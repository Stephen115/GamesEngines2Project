# Games Engines 2 Assignment
### Buck Rogers in the 25th Century scene
### By Stephen Creighton C17344841 DT228/4

## Description
For this project I will be working on a Scene from Buck Rogers in the 25th Century.
In this scene, the main character buck rogers has just returned to the Draconian flagship, where it is attacked seemingly by pirate marauders which have caused trouble for earth recently.
Because of the lack of trust Colonel Wilma Deering has in Bucks story he isn’t allowed to control his ship during the battle and was forced to come along due to him being suspected of being a spy.
Buck makes comments throughout the scene when earths pilots are blown up for relying too heavily on their ships AI.
Buck is finally allowed to fly his ship and takes out the remaining enemy ships, gaining the trust of Deering and returning to 

## Instructions for use
The project needs to be built before being run, however this caused some issues for me so it is recommended to be run through the unity editor, simply run the MainMenu scene and it will give access to all the other scenes.

## Unity Scene Breakdown
So for this assignment I planned on mapping out the chosen scene shot for shot but there were so many camera changes I did not get to finish it in time, so instead I added another scene with a randomized battle and a main Menu UI to choose between the two.

For the scripted battle the Draconian comes under attack, after a short conversation between our protagonists the ThunderFighters are scrambled to destroy the Marauders, we see Baker in a dogfight and he gets destroyed and that is as far as the scene got so the camera cuts to the thunderfighters stuck in the final path position they had.

## Known issues
Running this program from an exe file wrecked my audio driver but I have been having audio driver issues for a while.
Switching scenes and maximising after the scripted events have started both cause a small delay in the sound, if the scene is maximised then run straight off the sound matches perfectly.
Steering in the battle scene is a bit finicky and you can not travel along the Y axis.

Video Link: https://drive.google.com/file/d/1Tyx_3c-o9vkzOsZg-d8fyO3VX3MxGeID/view?usp=sharing 

## Storyboard / Usecase
1. User is brought to the main menu
2. User clicks the scene start or the randomized battle
3. If User clicks the randomized battle, they will find themselves in control of a spaceship in an environment with AI allys and enemies, they will see how the battle plays out.
4. If the User clicks the scene, they will be brought to an intro scene which will play the intro from the Buck Rogers in the 25th Century movie, at the end of that clip thunderfighter models will fly over the camera.
5. The Scene changes to a view of inside the hangar of the Draconian, you hear the characters speak about the situation they are in.
6. The Camera changes to an outside view of the draconian travelling through space, to set the scene.
7. The Camera changes to show the incoming Marauder attackers fly by the camera and towards the Draconian.
8. Back to the inside of the Hangar for more talking, the alarm is raised about the incoming attack
9. The Marauders carry out a flyby and fire on the Draconian.
10. Camera shows the explosion on the front of the Draconian.
11. Back to the Hangar.
12. Another attack flyby with the marauders barrel rolling.
13. A view of the thunderfighters taking off from inside the tunnel, and inside the cockpit of a thunderfighter.
14. A view of the Thunderfighters gaining altitude and shooting past at speed.
15. You see a marauder tailing a thunderfighter and hear Buck Rogers warn the pilot
16. Camera shows a front view of the Marauder firing
17. You see the Marauder chase down and explode the thunderfighter

**End of the scene here as I ran out of time, but then implemented a randomly generated fight scene and main menu to make up for it**

## Technical Description
For this project I made use of a number of tools Unity offers, I will lay out below some details involved with the development of this project:
* Post-Processing I created a volume for all the cameras in each scene to add some mood to them and make the emission from some objects stand out more, I gave each a layer and altered settings like the bloom
* Trail Renderers, All the ships have their own trail renderers which also have a material with emission on them to work with the post processing to make them appear brighter, the same goes for the lasers the ships fire
* The explosion effect I got from an asset pack
* The Draconian ship, The Marauder Ship, and the Thunderfighter ship were all made using Blender during the interim phase of this project, I have never used blender before then so they all took about 3 days each.
* The Cameras are managed using a mix of two scripts I created, the first is a manager that switches the cameras based on a check for a public value, this means if the cameraID is set to the right value the corresponding camera will be activated and all others will be deactivated. 
* The other script is the move forward script, I used a thunderfighter prefab like the ones in the intro a distance away from the scene so they would not be in view, they travel at a constant rate in one direction and hit off a series of checkpoints which will activate different scene objects, such as the AI for the thunderfighters or the explosions on the front of the Draconian. To do this I added tags to each hit box and made them change the camera value from the camera manager object.
* The Thunderfighters use Finite State Machines, the checkpoint on move forward activates the first part of the finite state machine but it only invokes the AI after a given time as each Thundefighter had to take off one at a time, this is done by a public value that sets the float in the script that starts the machine.
* There are unused scripts and behaviours as they may have been intended for future but I stopped before I was finished.
* The finite state machine main script is taken from class, but the behaviours and the starting for the FSM were all made by me, the AI scripts for the random battle all are made by me, the boid scripts and bigboid and pathfollow are all from class, but have been altered in places to fit this situation.
* There are a number of behaviours in the FSM such as taking off for the thunderfighters that take off in the scripted scene, there are shoot behaviours for activating a script that fires, the shooting script is taken from class but altered, there is a boost behaviour which adds a larger force to the thunderfighters when they go through the tunnel, there is a wander behaviour and a target behaviour for the battle scene.
* There is a script for controlling the ship that wasnt really used because the bigboid accomodated for this in the end.
* The shader was from my Games Engines 1 assignment which itself was from the shaders in class.

