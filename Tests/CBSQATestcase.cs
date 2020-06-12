using Hari_demo.EndPoints;
using HRBlock.CTF;
using HRBlock.CTF.API;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Hari_demo.Tests
{
    public class CBSQATestcase
    {
        [APITest, Scope("CBSQA")]

        public void GetUserDetails(IAPIDriver driver)
        {
            var endPoint = driver.EndPoint<GetHealthcheckEndpoint>();
          //  var office = "29594";
         //   var ssoID = "132654";
            driver.Action.Get("/codegenerator");
            endPoint.Response.Status.Expect.Equals(HttpStatusCode.OK);
            endPoint.Response.Status.Expect.GreaterThan(0);
        }
    }
}
