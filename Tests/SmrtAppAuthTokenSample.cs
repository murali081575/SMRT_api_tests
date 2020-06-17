using Smrt_api.EndPoints;
using HRBlock.CTF;
using HRBlock.CTF.API;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Smrt_api.Tests
{
    public class SmrtAppAuthTokenSample
    {
        [APITest, Scope("SmrtApp")]
        public void SmrtAppAuthTokenSample1(IAPIDriver driver, IStateBag statebag)
        {
            var endPoint = driver.EndPoint<SmrtAppEndpoint>();
            var oAuthToken = statebag.Get<string>("OAuthToken");
            driver.Action.Get("/.auth/me");
            statebag.Set<string>("ChainedAuthorizationToken", endPoint.Response.AuthorizationToken.Value);
            endPoint.Response.Status.Expect.Equals(HttpStatusCode.OK);
        }
    }
}