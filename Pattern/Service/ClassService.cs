using Pattern.Model;
using Pattern.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Service
{
    public class ClassService
    {
        public static string GenerateClassCode(ClassData classData)
        {
            ClassTemplate t = new ClassTemplate();
            t.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
            t.Session["classParameters"] = classData;
            t.Session["methods"] = classData.Methods;
            // Add other parameter values to t.Session here.
            t.Initialize(); // Must call this to transfer values.
            string resultText = t.TransformText();
            return resultText;
        }

    }
}
