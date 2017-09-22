using System;
using System.Configuration;

namespace GetDataConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RetrieveDataSync strSync = new RetrieveDataSync();
            string strOutput = strSync.GetDataFromAPI();

            AppSettingsReader ar = new AppSettingsReader();
            string outLocation = (string)ar.GetValue("dataoutputlocation", typeof(string));
            if (outLocation == "Console") Console.WriteLine(strOutput);
            Console.ReadLine();
        }
    }
}
