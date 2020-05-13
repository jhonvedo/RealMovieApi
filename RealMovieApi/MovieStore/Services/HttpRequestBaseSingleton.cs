using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public static class HttpRequestBaseSingleton
    {
        private static HttpRequestBase _instance;
        public const string DEFAULT_URL_BASE = "http://api.tvmaze.com";

        public static void Init(string urlBase)
        {
            _instance = new HttpRequestBase(urlBase);
        }
        public static HttpRequestBase GetInstance()
        {
            if(_instance == null)
            {
                Init(DEFAULT_URL_BASE);
            }
            return _instance;
        }



    }
}
