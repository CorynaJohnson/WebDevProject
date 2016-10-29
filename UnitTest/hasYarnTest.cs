using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using lab_2_web_design.Models;
using lab_2_web_design.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace UnitTest
{
    [TestFixture]
    public class hasYarnTest
    {
        private IUser _userService;

        [SetUp]
        public void SetUp()
        {
            //_userService = new UserService();
        }

        [Test]
        public void WhenUserHasNoYarn()
        {
            var user = new User
            {
                FirstName = "Joe",
                LastName = "BoB",
                EmailAdress = "Joebob@site.com",
                hasYarn = false
            };

            var result = _userService.UserhasYarn(user);

            Assert.IsFalse(result);
        }

    }
}
