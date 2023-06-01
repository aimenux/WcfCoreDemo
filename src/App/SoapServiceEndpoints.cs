using SoapEndpointConfiguration = App.SoapService.SoapServiceClient.EndpointConfiguration;

public static class SoapServiceEndpoints
{
    public static class Http
    {
        public const string Address = @"http://localhost:5000/SoapService/http";

        public static readonly SoapEndpointConfiguration Configuration = SoapEndpointConfiguration.BasicHttpBinding_ISoapService;
    }
    
    public static class Https
    {
        public const string Address = @"https://localhost:5001/SoapService/https";

        public static readonly SoapEndpointConfiguration Configuration = SoapEndpointConfiguration.WSHttpBinding_ISoapService;
    }
}