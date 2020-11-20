using System;
using NUnit.Framework;
using Structtt;

using static NUnit.Framework.Assert;

namespace Vector3_Tests
{
    [TestFixture]
    public class Vector3Tests
    {
        Vector3 v1 = new Vector3(1, 1, 1);
        Vector3 v2 = new Vector3(1, 1, 1);

        [Test]
        public void OperPlus_UnitVectorAndUnitVector_DoubledUnitVectorReturned()
        {
            AreEqual(new Vector3(2, 2, 2), v1 + v2);
        }


        [Test]
        public void OperMult_UnitVectorAndUnitVector_UnitVectorReturned()
        {
            AreEqual(new Vector3(1, 1, 1), v1 * v2);
        }

        [Test]
        public void OperDiv_UnitVectorAndUnitVector_UnitVectorReturned()
        {
            AreEqual(new Vector3(1, 1, 1), v1 / 1);
        }

        [Test]
        public void GetLength_UnitVectorAndUnitVector_UnitVectorReturned()
        {
            AreEqual(new Vector3(1, 1, 1).GetLength(), Math.Sqrt(3), 0.0001);
        }
    }
}
