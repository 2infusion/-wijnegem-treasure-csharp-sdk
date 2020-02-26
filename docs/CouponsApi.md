# IO.Swagger.Api.CouponsApi

All URIs are relative to *https://wijnegem-treasure-api.herokuapp.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CouponControllerCreateManyBase**](CouponsApi.md#couponcontrollercreatemanybase) | **POST** /coupons/bulk | Create many Coupon
[**CouponControllerCreateOneBase**](CouponsApi.md#couponcontrollercreateonebase) | **POST** /coupons | Create one Coupon
[**CouponControllerDeleteOneBase**](CouponsApi.md#couponcontrollerdeleteonebase) | **DELETE** /coupons/{id} | Delete one Coupon
[**CouponControllerGetManyBase**](CouponsApi.md#couponcontrollergetmanybase) | **GET** /coupons | Retrieve many Coupon
[**CouponControllerGetOneBase**](CouponsApi.md#couponcontrollergetonebase) | **GET** /coupons/{id} | Retrieve one Coupon
[**CouponControllerReplaceOneBase**](CouponsApi.md#couponcontrollerreplaceonebase) | **PUT** /coupons/{id} | Replace one Coupon
[**CouponControllerUpdateOneBase**](CouponsApi.md#couponcontrollerupdateonebase) | **PATCH** /coupons/{id} | Update one Coupon

<a name="couponcontrollercreatemanybase"></a>
# **CouponControllerCreateManyBase**
> List<Coupon> CouponControllerCreateManyBase (CreateManyCouponDto body)

Create many Coupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CouponControllerCreateManyBaseExample
    {
        public void main()
        {


            var apiInstance = new CouponsApi();
            var body = new CreateManyCouponDto(); // CreateManyCouponDto | 

            try
            {
                // Create many Coupon
                List&lt;Coupon&gt; result = apiInstance.CouponControllerCreateManyBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.CouponControllerCreateManyBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateManyCouponDto**](CreateManyCouponDto.md)|  | 

### Return type

[**List<Coupon>**](Coupon.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="couponcontrollercreateonebase"></a>
# **CouponControllerCreateOneBase**
> Coupon CouponControllerCreateOneBase (Coupon body)

Create one Coupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CouponControllerCreateOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CouponsApi();
            var body = new Coupon(); // Coupon | 

            try
            {
                // Create one Coupon
                Coupon result = apiInstance.CouponControllerCreateOneBase(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.CouponControllerCreateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Coupon**](Coupon.md)|  | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="couponcontrollerdeleteonebase"></a>
# **CouponControllerDeleteOneBase**
> void CouponControllerDeleteOneBase (string id)

Delete one Coupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CouponControllerDeleteOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CouponsApi();
            var id = id_example;  // string | 

            try
            {
                // Delete one Coupon
                apiInstance.CouponControllerDeleteOneBase(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.CouponControllerDeleteOneBase: " + e.Message );
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

<a name="couponcontrollergetmanybase"></a>
# **CouponControllerGetManyBase**
> InlineResponse2004 CouponControllerGetManyBase (List<string> fields, string s, List<string> filter, List<string> or, List<string> sort, List<string> join, int? limit, int? offset, int? page, int? cache)

Retrieve many Coupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CouponControllerGetManyBaseExample
    {
        public void main()
        {


            var apiInstance = new CouponsApi();
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
                // Retrieve many Coupon
                InlineResponse2004 result = apiInstance.CouponControllerGetManyBase(fields, s, filter, or, sort, join, limit, offset, page, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.CouponControllerGetManyBase: " + e.Message );
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

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="couponcontrollergetonebase"></a>
# **CouponControllerGetOneBase**
> Coupon CouponControllerGetOneBase (string id, List<string> fields, List<string> join, int? cache)

Retrieve one Coupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CouponControllerGetOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CouponsApi();
            var id = id_example;  // string | 
            var fields = new List<string>(); // List<string> | Selects resource fields. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#select\" target=\"_blank\">Docs</a> (optional) 
            var join = new List<string>(); // List<string> | Adds relational resources. <a href=\"https://github.com/nestjsx/crud/wiki/Requests#join\" target=\"_blank\">Docs</a> (optional) 
            var cache = 56;  // int? | Reset cache (if was enabled). <a href=\"https://github.com/nestjsx/crud/wiki/Requests#cache\" target=\"_blank\">Docs</a> (optional) 

            try
            {
                // Retrieve one Coupon
                Coupon result = apiInstance.CouponControllerGetOneBase(id, fields, join, cache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.CouponControllerGetOneBase: " + e.Message );
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

[**Coupon**](Coupon.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="couponcontrollerreplaceonebase"></a>
# **CouponControllerReplaceOneBase**
> Coupon CouponControllerReplaceOneBase (Coupon body, string id)

Replace one Coupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CouponControllerReplaceOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CouponsApi();
            var body = new Coupon(); // Coupon | 
            var id = id_example;  // string | 

            try
            {
                // Replace one Coupon
                Coupon result = apiInstance.CouponControllerReplaceOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.CouponControllerReplaceOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Coupon**](Coupon.md)|  | 
 **id** | **string**|  | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="couponcontrollerupdateonebase"></a>
# **CouponControllerUpdateOneBase**
> Coupon CouponControllerUpdateOneBase (Coupon body, string id)

Update one Coupon

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CouponControllerUpdateOneBaseExample
    {
        public void main()
        {


            var apiInstance = new CouponsApi();
            var body = new Coupon(); // Coupon | 
            var id = id_example;  // string | 

            try
            {
                // Update one Coupon
                Coupon result = apiInstance.CouponControllerUpdateOneBase(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.CouponControllerUpdateOneBase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Coupon**](Coupon.md)|  | 
 **id** | **string**|  | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

