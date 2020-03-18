using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    public class Method
    {
        public List<Parameter> Parameters { get; set; }
        public string ReturnType { get; set; }
        public string MethodName { get; set; }
        public string AccessModifier { get; set; }

        public Method()
        {
            Parameters = new List<Parameter>();
        }

        public Method(string returnType, string methodName)
        {
            ReturnType = returnType;
            MethodName = methodName;
            Parameters = new List<Parameter>();
        }

        public Method(string returnType, string methodName, string accessModifier) : this(returnType, methodName)
        {
            AccessModifier = accessModifier;
        }

        public Method(List<Parameter> parameters, string returnType, string methodName, string accessModifier) : this(returnType, methodName, accessModifier)
        {
            Parameters = parameters;
        }
    }
}
