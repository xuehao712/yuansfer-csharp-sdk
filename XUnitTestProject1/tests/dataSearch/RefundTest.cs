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
    public class RefundTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        RefundRequest request = new RefundRequest();

        [Fact]
        public void Test1()
        {
            request.refundAmount = "1.11";
            request.currency = "USD";
            request.settleCurrency = "USD";
            request.reference = "297553630266977470";

            RefundResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
