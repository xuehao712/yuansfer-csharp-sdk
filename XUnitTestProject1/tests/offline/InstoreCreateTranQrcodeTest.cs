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
    public class InstoreCreateTranQrcodeTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        InstoreCreateTranQrcodeRequest request = new InstoreCreateTranQrcodeRequest();

        [Fact]
        public void Test1()
        {
            request.amount = "1.11";
            request.currency = "USD";
            request.settleCurrency = "USD";
            request.vendor = "alipay";
            request.reference = "297553630266977474";
            request.ipnUrl = "http://zk-tys.yunkeguan.com/ttest/test";

            InstoreCreateTranQrcodeResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
