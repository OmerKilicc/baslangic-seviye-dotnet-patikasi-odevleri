namespace csharp101odevleri;

using System;

class Program
{
	static void Main(string[] args)
	{
		AnalyzeSentence();
	}

	// Solution to the first Problem
	public static void PrintEven()
	{
		Console.Write("How long do you want your array to be: ");
		int lengthOfArr = Convert.ToInt32(Console.ReadLine());
		int[] numbersToStore = new int[lengthOfArr];

		int arrCounter = TakeInputAndValidate(lengthOfArr, numbersToStore);

		Console.WriteLine("Here is the even numbers: ");
		for (int i = 0; i < arrCounter; i++)
		{
			if (numbersToStore[i] % 2 == 0)
				Console.Write($"{numbersToStore[i]} ");
		}
	}

	// Solution to the second problem
	public static void PerfectDivisors()
	{
		Console.WriteLine("How long do you want your array to be: ");
		int lengthOfArr = Convert.ToInt32(Console.ReadLine());
		int[] numbersToStore = new int[lengthOfArr];

		Console.WriteLine("What do you want for your divisor?: ");
		int divisor = Convert.ToInt32(Console.ReadLine());

		int arrCounter = TakeInputAndValidate(lengthOfArr, numbersToStore);

		Console.WriteLine("Here is the equal or perfect divisors: ");
		for (int i = 0; i < arrCounter; i++)
		{
			if (numbersToStore[i] % divisor == 0 || numbersToStore[i] == divisor)
				Console.Write($"{numbersToStore[i]} ");
		}

	}

	// Solution to the third problem
	public static void PrintWordsBackwards()
	{
		Console.WriteLine("How long do you want your array to be: ");
		int lengthOfArr = Convert.ToInt32(Console.ReadLine());
		string[] wordsToStore = new string[lengthOfArr];

		for (int i = 0; i < lengthOfArr; i++)
		{
			Console.WriteLine("Now write down your words in new line: ");

			string input = Console.ReadLine();
			if (!string.IsNullOrEmpty(input))
				wordsToStore[i] = input;

			else
			{
				Console.WriteLine("Input cant be null or empty!");
				continue;
			}
		}

		Console.WriteLine("Here is your words backwards: ");
		for (int i = lengthOfArr - 1; i >= 0; i--)
		{
			Console.Write($"{wordsToStore[i]} ");
		}
	}

	// Solution to the fourth problem
	public static void AnalyzeSentence()
	{
		Console.WriteLine("Could you please type a sentence to be analyzed: ");
		string sentenceToAnalyze = "";

		string input = Console.ReadLine();

		if (!string.IsNullOrEmpty(input))
			sentenceToAnalyze = input;
		else
		{
			Console.WriteLine("Input is null or empty! ");
			return;
		}	

		char[] charactersToStore = sentenceToAnalyze.Trim(' ').ToCharArray();
		Console.WriteLine("Here is all the characters in this sentence: ");

		foreach (char c in charactersToStore)
		{
			Console.WriteLine($"{c} ");
		}

		string[] wordsToStore = sentenceToAnalyze.Split(" ");
		Console.WriteLine("Here is all the words in this sentence: ");

		foreach(string word in wordsToStore)
		{
			Console.WriteLine($"{word} ");
		}

	}

	public static int TakeInputAndValidate(int lengthOfArr, int[] numbersToStore)
	{
		int arrCounter = 0;

		for (int i = 0; i < lengthOfArr; i++)
		{
			Console.WriteLine("Now write down your numbers in new line: ");
			int numberToAdd = Convert.ToInt32(Console.ReadLine());
			bool shouldWeAddToArray = !IsIntAlreadyInArray(numberToAdd, numbersToStore);

			if (shouldWeAddToArray)
			{
				numbersToStore[arrCounter] = numberToAdd;
				arrCounter++;
			}
		}

		return arrCounter;
	}

	public static bool IsIntAlreadyInArray(int numberToCheck, int[] arrayToLook)
	{
		foreach (int number in arrayToLook)
		{
			if (numberToCheck == number)
				return true;
		}

		return false;
	}

}
