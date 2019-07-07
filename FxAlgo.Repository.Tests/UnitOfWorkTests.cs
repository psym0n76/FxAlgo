using FxAlgo.Repository.Persistance;
using NUnit.Framework;
using System.Linq;

namespace FxAlgo.Repository.Tests
{
    [TestFixture]
    public class UnitOfWorkTests
    {
        //[Test]
        //[TestCase("A B C", 1)]
        //[TestCase("I just planted a young oak tree, wonder how tall it will grow in a few years?", 3.47)]
        //public void AverageWordLength_ShouldReturnResult(string input, double expected)
        //{
        //    var result = StringDemo.AverageWordLength(input);

        //    Assert.That(result, Is.EqualTo(expected));
        //}


        [Test]
        public void UnitOfWork_ShouldReturnTwoPricesFromAskPricesTable()
        {
            var subject = SubjectUnderTest();
            var results = subject.AskPrices.GetAll();

            Assert.That(results.Count(), Is.EqualTo(2));

        }

        [Test]
        public void UnitOfWork_ShouldReturnTwoPricesFromBidPricesTable()
        {
            var subject = SubjectUnderTest();
            var results = subject.BidPrices.GetAll();

            Assert.That(results.Count(), Is.EqualTo(2));

        }

        private IUnitOfWork SubjectUnderTest()
        {
            return new UnitOfWork(new FxAlgoContext());
        }

    }
}
