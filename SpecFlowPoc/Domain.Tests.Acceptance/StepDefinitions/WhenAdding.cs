using FluentAssertions;

using TechTalk.SpecFlow;

namespace Domain.Tests.Acceptance.StepDefinitions
{
    [Binding]
    public class WhenAdding
    {
        [Given(@"the numbers (.*) and (.*)")]
        public void GivenTheNumbersAnd(int numberA, int numberB)
        {
            ScenarioContext.Current["a"] = numberA;
            ScenarioContext.Current["b"] = numberB;
        }

        [When(@"adding the numbers")]
        public void WhenAddingTheNumbers()
        {
            ScenarioContext.Current["outcome"] =
                (int)ScenarioContext.Current["a"] +
                (int)ScenarioContext.Current["b"];
        }

        [Then(@"the output should be (.*)")]
        public void ThenTheOutputShouldBe(int expectedOutcome)
        {
            ScenarioContext.Current["outcome"].Should().Be(expectedOutcome, because:
                "That's what adding does, baby!");
        }
    }
}