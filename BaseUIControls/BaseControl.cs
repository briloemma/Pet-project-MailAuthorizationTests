﻿using MailAuthorizationTests.Environment;
using OpenQA.Selenium;

namespace MailAuthorizationTests.BaseUIControls
{
    internal abstract class BaseControl : IControl
    {
        protected By _locator;
        public BaseControl(By locator)
        {
            _locator = locator;
        }

        public virtual bool IsDisplayed()
        {
            WaitUtil.WaitForElementIsDisplayed(_locator);
            return WebDriverSingleton.GetInstance().FindElement(_locator).Displayed;
        }
        public virtual bool IsEnabled()
        {
            WaitUtil.WaitForElementIsDisplayed(_locator);
            return WebDriverSingleton.GetInstance().FindElement(_locator).Enabled;
        }
    }
}
