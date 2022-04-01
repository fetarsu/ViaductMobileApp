using System.Collections.Generic;
using System.Threading.Tasks;
using ViaductMobile.Models;

namespace ViaductMobile.Services
{
    public interface IReportService
    {
        Task<IEnumerable<Report>> GetAllReports();
        Task<IEnumerable<Report>> GetReport(string reportId);
        Task<User> UpdateReport(Report report);
        Task<User> AddReport(Report report);
    }
}