using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace WpfApp1
{
    class Connection
    {
        public HttpWebRequest request;
        public HttpWebResponse response;
        public Connection(string url)
        {
            request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Headers.Add("X-Gismeteo-Token", "56b30cb255.3443075");
            request.Headers.Add("Accept-Encoding", "deflate, gzip");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
        }
        public HttpWebResponse GetNewResponse()
        {
            response = (HttpWebResponse) request.GetResponse();
            return response;
        }
    }
}
