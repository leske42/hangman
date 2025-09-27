using Hangman;

Console.WriteLine("Welcome to Hangman!");
Console.WriteLine("====================");

var game = new HangmanGame();
await game.PlayAsync();
