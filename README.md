
# Pong

Simple Pong game created within Console. Just for pure fun and git training.

I saw many similar project (snake, contra etc.) so I told my self it would be fun to create something similar.

![Pong](https://github.com/mwawerHub/Pong/raw/master/pong.png "Pong")

# Tech

Repository contains both versions for:
	Net Core 3.1
	Net Framework v4.0
	
For background music in Core version I used NAudio library: https://github.com/naudio/NAudio

# Gameplay

The game mechanics are far from ideal due to Console environment. 
This project should be considered more like a curio than a fully-fledge game

Player 1 moves using W A S D keys
Player 2 moves using arrow keys

I shifted a little bit the behavior of ball bounce to cheat the lack of physics in Console.
So you can expect unusual angle changes after collisions. 

# Unsafe code block

Unsafe code block is used in Console Helper to ensure proper dimensions of console window
I consumed WinAPI to call kernel and gain control over console window properties. 

You can check the unsafe code block here https://github.com/mwawerHub/Pong/tree/master/Pong/PrepareConsole
