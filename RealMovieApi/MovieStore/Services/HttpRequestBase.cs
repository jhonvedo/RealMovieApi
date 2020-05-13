using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class HttpRequestBase
    {
       

        protected RestClient _client = null;
        public HttpRequestBase(string urlBase)
        {
            _client = new RestClient(urlBase);
        }

        public IRestResponse ConsumeService(string path)
        {          
            var request = new RestRequest(path,Method.GET);
            _= request.AddHeader("Content-Type", "application/json");
            IRestResponse response = _client.Execute(request);  
            return response;
        }

        public T ConsumeService<T>(string path)where T:class
        {
            IRestResponse response = ConsumeService(path);
            if (!response.IsSuccessful)
            {
                throw new Exception(response.Content);
            }
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
