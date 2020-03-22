using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    public class DecoratorInput : InputPattern
    {
        public InterfaceData Component { get; set; } //tutaj będzie namespace i metody, które musza zamplementować inne klasy
        public ClassData Decorator { get; set; } 
        public List<ClassData> ConcreteComponents { get; set; }// metody z interfejsu (OverriddenMethods) + metody własne (Methods)
        public List<ClassData> ConcreteDecorators { get; set; }// metody z interfejsu (OverriddenMethods) + metody własne (Methods)
    }
}
