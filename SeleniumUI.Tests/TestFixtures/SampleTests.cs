using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumUI.Tests.TestFixtures
{
    internal class SampleTests
    {
        [OneTimeTearDown]
        public void A() 
        {
            MessageBox.Show("OneTimeTearDown");
        }

        [Test]
        public void B()
        {
            MessageBox.Show("B");
        }

        [Test]
        public void C()
        {
            MessageBox.Show("C");
        }

        [OneTimeSetUp]
        public void D()
        {
            MessageBox.Show("OneTimeSetUp");
        }

        [SetUp]
        public void E()
        {
            MessageBox.Show("SetUp");
        }

        [TearDown]
        public void F()
        {
            MessageBox.Show("TearDown");
        }

    }
}
