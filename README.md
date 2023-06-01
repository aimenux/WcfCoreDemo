[![.NET](https://github.com/aimenux/WcfCoreDemo/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/aimenux/WcfCoreDemo/actions/workflows/ci.yml)

# WcfCoreDemo
```
Playing with WcfCore
```

In this repo, i m using two projects :
- `Api` : a soap web service based on [WcfCore](https://github.com/CoreWCF/CoreWCF) library
- `App` : a console app to consume the soap web service 

The `Api` soap web service expose two urls :
- http://localhost:5000/SoapService/http
- https://localhost:5001/SoapService/https

The `App` console app use a [custom endpoint behaviour](https://justsimplycode.com/2018/09/08/logging-all-outgoing-soap-requests/) in order to log soap requests/responses.

**`Tools`** : net 6.0, wcf-core