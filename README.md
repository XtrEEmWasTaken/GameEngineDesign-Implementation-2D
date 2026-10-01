# GameEngineDesign&Implementation-2D
Repository was simple to set up only took me a few minutes to do due to load times and a mistake i made by choosing to make a compplet new repository instead of the actual files i wanted in the repository.

for the project creation it took me much longer due to not having unity installed and  forgeting how to fully use it after a year using unreal engine 5, to solve my problem i used old code from a previous gdw project but couldn't get the jump to work in the alotted time



six Conditions
win get to the end
loss not completing it(not really a physical one but a mental loss)


https://github.com/XtrEEmWasTaken/GameEngineDesign-Implementation-2D


#Lab Assignment 1 

Joseph Chahine 100910379
Title = Coin Collector 
Gameplay loop - A platformer where you have to collect all the coins without touching the red spikes.


[A] Game Starts ->  [B] Coin Manager Created
[B] -> [C] {Does Coin Manager Exist}
[C] -> [D]no = creat Coin Manager Instance
[C] -> [E]Yes = Delete Duplicate
 
[D] -> [F] Player Collects Coin
[F] -> [G] Player/coin script
[G] -> [H] Manager.instance.addCoin
[H] -> [I] Coin Count increases


What element of your game adopts the chosen pattern?

The Game uses a singleton pattern to manage the coin count 

Why is this pattern a good choice for the associated functionality?

This pattern is a good choice for the functionality because the game only need the one pattern and having multiple could cause different scripts with different coin counts leading to inacurate scoring for a single player game