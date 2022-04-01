using System;

namespace ViaductMobile.Models
{
    public class Report
    {
        public string ReportId { get; set; }
        public int State { get; set; }
        public DateTime Date { get; set; }
        public decimal Revenue { get; set; }
        public decimal CardIncome { get; set; }
    }
}