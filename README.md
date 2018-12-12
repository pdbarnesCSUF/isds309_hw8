=Assignment 8
==ch 14
 1
===
Create a program named **DirectoryInformation** that allows a user to continually 
enter directory names until the user types *end*. If the directory name exists, 
display a list of the files in it; otherwise, display a message indicating the 
directory does not exist. Create as many test directories and files as necessary 
to test your program.

 2
===
Create a program named **FileComparison** that compares two files. First, 
use a text editor such as Notepad to save your favorite movie quote. 
Next, copy the file contents, and paste them into a word-processing 
program such as Word. Then, write the file-comparison application that 
displays the sizes of the two files as well as the ratio of their sizes 
to each other. To discover a file’s size, you can create a `System.IO.FileInfo` 
object using statements such as the following, where FILE_NAME is a string 
that contains the name of the file, and size has been declared as an 
integer:
```cs
     FileInfo fileInfo = new FileInfo(FILE_NAME);
     size = fileInfo.Length;
```