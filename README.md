# GameSensor
# Investigation Game

> A tactical simulation system to expose Iranian agents by attaching the correct sensors – a trial-and-error intelligence game.

---

## Game Description

In this game, you play the role of an intelligence investigator. Your goal is to expose Iranian agents by attaching the right combination of sensors. Each agent has a secret sensor mix required to reveal them.

### Agent Ranks
Agents come in various ranks, which determine how many correct sensors are needed

### Sensor Types
There are multiple sensor types:
- **Thermal**, **Motion**, **Cellular**, etc.

---

## How Investigation Works

- Each turn, the player attaches a sensor to the agent.
- The agent has a **secret combination** of sensor types required for exposure.
- The player **doesn't know** this combination and must figure it out via trial and error.
- After each turn, feedback is returned: how many of the attached sensors are correct.
- Once all the correct sensors are attached – the agent is exposed.

#### Example:

A **Junior Agent** requires 2 **Thermal** sensors.

- Turn 1: attach Thermal -> result: `1/2`
- Turn 2: attach another Thermal -> result: `2/2` → Agent exposed.

---

## Project Structure

### `Agent` Class

Represents an Iranian agent.

- `string Rank` – agent's rank
- `Dictionary<string, int> Weaknesses` – secret sensor types required for exposure
- `Dictionary<string, int> AttachedSensors` – sensors currently attached to the agent

#### Method: `Investigation()`
- Compares the attached sensors with the agent’s required weaknesses.
- For matching sensor types, takes the **minimum** between the required and attached amounts.
- Returns the total number of correct sensor attachments so far.

---

### `Sensor` Class

Represents a sensor.

- `string Type` – the sensor type (e.g., "Thermal", "Motion")

#### Method: `Activate(Dictionary<string, int> target)`
- If the sensor type exists in the dictionary: increment its count by 1.
- Otherwise: add it with a starting value of 1.

---

### `Manager` Class

Coordinates gameplay and user interaction.

- Asks the user which sensor type to attach.
- Creates an instance of the requested `Sensor`.
- Calls `Activate` on the agent’s attached sensors dictionary.
- Calls `Investigation()` to evaluate how many correct sensors are attached.
- Displays the result to the player.

---

## Technologies

- Language: **C#**
- Platform: **Console Application**
- IDE: **Visual Studio**

---

## Main Files

| File          | Description                             |
|---------------|-----------------------------------------|
| `Agent.cs`    | Defines the agent and investigation logic |
| `Sensor.cs`   | Defines sensor behavior and activation    |
| `Manager.cs`  | Handles input/output and game flow        |
| `Program.cs`  | Entry point for the application           |

---

## How to Play

1. Choose or randomly generate an agent and its sensor mix.
2. Run the game.
3. On each turn, input the sensor type to attach.
4. You'll receive feedback: how many are correct so far.
5. Once all required sensors are correctly attached -> agent is revealed!

---

Expose the threat and protect the homeland!
Good luck, commander!
