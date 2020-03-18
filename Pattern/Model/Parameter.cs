using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    public class Parameter
    {
        public string ParameterType { get; set;}
        public string ParameterName { get; set; }
        public string AccessModifier { get; set; }

        public Parameter()
        {
        }

        public Parameter(string parameterType, string parameterName)
        {
            ParameterType = parameterType;
            ParameterName = parameterName;
        }

        public Parameter(string parameterType, string parameterName, string accessModifier) : this(parameterType, parameterName)
        {
            AccessModifier = accessModifier;
        }
    }
}
