This project is a simple Rock, Paper, Scissors game written in C#. The gist of
the game is to beat the CPU to 3 total wins by selecting the rock, paper, or
scissors options. Focused on assuring that the player can't input invalid choices
using RequireValidEntry and ToUpper methods. You can play the game as many times
 as you want by selecting"y" to continue or "n" if you choose to exit the program.

The 3 features I added to this project:
1. By using a while loop as my "master loop" where the user can repeatedly enter
 commands/perform actions, including choosing to exit the program.

2. I Implement a log that records errors, invalid inputs, or other important
events and writes them to a text file by using a streamwriter method. Currently
the Logs.txt file is located in the bin in the project folder.

3. I used a scoreboard like feature to have a visual representation of data--
mainly scores for each game one whether player, cpu, or draw.
 