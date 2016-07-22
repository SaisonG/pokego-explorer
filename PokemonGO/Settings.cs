using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGO
{
    internal static class Settings
    {
        internal static readonly string PTC_USERNAME = "decaf0ddba11";
        internal static readonly string PTC_PASSWORD = "0dde57";

        internal static readonly int EXPLORATION_STEPS = 30; // Number of steps (increase this to explore a wider area)
        internal static readonly int STEP_DELAY = 1; // Seconds between steps
        internal static readonly int CLEAR_DELAY = 30; // Seconds between clearing map

        internal static readonly string STARTING_LOCATION = "Seattle, WA"; // Example: Time Square, New York City

        internal static readonly int POKEMON_IMAGE_SIZE = 40;

        internal static readonly int LOGIN_RETRIES = 40;
    }
}
