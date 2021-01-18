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
    public class CancelTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        CancelRequest request = new CancelRequest();

        [Fact]
        public void Test1()
        {
            request.reference = "297553630266977469";

            CancelResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
