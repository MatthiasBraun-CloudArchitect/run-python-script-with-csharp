using System;
using System.Collections.Generic;
using System.Text;

namespace RunPythonScript_ConsoleApp
{
    public interface ICSharpPython
    {
        string ExecutePythonScript(string filePythonScript, out string standardError);
    }
}
