using Phantasma.RPC.Sharp.Client;
using Phantasma.RPC.Sharp.Model;
using RestSharp;

namespace Phantasma.RPC.Sharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuctionApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="symbol"></param>
        /// <param name="iDtext"></param>
        /// <returns>AuctionResult</returns>
        AuctionResult GetAuction(string chainAddressOrName, string symbol, string iDtext);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="symbol"></param>
        /// <returns>int?</returns>
        int? GetAuctionsCount(string chainAddressOrName, string symbol);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="symbol"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns>PaginatedResult</returns>
        PaginatedResult GetAuctions(string chainAddressOrName, string symbol, int? page, int? pageSize);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuctionApi : IAuctionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuctionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuctionApi(String basePath)
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
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="symbol"></param>
        /// <param name="iDtext"></param>
        /// <returns>AuctionResult</returns>
        public AuctionResult GetAuction(string chainAddressOrName, string symbol, string iDtext)
        {
            var path = "/api/v1/GetAuction";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (chainAddressOrName != null)
                queryParams.Add("chainAddressOrName",
                    ApiClient.ParameterToString(chainAddressOrName)); // query parameter
            if (symbol != null) queryParams.Add("symbol", ApiClient.ParameterToString(symbol)); // query parameter
            if (iDtext != null) queryParams.Add("IDtext", ApiClient.ParameterToString(iDtext)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
                headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAuctionGet: " + response.Content,
                    response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetAuctionGet: " + response.ErrorMessage, response.ErrorMessage);

            return (AuctionResult)ApiClient.Deserialize(response.Content, typeof(AuctionResult), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="symbol"></param>
        /// <returns>int?</returns>
        public int? GetAuctionsCount(string chainAddressOrName, string symbol)
        {
            var path = "/api/v1/GetAuctionsCount";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (chainAddressOrName != null)
                queryParams.Add("chainAddressOrName",
                    ApiClient.ParameterToString(chainAddressOrName)); // query parameter
            if (symbol != null) queryParams.Add("symbol", ApiClient.ParameterToString(symbol)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
                headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetAuctionsCountGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetAuctionsCountGet: " + response.ErrorMessage, response.ErrorMessage);

            return (int?)ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="symbol"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns>PaginatedResult</returns>
        public PaginatedResult GetAuctions(string chainAddressOrName, string symbol, int? page, int? pageSize)
        {
            var path = "/api/v1/GetAuctions";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (chainAddressOrName != null)
                queryParams.Add("chainAddressOrName",
                    ApiClient.ParameterToString(chainAddressOrName)); // query parameter
            if (symbol != null) queryParams.Add("symbol", ApiClient.ParameterToString(symbol)); // query parameter
            if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
                headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAuctionsGet: " + response.Content,
                    response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetAuctionsGet: " + response.ErrorMessage, response.ErrorMessage);

            return (PaginatedResult)ApiClient.Deserialize(response.Content, typeof(PaginatedResult), response.Headers);
        }
    }
}