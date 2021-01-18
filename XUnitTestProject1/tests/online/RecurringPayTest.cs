using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using Yuansfer_SDK.src.client;
using Yuansfer_SDK.tests.common;
using Yuansfer_SDK.src.request.online;
using Yuansfer_SDK.src.response.online;
using Newtonsoft.Json.Linq;

namespace Yuansfer_SDK.tests.online
{
    public class RecurringPayTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        RecurringPayRequest request = new RecurringPayRequest();

        [Fact]
        public void Test1()
        {
            request.amount = "1.11";
            request.currency = "USD";
            request.settleCurrency = "USD";
            request.autoDebitNo = "298222562856331071";
            request.reference = "test2021010801";
            request.ipnUrl = "http://zk-tys.yunkeguan.com/ttest/test";

            RecurringPayResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
