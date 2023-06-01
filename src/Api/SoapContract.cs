namespace Api;

[DataContract]
public class SoapContract
{
    [DataMember]
    public int IntValue { get; set; }

    [DataMember]
    public string StringValue { get; set; }
}