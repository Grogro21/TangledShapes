namespace ShapeSMOdel
{
    public class Utilities
    {
        public static string FindDirectory(string theme)
        {
            string dir = Utilities.FindAssetsDirectory() + Path.DirectorySeparatorChar + theme;
            if (!Directory.Exists(dir))
            {
                throw new Exception("Theme not found");
            }
            return dir;
        }

        public static string FindAssetsDirectory()
        {
            string dir = Environment.CurrentDirectory;
            dir = Path.Combine(dir, "..");
            dir = dir + Path.DirectorySeparatorChar + "Assets";
            return dir;
        }


        public static string[] GetRandomThemes(int number)
        {
            string themeName;
            string dir = Utilities.FindAssetsDirectory();
            string[] themes = [];

            for (int i = 0; i < number; i++)
            {
                do
                {
                    Random rand = new Random();
                    themeName = Directory.GetFiles(dir)[rand.Next(Directory.GetFiles(dir).Length)];
                }
                while (themes.Contains(themeName));
                themes.Append(themeName);
            }
            return themes;
        }

        public static string[] ChoseTangledThemes(string[] themes, int number)
        {
            string themeToAdd;
            for (int i = 0; i < number; i++)
            {
                do
                {
                    Random rand = new Random();
                    themeToAdd = themes[rand.Next(themes.Length)];
                }
                while (themes.Contains(themeToAdd));
            }
            return themes;
        }
    }
}
