﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ContosoWeb.Utils
{
    public class HttpClientWrapper : HttpClient, IHttpClient
    {
        public HttpClientWrapper()
        {
            var accountKey = Encoding.ASCII.GetBytes(ConfigurationHelpers.GetString("MachineLearning.AccountKey"));
            var header = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(accountKey));
            DefaultRequestHeaders.Authorization = header;
        }
    }
}