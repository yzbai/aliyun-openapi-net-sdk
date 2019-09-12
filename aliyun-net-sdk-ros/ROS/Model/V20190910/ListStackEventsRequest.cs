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
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20190910;

namespace Aliyun.Acs.ROS.Model.V20190910
{
    public class ListStackEventsRequest : RpcAcsRequest<ListStackEventsResponse>
    {
        public ListStackEventsRequest()
            : base("ROS", "2019-09-10", "ListStackEvents", "ROS", "openAPI")
        {
        }

		private string stackId;

		private long? pageSize;

		private List<string> logicalResourceIds = new List<string>(){ };

		private List<string> resourceTypes = new List<string>(){ };

		private long? pageNumber;

		private List<string> statuss = new List<string>(){ };

		public string StackId
		{
			get
			{
				return stackId;
			}
			set	
			{
				stackId = value;
				DictionaryUtil.Add(QueryParameters, "StackId", value);
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public List<string> LogicalResourceIds
		{
			get
			{
				return logicalResourceIds;
			}

			set
			{
				logicalResourceIds = value;
				for (int i = 0; i < logicalResourceIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LogicalResourceId." + (i + 1) , logicalResourceIds[i]);
				}
			}
		}

		public List<string> ResourceTypes
		{
			get
			{
				return resourceTypes;
			}

			set
			{
				resourceTypes = value;
				for (int i = 0; i < resourceTypes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ResourceType." + (i + 1) , resourceTypes[i]);
				}
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public List<string> Statuss
		{
			get
			{
				return statuss;
			}

			set
			{
				statuss = value;
				for (int i = 0; i < statuss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Status." + (i + 1) , statuss[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListStackEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListStackEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}