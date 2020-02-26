# IO.Swagger.Api.CampaignApi

All URIs are relative to *https://wijnegem-treasure-api.herokuapp.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CampaignControllerCreateManyBase**](CampaignApi.md#campaigncontrollercreatemanybase) | **POST** /Campaign/bulk | Create many Campaign
[**CampaignControllerCreateOneBase**](CampaignApi.md#campaigncontrollercreateonebase) | **POST** /Campaign | Create one Campaign
[**CampaignControllerDeleteOneBase**](CampaignApi.md#campaigncontrollerdeleteonebase) | **DELETE** /Campaign/{id} | Delete one Campaign
[**CampaignControllerGetManyBase**](CampaignApi.md#campaigncontrollergetmanybase) | **GET** /Campaign | Retrieve many Campaign
[**CampaignControllerGetOneBase**](CampaignApi.md#campaigncontrollergetonebase) | **GET** /Campaign/{id} | Retrieve one Campaign
[**CampaignControllerReplaceOneBase**](CampaignApi.md#campaigncontrollerreplaceonebase) | **PUT** /Campaign/{id} | Replace one Campaign
[**CampaignControllerUpdateOneBase**](CampaignApi.md#campaigncontrollerupdateonebase) | **PATCH** /Campaign/{id} | Update one Campaign

<a name="campaigncontrollercreatemanybase"></a>
# **CampaignControllerCreateManyBase**
> List<Campaign> CampaignControllerCreateManyBase (CreateManyCampaignDto body)

Create many Campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CampaignControllerCreateManyBaseExample
    {
        public void main()
        {


            var apiInstance = new CampaignApi();
            var body = new CreateManyCampaignDto(); // CreateManyCampaignDto | 

            try
            {
                // Create many Campaign
                List&lt;Campaign&gt; result = apiInstance.CampaignControllerCreateManyBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CampaignControllerCreateManyBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateManyCampaignDto**](CreateManyCampaignDto.md)|  | 

### Return type

[**List<Campaign>**](Campaign.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="campaigncontrollercreateonebase"></a>
# **CampaignControllerCreateOneBase**
> Campaign CampaignControllerCreateOneBase (Campaign body)

Create one Campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CampaignControllerCreateOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CampaignApi();
            var body = new Campaign(); // Campaign | 

            try
            {
                // Create one Campaign
                Campaign result = apiInstance.CampaignControllerCreateOneBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CampaignControllerCreateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Campaign**](Campaign.md)|  | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="campaigncontrollerdeleteonebase"></a>
# **CampaignControllerDeleteOneBase**
> void CampaignControllerDeleteOneBase (string id)

Delete one Campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CampaignControllerDeleteOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CampaignApi();
            var id = id_example;  // string | 

            try
            {
                // Delete one Campaign
                apiInstance.CampaignControllerDeleteOneBase(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CampaignControllerDeleteOneBase: " + e.Message );
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

<a name="campaigncontrollergetmanybase"></a>
# **CampaignControllerGetManyBase**
> InlineResponse2001 CampaignControllerGetManyBase (List<string> fields, string s, List<string> filter, List<string> or, List<string> sort, List<string> join, int? limit, int? offset, int? page, int? cache)

Retrieve many Campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CampaignControllerGetManyBaseExample
    {
        public void main()
        {


            var apiInstance = new CampaignApi();
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
                // Retrieve many Campaign
                InlineResponse2001 result = apiInstance.CampaignControllerGetManyBase(fields, s, filter, or, sort, join, limit, offset, page, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CampaignControllerGetManyBase: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="campaigncontrollergetonebase"></a>
# **CampaignControllerGetOneBase**
> Campaign CampaignControllerGetOneBase (string id, List<string> fields, List<string> join, int? cache)

Retrieve one Campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CampaignControllerGetOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CampaignApi();
            var id = id_example;  // string | 
            var fields = new List<string>(); // List<string> | Selects resource fields. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#select\" target=\"_blank\">Docs</a> (optional) 
            var join = new List<string>(); // List<string> | Adds relational resources. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#join\" target=\"_blank\">Docs</a> (optional) 
            var cache = 56;  // int? | Reset cache (if was enabled). <a href=\"https://github.com/nestjsx/crud/wiki/Requests#cache\" target=\"_blank\">Docs</a> (optional) 

            try
            {
                // Retrieve one Campaign
                Campaign result = apiInstance.CampaignControllerGetOneBase(id, fields, join, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CampaignControllerGetOneBase: " + e.Message );
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

[**Campaign**](Campaign.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="campaigncontrollerreplaceonebase"></a>
# **CampaignControllerReplaceOneBase**
> Campaign CampaignControllerReplaceOneBase (Campaign body, string id)

Replace one Campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CampaignControllerReplaceOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CampaignApi();
            var body = new Campaign(); // Campaign | 
            var id = id_example;  // string | 

            try
            {
                // Replace one Campaign
                Campaign result = apiInstance.CampaignControllerReplaceOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CampaignControllerReplaceOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Campaign**](Campaign.md)|  | 
 **id** | **string**|  | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="campaigncontrollerupdateonebase"></a>
# **CampaignControllerUpdateOneBase**
> Campaign CampaignControllerUpdateOneBase (Campaign body, string id)

Update one Campaign

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CampaignControllerUpdateOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CampaignApi();
            var body = new Campaign(); // Campaign | 
            var id = id_example;  // string | 

            try
            {
                // Update one Campaign
                Campaign result = apiInstance.CampaignControllerUpdateOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignApi.CampaignControllerUpdateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Campaign**](Campaign.md)|  | 
 **id** | **string**|  | 

### Return type

[**Campaign**](Campaign.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

