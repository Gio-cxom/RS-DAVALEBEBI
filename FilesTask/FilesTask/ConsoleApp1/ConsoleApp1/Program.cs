using System;
using System.IO;
using System.Text;

class FilesTask
{
    public static void Main()
    {
        string fileName = "MyTest.txt";
        string fileName2 = "NewTest.txt";
        string[] ArrLines;
        string str;
        int n, i, count;
        using (FileStream fileStr = File.Create(fileName)) ;
        using (FileStream fileStr = File.Create(fileName2)) ;

        //Excercise 1

        //    try
        //    {
        //        Console.Write("\nCreate a file named mytest.txt in the disk\n");

        //        using (FileStream fileStr = File.Create(fileName))
        //        {
        //            Console.WriteLine("\n A file created with name mytest.txt\n");
        //        }
        //    }
        //    catch (Exception MyExcep)
        //    {
        //        Console.WriteLine(MyExcep.ToString());
        //    }


        ////Excercise 3

        //Console.Write("\n\n Remove a file from the disk (at first create the file ) :\n");

        //// Delete the file if it exists.
        //if (File.Exists(fileName))
        //{
        //    File.Delete(fileName);
        //    Console.WriteLine(" The file {0} deleted successfully.\n\n", fileName);
        //}
        //else
        //{
        //    using (FileStream fileStr = File.Create(fileName))
        //        Console.WriteLine(" File does not exist it will be created");
        //    Console.ReadKey();
        //}


        //Exercise 4

        //using (StreamWriter fileStr = File.CreateText(fileName))
        //{
        //    fileStr.WriteLine(" Hello and Welcome");
        //    fileStr.WriteLine(" It is the first content");
        //    fileStr.WriteLine(" of the text file mytest.txt");
        //    Console.WriteLine(" A file created with content name mytest.txt\n\n");
        //}


        //Exercise 5

        //using (StreamWriter fileStr = File.CreateText(fileName))
        //{
        //    fileStr.WriteLine(" Hello and Welcome");
        //    fileStr.WriteLine(" It is the first content");
        //    fileStr.WriteLine(" of the text file mytest.txt");
        //}
        //using (StreamReader sr = File.OpenText(fileName))
        //{
        //    string s = "";
        //    Console.WriteLine(" Here is the content of the file mytest.txt : ");
        //    while ((s = sr.ReadLine()) != null)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.WriteLine("");
        //}

        //exercise 6

        //string[] ArrLines;
        //int n, i;

        //using (StreamWriter fileStr = File.CreateText(fileName))
        //    Console.Write("\n\n Create a file and write an array of strings  :\n");
        //Console.Write("---------------------------------------------------\n");

        //Console.Write(" Input number of lines to write in the file  :");
        //n = Convert.ToInt32(Console.ReadLine());
        //ArrLines = new string[n];
        //Console.Write(" Input {0} strings below :\n", n);
        //for (i = 0; i < n; i++)
        //{
        //    Console.Write(" Input line {0} : ", i + 1);
        //    ArrLines[i] = Console.ReadLine();
        //}
        //System.IO.File.WriteAllLines(fileName, ArrLines);

        //using (StreamReader sr = File.OpenText(fileName))
        //{
        //    string s = "";
        //    Console.Write("\n The content of the file is  :\n", n);
        //    Console.Write("----------------------------------\n");
        //    while ((s = sr.ReadLine()) != null)
        //    {
        //        Console.WriteLine(" {0} ", s);
        //    }
        //    Console.WriteLine();
        //}

        //exercise 7
        //Console.Write(" Input the string to ignore the line : ");
        //str = Console.ReadLine();
        //Console.Write(" Input number of lines to write in the file  : ");
        //n = Convert.ToInt32(Console.ReadLine());
        //ArrLines = new string[n];

        //Console.Write(" Input {0} strings below :\n", n);
        //for (i = 0; i < n; i++)
        //{
        //    Console.Write(" Input line {0} : ", i + 1);
        //    ArrLines[i] = Console.ReadLine();
        //}

        //using (System.IO.StreamWriter file =
        //    new System.IO.StreamWriter(@"mytest.txt"))
        //{
        //    foreach (string line in ArrLines)
        //    {
        //        if (!line.Contains(str))
        //        {
        //            file.WriteLine(line);
        //        }
        //    }
        //}

        //using (StreamReader sr = File.OpenText(fileName))
        //{
        //    string s = "";
        //    Console.Write("\n The line has ignored which contain the string '{0}'. \n", str);
        //    Console.Write("\n The content of the file is  :\n", n);
        //    while ((s = sr.ReadLine()) != null)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.WriteLine();
        //}

        ////exercise 8
        ///

        //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"mytest.txt", true))
        //{
        //    file.WriteLine(" This is the line appended at last line.");
        //}
        //    Console.WriteLine("");

        //EXERcise 9


        //System.IO.File.Copy(fileName, fileName2, true);
        //Console.WriteLine(" The file {0} successfully copied to the name {1} in the same directory.", fileName, fileName2);

        //EXERcise 10


        //System.IO.File.Move(fileName, fileName2, true);
        //Console.WriteLine(" The file {0} successfully moved to the name {1} in the same directory.", fileName, fileName2);

        //EXERcise 11-12
        using (StreamWriter fileStr = File.CreateText(fileName))
        {
            fileStr.WriteLine(" test line 1");
            fileStr.WriteLine(" test line 2");
            fileStr.WriteLine(" Test line 3");
        }
        //    using (StreamReader sr = File.OpenText(fileName))
        //    {
        //        string s = "";
        //        Console.WriteLine(" Here is the content of the file mytest.txt : ");
        //        while ((s = sr.ReadLine()) != null)
        //        {
        //            Console.WriteLine(s);
        //        }
        //        Console.WriteLine("");
        //    }

        //    Console.Write("\n The content of the first line of the file is :\n");
        //    if (File.Exists(fileName))
        //    {
        //        string[] lines = File.ReadAllLines(fileName);
        //        Console.Write(lines[0]);
        //    }
        //    Console.WriteLine();
        //}
        //    Console.Write(" Input number of lines to write in the file  :");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    ArrLines = new string[n];
        //    Console.Write(" Input {0} strings below :\n", n);
        //    for (i = 0; i < n; i++)
        //    {
        //        Console.Write(" Input line {0} : ", i + 1);
        //        ArrLines[i] = Console.ReadLine();
        //    }
        //    System.IO.File.WriteAllLines(fileName, ArrLines);
        //    Console.Write("\n The content of the last line of the file {0} is  :\n", fileName);
        //    if (File.Exists(fileName))
        //    {
        //        string[] lines = File.ReadAllLines(fileName);
        //        Console.WriteLine(" {0}", lines[n - 1]);
        //    }
        //    Console.WriteLine();
        //}


        //    //EXERcise 13
        //    using (StreamReader sr = File.OpenText(fileName))
        //    {
        //        string s = "";
        //        count = 0;
        //        Console.WriteLine(" Here is the content of the file mytest.txt : ");
        //        while ((s = sr.ReadLine()) != null)
        //        {
        //            Console.WriteLine(s);
        //            count++;
        //        }
        //        Console.WriteLine("");
        //    }
        //    Console.Write(" The number of lines in  the file {0} is : {1} \n\n", fileName, count);
        //}


        //EXERcise 14 15
        Console.Write(" Input number of lines to write in the file  :");
        n = Convert.ToInt32(Console.ReadLine());
        ArrLines = new string[n];
        Console.Write(" Input {0} strings below :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write(" Input line {0} : ", i + 1);
            ArrLines[i] = Console.ReadLine();
        }
        System.IO.File.WriteAllLines(fileName, ArrLines);

        Console.Write("\n Input which line you want to display  :");
        count = Convert.ToInt32(Console.ReadLine());
        if (count >= 1 && count <= n)
        {
            Console.Write("\n The content of the line {0} of the file {1} is : \n", count, fileName);
            if (File.Exists(fileName))
            {
                for (i = n - count; i < n; i++)
                {
                    string[] lines = File.ReadAllLines(fileName);
                    Console.Write(" The last no {0} line is : {1} \n", count, lines[i]);
                    count--;
                }
            }
        }
        else
        {
            Console.WriteLine(" Please input the correct line no.");
        }
        //    {
        //        string[] lines = File.ReadAllLines(fileName);
        //        Console.WriteLine(" {0}", lines[count - 1]);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine(" Please input the correct line no.");
        //}
    }





    }

