using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel    TeamCompeting { get; set; }
        /// <summary>
        /// Score for this particular team
        /// </summary>
        public double       Score { get; set; }
        /// <summary>
        /// Represents the matchup the winner came from
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }


    }
}
