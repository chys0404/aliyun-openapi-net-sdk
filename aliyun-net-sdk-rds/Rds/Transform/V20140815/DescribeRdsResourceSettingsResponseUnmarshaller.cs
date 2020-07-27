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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeRdsResourceSettingsResponseUnmarshaller
    {
        public static DescribeRdsResourceSettingsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRdsResourceSettingsResponse describeRdsResourceSettingsResponse = new DescribeRdsResourceSettingsResponse();

			describeRdsResourceSettingsResponse.HttpResponse = context.HttpResponse;
			describeRdsResourceSettingsResponse.RequestId = context.StringValue("DescribeRdsResourceSettings.RequestId");

			List<DescribeRdsResourceSettingsResponse.DescribeRdsResourceSettings_RdsInstanceResourceSetting> describeRdsResourceSettingsResponse_rdsInstanceResourceSettings = new List<DescribeRdsResourceSettingsResponse.DescribeRdsResourceSettings_RdsInstanceResourceSetting>();
			for (int i = 0; i < context.Length("DescribeRdsResourceSettings.RdsInstanceResourceSettings.Length"); i++) {
				DescribeRdsResourceSettingsResponse.DescribeRdsResourceSettings_RdsInstanceResourceSetting rdsInstanceResourceSetting = new DescribeRdsResourceSettingsResponse.DescribeRdsResourceSettings_RdsInstanceResourceSetting();
				rdsInstanceResourceSetting.StartDate = context.StringValue("DescribeRdsResourceSettings.RdsInstanceResourceSettings["+ i +"].StartDate");
				rdsInstanceResourceSetting.EndDate = context.StringValue("DescribeRdsResourceSettings.RdsInstanceResourceSettings["+ i +"].EndDate");
				rdsInstanceResourceSetting.ResourceNiche = context.StringValue("DescribeRdsResourceSettings.RdsInstanceResourceSettings["+ i +"].ResourceNiche");
				rdsInstanceResourceSetting.NoticeBarContent = context.StringValue("DescribeRdsResourceSettings.RdsInstanceResourceSettings["+ i +"].NoticeBarContent");
				rdsInstanceResourceSetting.PoppedUpButtonText = context.StringValue("DescribeRdsResourceSettings.RdsInstanceResourceSettings["+ i +"].PoppedUpButtonText");
				rdsInstanceResourceSetting.PoppedUpButtonType = context.StringValue("DescribeRdsResourceSettings.RdsInstanceResourceSettings["+ i +"].PoppedUpButtonType");
				rdsInstanceResourceSetting.PoppedUpButtonUrl = context.StringValue("DescribeRdsResourceSettings.RdsInstanceResourceSettings["+ i +"].PoppedUpButtonUrl");
				rdsInstanceResourceSetting.PoppedUpContent = context.StringValue("DescribeRdsResourceSettings.RdsInstanceResourceSettings["+ i +"].PoppedUpContent");

				describeRdsResourceSettingsResponse_rdsInstanceResourceSettings.Add(rdsInstanceResourceSetting);
			}
			describeRdsResourceSettingsResponse.RdsInstanceResourceSettings = describeRdsResourceSettingsResponse_rdsInstanceResourceSettings;
        
			return describeRdsResourceSettingsResponse;
        }
    }
}
