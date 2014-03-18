
namespace AutomationUsingWebDriverAndPageObjectPattern.PageElements
{
    public class JourneyPlannerPageElements
    {
        //*****************************************************
        //Elements with ids
        //*****************************************************
        public string LEAVING_FROM
        {
            get { return "name_origin"; }
        }

        public string GOING_TO
        {
            get { return "name_destination"; }
        }

        public string DAPART_OR_ARRIVE
        {
            get { return "itdTripDateTimeDepArr_chzn"; }
        }

        public string DATE_DAY
        {
            get { return "itdDateDay_chzn"; }
        }

        public string MONTH_YEAR
        {
            get { return "itdDateYearMonth_chzn"; }
        }

        public string TIME_HOUR
        {
            get { return "itdTimeHour_chzn"; }
        }

        public string TIME_MINUTE
        {
            get { return "itdTimeMinute_chzn"; }
        }

        public string TIME_AM_PM
        {
            get { return "itdTimeAMPM_chzn"; }
        }

        public string SHOW_JOURNEY
        {
            get { return "jpSubmit"; }
        }

        public string JOURNEY_PLAN_RESULTS
        {
            get { return "JourneyPlanResults"; }
        }

        public string JOURNEY_OPTIONS
        {
            get { return "div.yourOptions"; }
        }

        //*****************************************************
        //Elements with names
        //******************************************************
        public string JOURNEY_PLANNER_OPTIONS_FOR_ORIGIN
        {
            get { return "anyObjFilter_origin"; }
        }
        
        public string JOURNEY_PLANNER_OPTIONS_FOR_DESTINATION
        {
            get { return "anyObjFilter_destination"; }
        }
    }
}
