# IO.Swagger.Api.AdminsApi

All URIs are relative to *https://virtserver.swaggerhub.com/Euanher/MyCVnew/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInventory**](AdminsApi.md#addinventory) | **POST** /inventory | Add View

<a name="addinventory"></a>
# **AddInventory**
> void AddInventory ()

Add View

Adds an item to the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddInventoryExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();

            try
            {
                // Add View
                apiInstance.AddInventory();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.AddInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
