using CsharpSecurityScanner.Domain.Interfaces;

namespace CsharpSecurityScanner.Infrastructure.Detectors
{
    public class CsrfDetector : IVulnerabilityDetector
    {
        public string DetectorName => "CSRF Detector";

        public bool IsVulnerable(string input)
        {
            return !input.Contains("csrf_token") && !input.Contains("_token");
        }

        public string GetVulnerabilityDescription()
        {
            return "Cross-Site Request forgery (CSRF) vulnerability detected - missing protection tokens";
        }
    }
}