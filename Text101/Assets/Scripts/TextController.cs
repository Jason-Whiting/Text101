using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {
		startGame,
		cell0, window0, floor0, bed0, door0, wall0,
		cell1, window1, floor1, bed1, door1, wall1,
		cell2, window2, floor2, bed2, door2, wall2,
		cell3, window3, floor3, bed3, door3, wall3,
		cell4, window4, floor4, bed4, door4, wall4,
		corridor0
	};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.startGame;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.startGame) 	{StartGame();}
		else if	(myState == States.cell0) 		{Cell0();}
		else if (myState == States.window0) 	{Window0();}
		else if (myState == States.floor0) 		{Floor0();}
		else if (myState == States.bed0) 		{Bed0();}
		else if (myState == States.door0) 		{Door0();}
		else if (myState == States.wall0) 		{Wall0();}
		else if (myState == States.cell1) 		{Cell1();}
		else if (myState == States.window1) 	{Window1();}
		else if (myState == States.floor1) 		{Floor1();}
		else if (myState == States.bed1) 		{Bed1();}
		else if (myState == States.door1) 		{Door1();}
		else if (myState == States.wall1) 		{Wall1();}
		else if (myState == States.cell2) 		{Cell2();}
		else if (myState == States.window2) 	{Window2();}
		else if (myState == States.floor2) 		{Floor2();}
		else if (myState == States.bed2) 		{Bed2();}
		else if (myState == States.door2) 		{Door2();}
		else if (myState == States.wall2) 		{Wall2();}		
		else if (myState == States.cell3) 		{Cell3();}
		else if (myState == States.window3) 	{Window3();}
		else if (myState == States.floor3) 		{Floor3();}
		else if (myState == States.bed3) 		{Bed3();}
		else if (myState == States.door3) 		{Door3();}
		else if (myState == States.wall3) 		{Wall3();}		
		else if (myState == States.cell4) 		{Cell4();}
		else if (myState == States.window4) 	{Window4();}
		else if (myState == States.floor4) 		{Floor4();}
		else if (myState == States.bed4) 		{Bed4();}
		else if (myState == States.door4) 		{Door4();}
		else if (myState == States.wall4) 		{Wall4();}
		else if (myState == States.corridor0)	{Corridor0();}
	}
	
	void StartGame() {
		text.text = "Welcome to Text101 Prison Escape.\n\n" +
					"Press 'Space' to begin.";
		if 		(Input.GetKeyDown(KeyCode.Space)){myState = States.cell0;}
	}
	
	void Cell0() {
		text.text = "You have been convicted of a terrible crime and sentenced to ten years in prison. However, you " +
					"have no intention of serving your time. You want to escape as soon as possible. The first thing " +
					"you must do is find a way out of your locked prison cell.\n\n" +
					"Press 'W' to examine the window.\n" +
					"Press 'B' to examine the bed.\n" +
					"Press 'F' to examine the floor.\n" +
					"Press 'A' to examine the wall.\n" +
					"Press 'D' to examine the door.";
		if 		(Input.GetKeyDown(KeyCode.W)) 	{myState = States.window0;}
		else if (Input.GetKeyDown(KeyCode.B)) 	{myState = States.bed0;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor0;}
		else if (Input.GetKeyDown(KeyCode.A)) 	{myState = States.wall0;}
		else if (Input.GetKeyDown(KeyCode.D)) 	{myState = States.door0;}
	}
	
	void Window0() {
		text.text = "Your cell only has a single window and it is also your only source of light. It is too high for you " +
					"to see anything except the sky. There is a beam of light that comes through the window and lands on " +
					"the floor several feet from your bed.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell0;}
	}
	
	void Bed0() {
		text.text = "Your bed is incredibly filthy. The mere thought of sleeping on it sends a chill down your spine. " +
					"You simply must escape as soon as possible. You take a moment to examine the bed more closely, but " +
					"you do not find anything useful. YOu get down on your hands and knees to check underneath the bed, " +
					"but it is too dark for you to see anything.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell0;}
	}
	
	void Floor0() {
		text.text = "The floor of your cell is completely bare except for a single block of wood placed by the door. The " +
					"block is just large enough to serve as a seat or a footstool\n\n" +
					"Press 'G' to grab the block.\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.G)) 	{myState = States.cell1;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell0;}
	}
	
	void Wall0() {
		text.text = "The walls of your cell are covered in markings left behind by those imprisoned before you. On the wall " +
					"behind you is your cell door. On the wall in front of you is a window. To your left is your bed. However, " +
					"on the wall to your right you spot something curious. A small mirror hangs just out of reach, but you " +
					"have no way of grabbing it.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell0;}
	}
	
	void Door0() {
		text.text = "The door to your cell is made of sturdy wood and is reinforced with metal rods. It seems that the doors " +
					"are the only things this prison keeps in good condition. The lock is slightly rusty, but shows no signs " +
					"of breaking. YOu test the door to make sure it is locked. Unfortunately, it is. There is no way you can " +
					"force open the door. You will have to find some way to pick the lock.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell0;}
	}
	
	void Cell1() {
		text.text = "You are still locked in your cell and want to escape. However, you now are holding a large, square block " +
					"of wood. It is not overly heavy, but you do not feel like carrying it any longer than you have to.\n\n" +
					"Press 'W' to place the block under the window.\n" +
					"Press 'B' to place the block on the bed.\n" +
					"Press 'F' to place the block on the floor.\n" +
					"Press 'A' to place the block by the wall.\n" +
					"Press 'D' to throw the block at the door.";
		if 		(Input.GetKeyDown(KeyCode.W)) 	{myState = States.window1;}
		else if (Input.GetKeyDown(KeyCode.B)) 	{myState = States.bed1;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor1;}
		else if (Input.GetKeyDown(KeyCode.A)) 	{myState = States.wall1;}
		else if (Input.GetKeyDown(KeyCode.D)) 	{myState = States.door1;}
	}
	
	void Window1() {
		text.text = "You place the block under the window and use it as a footstool to see outside. Your head is just high " +
					"enough to get a nice, clear view of the outside. You see a large, dense forest to your south-west. That " +
					"might be a good place to run after you escape. To the south and south-east are fields and rolling hills. " +
					"You feel a rejuvinating breeze brush through your hair.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell1;}
	}
	
	void Bed1() {
		text.text = "You place the block on your bed. The bed sacks under the weight. It looks like the springs are old and " +
					"can barely handle this much weight. You hear a strange clicking noise as well, almost as though something " +
					"is loose underneath it.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell1;}
	}
	
	void Floor1() {
		text.text = "You place the block on the floor for a moment to rest your arms. It really isn't all that heavy, but it " +
					"is a bit awkward to hold. After a short rest you pick the block back up.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell1;}
	}
	
	void Wall1() {
		text.text = "Having placed the block by the wall just below a mirror you spot hanging above, you think you are able " +
					"to step up and just barely grab the it.\n\n" +
					"Press 'G' to grab the mirror.\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.G)) 	{myState = States.cell2;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell1;}
	}
	
	void Door1() {
		text.text = "You throw the block at the door as hard as you can. There is a resounding thud as it bounces off and " +
					"falls to the floor. Neither the door nor the block seem particularly phased by the collision.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell1;}
	}
	
	void Cell2() {
		text.text = "You now stand in your cell with a wooden block tucked under one arm and a mirror held in the other. You " +
					"can tell by looking at the light on the floor, which has shifted a bit closer to your bed, that time is " +
					"passing and within an hour or two it just might be too dark for you to see very well inside your cell. " +
					"You hope you can find a way to unlock the door before you run out of light completely.\n\n" +
					"Press 'W' to look out the window.\n" +
					"Press 'B' to place the mirror by the bed.\n" +
					"Press 'F' to place the block on the floor.\n" +
					"Press 'A' to examine the wall.\n" +
					"Press 'D' to examine the door.";
		if 		(Input.GetKeyDown(KeyCode.W)) 	{myState = States.window2;}
		else if (Input.GetKeyDown(KeyCode.B)) 	{myState = States.bed2;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor2;}
		else if (Input.GetKeyDown(KeyCode.A)) 	{myState = States.wall2;}
		else if (Input.GetKeyDown(KeyCode.D)) 	{myState = States.door2;}
	}
	
	void Window2() {
		text.text = "Using the block once again to step up to the window, you look outside. There doesn't appear to be any " +
					"major change other than it being slightly darker now and a guard now patrols not far below you. You " +
					"use the mirror to reflect some of the remaining light into the guards' eyes and then quickly duck down " +
					"out of sight.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell2;}
	}
	
	void Bed2() {
		text.text = "You place the mirror on the floor next to your bed where the beam of light from your window comes in. " +
					"You use the mirror to reflect the light under your bed. You see what looks like a loose pin or spring. " +
					"You try to reach for it, but you cannot hold up the mirro while also reaching for the spring.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell2;}
	}
	
	void Floor2() {
		text.text = "You place the block of wood on the floor next to the spot of light coming from the window.\n\n" +
				"Press 'M' to lean the mirror against the block.\n" +
				"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell2;}
		else if (Input.GetKeyDown(KeyCode.M)) 	{myState = States.cell3;}
	}
	
	void Wall2() {
		text.text = "You look back at the walls. There is nothing else for you to grab.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell2;}
	}
	
	void Door2() {
		text.text = "You can't think of anything to do with the door using the block and mirror. You'd beed a smaller object " +
					"if you wanted to pick the lock.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell2;}
	}
	
	void Cell3() {
		text.text = "You are still stuck in your cell, but you have managed to set up the block and mirror so that the little " +
					"light still coming through the window is being reflected towards your bed. You feel you are making progress " +
					"But it is definitely getting darker outside and you do not want to waste any more time.\n\n" +
					"Press 'W' to look out the window.\n" +
					"Press 'B' to look under the bed.\n" +
					"Press 'F' to pick up the block and mirror.\n" +
					"Press 'A' to examine the wall.\n" +
					"Press 'D' to examine the door.";
		if 		(Input.GetKeyDown(KeyCode.W)) 	{myState = States.window3;}
		else if (Input.GetKeyDown(KeyCode.B)) 	{myState = States.bed3;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor3;}
		else if (Input.GetKeyDown(KeyCode.A)) 	{myState = States.wall3;}
		else if (Input.GetKeyDown(KeyCode.D)) 	{myState = States.door3;}
	}
	
	void Window3() {
		text.text = "Without the block to stand on, you once again cannot see much of anything out of your window.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell3;}
	}
	
	void Bed3() {
		text.text = "Now that the light is reflected under your bed, you get down on your hands and knees and reach out " +
					"your hand. You see a loose pin protruding from the bottom of the mattress.\n\n" +
					"Press 'G' to grab the pin.\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell3;}
		else if	(Input.GetKeyDown(KeyCode.G)) 	{myState = States.cell4;}
		
	}
	
	void Floor3() {
		text.text = "You don't want to waste any time by ruining your progress.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell3;}
	}
	
	void Wall3() {
		text.text = "It is getting darker to see the carvings on the wall. And it does not look like there is anything else " +
					"for you to use.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell3;}
	}
	
	void Door3() {
		text.text = "You still do not have the means of opening the door.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell3;}
	}
	
	void Cell4() {
		text.text = "You have finally managed to acquire something small enough to actually help in your escape. The pin you " +
					"hold in your hand is quite fragile though. You will have to be careful not to break it. You don't know " +
					"how many times it can be used before it bends or snaps.\n\n" +
					"Press 'W' to ook out the window.\n" +
					"Press 'B' to look under the bed.\n" +
					"Press 'F' to pick up the block and mirror.\n" +
					"Press 'A' to examine the wall.\n" +
					"Press 'D' to pick the door.";
		if 		(Input.GetKeyDown(KeyCode.W)) 	{myState = States.window4;}
		else if (Input.GetKeyDown(KeyCode.B)) 	{myState = States.bed4;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor4;}
		else if (Input.GetKeyDown(KeyCode.A)) 	{myState = States.wall4;}
		else if (Input.GetKeyDown(KeyCode.D)) 	{myState = States.door4;}
	}
	
	void Window4() {
		text.text = "Without the block to stand on, you once again cannot see much of anything out of your window. However, " +
					"you can at least see that the sun has just about gone down now. It is now quite dark in your cell.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell4;}
	}
	
	void Bed4() {
		text.text = "Now that you have retrieved a loose pin from under your bed, you doubt there is much else worth doing " +
					"with it.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell4;}
	}
	
	void Floor4() {
		text.text = "The block and mirror have already played their part in your escape. Taking them with you now would " +
					"only slow you down, make you look more suspicious, and just increase your chances of being caught.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell4;}
	}
	
	void Wall4() {
		text.text = "Now that it has gotten even darker, you can't see much of anything on your wall.\n\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell4;}
	}
	
	void Door4() {
		text.text = "You use the pin you found to carefully begin picking the cell door. You try to be as careful as possible " +
					"so that you do not break the pin and waste your only chance of escape. After a few moments, you succeed " +
					"and the door opens.\n\n" +
					"Press 'L' to leave your cell.\n" +
					"Press 'R' to continue roaming your cell.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell4;}
		else if (Input.GetKeyDown(KeyCode.L))	{myState = States.corridor0;}
	}
	
	void Corridor0() {
		text.text = "Congratulations on escaping your cell. But that was only the first step. You still need to escape the prison, " +
					"as well as evade any of your pursuers.\n\n" +
					"Unfortunately, those portions of the game are incomplete. This first phase is all that currently exists, and " +
					"even that has plenty of room for future improvements. I hope you enjoyed this little game though.\n\n" +
					"Press 'Space' to start over.";
		if 		(Input.GetKeyDown(KeyCode.Space)){myState = States.cell0;}
	}
	
}