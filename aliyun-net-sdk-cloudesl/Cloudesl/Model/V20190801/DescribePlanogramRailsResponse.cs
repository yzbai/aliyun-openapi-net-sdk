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

namespace Aliyun.Acs.cloudesl.Model.V20190801
{
	public class DescribePlanogramRailsResponse : AcsResponse
	{

		private string dynamicMessage;

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private string message;

		private int? pageNumber;

		private string dynamicCode;

		private string storeId;

		private int? totalCount;

		private string code;

		private int? pageSize;

		private List<DescribePlanogramRails_PlanogramRailInfo> planogramRailInfos;

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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
			}
		}

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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
			}
		}

		public List<DescribePlanogramRails_PlanogramRailInfo> PlanogramRailInfos
		{
			get
			{
				return planogramRailInfos;
			}
			set	
			{
				planogramRailInfos = value;
			}
		}

		public class DescribePlanogramRails_PlanogramRailInfo
		{

			private string shelf;

			private string railCode;

			private string layer;

			private int? gapUnit;

			public string Shelf
			{
				get
				{
					return shelf;
				}
				set	
				{
					shelf = value;
				}
			}

			public string RailCode
			{
				get
				{
					return railCode;
				}
				set	
				{
					railCode = value;
				}
			}

			public string Layer
			{
				get
				{
					return layer;
				}
				set	
				{
					layer = value;
				}
			}

			public int? GapUnit
			{
				get
				{
					return gapUnit;
				}
				set	
				{
					gapUnit = value;
				}
			}
		}
	}
}
