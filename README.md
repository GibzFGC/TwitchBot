# TwitchBot
A smaller Twitch Bot based on my Twitch Channels bot.

## Prerequisites:
- Visual Studio 2015 Community Edition
- SQLite .NET (https://www.nuget.org/profiles/mistachkin)

## SQLite Setup
You will need to create a SQLite file for the program to use in the root/Data folder.

Name the file TwitchBot.sqlite and add one new table called "twitchbot_commands". From there, add two columns called "command"
and "value"

Then, just add your commands without the "!". So, as an example. Command: "hello" and Value: "Hi there!" will make !hello work
in chat,

## Plans?
This can be extended heavily depending on if people think it would be useful. I always appreciate feedback.

##License?
Please note that this is under the MIT License. I've included a copy in the branch.
