using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Linq;
using OpenQA.Selenium.DevTools.V121.Console;
using System.Xml.Linq;

namespace AppliedActivity_4
{
    class Program
    {
        static void Main(string[] args)
        {
            SubmitForm();
        }

        //Test case-1 Sumbitting the form without filling the data(Created by-Meet Lathiya - A00299373)
        static void SubmitForm()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://accounts.snapchat.com/accounts/v2/signup";
                var signupbutton = driver.FindElement(By.ClassName("signup-button"));
                signupbutton.Submit();
                Thread.Sleep(5000);

                var finderrormessage = driver.FindElements(By.CssSelector(".sds-control-status.error")).Select((x) => x.Text);
                
                if (finderrormessage.Any())
                {
                    foreach (var errorMessage in finderrormessage)
                    {
                        Console.WriteLine(errorMessage);
                    }
                    Console.WriteLine("Test is Passed.");
                }
                else
                {
                    Console.WriteLine("Test-1 is failed.");
                }
                Console.ReadLine();
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}