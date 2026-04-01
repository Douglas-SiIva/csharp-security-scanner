using CsharpSecurityScanner.Domain.Interfaces;
using CsharpSecurityScanner.Infrastructure.Detectors;

namespace CsharpSecurityScanner.Application.Services;

public class SecurityScanner
{
    private readonly List<IVulnerabilityDetector> _detectors;
    
    public SecurityScanner()
    {
        _detectors = new List<IVulnerabilityDetector>
        {
            new SqlInjectionDetector(),
            new XssDetector(),
            new CsrfDetector()
        };
    }

    public void RunScan(string input)
    {
        foreach (var detector in _detectors)
        {
            Console.WriteLine(detector.DetectorName);

            var hasVulnerability = detector.IsVulnerable(input);
            Console.WriteLine(hasVulnerability);

            var vulnerabilityDescription = detector.GetVulnerabilityDescription();
            Console.WriteLine(vulnerabilityDescription);
            
            Console.WriteLine();
        }
    }
}
