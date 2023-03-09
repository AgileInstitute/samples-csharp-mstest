using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{ 
    [TestClass]
    public class Lab1Tests
    {
        [TestMethod]
        public void RidiculousPasswordIsRidiculous()
        {
            var checker = new PasswordChecker();
            Assert.IsFalse(checker.Check("password"));
        }
    }
}