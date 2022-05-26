using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;


namespace ToDoList
{
    public class MainViewModel 
    {
        public MainViewModel()
        {
            AddTask = new Command<string>(x =>
            {
                Tasks.Add(new Item() { Text = x });
            }, x => 
                string.IsNullOrWhiteSpace(x) == false);
            RemoveTask = new Command<Item>(x => Tasks.Remove(x));
        }

        public ObservableCollection<Item> Tasks{get;} = new ObservableCollection<Item>(){};
        public ICommand AddTask{ get; }
        public ICommand RemoveTask{ get; }
    }
}
