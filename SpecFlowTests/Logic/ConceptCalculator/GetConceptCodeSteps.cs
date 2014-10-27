using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowTests.Logic.ConceptCalculator
{
    [Binding]
    public class GetConceptCodeSteps
    {
        private readonly SpecflowExample.Logic.ConceptCalculator _conceptCalculator;
        private SpecflowExample.Logic.ConceptCalculator.ConceptCode _result;

        public GetConceptCodeSteps()
        {
            _conceptCalculator = new SpecflowExample.Logic.ConceptCalculator();
        }

        [Given(@"The ""(.*)"" concept value and ""(.*)"" concept value")]
        public void GivenTheConceptValueAndConceptValue(string p0, string p1)
        {
            _result = _conceptCalculator.GetConceptCode(p0, p1);
        }

        [Then(@"the ""(.*)"" should be valid")]
        public void ThenTheShouldBeValid(SpecflowExample.Logic.ConceptCalculator.ConceptCode p0)
        {
            Assert.AreEqual(_result, p0);
        }
    }
}