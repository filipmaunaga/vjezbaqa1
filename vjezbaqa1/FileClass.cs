﻿using System;
using System.IO;


namespace vjezbaqa1
{
    class FileClass
    {
        public static string LogFileName = "C:\\Users\\fgtttg\\Documents\\QA\\Report.log";
        public static void Log(string LogMessage)
        {
            using (StreamWriter file = new StreamWriter(LogFileName, true))
            {
                file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss K"));
                file.WriteLine(LogMessage);
                file.WriteLine("**********");
                file.WriteLine();
            }
        }
    }
}
