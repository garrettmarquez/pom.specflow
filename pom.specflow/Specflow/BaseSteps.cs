using NUnit.Framework;
using pom.specflow.Managers;
using TechTalk.SpecFlow;

namespace pom.specflow.Specflow
{
    public class BaseSteps
    {
        public static TestCase tc;
        public static WebDriverManager wdm;

        [BeforeScenario]
        public void SetUp()
        {
            TestContext.Out.WriteLine("BASE");
            tc = new TestCase();
            wdm = tc.GetWebDriverManager();
            wdm.GetDriver();
        }
        [AfterScenario]
        public void TearDown()
        {
            TestContext.Out.WriteLine("TEARDOWN");
            wdm.Close();
        }
    }
}
