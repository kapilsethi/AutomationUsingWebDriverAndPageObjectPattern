using AutomationUsingWebDriverAndPageObjectPattern.Lib;
using AutomationUsingWebDriverAndPageObjectPattern.PageElements;

namespace AutomationUsingWebDriverAndPageObjectPattern.Pages
{
    public class JourneyPlannerPage
    {
        private PageOperations pageOperations = new PageOperations();
        private JourneyPlannerPageElements journeyPlannerPageElements = new JourneyPlannerPageElements();

        public JourneyPlannerPage SelectJourneyPlannerOptionForOrigin(string option)
        {
            pageOperations.SelectRadioButton(journeyPlannerPageElements.JOURNEY_PLANNER_OPTIONS_FOR_ORIGIN , option);
            return this;
        }

        public JourneyPlannerPage EnterLeavingFrom(string origin)
        {
            pageOperations.Type(journeyPlannerPageElements.LEAVING_FROM, origin);
            return this;
        }
        
        public JourneyPlannerPage SelectJourneyPlannerOptionForDestination(string destination)
        {
            pageOperations.SelectRadioButton(journeyPlannerPageElements.JOURNEY_PLANNER_OPTIONS_FOR_DESTINATION, destination);
            return this;
        }

        public JourneyPlannerPage EnterGoingTo(string destination)
        {
            pageOperations.Type(journeyPlannerPageElements.GOING_TO, destination);
            return this;
        }

        public JourneyPlannerPage SelectDepartOrArrive(string departOrArrive)
        {
            pageOperations.Select(journeyPlannerPageElements.DAPART_OR_ARRIVE, departOrArrive);
            return this;
        }

        public JourneyPlannerPage SelectDate(string date)
        {
            pageOperations.Select(journeyPlannerPageElements.DATE_DAY, date);
            return this;
        }

        public JourneyPlannerPage SelectMonthAndYear(string monthAndYear)
        {
            pageOperations.Select(journeyPlannerPageElements.MONTH_YEAR, monthAndYear);
            return this;
        }

        public JourneyPlannerPage SelectHour(string hour)
        {
            pageOperations.Select(journeyPlannerPageElements.TIME_HOUR, hour);
            return this;
        }

        public JourneyPlannerPage SelectMinute(string minute)
        {
            pageOperations.Select(journeyPlannerPageElements.TIME_MINUTE, minute);
            return this;
        }

        public JourneyPlannerPage SelectAmOrPm(string amOrPm)
        {
            pageOperations.Select(journeyPlannerPageElements.TIME_AM_PM, amOrPm);
            return this;
        }

        public void ClickShowJourney()
        {
            pageOperations.Click(journeyPlannerPageElements.SHOW_JOURNEY);
        }
    }
}
