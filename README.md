# Yahtzee (WIP)
Coded by Jeffrey Michaels using Windows Form Apps in the .NET framework.

Features: Fully playable (and replayable) Yahtzee game with stats collection

# Getting Started
From the main menu, click "Play Game" to start a new Yahtzee game or "View Stats" to view your local stats

# Game Form
In the game form, click "Roll" initially to start the game.

After each roll, click a dice block to "hold" it, preventing the block from being rolled until either the block is clicked again or the round ends. 

After three rolls, the round ends and a score must be selected. Note: you are allowed to select a score before three rolls. 

The game ends when the scorecard is completely filled. After the game is over, your stats will be stored in the stats form

# Stats Form
In the stats form, there are two tabs: "Game History" and "Score and Roll Totals"

"Game History" displays each game's unique ID, the date and time the game was played, and its total score. Clicking on a specific game will bring up its scorecard

"Score and Roll Totals" displays various stats for each score on a scorecard and each potential dice roll

Score stats: Score Type, Times Scored, Total Score, Average Score Per Game

Roll stats: Times Rolled, Turns Held, Average Rolls Per Game, Most Times Rolled in one Game, Least Times Rolled in One Game

# Installation
When downloading this project to Visual Studio, the RESX files may be untrusted by your computer, which will prevent the compiler from running. 

To fix this, head into the folder where the project was stored, left click "MainForm.RESX" and then right click it, click properties, and under "Attributes:", check the "Unblock" checkbox. Repeat these steps for "GameForm.RESX" and "StatsForm.RESX.

(temp) Add link
