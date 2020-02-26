# IO.Swagger.Api.TreasureApi

All URIs are relative to *https://wijnegem-treasure-api.herokuapp.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TreasureControllerCreateManyBase**](TreasureApi.md#treasurecontrollercreatemanybase) | **POST** /treasure/bulk | Create many Treasure
[**TreasureControllerCreateOneBase**](TreasureApi.md#treasurecontrollercreateonebase) | **POST** /treasure | Create one Treasure
[**TreasureControllerDeleteOneBase**](TreasureApi.md#treasurecontrollerdeleteonebase) | **DELETE** /treasure/{id} | Delete one Treasure
[**TreasureControllerGetManyBase**](TreasureApi.md#treasurecontrollergetmanybase) | **GET** /treasure | Retrieve many Treasure
[**TreasureControllerGetOneBase**](TreasureApi.md#treasurecontrollergetonebase) | **GET** /treasure/{id} | Retrieve one Treasure
[**TreasureControllerReplaceOneBase**](TreasureApi.md#treasurecontrollerreplaceonebase) | **PUT** /treasure/{id} | Replace one Treasure
[**TreasureControllerUpdateOneBase**](TreasureApi.md#treasurecontrollerupdateonebase) | **PATCH** /treasure/{id} | Update one Treasure

<a name="treasurecontrollercreatemanybase"></a>
# **TreasureControllerCreateManyBase**
> List<Treasure> TreasureControllerCreateManyBase (CreateManyTreasureDto body)

Create many Treasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TreasureControllerCreateManyBaseExample
    {
        public void main()
        {


            var apiInstance = new TreasureApi();
            var body = new CreateManyTreasureDto(); // CreateManyTreasureDto | 

            try
            {
                // Create many Treasure
                List&lt;Treasure&gt; result = apiInstance.TreasureControllerCreateManyBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TreasureApi.TreasureControllerCreateManyBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateManyTreasureDto**](CreateManyTreasureDto.md)|  | 

### Return type

[**List<Treasure>**](Treasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="treasurecontrollercreateonebase"></a>
# **TreasureControllerCreateOneBase**
> Treasure TreasureControllerCreateOneBase (Treasure body)

Create one Treasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TreasureControllerCreateOneBaseExample
    {
        public void main()
        {


            var apiInstance = new TreasureApi();
            var body = new Treasure(); // Treasure | 

            try
            {
                // Create one Treasure
                Treasure result = apiInstance.TreasureControllerCreateOneBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TreasureApi.TreasureControllerCreateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Treasure**](Treasure.md)|  | 

### Return type

[**Treasure**](Treasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="treasurecontrollerdeleteonebase"></a>
# **TreasureControllerDeleteOneBase**
> void TreasureControllerDeleteOneBase (string id)

Delete one Treasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TreasureControllerDeleteOneBaseExample
    {
        public void main()
        {


            var apiInstance = new TreasureApi();
            var id = id_example;  // string | 

            try
            {
                // Delete one Treasure
                apiInstance.TreasureControllerDeleteOneBase(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TreasureApi.TreasureControllerDeleteOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="treasurecontrollergetmanybase"></a>
# **TreasureControllerGetManyBase**
> InlineResponse2003 TreasureControllerGetManyBase (List<string> fields, string s, List<string> filter, List<string> or, List<string> sort, List<string> join, int? limit, int? offset, int? page, int? cache)

Retrieve many Treasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TreasureControllerGetManyBaseExample
    {
        public void main()
        {


            var apiInstance = new TreasureApi();
            var fields = new List<string>(); // List<string> | Selects resource fields. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#select\" target=\"_blank\">Docs</a> (optional) 
            var s = s_example;  // string | Adds search condition. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#search\" target=\"_blank\">Docs</a> (optional) 
            var filter = new List<string>(); // List<string> | Adds filter condition. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#filter\" target=\"_blank\">Docs</a> (optional) 
            var or = new List<string>(); // List<string> | Adds OR condition. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#or\" target=\"_blank\">Docs</a> (optional) 
            var sort = new List<string>(); // List<string> | Adds sort by field. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#sort\" target=\"_blank\">Docs</a> (optional) 
            var join = new List<string>(); // List<string> | Adds relational resources. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#join\" target=\"_blank\">Docs</a> (optional) 
            var limit = 56;  // int? | Limit amount of resources. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#limit\" target=\"_blank\">Docs</a> (optional) 
            var offset = 56;  // int? | Offset amount of resources. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#offset\" target=\"_blank\">Docs</a> (optional) 
            var page = 56;  // int? | Page portion of resources. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#page\" target=\"_blank\">Docs</a> (optional) 
            var cache = 56;  // int? | Reset cache (if was enabled). <a href=\"https://github.com/nestjsx/crud/wiki/Requests#cache\" target=\"_blank\">Docs</a> (optional) 

            try
            {
                // Retrieve many Treasure
                InlineResponse2003 result = apiInstance.TreasureControllerGetManyBase(fields, s, filter, or, sort, join, limit, offset, page, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TreasureApi.TreasureControllerGetManyBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | [**List<string>**](string.md)| Selects resource fields. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#select\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **s** | **string**| Adds search condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#search\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **filter** | [**List<string>**](string.md)| Adds filter condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#filter\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **or** | [**List<string>**](string.md)| Adds OR condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#or\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **sort** | [**List<string>**](string.md)| Adds sort by field. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#sort\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **join** | [**List<string>**](string.md)| Adds relational resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#join\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **limit** | **int?**| Limit amount of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#limit\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **offset** | **int?**| Offset amount of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#offset\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **page** | **int?**| Page portion of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#page\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **cache** | **int?**| Reset cache (if was enabled). &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#cache\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="treasurecontrollergetonebase"></a>
# **TreasureControllerGetOneBase**
> Treasure TreasureControllerGetOneBase (string id, List<string> fields, List<string> join, int? cache)

Retrieve one Treasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TreasureControllerGetOneBaseExample
    {
        public void main()
        {


            var apiInstance = new TreasureApi();
            var id = id_example;  // string | 
            var fields = new List<string>(); // List<string> | Selects resource fields. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#select\" target=\"_blank\">Docs</a> (optional) 
            var join = new List<string>(); // List<string> | Adds relational resources. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#join\" target=\"_blank\">Docs</a> (optional) 
            var cache = 56;  // int? | Reset cache (if was enabled). <a href=\"https://github.com/nestjsx/crud/wiki/Requests#cache\" target=\"_blank\">Docs</a> (optional) 

            try
            {
                // Retrieve one Treasure
                Treasure result = apiInstance.TreasureControllerGetOneBase(id, fields, join, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TreasureApi.TreasureControllerGetOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **fields** | [**List<string>**](string.md)| Selects resource fields. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#select\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **join** | [**List<string>**](string.md)| Adds relational resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#join\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **cache** | **int?**| Reset cache (if was enabled). &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#cache\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 

### Return type

[**Treasure**](Treasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="treasurecontrollerreplaceonebase"></a>
# **TreasureControllerReplaceOneBase**
> Treasure TreasureControllerReplaceOneBase (Treasure body, string id)

Replace one Treasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TreasureControllerReplaceOneBaseExample
    {
        public void main()
        {


            var apiInstance = new TreasureApi();
            var body = new Treasure(); // Treasure | 
            var id = id_example;  // string | 

            try
            {
                // Replace one Treasure
                Treasure result = apiInstance.TreasureControllerReplaceOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TreasureApi.TreasureControllerReplaceOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Treasure**](Treasure.md)|  | 
 **id** | **string**|  | 

### Return type

[**Treasure**](Treasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="treasurecontrollerupdateonebase"></a>
# **TreasureControllerUpdateOneBase**
> Treasure TreasureControllerUpdateOneBase (Treasure body, string id)

Update one Treasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TreasureControllerUpdateOneBaseExample
    {
        public void main()
        {


            var apiInstance = new TreasureApi();
            var body = new Treasure(); // Treasure | 
            var id = id_example;  // string | 

            try
            {
                // Update one Treasure
                Treasure result = apiInstance.TreasureControllerUpdateOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TreasureApi.TreasureControllerUpdateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Treasure**](Treasure.md)|  | 
 **id** | **string**|  | 

### Return type

[**Treasure**](Treasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

