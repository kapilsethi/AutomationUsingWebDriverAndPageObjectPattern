using AutomationUsingWebDriverAndPageObjectPattern.Pages;

using NUnit.Framework;

namespace AutomationUsingWebDriverAndPageObjectPattern.Tests
{
    [TestFixture]
    public class JourneyPlannerTests
    {
        [Test]
        public void CheckJourneyPlannerWithStops()
        {
            new NavigationHelper().OpenHomePage().GoToJourneyPlannerPage().
                SelectJourneyPlannerOptionForOrigin("Stops").
                EnterLeavingFrom("Glen Waverley Railway Station").
                SelectJourneyPlannerOptionForDestination("Stops").
                EnterGoingTo("Glen Iris Railway Station").
                SelectDepartOrArrive("Arrive").
                SelectDate("8").SelectMonthAndYear("Apr-14").
                SelectHour("9").SelectMinute("30").SelectAmOrPm("am").
                ClickShowJourney();
        }
    }
}
