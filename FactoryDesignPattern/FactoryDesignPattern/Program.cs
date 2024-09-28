namespace Soccer.Outcomes
{
    public class SoccerOutcome
    {
        List<string> outcomes = new List<string>();

        int homeScore = 1, awayScore = 2;

        //<summary>
        // this class is violates the SRP because of multiple if else condition and many conecrns for outcomes.
        // Violates OCP as if we have add another outcomes exisitng code will be modified.
        // tight coupling
        //</summary>
        public void GetOutcomes()
        {
            if (homeScore > awayScore)
            {
                outcomes.Add("home wins");
            }
            else if (homeScore < awayScore)
            {
                outcomes.Add("away wins");
            }
            else if (homeScore == awayScore)
            {
                outcomes.Add("draw");
            }
        }
    }

    //<summary>
    //Factory design pattern to solve this issue.
    //</summary>

    public interface ISoccerOutcome
    {
        string Outcome(int homeScore, int awayScore);
    }

    public class Draw : ISoccerOutcome
    {
        public string Outcome(int homeScore, int awayScore)
        {
            return homeScore == awayScore ? "Draw" : "";
        }
    }

    public class HomeWinOutcome : ISoccerOutcome
    {
        public string Outcome(int homeScore, int awayScore)
        {
            return homeScore > awayScore ? "Home wins." : "";
        }
    }

    public class AwayWinOutcome : ISoccerOutcome
    {
        public string Outcome(int homeScore, int awayScore)
        {
            return homeScore < awayScore ? "away wins" : "";
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            ISoccerOutcome outcome = new HomeWinOutcome();
            Console.WriteLine(outcome.Outcome(2, 1));

            outcome = new AwayWinOutcome();
            Console.WriteLine(outcome.Outcome(4, 5));
        }
    }

}
