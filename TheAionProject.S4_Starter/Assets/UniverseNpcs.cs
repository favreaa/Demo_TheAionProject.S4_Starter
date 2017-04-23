using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject 
{
    /// <summary>  
    /// static class to hold all npc objects 
    /// </summary>  
    public static partial class UniverseObjects
    {
        public static List<Npc> Npcs = new List<Npc>()  
        {
            new Civilian
            {
                Id = 1,
                Name = "Lorax Named Jim",
                SpaceTimeLocationId = 2,
                Description = "A short stubby Lorax, who wears a suit and cannot be trusted.",
                Messages = new List<string>
                {
                    "Ah I have not seen you around these parts before you must be traveling." + 
                    "For a good drink go to the Bar and Grille.",
                    "In my youth I was a general in the wars of the Lorax invasions.",
                    "I have plans to take over the universe you should join my cause."
                }
            },

            new Civilian
            {
                Id = 2,
                Name = "Bob the Merchant",
                SpaceTimeLocationId = 1,
                Description = "Is a Merchant who is always trying to sell something that he does not have.",
                Messages = new List<string>
                {
                    "That coat is a little ugly, once I have one in stock ill sell it to you.",
                    "Space Nukes could help in your conquest, too bad I just sold the last one to to a Lorax named Jim .",
                    "Is that man following you?"
                }
            },

            new Civilian
            {
                Id = 3,
                Name = "Benny the Godfather of the SpaceWorm Gang",
                SpaceTimeLocationId = 2,
                Description = "A slow SpaceWorm who is notorius for eating his enemies.. be very cautious."
            }
        };
    }
}
