
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace techlink
{
    public class JsonResponse<T>
    {
        public string code
        {
            get;
            set;
        }

        public string message
        {
            get;
            set;
        }

        public T data {
            get;
            set;
        }

        public IEnumerable<T> collection
        {
            get;
            set;
        }


        public JsonResponse(string code, string message)
        {
            this.code = code;
            this.message = message;
        }

        public JsonResponse(string code, string message, T data)
        {
            this.code = code;
            this.message = message;
            this.data = data;
        }

        public JsonResponse(string code, string message, IEnumerable<T> data)
        {
            this.code = code;
            this.message = message;
            this.collection = collection;
        }
    }
}