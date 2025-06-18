# SensorGame – Agent Investigation Simulation

A tactical investigation game where your goal is to reveal enemy agents by attaching the correct combination of sensors based on their hidden weaknesses.

---

## Project Structure

- `Agent`: Represents an enemy agent with sensor weaknesses.
- `Sensor`: Abstract base class for all sensor types.
- `SensorFactory`: Responsible for creating specific sensor instances.
- `Manager`: Controls the game loop and manages sensor attachment.
- `Program`: Starts the game via `Main`.

---

## How to Play

1. The game starts with an agent that has 3 randomly assigned sensor weaknesses (some types may repeat).
2. You must attach sensors to the agent by entering sensor types via the console.
3. You will receive feedback on how many matches you've found.
4. The game ends when all weaknesses are fully matched by attached sensors.

---

## Classes Overview

### Agent

- **Fields**:
  - `Rank`: Type of agent.
  - `Weaknesses`: `Dictionary<string, int>` – sensors needed to reveal the agent.
  - `AttachedSensors`: `Dictionary<string, int>` – sensors attached by the player.

- **Methods**:
  - `Investigation()`: Compares `AttachedSensors` and `Weaknesses` to count the number of matches.
  - `RemoveSensor(string type)`: Removes one sensor of a specific type from `AttachedSensors`.
  - `IsRevealed()`: Returns `true` if all weaknesses are fully matched.
  - `RandomSensor()`: Returns a random sensor type string.

---

### Sensor (Base Class)

- **Field**:
  - `Type`: The sensor's type (e.g., "Audio", "Thermal").

- **Method**:
  - `Activate(Dictionary<string, int> attachedSensors)`: Adds or updates the sensor in the agent's `AttachedSensors`.

---

### Sensor Subclasses

- `SensorAudio`
- `SensorLight`
- `SensorMagnetic`
- `SensorMotion`
- `SensorPulse`
- `SensorSignal`
- `SensorThermal`

> These classes inherit from `Sensor` and initialize with their corresponding type name.

---

### SensorFactory

- **Static Method**:
  - `CreateSensor(string type)`: Returns a new sensor object based on the input string. Returns `null` for invalid types.

---

### Manager

- **Fields**:
  - `Agent`: The current agent in the game.
  - `AgentType`: The rank/type of the agent.

- **Method**:
  - `StartGame()`: Main game loop. Reads user input, creates sensors, updates attached sensors, and checks if the agent is revealed.

---

### Program

- **Method**:
  - `Main()`: Initializes a `Manager` and starts the game using `StartGame()`.

---

## Example Sensor Types

- Light  
- Motion  
- Thermal  
- Audio  
- Signal  
- Magnetic  
- Pulse

---

## Notes

- The game uses console input/output for interaction.
- Case-insensitive sensor input is supported.
- The system ensures invalid sensors are rejected with user feedback.

---

Enjoy investigating! 