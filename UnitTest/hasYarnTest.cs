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
using FakeItEasy;
using lab_2_web_design.Data;

namespace UnitTest
{
    [TestFixture]
    public class hasYarnTest
    {
        private IUser _userService;
        private IRepository _fakeRepository;

        [SetUp]
        public void SetUp()
        {
            _fakeRepository = A.Fake<IRepository>();
            _userService = new UserService(_fakeRepository);
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
            A.CallTo(() => _fakeRepository.doesUserHaveYarn(A<User>.Ignored)).Returns(false);
            var result = _userService.UserhasYarn(user);

            Assert.IsFalse(result);
        }

    }
}
