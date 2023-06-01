namespace Api;

[ServiceContract]
public interface ISoapService
{
    [OperationContract]
    string GetHelloMessage();

    [OperationContract]
    SoapContract GetRandomContract();
}
    
public class SoapService : ISoapService
{
    public string GetHelloMessage()
    {
        return $"Hello {Guid.NewGuid():N}";
    }

    public SoapContract GetRandomContract()
    {
        var intValue = Random.Shared.Next(1, 100);
        var stringValue = RandomString(intValue);
        return new SoapContract
        {
            IntValue = intValue,
            StringValue = stringValue
        };
    }

    private static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var charsArray = Enumerable.Repeat(chars, length)
            .Select(s => s[Random.Shared.Next(s.Length)])
            .ToArray();
        return new string(charsArray);
    }
}