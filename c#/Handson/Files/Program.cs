using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Dell\mydir2");
            if(di.Exists==false)di.Create();
            di.CreateSubdirectory("mydir1");
            DirectoryInfo[] d = di.GetDirectories();
            foreach(DirectoryInfo x in d)
            {
                Console.WriteLine(x.Name + " "+x.FullName+" "+x.CreationTime);
                
            }
            FileInfo[] fi = di.GetFiles();
            Console.WriteLine("*****************************************");
            foreach (FileInfo x in fi)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);

            }
            //FileStream fs = new FileStream(@"C:\Users\Dell\mydir2\a.txt",FileMode.OpenOrCreate,FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("welcome");
            //for(int i=0;i<2;i++)
            //{
            //    string s = Console.ReadLine();
            //    sw.WriteLine(s);
            //}
            //sw.Close();
            //fs.Close();
            //FileStream fs1=new FileStream(@"C:\Users\Dell\mydir2\a.txt",FileMode.OpenOrCreate,FileAccess.Read);
            //StreamReader sr = new StreamReader(fs1);
            //string s;
            //while((s=sr.ReadLine())!=null)
            //{
            //    Console.WriteLine(s);
            //}
            //sr.Close();
            //fs1.Close();
            FileStream fs = new FileStream(@"C:\Users\Dell\mydir2\b.txt",FileMode.OpenOrCreate,FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            int i = 0;
            char ch = 'd';
            string f = "hello";
            bw.Write(i);
            bw.Write(ch);
            bw.Write(f);
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"C:\Users\Dell\mydir2\b.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader bw1 = new BinaryReader(fs1);
            int x1 = bw1.ReadInt32();
            char y = bw1.ReadChar();
            string z = bw1.ReadString();
            bw1.Close();
            fs1.Close();
            Console.WriteLine(x1 + " " + y + " " + z);
            Console.ReadLine();

        }
    }
}
