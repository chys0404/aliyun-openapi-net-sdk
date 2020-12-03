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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class CreateQualityRelativeNodeResponseUnmarshaller
    {
        public static CreateQualityRelativeNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateQualityRelativeNodeResponse createQualityRelativeNodeResponse = new CreateQualityRelativeNodeResponse();

			createQualityRelativeNodeResponse.HttpResponse = _ctx.HttpResponse;
			createQualityRelativeNodeResponse.Success = _ctx.BooleanValue("CreateQualityRelativeNode.Success");
			createQualityRelativeNodeResponse.ErrorCode = _ctx.StringValue("CreateQualityRelativeNode.ErrorCode");
			createQualityRelativeNodeResponse.ErrorMessage = _ctx.StringValue("CreateQualityRelativeNode.ErrorMessage");
			createQualityRelativeNodeResponse.HttpStatusCode = _ctx.IntegerValue("CreateQualityRelativeNode.HttpStatusCode");
			createQualityRelativeNodeResponse.Data = _ctx.BooleanValue("CreateQualityRelativeNode.Data");
			createQualityRelativeNodeResponse.RequestId = _ctx.StringValue("CreateQualityRelativeNode.RequestId");
        
			return createQualityRelativeNodeResponse;
        }
    }
}
