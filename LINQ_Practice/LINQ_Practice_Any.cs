using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LINQ_Practice.Models;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class LINQ_Practice_Any
    {
        public List<Cohort> PracticeData { get; set; }
        public CohortBuilder CohortBuilder { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            CohortBuilder = new CohortBuilder();
            PracticeData = CohortBuilder.GenerateCohorts();
        }

        [TestCleanup]
        public void TearDown()
        {
            CohortBuilder = null;
            PracticeData = null;
        }


        [TestMethod]
        public void DoAnyCohortsHavePrimaryInstructorsBornIn1980s()
        {
            var doAny = PracticeData.Any(cohort => cohort.PrimaryInstructor.Birthday.Year < 1990 && cohort.PrimaryInstructor.Birthday.Year > 1979  )/*FILL IN LINQ EXPRESSION*/;
            Assert.IsTrue(doAny); //<-- change false to doAny
        }

        [TestMethod]
        public void DoAnyCohortsHaveActivePrimaryInstructors()
        {
            var doAny = PracticeData.Any(cohort => cohort.PrimaryInstructor.Active )/*FILL IN LINQ EXPRESSION*/;
            Assert.IsTrue(doAny); //<-- change false to doAny
        }

        [TestMethod]
        public void DoAnyActiveCohortsHave3JuniorInstructors()
        {
            var doAny = PracticeData.Any(cohort => cohort.JuniorInstructors.Count == 3)/*FILL IN LINQ EXPRESSION*/;
            Assert.IsTrue(doAny); //<-- change false to doAny
        }

        [TestMethod]
        public void AreAnyCohortsBothFullTimeAndNotActive()
        {
            var doAny = PracticeData.Any(cohort => cohort.FullTime == true && cohort.Active == false )/*FILL IN LINQ EXPRESSION*/;
            Assert.IsTrue(doAny); //<-- change false to doAny
        }

        [TestMethod]
        public void AreAnyStudentsInCohort3NotActiveAndBornInOctober()
        {
            var doAny = PracticeData[2].Students.Any(cohort => cohort.Birthday.Month == 10 && cohort.Active == false)/*FILL IN LINQ EXPRESSION*/;  //HINT: Cohort3 is PracticeData[2]
            Assert.IsFalse(doAny); //<-- change true to doAny
        }

        [TestMethod]
        public void AreAnyJuniorInstructorsInCohort4NotActive()
        {
            var doAny = PracticeData[3].JuniorInstructors.Any(cohort => cohort.Active == false)/*FILL IN LINQ EXPRESSION*/;  //HINT: Cohort4 is PracticeData[3]
            Assert.IsFalse(doAny); //<-- change true to doAny
        }
    }
}
