using System;
using System.Windows;

namespace CBRF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                ViewModelLocator.Init();
                base.OnStartup(e);
            }
            catch (Exception)
            {
                MessageBox.Show("Error run App");
            }
        }
    }
}
