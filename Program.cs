using System;

namespace Program
{
	class Sieve
	{
		static void Main(string[] args)
		{
			int nbr, multiple, multiplier = 2;
			Console.WriteLine("\n********* Sieve of Eratosthenes *********");
			Console.Write("Enter a Number to find Prime Numbers Below it: ");
			while (!int.TryParse(Console.ReadLine(), out nbr) || nbr < 2) ;

			bool[] isPrime = new bool[nbr];

			// Adding True values to the array since default values are False
			for (int i = 2; i < isPrime.Length; i++)
				isPrime[i] = true;

			// Making an Iteration to Get Prime numbers
			while (multiplier * multiplier <= nbr)
			{
				if (isPrime[multiplier])
				{
					multiple = multiplier * multiplier;
					while (multiple < nbr)
					{
						isPrime[multiple] = false;
						multiple += multiplier;
					}
				}
				multiplier++;
			}

			// Writing Prime Numbers Found below nbr...
			Console.Write($"Prime Numbers Below {nbr} are: ");
			for (int i = 0; i < isPrime.Length; i++)
			{
				if (isPrime[i])
					Console.Write(i + " ");
			}
		}
	}
}