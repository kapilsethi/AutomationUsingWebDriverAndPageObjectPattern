
using AutomationUsingWebDriverAndPageObjectPattern.Lib;
using AutomationUsingWebDriverAndPageObjectPattern.PageElements;

namespace AutomationUsingWebDriverAndPageObjectPattern.Pages
{
    public class NavigationHelper
    {
        private PageOperations pageOperations = new PageOperations();
        private HomePageElements homePageElements = new HomePageElements();
        private JourneyPlannerPageElements journeyPlannerPageElements = new JourneyPlannerPageElements();

        public NavigationHelper OpenHomePage()
        {
            pageOperations.OpenWebsite("http://ptv.vic.gov.au/");
            pageOperations.WaitForPageLoad(journeyPlannerPageElements.LEAVING_FROM);
            return this;
        }

        public JourneyPlannerPage GoToJourneyPlannerPage()
        {
            pageOperations.ClickLink(homePageElements.JourneyPlannerLink);
            pageOperations.WaitForPageLoad(journeyPlannerPageElements.JOURNEY_PLAN_RESULTS);
            pageOperations.WaitForPageLoad(journeyPlannerPageElements.LEAVING_FROM);
            return new JourneyPlannerPage();
        }
    }
}
