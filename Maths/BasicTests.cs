using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maths
{
    [TestClass]
    public class BasicTests
    {
        
        [TestMethod]
        public void ExceptionThrownWhenGivenNull()
        {
            Assert.ThrowsException<MathsException>( () => new Set(new[] { (string)null }));
        }

    }
    
}