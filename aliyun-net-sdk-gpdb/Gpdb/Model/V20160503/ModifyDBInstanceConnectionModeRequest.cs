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
using Aliyun.Acs.gpdb.Transform;
using Aliyun.Acs.gpdb.Transform.V20160503;

namespace Aliyun.Acs.gpdb.Model.V20160503
{
    public class ModifyDBInstanceConnectionModeRequest : RpcAcsRequest<ModifyDBInstanceConnectionModeResponse>
    {
        public ModifyDBInstanceConnectionModeRequest()
            : base("gpdb", "2016-05-03", "ModifyDBInstanceConnectionMode", "gpdb", "openAPI")
        {
        }

		private string connectionMode;

		private string dBInstanceId;

		private string accessKeyId;

		public string ConnectionMode
		{
			get
			{
				return connectionMode;
			}
			set	
			{
				connectionMode = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionMode", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override ModifyDBInstanceConnectionModeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBInstanceConnectionModeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}