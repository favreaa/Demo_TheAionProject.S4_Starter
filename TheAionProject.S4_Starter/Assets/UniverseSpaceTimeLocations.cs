using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold all objects in the game universe; locations, game objects, npc's
    /// </summary>
    public static partial class UniverseObjects
    {
        public static List<SpaceTimeLocation> SpaceTimeLocations = new List<SpaceTimeLocation>()
        {
   new SpaceTimeLocation
            {
                CommonName = "Flux Home base",
                SpaceTimeLocationID = 1,
                UniversalDate = 386759,
                UniversalLocation = "P-5, SS-157, G-429, LS-3001",
                Description = "The Flux Engagements home base is located in  " +
                    "the captial city of Zanzabar and is the primary " +
                    "base for missing artifacts.\n",
                GeneralContents = "The base is large, cold, and very old " +
                    "This was the first base of its kind, built in the yar 2055 " +
                    "by the old humans of yesterday. \n",
                Accessible = true,
                ExperiencePoints = 20
            },

            new SpaceTimeLocation
            {
                CommonName = "Hogwarts Medical Bay",
                SpaceTimeLocationID = 2,
                UniversalDate = 386759,
                UniversalLocation = "P-27, SS-92, G-4000, LS-295",
                Description = "The Hogwarts medical bay is the primary place where you can " +
                    "improve your health, if every you will need to do so" +
                    "The medical bay was founded by the space worms.",
                GeneralContents = "- Medical Supplies-",
                Accessible = true,
                ExperiencePoints = 10

            },

            new SpaceTimeLocation
            {
                CommonName = "Universal Bar and Grille",
                SpaceTimeLocationID = 3,
                UniversalDate = 386759,
                UniversalLocation = "P-9, SS-1242, G-3004, LS-2995",
                Description = "The Universal Bar and Grile is a place where you can relax after a " +
                              "long day of fighting off the evil Loraxians " +
                              "where all your troubles can dissapear.",
                GeneralContents = "- Beer and Spirits.. -",
                Accessible = false,
                ExperiencePoints = 20
            },

            new SpaceTimeLocation
            {
                CommonName = "Edge of the Universe",
                SpaceTimeLocationID = 4,
                UniversalDate = 386759,
                UniversalLocation = "P-99, SS-999, G-9999, LS-99991",
                Description = "The edge of the universe is the furhest away base on the edge of our universe." +
                              "This area has a wealth of knowledge, to aide in finding the locations of the  " +
                              "long lost artifacts that could start the last war.",
                GeneralContents = "- Books, Computer information, documentation -",
                Accessible = true,
                ExperiencePoints = 25
            }
        };
    }
}
