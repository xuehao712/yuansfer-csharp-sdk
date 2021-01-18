using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using Yuansfer_SDK.src.client;
using Yuansfer_SDK.tests.common;
using Yuansfer_SDK.src.request.dataSearch;
using Yuansfer_SDK.src.response.dataSearch;
using Newtonsoft.Json.Linq;

namespace Yuansfer_SDK.tests.dataSearch
{
    public class TransListTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        TransListRequest request = new TransListRequest();

        [Fact]
        public void Test1()
        {
            
            request.endDate = DateTime.Now.ToString("yyyyMMdd");
            request.startDate = DateTime.Now.AddDays(-14).ToString("yyyyMMdd");

            TransListResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
