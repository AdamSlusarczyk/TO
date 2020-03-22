using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    public class StrategyInput:InputPattern
    {
        public InterfaceData IStrategy { get; set; } //tutaj będzie namespace i metody, które musza zamplementować inne klasy
        public ClassData Context { get; set; }
        public List<ClassData> ConcreteStrategy { get; set; }// metody z interfejsu (OverriddenMethods) + metody własne (Methods)
    }
}
