using System;
using System.Collections.Generic;

using FormsSample.ViewModels;

using AppServiceHelpers;
using AppServiceHelpers.Abstractions;

using Xamarin.Forms;

namespace FormsSample.Pages
{
    public partial class ToDoListPage : ContentPage
    {
        public ToDoListPage(IEasyMobileServiceClient client)
		{
            InitializeComponent();

			BindingContext = new ToDosViewModel(client);
        }
    }
}

