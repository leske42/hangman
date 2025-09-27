namespace Hangman.Tests;

public class HangmanGameTests
{
    [Fact]
    public void HangmanGame_CanBeCreated()
    {
        // Arrange & Act
        var game = new HangmanGame();
        
        // Assert
        Assert.NotNull(game);
    }
}
