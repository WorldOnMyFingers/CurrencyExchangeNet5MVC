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
    public interface ICurrencyApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="localCurrencySymbol"></param>
        /// <returns>List&lt;CurrencyPairNameValue&gt;</returns>
        List<CurrencyPairNameValue> CurrencyGet (string localCurrencySymbol);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CurrencyApi : ICurrencyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CurrencyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrencyApi(String basePath)
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
        ///  
        /// </summary>
        /// <param name="localCurrencySymbol"></param> 
        /// <returns>List&lt;CurrencyPairNameValue&gt;</returns>            
        public List<CurrencyPairNameValue> CurrencyGet (string localCurrencySymbol)
        {
            
    
            var path = "/api/Currency";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (localCurrencySymbol != null) queryParams.Add("localCurrencySymbol", ApiClient.ParameterToString(localCurrencySymbol)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CurrencyGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CurrencyGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CurrencyPairNameValue>) ApiClient.Deserialize(response.Content, typeof(List<CurrencyPairNameValue>), response.Headers);
        }
    
    }
}
