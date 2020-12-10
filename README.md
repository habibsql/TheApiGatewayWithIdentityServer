### The-ApiGateway-With-IdentityServer

2 very important components for Microservice based architecture

- i) Authentication/Authorization server
- ii) API Gateway

are demonated here:
<br/>
<img alt="IdentityServer4" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/identityserver4.png" height="300" width="600px">

##### Identity Server4:
Identity Server4 is an OpenIDConnect and OAth2.0 framework for ASPNET Core

**Benifits**:
* Centralize authentication logic for all applications (web, mobile, native, services).
* Authentication as Service.
* Access Control for API's using token generation.
* Use as Federated Gateway (external identity providers (google, facebook, Azure Active directory)
* Single Singin/Singout
* Support Dotnet foundation.
* Apachi2 licence

<img alt="IdentityServer4" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/apigateway.jpg" height="300" width="600px">
##### API Gateway:
Take all API calls from clients, then route them to the appropriate microservices with request routing, composition
and  protocol translation. Typically it handles a request by invoking multiple microservices and aggregate the results.
It can translate between Web protocol. It invoke various services like product info and review and combine the results.

**Benifits**:
* Act like a reverse proxy.
* No need to expose real services endpoints publicly.
* Authentication feature
* Response Caching.
* Api call tracking and Bill generation if needed.
* Centralize API management.

#### Technology Uses:
* Aspnet Core
* IdentityServer4
* Ocelot API gateway

<img alt="Token" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/get-token.jpg" height="350" width="700px">

<img alt="API-1" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/get1.jpg" height="350" width="700px">

<img alt="API-2" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/get2.jpg" height="350" width="700px">

<img alt="API-3" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/merge.jpg" height="350" width="700px">
