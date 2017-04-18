using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Task6
{
    [TestFixture]
    class test_person
    {
        [Test]
        public void createPerson() {
            var p = new Student("Kranthi", 23, "Information and communication Systems", 2);
            Assert.IsTrue(p.Name == "Kranthi");
            Assert.IsTrue(p.Age==23);
            Assert.IsTrue(p.Studienrichtung== "Information and communication Systems");
            Assert.IsTrue(p.Semester == 2);
        }

        [Test]
        public void PersonNameShouldNotBeNULL1()
        {
            Assert.Catch(() =>
            {
                var p = new Student(null, 23, "Information and communication Systems", 2);
            });
        }

        [Test]
        public void PersonNameShouldNotBeNULL2()
        {
            Assert.Catch(() =>
            {
                var p = new Student("", 23, "Information and communication Systems", 2);
            });
        }


        [Test]
        public void PersonAgeShouldNotBeNULL()
        {
            Assert.Catch(() =>
            {
                var p = new Student("Kranthi", 0, "Information and communication Systems", 2);
            });
        }

        [Test]
        public void ProfessionShouldNotBeEmpty1()
        {
            Assert.Catch(() =>
            {
                var p = new Student("Kranthi", 23, null, 2);
            });
        }

        [Test]
        public void ProfessionShouldNotBeEmpty2()
        {
            Assert.Catch(() =>
            {
                var p = new Student("Kranthi", 23, "", 2);
            });
        }

        [Test]
        public void SemesterShouldNotBeEmpty()
        {
            Assert.Catch(() =>
            {
                var p = new Student("Kranthi", 23, "Information and communication Systems", 0);
            });
        }

        [Test]
        public void NoSalary()
        {
           
                var p = new Student("Kranthi", 23, "Information and communication Systems", 2);

            Assert.IsTrue(p.Salary(p.Age)==0);

        }

    }
}
