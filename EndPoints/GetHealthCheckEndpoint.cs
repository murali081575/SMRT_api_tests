using HRBlock.CTF.API;

namespace Smrt_api.EndPoints
{
    [APIScope("CBSQA")]
    [Compatible(HttpAction.Get, endPoint: "")]
    class GetHealthcheckEndpoint : ApplicationService<EmptyEndPointRequest, EmptyEndPointResponse>
    {
    }
}
