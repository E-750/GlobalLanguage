![Logo](https://i.ibb.co/YQTqPT2/repository-open-graph-template.png)

A plugin for Rust that helps server owner preventing players from typing specificed language in Global Chat only allowing other languages in [Team] Chat.
## Installation

```bash
  Start by going to release tab
  Download GlobalLanguage.zip
  unpack the file
  Drag and drop the GlobalLanguage.cs
  inside your oxide/plugins folder
  setup the config file inside oxide/config
  based on what you prefer
```
    
## Screenshots

![GlobalLanguageExample](https://i.ibb.co/HCYCDv3/Global-Language-Example.png)

## Known Bugs

- None

## Changelog

- Fixed BetterChat capabilities.
- Fixed some Format console color issues.
- Added backward capabilities for servers who isn't using BetterChat.

## Used By

This plugin is used by the following servers:

- [EUM] EuM | PvE x1000 |KIT|TOWN|HOME|REMOVE|NO VIP
## Support

For support, contact me on discord **blazerwolfy**


## Authors

- [[EuM] BlazerWolfy](https://steamcommunity.com/id/BlazerWolfy/)


## Configuration File Usages
```json
{
  "ActionToPerform": "Mute", // Action to perform upon typing in the forbidden language (Available action: None, Kick, Ban, Mute)
  "KickReason": "You were kicked", // The reason to display to the player on Kick Action
  "BanReason": "You were banned", // The reason to display to the player on Ban Action
  "MuteReason": "You were muted", // The reason to display to the player on Mute Action
  "ForbiddenLanguageMessage": "", // The text to display to the player on typing the forbidden language in the global chat
  "MaxWarningsToKick": 5, // The amount of warnings a player gets before they're affected by **Kick**.
  "MaxWarningsToBan": 10, // The amount of warnings a player gets before they're affected by **Ban**.
  "MaxWarningsToMute": 3, // The amount of warnings a player gets before they're affected by **Mute**.
  "ShouldPlayerSeeWarnings": true, // This only works if the 'ActionToPerform' is Kick, Ban, Mute
  "UpdateChecker": true,
  "DebugMode": false // Tells you some useful debugging information
}
```
