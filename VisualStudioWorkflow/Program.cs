using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioWorkflow
{
    //A simple Program to help me familiarize with GitHub+VS workflow
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Modification to Pull in VS!");
            Console.WriteLine("Another modification to Fetch in VS!!");
            //Fetch stores additional commits not available in the current branch in the local repository, but does not merge them, while Pull does.
            //Verdict: Fetch is useful for simply keeping your repo up-to-date, but you have to merge afterwards.
            Console.Read();
        }
    }
}
