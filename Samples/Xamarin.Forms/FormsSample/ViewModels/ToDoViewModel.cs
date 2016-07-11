using System;
using AppServiceHelpers.Abstractions;
using AppServiceHelpers.Forms;

namespace FormsSample.ViewModels
{
    public class ToDoViewModel : BaseAzureViewModel<Models.ToDo>
    {
        IEasyMobileServiceClient client;
        Models.ToDo todo;

        public ToDoViewModel(IEasyMobileServiceClient client, Models.ToDo todo) : base (client)
        {
            this.client = client;
            this.todo = todo;
        }

        public string Text
        {
            get
            {
                return todo.Text;   
            }
            set
            {
                todo.Text = value;
            }
        }

        public bool Complete
        {
            get
            {
                return todo.Completed;
            }
            set
            {
                todo.Completed = value;
            }
        }
    }
}

