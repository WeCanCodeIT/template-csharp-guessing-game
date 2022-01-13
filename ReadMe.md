# WCCI - Guessing Game
## Primary Objectives

> We are building an interactive guessing game. Use the following User stories to determine your functionality.

- As a User I should be able to guess a number so that I can see if I won the game
- As a User I should get three chances to guess the right number so that I can see if I won the game 
- As a User I should be able to exit the game so that I can get the satisfaction of rage quitting

## Features

- The Program class has a note of where you should add your static method call
- The ZingBot class does not need to be modified it is for the StretchMe tasks

## Iterations
> These are the step by step tasks needed to create a fully functional guessing game

### Iteration 1

- Create a static constant variable for the winning number and set it equal to 7
- Print the provided instructions
- Create a prompt and read in the user input and store it as the guess
- Check if the guess was equal to the winning number
- Announce if the user won or lost the game

### Iteration 2

- If the user guesses 0, repeat the instructions and re-prompt them for a guess
- If the user guesses -1 the program should quit returning to the main menu
- If the user is wrong, allow them one more try
- Announce the final outcome of their guess

### Iteration 3

- After the user guesses, help them out by announcing if they are higher or lower than the winning number
- For every run of the guessing method change the winning number to be a random value between 1 and 10
- Make the game more challenging by changing the range from 1-100 (this is just an instruction change)

## Hints

- Start by creating a static method for your Guessing Game protocol
- Do the tasks by iteration and you will only have to make incremental changes to advance the game

## Sample Code

```chsarp
// The rand.Next() method will return a value a random value 
// between the min and max, exclusive so the code below will 
// return a number between 1 and 100.
Random rand = new Random();
// Usage: rand.Next(min, max)
int winningNumber = rand.Next(1, 101);