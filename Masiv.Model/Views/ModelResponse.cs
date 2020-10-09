using System.Collections.Generic;
using System.Net;

namespace Masiv.Model.Views
{
    public class ModelResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public IEnumerable<T> Data { get; set; }
        public T Item { get; set; }
    }
}