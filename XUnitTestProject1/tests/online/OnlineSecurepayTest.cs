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
    public class OnlineSecurepayTest
    {
        YuanpayClient client = new YuanpayV3Client(InitYuanpayConfig.initMerchantConfig());

        JArray goods = new JArray();
        JObject item = new JObject();

        OnlineSecurepayRequest request = new OnlineSecurepayRequest();

        [Fact]
        public void Test1()
        {
            request.amount = "1.11";
            request.currency = "USD";
            request.settleCurrency = "USD";
            request.vendor = "alipay";
            request.terminal = "ONLINE";
            request.reference = "2975536302669774733";
            request.ipnUrl = "http://zk-tys.yunkeguan.com/ttest/test";
            request.callbackUrl = "http://zk-tys.yunkeguan.com/ttest/test2?status={status}";
            request.description = "Test for description";
            request.note = "Test for note";
            item.Add("goods_name", "name1");
            item.Add("quantity", "1");
            goods.Add(item);
            request.goodsInfo = goods.ToString();

            OnlineSecurepayResponse response = client.execute(request);
            Assert.Equal("000100", response.retCode);
        }
    }
}
