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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class ListNodesRequest : RpcAcsRequest<ListNodesResponse>
    {
        public ListNodesRequest()
            : base("dataworks-public", "2020-05-18", "ListNodes")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string owner;

		private string projectEnv;

		private string bizName;

		private int? pageNumber;

		private string nodeName;

		private string programType;

		private int? pageSize;

		private long? projectId;

		public string Owner
		{
			get
			{
				return owner;
			}
			set	
			{
				owner = value;
				DictionaryUtil.Add(BodyParameters, "Owner", value);
			}
		}

		public string ProjectEnv
		{
			get
			{
				return projectEnv;
			}
			set	
			{
				projectEnv = value;
				DictionaryUtil.Add(BodyParameters, "ProjectEnv", value);
			}
		}

		public string BizName
		{
			get
			{
				return bizName;
			}
			set	
			{
				bizName = value;
				DictionaryUtil.Add(BodyParameters, "BizName", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public string NodeName
		{
			get
			{
				return nodeName;
			}
			set	
			{
				nodeName = value;
				DictionaryUtil.Add(BodyParameters, "NodeName", value);
			}
		}

		public string ProgramType
		{
			get
			{
				return programType;
			}
			set	
			{
				programType = value;
				DictionaryUtil.Add(BodyParameters, "ProgramType", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListNodesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListNodesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
