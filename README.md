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

## Scope of Project
The Oh, Village! app will be the main UI to provide the user with the game and multiplayer feature of the game. 

- Features to be completed by mid-June :

  The **main features** of Oh, Village! and the big picture of the gameplay system would be the focus of the implementation.
    - The game should have its structure of menu page and the game itself. 
    -	The cards should have formed including their effects, hit points (HP), and/or functionalities. 
    -	There should be a prototype of the game design and big picture of the gameplay.
    - The first phase of game balancing should be completed.
    
- Features to be completed by mid-July :

  The **extensions and additional features** of Oh, Village! would be implemented during this period of time.
    - The game design (UI/UX) should be refined, and background music (SFX) should be added.
    - There should already be animation of card dealing and deployment.
    - Tutorials and guides towards the game should have been implemented.
    - The online multiplayer version of the game should be added.
    - The balancing and beta-testing of the game should be finished.

## Tech Stack
These following tech stacks would be used in our project :
- Unity
- C# (Visual Studio)

## Program Flow

![Oh!Village_Program_Flow](https://user-images.githubusercontent.com/70026153/120075076-6bd94b80-c0d2-11eb-8e3a-5e6bab66c13b.png)

## Gameplay
Oh, Village! game supports 2, 3, or 4 players gameplay. The objective of this game is to be the last player surviving after a series of turns. The players will take turn in deploying cards or attacking their opponents with their available energy. Energy is used either in deploying cards into the playing field or attacking opponents with the deployed heroes. Each player has a hitpoint (HP) which should be maintained above 0, otherwise they would die. The cards are drawn from a pool of cards in which every draw has the same distribution of the cards, despite the results of previous draws.  
<br>
There are three kinds of playable cards: **Hero** cards, **Weapon** cards, and **Spell** cards. Hero cards could be deployed into heroes in the playing field which could attack one of the opponents while it is still alive. Heroes could also be equipped with Weapons (deployed into the playing field by Weapon cards) which would increase their attack power but also increase its attacking-energy-cost. Spell cards have various effects that could affect many opponents simultaneously. 
Currently the attacking system is made default to:
  1. Attack opponent's hero with lowest HP
  2. If no heroes available, attack the opponent. 

In the future, more features would be made including addition of cards, balancing of the cards, different modes (starting HP, Turn limit), and improvements of the UI. 
In the current prototype of this version, the cards available are only 2, but the basic gameplay and the backbone of the game logic is already finished. The basic UI and the clickable cards and attacking scheme are already implemented. 

## Developmental Plan

<table>
  <tr>
    <td>
      <b>No.</b>
  </td>
  <td>
    <b>Task</b>
  </td>
  <td>
    <b>Expected Completion Date</b>
  </td>
  <td>
    <b>By Milestone</b>
  </td>
  </tr>
  <tr>
    <td>
      1.
    </td>
    <td>
      Creation of Main Menu : <br>
      - Local Play (Done) <br>
      - Settings (To do)
    </td>
    <td>
      05/06/21
    </td>
    <td>
      2
    </td>
  </tr>
  <tr>
    <td>
      2.
    </td>
    <td>
      Creation of all playable cards : <br> 
      - Character (Done) <br>
      - Weapon (To do) <br>
      - Spell (To do)
    </td>
    <td>
      08/06/21
    </td>
    <td>
      2
    </td>
  </tr>
  <tr>
    <td>
      3.
    </td>
    <td>
      Gameplay logic coding : <br>
      - Cards' energy usage system (Done) <br>
      - Players' energy and HP indicator (Done) <br>
      - Turns and deployment of cards (Done) <br>
      - End turn and win declaration (Done)
    </td>
    <td>
      20/06/21
    </td>
    <td>
      2
    </td>
  </tr>
  <tr>
    <td>
      4.
    </td>
    <td>
      Completion of local play : <br>
      - Card dealing and deployment animation (Done) <br>
      - Card balancing (readjustments of card stats) (To do) <br>
      - Card stack finalizing (To do) 
    </td>
    <td>
      27/06/21
    </td>
    <td>
      2
    </td>
  </tr>
  <tr>
    <td>
      5.
    </td>
    <td>
      Completion of Settings Menu and How to Play Menu : <br>
      - Creation of SFX (BGM and Sound Effects) <br>
      - Tutorial, Rules, and Card Lists of the game.
    </td>
    <td>
      04/07/21
    </td>
    <td>
      3
    </td>
  </tr>
  
  <tr>
    <td>
      6.
    </td>
    <td>
      Game design refining : <br>
      - UI/UX smoothing on 2 Player Gameplay <br>
      - 3 Player and 4 Player Gameplay Finishing. <br>
      - Animation refinement for scene transitions.
    </td>
    <td>
      11/07/21
    </td>
    <td>
      3
    </td>
  </tr>
  
  <tr>
    <td>
      7.
    </td>
    <td>
      - Finalizing Card deck ratio and designs. <br>
    </td>
    <td>
      24/07/21
    </td>
    <td>
      3
    </td>
  </tr>
  
  <tr>
    <td>
      8.
    </td>
    <td>
      Game completion : <br>
      - Beta testing <br>
      - Card rebalancing <br>
      - Energy system rebalancing <br>
      - Bug fixing
    </td>
    <td>
      26/07/21
    </td>
    <td>
      3
    </td>
  </tr>
  </table>

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
  
  </table>

| Total Hours | Orbitee 1 | Orbitee 2 |
| --- | --- | --- |
| 158 | 79 | 79 |

