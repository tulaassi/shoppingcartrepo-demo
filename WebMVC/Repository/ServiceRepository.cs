
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Configuration;
using static System.Net.WebRequestMethods;

namespace MVCdemo.Repository
{
    public class ServiceRepository
    {
        HttpClient client; 
        public ServiceRepository()
        {
            client = new HttpClient();

            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["apiBaseURL"].ToString());

        }
        public HttpResponseMessage GetResponse(string url) { return client.GetAsync(url).Result;
        }

    }
}

