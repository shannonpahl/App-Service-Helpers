using FormsSample.Models;

using Xamarin.Forms;

using AppServiceHelpers.Abstractions;
using AppServiceHelpers.Forms;

namespace FormsSample.ViewModels
{
    public class ToDosViewModel : BaseAzureViewModel<ToDo>
    {
        IEasyMobileServiceClient client;
        public ToDosViewModel(IEasyMobileServiceClient client) : base (client)
        {
            this.client = client;

			Title = "Todos";
        }

        Models.ToDo selectedToDoItem;
        public Models.ToDo SelectedToDoItem
        {
            get { return selectedToDoItem; }
            set
            {
                selectedToDoItem = value;
                OnPropertyChanged("SelectedItem");

                if (selectedToDoItem != null)
                {
                    var navigation = Application.Current.MainPage as NavigationPage;
                    navigation.PushAsync(new Pages.ToDoPage(client, selectedToDoItem));
                    SelectedToDoItem = null;
                }
            }
        }
    }
}