using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MathupEntryModel> Entries { get; set; }
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }   
    }
}