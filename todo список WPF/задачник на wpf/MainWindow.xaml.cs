 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using задачник_на_wpf.models;
using System.IO;
using задачник_на_wpf.Services2;
using System.Windows.Markup;
using System.Globalization;
using System.Windows.Controls.Primitives;

namespace задачник_на_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private BindingList<ToDoModel> _toDoData;
        private FileIO _fileIOService;


            
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fileIOService = new FileIO(PATH);

            try
            {
                _toDoData = _fileIOService.LoadData();
                _toDoData.ListChanged += _toDoData_ListChanged;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            ToDoList.ItemsSource = _toDoData;
            _toDoData.ListChanged += _toDoData_ListChanged;
        }

        private void _toDoData_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemDeleted)
            {
                try
                {
                    _fileIOService.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        

            //switch (e.ListChangedType)
            //{
            //    case ListChangedType.Reset:
            //        break;
            //    case ListChangedType.ItemAdded:
            //        break;
            //    case ListChangedType.ItemDeleted:
            //        break;
            //    case ListChangedType.ItemMoved:
            //        break;
            //    case ListChangedType.ItemChanged:
            //        break;
            //    case ListChangedType.PropertyDescriptorAdded:
            //        break;
            //    case ListChangedType.PropertyDescriptorDeleted:
            //        break;
            //    case ListChangedType.PropertyDescriptorChanged:
            //        break;
            //}
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsNumberAllowed(e.Text);
        }
        private bool IsNumberAllowed(string DeadlineText)
        {
            return DeadlineText.All(char.IsDigit) || DeadlineText == ".";
        }
        //private void DataGrid_Sorting(object sender, DataGridSortingEventArgs e)
        //{
        //    if (e.Column.Header.ToString() == "Дедлайн")
        //    {
        //        ICollectionView dataView = CollectionViewSource.GetDefaultView(DataGRid. );
        //        dataView.SortDescriptions.Clear();
        //        dataView.SortDescriptions.Add(new SortDescription("Deadline", ListSortDirection.Ascending));
        //        dataView.Refresh();
        //        e.Handled = true;
        //    }
        //}

        //private void ToDoList_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        //{
        //    if (e.Column.Header.ToString() == "Дедлайн")
        //    {
        //        if (e.EditAction == DataGridEditAction.Commit)
        //        {
        //            var editedItem = e.Row.Item as ToDoModel;
        //            if (editedItem != null)
        //            {
        //                try
        //                {
        //                    // Парсим введенную дату и обновляем свойство DeadLine
        //                    DateTime newDeadline = DateTime.ParseExact(((TextBox)e.EditingElement).Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        //                    editedItem.DeadLine = newDeadline;
        //                }
        //                catch (FormatException)
        //                {
        //                    // Обработка ошибки ввода неверного формата даты
        //                    MessageBox.Show("Неверный формат даты. Используйте формат dd.MM.yyyy.");
        //                }
        //            }
        //        }
        //    }
        //}
        private void ToDoList_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.Column.Header.ToString() == "Дедлайн")
            {
                TextBox textBox = e.EditingElement as TextBox;
                if (textBox != null)
                {
                    DateTime parsedDate;
                    if (!DateTime.TryParseExact(textBox.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                    {
                        MessageBox.Show("Неверный формат даты. Введите дату в формате dd.mm.yyyy.");
                        e.Cancel = true;
                    }
                    else
                    {
                        ToDoModel selectedItem = ToDoList.SelectedItem as ToDoModel;
                        if (selectedItem != null)
                        {
                            selectedItem.DeadLine = parsedDate;
                        }
                    }
                }
            }
        }



        //public class ToDoModelComparer : IComparer<ToDoModel>
        //{
        //    public int Compare(ToDoModel x, ToDoModel y)
        //    {
        //        if (x == null || y == null)
        //            return 0;

        //        // Сравниваем по дедлайну
        //        return x.DeadLine.CompareTo(y.DeadLine);
        //    }
        //}

        //private void BubbleSort(BindingList<ToDoModel> list)
        //{
        //    int n = list.Count;
        //    bool swapped;
        //    do
        //    {
        //        swapped = false;
        //        for (int i = 1; i < n; i++)
        //        {
        //            if (list[i - 1].DeadLine > list[i].DeadLine)
        //            {
        //                // Меняем местами элементы, если нужно
        //                ToDoModel temp = list[i - 1];
        //                list[i - 1] = list[i];
        //                list[i] = temp;
        //                swapped = true;
        //            }
        //        }
        //        n--;
        //    } while (swapped);
        //}

        //private void DataGridHeader_Click(object sender, RoutedEventArgs e)
        //{
        //    var columnHeader = e.OriginalSource as DataGridColumnHeader;

        //    if (columnHeader != null && columnHeader.Column != null && columnHeader.Column.Header.ToString() == "Дедлайн")
        //    {
        //        if (_toDoData != null && _toDoData.Count > 1)
        //        {
        //            // Вызываем метод сортировки "пузырьком"
        //            BubbleSort(_toDoData);

        //            // Обновление источника данных DataGrid
        //            ToDoList.ItemsSource = null;
        //            ToDoList.ItemsSource = _toDoData;
        //        }
        //    }
        //}



    }
}
