using Pattern.Model;
using Pattern.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Service
{
    public class InterfaceService
    {
        public static string GenerateInterfaceCode(InterfaceData interfaceData)
        {
            InterfaceTemplate t = new InterfaceTemplate();
            t.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();
            t.Session["interfaceParameters"] = interfaceData;
            t.Session["methods"] = interfaceData.Methods;
            // Add other parameter values to t.Session here.
            t.Initialize(); // Must call this to transfer values.
            string resultText = t.TransformText();
            return resultText;
        }
    }
}
