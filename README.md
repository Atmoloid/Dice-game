# Dice Game 🎲

A simple dice game made with C#.

## How It Works

This game is a command-line-based dice game where a player competes against an enemy (computer) in 10 rounds of dice rolls. The player and the enemy roll a dice, and the winner of each round is determined based on the higher roll. Points are awarded to the winner of each round, and the player with the most points after 10 rounds wins the game.

---

## Code Breakdown

### Namespace and Class Declaration
- **`namespace dice_game`**: Encapsulates the code within the `dice_game` namespace.
- **`class Program`**: The main class where the execution begins.

---

### Entry Point
- **`static void Main(string[] args)`**: The entry point of the program.

---

### Variable Initialization
- **`int playerRandomNum; int enemyrandomNum;`**: Stores dice roll values for the player and the enemy.
- **`int playerPoints = 0; int enemyPoints = 0;`**: Tracks cumulative points for the player and the enemy.
- **`Random random = new Random();`**: Generates random dice rolls.

---

### Game Loop
The game consists of 10 rounds inside a `for` loop:
1. The player presses a key to roll their dice.
2. A random number between 1 and 6 is generated for both the player and the enemy.
3. The winner of the round is determined:
   - The player wins if their dice roll is higher.
   - The enemy wins if their dice roll is higher.
   - The round is a draw if both rolls are equal.
4. Scores are updated and displayed after each round.

---

### Final Outcome
After 10 rounds:
- If the player's points are higher, the player wins the game.
- If the enemy's points are higher, the enemy wins the game.
- If both have the same points, the game is a draw.

---

### Features
- **Random Number Generation**: Simulates dice rolls using the `Random` class.
- **Suspense Simulation**: Adds a 1-second delay between the rolls using `Thread.Sleep(1000)`.
- **Console Interaction**: Engages the player with `Console.WriteLine` and `Console.ReadKey`.

---

### Sample Game Execution

1. The player is prompted to roll the dice:
   ```
   Press any key to roll the dice
   ```
2. The player's roll and the enemy's roll are displayed:
   ```
   You rolled a 4
   ...
   Enemy rolled a 6
   Enemy wins this round
   Player score: 0 Enemy score: 1.
   ```
3. After 10 rounds, the final result is displayed:
   ```
   Player score: 6 Enemy score: 4.
   Player wins the game
   ```

---

## How to Run the Game

1. Clone the repository:
   ```bash
   git clone https://github.com/Atmoloid/Dice-game.git
   ```
2. Open the project in an IDE that supports C# (e.g., Visual Studio or Visual Studio Code).
3. Build and run the project to start the game.
