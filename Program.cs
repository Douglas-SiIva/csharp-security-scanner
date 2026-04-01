using CsharpSecurityScanner.Application.Services;

var scanner = new SecurityScanner();
scanner.RunScan("SELECT * FROM users WHERE id = 1");