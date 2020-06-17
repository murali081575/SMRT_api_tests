using Smrt_api.EndPoints;
using HRBlock.CTF;
using HRBlock.CTF.API;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Smrt_api.Tests
{
   public class Health_check
    {
        [APITest, Scope("CBSQA")]

        public void GetHealthcheck(IAPIDriver driver)
        {
            var endPoint = driver.EndPoint<GetHealthcheckEndpoint>();
            driver.Action.Get("/healthcheck");
            endPoint.Response.Status.Expect.Equals(HttpStatusCode.OK);
        }
    }
}
