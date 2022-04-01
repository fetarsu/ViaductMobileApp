using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaductMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViaductMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportView : ContentPage
    {
        public ReportView()
        {
            InitializeComponent();
            BindingContext = new ReportViewModel(); 
        }
    }
}