using Newtonsoft.Json;
using VRising.Configuration;

namespace VRising.Localization
{
    internal class GameLocalization
    {
        internal static Dictionary<Guid, string> Load(string fileName)
        {
            var path = Path.Combine(AppConfig.DataFolder, "Localization", fileName);
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Localization file {path} is not found");
            }

            var json = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<GameLocalization>(json);

            foreach (var gameLocalizationNode in data.Nodes)
            {
                foreach (var gameLocalizationCode in data.Codes)
                {
                    gameLocalizationNode.Text = gameLocalizationNode.Text.Replace(gameLocalizationCode.Key, gameLocalizationCode.Text);
                }
            }
            return data.Nodes.ToDictionary(d => d.Guid, d => d.Text);
        }

        public List<GameLocalizationCode> Codes { get; set; }
        public List<GameLocalizationNode> Nodes { get; set; }
    }

    internal class GameLocalizationNode
    {
        public Guid Guid { get; set; }
        public string Text { get; set; }
    }

    internal class GameLocalizationCode
    {
        public string Key { get; set; }
        public string Text { get; set; }
    }
}
