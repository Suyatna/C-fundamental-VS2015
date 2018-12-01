using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace  Grades.Tests.Type
{

    [TestClass]
    public class ReferenceTypeTest
    {
        [TestMethod]
        public void VariableHoldReference() 
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;            

            g1.Name = "Suya";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}