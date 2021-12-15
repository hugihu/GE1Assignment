# Games Engine 1 Assignment 

Name: Hugh O'Carroll-Macri

Student Number: C17316046

Class Group: TU857

# Description of the project
The goal for this project was to create a procedurally generated system in Unity. This System comprises of one main scene, the procedural generated landscape with different biomes with the intention of random coins to be spawned in and be collectable by the player(coins not working). The landscape is generated using Perlin Noise so the landscape changes based on the seed. 

Link to Youtube Video: https://youtu.be/ShXoayBq34o
# Instructions for use
To use this project clone the repository into a suitable folder of your chosing. Launch the unity hub and install the version: "2020.3.21f1" once installed, open the project and browse through your file explorer to find the project folder. Launch the project and press the play button, you will be placed in a spot on the landscape you can use the controls 'W' 'A' 'S' 'D', to move througout the environment. The mouse can also be used to rotate the persons view. Simply walk around and explore the different biomes. 

# How it Works

Below is the code used to generate waves using PerlinNoise:
![image](https://user-images.githubusercontent.com/36172105/146101789-c8cf9b58-ed96-4e1c-ab15-a73a73f9ab9a.png)
![image](https://user-images.githubusercontent.com/36172105/146101830-9c259447-43bc-4de6-b398-ba44bbdae05d.png)

Below is the code used to be able to 'tab-out' of the game to easily stop/start the program:
![image](https://user-images.githubusercontent.com/36172105/146101946-68a1dde4-8b31-4752-a429-3532c4ecb300.png)

Below is the code used to generate tile depth and width on the mesh vertices in order to create different heights:
![image](https://user-images.githubusercontent.com/36172105/146102039-00d99b53-29b8-4a41-8796-6e36186fab2c.png)

Below is the code used to take the mouse input and turn it into head movement:
![image](https://user-images.githubusercontent.com/36172105/146102121-e76bde08-c199-4e1f-9dfd-e69ad35bb837.png)

Below is the code used to create the head bob effect when sprinting:
![image](https://user-images.githubusercontent.com/36172105/146102236-01f04127-a215-4d39-a0f3-d32f564e2983.png)

Below is the code used to allow for different direction movement in the environment:
![image](https://user-images.githubusercontent.com/36172105/146102316-8d0381b3-ff79-4217-97eb-1b37335e1959.png)


 | Scripts and Assets |  Source |
 |----------|---|
 | FirstPersonController | Followed Tutorial |
 | HeadBob | Followed Tutorial  |
 | MouseLook| Followed Tutorial  |
 | RigidbodyFirstPersonController    | Followed Tutorial  |
 | LevelGeneration | Self Written | 
 | Coin | Self Written | 
 | NoiseMapGeneration | Self Written |
 | SimpleActivatorMenu | Self Written |
 | TileGeneration | Self Written |
 | Coin Prefab | Self Made |
 | Level Tile prefab | Self Made |
 | Sample Scenes  | Downloaded asset |
 | Standard Assets | Downloaded asset |
 
 # References 
 
 https://assetstore.unity.com/ - Asset store
 
 https://gamedevacademy.org/complete-guide-to-procedural-level-generation-in-unity-part-3/ - FirstPerson Scripts 
 
 https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351 - Standard Assets
 
 https://assetstore.unity.com/packages/audio/ambient/nature/ambience-banaue-rice-terraces-free-sample-pack-144354 - Audio pack for nature sounds
 
 # What I am Proud of
 
 In this assignment I had huge ambitions and aims to complete for the most case I wasn't able to do what I wanted but I'm proud of my ability to create a moder first person view with head bob, mouse control, sprinting ability and jumping ability. The biomes were successfully created although more work could of been done to polish it out to make them more distincitve. 
 
 # In the Future
 
I would like to be able to get the coin feature to the game as it just makes the game greatly more interesting. I would also like to be able to scale the mountains larger making them more distincitve. A better player model could of been made with hands and legs viewable in the first person view. 
 
