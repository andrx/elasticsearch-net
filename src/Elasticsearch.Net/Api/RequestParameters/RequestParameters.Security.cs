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

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.SecurityApi
{
	///<summary>Request options for Authenticate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-authenticate.html</para></summary>
	public class AuthenticateRequestParameters : RequestParameters<AuthenticateRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for ChangePassword <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-change-password.html</para></summary>
	public class ChangePasswordRequestParameters : RequestParameters<ChangePasswordRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for ClearCachedRealms <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-clear-cache.html</para></summary>
	public class ClearCachedRealmsRequestParameters : RequestParameters<ClearCachedRealmsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => false;
		///<summary>Comma-separated list of usernames to clear from the cache</summary>
		public string[] Usernames
		{
			get => Q<string[]>("usernames");
			set => Q("usernames", value);
		}
	}

	///<summary>Request options for ClearCachedRoles <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-clear-role-cache.html</para></summary>
	public class ClearCachedRolesRequestParameters : RequestParameters<ClearCachedRolesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for CreateApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-create-api-key.html</para></summary>
	public class CreateApiKeyRequestParameters : RequestParameters<CreateApiKeyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DeletePrivileges <para>TODO</para></summary>
	public class DeletePrivilegesRequestParameters : RequestParameters<DeletePrivilegesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DeleteRole <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-role.html</para></summary>
	public class DeleteRoleRequestParameters : RequestParameters<DeleteRoleRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DeleteRoleMapping <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-role-mapping.html</para></summary>
	public class DeleteRoleMappingRequestParameters : RequestParameters<DeleteRoleMappingRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DeleteUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-delete-user.html</para></summary>
	public class DeleteUserRequestParameters : RequestParameters<DeleteUserRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for DisableUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-disable-user.html</para></summary>
	public class DisableUserRequestParameters : RequestParameters<DisableUserRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => false;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for EnableUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-enable-user.html</para></summary>
	public class EnableUserRequestParameters : RequestParameters<EnableUserRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => false;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for GetApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-api-key.html</para></summary>
	public class GetApiKeyRequestParameters : RequestParameters<GetApiKeyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>API key id of the API key to be retrieved</summary>
		public string Id
		{
			get => Q<string>("id");
			set => Q("id", value);
		}

		///<summary>API key name of the API key to be retrieved</summary>
		public string Name
		{
			get => Q<string>("name");
			set => Q("name", value);
		}

		///<summary>realm name of the user who created this API key to be retrieved</summary>
		public string RealmName
		{
			get => Q<string>("realm_name");
			set => Q("realm_name", value);
		}

		///<summary>user name of the user who created this API key to be retrieved</summary>
		public string Username
		{
			get => Q<string>("username");
			set => Q("username", value);
		}
	}

	///<summary>Request options for GetPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-privileges.html</para></summary>
	public class GetPrivilegesRequestParameters : RequestParameters<GetPrivilegesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for GetRole <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-role.html</para></summary>
	public class GetRoleRequestParameters : RequestParameters<GetRoleRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for GetRoleMapping <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-role-mapping.html</para></summary>
	public class GetRoleMappingRequestParameters : RequestParameters<GetRoleMappingRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for GetUserAccessToken <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-token.html</para></summary>
	public class GetUserAccessTokenRequestParameters : RequestParameters<GetUserAccessTokenRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for GetUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-user.html</para></summary>
	public class GetUserRequestParameters : RequestParameters<GetUserRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for GetUserPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-get-privileges.html</para></summary>
	public class GetUserPrivilegesRequestParameters : RequestParameters<GetUserPrivilegesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for HasPrivileges <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-has-privileges.html</para></summary>
	public class HasPrivilegesRequestParameters : RequestParameters<HasPrivilegesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for InvalidateApiKey <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-invalidate-api-key.html</para></summary>
	public class InvalidateApiKeyRequestParameters : RequestParameters<InvalidateApiKeyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for InvalidateUserAccessToken <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-invalidate-token.html</para></summary>
	public class InvalidateUserAccessTokenRequestParameters : RequestParameters<InvalidateUserAccessTokenRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for PutPrivileges <para>TODO</para></summary>
	public class PutPrivilegesRequestParameters : RequestParameters<PutPrivilegesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for PutRole <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-role.html</para></summary>
	public class PutRoleRequestParameters : RequestParameters<PutRoleRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for PutRoleMapping <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-role-mapping.html</para></summary>
	public class PutRoleMappingRequestParameters : RequestParameters<PutRoleMappingRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for PutUser <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-put-user.html</para></summary>
	public class PutUserRequestParameters : RequestParameters<PutUserRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>
		/// If `true` (the default) then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh
		/// to make this operation visible to search, if `false` then do nothing with refreshes.
		///</summary>
		public Refresh? Refresh
		{
			get => Q<Refresh? >("refresh");
			set => Q("refresh", value);
		}
	}

	///<summary>Request options for GetCertificates <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/security-api-ssl.html</para></summary>
	public class GetCertificatesRequestParameters : RequestParameters<GetCertificatesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}
}