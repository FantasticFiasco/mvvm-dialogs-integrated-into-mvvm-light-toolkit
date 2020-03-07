using GalaSoft.MvvmLight.Ioc;

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
        }

        public MainWindowViewModel MainWindow => SimpleIoc.Default.GetInstance<MainWindowViewModel>();
    }
}
