using ICities;

namespace ShroomPack
{
    public class ShroomPack : IUserMod
    {
        public string Name
        {
            get { return "Shroom flag pack"; }
        }

        public string Description
        {
            get { return "Shroom flag pack"; }
        }

        public string[][] CustomFlags()
        {
            return new[]
            {
                new[] {"hippy", "Hippy"},
                new[] {"colors", "Colors #1"},
                new[] {"colors2", "Colors #2"},
                new[] {"business", "Business"}
            };
        }
    }
}
