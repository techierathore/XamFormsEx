using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamFormsEx.Templates
{

    public partial class DataTempEx : ContentPage
	{
		public DataTempEx ()
		{
			InitializeComponent ();
            var people = new List<Person>
            {
                new Person { Name = "Kath", DateOfBirth = new DateTime(1985, 11, 20), Location = "France", iCount=1 },
                new Person { Name = "Steve", DateOfBirth = new DateTime(1975, 1, 15), Location = "USA",iCount=2 },
                new Person { Name = "Lucas", DateOfBirth = new DateTime(1988, 2, 5), Location = "Germany" ,iCount=3 },
                new Person { Name = "John", DateOfBirth = new DateTime(1976, 2, 20), Location = "USA" ,iCount=1 },
                new Person { Name = "Tariq", DateOfBirth = new DateTime(1987, 1, 10), Location = "UK" ,iCount=2},
                new Person { Name = "Jane", DateOfBirth = new DateTime(1982, 8, 30), Location = "USA" ,iCount=3 },
                new Person { Name = "Tom", DateOfBirth = new DateTime(1977, 3, 10), Location = "UK" ,iCount=1 },
                new Person { Name = "Kath", DateOfBirth = new DateTime(1985, 11, 20), Location = "France" ,iCount=2 },
                new Person { Name = "Steve", DateOfBirth = new DateTime(1975, 1, 15), Location = "USA" ,iCount=3 },
                new Person { Name = "Lucas", DateOfBirth = new DateTime(1988, 2, 5), Location = "Germany" ,iCount=1},
                new Person { Name = "John", DateOfBirth = new DateTime(1976, 2, 20), Location = "USA" ,iCount=2 },
                new Person { Name = "Tariq", DateOfBirth = new DateTime(1987, 1, 10), Location = "UK" ,iCount=3},
                new Person { Name = "Jane", DateOfBirth = new DateTime(1982, 8, 30), Location = "USA" ,iCount=1},
                new Person { Name = "Tom", DateOfBirth = new DateTime(1977, 3, 10), Location = "UK" ,iCount=2}

            };

            listView.ItemsSource = people;
        }
	}
    public class PersonDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ValidTemplate { get; set; }
        public DataTemplate InvalidTemplate { get; set; }
        public DataTemplate ThridTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Person SelItem = (Person)item;
            DataTemplate vResult = null;
            switch (SelItem.iCount)
            {
                case 1: vResult = ValidTemplate; break;
                case 2: vResult = InvalidTemplate; break;
                case 3: vResult = ThridTemplate; break;
            }

            return vResult;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Location { get; set; }
        public int iCount { get; set; }
    }
}