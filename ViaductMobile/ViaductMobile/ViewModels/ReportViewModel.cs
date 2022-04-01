using System;
using System.Windows.Input;
using ViaductMobile.Enums;
using ViaductMobile.Models;
using ViaductMobile.Services.Implementation;
using Xamarin.Forms;

namespace ViaductMobile.ViewModels
{
    public class ReportViewModel
    {
        private readonly ReportService _reportService = new ReportService();
        private readonly UserService _userService = new UserService();
        public ReportViewModel()
        {
            StartCommand = new Command(StartMethod);
            AddCommand = new Command(AddMethod);  
            CloseCommand = new Command(CloseMethod);  
            ReopenCommand = new Command(ReopenMethod);

            //var report = _reportService.GetReport(DateTime.Now);
            //var x = report.Result;
        }
        
        public ICommand StartCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand ReopenCommand { get; }


        public string ReportState { get; set; }
        
        private void StartMethod()
        {
            Report report2 = new Report()
            {
                ReportId = "9dc2ea8c906a4a4ba91564b1471140ad",
                State = 0,
                CardIncome = 0,
                Date = DateTime.Now,
                Revenue = 0
            };
            _reportService.AddReport(report2);
        }
        private void AddMethod()
        {
            throw new NotImplementedException();
        }
        private void CloseMethod()
        {
            throw new NotImplementedException();
        }
        private void ReopenMethod()
        {
            throw new NotImplementedException();
        }
    }
}