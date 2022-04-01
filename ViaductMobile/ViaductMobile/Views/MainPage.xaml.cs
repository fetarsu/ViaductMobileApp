using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaductMobile.Models;
using ViaductMobile.Services;
using ViaductMobile.Services.Implementation;
using Xamarin.Forms;

namespace ViaductMobile
{
    public partial class MainPage : TabbedPage
    {
        private readonly UserService _userService = new UserService();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {

            var use2r = new User()
            {
                Name = "test233"
            };

            var newUser = await _userService.AddUser(use2r);
        }
    }
}
