﻿using MailAuthorizationTests.Environment;
using OpenQA.Selenium;

namespace MailAuthorizationTests.UIControls
{
    internal class Button : BaseControl
    {
        public Button(By locator) : base(locator)
        {

        }

        public void Click(bool withWait = true)
        {
            if (withWait)
            {
                IsDisplayed();
            }
            WebDriverFactory.GetInstance().FindElement(locator).Click();
        }

    }
}
