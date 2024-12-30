using System.Collections.Generic;
using Jotunn.Utils;
using UnityEngine;

namespace TrashAdultsRoundsPack
{
    public static class Assets 
    {
        
        public static readonly string TrashAdultsModPackBundle = "trashadultsmodpack";
        
        public static Dictionary<string, GameObject> CardArt = new Dictionary<string, GameObject>();
        
        public static void LoadArt(this Dictionary<string, GameObject> cardStore, string bundleName, List<string> assetNames)
        {
            AssetBundle bundle = AssetUtils.LoadAssetBundleFromResources(bundleName, typeof(TrashAdultsMod).Assembly);

            foreach (string cardName in assetNames)
            {
                GameObject art = bundle.LoadAsset<GameObject>("C_" + cardName);
                if (art != null)
                {
                    cardStore.Add(cardName, art);
                }
            }
        }
        
       public static void LoadCardArt()
        {
            var cards = new List<string>
            {
                "Boing",
            };
            
            Assets.CardArt.LoadArt(TrashAdultsModPackBundle, cards); 
    }
        
    }
}