using ICities;

namespace ShroomblazeFlags
{
    public class ShroomblazeFlags : IUserMod
    {
        public string Name
        {
            get { return "Shroomblaze Flags"; }
        }

        public string Description
        {
            get { return "Shroomblaze Flags"; }
        }

        public string[][] CustomFlags()
        {
            return new[]
            {
                new[] {"hippy", "Hippy"},
                new[] {"colors", "Colors #1"},
                new[] {"colors2", "Colors #2"},
                new[] {"business", "Business"},
                new[] {"chirpy", "Chirpy"}
            };
        }
    }
}
