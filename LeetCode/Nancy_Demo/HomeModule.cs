using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy_Demo
{
    public class HomeModule:NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters => "Hello World from Nancy";
        }
    }
}
