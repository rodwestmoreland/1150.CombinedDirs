using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls
{
    class PlayerDisplayer
    {
        public static void Players(PlayerCharacters player)
        {
            Console.WriteLine( player.Name);
            
            if (!player.DaysSinceLastLogIn.HasValue) //using nullable types in PlayerCharacters (gives methods such as .HasValue)
            {       Console.WriteLine("no past login info");      }
            else {  Console.WriteLine(player.DaysSinceLastLogIn); }
            
            if(!player.Birthday.HasValue) //using nullable types in PlayerCharacters (gives methods such as .HasValue)
            {       Console.WriteLine("no birthday given"); }
            else {  Console.WriteLine(player.Birthday);     }

            if (!player.IsNewPlayer.HasValue) //using nullable types in PlayerCharacters (gives methods such as .HasValue
            {       Console.WriteLine("player status unkown"); }
            else if (player.IsNewPlayer == true)
            {       Console.WriteLine("Player is a noob"); }
            else
            {       Console.WriteLine("Experienced player"); }
        }
        
        
    }
}
