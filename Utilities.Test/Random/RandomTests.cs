using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Utilities.Test.Random
{
    [TestClass]
    public class RandomTests
    {
        [TestMethod]
        public void Method()
        {
            var random = new Utilities.Random.Random();
            random.Foo();
        }
    }
}