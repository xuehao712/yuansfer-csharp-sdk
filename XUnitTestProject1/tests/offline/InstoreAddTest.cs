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
    public class InstoreAddTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        InstoreAddRequest request = new InstoreAddRequest();

        [Fact]
        public void Test1()
        {
            request.amount = "1.11";
            request.currency = "USD";
            request.settleCurrency = "USD";
            request.reference = "29755363011266977472";
            Version v = System.Environment.Version;
            string s = v.ToString();
            InstoreAddResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
