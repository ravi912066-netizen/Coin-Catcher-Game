# 🪙 Coin Catcher Game – Workshop 2

A 2D arcade-style Coin Catcher Game developed using **Unity 6 and C#** as part of Workshop 2.

The objective is to catch falling coins, avoid bombs, and achieve the highest possible score while managing limited lives.

## 🎮 Game Overview

The player controls a catcher at the bottom of the screen and moves it horizontally to collect falling coins and avoid dangerous bombs.

## ✨ Features

- **Player Movement:** Move the catcher left and right.
- **Coin Spawning:** Coins spawn automatically at random positions.
- **Bomb Spawning:** Bombs appear randomly alongside coins.
- **Score System:** Earn points by catching coins.
- **Lives System:** Lose a life when hitting a bomb.
- **Game Over:** The game ends when all lives are lost.
- **Object Destruction:** Coins and bombs are destroyed after leaving the screen.

## 🛠️ Technologies Used

- Unity 6
- C#
- Visual Studio Code
- Unity 2D Physics
- Git & GitHub

## 📁 Project Structure

```text
Coin-Catcher-Game/
│
├── Assets/
│   ├── Prefabs/
│   ├── Scenes/
│   └── script/
│       ├── Catcher.cs
│       ├── Coin.cs
│       ├── Bomb.cs
│       ├── ItemSpawner.cs
│       └── GameManager.cs
│
├── Packages/
├── ProjectSettings/
├── .gitignore
└── README.md
```

## 🚀 Getting Started

### Prerequisites

- Unity 6
- Visual Studio Code
- Git

### Installation

1. Clone the repository:

```bash
git clone https://github.com/ravi912066-netizen/Coin-Catcher-Game.git
```

2. Open Unity Hub.
3. Select **Add Project from Disk**.
4. Select the cloned project folder.
5. Open the project using Unity 6.
6. Open the main game scene.
7. Press the Play button.

## 🕹️ Controls

| Key | Action |
|---|---|
| A / Left Arrow | Move Left |
| D / Right Arrow | Move Right |

## 🎯 Game Rules

| Action | Result |
|---|---|
| Catch a coin | +1 Score |
| Hit a bomb | -1 Life |
| Lives reach zero | Game Over |

Initial Lives: 3

## 📸 Screenshots

Screenshots of the gameplay will be added here.

## 🧠 Learning Outcomes

Through this workshop, I am learning:

- Unity GameObject and Component System
- C# scripting in Unity
- Transform-based player movement
- Random object spawning
- Collision detection using 2D physics
- Score and life management
- Game state management
- Git and GitHub project management

## 🔮 Future Improvements

- Add sound effects and background music.
- Add a restart button.
- Add increasing difficulty levels.
- Add a high-score system.
- Improve game visuals and animations.

## 👨‍💻 Author

**Ravi Yadav**

B.Tech Computer Science Engineering

GitHub: [@ravi912066-netizen](https://github.com/ravi912066-netizen)

---

⭐ If you like this project, consider giving it a star!
