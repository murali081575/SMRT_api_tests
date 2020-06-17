using HRBlock.CTF.API;
using HRBlock.CTF.Expectations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smrt_api.EndPoints
{
    [APIScope(name: "SmrtApp")]
    [Compatible(HttpAction.Get, endPoint: "/.auth/me")]
   public class SmrtAppEndpoint : ApplicationService<SmrtAppRequest, SmrtAppResponse>
    {
    }
    public class SmrtAppData
    {
        public string OAuth2Token { get; set; }
    }
    public class SmrtAppRequest : JsonEndPointRequest<SmrtAppData>
    {
        public string OAuth2Token
        {
            get => InnerBody.Body.OAuth2Token;
            set => InnerBody.Body.OAuth2Token = value;
        }
    }
    public class SmrtAppResponse : JsonEndPointResponse
    {
        public StringExpect AuthorizationToken => GetValue <string>("$[0].access_token");

      
    }
  }
