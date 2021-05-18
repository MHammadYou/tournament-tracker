namespace TrackerLibrary
{
    public class MatchEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchupModel ParentMatup { get; set; }
    }
}