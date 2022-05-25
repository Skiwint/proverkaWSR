using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace DiplomApp.Clasess
{
    public class AllModel<TObj> where TObj : ModelAbstract
    {
        private string Path { get; set; }

        public AllModel(string path)
        {
            Path = path;
        }

        public List<TObj> Objs { get => Get(); }
        
        private List<TObj> Get()
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://localhost:5001/api/{Path}/"),
            };
            var response = client.Send(request);
            return JsonConvert.DeserializeObject<List<TObj>>(response.Content.ReadAsStringAsync().Result) ??
                new List<TObj>();
        }
    }
}
