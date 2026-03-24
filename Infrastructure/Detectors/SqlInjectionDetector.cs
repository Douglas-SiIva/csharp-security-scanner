using System.Linq;
using CsharpSecurityScanner.Domain.Interfaces;

namespace CsharpSecurityScanner.Infrastructure.Detectors
{
    public class SqlInjectionDetector : IVulnerabilityDetector
    {
        public string DetectorName => "SQL Injection Detector";

        public bool IsVulnerable(string input)
        {
            var sqlKeywords = new string[] { "SELECT", "DROP", "UNION", "INSERT", "UPDATE", "DELETE" };
            return sqlKeywords.Any(keyword => input.ToUpper().Contains(keyword));
        }

        public string GetVulnerabilityDescription()
        {
            return "SQL Injection vulnerability detected";
        }
    }
}