using System.Dynamic;
using System.Net;

namespace HerwegBrasil.Dtos
{
    public class ResponseGeneric<T> where T : class
    {   
        public HttpStatusCode CodigoHttp { get; set;}
        public T? DataReturn { get; set;}
        public ExpandoObject? ErrorReturn { get; set;}
    }
}
