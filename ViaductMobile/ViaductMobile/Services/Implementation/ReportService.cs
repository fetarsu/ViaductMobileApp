﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using ViaductMobile.Models;

namespace ViaductMobile.Services.Implementation
{
    public class ReportService
    {
        private static readonly MobileServiceClient azureService = new MobileServiceClient("https://viaductmobile.azurewebsites.net/");
        
        public async Task<IEnumerable<Report>> GetAllReports()
        {
            var table = azureService.GetTable<Report>();
            return await table.ReadAsync();
        }
        
        public async Task<IEnumerable<Report>> GetReport(DateTime date)
        {
            var table = azureService.GetTable<Report>();
            var query = table.Where(x=>x.Date == date);
            return await table.ReadAsync(query);
        }
        
        public async Task<Report> UpdateReport(Report report)
        {
            var table = azureService.GetTable<Report>();
            await table.UpdateAsync(report);
            return report;
        }

        public async Task<Report> AddReport(Report report)
        {
            try
            {
                await azureService.GetTable<Report>().InsertAsync(report);
                return report;
            }
            catch (MobileServiceInvalidOperationException msioe)
            {
                var response = await msioe.Response.Content.ReadAsStringAsync();
                return report;
            }
            catch (Exception ex)
            {
                return report;
            }
        }
    }
}