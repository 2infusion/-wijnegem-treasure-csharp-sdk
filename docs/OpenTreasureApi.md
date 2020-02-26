# IO.Swagger.Api.OpenTreasureApi

All URIs are relative to *https://wijnegem-treasure-api.herokuapp.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OpenTreasureControllerCreateManyBase**](OpenTreasureApi.md#opentreasurecontrollercreatemanybase) | **POST** /open-treasure/bulk | Create many OpenTreasure
[**OpenTreasureControllerCreateOneBase**](OpenTreasureApi.md#opentreasurecontrollercreateonebase) | **POST** /open-treasure | Create one OpenTreasure
[**OpenTreasureControllerDeleteOneBase**](OpenTreasureApi.md#opentreasurecontrollerdeleteonebase) | **DELETE** /open-treasure/{id} | Delete one OpenTreasure
[**OpenTreasureControllerGetManyBase**](OpenTreasureApi.md#opentreasurecontrollergetmanybase) | **GET** /open-treasure | Retrieve many OpenTreasure
[**OpenTreasureControllerGetOneBase**](OpenTreasureApi.md#opentreasurecontrollergetonebase) | **GET** /open-treasure/{id} | Retrieve one OpenTreasure
[**OpenTreasureControllerReplaceOneBase**](OpenTreasureApi.md#opentreasurecontrollerreplaceonebase) | **PUT** /open-treasure/{id} | Replace one OpenTreasure
[**OpenTreasureControllerUpdateOneBase**](OpenTreasureApi.md#opentreasurecontrollerupdateonebase) | **PATCH** /open-treasure/{id} | Update one OpenTreasure

<a name="opentreasurecontrollercreatemanybase"></a>
# **OpenTreasureControllerCreateManyBase**
> List<OpenTreasure> OpenTreasureControllerCreateManyBase (CreateManyOpenTreasureDto body)

Create many OpenTreasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenTreasureControllerCreateManyBaseExample
    {
        public void main()
        {


            var apiInstance = new OpenTreasureApi();
            var body = new CreateManyOpenTreasureDto(); // CreateManyOpenTreasureDto | 

            try
            {
                // Create many OpenTreasure
                List&lt;OpenTreasure&gt; result = apiInstance.OpenTreasureControllerCreateManyBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenTreasureApi.OpenTreasureControllerCreateManyBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateManyOpenTreasureDto**](CreateManyOpenTreasureDto.md)|  | 

### Return type

[**List<OpenTreasure>**](OpenTreasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opentreasurecontrollercreateonebase"></a>
# **OpenTreasureControllerCreateOneBase**
> OpenTreasure OpenTreasureControllerCreateOneBase (OpenTreasure body)

Create one OpenTreasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenTreasureControllerCreateOneBaseExample
    {
        public void main()
        {


            var apiInstance = new OpenTreasureApi();
            var body = new OpenTreasure(); // OpenTreasure | 

            try
            {
                // Create one OpenTreasure
                OpenTreasure result = apiInstance.OpenTreasureControllerCreateOneBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenTreasureApi.OpenTreasureControllerCreateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OpenTreasure**](OpenTreasure.md)|  | 

### Return type

[**OpenTreasure**](OpenTreasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opentreasurecontrollerdeleteonebase"></a>
# **OpenTreasureControllerDeleteOneBase**
> void OpenTreasureControllerDeleteOneBase (string id)

Delete one OpenTreasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenTreasureControllerDeleteOneBaseExample
    {
        public void main()
        {


            var apiInstance = new OpenTreasureApi();
            var id = id_example;  // string | 

            try
            {
                // Delete one OpenTreasure
                apiInstance.OpenTreasureControllerDeleteOneBase(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenTreasureApi.OpenTreasureControllerDeleteOneBase: " + e.Message );
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

<a name="opentreasurecontrollergetmanybase"></a>
# **OpenTreasureControllerGetManyBase**
> InlineResponse2002 OpenTreasureControllerGetManyBase (List<string> fields, string s, List<string> filter, List<string> or, List<string> sort, List<string> join, int? limit, int? offset, int? page, int? cache)

Retrieve many OpenTreasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenTreasureControllerGetManyBaseExample
    {
        public void main()
        {


            var apiInstance = new OpenTreasureApi();
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
                // Retrieve many OpenTreasure
                InlineResponse2002 result = apiInstance.OpenTreasureControllerGetManyBase(fields, s, filter, or, sort, join, limit, offset, page, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenTreasureApi.OpenTreasureControllerGetManyBase: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opentreasurecontrollergetonebase"></a>
# **OpenTreasureControllerGetOneBase**
> OpenTreasure OpenTreasureControllerGetOneBase (string id, List<string> fields, List<string> join, int? cache)

Retrieve one OpenTreasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenTreasureControllerGetOneBaseExample
    {
        public void main()
        {


            var apiInstance = new OpenTreasureApi();
            var id = id_example;  // string | 
            var fields = new List<string>(); // List<string> | Selects resource fields. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#select\" target=\"_blank\">Docs</a> (optional) 
            var join = new List<string>(); // List<string> | Adds relational resources. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#join\" target=\"_blank\">Docs</a> (optional) 
            var cache = 56;  // int? | Reset cache (if was enabled). <a href=\"https://github.com/nestjsx/crud/wiki/Requests#cache\" target=\"_blank\">Docs</a> (optional) 

            try
            {
                // Retrieve one OpenTreasure
                OpenTreasure result = apiInstance.OpenTreasureControllerGetOneBase(id, fields, join, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenTreasureApi.OpenTreasureControllerGetOneBase: " + e.Message );
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

[**OpenTreasure**](OpenTreasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opentreasurecontrollerreplaceonebase"></a>
# **OpenTreasureControllerReplaceOneBase**
> OpenTreasure OpenTreasureControllerReplaceOneBase (OpenTreasure body, string id)

Replace one OpenTreasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenTreasureControllerReplaceOneBaseExample
    {
        public void main()
        {


            var apiInstance = new OpenTreasureApi();
            var body = new OpenTreasure(); // OpenTreasure | 
            var id = id_example;  // string | 

            try
            {
                // Replace one OpenTreasure
                OpenTreasure result = apiInstance.OpenTreasureControllerReplaceOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenTreasureApi.OpenTreasureControllerReplaceOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OpenTreasure**](OpenTreasure.md)|  | 
 **id** | **string**|  | 

### Return type

[**OpenTreasure**](OpenTreasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opentreasurecontrollerupdateonebase"></a>
# **OpenTreasureControllerUpdateOneBase**
> OpenTreasure OpenTreasureControllerUpdateOneBase (OpenTreasure body, string id)

Update one OpenTreasure

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenTreasureControllerUpdateOneBaseExample
    {
        public void main()
        {


            var apiInstance = new OpenTreasureApi();
            var body = new OpenTreasure(); // OpenTreasure | 
            var id = id_example;  // string | 

            try
            {
                // Update one OpenTreasure
                OpenTreasure result = apiInstance.OpenTreasureControllerUpdateOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenTreasureApi.OpenTreasureControllerUpdateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OpenTreasure**](OpenTreasure.md)|  | 
 **id** | **string**|  | 

### Return type

[**OpenTreasure**](OpenTreasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

