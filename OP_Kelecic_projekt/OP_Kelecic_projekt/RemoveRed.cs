using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Kelecic_projekt
{
    class RemoveRed : RemoveColor
    {
        ScriptEngine pyEngine = null;
        ScriptScope pyScope = null;

        public RemoveRed (int width, int height) : base(width, height)
        {

        }

        public override Bitmap DoEdit(Bitmap image)
        {
            if (image != null)
            {
                pyEngine = Python.CreateEngine();
                pyScope = pyEngine.CreateScope();

                ScriptSource skript = pyEngine.CreateScriptSourceFromFile("C:/Users/Kele/Documents/Visual Studio 2017/Projects/OP_Kelecic_projekt/IronPythonRemovingColors/IronPythonRemovingColors.py");
                skript.Execute(pyScope);
                dynamic pyScript = pyScope.GetVariable("Main");
                image = pyScript(image, "RED");
            }
            return image;
        }
    }
}
