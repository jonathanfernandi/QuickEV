using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickEV_Website.Modules
{
    public class Response<T>
    {
        public String Message { get; set; }
        public T Payload { get; set; }
        public Boolean IsSuccess { get; set; }
    }
}