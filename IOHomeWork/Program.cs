using System;
using System.IO;
using System.Threading;

namespace IOHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\stu\memory-game");
            DirectoryInfo directoryInfo2 = new DirectoryInfo(@"C:\Users\stu\Desktop\New folder");
            DirectoryCopy(directoryInfo, directoryInfo2);
            //Thread t = new Thread(new ThreadStart(FileCopyLong));
            //Thread t2 = new Thread(new ThreadStart(FileCopyShort));
            //t.Start();
            //t2.Start();
        }
        static void FileCopyLong()
        {
            int counter;
            string source, copy;
            FileStream sourceStream, copyStream;
            byte[] buffer = new byte[8];
            
            Console.WriteLine("Enter file to copy: ");
            source = Console.ReadLine();
            Console.WriteLine("Enter dir to paste in: ");
            copy = Console.ReadLine();
            sourceStream = new FileStream(source, mode: FileMode.Open, FileAccess.Read);
            copyStream = new FileStream(copy + "\\" + sourceStream.Name.Split('\\')[sourceStream.Name.Split('\\').Length-1], mode: FileMode.OpenOrCreate, FileAccess.Write);
            while((counter = sourceStream.Read(buffer)) != 0)
            {
                copyStream.Write(buffer, 0, counter);
                Console.WriteLine(((float)copyStream.Length / (float)sourceStream.Length) * 100);
            }
            sourceStream.Close();
            copyStream.Close();
        }
        static void FileCopyShort()
        {
            string src, copy;
            Console.WriteLine("Enter file to copy: ");
            src = Console.ReadLine();
            Console.WriteLine("Enter dir to paste in: ");
            copy = Console.ReadLine();
            File.Copy(src, copy + "\\" + src.Split('\\')[src.Split('\\').Length - 1]);
        }
        static void DirectoryCopy(DirectoryInfo directoryInfo, DirectoryInfo directoryInfo2)
        {
            foreach (FileInfo item in directoryInfo.GetFiles())
            {
                File.Copy(item.FullName, directoryInfo2.FullName + "\\" + item.Name);
            }
            foreach (DirectoryInfo item in directoryInfo.GetDirectories())
            {
                directoryInfo2.CreateSubdirectory(item.Name);
                DirectoryCopy(new DirectoryInfo(item.FullName), new DirectoryInfo(directoryInfo2.FullName + "\\" + item.Name));
            }
            
        }
    }   
}
