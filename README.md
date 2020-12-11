### The-ApiGateway-With-IdentityServer
2 very important components for Microservice based architecture:
- i) Authentication/Authorization server
- ii) API Gateway
<br/>are demonated here:
<br/> - Authentication server is used here for generating jwt token. Based on that token, API gateway exposed endpoint can be called.
<br/> - API Gateway exposed endpoints publicly to consume that private endpoints.
<br/>
<img alt="IdentityServer4" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/identityserver4.png" height="300" width="500px">

#### Identity Server4:
Identity Server4 is an OpenIDConnect and OAth2.0 framework for ASPNET Core. It provides jwt token for authentication/authorization.

**Benifits**:
* Centralize authentication logic for all applications (web, mobile, native, services).
* Authentication as Service.
* Access Control for API's using token generation.
* Use as Federated Gateway (external identity providers (google, facebook, Azure Active directory)
* Single Singin/Signout
* Support Dotnet foundation.
* Apachi2 licence
<br>
<img alt="IdentityServer4" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/apigateway.jpg" height="300" width="600px">

#### API Gateway:
Take all API calls from clients, then route them to the appropriate microservices with request routing, composition
and  protocol translation. Typically it handles a request by invoking multiple microservices and aggregate the results.
It can translate between Web protocol. It invoke various services like product info and review and combine the results.

**Benifits**:
* Act as reverse proxy.
* No need to expose real services endpoints publicly.
* Authentication feature
* Response Caching.
* Api call tracking and Bill generation if needed.
* Centralize API management.

#### Technology used:
* Aspnet Core
* IdentityServer4
* Ocelot API gateway

#### How to run:
- There are 3 projects in the solution:
- 1) IdentityServer project
- 2) Ocelot project
- 3) TodoApi project

**Steps to follow**:
- Step 1. You need to run both 3 projects. 
- Step 2. Call IdentityServer projects endpoint (https://localhost:4001/connect/token) (using postman)
- Step 3. Using that token call API gateway exposed endpoint(GET https://localhost:6001/api/todo)
- Step 4. You will received the todo list.

**Note**: 
- If you call API gateway exposed endpoints (Ocelot project) without valid token you will get 401 unauthorized error
- If you call directly TodoApi endpoints (TodoApi project) you can get data without any token.
- Senario is: your Todo project endpoinsts will be private network and not exposed outside the network. But your Ocelot
project will be exposed outside network (with authentication).
- Hope you the real usecase understand. (Please check the POSTMAN screenshot bellow:)

**Collect Jwt Token**:
<br>
<img alt="Token" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/get-token.jpg" height="300" width="500px">

**Single API call (without any parameters) with exposed API gateway endpoints (return array of Todo objects)**:
<br>
<img alt="API-1" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/get1.jpg" height="300" width="500px">

**Single API call (with parameters) with exposed API gateway endpoints (return String)**:
<br>
<img alt="API-2" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/get2.jpg" height="300" width="500px">

**Single API call with exposed API gateway endpoints which return and merged data with 2 API call**:
<br>
<img alt="API-3" src="https://github.com/habibsql/TheApiGatewayWithIdentityServer/blob/main/docs/merge.jpg" height="300" width="500px"/>
