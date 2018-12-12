/*
 * Patrick Barnes
 * Create a program named DirectoryInformation that allows a user to continually 
 * enter directory names until the user types end. If the directory name exists, 
 * display a list of the files in it; otherwise, display a message indicating the 
 * directory does not exist. Create as many test directories and files as necessary 
 * to test your program.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_DirectoryInformation
{
    class DirectoryInformation
    {
        static void Main(string[] args)
        {
            string usrInput = "";

            Console.WriteLine("=== Type \"end\" to end program. ===\n");
            Console.Write("Enter a Path(dir):");
            usrInput = Console.ReadLine();

            while (usrInput.ToLower() != "end")
            {

                foreach (string strFile in Directory.EnumerateFiles(usrInput))
                {
                    Console.WriteLine(strFile);
                }
                //input
                Console.Write("Enter a Path(dir):");
                usrInput = Console.ReadLine();
            }
            Console.WriteLine("--- END ---");
        }
    }
}
