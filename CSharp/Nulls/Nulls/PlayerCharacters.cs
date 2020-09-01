using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls
{
    class PlayerCharacters
    {
        public string   Name                { get; set; }
        public bool?    IsNewPlayer         { get; set; }
        public int?     DaysSinceLastLogIn  { get; set; } // ? is same as Nullable<int>
        public DateTime? Birthday           { get; set; } // ? is same as Nullable<DateTime>
    }
}
