// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.IndexLifecycleManagementApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface IDeleteLifecycleRequest : IRequest<DeleteLifecycleRequestParameters>
	{
		[IgnoreDataMember]
		Id PolicyId
		{
			get;
		}
	}

	///<summary>Request for DeleteLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-delete-lifecycle.html</para></summary>
	public partial class DeleteLifecycleRequest : PlainRequestBase<DeleteLifecycleRequestParameters>, IDeleteLifecycleRequest
	{
		protected IDeleteLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementDeleteLifecycle;
		///<summary>/_ilm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public DeleteLifecycleRequest(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteLifecycleRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IDeleteLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IExplainLifecycleRequest : IRequest<ExplainLifecycleRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}
	}

	///<summary>Request for ExplainLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-explain-lifecycle.html</para></summary>
	public partial class ExplainLifecycleRequest : PlainRequestBase<ExplainLifecycleRequestParameters>, IExplainLifecycleRequest
	{
		protected IExplainLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementExplainLifecycle;
		///<summary>/{index}/_ilm/explain</summary>
		///<param name = "index">this parameter is required</param>
		public ExplainLifecycleRequest(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ExplainLifecycleRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName IExplainLifecycleRequest.Index => Self.RouteValues.Get<IndexName>("index");
		// Request parameters
		///<summary>filters the indices included in the response to ones in an ILM error state, implies only_managed</summary>
		public bool? OnlyErrors
		{
			get => Q<bool? >("only_errors");
			set => Q("only_errors", value);
		}

		///<summary>filters the indices included in the response to ones managed by ILM</summary>
		public bool? OnlyManaged
		{
			get => Q<bool? >("only_managed");
			set => Q("only_managed", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetLifecycleRequest : IRequest<GetLifecycleRequestParameters>
	{
		[IgnoreDataMember]
		Id PolicyId
		{
			get;
		}
	}

	///<summary>Request for GetLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-lifecycle.html</para></summary>
	public partial class GetLifecycleRequest : PlainRequestBase<GetLifecycleRequestParameters>, IGetLifecycleRequest
	{
		protected IGetLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetLifecycle;
		///<summary>/_ilm/policy/{policy_id}</summary>
		///<param name = "policyId">Optional, accepts null</param>
		public GetLifecycleRequest(Id policyId): base(r => r.Optional("policy_id", policyId))
		{
		}

		///<summary>/_ilm/policy</summary>
		public GetLifecycleRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IGetLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IGetIlmStatusRequest : IRequest<GetIlmStatusRequestParameters>
	{
	}

	///<summary>Request for GetStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-status.html</para></summary>
	public partial class GetIlmStatusRequest : PlainRequestBase<GetIlmStatusRequestParameters>, IGetIlmStatusRequest
	{
		protected IGetIlmStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetStatus;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IMoveToStepRequest : IRequest<MoveToStepRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}
	}

	///<summary>Request for MoveToStep <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-move-to-step.html</para></summary>
	public partial class MoveToStepRequest : PlainRequestBase<MoveToStepRequestParameters>, IMoveToStepRequest
	{
		protected IMoveToStepRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementMoveToStep;
		///<summary>/_ilm/move/{index}</summary>
		///<param name = "index">this parameter is required</param>
		public MoveToStepRequest(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected MoveToStepRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName IMoveToStepRequest.Index => Self.RouteValues.Get<IndexName>("index");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IPutLifecycleRequest : IRequest<PutLifecycleRequestParameters>
	{
		[IgnoreDataMember]
		Id PolicyId
		{
			get;
		}
	}

	///<summary>Request for PutLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-put-lifecycle.html</para></summary>
	public partial class PutLifecycleRequest : PlainRequestBase<PutLifecycleRequestParameters>, IPutLifecycleRequest
	{
		protected IPutLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementPutLifecycle;
		///<summary>/_ilm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public PutLifecycleRequest(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutLifecycleRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IPutLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IRemovePolicyRequest : IRequest<RemovePolicyRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}
	}

	///<summary>Request for RemovePolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-remove-policy.html</para></summary>
	public partial class RemovePolicyRequest : PlainRequestBase<RemovePolicyRequestParameters>, IRemovePolicyRequest
	{
		protected IRemovePolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRemovePolicy;
		///<summary>/{index}/_ilm/remove</summary>
		///<param name = "index">this parameter is required</param>
		public RemovePolicyRequest(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected RemovePolicyRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName IRemovePolicyRequest.Index => Self.RouteValues.Get<IndexName>("index");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IRetryIlmRequest : IRequest<RetryIlmRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}
	}

	///<summary>Request for Retry <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-retry-policy.html</para></summary>
	public partial class RetryIlmRequest : PlainRequestBase<RetryIlmRequestParameters>, IRetryIlmRequest
	{
		protected IRetryIlmRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRetry;
		///<summary>/{index}/_ilm/retry</summary>
		///<param name = "index">this parameter is required</param>
		public RetryIlmRequest(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected RetryIlmRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName IRetryIlmRequest.Index => Self.RouteValues.Get<IndexName>("index");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IStartIlmRequest : IRequest<StartIlmRequestParameters>
	{
	}

	///<summary>Request for Start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-start.html</para></summary>
	public partial class StartIlmRequest : PlainRequestBase<StartIlmRequestParameters>, IStartIlmRequest
	{
		protected IStartIlmRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStart;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IStopIlmRequest : IRequest<StopIlmRequestParameters>
	{
	}

	///<summary>Request for Stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-stop.html</para></summary>
	public partial class StopIlmRequest : PlainRequestBase<StopIlmRequestParameters>, IStopIlmRequest
	{
		protected IStopIlmRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStop;
	// values part of the url path
	// Request parameters
	}
}