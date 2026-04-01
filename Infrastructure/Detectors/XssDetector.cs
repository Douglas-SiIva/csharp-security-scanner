using System.Linq;
using CsharpSecurityScanner.Domain.Interfaces;

namespace CsharpSecurityScanner.Infrastructure.Detectors
{
    public class XssDetector : IVulnerabilityDetector
    {
        public string DetectorName => "XSS Detector";

        public bool IsVulnerable(string input)
        {
            var xssPatterns = new[] {"<script", "javascript:", "<iframe>", "<object>"};
            return xssPatterns.Any(pattern => input.Contains(pattern, StringComparison.OrdinalIgnoreCase));
        }

        public string GetVulnerabilityDescription() => "Cross-Site Scripting (XSS) vulnerability detected";
    }
}