# 🧩 Maze Game (Console-based)

Welcome to **Maze Game** – a simple console-based maze navigation game written in **C#**.

The goal is to navigate your player `@` through a maze of walls `#` to reach the exit `E`.  
Once you reach the exit, you will be congratulated and reset to the start point to play again!

---

## 🎮 How to Play

- Use the **arrow keys** (`↑ ↓ ← →`) to move the player.
- Avoid walls `#`, and try to reach the exit marked with `E`.
- When you reach the exit, a congratulatory message appears and the player resets to the start.

---

## 🧱 Maze Logic

- The maze is auto-generated with alternating wall columns:
  - Even-numbered wall columns have an opening at the bottom.
  - Odd-numbered wall columns have an opening at the top.
  - There are free columns between wall columns to allow movement.
- The player starts at position `(1,1)`.
- The exit is always located near the bottom-right of the maze (`Width - 2`, `Height - 2`).

---

## 🗂️ Project Structure

MazeGame/
├── Maze.cs # Maze generation, rendering, and movement logic
├── Player.cs # Player properties and icon
├── Wall.cs # Wall object (solid)
├── EmptySpace.cs # Empty space object (non-solid)
├── Exit.cs # Exit point object (non-solid, triggers win)
├── IMazeObject.cs # Interface for all maze objects
└── Program.cs # Entry point with game loop


---

## 🚀 How to Run

1. Open the project in **Visual Studio** or any C# IDE.
2. Build and run the project.
3. Play using the arrow keys in the console window.

> ⚠️ Make sure your console window is large enough (e.g., 40x20) to fit the maze.

---


---

## 📌 Notes

- The game uses `Console.Clear()` and redraws the maze each move.
- You can enhance it later with:
  - Timer or countdown.
  - Random maze generation.
  - Levels or scoring system.
  - Sound effects via `System.Media`.

---

## 🛠️ Technologies Used

- Language: **C#**
- Framework: **.NET Console App**

---

## 🧑‍💻 Author

Developed with 💙 by Ahmed Ali. 
Feel free to fork, improve, or suggest features!
