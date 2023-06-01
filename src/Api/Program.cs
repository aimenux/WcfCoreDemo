using Api;
using static SoapServiceEndpoints;

var builder = WebApplication.CreateBuilder();

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();
builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();

var app = builder.Build();

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<SoapService>();
    serviceBuilder.AddServiceEndpoint<SoapService, ISoapService>(Http.Binding, Http.Address);
    serviceBuilder.AddServiceEndpoint<SoapService, ISoapService>(Https.Binding, Https.Address);
    var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpsGetEnabled = true;
});

app.Run();