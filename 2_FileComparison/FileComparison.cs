/*
 * Patrick Barnes
 * Create a program named FileComparison that compares two files. First, 
 * use a text editor such as Notepad to save your favorite movie quote. 
 * Next, copy the file contents, and paste them into a word-processing 
 * program such as Word. Then, write the file-comparison application that 
 * displays the sizes of the two files as well as the ratio of their sizes 
 * to each other. To discover a file’s size, you can create a System.IO.FileInfo 
 * object using statements such as the following, where FILE_NAME is a string 
 * that contains the name of the file, and size has been declared as an 
 * integer:
 *      FileInfo fileInfo = new FileInfo(FILE_NAME);
 *      size = fileInfo.Length;
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_FileComparison
{
    class FileComparison
    {
        static void Main(string[] args)
        {
            string filePath1 = "test.txt";
            string filePath2 = "test.docx";

            FileInfo fileInfo1 = new FileInfo(filePath1);
            FileInfo fileInfo2 = new FileInfo(filePath2);

            Console.WriteLine("{0,10} {1,10} {2,10}", "", filePath1, filePath2);
            Console.WriteLine("{0,10} {1,10} {2,10}", "FileSize", fileInfo1.Length, fileInfo2.Length);

            Console.WriteLine("--- END ---");
        }
    }
}
