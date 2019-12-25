using System;
using TechTalk.SpecFlow;
namespace crud_apis.tests
{


    [Binding]
    class Steps
    {
        [Given(@"Table student exists")]
        [When(@"User create student with id '1' name 'Pramod' and class 'BE'")]
        [When(@"DB should have entry for id '1' name 'Pramod' class 'BE'")]
        public void GivenPrecondition()
        {
            Console.WriteLine("####################");
        }
    }
}