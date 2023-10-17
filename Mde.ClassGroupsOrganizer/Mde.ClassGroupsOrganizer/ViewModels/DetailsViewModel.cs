using FreshMvvm;
using Mde.ClassGroupsOrganizer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mde.ClassGroupsOrganizer.ViewModels
{
    public class DetailsViewModel : FreshBasePageModel
    {
        private string studentName;

        public string StudentName
        {
            get { return studentName; }
            set 
            { 
                studentName = value;
                RaisePropertyChanged();
            }
        }

        public ICommand OnGoBackCommand => new Command(GoBack);

        public override void Init(object initData)
        {
            base.Init(initData);
            Student student = (Student)initData;
            StudentName = student.Name;
        }

        private void GoBack()
        {
            CoreMethods.PopPageModel("secret message");
        }


    }
}
