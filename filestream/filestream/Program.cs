using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\work\train\cf trains\SPBSU\D\kth.in";
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = File.Create(path))
            {
                AddText(fs, "Text1");
                AddText(fs, "Text2");
                AddText(fs, "More Text");
                for (int i = 0; i < 128; ++i)
                    AddText(fs, Convert.ToChar(i).ToString());
            }
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[5000];
                UTF8Encoding temp = new UTF8Encoding(true);
                while(fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }

        private static void AddText(FileStream fs, string add)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(add);
            fs.Write(info, 0, info.Length);
        }
    }
}
