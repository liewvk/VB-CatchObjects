# CatchObjects

A simple Windows Forms arcade game built in Visual Basic .NET as part of the "VB Game Programming" chapter project.

The player controls a paddle at the bottom of the screen, catches falling objects, scores points, and tries to survive as the game speeds up.

## Features

- Arrow key movement for the player
- Falling object spawning and collision detection
- Score tracking and lives system
- Increasing difficulty over time
- Game over and restart flow

## How to Play

- Use the Left and Right arrow keys to move the player.
- Catch falling objects to earn points.
- If an object reaches the bottom of the play area, you lose a life.
- The game ends when all lives are lost.

## Requirements

- Visual Studio 2022 or later
- Windows desktop development workload
- .NET 10 SDK / Windows targeting pack

## Run the Project

1. Open `CatchObjects.slnx` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Build the solution.
4. Press F5 to run the game.

You can also build from the command line:

```bash
dotnet build CatchObjects.slnx
```

## Project Files

- `CatchObjects.vbproj` - project configuration
- `Form1.vb` - main game logic and UI event handling
- `Form1.Designer.vb` - generated Windows Forms designer code
- `ApplicationEvents.vb` - application-level event handlers
- `My Project/` - Visual Basic project metadata

## License

This project is provided as a learning example and is intended for educational use.
