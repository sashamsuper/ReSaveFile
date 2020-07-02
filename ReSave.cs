using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class ReSave 
    {
        public static void Main()
        {
        	OpenFileDialog.Show();
        	Console.WriteLine("MainFile");
        	SomeFile someFile=new SomeFile();
        }
    }
}