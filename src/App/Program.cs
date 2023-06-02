using System;
using App;
using App.SoapService;
using static App.SoapServiceConstants;

await using var client = new SoapServiceClient(Https.Configuration, Https.Address);

var soapLogger = new SoapLogger();
var soapInspector = new SoapLoggingClientMessageInspector(soapLogger);
var soapBehaviour = new SoapLoggingBehaviour(soapInspector);
client.Endpoint.EndpointBehaviors.Add(soapBehaviour);

var message = await client.GetHelloMessageAsync();
Console.WriteLine($"Message = {message}");

var contract = await client.GetRandomContractAsync();
Console.WriteLine($"Contract = {contract.StringValue}");

Console.WriteLine("Press any key to exit program !");
Console.ReadKey();