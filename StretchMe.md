# WCCI - Guessing Game
## Stretch Tasks

> We are enhancing the We Can Code It Guessing Game. Use the following user stories to build out your features.

- As a User I should be given 3 guesses so that I can maximize my chances of winning the game
- As a User I should be able to keep track of my total wins and losses so that I can show my friends
- As a User I want to be able to add my name to a leader board
- As a User I want the game to be more challenging and reward points based on the amount of guesses it took

## FYI

- The ZingBot class has been provided solely as a learning tool.
- All the stretch tasks can be completed from the Program class and may require more variables or methods

## Code for Thought

> The [Divide and Conquer](https://www.geeksforgeeks.org/divide-and-conquer-algorithm-introduction/) algorithm provides an efficiency of O(n log n) and through some quick math magic we know that we can use log(n^2) which is the same as log(n) / log(2). Using this information can you calculate the maxiumum amount of tries a user should need given the range of 1 to 100? What about 1 to 1,000,000?

## Hints

- The ZingBot class provides a demonstration of the divide and conquer algorithm


## Sample Code

```chsarp
// Divide and Conquer Algorithm
// Suppose this list if filled with the numbers from 1 to 100
int winningNumber = 7;
bool won = false;
int min = 1;
int max = 100;

int guess = (max-min)/2;
if(guess == winningNumber)
{
won = true;
}
else if(guess > winningNumber)
{
max = guess;
}
else if(guess < winningNumber)
{
min = guess;
}

