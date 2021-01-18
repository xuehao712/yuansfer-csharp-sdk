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
    public class RecurringRevokeTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        RecurringRevokeRequest request = new RecurringRevokeRequest();

        [Fact]
        public void Test1()
        {
            request.autoDebitNo = "298217806906830305";

            RecurringRevokeResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
