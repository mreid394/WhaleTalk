using System; // Importing the System namespace to use Console and other basic functionality.
using System.Collections.Generic; // Importing the Collections namespace to use List<T>.

class Program // Defining the main program class.
{
	static void Main() // Entry point of the program.
	{
		string input = "Hello, I am a Whale!"; // Define the input string that the program will process.

		char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; // Define an array of vowels to check against the characters in the input string.

		List<char> resultArray = new List<char>(); // Initialize a dynamic list to store vowels that are extracted from the input string.

		for (int i = 0; i < input.Length; i++) // Start a loop to iterate over each character in the input string. The `i` is the index representing the position of the current character.
		{
			if (input[i] == 'e') // Check if the current character is specifically 'e'.
			{
				resultArray.Add(input[i]); // If it is 'e', add it to the resultArray list.
			}

			if (input[i] == 'u') // Check if the current character is specifically 'u'.
			{
				resultArray.Add(input[i]); // If it is 'u', add it to the resultArray list.
			}

			for (int x = 0; x < vowels.Length; x++) // Start another loop to check if the current character matches any vowel. The `x` is the index for iterating through the vowels array.
			{
				if (input[i] == vowels[x]) // Compare the current input character with the current vowel.
				{
					resultArray.Add(input[i]); // If there is a match, add the current character to the resultArray list.
				}
			}
		}

		string resultString = string.Join("", resultArray); // Join all characters in the resultArray list into a single string and use an empty string "" as a separator to concatenate characters without spaces.
		resultString = resultString.ToUpper(); // Convert the resulting string to uppercase letters.
		Console.WriteLine(resultString); // Print the final uppercase string to the console.
	}
}