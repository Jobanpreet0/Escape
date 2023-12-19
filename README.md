# **Escape (2D co-op game)**

## **Description**

This project involved creating a cooperative puzzle-solving game experience for two players, fostering communication and teamwork as essential elements for success. The core idea was to create an engaging and enjoyable gameplay dynamic that goes beyond individual play. Meanwhile, the chosen game style is 2D, featuring characters with animated movements within this two-dimensional environment. The emphasis on a 2D setting enhances accessibility and allows for the implementation of intricate puzzle scenarios and varying levels of difficulty. This combination of a cooperative concept and a 2D game style aims to deliver an immersive and entertaining gaming experience for players engaging with the project.

## **How To Play**

**Player 1 Movement**

Move up: W

Move down: S

Move left: A

Move right: D

**Player 2 Movement**

Move left: ←

Move up: ↑

Move right: →

Move down: ↓

**Obstacles**

Player 1: Watch out for three fast-moving balls in your room. Colliding with a ball results in restarting the level.

Player 2: Beware of a deadly fence and two moving blades in your room. Touching any of these obstacles leads to restarting the level.

**Goal**

Avoid obstacles, collect the key in the room, and use it to open the door across the room.

## **Code files and their purpose:**

- **PlayerMovement.cs:** Manages the movement of the first player, utilizing WASD keys to control speed and setting boundaries.
- **Player2Movement.cs:** Controls the movement of the second player, using arrow keys to determine speed and implementing boundary constraints.
- **Obstacle\_1.cs, Obstacle\_2.cs, Obstacle\_3.cs:** Directs the movement of three obstacle balls traversing the screen for player 1.
- **Destruction.cs:** Governs the mechanics of player elimination upon collision with an obstacle.
- **KeyHolder.cs:** Handles the storage of keys collected upon collision.
- **Blades.cs:** Regulates the movement of two blades that traverse the screen for player 2.
- **KeyDoor.cs:** Opens the door if the user holds the key.

## **Contact Information**

For any issues or concerns with the software, feel free to reach out to Jobanpreet at Joban.01.singh@live.com.
