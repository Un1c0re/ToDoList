using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoList
{
    public class Item 

    {
        public bool IsDone { get; set; } = false;
        public string Text { get; set; } = "Error";

        public override string ToString()
        {
            return Text.ToString();
        }

   
    }
}