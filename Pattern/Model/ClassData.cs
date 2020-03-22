using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    public class ClassData
    {
        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public List<Method> Methods { get; set; }
        public List<Method> OverriddenMethods { get; set; }
        public List<Parameter> Parameters { get; set; }
        public string BaseClassName { get; set; }

        public ClassData(string @namespace, string className, string baseClassName)
        {
            Namespace = @namespace;
            ClassName = className;
            BaseClassName = baseClassName;
            Methods = new List<Method>();
            OverriddenMethods = new List<Method>();
            Parameters = new List<Parameter>();
        }

        public ClassData(string @namespace, string className)
        {
            Namespace = @namespace;
            ClassName = className;
            Methods = new List<Method>();
            OverriddenMethods = new List<Method>();
            Parameters = new List<Parameter>();
        }

        public ClassData()
        {
            Methods = new List<Method>();
            OverriddenMethods = new List<Method>();
            Parameters = new List<Parameter>();
        }
    }
}
