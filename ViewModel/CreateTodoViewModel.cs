using System.ComponentModel.DataAnnotations;

namespace ApiTodo.ViewModel
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
