using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTodo.ViewModel
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
