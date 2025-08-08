namespace UnitTestingBy_xUnitTest
{
    public class MyConditionalFactAttribute : FactAttribute
    {
        public MyConditionalFactAttribute()
        {
            if (!ShouldRunTests())
            {
                Skip = "Custom Error Message: Skipping because environmental condition is not met.";
            }
        }

        private bool ShouldRunTests()
        {
            // Your condition here
            return Environment.GetEnvironmentVariable("RUN_API_TESTS") == "true";
        }
    }

}
