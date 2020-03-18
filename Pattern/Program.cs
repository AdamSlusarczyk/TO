using Pattern.Model;
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
            InterfaceTemplate t = new InterfaceTemplate();
            InterfaceData interfaceData = new InterfaceData("Pattern", "IBuilder");
            Method m = new Method("string", "metoda");
            Parameter p = new Parameter("string","test");
            m.Parameters.Add(p);
            interfaceData.Methods.Add(m);
            t.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
            t.Session["interfaceParameters"] = interfaceData;
            t.Session["methods"] = interfaceData.Methods;
            // Add other parameter values to t.Session here.
            t.Initialize(); // Must call this to transfer values.
            string resultText = t.TransformText();
            Console.WriteLine(resultText);
            Console.ReadKey();
            ClassTemplate ct = new ClassTemplate();
            ClassData classData = new ClassData("Pattern", "IBuilder","baseClass");
            Method mc = new Method("string", "metoda","public");
            Parameter pc = new Parameter("string", "test","public");
            mc.Parameters.Add(pc);
            classData.Methods.Add(mc);
            classData.Parameters.Add(pc);
            classData.Parameters.Add(pc);
            ct.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
            ct.Session["classParameters"] =classData;
            ct.Session["methods"] = classData.Methods;
            // Add other parameter values to t.Session here.
            ct.Initialize(); // Must call this to transfer values.
            string resultTextc = ct.TransformText();
            Console.WriteLine(resultTextc);
            Console.ReadKey();
        }
    }
}
