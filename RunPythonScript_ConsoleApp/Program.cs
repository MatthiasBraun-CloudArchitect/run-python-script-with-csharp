using System;

namespace RunPythonScript_ConsoleApp
{
    public class Program
    {

        // Get config settings
        private static string filePythonExePath = "C:\\Program Files\\Python38\\python.exe";
        private static string filePythonNamePath = "C:\\GitRepository\\run-python-script-with-csharp\\RunPythonScript_ConsoleApp\\python_script.py";

        static void Main(string[] args)
        {
            string outputText, standardError, pythonParameter;

            // Instantiate C# - Python class object            
            ICSharpPython mlSharpPython = new CSharpPython(filePythonExePath);

            Console.WriteLine("Please enter a number for the multiplication calculation (x*10).");
            pythonParameter = Console.ReadLine();

            // Define Python script file and input parameter name
            string fileNameParameter = $"{filePythonNamePath} {pythonParameter}";

            // Execute the python script file 
            outputText = mlSharpPython.ExecutePythonScript(fileNameParameter, out standardError);
            if (string.IsNullOrEmpty(standardError))
            {
                        Console.WriteLine(outputText);
                        
            }
            else
            {
                Console.WriteLine(standardError);
            }
            Console.ReadKey();
        }
    }
}
