using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using задачник_на_wpf.models;

namespace задачник_на_wpf.Services2
{
    internal class FileIO
    {
        private readonly string PATH;
        
        public FileIO(string path)
        {
            PATH = path;
        }

        public BindingList<ToDoModel> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if(!fileExists) 
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<ToDoModel>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<ToDoModel>>(fileText);
            }
        }
       
        public void SaveData(object _toDoData) 
        {
            using (StreamWriter writer = File.CreateText(PATH)) 
            {
                string output = JsonConvert.SerializeObject(_toDoData);
                writer.Write(output);
            }
        }
    }
}
