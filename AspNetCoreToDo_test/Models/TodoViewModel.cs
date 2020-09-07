namespace AspNetCoreTodo.Models
{
    public class TodoViewModel
    {
        public TodoItem[] Items { get; set; }
        public TodoViewModel(TodoItem[] Items)
        {
            this.Items = Items;
        }
    }
}