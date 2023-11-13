using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setVersion();
            Browser.Navigate("https://yandex.ru/maps/65/novosibirsk/?ll=82.920430%2C55.030199&z=12");
        }
        private void setVersion() 
        {
            const string keyName = @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            const int ieVersion = 11001;

            try
            {
                using(RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
                {
                    if (key != null) 
                    {
                        string appname = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                        key.SetValue(appname, ieVersion, RegistryValueKind.DWord);
                    }
                }
            }
            catch
            {
                
            }

        }
    }
}
