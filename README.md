# 🧸 3D Desk Toy – Unity Project

A simple interactive Unity project that spawns a grid of rotating 3D cubes. Each cube can be clicked to change its color, and UI buttons allow resetting or randomizing colors across all toys at once.

This project is designed as a **learning-by-doing exercise** for Unity basics: prefabs, scripts, raycasting, materials, and UI.

---

## 🎮 Features

- Grid-based spawning of 3D cube toys
- Continuous rotation animation for each toy
- Mouse click interaction using raycasting
- Random color assignment on click
- UI buttons for scene reset and mass color randomization
- Modular scripts with clear responsibilities

---

## 🧠 How It Works

### 1. Grid Spawning (`GridSpawner`)
At runtime, the `GridSpawner` script runs once and instantiates multiple copies of the **Toy Prefab**.  
Nested loops calculate positions on the X and Z axes, arranging the toys neatly into a grid.

---

### 2. Click Interaction (`InputHandler`)
The `InputHandler` script is attached to the **Main Camera**.  
When the user clicks the mouse:
- A ray is cast from the camera through the mouse position
- If the ray hits a collider tagged **"Toy"**
- The toy’s material color is changed to a randomly generated color

---

### 3. Rotation Animation (`Rotator`)
Each Toy prefab includes a `Rotator` script.  
This script continuously rotates the cube every frame using `Transform.Rotate`, giving each toy a simple animated behavior.

---

### 4. UI Controls (`GameManager`)
Unity UI buttons are connected to public methods on the **GameManager**:
- **Reset Button** reloads the current scene
- **Randomize Button** finds all objects tagged `"Toy"` and applies random colors to them simultaneously

---

## 🧩 Project Structure

Assets/
├── Materials/
│ └── ToyMat.mat
├── Prefab/
│ └── Toy.prefab
├── Scenes/
│ └── MainScene.unity
├── Scripts/
│ ├── GameManager.cs
│ ├── GridSpawner.cs
│ ├── InputHandler.cs
│ └── Rotator.cs


---

## ⚙️ Requirements

- Unity **6.3 LTS**
- Universal Render Pipeline (URP)
- Input Handling set to **Both** (Old + New Input System)

---

## ▶️ How to Run

1. Open the project in Unity 6.3 LTS
2. Open `MainScene`
3. Ensure:
   - `GameManager` exists in the Hierarchy
   - Toy Prefab is assigned in the GameManager Inspector
4. Press **Play**

---

## 📚 Learning Outcomes

- Working with Prefabs and runtime instantiation
- Understanding raycasting and object interaction
- Using tags to identify objects
- Manipulating materials and colors at runtime
- Connecting UI Buttons to game logic
- Structuring Unity scripts cleanly

---

## 🚀 Possible Extensions

- Touch input support for mobile
- Adjustable grid size from UI
- Smooth color transitions
- Sound effects on interaction
- Object pooling for performance

---

## 👤 Author

Built as a hands-on Unity learning project.

