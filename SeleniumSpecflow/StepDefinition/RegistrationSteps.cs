﻿using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using BuggyCarsRating.BDD.StepDefinitions;
using BuggyCarsRating.Model.Data;
using BuggyCarsRating.Model.Pages;
using System.Linq;
using TechTalk.SpecFlow;

namespace BuggyCarsRating.BDD.StepDefinition
{
    [Binding]
    public class RegistrationSteps : BaseSteps
    {
        public RegistrationSteps(IWebDriver driver, IObjectContainer objectContainer, ScenarioContext scenarioContext, FeatureContext featureContext) : base(driver, objectContainer, scenarioContext, featureContext)
        {

        }

        [Given(@"I register on the site using:")]
        public void GivenIRegisterOnTheSiteUsing(Table table)
        {
            HomePage home = new HomePage(driver);
            home.RegisterButton.Click();

            var username = Faker.Internet.UserName();
            var password = table.Rows.First()["Password"].ToString();
            objectContainer.RegisterInstanceAs(new LoginData().WithUsername(username).WithPassword(password), "logincredentials");

            RegistrationPage register = new RegistrationPage(driver);
            register.CreateNewUser(username, password);
        }

        [When(@"verify registration is a success")]
        public void ThenVerifyRegistrationIsASuccess()
        {
            RegistrationPage register = new RegistrationPage(driver);
            Assert.IsTrue(register.RegistrationSuccessMessage.Displayed, "registration message successful shown");
        }

        [Then(@"I use created credentials to log in successfully")]
        public void ThenIUseCreatedCredentialsToLogInSuccessfully()
        {
            LoginData loginData = objectContainer.Resolve<LoginData>("logincredentials");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.SetLoginAndEnter(loginData.Username, loginData.Password);

            HomePage homePage = new HomePage(driver);
            Assert.IsTrue(homePage.IsHeaderPresent(), "Login was successful.");
        }

    }
}
