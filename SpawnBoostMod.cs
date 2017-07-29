using Terraria;
using Terraria.ModLoader;

/// <summary>
/// This mod should be compiled with Terraria Mod Loader
/// 
/// This mod was based on starting code provided by Terraria forum member jopojelly. It has been modified to customize the effect and updated
/// for the current version of Terraria (1.3.5.2) / tModLoader (0.10.0.2)
/// https://forums.terraria.org/index.php?threads/any-monster-spawn-rate-and-spawn-cap-mod.48567/
/// 
/// The mod will alter the behavior of the Terraria battle potion. By default the potion marginally increases enemy spawn rates and totals.
/// This mod alters it such that it greatly increases these amounts, allowing for large encounters similar to that of invasions.
/// 
/// </summary>
namespace SpawnBoostMod
{
    class SpawnBoostMod : Mod
    {
        public SpawnBoostMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
            };
        }
    }

    class SpawnRateMultiplierGlobalNPC : GlobalNPC
    {
        private static float maxMultiplier = 10f;
        private static float spawnMultiplier = 3f;
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (player.enemySpawns)
            {
                spawnRate = (int)(spawnRate / spawnMultiplier);
                maxSpawns = (int)(maxSpawns * maxMultiplier);
            }
        }
    }
}