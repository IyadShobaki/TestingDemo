using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class Example
    {
        public static string ExampleLoadTextFile(string file)
        {
            if (file.Length < 10)
            {
                //throw new System.IO.FileNotFoundException();
                throw new ArgumentException("The file name was too short", "file");
            }

            return "The file was correctly loaded.";
        }
    }
}
