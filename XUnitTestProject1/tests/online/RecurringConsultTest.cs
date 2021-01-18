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
    public class RecurringConsultTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        RecurringConsultRequest request = new RecurringConsultRequest();

        [Fact]
        public void Test1()
        {
            request.note = "Test for note";
            request.terminal = "APP";
            request.osType = "IOS";
            request.osVersion = "123";
            request.autoReference = "testAuth2021010801";
            request.autoIpnUrl = "http://zk-tys.yunkeguan.com/ttest/test";
            request.autoRedirectUrl = "http://zk-tys.yunkeguan.com/ttest/test2?status={status}";
            request.customerBelongsTo = "GCASH";
            RecurringConsultResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
