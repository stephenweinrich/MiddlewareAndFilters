using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Response
    {
        public object Data { get; set; }
        public Error Error { get; set; }
    }
}
