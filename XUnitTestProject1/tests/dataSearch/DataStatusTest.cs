﻿using System;
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
    public class DataStatusTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        DataStatusRequest request = new DataStatusRequest();

        [Fact]
        public void Test1()
        {
            string paymentDate = DateTime.Now.ToString("yyyyMMdd");
            request.paymentDate = paymentDate;

            DataStatusResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
