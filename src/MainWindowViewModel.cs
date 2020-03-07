using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmDialogs;

namespace TodoList
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IDialogService dialogService;

        public MainWindowViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;

            AddCommand = new RelayCommand(Add);
            ClearCompletedCommand = new RelayCommand(ClearCompleted);
        }

        public ObservableCollection<TodoViewModel> Todos { get; } = new ObservableCollection<TodoViewModel>();

        public ICommand AddCommand { get; }

        public ICommand ClearCompletedCommand { get; }

        private void Add()
        {
            var addTodoDialogViewModel = new AddTodoDialogViewModel();

            var success = dialogService.ShowDialog(this, addTodoDialogViewModel);
            if (success == true)
            {
                Todos.Add(new TodoViewModel(addTodoDialogViewModel.Name));
            }
        }

        private void ClearCompleted()
        {
            var result = dialogService.ShowMessageBox(this, "Are you sure?", "Clear Completed", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result != MessageBoxResult.Yes)
            {
                return;
            }

            foreach (var completed in Todos.Where(todo => todo.IsCompleted).ToArray())
            {
                Todos.Remove(completed);
            }
        }
    }
}
