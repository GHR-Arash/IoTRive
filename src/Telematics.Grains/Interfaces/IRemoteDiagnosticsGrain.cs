using Orleans;
using System.Threading.Tasks;
using Telematics.Grains.Models;

namespace Telematics.Grains.Diagnostics
{
    public interface IRemoteDiagnosticsGrain : IGrainWithStringKey
    {
        Task<DiagnosticSessionResult> StartDiagnosticSessionAsync(string vehicleId);
        Task<DiagnosticReport> GetDiagnosticReportAsync(string sessionId);
    }

    public class DiagnosticReport
    {
        public string SessionId { get; set; }
        public bool IsSuccessful { get; set; }
        public string ReportDetails { get; set; }
    }
}
