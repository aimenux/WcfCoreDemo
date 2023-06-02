using SoapEndpointConfiguration = App.SoapService.SoapServiceClient.EndpointConfiguration;

namespace App;

public static class SoapServiceConstants
{
    public static class Http
    {
        public const string Address = @"http://localhost:5000/SoapService/http";

        public const SoapEndpointConfiguration Configuration = SoapEndpointConfiguration.BasicHttpBinding_ISoapService;
    }
    
    public static class Https
    {
        public const string Address = @"https://localhost:5001/SoapService/https";

        public const SoapEndpointConfiguration Configuration = SoapEndpointConfiguration.WSHttpBinding_ISoapService;
    }
}