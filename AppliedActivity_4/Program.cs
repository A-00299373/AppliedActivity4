﻿using OpenQA.Selenium;
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
            EnterInvalidEmailAddress();
            EnterInvalidPassword();
            EnterInvalidUsername();
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

        //Test Case-2 Entering invalid email address with other details filled correctly (Created by Sagar Shah-A00297514)
        static void EnterInvalidEmailAddress()
        {
            var driver1 = new EdgeDriver();
            try
            {
                driver1.Url = "https://accounts.snapchat.com/accounts/v2/signup";

                var firstname = driver1.FindElement(By.Name("first_name"));
                firstname.SendKeys("XYZ");

                var username = driver1.FindElement(By.Name("username"));
                username.SendKeys("XYZ123");

                var email = driver1.FindElement(By.Name("email"));
                email.SendKeys("xyz@gmail");

                var password = driver1.FindElement(By.Name("password"));
                password.SendKeys("P@ssw0rd");

                var birthmonth = driver1.FindElement(By.Name("birth_month"));
                birthmonth.SendKeys("January");

                var birthday = driver1.FindElement(By.Name("birth_day"));
                birthday.SendKeys("1");

                var birthyear = driver1.FindElement(By.Name("birth_year"));
                birthyear.SendKeys("2001");

                var signupbuttonclass = driver1.FindElement(By.ClassName("signup-button"));
                var signupbutton = signupbuttonclass.FindElement(By.TagName("button"));
                signupbutton.Submit();

                var emailerrormessage = driver1.FindElements(By.CssSelector(".sds-control-status.error")).Select((x) => x.Text);

                if (emailerrormessage.Any())
                {
                    foreach (var errorMessage in emailerrormessage)
                    {
                        Console.WriteLine(errorMessage);
                    }
                    Console.WriteLine("Test-2 is Passed.");
                }
                else
                {
                    Console.WriteLine("Test is failed.");
                }
                Console.ReadLine();
            }
            finally
            {
                driver1.Quit();
            }
        }

        //Test-3 Entering invalid password edited by Pratham Shah: A00303235
        static void EnterInvalidPassword()
        {
            var driver2 = new EdgeDriver();
            try
            {
                driver2.Url = "https://accounts.snapchat.com/accounts/v2/signup";

                var firstname = driver2.FindElement(By.Name("first_name"));
                firstname.SendKeys("XYZ");

                var username = driver2.FindElement(By.Name("username"));
                username.SendKeys("XYZ123");

                var email = driver2.FindElement(By.Name("email"));
                email.SendKeys("xyz@gmail.com");

                var password = driver2.FindElement(By.Name("password"));
                password.SendKeys("mmmmmmmm");

                var birthmonth = driver2.FindElement(By.Name("birth_month"));
                birthmonth.SendKeys("January");

                var birthday = driver2.FindElement(By.Name("birth_day"));
                birthday.SendKeys("1");

                var birthyear = driver2.FindElement(By.Name("birth_year"));
                birthyear.SendKeys("2001");

                var signupbuttonclass = driver2.FindElement(By.ClassName("signup-button"));
                var signupbutton = signupbuttonclass.FindElement(By.TagName("button"));
                signupbutton.Submit();

                var emailerrormessage = driver2.FindElements(By.CssSelector(".sds-control-status.error")).Select((x) => x.Text);

                if (emailerrormessage.Any())
                {
                    foreach (var errorMessage in emailerrormessage)
                    {
                        Console.WriteLine(errorMessage);
                    }
                    Console.WriteLine("Test-3 is Passed.");
                }
                else
                {
                    Console.WriteLine("Test is failed.");
                }
                Console.ReadLine();
            }
            finally
            {
                driver2.Quit();
            }
        }
         
        //Test-4 Entering invalid username  (Created by Obed Sampong - A00280655)
        static void EnterInvalidUsername()
        {
            var driver3 = new EdgeDriver();
            try
            {
                driver3.Url = "https://accounts.snapchat.com/accounts/v2/signup";

                var firstname = driver3.FindElement(By.Name("first_name"));
                firstname.SendKeys("XYZ");

                var username = driver3.FindElement(By.Name("username"));
                username.SendKeys("NewwwSnapchatUser");

                var email = driver3.FindElement(By.Name("email"));
                email.SendKeys("xyz@gmail.com");

                var password = driver3.FindElement(By.Name("password"));
                password.SendKeys("P@ssw0rd");

                var birthmonth = driver3.FindElement(By.Name("birth_month"));
                birthmonth.SendKeys("January");

                var birthday = driver3.FindElement(By.Name("birth_day"));
                birthday.SendKeys("1");

                var birthyear = driver3.FindElement(By.Name("birth_year"));
                birthyear.SendKeys("2001");

                var signupbuttonclass = driver3.FindElement(By.ClassName("signup-button"));
                var signupbutton = signupbuttonclass.FindElement(By.TagName("button"));
                signupbutton.Submit();

                var emailerrormessage = driver3.FindElements(By.CssSelector(".sds-control-status.error")).Select((x) => x.Text);

                if (emailerrormessage.Any())
                {
                    foreach (var errorMessage in emailerrormessage)
                    {
                        Console.WriteLine(errorMessage);
                    }
                    Console.WriteLine("Test-4 is Passed.");
                }
                else
                {
                    Console.WriteLine("Test is failed.");
                }
                Console.ReadLine();
            }
            finally
            {
                driver3.Quit();
            }
        }
    }
}
