using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMovieStoreIqbal;
namespace Movie_UnitTest
{
    [TestClass]
    public class UnitTesting
    {
        MovieRental obj_movie = new MovieRental();
        [TestMethod]
        public void LessThan5YearTest()
        {
            var actual = obj_movie.FeeCalculation(2016, 2020);
            Assert.AreEqual(expected: 5, actual);
        }
        [TestMethod]
        public void MoreThan5YearTest()
        {
            var actual = obj_movie.FeeCalculation(2011, 2020);
            Assert.AreEqual(expected: 2, actual);
        }
    }
}
