using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model.InputData
{
    public class BuilderInput : InputPattern
    {
        public InterfaceData IBuilder { get; set; } //tutaj będzie namespace i metody, które musza zamplementować inne klasy
        public ClassData Director { get; set; }
        public ClassData Product { get; set; }
        public List<ClassData> ConcreteBuilders{ get; set; }// metody z interfejsu (OverriddenMethods) + metody własne (Methods)
    }
}
