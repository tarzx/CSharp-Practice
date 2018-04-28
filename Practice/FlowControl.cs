using System;

namespace Practice
{
	public class FlowControl
	{
		public static void Main (string[] args) {
			//checkPositive ();
			//mulNotZero ();
			//divideNotZero ();
			//greatestThree ();
			//whileTilZero ();
			//doTilZero ();
			//whileCounter ();
			//timeTable ();
			//oddDescending ();
			//sumNumber ();
			//twoNegative ();
			//oneOrTwoNegative ();
			//mul3and5 ();
			//numberRepeat ();
			//password ();
			//passwordCounter ();
			//manyDivision ();
			//severalMultiTable ();
			//square ();
			//breakContinue ();
			//rectangle ();
			//repeatitive ();
			//digit ();
			//hollowSquare ();
			//product ();
			//absolute ();
			//hollowRectangle ();
			//statisitc ();
			//switches ();
			//conditionalOperator ();
			//prime ();
			//conditionalOperator2 ();
			//giveChange ();
			exception ();
		}
		public static void checkPositive() {
			int a;

			Console.WriteLine ("Enter a number: ");
			a=Convert.ToInt32(Console.ReadLine());

			if(a>0)
				Console.WriteLine (" is positive");
			else if(a<0)
				Console.WriteLine (" is negative");
			else
				Console.WriteLine (" is zero");
		}
		public static void mulNotZero() {
			int x,y;

			Console.Write ("Enter x: ");
			x = Convert.ToInt32(Console.ReadLine());

			if (x!=0) 
			{
				Console.Write("Enter y: ");
				y = Convert.ToInt32(Console.ReadLine());  
				Console.WriteLine("The product of {0} and {1} is {2}", x, y, x*y);
			}
			else 
				Console.Write("0");
		}
		public static void divideNotZero() {
			int number1, number2;

			Console.Write ("Enter the first number: ");
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the second number: ");
			number2 = Convert.ToInt32(Console.ReadLine());

			if (number2 != 0)
			{
				Console.WriteLine ("The result for {0} / {1} is {2}", number1, number2, number1/number2);
			}
		 	else 
				Console.WriteLine ("No result");
		}
		public static void greatestThree() {
			int number1, number2, number3;

			Console.Write ("Enter the number 1: ");
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the number 2: ");
			number2 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the number 3: ");
			number3 = Convert.ToInt32(Console.ReadLine());

			if (number1 > number2 && number1 > number3)
				Console.WriteLine ("The number 1 ({0}) is greatest", number1);
			else if ( number2 > number1 && number2 > number3)
				Console.WriteLine ("The number 2 ({0}) is greatest", number2);
			else if ( number3 > number1 && number3 > number2)
				Console.WriteLine ("The number 3 ({0}) is greatest", number3);
			else
				Console.WriteLine("Numbers equals");
		}
		public static void whileTilZero() {
			int number;

			Console.Write ("Enter a number: ");
			number = Convert.ToInt32(Console.ReadLine());

			while (number != 0)
			{
				Console.WriteLine (number * 10);
				Console.Write ("Enter a number: ");
				number = Convert.ToInt32(Console.ReadLine());
			}
		}
		public static void doTilZero() {
			int number;

			do
			{
				Console.Write ("Enter a number: ");
				number = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(number * 10);
			}
			while (number != 0);
		}
		public static void whileCounter() {
			int n=1;
			while (n <= 10)
			{
				Console.Write("{0} ", n);
				n++;
			}
		}
		public static void timeTable() {
			int num, multiplier = 1;

			Console.Write ("Insert a number to multiply: ");
			num = Convert.ToInt32(Console.ReadLine());
			while (multiplier <= 10)
			{
				Console.WriteLine("{0} x {1} = {2}", num, multiplier, num*multiplier);
				multiplier++;
			}
		}
		public static void oddDescending() {
			int n = 15;
			while (n >= 7)
			{
				Console.WriteLine(n);
				n -= 2;
			}
		}
		public static void sumNumber() {
			int number;
			int sum = 0;
	
			do
			{
				Console.Write ("Number: ");
				number = Convert.ToInt32(Console.ReadLine());

				sum = number + sum;

				if(number != 0)
					Console.WriteLine ("Total: {0}", sum);
			} 
			while (number != 0);

			Console.WriteLine ("Finished");
		}
		public static void twoNegative() {
			int number1;
			int number2;

			Console.Write ("number 1: ");
			number1=Convert.ToInt32(Console.ReadLine());

			Console.Write ("number 2: ");
			number2=Convert.ToInt32(Console.ReadLine());

			if( (number1 < 0) && (number2 < 0) )
				Console.WriteLine ("the numbers are negative");

			if( ! ( (number1 < 0) && (number2 < 0) ) )
				Console.WriteLine ("the numbers are NOT negative");
		}
		public static void oneOrTwoNegative() {
			int number1;
			int number2;

			Console.Write ("number 1: ");
			number1=Convert.ToInt32(Console.ReadLine());

			Console.Write ("number 2: ");
			number2=Convert.ToInt32(Console.ReadLine());

			if( (number1 < 0) && (number2 < 0) )
				Console.WriteLine ("the numbers are negative");

			else if( (number1 < 0) || (number2 < 0) )
				Console.WriteLine ("one is negative");

			else
				Console.WriteLine ("none is negative");
		}
		public static void mul3and5() {
			int i = 1;

			for (i=1; i <= 500; i++) {
				if ((i%3 == 0) && (i%5 == 0))
					Console.Write ("{0} ",i);
			}
		}
		public static void numberRepeat() {
			int num, amount;
			int i;

			Console.Write ("Enter a number: ");
			num = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter an amount: ");
			amount = Convert.ToInt32(Console.ReadLine());

			// ------------------------------------
			for( i = 0 ; i < amount ; i++) 
				Console.Write (num);

			// ------------------------------------
			Console.WriteLine();

			i = 0 ; 
			while(i < amount) 
			{
				Console.Write (num);
				i++;
			}

			// ------------------------------------
			Console.WriteLine();

			i = 0 ; 
			do
			{
				Console.Write (num);
				i++;
			}
			while(i < amount);
		}
		public static void password() {
			int user, pass;             

			do
			{                        
				Console.Write ("Enter a user:  ");
				user = Convert.ToInt32(Console.ReadLine());

				Console.Write ("Enter a password:  ");
				pass = Convert.ToInt32(Console.ReadLine());

				if ((user != 12) || (pass != 1234))
					Console.WriteLine ("Login Error");

			}
			while ( (user != 12) || (pass != 1234));

			Console.WriteLine ("Login successful");
		}
		public static void passwordCounter() {
			int user, pass;             
			int counter = 0;

			do
			{                        
				Console.Write ("Enter a user:  ");
				user = Convert.ToInt32(Console.ReadLine());

				Console.Write ("Enter a password:  ");
				pass = Convert.ToInt32(Console.ReadLine());

				if ((user != 12) || (pass != 1234))
				{
					Console.WriteLine ("Login Error");
					counter++;
				}

			}
			while ( ((user != 12) || (pass != 1234)) &&  (counter != 3));

			if ((user != 12) || (pass != 1234))
				Console.WriteLine ("Logged out!");
			else
				Console.WriteLine ("Login successful");
		}
		public static void manyDivision() {
			int num1, num2;
			do {
				Console.Write ("First number? ");
				num1 = Convert.ToInt32 (Console.ReadLine ());

				if (num1 != 0) {
					Console.Write ("Second number? ");
					num2 = Convert.ToInt32 (Console.ReadLine ());
					if (num2 == 0) {
						Console.WriteLine ("Cannot divide by 0");
						Console.WriteLine ();
					} else {
						Console.WriteLine ("Division is {0}", num1 / num2);
						Console.WriteLine ("Remainder is {0}", num1 % num2);
						Console.WriteLine ();
					}
				}   
			} while(num1 != 0);
			Console.WriteLine ("Bye!");
		}
		public static void severalMultiTable() {
			int num, multiplier;

			num = 2;

			do
			{

				multiplier = 1;
				do
				{
					Console.WriteLine ("{0} x {1} = {2}", num, multiplier, num*multiplier);
					multiplier++;
				}
				while (multiplier <= 10);

				Console.WriteLine ();
				num++;

			} while (num <= 6);
		} 
		public static void square() {
			int n;     // User entered data
			int row,column;   // For loops
			int width;

			Console.Write ("Enter a number: ");
			n = Convert.ToInt32( Console.ReadLine() );
			Console.Write ("Enter the desired: ");
			width = Convert.ToInt32( Console.ReadLine() );

			for (row=0; row<width; row++)
			{
				for (column=0; column<width; column++)
					Console.Write (n);

				Console.WriteLine ();
			}
		}
		public static void breakContinue() {
			for (int i=10; i<=20; i+=2) {
				if (i==16) 
					continue;
				Console.Write ("{0} ", i);
			}
			Console.WriteLine ();

			for (int i=10; i<=20; i++) {
				if (i%2 == 1) 
					continue;               
				if (i==16) 
					continue;
				Console.Write ("{0} ", i);
			}
			Console.WriteLine ();

			for (int i=10; ; i+=2) {
				if (i==16) 
					continue;
				if (i>20) 
					break;
				Console.Write ("{0} ", i);
			} 
			Console.WriteLine ();
		}
		public static void rectangle() {
			int n;   // User entered data
			int row, column; // For loops
			int width, height;

			Console.Write ("Enter a number: ");
			n = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Enter the desired: ");
			width = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Enter the desired height: ");
			height = Convert.ToInt32 (Console.ReadLine ());

			for (row = 0; row<height; row++) {
				for (column = 0; column<width; column++)
					Console.Write (n);
				Console.WriteLine ();
			}
		}
		public static void repeatitive() {
			int number,number2;
			int i;

			Console.Write ("Enter first number: ");
			number = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Enter last number: ");
			number2 = Convert.ToInt32 (Console.ReadLine ());               

			for (i = number; i <= number2; i++)
				Console.Write ("{0} ", i);

			Console.WriteLine ();
			// -----------------------
			i = number;
			while (i <= number2) {
				Console.Write ("{0} ", i);
				i++;   
			}
			Console.WriteLine ();
			// -----------------------
			i = number;
			do {
				Console.Write ("{0} ", i);
				i++;  
			} while(i <= number2);

			Console.WriteLine ();
		}
		public static void digit() {
			int number;
			int digit = 0;

			Console.Write ("Number? ");
			number = Convert.ToInt32(Console.ReadLine());

			if(number < 0) {
				Console.WriteLine ("(Warning: it is a negative number)");
				number = -number;
			}

			while (number > 0) {
				number = number / 10;
				digit++;
			}
			if (digit == 0) digit = 1;

			Console.WriteLine ("{0} digits", digit);
		}
		public static void hollowSquare() {
			int n;
			int i,j;
			int width;

			Console.Write ("Enter number for the border of the square: ");
			n=Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter total: ");
			width=Convert.ToInt32(Console.ReadLine());

			// First row
			for(i=0;i<width;i++)
				Console.Write (n);
			Console.WriteLine ();
			// Middle x-2 rows
			for(i=0;i<width-2;i++) {
				Console.Write (n);
				for(j=0;j<width-2;j++)
					Console.Write (" ");
				Console.WriteLine (n);
			}   
			// Last row
			for(i=0;i<width;i++)
				Console.Write (n);

			Console.WriteLine ();
		}
		public static void product() {
			int n1, n2;
			Console.Write ("Enter the first number: ");
			n1 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the second number: ");
			n2 = Convert.ToInt32(Console.ReadLine());

			int result=0;
			int i=0;
			while( i < n2 ) {
				result = result+n1;
				i++;
			}
			Console.WriteLine ("{0} X {1} = {2}", n1, n2, result);
		}
		public static void absolute() {
			int n, abs;
			Console.Write ("Enter a number: ");
			n = Convert.ToInt32(Console.ReadLine());

			if(n<0)
				abs = -n;
			else
				abs = n;
			Console.WriteLine ("Absolute valor is {0}", abs);

			//valor = condicion? siCierto;siFalso;
			abs = n<0 ? -n: n;
			Console.WriteLine ("And also {0}", abs);
		}
		public static void hollowRectangle() {
			int symbol, width, height;
			int row, column;

			Console.Write ("Enter a symbol: ");
			symbol = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the desired width: ");
			width = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the desired height: ");
			height = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine (); 

			for(row = 1; row <= height; row++) {
				for(column = 1; column <= width; column++) {
					if ((row == 1) || (row == height))
						Console.Write (symbol);
					else {
						if ((column == 1) || (column == width))
							Console.Write (symbol);
						else
							Console.Write (" ");
					}
				} 
				Console.WriteLine();                 
			}   
		}
		public static void statisitc() {
			int num; 
			int total=0, amount=0;
			int maximum, minimum;

			Console.Write ("number? ");
			num = Convert.ToInt32(Console.ReadLine());
			maximum = num;
			minimum = num;

			while (num!=0) {
				amount++;
				total += num;

				if (num > maximum)
					maximum = num;
				if (num < minimum)
					minimum = num;

				Console.WriteLine ("Total={0} Amount={1} Average={2} maximum={3} minimum={4}", total, amount, total/amount, maximum, minimum);

				Console.Write("number? ");
				num = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Bye!");
		}
		public static void switches() {
			int number;

			Console.Write ("Number? ");
			number = Convert.ToInt32(Console.ReadLine());

			if ((number == 9) || (number == 10))
				Console.WriteLine ("Sobresaliente");
			else if ((number == 7) || (number == 8))
				Console.WriteLine ("Notable");
			else if(number == 6)
				Console.WriteLine ("Bien");
			else if(number == 5)
				Console.WriteLine ("Aprobado");
			else if ((number >= 0) && (number <= 4))
				Console.WriteLine ("Suspenso");
			else
				Console.WriteLine ("No válido");

			switch(number) {
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
				Console.WriteLine ("Suspenso");
				break;
			case 5:
				Console.WriteLine ("Aprobado");
				break;
			case 6:
				Console.WriteLine ("Bien");
				break;
			case 7: goto case 8;  // Innecesario, pero aceptable
			case 8:
				Console.WriteLine ("Notable");
				break;
			case 9: 
				Console.WriteLine ("Bajo, pero... ");  // Ejemplo
				goto case 10;
			case 10:
				Console.WriteLine ("Sobresaliente");
				break;
			default:
				Console.WriteLine ("Nota no válida");
				break;
			}
		}
		public static void conditionalOperator() {
			int a, b;
			string answer;

			Console.Write ("Enter the first number: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter the second number: ");
			b = Convert.ToInt32(Console.ReadLine());

			// ------ First number positive -------
			// First, using "if"
			if (a > 0)
				Console.WriteLine ("a is positive");
			else
				Console.WriteLine ("a is not positive");
			// Second way: string and if
			if (a > 0)
				answer = "a is positive";
			else
				answer = "a is not positive";
			Console.WriteLine (answer);
			// Finally, using conditional
			answer = a > 0 ? "a is positive" : "a is not positive";
			Console.WriteLine (answer);

			// ------ Second number positive -------
			// Conditional inside Write
			Console.WriteLine (b > 0 ? "b is positive" : "b is not positive");
			// ------ Both positive -------
			// String and then if
			answer = (a > 0) && (b > 0)? "both are positive" : "not both are positive";
			Console.WriteLine (answer);
	
			// ------ Smallest -------        
			// Additional intermediate variable
			int smallest = a < b ? a : b;
			Console.WriteLine ("Smallest: {0}", smallest);
		}
		public static void prime() {
			int number;
			int dividers=0;

			Console.Write ("Enter a number: ");
			number=Convert.ToInt32(Console.ReadLine());

			for(int i=1; i <= number; i++)
				if(number%i==0)
					dividers++;

			if (dividers == 2)
				Console.WriteLine ("The number is prime");
			else
				Console.WriteLine ("The number is not prime");
		}
		public static void conditionalOperator2() {
			int a, b, amountOfPositives;

			Console.Write ("Enter 1st number: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter 2nd number: ");
			b = Convert.ToInt32(Console.ReadLine());

			if ((a > 0) && (b > 0))
				amountOfPositives = 2;
			else
				if ((a > 0) || (b > 0))
					amountOfPositives = 1;
				else
					amountOfPositives = 0;
			Console.WriteLine ("{0} positives.", amountOfPositives);

			amountOfPositives = ((a > 0) && (b > 0)) ? 2 : ((a > 0) || (b > 0)) ? 1 : 0;
			Console.WriteLine ("{0} positives.", amountOfPositives);
		}
		public static void giveChange() {
			int price, paid, change;

			Console.Write ("Price? ");
			price = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Paid? ");
			paid = Convert.ToInt32(Console.ReadLine());

			change = paid - price;
			Console.Write ("Your change is {0}: ", change);
			while (change > 0) {
				if (change >= 50) {
					Console.Write ("50 ");
					change-=50;
				}
				else {
					if (change >= 20) {
						Console.Write ("20 ");
						change-=20;
					}
					else {
						if (change >= 10) {
							Console.Write ("10 ");
							change-=10;
						}
						else {
							if (change >= 5) {
								Console.Write ("5 ");
								change-=5;
							}
							else {
								if (change >= 2) {
									Console.Write ("2 ");
									change-=2;
								}
								else {
									Console.Write ("1 ");
									change-=1;
								}
							}
						}
					}
				}
			}
			Console.WriteLine();
		}
		public static void exception() {
			int number1;
			int number2;
			int division;

			Console.Write ("Enter a number to divide: ");
			number1 = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Enter another number to divide: ");
			number2 = Convert.ToInt32 (Console.ReadLine ());

			try {
				division = number1 / number2;
				Console.WriteLine ("{0} / {1} = {2}", number1, number2, division);
			} catch (DivideByZeroException) {
				Console.WriteLine ("Cannot divide by Zero");
				return;
			}
		}
	}
}

