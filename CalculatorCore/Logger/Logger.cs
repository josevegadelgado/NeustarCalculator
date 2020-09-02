using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CalculatorCore.Logger
{
    internal static class Logger
    {


        private static string LogFolder
        {  
            get {
            return "C:\\DataLog.txt";
            }
        }
         

        public static void SaveLogInformation(string pStrMessage) {


            using (StreamWriter outputFile = (File.Exists(LogFolder)) ? File.AppendText(LogFolder) : File.CreateText(LogFolder))
            {
                outputFile.WriteLine(pStrMessage);
            }             
        }


    }
}
