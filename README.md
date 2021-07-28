# Oh, Village!

## Orbital Project 
**Proposed level of achievement** : Apollo 11

## Motivation
**Role-playing games (RPG)** in form of card games are getting less and less popular these days. This is because gamers do not consider this type of game as fun as other types of games, such as Multiplayer Online Battle Arena (MOBA) like Mobile Legends: Bang Bang or DOTA 2. However, we think this phenomenon is happening because RPG card games currently in the market are not as fun, because companies are putting a lot of their resources on more popular type of games, like MOBA, FPS, or battle royale game. Also, this could happen because RPG card games are more fun to be played offline, with actual cards. Hence, we want to popularize this type of game which was popular in the 80’s, such as Dragons and Dungeon (D&D) game. We tried to use deployment and energy systems for the gameplay, with fair amount of good cards and counters toward each card so that no cards will be too overpowered.

## Aim
We would like to make a RPG card game, called “Oh, Village!” with characters, weapons, spells, and trap cards that could be played using computers that mimics user’s experience of playing with actual cards. We also would like to improve user experience by giving them alternatives in how they stack their in-hand-cards. To increase the playability of this game, we will make the cards as simple as they could be from the design aspect to the functionality aspect so that new players would find it easy to adapt and master the strategy in this game. 

## User Stories
  1.	As a new player, I would like to understand and master the strategy of the game faster.
  2.	As a player, I would like to have a platform to play with my friends.
  3.	As a player, I would like the platform to be adjustable with my likings in term of how to stack my card. 
  4.	As a professional player, I would like to have a platform to play with other game enthusiasts of the community. 

## Features
The Oh, Village! app will be the main UI to provide the user with the game and multiplayer feature of the game. 
The **main features** of Oh, Village! including: 
- 2 players gameplay
- Hero, Spell, and Weapon Cards to play
- Customizable starting HP and total turns to play
- Playing field and players' hand field for easier look at the current position in the game
- Self explanatory cards that include their own attributes. 

## Tech Stack
These following tech stacks would be used in our project :
- Unity
- C# (Visual Studio)
- Photoshop CC17

## To open the game 
You should :
- Open Unity v2020.3.8f1; platform Windows-64bit, and Download this whole repository and open the game using Unity Hub. 
- Or, you can access the executable via https://villageproducer.itch.io/oh-village and follow the installation instruction there. 

## Program Flow

