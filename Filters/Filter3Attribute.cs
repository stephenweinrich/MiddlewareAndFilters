using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Filters
{
    public class Filter3 : Attribute, IFilterFactory
    {
        // Implement IFilterFactory
        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            return new InternalAddHeaderFilter();
        }

        private class InternalAddHeaderFilter : IResultFilter
        {
            public void OnResultExecuting(ResultExecutingContext context)
            {
                Console.WriteLine("Filter 3 - BEFORE");
            }

            public void OnResultExecuted(ResultExecutedContext context)
            {
                Console.WriteLine("Filter 3 - AFTER");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
