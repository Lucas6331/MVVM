using MVVM_API_SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_API_SampleProject.ViewModels
{
    public class TodoViewModel
    {
        public Todo Todo { get; set; }

        public TodoViewModel()
        {
            Todo = new Todo()
            {
                userId = 1,
                id = 1,
                title = "delectus aut autem",
                completed = false,
            };
        }
    }
}
