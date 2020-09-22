using Newtonsoft.Json;
using sCTNSolution.AppTest.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace sCTNSolution.AppTest.Service
{
    public class serverapi
    {
       
        public static HttpClient _client { get; set; }
        public static string _token {get;set;}
        public static string url = ConfigurationManager.AppSettings["serverapi"];
        public static void ConfigarutionAsync()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(url);
         //   var imei = Hashing.GetHDDSerialNo();

        }
        //Authorize
        ////api/{controller}
        public static async Task<List<T>> GetListDataAsync<T>(string api)
        {
            //api / TblNhanviens / 5
            _client.DefaultRequestHeaders.Accept.Clear();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            _client.DefaultRequestHeaders.Accept.Add(contentType);
            _client.DefaultRequestHeaders.Authorization =
                                        new AuthenticationHeaderValue("Bearer", serverapi._token);
            HttpResponseMessage response = await _client.GetAsync($"api/{api}");
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
            {
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                string json = await response.Content.ReadAsStringAsync();

                if (!json.Equals(""))
                {
                    return JsonConvert.DeserializeObject<List<T>>(json);
                }
                else
                {
                    return default(List<T>);
                }
            }
            else
            {
                return default(List<T>);
            }
        }
        public static async Task<T> GetDataAsync<T>(string api)
        {
            //api / TblNhanviens / 5
            _client.DefaultRequestHeaders.Accept.Clear();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            _client.DefaultRequestHeaders.Accept.Add(contentType);
            _client.DefaultRequestHeaders.Authorization =
                                        new AuthenticationHeaderValue("Bearer", serverapi._token);
            HttpResponseMessage response = await _client.GetAsync($"api/{api}");
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
            {
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                string json = await response.Content.ReadAsStringAsync();

                if (!json.Equals(""))
                {
                    return JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    return default(T);
                }
            }
            else
            {
                return default(T);
            }
        }
        //post
        public static async Task<ValueReponse<T>> PostDataAsync<T>(string api, T data)
        {
            //api / TblNhanviens / 5
            HttpResponseMessage response = await _client.PostAsJsonAsync($"api/{api}", data);
            response.EnsureSuccessStatusCode();
            bool json1 = response.IsSuccessStatusCode;// .Content.ReadAsStringAsync();
            // return URI of the created resource.
            string json = await response.Content.ReadAsStringAsync();
            return new ValueReponse<T> { state = json1, msge = json, data = JsonConvert.DeserializeObject<List<T>>(json) };
            
        }
        public static async Task<string> Authenticate<T>(string api, T data)
        {
            //api / TblNhanviens / 5
            HttpResponseMessage response = await _client.PostAsJsonAsync($"api/{api}", data);
            response.EnsureSuccessStatusCode();
            bool json1 = response.IsSuccessStatusCode;// .Content.ReadAsStringAsync();
            // return URI of the created resource.
            string json = await response.Content.ReadAsStringAsync();
            return json;

        }
        //public static void Checkconnect()
        //{

        //}
    }
}
