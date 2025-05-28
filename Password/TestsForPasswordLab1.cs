using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{ 
    [TestClass]
    public class TestsForPasswordLab1
    {
        [TestMethod]
        public void RidiculousPasswordIsRidiculous()
        {
            var checker = new PasswordChecker();
            Assert.IsFalse(checker.Check("password"));
        }
    }
}