using System;

namespace Practice
{
	class FirstProgram
	{
		public static void Main (string[] args) {
			//print ();
			//sumNumber ();
			//divisionNumber ();
			//multiOperation ();
			//mulVariable ();
			//useComment ();
			//severalOperation ();
			//multiTable ();
			//average ();
			//equivalent ();
			//age ();
			//formats ();
			//rectangle ();
			conversion ();
		}

		public static void print() {
			Console.WriteLine ("Hello World!");
		}
		public static void sumNumber() {
			Console.WriteLine (2+3);
		}
		public static void divisionNumber() {
			Console.WriteLine (24/5);
		}
		public static void multiOperation() {
			Console.WriteLine (-1+3*5);
			Console.WriteLine ((24+5)%7);
			Console.WriteLine (15+-4*6/11);
			Console.WriteLine (2+10/6*1-7%2);
		}
		public static void mulVariable() {
			int number1, number2;
			int multiplication;

			Console.Write ("Enter 1st number ");
			number1 = System.Convert.ToInt32 (System.Console.ReadLine ());
			Console.Write ("Enter 2nd number ");
			number2 = System.Convert.ToInt32 (System.Console.ReadLine ());

			multiplication = number1 * number2;
			System.Console.Write ("The multiplication is:");
			System.Console.WriteLine (multiplication);
		}
		public static void useComment() {
			int number1, number2, number3;

			Console.Write ("Enter the first number to multiply: ");
			number1 = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Enter the second number to multiply: ");
			number2 = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Enter the third number to multiply: ");
			number3 = Convert.ToInt32 (Console.ReadLine ());

			int result = number1 * number2 * number3;
			Console.WriteLine ("Result: {0} x {1} x {2} = {3}", number1, number2, number3, result);
		}
		public static void severalOperation() {
			Console.Write ("Enter a number: ");
			int number1= Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter another number: ");
			int number2= Convert.ToInt32(Console.ReadLine());

			Console.WriteLine ("{0} + {1} = {2}", number1, number2, number1+number2);
			Console.WriteLine ("{0} - {1} = {2}", number1, number2, number1-number2);
			Console.WriteLine ("{0} x {1} = {2}", number1, number2, number1*number2);
			Console.WriteLine ("{0} / {1} = {2}", number1, number2, number1/number2);
			Console.WriteLine ("{0} mod {1} = {2}", number1, number2, number1%number2);
		}
		public static void multiTable() {
			int x;
			int result;

			Console.Write ("Enter a number:");
			x = Convert.ToInt32(Console.ReadLine() );

			result = x * 0;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 0, result); 
			result = x * 1;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 1, result);
			result = x * 2;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 2, result);
			result = x * 3;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 3, result);
			result = x * 4;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 4, result);
			result = x * 5;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 5, result);
			result = x * 6;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 6, result);
			result = x * 7;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 7, result);
			result = x * 8;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 8, result);
			result = x * 9;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 9, result);
			result = x * 10;
			Console.WriteLine ("The result is: {0} x {1} = {2}", x, 10, result);
		}
		public static void average() {
			int num1,num2,num3,num4;

			Console.Write ("Enter the First number: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the Second number: ");
			num2 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the third number: ");
			num3 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the four number: ");
			num4 = Convert.ToInt32(Console.ReadLine());

			int result = (num1 + num2 + num3 + num4) / 4;
			Console.WriteLine("the average of {0} , {1} , {2} , {3} is: {4} ", num1, num2, num3, num4, result);
		}
		public static void equivalent() {
			int num1, num2, num3;

			Console.Write ("Enter first number....");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter second number....");
			num2 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter third number....");
			num3 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Result of operation between {0}, {1} and {2}, (a+b)·c is {3} and a·b + a·c is {4}",
				num1, num2, num3, ((num1+num2)*num3), (num1*num3+num2*num3));
		}
		public static void age() {
			int age;
			Console.Write ("Enter a age ");
			age = Convert.ToInt32(Console.ReadLine());
			Console.Write("You look younger than {0} ",age);
		}
		public static void formats() {
			int n; 

			Console.Write ("Enter a digit: ");
			n = Convert.ToInt32 (Console.ReadLine ());

			// Part A: "n n n n" using Write
			Console.Write (n);
			Console.Write (" ");
			Console.Write (n);
			Console.Write (" ");
			Console.Write (n);
			Console.Write (" ");
			Console.Write (n);
			Console.WriteLine ();

			// Part B: "nnnn" using Write
			Console.Write (n);
			Console.Write (n);
			Console.Write (n);
			Console.Write (n);
			Console.WriteLine ();

			// Part C: "n n n n" using {0}
			Console.WriteLine ("{0} {0} {0} {0}", n);

			// Part D: "nnnn" using {0}
			Console.WriteLine ("{0}{0}{0}{0}", n);
		}
		public static void rectangle() {
			int x;

			Console.Write ("Enter a number: ");
			x=Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("{0}{0}{0}",x);
			Console.WriteLine("{0} {0}",x);
			Console.WriteLine("{0} {0}",x);
			Console.WriteLine("{0} {0}",x);
			Console.WriteLine("{0}{0}{0}",x);
		}
		public static void conversion() {
			Console.Write("Enter the amount of celsius: "); 
			int celsius = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Kelvin = {0}", celsius + 273);
			Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
		}
	}
}
