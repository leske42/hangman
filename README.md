# Hangman Game

A console-based Hangman game implemented in C# using .NET 9.0.

## Description

This is a classic word-guessing game where players try to guess a hidden word by suggesting letters. The player has a limited number of incorrect guesses before the game ends.

## Features

- Interactive console gameplay
- Visual hangman display
- Random word selection from a predefined list
- Progress tracking of guessed letters
- Win/lose conditions with appropriate feedback

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later

## How to Build

```bash
# Clone the repository
git clone https://github.com/leske42/hangman.git
cd hangman

# Restore dependencies and build
dotnet build

# Or build in release mode
dotnet build --configuration Release
```

## How to Run

```bash
# Run the game
dotnet run --project Hangman

# Or run from the Hangman directory
cd Hangman
dotnet run
```

## How to Test

```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --verbosity normal
```

## Project Structure

```
hangman/
├── .editorconfig           # Code style configuration
├── .gitignore             # Git ignore rules for C# projects
├── Directory.Build.props   # MSBuild properties for all projects
├── Hangman.sln            # Solution file
├── Hangman/               # Main console application
│   ├── Hangman.csproj     # Project file
│   ├── Program.cs         # Application entry point
│   └── HangmanGame.cs     # Game logic implementation
└── Hangman.Tests/         # Unit test project
    ├── Hangman.Tests.csproj
    └── UnitTest1.cs       # Basic tests
```

## Development

This project includes:

- **EditorConfig**: Consistent code formatting across different editors
- **Directory.Build.props**: Solution-wide MSBuild settings
- **Comprehensive .gitignore**: Excludes build artifacts and IDE files
- **Code Analysis**: Enabled with warnings treated as errors
- **Nullable Reference Types**: Enabled for better null safety
- **Unit Testing**: xUnit framework for testing

## Code Style

The project uses standard C# coding conventions enforced through EditorConfig and MSBuild analyzers. Key points:

- 4 spaces for indentation
- `this.` qualification discouraged
- Braces required for all control structures
- Nullable reference types enabled
- Warnings treated as errors

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes following the existing code style
4. Add tests for new functionality
5. Ensure all tests pass: `dotnet test`
6. Submit a pull request

## License

This project is open source and available under the [MIT License](LICENSE).