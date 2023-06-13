using System.Text.RegularExpressions;
using System;
using static ConVar.Chat;

namespace Oxide.Plugins
{
    [Info("GlobalLanguage", "BlazerWolfy", "1.0.0")]
    [Description("A custom made plugin for EuM Rust that helps with global chat language")]

    public class GlobalLanguage : RustPlugin
    {
        #region Blazer Update System
        private const string UpdateEndpoint = "https://example.com/plugin_update.json";
        #endregion

        private Regex russianRegex;

        private void Init()
        {
            #region Blazer Update System
            webrequest.EnqueueGet(UpdateEndpoint, (code, response) => OnUpdateCheckResponse(code, response), this);
            #endregion

            russianRegex = new Regex(@"\p{IsCyrillic}", RegexOptions.Compiled);
        }

        private object OnPlayerChat(BasePlayer player, string message, ChatChannel channel)
        {
            if(channel != ChatChannel.Global)
            {

            }
            else
            {
                if (russianRegex.IsMatch(message))
                {
                    Puts($"Russian letters detected in chat message from player {player.displayName}");
                    player.ChatMessage("Please refrain from typing Russian in global chat");
                    return false;
                }
            }
            return null;
        }

        #region Console Color
        private void PrintColoredMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        #endregion

        #region Blazer Update System
        private void OnUpdateCheckResponse(int code, string response)
        {
            if (code == 200 && !string.IsNullOrEmpty(response))
            {
                var updateInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateInfo>(response);
                string currentVersion = this.Version.ToString();

                // Compare the latest version with the current version
                if (IsNewerVersion(updateInfo.Version, currentVersion))
                {
                    Puts("An update is available!");
                    Puts("Latest version: " + updateInfo.Version);
                    Puts("Download URL: " + updateInfo.DownloadUrl);
                }
                else
                {
                    Puts("No updates available.");
                }
            }
            else
            {
                Puts("Failed to check for updates: HTTP request failed");
            }
        }

        private bool IsNewerVersion(string version1, string version2)
        {
            // Implement your version comparison logic here
            // Return true if version1 is newer than version2; otherwise, return false

            // Example implementation assuming semantic versioning (x.y.z)
            var v1 = new Version(version1);
            var v2 = new Version(version2);
            return v1 > v2;
        }
    }

    public class UpdateInfo
    {
        public string Version { get; set; }
        public string DownloadUrl { get; set; }
    }
    #endregion
}