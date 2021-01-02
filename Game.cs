using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantStreamOverlay
{
    public class Game
    {
        public enum Ranks
        {
            Unranked = 0,
            Unknown1,
            Unknown2,
            Iron1,
            Iron2,
            Iron3,
            Bronze1,
            Bronze2,
            Bronze3,
            Silver1,
            Silver2,
            Silver3,
            Gold1,
            Gold2,
            Gold3,
            Platinum1,
            Platinum2,
            Platinum3,
            Diamond1,
            Diamond2,
            Diamond3,
            Immortal1,
            Immortal2,
            Immortal3,
            Radiant
        }

        public enum CompetitiveMovements
        {
            MovementUnknown = 0,
            Stable,
            Promoted,
            Demoted,
            MajorIncrease,
            MajorDecrease,
            Increase,
            Decrease,
            MinorIncrease,
            MinorDecrease
        }

        public Ranks TierAfterUpdate { get; set; }
        public Ranks TierBeforeUpdate { get; set; }
        public int TierProgressAfterUpdate { get; set; }
        public int TierProgressBeforeUpdate { get; set; }

        public string CompetitiveMovement { get; set; }
        public CompetitiveMovements GetCompetitiveMovement
        {
            get
            {
                CompetitiveMovements competitiveMovement;
                switch (CompetitiveMovement)
                {
                    case "PROMOTED":
                        competitiveMovement = CompetitiveMovements.Promoted;
                        break;
                    case "DEMOTED":
                        competitiveMovement = CompetitiveMovements.Demoted;
                        break;
                    case "MAJOR_INCREASE":
                        competitiveMovement = CompetitiveMovements.MajorIncrease;
                        break;
                    case "MAJOR_DECREASE":
                        competitiveMovement = CompetitiveMovements.MajorDecrease;
                        break;
                    case "INCREASE":
                        competitiveMovement = CompetitiveMovements.Increase;
                        break;
                    case "DECREASE":
                        competitiveMovement = CompetitiveMovements.Decrease;
                        break;
                    case "MINOR_INCREASE":
                        competitiveMovement = CompetitiveMovements.MinorIncrease;
                        break;
                    case "MINOR_DECREASE":
                        competitiveMovement = CompetitiveMovements.MinorDecrease;
                        break;
                    case "STABLE":
                        competitiveMovement = CompetitiveMovements.Stable;
                        break;
                    default:
                        competitiveMovement = CompetitiveMovements.MovementUnknown;
                        break;
                }
                return competitiveMovement;
            }
        }

        public int Points
        {
            get
            {
                int diff = 0;
                if (GetCompetitiveMovement == CompetitiveMovements.Promoted)
                    diff = 100;
                else if (GetCompetitiveMovement == CompetitiveMovements.Demoted)
                    diff = -100;

                return TierProgressAfterUpdate - TierProgressBeforeUpdate + diff;
            }
        }
    }
}
