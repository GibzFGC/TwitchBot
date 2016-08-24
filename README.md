# TwitchBot
A smaller Twitch Bot based on my Twitch Channels bot.

## Prerequisites:
- Visual Studio 2015 Community Edition (Written in VB.NET)
- .Net Framework 4.5.2
- SQLite .NET (https://www.nuget.org/profiles/mistachkin)

## SQLite Setup

### Quick Setup:
When you've opened the solution in Visual Studio, head straight to Tools > NuGet Package Manager > Manage NuGet Packages for Solution.

In here, choose the "Browse" tab and in the search box look for SQLite. You're looking for System.Data.SQLite, the official Database Engine.

Click it, on the right tick your project and choose install. As of writing, it's on version 1.0.102.


### Creating the SQLite file:
You will need to create a SQLite file for the program to use in the root/Data folder.

You will need a SQLite editor. I use SQLite Manager (https://addons.mozilla.org/en-GB/firefox/addon/sqlite-manager/) which I've added to Firefox for ease of use and quick editing but there are many options out there for you to choose from.

Create a new SQLite database and name the file TwitchBot.sqlite. Add one new table called "twitchbot_commands". From there, add two columns called "command"
and "value"

Then, just add your commands without the "!". So, as an example. Command: "hello" and Value: "Hi there!" will make !hello work
in chat,

## Features
- New right-click context menu (allows bot naming, erasing of account data).

## Bugs & Fixes
### 24th August 2016
- Fixed: Better application closing handling.
- Fixed: Special characters crashing the application.

## Plans?
This can be extended heavily depending on if people think it would be useful. I always appreciate feedback.

##License?
Please note that this is under the MIT License. I've included a copy in the branch.
