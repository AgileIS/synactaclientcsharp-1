# IO.Swagger - the C# library for the Synacta

WebApi

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v1
- SDK version: 1.0.0
- Build date: 2016-11-15T16:05:09.142Z
- Build package: class io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [http://www.agile-is.de/](http://www.agile-is.de/)

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var id = id_example;  // string | The principal identifier.
            var authorization = authorization_example;  // string | access token

            try
            {
                // Provides a principal by his identifier.
                PrincipalSearchResult result = apiInstance.ApiAuthorizationPrincipalsByIdGet(id, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ApiAuthorizationPrincipalsByIdGet: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost/*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorizationApi* | [**ApiAuthorizationPrincipalsByIdGet**](docs/AuthorizationApi.md#apiauthorizationprincipalsbyidget) | **GET** /_api/authorization/Principals/{id} | Provides a principal by his identifier.
*AuthorizationApi* | [**ApiAuthorizationPrincipalsGet**](docs/AuthorizationApi.md#apiauthorizationprincipalsget) | **GET** /_api/authorization/Principals | Gets the principals.
*AuthorizationApi* | [**ApiAuthorizationRightsGet**](docs/AuthorizationApi.md#apiauthorizationrightsget) | **GET** /_api/authorization/Rights | Gets the rights.
*AuthorizationApi* | [**ApiAuthorizationRolesAddGet**](docs/AuthorizationApi.md#apiauthorizationrolesaddget) | **GET** /_api/authorization/Roles/Add | Gets the role container.
*AuthorizationApi* | [**ApiAuthorizationRolesAddPut**](docs/AuthorizationApi.md#apiauthorizationrolesaddput) | **PUT** /_api/authorization/Roles/Add | Adds the role.
*AuthorizationApi* | [**ApiAuthorizationRolesByIdDelete**](docs/AuthorizationApi.md#apiauthorizationrolesbyiddelete) | **DELETE** /_api/authorization/Roles/{id} | Deletes the role.
*AuthorizationApi* | [**ApiAuthorizationRolesByIdGet**](docs/AuthorizationApi.md#apiauthorizationrolesbyidget) | **GET** /_api/authorization/Roles/{id} | Gets the role.
*AuthorizationApi* | [**ApiAuthorizationRolesByIdPost**](docs/AuthorizationApi.md#apiauthorizationrolesbyidpost) | **POST** /_api/authorization/Roles/{id} | Updates the role.
*AuthorizationApi* | [**ApiAuthorizationRolesGet**](docs/AuthorizationApi.md#apiauthorizationrolesget) | **GET** /_api/authorization/Roles | Gets the roles.
*BaseApi* | [**ApiBaseByTypeByIdAddByNewContainerTypeGet**](docs/BaseApi.md#apibasebytypebyidaddbynewcontainertypeget) | **GET** /_api/base/{type}/{id}/Add/{newContainerType} | Gets the empty container.
*BaseApi* | [**ApiBaseByTypeByIdAddPut**](docs/BaseApi.md#apibasebytypebyidaddput) | **PUT** /_api/base/{type}/{id}/Add | Saves the new container.
*BaseApi* | [**ApiBaseByTypeByIdCheckinPut**](docs/BaseApi.md#apibasebytypebyidcheckinput) | **PUT** /_api/base/{type}/{id}/Checkin | Checkins the specified .
*BaseApi* | [**ApiBaseByTypeByIdCheckoutPut**](docs/BaseApi.md#apibasebytypebyidcheckoutput) | **PUT** /_api/base/{type}/{id}/Checkout | Checkouts the specified .
*BaseApi* | [**ApiBaseByTypeByIdChildrenGet**](docs/BaseApi.md#apibasebytypebyidchildrenget) | **GET** /_api/base/{type}/{id}/Children | Gets the children of container.
*BaseApi* | [**ApiBaseByTypeByIdChildrenTypesGet**](docs/BaseApi.md#apibasebytypebyidchildrentypesget) | **GET** /_api/base/{type}/{id}/Children/Types | Gets the container types.
*BaseApi* | [**ApiBaseByTypeByIdDelete**](docs/BaseApi.md#apibasebytypebyiddelete) | **DELETE** /_api/base/{type}/{id} | Deletes the container.
*BaseApi* | [**ApiBaseByTypeByIdDocumentsGet**](docs/BaseApi.md#apibasebytypebyiddocumentsget) | **GET** /_api/base/{type}/{id}/Documents | Gets the documents.
*BaseApi* | [**ApiBaseByTypeByIdDocumentsTypesGet**](docs/BaseApi.md#apibasebytypebyiddocumentstypesget) | **GET** /_api/base/{type}/{id}/Documents/Types | Gets the documents types.
*BaseApi* | [**ApiBaseByTypeByIdGet**](docs/BaseApi.md#apibasebytypebyidget) | **GET** /_api/base/{type}/{id} | Gets the container by identifier.
*BaseApi* | [**ApiBaseByTypeByIdGetFileGet**](docs/BaseApi.md#apibasebytypebyidgetfileget) | **GET** /_api/base/{type}/{id}/GetFile | Gets the file.
*BaseApi* | [**ApiBaseByTypeByIdLookupListByLookupListNameGet**](docs/BaseApi.md#apibasebytypebyidlookuplistbylookuplistnameget) | **GET** /_api/base/{type}/{id}/LookupList/{lookupListName} | Gets the lookup list entries.
*BaseApi* | [**ApiBaseByTypeByIdMovePost**](docs/BaseApi.md#apibasebytypebyidmovepost) | **POST** /_api/base/{type}/{id}/Move | Moves the object.
*BaseApi* | [**ApiBaseByTypeByIdPost**](docs/BaseApi.md#apibasebytypebyidpost) | **POST** /_api/base/{type}/{id} | Updates the container.
*BaseApi* | [**ApiBaseByTypeByIdUploadFilePost**](docs/BaseApi.md#apibasebytypebyiduploadfilepost) | **POST** /_api/base/{type}/{id}/UploadFile | Uploads the file.
*BaseApi* | [**ApiBaseByTypeByIdVersionsByVersionIdGet**](docs/BaseApi.md#apibasebytypebyidversionsbyversionidget) | **GET** /_api/base/{type}/{id}/Versions/{versionId} | Gets the version by identifier.
*BaseApi* | [**ApiBaseByTypeByIdVersionsByVersionIdGetFileGet**](docs/BaseApi.md#apibasebytypebyidversionsbyversionidgetfileget) | **GET** /_api/base/{type}/{id}/Versions/{versionId}/GetFile | Gets the file for version.
*BaseApi* | [**ApiBaseByTypeByIdVersionsByVersionIdRestorePost**](docs/BaseApi.md#apibasebytypebyidversionsbyversionidrestorepost) | **POST** /_api/base/{type}/{id}/Versions/{versionId}/Restore | Restores the version.
*BaseApi* | [**ApiBaseByTypeByIdVersionsGet**](docs/BaseApi.md#apibasebytypebyidversionsget) | **GET** /_api/base/{type}/{id}/Versions | Gets the versions.
*BaseApi* | [**ApiBaseByTypeGet**](docs/BaseApi.md#apibasebytypeget) | **GET** /_api/base/{type} | Gets containers by a type.
*BaseApi* | [**ApiBaseRootGet**](docs/BaseApi.md#apibaserootget) | **GET** /_api/base/Root | Gets the root.
*BaseApi* | [**ApiBaseTypesGet**](docs/BaseApi.md#apibasetypesget) | **GET** /_api/base/Types | Gets the container types.
*LoggingApi* | [**ApiLogAddGet**](docs/LoggingApi.md#apilogaddget) | **GET** /_api/log/Add | Gets the log container.
*LoggingApi* | [**ApiLogAddPut**](docs/LoggingApi.md#apilogaddput) | **PUT** /_api/log/Add | Adds the log.
*LoggingApi* | [**ApiLogGet**](docs/LoggingApi.md#apilogget) | **GET** /_api/log | Gets all logs.
*OrganisationApi* | [**ApiOrgByIdAddGet**](docs/OrganisationApi.md#apiorgbyidaddget) | **GET** /_api/org/{id}/Add | Gets the new organisation.
*OrganisationApi* | [**ApiOrgByIdAddPut**](docs/OrganisationApi.md#apiorgbyidaddput) | **PUT** /_api/org/{id}/Add | Saves the new organisation.
*OrganisationApi* | [**ApiOrgByIdByTypeGet**](docs/OrganisationApi.md#apiorgbyidbytypeget) | **GET** /_api/org/{id}/{type} | Gets all containers.
*OrganisationApi* | [**ApiOrgByIdChildrenGet**](docs/OrganisationApi.md#apiorgbyidchildrenget) | **GET** /_api/org/{id}/Children | Gets the child organisations.
*OrganisationApi* | [**ApiOrgByIdDelete**](docs/OrganisationApi.md#apiorgbyiddelete) | **DELETE** /_api/org/{id} | Deletes the organisation.
*OrganisationApi* | [**ApiOrgByIdGet**](docs/OrganisationApi.md#apiorgbyidget) | **GET** /_api/org/{id} | Gets the organisation.
*OrganisationApi* | [**ApiOrgByIdMovePost**](docs/OrganisationApi.md#apiorgbyidmovepost) | **POST** /_api/org/{id}/Move | Moves the organisation.
*OrganisationApi* | [**ApiOrgByIdPost**](docs/OrganisationApi.md#apiorgbyidpost) | **POST** /_api/org/{id} | Updates the organisation.
*OrganisationApi* | [**ApiOrgByIdRecycleBinByRecycleBinIdGet**](docs/OrganisationApi.md#apiorgbyidrecyclebinbyrecyclebinidget) | **GET** /_api/org/{id}/RecycleBin/{recycleBinId} | Gets the recycle bin entry.
*OrganisationApi* | [**ApiOrgByIdRecycleBinByRecycleBinIdRestorePost**](docs/OrganisationApi.md#apiorgbyidrecyclebinbyrecyclebinidrestorepost) | **POST** /_api/org/{id}/RecycleBin/{recycleBinId}/Restore | Restores the recycle bin entry.
*OrganisationApi* | [**ApiOrgByIdRecycleBinGet**](docs/OrganisationApi.md#apiorgbyidrecyclebinget) | **GET** /_api/org/{id}/RecycleBin | Gets the recycle bin.
*OrganisationApi* | [**ApiOrgGet**](docs/OrganisationApi.md#apiorgget) | **GET** /_api/org | Gets all organisations.
*OrganisationApi* | [**ApiOrgOrgTreeGet**](docs/OrganisationApi.md#apiorgorgtreeget) | **GET** /_api/org/OrgTree | Gets all organisations with childs.
*SearchApi* | [**ApiSearchGet**](docs/SearchApi.md#apisearchget) | **GET** /_api/search | Executes the search.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Container](docs/Container.md)
 - [Model.DocumentVersion](docs/DocumentVersion.md)
 - [Model.KeyValuePairStringString](docs/KeyValuePairStringString.md)
 - [Model.Log](docs/Log.md)
 - [Model.Organisation](docs/Organisation.md)
 - [Model.PrincipalSearchResult](docs/PrincipalSearchResult.md)
 - [Model.RecycleBinEntry](docs/RecycleBinEntry.md)
 - [Model.Right](docs/Right.md)
 - [Model.Role](docs/Role.md)


## Documentation for Authorization

All endpoints do not require authorization.
