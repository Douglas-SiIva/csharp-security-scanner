using CsharpSecurityScanner.Infrastructure.Detectors;

var detector = new SqlInjectionDetector();

Console.WriteLine($"Detector: {detector.DetectorName}");
Console.WriteLine($"Test 1: {detector.IsVulnerable("SELECT * FROM users")}");
Console.WriteLine($"Test 2: {detector.IsVulnerable("Hello World")}");
Console.WriteLine($"Description: {detector.GetVulnerabilityDescription()}");
