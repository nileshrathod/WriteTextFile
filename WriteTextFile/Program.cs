using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = DateTime.Now.ToString("HH-mm-ss-ffffff").ToString() + "-" + "Sample.txt";
            
            string path = Path.Combine(@"C:\Code Files", name);
            
            using (StreamWriter sw = File.CreateText(path))
            {
               sw.WriteLine("This is just a test text.");
            }

        }
    }
}
