using System;
using System.Net.Http;
using System.Threading.Tasks;
using ConfigConsole.MsgEmailTool;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var me = new HttpTool();
            const string url = "http://msg.1yyg.com/api/email";
            var obj = new
            {
                PhoneNumber = "sample string 1",
                Message = "sample string 2",
                UserID = 3,
                MsgType = 4,
                DeviceType = 5
            };
            Task<HttpResponseMessage> aaa = me.SendAsync(url, obj);
            var bbb = aaa.Result.Content.ReadAsStringAsync();
            Console.WriteLine(bbb.Result.ToString());


            //-----------------------------------------------------------------


            const string msgurl = "http://msg.1yyg.com/api/Message";
            var msgObj = new
            {
                PhoneNumber = "sample string 1",
                Message = "sample string 2",
                UserID = 3,
                MsgType = 4,
                DeviceType = 5
            };
            Task<HttpResponseMessage> msgaaa = me.SendAsync(msgurl, msgObj);
            var msgbbb = aaa.Result.Content.ReadAsStringAsync();
            Console.WriteLine(msgbbb.Result.ToString());
        }
    }
}