![Oh!Village_Program_Flow](https://github.com/HalphasX/Oh-Village/blob/main/Program%20Flow.png)

## Gameplay
Oh, Village! game supports 2 players gameplay. The objective of this game is to be the last player surviving after a series of turns. The players will take turn in deploying cards or attacking their opponents with their available energy. Energy is used either in deploying cards into the playing field or attacking opponents with the deployed heroes. Each player has a hitpoint (HP) which should be maintained above 0, otherwise they would die. The cards are drawn from a pool of cards in which every draw has the same distribution of the cards, despite the results of previous draws.  
<br>
There are three kinds of playable cards: **Hero** cards, **Weapon** cards, and **Spell** cards. 
<br>
**Hero Cards**
<br>
Hero cards could be deployed into heroes in the playing field which could attack one of the opponents while it is still alive. Some heroes could also be equipped with Weapons (deployed into the playing field by Weapon cards) which would increase their attack power or HP but also increase its attacking-energy-cost. 
The attacking system is made default to:
  1. Attack opponent's hero with lowest HP
  2. If no heroes available, attack the opponent. 
The available heroes are: 
  1. Villager
  2. Cleric
  3. Guardian
  4. Knight
<br> 
**Weapon Cards**
Weapon cards could be equipped by some specific heroes to gain some additional attributes.
The available weapons are: 
  1. Sword for Knights which would increase Attack Power
  2. Shield for Guardians which would increase HP
  3. Staff for Clerics which would increase its healing effect
<br> 
**Spell Cards**
Spell cards are rare and some have very powerful effects. The attacking spell cards will directly attack the user, not just their heroes. In addition, some of the spells have annoying effects as well. 
The available spells are: 
  1. Hellfire
  2. Tornado
  3. Lightning
  4. Fireball
  5. Double Slash
  6. Heal Spell (S, M, L)
<br> 
Players could customize their starting HP and total turns which could be done in the starting scene. If the game reaches the total turns, it will automatically stopped and the player with more HP will win. Players can look at the available cards in Library and how to play this game in How To Play scene of the game. 

## Project Log
<table>
  <tr>
    <td>
      <b>No.</b>
  </td>
  <td>
    <b>Task</b>
  </td>
    <td>
      <b> Date </b>
    </td>
  <td>
    <b>Orbitee 1 (hrs)</b>
  </td>
  <td>
    <b>Orbitee 2 (hrs)</b>
  </td>
    <td>
      <b> Remarks </b>
    </td>
  </tr>
  <tr>
    <td>
      1.
    </td>
    <td>
      Liftoff : Programme Overview
    </td>
    <td>
      11/05/21
    </td>
    <td>
      3
    </td>
    <td>
      3
    </td>
    <td>
      Read and reviewed on orbital programme overview slides and milestone samples.
    </td>
  </tr>
    
  <tr>
    <td>
      2.
    </td>
    <td>
      Liftoff : Team meeting with advisor
    </td>
    <td>
      12/05/21
    </td>
    <td>
      0.5
    </td>
    <td>
      0.5
    </td>
    <td>
    - Discussed project idea and possible features extension with the advisor. <br>
    - Discussed possible difficulties in feature implementation.
    </td>
  </tr>
  
  <tr>
    <td>
      3.
    </td>
    <td>
      Liftoff : Poster Creation
    </td>
    <td>
      15/05/21 - 16/05/21
    </td>
    <td>
      3
    </td>
    <td>
      3
    </td>
    <td>
      Created Oh, Village! poster for submission.
    </td>
  </tr>
  
  
  <tr>
    <td>
      4.
    </td>
    <td>
      Liftoff : Video Creation
    </td>
    <td>
      17/05/21
    </td>
    <td>
      3
    </td>
    <td>
      3
    </td>
    <td>
      Created Oh, Village! promotional video for submission.
    </td>
  </tr>
  
  <tr>
    <td>
      5.
    </td>
    <td>
      Team meeting : Gameplay idea discussion
    </td>
    <td>
      21/05/21
    </td>
    <td>
      3.5
    </td>
    <td>
      3.5
    </td>
    <td>
      - Discussed implementations of gameplay, turn-based systems, and energy system for the game. <br>
      - Discussed possible in-game designs that could be included into the game.
    </td>
  </tr>
  
  
  <tr>
    <td>
      6.
    </td>
    <td>
      Discussion on cards to be implemented into the game
    </td>
    <td>
      22/05/21 - 29/05/21
    </td>
    <td>
      4
    </td>
    <td>
      4
    </td>
    <td>
      - Created cards for characters, weapons, and spells. <br>
      - Decided the types and statistics (Att/Def/HP) for each cards.
    </td>
  </tr>
  
  <tr>
    <td>
      7.
    </td>
    <td>
      Unity Workshop
    </td>
    <td>
      22/05/21
    </td>
    <td>
      2
    </td>
    <td>
      2
    </td>
    <td>
      Attended Unity Workshop for the development of the game.
    </td>
  </tr>
  
  <tr>
    <td>
      8.
    </td>
    <td>
      Technical Consultation
    </td>
    <td>
      22/05/21
    </td>
    <td>
      0.5
    </td>
    <td>
      0.5
    </td>
    <td>
      Consulted with Angie about gameplay and recommended implementation of the game using Unity Game Engine.
    </td>
  </tr>
  
  <tr>
    <td>
      9.
    </td>
    <td>
      Team Meeting : Developmental Plan
    </td>
    <td>
      29/05/21
    </td>
    <td>
      4
    </td>
    <td>
      4
    </td>
    <td>
      Decided on the developmental plan of the project, including the timeline and target feature to be implemented in the project.
    </td>
  </tr>
  
  <tr>
    <td>
      10.
    </td>
    <td>
      Team Meeting : Implementation of Main Menu
    </td>
    <td>
      30/05/21
    </td>
    <td>
      8
    </td>
    <td>
      8
    </td>
    <td>
      - Developed features in main menu, which includes entrance screen and buttons in accordance to program flow. <br>
      - Created documentations for the project, including ReadMe and Project Log.
    </td>
  </tr>
  
  <tr>
    <td>
      11.
    </td>
    <td>
      Team Meeting : Finalization of Submission
    </td>
    <td>
      31/05/21
    </td>
    <td>
      3
    </td>
    <td>
      3
    </td>
    <td>
      - Refined errors in the submission file. <br> 
      - Submit submission for Milestone 1. 
    </td>
  </tr>
  
  <tr>
    <td>
      12.
    </td>
    <td>
      Team Meeting : Making plans for Milestone 2 target
    </td>
    <td>
      04/06/21
    </td>
    <td>
      2
    </td>
    <td>
      2
    </td>
    <td>
      - Finalizing target for Milestone 2. <br> 
      - Planning future meetings. 
    </td>
  </tr>
  
  <tr>
    <td>
      13.
    </td>
    <td>
      C# Discussion : C# with Unity Engine Discussion
    </td>
    <td>
      06/06/21
    </td>
    <td>
      4
    </td>
    <td>
      4
    </td>
    <td>
      - Discuss the Unity Engine package in C#, which is the main language used for this game. <br> 
      - Discuss how to implement the game logic. 
    </td>
  </tr>
  
  <tr>
    <td>
      14.
    </td>
    <td>
      C# Learning : Individual Learning of C#
    </td>
    <td>
      07/06/21 - 11/06/21
    </td>
    <td>
      7
    </td>
    <td>
      7
    </td>
    <td>
      - Individual research of packages and functions that would be useful for our game. <br> 
      - Discuss through social media about coding in C#. 
    </td>
  </tr>
  
  <tr>
    <td>
      15.
    </td>
    <td>
      Team Meeting : Implementing the game #1
    </td>
    <td>
      12/06/21
    </td>
    <td>
      5
    </td>
    <td>
      5
    </td>
    <td>
      - Fixed unexpected bugs from previous version. <br>
      - Starting to implement the game logic and the creation of the scenes. 
    </td>
  </tr>
  
  <tr>
    <td>
      16.
    </td>
    <td>
      Team Meeting : Implementing the game #2
    </td>
    <td>
      17/06/21
    </td>
    <td>
      4.5
    </td>
    <td>
      4.5
    </td>
    <td>
      - Finishing the functions needed for attacking and deployment of cards. <br>
      - Starting to work on the graphics and the display of the game. 
    </td>
  </tr>
  
  <tr>
    <td>
      17.
    </td>
    <td>
      Team Meeting : Implementing the game #3
    </td>
    <td>
      19/06/21
    </td>
    <td>
      5.5
    </td>
    <td>
      5.5
    </td>
    <td>
      - Tried to insert the functions into Unity, resulting in many bugs. <br> 
      - Debugging and some refining of the UI. <br>
      - Implemented Pause Menu.
    </td>
  </tr>
  
  <tr>
    <td>
      18.
    </td>
    <td>
      Team Meeting : Implementing the game #4
    </td>
    <td>
      26/06/21
    </td>
    <td>
      6.5
    </td>
    <td>
      6.5
    </td>
    <td>
      - More debugging and finishing on the attacking gameplay. <br> 
      - Adding some more icons and graphics for the game. <br>
      - Finished modifying the gameplay for two players and the functionalities of the continue button.
    </td>
  </tr>
  
  <tr>
    <td>
      19.
    </td>
    <td>
      Team Meeting : Finalization of Game Submission 
    </td>
    <td>
      27/06/21
    </td>
    <td>
      6
    </td>
    <td>
      6
    </td>
    <td>
      - Finishing to make the game presentable. <br> 
      - Fixed bugs occured from Unity build setting and hierarchy of game objects. 
    </td>
  </tr>
  
  <tr>
    <td>
      20.
    </td>
    <td>
      Team Meeting : Finalization of Submission
    </td>
    <td>
      28/06/21
    </td>
    <td>
      4
    </td>
    <td>
      4
    </td>
    <td>
      - Update Project Log, README.md, and Poster. <br> 
      - Record and upload a video about the current development of the game. 
    </td>
  </tr>
  
  <tr>
    <td>
      21.
    </td>
    <td>
      Team Meeting : Plan Finalization
    </td>
    <td>
      30/06/21
    </td>
    <td>
      5.5
    </td>
    <td>
      5.5
    </td>
    <td>
      - Finalize target and schedule for Milestone 3. 
    </td>
  </tr>
  
  <tr>
    <td>
      22.
    </td>
    <td>
      Team meeting : Cards Plan
    </td>
    <td>
      02/07/21
    </td>
    <td>
      6
    </td>
    <td>
      6
    </td>
    <td>
      - Create an excel file consisting of the cards to be implemented. <br> 
      - Balancing the energy cost, attack power, and attack cost. 
    </td>
  </tr>
  
  <tr>
    <td>
      23.
    </td>
    <td>
      Team Meeting : Coding the Cards #1
    </td>
    <td>
      06/07/21
    </td>
    <td>
      7
    </td>
    <td>
      7
    </td>
    <td>
      - Implementing Hero cards, and some of the Spell cards. <br>
      - Including fixing bugs encountered in the process.       
    </td>
  </tr>
  
  <tr>
    <td>
      24.
    </td>
    <td>
      Team Meeting : Coding the Cards #2
    </td>
    <td>
      09/07/21
    </td>
    <td>
      8
    </td>
    <td>
      8
    </td>
    <td>
      - Completing Spell cards and Weapon cards. <br> 
      - Creating prefabs on Unity and attaching them to the source script. 
    </td>
  </tr>
  
  <tr>
    <td>
      25.
    </td>
    <td>
      Team Meeting : Changing the display in Unity.
    </td>
    <td>
      13/07/21
    </td>
    <td>
      9
    </td>
    <td>
      9
    </td>
    <td>
      - Changing backgrounds of Main Menu, Playfield, and Hands. <br> 
      - Refining UI of the game by allowing players to choose the starting HP and turns limit. 
    </td>
  </tr>
  
  <tr>
    <td>
      26.
    </td>
    <td>
      Team Meeting : Testing and Cards rebalancing
    </td>
    <td>
      15/07/21
    </td>
    <td>
      6
    </td>
    <td>
      6
    </td>
    <td>
      - Testing playing the games a few times and fixed bugs here and there regarding the cards' power.
    </td>
  </tr>
  
  <tr>
    <td>
      27.
    </td>
    <td>
      Testing
    </td>
    <td>
      18/07/21
    </td>
    <td>
      9.5
    </td>
    <td>
      9.5
    </td>
    <td>
      - Test the game by letting some groups of our friends play, and collect their feedbacks on the spot. 
    </td>
  </tr>
  
  <tr>
    <td>
      28.
    </td>
    <td>
      Team Meeting : Cards rebalancing
    </td>
    <td>
      21/07/21
    </td>
    <td>
      7
    </td>
    <td>
      7
    </td>
    <td>
      - Rebalance the cards and add some new cards based on our friends' feedback. 
    </td>
  </tr>
  
  <tr>
    <td>
      29.
    </td>
    <td>
      Team Meeting : Finalization of Project on Unity
    </td>
    <td>
      24/07/21
    </td>
    <td>
      3
    </td>
    <td>
      3
    </td>
    <td>
      - Refining some UI and finalize the project. 
    </td>
  </tr>
  
  <tr>
    <td>
      30.
    </td>
    <td>
      Team Meeting : Finalization of Submission for Milestone 3
    </td>
    <td>
      26/07/21
    </td>
    <td>
      4
    </td>
    <td>
      4
    </td>
    <td>
      - Update Project Log, README.md, and Poster. <br> 
      - Record and upload a video about the final product.
    </td>
  </tr>
  
  
  </table>

| Total Hours | Orbitee 1 | Orbitee 2 |
| --- | --- | --- |
| 288 | 144 | 144 |

