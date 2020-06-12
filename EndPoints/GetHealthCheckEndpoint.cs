using HRBlock.CTF.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hari_demo.EndPoints
{
    [APIScope("CBSQA")]
    [Compatible(HttpAction.Get, endPoint: "")]
    class GetHealthcheckEndpoint : ApplicationService<EmptyEndPointRequest, EmptyEndPointResponse>
    {
    }
}
