using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace DocuTrackerAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Window.Maximize();
            //Instance = new ChromeDriver();
            TurnOnWait();
        }

        public static void close()
        {
            //hiii
            // Instance.Close();
        }
        public static void Refresh()
        {
            
        }
        public static string BaseAddress
        {
            get
            {
                return "http://clientdemo.cloudapp.net/";
            }

        }

        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
        }

        public static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        public static void TurnOnWait1()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));
        }

        public static void TurnOnWait2()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(500));
        }
        public static void TurnOnWait3()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1000));
        }



        public static void Currentwindowclose()
        {
            Instance.Close();
        }
    }
}
