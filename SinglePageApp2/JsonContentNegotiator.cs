using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;
using Newtonsoft.Json.Serialization;

namespace SinglePageApp2
{
    public class JsonContentNegotiator : IContentNegotiator
    {
        private readonly JsonMediaTypeFormatter _jsonFormatter;


        public JsonContentNegotiator ()
        {
            _jsonFormatter = new JsonMediaTypeFormatter
            {
                SerializerSettings = new Newtonsoft.Json.JsonSerializerSettings 
                { 
                    PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects
                }
            };
        }

        public JsonContentNegotiator (JsonMediaTypeFormatter formatter)
        {
            _jsonFormatter = formatter;
        }


        public ContentNegotiationResult Negotiate (Type type, HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
        {
            var result = new ContentNegotiationResult (_jsonFormatter, new MediaTypeHeaderValue ("application/json"));
            return result;
        }

    }
}