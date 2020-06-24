using GalaSoft.MvvmLight.Ioc;
using MvvmDialogs;

namespace Todos
{
    /// <summary>
    /// This class contains references to all the view models in the application and provides an
    /// entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<IDialogService>(() => new DialogService());
        }

        public MainWindowViewModel MainWindow => SimpleIoc.Default.GetInstance<MainWindowViewModel>();
    }
}
