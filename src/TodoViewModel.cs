using GalaSoft.MvvmLight;

namespace Todos
{
    public class TodoViewModel : ViewModelBase
    {
        private string name;
        private bool isCompleted;

        public TodoViewModel(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => Set(nameof(Name), ref name, value);
        }

        public bool IsCompleted
        {
            get => isCompleted;
            set => Set(nameof(IsCompleted), ref isCompleted, value);
        }
    }
}
