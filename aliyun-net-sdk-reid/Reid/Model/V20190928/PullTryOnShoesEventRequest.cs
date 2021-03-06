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
using Aliyun.Acs.reid.Transform;
using Aliyun.Acs.reid.Transform.V20190928;

namespace Aliyun.Acs.reid.Model.V20190928
{
    public class PullTryOnShoesEventRequest : RpcAcsRequest<PullTryOnShoesEventResponse>
    {
        public PullTryOnShoesEventRequest()
            : base("reid", "2019-09-28", "PullTryOnShoesEvent", "1.1.8", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string date;

		private long? storeId;

		private int? pageNumber;

		private int? pageSize;

		private string name;

		private string skuId;

		public string Date
		{
			get
			{
				return date;
			}
			set	
			{
				date = value;
				DictionaryUtil.Add(BodyParameters, "Date", value);
			}
		}

		public long? StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value.ToString());
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string SkuId
		{
			get
			{
				return skuId;
			}
			set	
			{
				skuId = value;
				DictionaryUtil.Add(BodyParameters, "SkuId", value);
			}
		}

        public override PullTryOnShoesEventResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PullTryOnShoesEventResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
