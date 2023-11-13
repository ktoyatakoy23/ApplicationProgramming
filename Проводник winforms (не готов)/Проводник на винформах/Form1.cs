using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проводник_на_винформах
{
    public partial class Form1 : Form
    {
        List<string> CurrentDirectory = new List<string>();
        public Form1()
        {
                btnLoadFilesAndFolders_Click();
                InitializeComponent();
                Main();
                AllFilesAndFolders();
                CurrentPath.Text = CurrentDirectory.Last();
            
        }
        void Main()
        {
            string StartDirectory = @"C:";
            CurrentDirectory.Add(StartDirectory);
        }

        //void AllFilesAndFolders()
        //{
        //    All.Text = "Папки: ";
        //    string[] allfolders = Directory.GetDirectories(CurrentDirectory.Last());
        //    foreach (string folder in allfolders)
        //    {
        //        All.Text = folder;
        //    }

            //Console.WriteLine("");
            //Console.WriteLine("Файлы: ");
            //string[] allfiles = Directory.GetFiles(CurrentDirectory.Last());
            //foreach (string filename in allfiles)
            //{
            //    Console.WriteLine(filename);
            //}
            //Console.WriteLine("");
        }
        private void btnLoadFilesAndFolders_Click(object sender, EventArgs e)
        {
            string path = CurrentDirectory.Last(); // Укажите путь к вашей папке или файлу
            All(path);
        }

        private void LoadFilesAndFolders(string path)
        {
            try
            {
                // Получаем список папок и файлов
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

            // Очищаем ListBox перед добавлением новых элементов
            All.Items.Clear();

                // Добавляем папки в ListBox
                foreach (string directory in directories)
                {
                All.Items.Add("Папка: " + Path.GetFileName(directory));
                }

                // Добавляем файлы в ListBox
                foreach (string file in files)
                {
                    listBoxFilesAndFolders.Items.Add("Файл: " + Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }




    }
}
