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
        public static List<GameObject> gameObjects = new List<GameObject>()
        {
            new TravelerObject
            {
                Id = 1,
                Name = "Box of Unubtanian",
                SpaceTimeLocationId = 2,
                Description = "A box that contains 10 Unubtanian peices.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 2,
                Name = "Piece of Eight",
                SpaceTimeLocationId = 3,
                Description = "A precious black stone used by rebel scum for trading.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 3,
                Name = "Morphinite ",
                SpaceTimeLocationId = 3,
                Description = "A chemical compound that provides medical use.",
                Type = TravelerObjectType.Medicine,
                Value = 45,
                CanInventory = false,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 4,
                Name = "Flux guide to the universe",
                SpaceTimeLocationId = 3,
                Description =
                    "Memo: Unkown origin" + "/n" +
                    "Universal Date: Unknown" + "/n" +
                    "/n" +
                    "This document will provide the secrets of the universe .",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 8,
                Name = "Lorax Transporter ",
                SpaceTimeLocationId = 0,
                Description =
                    "a small device that can transport you anywhere in the universe .",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 9,
                Name = "Military Pack",
                SpaceTimeLocationId = 0,
                Description =
                    "Provides anything you will need for 24 hours ",
                Type = TravelerObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            }
        };
    }
}
