using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity5 : ContentPage
	{
		ObservableCollection<employee> employees = new ObservableCollection<employee>();

        public ObservableCollection<employee> Employees { get { return employees; } }
        public Activity5 ()
		{
			InitializeComponent ();
			{
				lst.ItemsSource = employees;

				employees.Add(new employee { DisplayName = "Lebron James", Position = "Small Forward", profileImage="image1.png" });
                employees.Add(new employee { DisplayName = "Kobe Bryant", Position = "Shooting Guard", profileImage = "image2.png" });
                employees.Add(new employee { DisplayName = "Michael Jordan", Position = "Shooting Guard", profileImage = "https://cdn.nba.com/headshots/nba/latest/1040x760/893.png" });
            }
		}
	}
}