﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendPaulo.Data
{
    public class Response<T>
    {
        public int Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public Response()
        {
            this.Success = 0;
        }
    }
}
