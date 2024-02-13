namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {private readonly ScenarioContext scenarioContext;
        private readonly Calculater calculater;
        private int result;
       public CalculatorStepDefinitions (ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculater = new Calculater ();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
           calculater.Fnum = number;

        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           calculater .Snum = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
           result = calculater.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);
        }
    }
}
