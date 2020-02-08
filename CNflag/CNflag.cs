using ICities;

namespace CNFlags
{
    public class CNFlags : IUserMod
    {
        public string Name
        {
            get { return "Chinese Flags"; }
        }

        public string Description
        {
            get { return "Chinese Flags"; }
        }

        public string[][] CustomFlags()
        {
            return new[]
            {
                new[] {"china", "China"},
            };
        }
    }
}
