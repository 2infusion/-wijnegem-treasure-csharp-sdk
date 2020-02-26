using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOpenTreasureApi
    {
        /// <summary>
        /// Create many OpenTreasure 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>List&lt;OpenTreasure&gt;</returns>
        List<OpenTreasure> OpenTreasureControllerCreateManyBase (CreateManyOpenTreasureDto body);
        /// <summary>
        /// Create one OpenTreasure 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>OpenTreasure</returns>
        OpenTreasure OpenTreasureControllerCreateOneBase (OpenTreasure body);
        /// <summary>
        /// Delete one OpenTreasure 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void OpenTreasureControllerDeleteOneBase (string id);
        /// <summary>
        /// Retrieve many OpenTreasure 
        /// </summary>
        /// <param name="fields">Selects resource fields. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#select\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="s">Adds search condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#search\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="filter">Adds filter condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#filter\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="or">Adds OR condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#or\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="sort">Adds sort by field. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#sort\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="join">Adds relational resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#join\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="limit">Limit amount of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#limit\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="offset">Offset amount of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#offset\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="page">Page portion of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#page\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="cache">Reset cache (if was enabled). &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#cache\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 OpenTreasureControllerGetManyBase (List<string> fields, string s, List<string> filter, List<string> or, List<string> sort, List<string> join, int? limit, int? offset, int? page, int? cache);
        /// <summary>
        /// Retrieve one OpenTreasure 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Selects resource fields. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#select\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="join">Adds relational resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#join\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="cache">Reset cache (if was enabled). &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#cache\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <returns>OpenTreasure</returns>
        OpenTreasure OpenTreasureControllerGetOneBase (string id, List<string> fields, List<string> join, int? cache);
        /// <summary>
        /// Replace one OpenTreasure 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>OpenTreasure</returns>
        OpenTreasure OpenTreasureControllerReplaceOneBase (OpenTreasure body, string id);
        /// <summary>
        /// Update one OpenTreasure 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>OpenTreasure</returns>
        OpenTreasure OpenTreasureControllerUpdateOneBase (OpenTreasure body, string id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OpenTreasureApi : IOpenTreasureApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenTreasureApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OpenTreasureApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenTreasureApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OpenTreasureApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Create many OpenTreasure 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>List&lt;OpenTreasure&gt;</returns>
        public List<OpenTreasure> OpenTreasureControllerCreateManyBase (CreateManyOpenTreasureDto body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling OpenTreasureControllerCreateManyBase");
    
            var path = "/open-treasure/bulk";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerCreateManyBase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerCreateManyBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<OpenTreasure>) ApiClient.Deserialize(response.Content, typeof(List<OpenTreasure>), response.Headers);
        }
    
        /// <summary>
        /// Create one OpenTreasure 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>OpenTreasure</returns>
        public OpenTreasure OpenTreasureControllerCreateOneBase (OpenTreasure body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling OpenTreasureControllerCreateOneBase");
    
            var path = "/open-treasure";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerCreateOneBase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerCreateOneBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OpenTreasure) ApiClient.Deserialize(response.Content, typeof(OpenTreasure), response.Headers);
        }
    
        /// <summary>
        /// Delete one OpenTreasure 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void OpenTreasureControllerDeleteOneBase (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OpenTreasureControllerDeleteOneBase");
    
            var path = "/open-treasure/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerDeleteOneBase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerDeleteOneBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Retrieve many OpenTreasure 
        /// </summary>
        /// <param name="fields">Selects resource fields. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#select\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="s">Adds search condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#search\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="filter">Adds filter condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#filter\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="or">Adds OR condition. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#or\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="sort">Adds sort by field. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#sort\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="join">Adds relational resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#join\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="limit">Limit amount of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#limit\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="offset">Offset amount of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#offset\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="page">Page portion of resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#page\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="cache">Reset cache (if was enabled). &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#cache\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 OpenTreasureControllerGetManyBase (List<string> fields, string s, List<string> filter, List<string> or, List<string> sort, List<string> join, int? limit, int? offset, int? page, int? cache)
        {
    
            var path = "/open-treasure";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (s != null) queryParams.Add("s", ApiClient.ParameterToString(s)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (or != null) queryParams.Add("or", ApiClient.ParameterToString(or)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (join != null) queryParams.Add("join", ApiClient.ParameterToString(join)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (cache != null) queryParams.Add("cache", ApiClient.ParameterToString(cache)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerGetManyBase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerGetManyBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        /// Retrieve one OpenTreasure 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Selects resource fields. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#select\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="join">Adds relational resources. &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#join\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <param name="cache">Reset cache (if was enabled). &lt;a href&#x3D;\&quot;https://github.com/nestjsx/crud/wiki/Requests#cache\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Docs&lt;/a&gt;</param>
        /// <returns>OpenTreasure</returns>
        public OpenTreasure OpenTreasureControllerGetOneBase (string id, List<string> fields, List<string> join, int? cache)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OpenTreasureControllerGetOneBase");
    
            var path = "/open-treasure/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (join != null) queryParams.Add("join", ApiClient.ParameterToString(join)); // query parameter
 if (cache != null) queryParams.Add("cache", ApiClient.ParameterToString(cache)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerGetOneBase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerGetOneBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OpenTreasure) ApiClient.Deserialize(response.Content, typeof(OpenTreasure), response.Headers);
        }
    
        /// <summary>
        /// Replace one OpenTreasure 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>OpenTreasure</returns>
        public OpenTreasure OpenTreasureControllerReplaceOneBase (OpenTreasure body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling OpenTreasureControllerReplaceOneBase");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OpenTreasureControllerReplaceOneBase");
    
            var path = "/open-treasure/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerReplaceOneBase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerReplaceOneBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OpenTreasure) ApiClient.Deserialize(response.Content, typeof(OpenTreasure), response.Headers);
        }
    
        /// <summary>
        /// Update one OpenTreasure 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <returns>OpenTreasure</returns>
        public OpenTreasure OpenTreasureControllerUpdateOneBase (OpenTreasure body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling OpenTreasureControllerUpdateOneBase");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OpenTreasureControllerUpdateOneBase");
    
            var path = "/open-treasure/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearer" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerUpdateOneBase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OpenTreasureControllerUpdateOneBase: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OpenTreasure) ApiClient.Deserialize(response.Content, typeof(OpenTreasure), response.Headers);
        }
    
    }
}
