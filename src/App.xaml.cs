using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using MvvmDialogs;

namespace Todos
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();    
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            // Register the dialog service in the IoC container, enabling us to inject the service
            // into view models that require opening dialogs
            SimpleIoc.Default.Register<IDialogService>(() => new DialogService());
        }
    }
}
