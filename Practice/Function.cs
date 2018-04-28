using System;

namespace Practice
{
	public class Function {
		
		public static void Main() {
			//testDouble ();
			//testSwap ();
			//testPower ();
			//testFactorial ();
			//testMaximum ();
			//testDraw ();
			//testCountDV ();
			//testReverse ();
			//testPalindrome ();
			testMultiply ();
		}
		public static int Double(int number) {
			return number*2;
		}
		public static void Double(ref int n) {   
			n = n + n;
		}
		public static void testDouble() {
			int x = 2;
			Console.WriteLine("Value x: {0}", x);
			int x2 = Double (x);
			Console.WriteLine ("Normal function...");
			Console.WriteLine("Result from normal function: {0}", x2);
			Console.WriteLine("Value x after normal function: {0}", x);
			Console.WriteLine ("Ref function...");
			Double(ref x);
			Console.WriteLine("Value x after ref function: {0}", x);
		}
		public static void Swap(ref int x, ref int y){
			int swap;

			swap = x;
			x = y;
			y = swap;
		}
		public static void testSwap() {
			int x = 5;
			int y = 3;

			Console.WriteLine ("x: {0} , y: {1}", x, y);
			Console.WriteLine ("Swap...");
			Swap (ref x, ref y);
			Console.WriteLine ("x: {0} , y: {1}", x, y);
		}
		public static double Power(double number, int exponent) {
			double result = 1;
			if (exponent > 0) {
				for (int i = 1; i <= exponent; i++)
					result *= number;
			} else if (exponent < 0) {
				for (int i = exponent; i <= -1; i++)
					result /= number;
			}
			return result;
		}
		public static double PowerR(double number, int exponent) {
			if (exponent > 0)
				return PowerR (number, exponent - 1) * number;
			else if (exponent < 0)
				return PowerR (number, exponent + 1) / number;
			else
				return 1;
		}
		public static void testPower() {
			double number;
			int exponent;

			Console.Write("Base: ");
			number = Convert.ToDouble( Console.ReadLine() );
			Console.Write("Exponent: ");
			exponent = Convert.ToInt32( Console.ReadLine() );
			Console.WriteLine("Loop: {0}^{1}={2}", number, exponent, Power(number, exponent));
			Console.WriteLine("Recursive: {0}^{1}={2}", number, exponent, PowerR(number, exponent));
		}
		public static int Factorial(int num) {
			int result = 1;
			for (int i = 1; i <= num; i++)
				result *= i;
			return result;
		}
		public static int FactorialR(int num) {
			if (num == 0)
				return 1;
			else
				return num * FactorialR(num-1);
		}
		public static void testFactorial() {
			Console.Write ("Enter a number: ");
			int number = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine ("Normal {0}! = {1}", number, Factorial(number));
			Console.WriteLine ("Recursive {0}! = {1}", number, FactorialR(number));
		}
		public static float Maximum(float[] list) {
			float max = float.MinValue; //-99999999.00f;
			for (int i = 0; i < list.Length; i++)
				max = max < list[i] ? list[i] : max;
			return max;
		}
		public static void testMaximum() {
			float[] data = { 1.5f, 0.7f, 8.0f };
			float max = Maximum(data);
			Console.WriteLine (max);    
		}
		public static void DrawParallelogram(int width, int height, char character) {
			for (int i = 0; i < height; i++) {
				// Write character
				for (int j = 0; j < width-i; j++)
					Console.Write (character);
				Console.WriteLine ();
				// Write spaces
				for (int c = 0; c <= i; c++)
					Console.Write (" ");
			}
		}
		public static void testDraw() {
			DrawParallelogram(10, 5, '*');
		}
		public static void CountDV(string answer, ref int amountOfDigits, ref int amountOfVowels) {
			amountOfDigits = 0;
			amountOfVowels = 0;

			for (int i=0; i < answer.Length; i++) {
				switch (answer.Substring(i,1).ToLower()) {
					case "a": case "e": case "i": case "o": case "u": 
						amountOfVowels++; 
						break;
					case "0": case "1": case "2": case "3": case "4":
					case "5": case "6": case "7": case "8": case "9": 
						amountOfDigits++; 
						break;
				}
			}
		}
		public static void testCountDV() {
			string input = "This";
			int amountOfDigits = 0;
			int amountOfVowels = 0;

			CountDV (input, ref amountOfDigits, ref amountOfVowels);
			Console.WriteLine ("Text: {0}", input);
			Console.WriteLine ("Amount of digits: {0}", amountOfDigits);
			Console.WriteLine ("Amount of vowels: {0}", amountOfVowels);
		}
		public static string Reverse(string text) {
			if (text.Length <= 1) 
				return text;
			char firstLetter = text[0];
			string rest = text.Substring(1);
			return Reverse(rest) + firstLetter;
		}
		public static void testReverse() {
			Console.Write ("Enter text : ");
			string input = Console.ReadLine();

			Console.WriteLine ("Raverse: {0}", Reverse(input));
		}
		public static bool IsPalindrome(string text) {
			text = text.ToUpper();
			int begin=0;
			int end = text.Length-1;
			for(begin = 0; begin < end; begin++) {
				if( text[begin] != text[end] )
					return false;
				end--;
			}
			return true;
		}   
		public static bool IsPalindromeR(string text) {
			if (text.Length <= 1)
				return true;
			else {
				if (text[0] != text[text.Length-1])
					return false;
				else
					return IsPalindromeR(text.Substring(1, text.Length-2));
			}   
		} 
 		public static void testPalindrome() {
			string t1 = "radar";
			string t2 = "ratas";

			Console.WriteLine ("IsPalindrome on {0}: {1}", t1, IsPalindrome(t1));
			Console.WriteLine ("IsPalindrome on {0}: {1}", t2, IsPalindrome(t2));
			Console.WriteLine ("IsPalindrome Recursive on {0}: {1}", t1, IsPalindromeR(t1));
			Console.WriteLine ("IsPalindrome Recursive on {0}: {1}", t2, IsPalindromeR(t2));
		}
		public static int Multiply(int n1, int n2) {
			int result = 0;
			for (int i = 1; i <= n2; i++)
				result += n1;
			return result;
		}
		public static int MultiplyR(int n1, int n2) {
			if (n2 == 0)
				return 0;
			else
				return n1 + MultiplyR(n1, n2 - 1);
		}   
		public static void testMultiply() {
			Console.Write ("Enter n1: ");
			int n1 = Convert.ToInt32(Console.ReadLine());       
			Console.Write ("Enter n2: ");
			int n2 = Convert.ToInt32(Console.ReadLine());       
			Console.WriteLine ("Normal {0} x {1} = {2}", n1, n2, Multiply(n1, n2));
			Console.WriteLine ("Recursive {0} x {1} = {2}", n1, n2, MultiplyR(n1, n2));
		}

	}
}

