using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Virtual.Providers;

namespace Elasticsearch.Net.Virtual
{
	public class VirtualizedCluster
	{
		private readonly FixedPipelineFactory _fixedRequestPipeline;
		private readonly TestableDateTimeProvider _dateTimeProvider;
		private readonly ConnectionConfiguration _settings;
		private Func<IElasticLowLevelClient, Func<RequestConfigurationDescriptor, IRequestConfiguration>, Task<IElasticsearchResponse>> _asyncCall;
		private Func<IElasticLowLevelClient, Func<RequestConfigurationDescriptor, IRequestConfiguration>, IElasticsearchResponse> _syncCall;
		
		private class VirtualResponse : ElasticsearchResponseBase { }

		public VirtualizedCluster(TestableDateTimeProvider dateTimeProvider, ConnectionConfiguration settings)
		{
			_dateTimeProvider = dateTimeProvider;
			_settings = settings;
			_fixedRequestPipeline = new FixedPipelineFactory(settings, _dateTimeProvider);

			_syncCall = (c, r) => c.Search<VirtualResponse>(PostData.Serializable(new {}), new SearchRequestParameters
			{
					RequestConfiguration = r?.Invoke(new RequestConfigurationDescriptor(null))
			});
			_asyncCall = async (c, r) =>
			{
				var res = await c.SearchAsync<VirtualResponse>
				(
					PostData.Serializable(new { }),
					new SearchRequestParameters { RequestConfiguration = r?.Invoke(new RequestConfigurationDescriptor(null)) },
					CancellationToken.None
				).ConfigureAwait(false);
				return (IElasticsearchResponse)res;
			};
		}

		public IConnectionPool ConnectionPool => Client.Settings.ConnectionPool;
		private ElasticLowLevelClient Client => _fixedRequestPipeline?.Client;

		public VirtualizedCluster ClientProxiesTo(
			Func<IElasticLowLevelClient, Func<RequestConfigurationDescriptor, IRequestConfiguration>, IElasticsearchResponse> sync,
			Func<IElasticLowLevelClient, Func<RequestConfigurationDescriptor, IRequestConfiguration>, Task<IElasticsearchResponse>> async
		)
		{
			_syncCall = sync;
			_asyncCall = async;
			return this;
		}

		public IElasticsearchResponse ClientCall(Func<RequestConfigurationDescriptor, IRequestConfiguration> requestOverrides = null) =>
			_syncCall(Client, requestOverrides);

		public async Task<IElasticsearchResponse> ClientCallAsync(Func<RequestConfigurationDescriptor, IRequestConfiguration> requestOverrides = null) =>
			await _asyncCall(Client, requestOverrides).ConfigureAwait(false);

		public void ChangeTime(Func<DateTime, DateTime> change) => _dateTimeProvider.ChangeTime(change);

		public void ClientThrows(bool throws) => _settings.ThrowExceptions(throws);
	}
}
