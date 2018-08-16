using System;
using System.Collections.Generic;
using System.Text;

using System.Net.Http;
using System.Threading.Tasks;

namespace WebTextGetter
{
    public class GetClient
    {
        private static HttpClient _client = new HttpClient();

        public GetClient()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _client.Timeout = TimeSpan.FromMinutes(1);
        }

        public async Task GetBody(string ncode, int page)
        {
            var body = await Get(GetUrlFormatter.GetBody("n0757ey", 1));
            Console.WriteLine(body);
        }
        
        private async Task<string> Get(string url)
        {
            try
            {
                var result = await _client.GetAsync(url);
                result.EnsureSuccessStatusCode();
                var message = await result.Content.ReadAsStringAsync();
                return message;
            }
            catch 
            {
                throw;
            }
        }
    }
}
