using Mde.ClassGroupsOrganizer.Domain.Models;
using Mde.ClassGroupsOrganizer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.ClassGroupsOrganizer.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var model = (MainViewModel)BindingContext;
            var student = e.Item as Student;
            model.OnNavigateCommand.Execute(student);
        }
    }
}
