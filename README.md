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
## Roadmap

- Add more options for server owners

- Add configuration file for custom messages


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
  // What language should be forbidden in the Global Chat? (Currently only supports one language at a time)
  "ForbiddenLanguage"

  // What message the player who type the forbidden language in global chat should see before theirs message was cancelled
  "ForbiddenLanguageMessage"

  // What message should the console access see when the player who type the forbidden language in Global chat should see
  "ForbiddenLanguageConsoleMessage"

  // Enable or Disable whatever console access should see the player who tried to talk the forbbiden language in global chat
  "DebugLang"

  // Enable or Disable automatic update checker
  "UpdateChecker"
}
```
