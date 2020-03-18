using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    public class InterfaceData
    {
        public string Namespace { get; set; }
        public string InterfaceName { get; set; }
        public List<Method> Methods { get; set; }

        public InterfaceData()
        {
            Methods = new List<Method>();
        }

        public InterfaceData(string @namespace, string interfaceName, List<Method> methods)
        {
            Namespace = @namespace;
            InterfaceName = interfaceName;
            Methods = methods;
        }

        public InterfaceData(string @namespace, string interfaceName)
        {
            Namespace = @namespace;
            InterfaceName = interfaceName;
            Methods = new List<Method>();
        }
    }
}
