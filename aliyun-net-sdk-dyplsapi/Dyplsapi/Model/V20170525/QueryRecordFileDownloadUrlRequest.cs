/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dyplsapi.Transform;
using Aliyun.Acs.Dyplsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
    public class QueryRecordFileDownloadUrlRequest : RpcAcsRequest<QueryRecordFileDownloadUrlResponse>
    {
        public QueryRecordFileDownloadUrlRequest()
            : base("Dyplsapi", "2017-05-25", "QueryRecordFileDownloadUrl", "dypls", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string callId;

		private long? resourceOwnerId;

		private string productType;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string callTime;

		private string poolKey;

		public string CallId
		{
			get
			{
				return callId;
			}
			set	
			{
				callId = value;
				DictionaryUtil.Add(QueryParameters, "CallId", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string CallTime
		{
			get
			{
				return callTime;
			}
			set	
			{
				callTime = value;
				DictionaryUtil.Add(QueryParameters, "CallTime", value);
			}
		}

		public string PoolKey
		{
			get
			{
				return poolKey;
			}
			set	
			{
				poolKey = value;
				DictionaryUtil.Add(QueryParameters, "PoolKey", value);
			}
		}

        public override QueryRecordFileDownloadUrlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryRecordFileDownloadUrlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
