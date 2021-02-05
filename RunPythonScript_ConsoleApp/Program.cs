using System;

namespace RunPythonScript_ConsoleApp
{
    public class Program
    {

        // Get config settings
        private static string filePythonExePath = "C:\\Program Files\\Python38\\python.exe";
        //private static string folderImagePath = Properties.Settings.Default.FolderImagePath;
        private static string filePythonNamePath = "C:\\GitRepository\\RunPythonScript_ConsoleApp\\python_script.py";
        private static string filePythonParameter = "2";

        static void Main(string[] args)
        {
            string outputText, standardError;

            // Instantiate C# - Python class object            
            ICSharpPython mlSharpPython = new CSharpPython(filePythonExePath);

            // Test image
            //string imagePathName = folderImagePath + "Image_Test_Name.png";

            // Define Python script file and input parameter name
            string fileNameParameter = $"{filePythonNamePath} {filePythonParameter}";

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
