# Game Rules

1. The computer chooses a hidden word and shows the user its definition.  
   - The word can come from a predefined dictionary of word-definition pairs.  
   - You can use any theme you like.  

2. The computer shows underscores for each letter in the word.

3. The player is prompted to guess a letter or the whole word. Initially, the player has 5 lives.

4. If the player guesses the whole word:  
- If correct → print “You won!” and end the game.  
- If wrong → print “You lost!” and end the game.  

5. If the player guesses a letter:  
- If the letter is in the hidden word, reveal it in place and give one life back.  
- If not, the player loses one life.  

6. The game ends when either:  
- All letters are revealed (win).  
- The player runs out of lives (lose).  

7. At the end, print out the definition of the hidden word.
