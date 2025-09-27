namespace Hangman;

public class HangmanGame
{
    private readonly string[] _words = [
        "PROGRAMMING",
        "COMPUTER",
        "KEYBOARD",
        "MONITOR",
        "DEVELOPER",
        "SOFTWARE",
        "ALGORITHM",
        "DATABASE",
        "NETWORK",
        "INTERNET"
    ];

    private readonly Random _random = new();
    private string _wordToGuess = string.Empty;
    private char[] _guessedWord = [];
    private HashSet<char> _guessedLetters = [];
    private int _wrongGuesses = 0;
    private const int MaxWrongGuesses = 6;

    public async Task PlayAsync()
    {
        InitializeGame();

        while (!IsGameOver())
        {
            DisplayGameState();
            await ProcessPlayerGuessAsync();
        }

        DisplayGameResult();
    }

    private void InitializeGame()
    {
        _wordToGuess = _words[_random.Next(_words.Length)];
        _guessedWord = new char[_wordToGuess.Length];
        for (int i = 0; i < _guessedWord.Length; i++)
        {
            _guessedWord[i] = '_';
        }
        _guessedLetters = [];
        _wrongGuesses = 0;
    }

    private void DisplayGameState()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("====================");
        Console.WriteLine();
        
        DisplayHangman();
        Console.WriteLine();
        
        Console.WriteLine($"Word: {string.Join(" ", _guessedWord)}");
        Console.WriteLine($"Wrong guesses: {_wrongGuesses}/{MaxWrongGuesses}");
        
        if (_guessedLetters.Count > 0)
        {
            Console.WriteLine($"Guessed letters: {string.Join(", ", _guessedLetters.OrderBy(c => c))}");
        }
        
        Console.WriteLine();
    }

    private void DisplayHangman()
    {
        string[] hangmanParts = [
            "  +---+",
            "  |   |",
            _wrongGuesses > 0 ? "  O   |" : "      |",
            _wrongGuesses > 2 ? $" {(_wrongGuesses > 1 ? "/" : " ")}{(_wrongGuesses > 3 ? "|" : " ")}{(_wrongGuesses > 4 ? "\\" : " ")}  |" : "      |",
            _wrongGuesses > 5 ? " /    |" : "      |",
            "      |",
            "========="
        ];

        foreach (string part in hangmanParts)
        {
            Console.WriteLine(part);
        }
    }

    private async Task ProcessPlayerGuessAsync()
    {
        Console.Write("Enter a letter: ");
        string? input = await Task.Run(Console.ReadLine);
        
        if (string.IsNullOrWhiteSpace(input) || input.Length != 1 || !char.IsLetter(input[0]))
        {
            Console.WriteLine("Please enter a valid single letter.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }

        char guess = char.ToUpper(input[0]);

        if (_guessedLetters.Contains(guess))
        {
            Console.WriteLine("You already guessed that letter!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }

        _guessedLetters.Add(guess);

        if (_wordToGuess.Contains(guess))
        {
            for (int i = 0; i < _wordToGuess.Length; i++)
            {
                if (_wordToGuess[i] == guess)
                {
                    _guessedWord[i] = guess;
                }
            }
            Console.WriteLine("Good guess!");
        }
        else
        {
            _wrongGuesses++;
            Console.WriteLine("Wrong guess!");
        }

        if (!IsGameOver())
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    private bool IsGameOver()
    {
        return HasWon() || HasLost();
    }

    private bool HasWon()
    {
        return !_guessedWord.Contains('_');
    }

    private bool HasLost()
    {
        return _wrongGuesses >= MaxWrongGuesses;
    }

    private void DisplayGameResult()
    {
        DisplayGameState();
        
        if (HasWon())
        {
            Console.WriteLine("🎉 Congratulations! You won!");
        }
        else
        {
            Console.WriteLine($"💀 Game Over! The word was: {_wordToGuess}");
        }
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}