using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchEntryModel> Entries { get; set; } = new List<MatchEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }   
    }
}