using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using Yuansfer_SDK.src.client;
using Yuansfer_SDK.tests.common;
using Yuansfer_SDK.src.request.offline;
using Yuansfer_SDK.src.response.offline;
using Newtonsoft.Json.Linq;

namespace Yuansfer_SDK.tests.offline
{
    public class InstorePayTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        InstorePayRequest request = new InstorePayRequest();

        [Fact]
        public void Test1()
        {
            request.reference = "297553630266977474";
            request.paymentBarcode = "123456789";
            request.vendor = "alipay";

            InstorePayResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
