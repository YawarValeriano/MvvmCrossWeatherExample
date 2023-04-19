using System;
using Core.Models;
using MvvmCross.ViewModels;

namespace Core.ViewModels
{
	public class ListViewModel : MvxViewModel
	{
		public MvxObservableCollection<Person> People { get; set; } = new MvxObservableCollection<Person>();
		public ListViewModel()
		{
			People.Add(new Person("First Name", "LastName"));
			People.Add(new Person("Second Name", "LastName"));
			People.Add(new Person("Third Name", "LastName"));
			People.Add(new Person("Fourth Name", "LastName"));
			People.Add(new Person("Fifth Name", "LastName"));
        }
	}
}

