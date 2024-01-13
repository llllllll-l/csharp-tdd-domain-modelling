using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{

    [TestFixture]
    public class CohortManagerTest
    {

        private CohortManager _coHort;
        private List<string> places = new List<string> { "1", "2","3","4","5" };

        [SetUp]
        public void SetUp() {
            _coHort = new CohortManager();
        }
        [Test]
        public void TestSearchFunction()
        {
            Assert.IsTrue(_coHort.SearchManeger(places, "4"));
        }

        public void TestSearchFuntionFail() {
            Assert.IsFalse(_coHort.SearchManeger(places, "6"));
        }
    }
}