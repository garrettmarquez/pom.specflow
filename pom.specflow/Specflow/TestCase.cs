using pom.specflow.Managers;

namespace pom.specflow.Specflow
{
    public class TestCase
    {
        private WebDriverManager wdm;
        public TestCase()
        {
            wdm = new WebDriverManager();
        }
        public WebDriverManager GetWebDriverManager()
        {
            return wdm;
        }
    }
}
