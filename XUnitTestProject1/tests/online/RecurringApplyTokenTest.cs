using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using Yuansfer_SDK.src.client;
using Yuansfer_SDK.tests.common;
using Yuansfer_SDK.src.request.online;
using Yuansfer_SDK.src.response.online;
using Newtonsoft.Json.Linq;
using Yuansfer_SDK.src.config;
using Yuansfer_SDK.src.enums;

namespace Yuansfer_SDK.tests.online
{
    public class RecurringApplyTokenTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        RecurringApplyTokenRequest request = new RecurringApplyTokenRequest();

        [Fact]
        public void Test1()
        {
            request.autoDebitNo = "298222562856331071";
            request.grantType = "AUTHORIZATION_CODE";
            RecurringApplyTokenResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }

    }
}
