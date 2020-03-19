using Pattern.Model;
using Pattern.Service;
using Pattern.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceData interfaceData = new InterfaceData("Pattern", "IBuilder");
            Method m = new Method("string", "metoda");
            Parameter p = new Parameter("string","test");
            m.Parameters.Add(p);
            interfaceData.Methods.Add(m);
            string resultText = InterfaceService.GenerateInterfaceCode(interfaceData);
            Console.WriteLine(resultText);
            Console.ReadKey();
            ClassData classData = new ClassData("Pattern", "IBuilder","baseClass");
            Method mc = new Method("string", "metoda","public");
            Parameter pc = new Parameter("string", "test","public");
            mc.Parameters.Add(pc);
            classData.Methods.Add(mc);
            classData.Parameters.Add(pc);
            classData.Parameters.Add(pc);
            string resultTextc = ClassService.GenerateClassCode(classData);
            
        }
    }
}
