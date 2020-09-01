using System;

namespace Nulls
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacters();
            player.Name = "Sue";
            player.DaysSinceLastLogIn = 3;
            player.IsNewPlayer = true;
            //player.Birthday = "01/01/2010";

            PlayerDisplayer.Players(player);
        }
    }
}
