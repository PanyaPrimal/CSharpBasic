internal class Program
{
    private static void Main(string[] args)
    {
        string secretWord = "banana";
        int maxAttempts = 6;
        int wrongAttempts = 0;
        HashSet<char> guessedLetters = new HashSet<char>();
        
        Console.WriteLine("Welcome! Try to guess the secret word!");
        Console.WriteLine($"Number of letters in the word: {secretWord.Length}");
        Console.WriteLine($"Number of possible wrong attempts: {maxAttempts}");
        Console.WriteLine();
        
        while (wrongAttempts < maxAttempts)
        {
            Console.Write("Enter your letter: ");
            string? input = Console.ReadLine();
            
            if (string.IsNullOrEmpty(input) || input.Length != 1)
            {
                Console.WriteLine("Please enter only one letter!");
                Console.WriteLine();
                continue;
            }
            
            char letter = char.ToLower(input[0]);
            
            if (guessedLetters.Contains(letter))
            {
                Console.WriteLine("You already entered this letter! Try another one.");
                Console.WriteLine();
                continue;
            }
            
            guessedLetters.Add(letter);
            
            if (secretWord.Contains(letter))
            {
                List<int> positions = new List<int>();
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == letter)
                    {
                        positions.Add(i + 1);
                    }
                }
                
                Console.WriteLine($"This letter is in the word! Letter position: {string.Join(",", positions)}");
                
                bool allGuessed = true;
                foreach (char c in secretWord)
                {
                    if (!guessedLetters.Contains(c))
                    {
                        allGuessed = false;
                        break;
                    }
                }
                
                if (allGuessed)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Congratulations, you guessed the word! Secret word: {secretWord}.");
                    Console.WriteLine("Thank you for playing.");
                    return;
                }
            }
            else
            {
                wrongAttempts++;
                Console.WriteLine($"This letter is not in the word! Attempts left: {maxAttempts - wrongAttempts}");
            }
            
            Console.WriteLine();
        }
        
        Console.WriteLine($"You lost! The secret word was: {secretWord}.");
        Console.WriteLine("Thank you for playing.");
    }
}
