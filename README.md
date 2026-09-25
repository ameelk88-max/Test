# 🚀 My First Game here

This is my first game project. It was a relatively fast project that I mainly created to learn and practice using "Git and GitHub".

Even though it was a small project, I implemented several interesting systems. Some of the more important systems are not directly visible to the player, so feel free to take a look at the code if you are interested!

## 🎮 About the Game

You control a **spaceship** and try to destroy as many enemies as possible to increase your score.

While playing, you can gain different upgrades to make your spaceship stronger. However, the enemies also become stronger over time and start spawning faster.

The goal is simple:

**Destroy as many enemies as possible and achieve the highest score you can.**

---

## ⚙️ Systems in the Game

### 🔧 Upgrade Choice System

After destroying a certain number of enemies, **3 upgrade options** appear on the screen.

The game randomly selects the options from a larger list of available upgrades. You can choose one upgrade, which improves one of your spaceship's stats, and then continue playing.

The system is designed to be easy to expand. To add a new upgrade, you mainly need to create the upgrade and add it to the **upgrade list**.

### 👾 Enemy Upgrade System

Enemies receive unique upgrades as the game progresses.

The system is designed to make it easy to **add, remove, or adjust enemy upgrades** without having to rewrite large parts of the system.

### 🎯 Smart Enemy Spawn System

The enemy spawn system allows you to easily control the **spawn chances of different enemy types**.

The chances can be adjusted using a `switch` inside the script, making it easy to change how frequently each enemy type appears.

Enemies spawn at random spawn locations, and their spawn rate increases as time passes.

### 🌀 Screen Wrap

If the spaceship leaves the screen on one side, it automatically appears on the opposite side.

For example:

**Left side → Right side**
**Right side → Left side**

### 🎮 GameManager

The `GameManager` keeps track of important game information, including:

* Number of enemies destroyed
* Player lives
* Score
* Other important game values

### 🛸 Simple Movement

The spaceship has simple horizontal movement, allowing the player to move left and right.
