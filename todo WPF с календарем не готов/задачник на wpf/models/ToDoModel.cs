﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачник_на_wpf.models
{
    public class ToDoModel: INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;
        public DateTime DeadLine { get; set; } 
        public DateTime CreationDate { get; set; } = DateTime.Now;





        public bool isDone
        {
            get { return _isDone; }
            set
            {
                if (_isDone == value)
                {
                    return;
                }
                _isDone = value;
                OnPropertyChanged("isDone");
            }
        }

        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value) 
                {
                    return;
                }
                _text = value; 
                OnPropertyChanged("Text");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
