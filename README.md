# 🚀 Hand Tracking Space Shooter

A Unity game where your **hand becomes the controller**! Fly a spaceship and dodge or shoot incoming enemies using **real-time hand tracking** powered by Python, MediaPipe, OpenCV, and CVZone.

---

## 🧠 Overview

This is a **space shooting game** built in Unity using **C#**, where:
- The player’s spaceship is **controlled by their hand movement** (no keyboard or mouse needed).
- **Real-time hand tracking** is handled via a Python script using **MediaPipe** and **OpenCV**, detecting **21 hand landmarks**.
- Unity receives the hand position and maps it to the player’s spaceship.
- The game ends when an **enemy collides with the player ship**.

---

## 🛠️ Tech Stack

- **Unity (C#)** – Game logic, physics, and rendering.
- **Python** – Hand tracking:
  - `MediaPipe` – Landmark detection (21 key hand points).
  - `OpenCV` – Webcam input and frame processing.
  - `CVZone` – Simplifies communication and hand-tracking utilities.

---

## 🎮 Gameplay

- Move your **hand** in front of the webcam to control the spaceship.
- Enemies appear from the top and move toward the player.
- **Avoid enemy ships** to survive.
- **One collision = Game Over.**

---

## 📂 Project Structure

HandTrackingSpaceShooter/
├── Assets/ # Main Unity game
│ ├── KennySpace/
│ └── Scripts/ # C# and python scripts for player, enemy, game logic
├── TextMeshPro/
├── UDPRecieve.cs
└── README.md


---

## 🔧 Setup Instructions

### 1. Python Environment (Hand Tracking)

Install dependencies:
```bash
pip install mediapipe opencv-python cvzone
```

Run the hand tracking script:

```bash
python hand_tracking.py
```


This will open your webcam and start tracking your hand. The Python script sends coordinates to Unity.

2. Unity Setup
Open the UnityProject folder in Unity Editor.

Attach the HandTrackingReceiver.cs (or similar) script to the player spaceship.

Ensure the Unity script is set up to receive hand coordinates (via socket or serial).

Hit Play to start the game.

🔌 Communication Between Python and Unity
Unity and Python communicate using:

UDP or TCP sockets, or

Serial Port (if using Arduino/virtual COM)

Make sure the communication parameters (e.g., port/IP) are consistent on both ends.

🚧 Known Limitations
Requires good lighting for stable hand detection.

Tracks only one hand at a time.

No shooting functionality yet (just movement and collision detection).

Desktop-only due to Python dependency (not compatible with WebGL/mobile).

💡 Future Improvements
Add gesture-based shooting (e.g., fist to fire).

Implement difficulty scaling (speed, enemy count).

Add sound effects and explosion animations.

Use two-hand tracking for special abilities.

👨‍💻 Author
Made with 💻 using Unity and Python
By Anusha Ratra
