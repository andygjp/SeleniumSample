namespace SeleniumSample
{
    using System;
    using System.IO;
    using OpenQA.Selenium.Chrome;

    static internal class WebDriverHelper
    {
        public static ChromeDriver GetChromeDriver()
        {
            var service = GetChromeDriverService();
            var chrome = new ChromeDriver(service);
            return chrome;
        }

        static ChromeDriverService GetChromeDriverService()
        {
            var directory = GetDirectoryOfChromeDriver();
            var service = ChromeDriverService.CreateDefaultService(directory);
            return service;
        }

        static string GetDirectoryOfChromeDriver()
        {
            var assemblyPathUri = typeof (WebDriverHelper).Assembly.CodeBase;
            var assemblyPath = new Uri(assemblyPathUri).AbsolutePath;
            var directory = Path.GetDirectoryName(assemblyPath);
            return directory;
        }
    }
}