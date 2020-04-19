using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public class ProjectRepository
    {
        public string[] FileRetrive(string type)
        {
            string[] files = System.IO.Directory.GetFiles(type);

            
            return files;
        }

        public string[] DeleteFile(string type, string element)
        {
            string pathString = System.IO.Path.Combine(type, element);


            //Delete file in main folder

            if (System.IO.File.Exists(pathString))
                try
                {
                    System.IO.File.Delete(pathString);
                }
                catch (System.IO.IOException ee)
                {
                    MessageBox.Show(ee.Message);
                }

            string[] files = System.IO.Directory.GetFiles(type);

            return files;
        }
        public void CreateFile(string type, string element)
        {
            string pathString = System.IO.Path.Combine(type, element);


            //Create file in main folder

            if (!System.IO.File.Exists(pathString))
                try
                {
                    using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                    {
                        ///ok

                    }
                }
                catch (System.IO.IOException ee)
                {
                    MessageBox.Show(ee.Message);
                }
            
        }

        public void CopyFile(string typeFrom, string typeTo)
        {
            if (System.IO.File.Exists(typeFrom))
                try
                {
                    System.IO.File.Copy(typeFrom, typeTo);
                }
                catch (System.IO.IOException ee)
                {
                    MessageBox.Show(ee.Message);
                }
        }

        public void ChangeTaskList(ListBox listtasks, string type, string element)
        {

            string pathstring = System.IO.Path.Combine(type, element);

            System.IO.File.WriteAllText(pathstring, string.Empty);

            var fs = File.Open(pathstring, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (var sw = new StreamWriter(fs))
            {
                int m = listtasks.Items.Count;
                for (int i = 0; i < m; i++)
                {
                    var str = listtasks.Items[i].ToString();

                    sw.WriteLine(str);
                }

                sw.Close();
            }
            fs.Close();
           
        }

        public ListBox ListTaskList(string type, string element)
        {
            ListBox listtasks = new ListBox();
            string pathstring = System.IO.Path.Combine(type, element);

            ///System.IO.File.WriteAllText(pathstring, string.Empty);

            var fs = File.Open(pathstring, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (var sw = new StreamReader(fs))
            {
                string str;

                while ((str = sw.ReadLine()) != null)
                {
                    listtasks.Items.Add(str);
                }

                sw.Close();
            }

            fs.Close();

            return listtasks;

        }
    }
}
