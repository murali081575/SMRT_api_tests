using Smrt_api.EndPoints;
using HRBlock.CTF;
using HRBlock.CTF.API;
using System;
using System.Net;

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
            driver.Action.Get("/api/healthcheck");
            endPoint.Response.Status.Expect.Equals(HttpStatusCode.OK);
            driver.Action.Get("/api/DLiaB");
            Console.WriteLine(endPoint.Response);
            endPoint.Response.Status.Expect.Equals(HttpStatusCode.OK);
        }
        [APITest, Scope("CBSQA")]
        public void Getcodegen(IAPIDriver driver)
        {
            var endPoint = driver.EndPoint<GetHealthcheckEndpoint>();
            driver.Action.Get("/CodeGenerator");
            endPoint.Response.Status.Expect.Equals(HttpStatusCode.OK);
            endPoint.Response.Status.Expect.GreaterThan(0);
        }
        [APITest, Scope("CBSQA")]
        public void Get_IP(IAPIDriver driver)
        {
            var endPoint = driver.EndPoint<GetHealthcheckEndpoint>();
            driver.Action.Get("api/IP");
            endPoint.Response.Status.Expect.Equals(HttpStatusCode.OK);
            endPoint.Response.Status.Expect.GreaterThan(0);
            driver.Action.Get("/IP");
            endPoint.Response.Status.Expect.Equals(HttpStatusCode.OK);
            endPoint.Response.Status.Expect.GreaterThan(0);
        }
        [APITest, Scope("CBSQA")]
        public void Get_Weather(IAPIDriver driver)
        {
            var endPoint = driver.EndPoint<GetHealthcheckEndpoint>();
            driver.Action.Get("/WeatherForecast");
            endPoint.Response.Status.Expect.Equals(HttpStatusCode.OK);
            endPoint.Response.Status.Expect.GreaterThan(0);
        }
    }
}
