using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using Yuansfer_SDK.src.client;
using Yuansfer_SDK.tests.common;
using Yuansfer_SDK.src.request.mobile;
using Yuansfer_SDK.src.response.mobile;
using Newtonsoft.Json.Linq;

namespace Yuansfer_SDK.tests.mobile
{
    public class MobilePrepayTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        MobilePrepayRequest request = new MobilePrepayRequest();

        [Fact]
        public void Test1()
        {
            request.amount = "1.11";
            request.currency = "USD";
            request.settleCurrency = "USD";
            request.vendor = "alipay";
            request.terminal = "APP";
            request.reference = "297553630266977470";
            request.ipnUrl = "http://zk-tys.yunkeguan.com/ttest/test";
            request.description = "Test for description";
            request.note = "Test for note";

            MobilePrepayResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
