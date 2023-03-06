using EnhancedPlorts.Data.Plorts;
using MelonLoader;

[assembly: MelonInfo(typeof(EnhancedPlorts.ModEntry), "Enhanced Plorts", "1.1", "FruitsyOG")]
[assembly: MelonGame("MonomiPark", "SlimeRancher2")]
namespace EnhancedPlorts
{
    internal class ModEntry : MelonMod
    {
        public override void OnInitializeMelon() { }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            switch (sceneName)
            {
                //Here you have SystemContext loaded and here you registering a translations
                case "SystemCore":
                    {
                        break;
                    }
                //Here you have loaded assets like Identifiables and GameContext
                case "GameCore":
                    {
                        Cotton.ModifyPlort();
                        Flutter.ModifyPlort();
                        Ringtail.ModifyPlort();
                        Batty.ModifyPlort();
                        Phosphor.ModifyPlort();
                        Tabby.ModifyPlort();
                        // Rad.ModifyPlort();
                        Honey.ModifyPlort();
                        Hunter.ModifyPlort();
                        break;
                    }
                //Here you have loaded SceneContext
                case "zoneCore":
                    {
                        break;
                    }
            }
        }
    }
}
