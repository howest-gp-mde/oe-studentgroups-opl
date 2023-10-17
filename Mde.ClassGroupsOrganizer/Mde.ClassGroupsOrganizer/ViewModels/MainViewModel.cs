using FreshMvvm;
using Mde.ClassGroupsOrganizer.Domain.Models;
using Mde.ClassGroupsOrganizer.Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mde.ClassGroupsOrganizer.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {
        private readonly IStudentService _studentService;

        #region props
        private string name;

        public string Name
		{
			get { return name; }
			set 
            { 
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
		}

        private int studentGroup;

        public int StudentGroup
        {
            get { return studentGroup; }
            set 
            { 
                studentGroup = value;
                RaisePropertyChanged(nameof(StudentGroup));
            }
        }


        private ObservableCollection<Student> students;

        public ObservableCollection<Student> Students
        {
            get { return students; }
            set 
            { 
                students = value;
                RaisePropertyChanged(nameof(Students));
            }
        }
        #endregion

        #region commands
        public ICommand OnButtonClickedCommand => new Command(AddStudent);
        public ICommand OnNavigateCommand => new Command<Student>(async(student) =>
        {
            await CoreMethods.PushPageModel<DetailsViewModel>(student);
        });

        #endregion
        public MainViewModel()
        {
            Name = "TEST";
            _studentService = new InMemoryStudentService();
        }

        private void AddStudent()
        {
            Student student = new Student
            {
                Name = Name,
                Group = StudentGroup
            };

            _studentService.Add(student);

            Students = new ObservableCollection<Student>(_studentService.GetAll());
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            var students = _studentService.GetAll();
            Students = new ObservableCollection<Student>(students);
        }

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
            string secretMessage = (string)returnedData;

            CoreMethods.DisplayAlert("Info", secretMessage, "Ok");
        }

    }
}
