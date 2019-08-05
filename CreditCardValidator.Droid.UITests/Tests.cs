using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace CreditCardValidator.Droid.UITests
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the iOS app being tested is included in the solution then 
            // add a reference to the android project from the project containing this file
            app = ConfigureApp
                    .Android
                    .InstalledApp("com.xamarin.example.creditcardvalidator")
                    .StartApp();
        }

        [Test]
        public void CreditCardNumber_TooShort_DisplayErrorMessage()
        {
            //First, wait for the default screen and set context on the input box.
            //Take a screenshot
            app.WaitForElement(c => c.Marked("action_bar_title").Text("Enter Credit Card Number"));
            app.Screenshot("Default View");

            //Then, enter a string of digits and take a screenshot
            app.EnterText(c => c.Marked("creditCardNumberText"), new string('9', 15));
            app.Screenshot("Text Entered");
            app.WaitForElement(c => c.Marked("action_bar_title").Text("Enter Credit Card Number"));

            //Finally, progress with validation and verify the message.
            app.Tap(c => c.Marked("validateButton"));
            app.WaitForElement(c => c.Marked("errorMessagesText").Text("Credit card number is too short."));
            app.Screenshot("Complete");
        }
    }
}

