using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SW.SDK.Services.IssuerJson;
using SW.SDK.Services.Authentication;
using UT_SW.SDK.Helpers;


namespace UT_SWSDK20
{
    /// <summary>
    /// Summary description for UT_SWSDK20
    /// </summary>
    [TestClass]
    public class UT_SWSDK20
    {
        public UT_SWSDK20()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private static BuildSettings Build;

        #region Additional test attributes
        [ClassInitialize()]
        public static void UT_Service_Validation_Initialize(TestContext testContext)
        {
            Build = new BuildSettings();
        }
        #endregion
        [TestMethod]
        public void TestMethod_Authenticate()
        {
            Authentication auth = new Authentication(Build.Url, Build.User, Build.Password + "1");
            AuthResponse response = auth.GetToken();
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void TestMethod_IssuerJson()
        {
            Console.WriteLine(Build.Json);
            IssuerJson issuerJson = new IssuerJson("http://services.test.sw.com.mx", "demo", "123456789");
            var response = (IssuerJsonResponseV4)issuerJson.EmisionTimbradoJsonV4(Build.Json);
            Assert.IsTrue(response.message == "307. El comprobante contiene un timbre previo.");
        }
        /*
        [TestMethod]
        public void TestMethod_Pdf()
        {
            Console.WriteLine(Build.Json);
            IssuerJson issuerJson = new IssuerJson("http://services.test.sw.com.mx", "demo", "123456789");
            var response = (IssuerJsonResponseV4)issuerJson.EmisionTimbradoJsonV4(Build.Json);
            Assert.IsTrue(response.message == "307. El comprobante contiene un timbre previo.");
        }
        */
    }
}
