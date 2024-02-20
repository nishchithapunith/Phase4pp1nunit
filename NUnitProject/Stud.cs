using Phase4pp1nunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    [TestFixture]
    public class Stud
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Nishu";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("Nishu", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "Sakaleshpura";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("Sakaleshpura", studentAddress);
        }
    }
}