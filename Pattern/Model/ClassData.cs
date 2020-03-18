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
        public List<Parameter> Parameters { get; set; }
        public string BaseClassName { get; set; }

        public ClassData(string @namespace, string className, List<Method> methods, string baseClassName)
        {
            Namespace = @namespace;
            ClassName = className;
            Methods = methods;
            BaseClassName = baseClassName;
            Parameters = new List<Parameter>();
        }

        public ClassData(string @namespace, string className, List<Method> methods)
        {
            Namespace = @namespace;
            ClassName = className;
            Methods = methods;
            Parameters = new List<Parameter>();

        }

        public ClassData(string @namespace, string className)
        {
            Namespace = @namespace;
            ClassName = className;
            Methods = new List<Method>();
            Parameters = new List<Parameter>();

        }

        public ClassData()
        {
            Methods = new List<Method>();
            Parameters = new List<Parameter>();
        }

        public ClassData(string @namespace, string className, List<Method> methods, List<Parameter> parameters, string baseClassName) : this(@namespace, className, methods)
        {
            Parameters = parameters;
            BaseClassName = baseClassName;
        }

        public ClassData(string @namespace, string className, List<Method> methods, List<Parameter> parameters) : this(@namespace, className, methods)
        {
            Parameters = parameters;
        }

        public ClassData(string @namespace, string className, List<Parameter> parameters) : this(@namespace, className)
        {
            Parameters = parameters;
        }

        public ClassData(string @namespace, string className, List<Parameter> parameters, string baseClassName) : this(@namespace, className, parameters)
        {
            BaseClassName = baseClassName;
            Parameters = new List<Parameter>();

        }

        public ClassData(string @namespace, string className, string baseClassName) : this(@namespace, className)
        {
            BaseClassName = baseClassName;
            Methods = new List<Method>();
            Parameters = new List<Parameter>();
        }
    }
}
