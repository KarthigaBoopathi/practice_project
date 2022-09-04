using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("D:\\Practice\\practiceproject\\studentdata.txt");
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
