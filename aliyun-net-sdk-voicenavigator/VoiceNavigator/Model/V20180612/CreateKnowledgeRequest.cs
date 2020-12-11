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
using Aliyun.Acs.VoiceNavigator.Transform;
using Aliyun.Acs.VoiceNavigator.Transform.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
    public class CreateKnowledgeRequest : RpcAcsRequest<CreateKnowledgeResponse>
    {
        public CreateKnowledgeRequest()
            : base("VoiceNavigator", "2018-06-12", "CreateKnowledge", "voicebot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string userUtterance;

		private bool? interruptible;

		private string instanceId;

		private string answer;

		private List<string> similarUtterancess = new List<string>(){ };

		private string categoryId;

		public string UserUtterance
		{
			get
			{
				return userUtterance;
			}
			set	
			{
				userUtterance = value;
				DictionaryUtil.Add(QueryParameters, "UserUtterance", value);
			}
		}

		public bool? Interruptible
		{
			get
			{
				return interruptible;
			}
			set	
			{
				interruptible = value;
				DictionaryUtil.Add(QueryParameters, "Interruptible", value.ToString());
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string Answer
		{
			get
			{
				return answer;
			}
			set	
			{
				answer = value;
				DictionaryUtil.Add(QueryParameters, "Answer", value);
			}
		}

		public List<string> SimilarUtterancess
		{
			get
			{
				return similarUtterancess;
			}

			set
			{
				similarUtterancess = value;
				for (int i = 0; i < similarUtterancess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SimilarUtterances." + (i + 1) , similarUtterancess[i]);
				}
			}
		}

		public string CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
				DictionaryUtil.Add(QueryParameters, "CategoryId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateKnowledgeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateKnowledgeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
