using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace anySoftwareStart
{
    class PathManager
    {
        public static List<string> PathList { get; private set; } = new List<string>();
        
        public static void Load()
        {
            PathList.Clear();
            try
            {
                using (StreamReader streamReader = new StreamReader(@"Path.txt"))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        PathList.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Path.txtが見つからなかった場合何もしない
            }
            
        }
        
        public static void Write()
        {
            using (StreamWriter streamWriter = new StreamWriter(@"Path.txt", false, Encoding.GetEncoding("utf-8")))
            {
                foreach (var path in PathList)
                {
                    streamWriter.WriteLine(path);
                }
            }
        }

        public static void PathAdd(object path)
        {
            PathList.Add((string)path);
        }


    }
}
