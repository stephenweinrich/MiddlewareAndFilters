using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Filters
{
    public class Filter1 : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Filter 1 - BEFORE");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Filter 1 - AFTER");
        }
    }
}
