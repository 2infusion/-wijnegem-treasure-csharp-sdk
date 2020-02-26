# IO.Swagger.Api.GameApi

All URIs are relative to *https://wijnegem-treasure-api.herokuapp.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUserInfo**](GameApi.md#createuserinfo) | **POST** /game/user-info | 
[**GameControllerLeaderBoardTotal**](GameApi.md#gamecontrollerleaderboardtotal) | **GET** /game/leaderboard-total | 
[**Map**](GameApi.md#map) | **GET** /game/map | 
[**MyCoupons**](GameApi.md#mycoupons) | **GET** /game/my-coupons | 
[**UnlockTreasureById**](GameApi.md#unlocktreasurebyid) | **POST** /game/unlock-treasure | 
[**ValidateCouponById**](GameApi.md#validatecouponbyid) | **POST** /game/validate-coupon | 

<a name="createuserinfo"></a>
# **CreateUserInfo**
> UserInfo CreateUserInfo (UserInfo body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserInfoExample
    {
        public void main()
        {


            var apiInstance = new GameApi();
            var body = new UserInfo(); // UserInfo | 

            try
            {
                UserInfo result = apiInstance.CreateUserInfo(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GameApi.CreateUserInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserInfo**](UserInfo.md)|  | 

### Return type

[**UserInfo**](UserInfo.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gamecontrollerleaderboardtotal"></a>
# **GameControllerLeaderBoardTotal**
> Coupon GameControllerLeaderBoardTotal ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GameControllerLeaderBoardTotalExample
    {
        public void main()
        {


            var apiInstance = new GameApi();

            try
            {
                Coupon result = apiInstance.GameControllerLeaderBoardTotal();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GameApi.GameControllerLeaderBoardTotal: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Coupon**](Coupon.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="map"></a>
# **Map**
> Dictionary Map ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapExample
    {
        public void main()
        {


            var apiInstance = new GameApi();

            try
            {
                Dictionary result = apiInstance.Map();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GameApi.Map: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary**

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mycoupons"></a>
# **MyCoupons**
> List<Coupon> MyCoupons ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MyCouponsExample
    {
        public void main()
        {


            var apiInstance = new GameApi();

            try
            {
                List&lt;Coupon&gt; result = apiInstance.MyCoupons();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GameApi.MyCoupons: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Coupon>**](Coupon.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlocktreasurebyid"></a>
# **UnlockTreasureById**
> OpenTreasure UnlockTreasureById (UnlockTreasure body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnlockTreasureByIdExample
    {
        public void main()
        {


            var apiInstance = new GameApi();
            var body = new UnlockTreasure(); // UnlockTreasure | 

            try
            {
                OpenTreasure result = apiInstance.UnlockTreasureById(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GameApi.UnlockTreasureById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnlockTreasure**](UnlockTreasure.md)|  | 

### Return type

[**OpenTreasure**](OpenTreasure.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatecouponbyid"></a>
# **ValidateCouponById**
> Coupon ValidateCouponById (UnlockTreasure body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidateCouponByIdExample
    {
        public void main()
        {


            var apiInstance = new GameApi();
            var body = new UnlockTreasure(); // UnlockTreasure | 

            try
            {
                Coupon result = apiInstance.ValidateCouponById(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GameApi.ValidateCouponById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnlockTreasure**](UnlockTreasure.md)|  | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

