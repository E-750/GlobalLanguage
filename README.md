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
  "CancelRussian": true, // Don't change
  "CancelGerman": false, // Don't change
  "CancelDanish": false, // Don't change
  "ActionToPerform": "None", // None = Nothing, CancelMessage = Cancel the message, Kill = Kills the player after WarningBeforePerforming is 0, Kick = Kicks the player after WarningBeforePerforming is 0
  "WarningBeforePerforming": 3, // The amount of warnings a player gets before they're affected by Kill, Kick.
  "ForbiddenLanguageMessage": "", // The message the player sees in the chat when theirs messages are cancel.
  "UpdateChecker": true, // Automatically checks for updates. And let's the console access know.
  "DebugMode": false // Doesn't do much as of right now.
}
```
