using System;
using TechTalk.SpecFlow;
using Xunit;

namespace crud_apis.tests
{


    [Binding]
    class Steps
    {
        [Given(@"Table student exists")]
        public void GivenPrecondition()
        {
            Console.WriteLine("####################");
        }
        [Then(@"DB should have entry for id '(.*)' name '(.*)' class '(.*)'")]
        public void ThenDBShouldHaveEntryForIdNameClass(int p0, string pramod1, string bE2)
        {
            System.Console.WriteLine();
        }
        [When(@"User create student with id '(.*)' name '(.*)' and class '(.*)'")]
        public void WhenUserCreateStudentWithIdNameAndClass(int p0, string pramod1, string bE2)
        {
            System.Console.WriteLine();
        }
    }
}