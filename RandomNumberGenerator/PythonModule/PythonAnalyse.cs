using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace RandomNumberGenerator.PythonModule
{
    public class PythonAnalyser
    {
        private readonly ScriptEngine _engine;
        public PythonAnalyser()
        {
            _engine = Python.CreateEngine();
        }

        public void Analyse()
        { _engine.ExecuteFile(@"./test.py");
        }
    }
}