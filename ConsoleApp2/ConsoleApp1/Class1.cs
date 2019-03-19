using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Testing
{
    public class Func
    {
        public double inctosm(int inc)
        {
            if (inc < 0) throw new ArgumentException("Item less then zero");
            return inc * 2.57;
        }

        public bool parity(int par)
        {
            if (par < 0) throw new ArgumentException("Item less then zero");
            return (par % 2 == 0) ? true : false;
        }

        public int masmax(ref int[] mas)
        {
            if (mas == null) throw new IndexOutOfRangeException("Индекс находился вне границ массива.");
            int l = mas.Length;
            Array.Sort(mas);
            int a = mas[l - 1];
            return a;
        }

        public double remainder(int a, int b)
        {
            if (a < 0 || b <= 0) throw new ArgumentException("Item less then zero");
            return a % b;
        }
    }

    [TestFixture]
    public class Test
    {
        [TestCase]
        public void inctosm()
        {
            Func f = new Func();
            var ex = Assert.Throws<ArgumentException>(() => f.inctosm(-10));
            Assert.That(ex.Message, Is.EqualTo("Item less then zero"));
            Assert.AreEqual(2.57, f.inctosm(1));
            
        }

        [TestCase]
        public void parity()
        {
            Func f = new Func();
            Assert.IsTrue(f.parity(4));
            Assert.IsFalse(f.parity(5));
        }

        [TestCase]
        public void masmax()
        {
            Func f = new Func();
            int[] b = { 1, 23, 35 };
            int[] c = { };
            var ex = Assert.Throws<IndexOutOfRangeException>(() => f.masmax(ref c));
            Assert.That(ex.Message, Is.EqualTo("Индекс находился вне границ массива."));
            Assert.AreEqual(35, f.masmax(ref b));
        }

        [TestCase]
        public void remainder()
        {
            Func f = new Func();
            var ex = Assert.Throws<ArgumentException>(() => f.remainder(2, 0));
            Assert.That(ex.Message, Is.EqualTo("Item less then zero"));
            Assert.AreEqual(1, f.remainder(10, 3));
        }
    }
}
