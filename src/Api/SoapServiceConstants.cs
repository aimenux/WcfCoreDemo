namespace Api;

public static class SoapServiceConstants
{
    public static class Http
    {
        public const string Address = @"/SoapService/http";
        
        public static readonly BasicHttpBinding Binding = new BasicHttpBinding();
    }
    
    public static class Https
    {
        public const string Address = @"/SoapService/https";
        
        public static readonly WSHttpBinding Binding = CreateHttpsBinding();
        
        private static WSHttpBinding CreateHttpsBinding()
        {
            var binding = new WSHttpBinding(SecurityMode.Transport);
            binding.Security.Transport.ClientCredentialType= HttpClientCredentialType.None;
            return binding;
        }
    }
}