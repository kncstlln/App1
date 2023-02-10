using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OpenActivity1 (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity1());
        }
        private async void OpenActivity2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }
    }
}
