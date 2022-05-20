using Array;
using NUnit.Framework;
using System.Linq;

namespace ArrayTest
{
    public class Tests
    {
        [TestCase(new int[] { 1, 8, -1, -2, 3 ,5, 3, -1, -9, 0, -2})]
        [TestCase(new int[] { 0, 4, -4, -3, 5, -4, 1, -4, -1, 7, 0})]
        [TestCase(new int[] { 1,2,8,-1,-1})]
        [TestCase(new int[] { -2,2,-4,8})]
        public void TestSortAndFilter(int[] a)
        {
            ArrayProcesor array = new ArrayProcesor();
            int[] res = array.SortAndFilter(a);
            Assert.Multiple(() =>
            {
                CollectionAssert.IsOrdered(res);
                CollectionAssert.AllItemsAreUnique(res.Where(item => item < 0).ToArray());
            });
        }
    }
}