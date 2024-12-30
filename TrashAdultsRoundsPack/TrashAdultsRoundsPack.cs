using System.Collections.Generic;
using BepInEx;
using UnboundLib.Cards;
using HarmonyLib;
using TrashAdultsRoundsPack.Cards;

namespace TrashAdultsRoundsPack
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    
    public class TrashAdultsMod: BaseUnityPlugin
    {
        public const string ModId = "lol.trashadults.rounds";
        public const string ModName = "Trash Adults Rounds Pack";
        public const string Version = "0.0.1"; // What version are we on (major.minor.patch)?

        public const string ModInitials = "TA";

        public static TrashAdultsMod instance { get; private set; }


        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            Assets.LoadCardArt(); 
            
            CustomCard.BuildCard<Boing>(); 
        }
    }
    
}