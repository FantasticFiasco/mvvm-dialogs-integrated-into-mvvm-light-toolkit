using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmDialogs;

namespace TodoList
{
    public class AddTodoDialogViewModel : ViewModelBase, IModalDialogViewModel
    {
        private string name;
        private bool? dialogResult;

        public AddTodoDialogViewModel()
        {
            OkCommand = new RelayCommand(Ok);
        }

        public string Name
        {
            get => name;
            set => Set(nameof(Name), ref name, value);
        }

        public ICommand OkCommand { get; }

        public bool? DialogResult
        {
            get => dialogResult;
            private set => Set(nameof(DialogResult), ref dialogResult, value);
        }

        private void Ok()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                DialogResult = true;
            }
        }
    }
}
