# IO.Swagger.Api.PartnerApi

All URIs are relative to *https://wijnegem-treasure-api.herokuapp.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PartnerControllerCreateManyBase**](PartnerApi.md#partnercontrollercreatemanybase) | **POST** /partner/bulk | Create many Partner
[**PartnerControllerCreateOneBase**](PartnerApi.md#partnercontrollercreateonebase) | **POST** /partner | Create one Partner
[**PartnerControllerDeleteOneBase**](PartnerApi.md#partnercontrollerdeleteonebase) | **DELETE** /partner/{id} | Delete one Partner
[**PartnerControllerGetManyBase**](PartnerApi.md#partnercontrollergetmanybase) | **GET** /partner | Retrieve many Partner
[**PartnerControllerGetOneBase**](PartnerApi.md#partnercontrollergetonebase) | **GET** /partner/{id} | Retrieve one Partner
[**PartnerControllerReplaceOneBase**](PartnerApi.md#partnercontrollerreplaceonebase) | **PUT** /partner/{id} | Replace one Partner
[**PartnerControllerUpdateOneBase**](PartnerApi.md#partnercontrollerupdateonebase) | **PATCH** /partner/{id} | Update one Partner

<a name="partnercontrollercreatemanybase"></a>
# **PartnerControllerCreateManyBase**
> List<Partner> PartnerControllerCreateManyBase (CreateManyPartnerDto body)

Create many Partner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerControllerCreateManyBaseExample
    {
        public void main()
        {

            var apiInstance = new PartnerApi();
            var body = new CreateManyPartnerDto(); // CreateManyPartnerDto | 

            try
            {
                // Create many Partner
                List&lt;Partner&gt; result = apiInstance.PartnerControllerCreateManyBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnerApi.PartnerControllerCreateManyBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateManyPartnerDto**](CreateManyPartnerDto.md)|  | 

### Return type

[**List<Partner>**](Partner.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partnercontrollercreateonebase"></a>
# **PartnerControllerCreateOneBase**
> Partner PartnerControllerCreateOneBase (Partner body)

Create one Partner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerControllerCreateOneBaseExample
    {
        public void main()
        {

            var apiInstance = new PartnerApi();
            var body = new Partner(); // Partner | 

            try
            {
                // Create one Partner
                Partner result = apiInstance.PartnerControllerCreateOneBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnerApi.PartnerControllerCreateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Partner**](Partner.md)|  | 

### Return type

[**Partner**](Partner.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partnercontrollerdeleteonebase"></a>
# **PartnerControllerDeleteOneBase**
> void PartnerControllerDeleteOneBase (string id)

Delete one Partner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerControllerDeleteOneBaseExample
    {
        public void main()
        {

            var apiInstance = new PartnerApi();
            var id = id_example;  // string | 

            try
            {
                // Delete one Partner
                apiInstance.PartnerControllerDeleteOneBase(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnerApi.PartnerControllerDeleteOneBase: " + e.Message );
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
<a name="partnercontrollergetmanybase"></a>
# **PartnerControllerGetManyBase**
> InlineResponse200 PartnerControllerGetManyBase (List<string> fields = null, string s = null, List<string> filter = null, List<string> or = null, List<string> sort = null, List<string> join = null, int? limit = null, int? offset = null, int? page = null, int? cache = null)

Retrieve many Partner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerControllerGetManyBaseExample
    {
        public void main()
        {

            var apiInstance = new PartnerApi();
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
                // Retrieve many Partner
                InlineResponse200 result = apiInstance.PartnerControllerGetManyBase(fields, s, filter, or, sort, join, limit, offset, page, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnerApi.PartnerControllerGetManyBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fields** | [**List&lt;string&gt;**](string.md)| Selects resource fields. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#select\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **s** | **string**| Adds search condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#search\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **filter** | [**List&lt;string&gt;**](string.md)| Adds filter condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#filter\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **or** | [**List&lt;string&gt;**](string.md)| Adds OR condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#or\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **sort** | [**List&lt;string&gt;**](string.md)| Adds sort by field. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#sort\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **join** | [**List&lt;string&gt;**](string.md)| Adds relational resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#join\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **limit** | **int?**| Limit amount of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#limit\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **offset** | **int?**| Offset amount of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#offset\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **page** | **int?**| Page portion of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#page\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **cache** | **int?**| Reset cache (if was enabled). &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#cache\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partnercontrollergetonebase"></a>
# **PartnerControllerGetOneBase**
> Partner PartnerControllerGetOneBase (string id, List<string> fields = null, List<string> join = null, int? cache = null)

Retrieve one Partner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerControllerGetOneBaseExample
    {
        public void main()
        {

            var apiInstance = new PartnerApi();
            var id = id_example;  // string | 
            var fields = new List<string>(); // List<string> | Selects resource fields. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#select\" target=\"_blank\">Docs</a> (optional) 
            var join = new List<string>(); // List<string> | Adds relational resources. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#join\" target=\"_blank\">Docs</a> (optional) 
            var cache = 56;  // int? | Reset cache (if was enabled). <a href=\"https://github.com/nestjsx/crud/wiki/Requests#cache\" target=\"_blank\">Docs</a> (optional) 

            try
            {
                // Retrieve one Partner
                Partner result = apiInstance.PartnerControllerGetOneBase(id, fields, join, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnerApi.PartnerControllerGetOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **fields** | [**List&lt;string&gt;**](string.md)| Selects resource fields. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#select\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **join** | [**List&lt;string&gt;**](string.md)| Adds relational resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#join\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 
 **cache** | **int?**| Reset cache (if was enabled). &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#cache\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt; | [optional] 

### Return type

[**Partner**](Partner.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partnercontrollerreplaceonebase"></a>
# **PartnerControllerReplaceOneBase**
> Partner PartnerControllerReplaceOneBase (Partner body, string id)

Replace one Partner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerControllerReplaceOneBaseExample
    {
        public void main()
        {

            var apiInstance = new PartnerApi();
            var body = new Partner(); // Partner | 
            var id = id_example;  // string | 

            try
            {
                // Replace one Partner
                Partner result = apiInstance.PartnerControllerReplaceOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnerApi.PartnerControllerReplaceOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Partner**](Partner.md)|  | 
 **id** | **string**|  | 

### Return type

[**Partner**](Partner.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partnercontrollerupdateonebase"></a>
# **PartnerControllerUpdateOneBase**
> Partner PartnerControllerUpdateOneBase (Partner body, string id)

Update one Partner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerControllerUpdateOneBaseExample
    {
        public void main()
        {

            var apiInstance = new PartnerApi();
            var body = new Partner(); // Partner | 
            var id = id_example;  // string | 

            try
            {
                // Update one Partner
                Partner result = apiInstance.PartnerControllerUpdateOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnerApi.PartnerControllerUpdateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Partner**](Partner.md)|  | 
 **id** | **string**|  | 

### Return type

[**Partner**](Partner.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
