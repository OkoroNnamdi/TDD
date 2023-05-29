using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cloudcustomer.UnitTests.Helpers
{
    internal static  class HttpMockMessageHandler<T>
    {
        internal static Mock<HttpMessageHandler> SetUpBasicResourceList(List<T> expectedResponse)
        {
            var mockResponse = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(JsonConvert.SerializeObject(expectedResponse))
            };
            mockResponse.Content.Headers.ContentType =
                new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"); 
            var handlerMock = new Mock<HttpMessageHandler>();
            handlerMock.Protected().Setup<Task<HttpResponseMessage>>(
                
                "SendAsync",
                ItExpr.IsAny<HttpResponseMessage>(),
                ItExpr .IsAny<CancellationToken>())
                .ReturnsAsync (mockResponse);
            return handlerMock;
       
        }
    }
}
