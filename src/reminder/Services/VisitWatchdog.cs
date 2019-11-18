using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booker.Reminder.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace Booker.Reminder
{
    public class VisitWatchdog : IVisitWatchdog
    {
        private readonly IConfiguration _configuration;
        private readonly INotifierClient _notifierClient;

        public VisitWatchdog(IConfiguration configuration, INotifierClient notifierClient)
        {
            _configuration = configuration;
            _notifierClient = notifierClient;
        }

        public Task CheckVisits()
        {
            using SqlConnection connection =
                new SqlConnection(
                    "Server=(localdb)\\mssqllocaldb;Database=Booker;ConnectRetryCount=0;Trusted_Connection=True;MultipleActiveResultSets=true");

            var visits = connection.Query<Visit>("SELECT * FROM Visits").ToList();

            foreach (var visit in visits)
            {
                if (!visit.Reminded && visit.DateTime.Day == (DateTime.Now.Day + 1))
                {
                    _notifierClient.Notify();
                    connection.Execute($"UPDATE Visits SET Reminded = @Reminded WHERE Id = @Id", new { Reminded = true, Id = visit.Id });
                }
            }
            return Task.CompletedTask;
        }
    }
}
