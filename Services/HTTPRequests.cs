using EntitiesModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Services
{
    public class HTTPRequests
    {
        private string url;
        public async Task<string> getCountrys()
        {
            url = "https://restcountries.com/v3.1/all";
            WebRequest webRequest = WebRequest.Create(url);
            WebResponse response = webRequest.GetResponse();
            StreamReader sreader = new StreamReader(response.GetResponseStream());

            return await sreader.ReadToEndAsync();
        }
    }
}
