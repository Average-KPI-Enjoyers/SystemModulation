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
            ICollection<string> searchPaths = _engine.GetSearchPaths();
            searchPaths.Add(@"./PythonModule/venv/lib");
            searchPaths.Add(@"./PythonModule/venv/lib/site-packages");
            _engine.SetSearchPaths(searchPaths);
        }

        public void Analyse()
        { 
            _engine.ExecuteFile(@"./PythonModule/analyser.py");
        }
    }
}