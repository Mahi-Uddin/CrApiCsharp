using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace CrApiCsharp
{
    /// <summary>
    /// Main worker class of this wrapper :)
    /// </summary>
    public class API
    {
        private const string url = "http://api.cr-api.com/";

        public string AuthToken;

        /// <summary>
        /// API class constructor
        /// </summary>
        public API(string authToken)
        {
            new Thread(new ThreadStart(UpdateChecker.Check));
            AuthToken = authToken;
        }
        
        /// <summary>
        /// Get direct output from CR API
        /// </summary>
        /// <param name="endpoint">EndPoint to use</param>
        /// <param name="parameter">Parameter to EndPoint (like player ID)</param>
        /// <returns>Returns the JSON string from the request</returns>
        public string Get(EndPoints endpoint, string parameter)
        {
            return Get(url + endpoint.ToString() + "/" + parameter);
        }

        /// <summary>
        /// Deserialize JSON as data
        /// </summary>
        /// <param name="input">JSON string to deserialize</param>
        /// <returns>Returns deserialize class</returns>
        public T Parse<T>(string input)
        {
            return JsonConvert.DeserializeObject<T>(input);
        }

        private string Get(string url)
        {
            WebHeaderCollection headers = new WebHeaderCollection();
            headers.Add($"auth: {AuthToken}");
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(url);
            getRequest.Method = "GET";
            getRequest.Headers = headers;
            WebResponse apiResponse = getRequest.GetResponse();
            StreamReader reader = new StreamReader(apiResponse.GetResponseStream(), Encoding.UTF8);
            string responseString = reader.ReadToEnd();
            reader.Close();
            apiResponse.Close();

            return responseString;
        }
    }
}
