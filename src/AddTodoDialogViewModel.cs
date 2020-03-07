using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmDialogs;

namespace Todos
{
    public class AddTodoDialogViewModel : ViewModelBase, IModalDialogViewModel
    {
        private readonly RelayCommand okCommand;

        private string name;
        private bool? dialogResult;

        public AddTodoDialogViewModel()
        {
            okCommand = new RelayCommand(Ok, CanOk);
        }

        public string Name
        {
            get => name;
            set
            {
                Set(nameof(Name), ref name, value);

                okCommand.RaiseCanExecuteChanged();
            }
        }

        public ICommand OkCommand => okCommand;

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

        private bool CanOk()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }
    }
}
