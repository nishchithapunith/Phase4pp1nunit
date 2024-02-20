using Phase4pp1nunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{

    [TestFixture]
    public class Teach
    {
        [Test]
        public void Test_CreateTeacher()
        {
            // Arrange
            var teacher = new Teacher();
            teacher.TeacherID = 104;
            teacher.TeacherName = "Balaji";

            // Act & Assert
            Assert.AreEqual(104, teacher.TeacherID);
            Assert.AreEqual("Balaji", teacher.TeacherName);
        }
    }
}