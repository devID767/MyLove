using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyLove
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }

        private void Ready_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new ILoveYou());
        }
    }
}
