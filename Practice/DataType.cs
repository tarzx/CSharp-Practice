using System;

namespace Practice
{
	public class DataType
	{
		public static void Main (String[] args) {
			//testChar ();
			//triangle ();
			//passwordString ();
			//passwordCounter ();
			//calculatorIf ();
			//calculatorSwitch ();
			//testDouble ();
			//calFunction ();
			//displayFunction ();
			//testFloat ();
			//sphere ();
			//vowelSwitch ();
			//vowelIf ();
			//triangleNE ();
			//primeFactor ();
			//symbolIf ();
			//charFor ();
			//approxPI ();
			//calRecInfo ();
			//hexadecimal ();
			//hexadecimalTable ();
			//binary ();
			//conditionalBoolean ();
			exceptionFloat ();
		}

		public static void testChar() {
			char letter,letter2,letter3;

			Console.Write ("Enter letter: ");
			letter = Convert.ToChar (Console.ReadLine ());
			Console.Write ("Enter letter: ");
			letter2 = Convert.ToChar (Console.ReadLine ());       
			Console.Write ("Enter letter: ");
			letter3 = Convert.ToChar (Console.ReadLine ());
			Console.WriteLine ("{0} {1} {2}", letter3, letter2, letter);
		}
		public static void triangle() {
			Console.Write("Enter a number: ");
			int n = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Enter the desired width: ");
			int width = Convert.ToInt32 (Console.ReadLine ());

			int height = width;   
			for (int row = 0; row < height; row++) {
				for (int column = 0; column < width; column++) {
					Console.Write (n);
				}
				Console.WriteLine ();
				width--;
			}
		}
		public static void passwordString() {
			string user, password;

			do {
				Console.Write ("Enter a user: ");
				user = Console.ReadLine();
				Console.Write ("Enter a password: ");
				password = Console.ReadLine();
			}
			while ( user != "user" && password != "password" );
			Console.WriteLine ( "Bye!" );
		}
		public static void passwordCounter() {
			string user, pass;
			int count = 0;

			do {
				Console.Write ("Enter username: ");
				user = Console.ReadLine();
				Console.Write ("Enter password: ");
				pass = Console.ReadLine();
				count++;
			}
			while(((user != "user") || (pass != "password")) && (count != 5));

			if (count == 5)
				Console.Write ("Login attemp fail!");
			else   
				Console.Write ("Password correct!");
		}
		public static void calculatorIf() {
			int a, b;
			char operation;

			Console.Write ("Enter first number: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter operation: ");
			operation = Convert.ToChar(Console.ReadLine());
			Console.Write ("Enter second number: ");
			b = Convert.ToInt32(Console.ReadLine());

			if (operation=='+')
				Console.WriteLine("{0} + {1} = {2}", a, b, a+b);
			else if (operation=='-')
				Console.WriteLine("{0} - {1} = {2}", a, b, a-b);
			else if ((operation=='x') || (operation=='*'))
				Console.WriteLine("{0} * {1} = {2}", a, b, a*b);
			else if (operation=='/')
				Console.WriteLine("{0} / {1} = {2}", a, b, a/b);
			else
				Console.WriteLine("Wrong Character");
		}
		public static void calculatorSwitch() {
			int a, b;
			char operation;

			Console.Write ("Enter first number: ");
			a = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Enter operation: ");
			operation = Convert.ToChar (Console.ReadLine ());
			Console.Write ("Enter second number: ");
			b = Convert.ToInt32 (Console.ReadLine ());

			switch (operation) {
			case '+': 
				Console.WriteLine ("{0} + {1} = {2}", a, b, a + b);
				break;
			case '-':
				Console.WriteLine ("{0} - {1} = {2}", a, b, a - b);
				break;
			case 'x':
			case '*':
				Console.WriteLine ("{0} * {1} = {2}", a, b, a * b);
				break;
			case '/':
				Console.WriteLine ("{0} / {1} = {2}", a, b, a / b);
				break;
			default:
				Console.WriteLine ("Wrong Character");
				break;
			}
		}
		public static void testDouble() {
			double a, b;
			double area, perimeter, diagonal;

			Console.Write ("Enter the width: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write ("Enter the height: ");
			b = Convert.ToDouble(Console.ReadLine());

			perimeter = a*2 + b*2;
			Console.WriteLine ("Perimeter: {0}", perimeter);
			area = a*b;
			Console.WriteLine("Area: {0}", area);
			diagonal = Math.Sqrt (a*a + b*b);
			Console.WriteLine("Diagonal: {0}", diagonal);
		}
		public static void calFunction() {
			int y, x;

			Console.WriteLine ("y = x² - 2x +1");
			Console.WriteLine ();

			for (x=-10; x <= 10; x++) {
				y = x*x - 2*x + 1;
				Console.WriteLine ("x = {0} ; y=({0})² - 2*({0}) +1 = {1}", x, y);
			}
		}
		public static void displayFunction() {
			int x,y,j;
			for(x = -1; x <= 8; x ++)
			{
				y = (x-4) * (x-4);

				for(j = 0; j < y; j++)
					Console.Write ("*");
				Console.WriteLine ();
			}
		}
		public static void testFloat() {
			float distance;
			float hour, min, sec;
			float timeSec;
			float mps;
			float kph, mph;

			Console.Write ("Enter distance(meters): ");
			distance = Convert.ToSingle(Console.ReadLine());
			Console.Write ("Enter timeSec(hour): ");
			hour = Convert.ToSingle(Console.ReadLine());
			Console.Write ("Enter timeSec(minutes): ");
			min = Convert.ToSingle(Console.ReadLine());
			Console.Write ("Enter timeSec(seconds): ");
			sec = Convert.ToSingle(Console.ReadLine());

			timeSec = (hour*3600) + (min*60) + sec;
			mps = distance/timeSec;
			kph = (distance/1000.0f)/(timeSec/3600.0f);
			mph = kph / 1.609f;

			Console.WriteLine ("Your speed in meters/sec is {0}", mps);
			Console.WriteLine ("Your speed in km/h is {0}", kph);
			Console.WriteLine ("Your speed in miles/h is {0}", mph);
		}
		public static void sphere() {
			float radius;
			float pi = 3.1415926535f;

			Console.Write ("Radius? ");
			radius = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine ("Surface: {0}", 4 * pi * (radius * radius) );
			Console.WriteLine ("Volume: {0}", 4/3 * pi * (radius * radius * radius));
		}
		public static void vowelSwitch() {
			char symbol;

			Console.Write ("Enter a symbol: ");
			symbol=Convert.ToChar(Console.ReadLine());

			switch(symbol)
			{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
				Console.WriteLine ("It's a lowercase vowel.");
				break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				Console.WriteLine ("It's a digit.");
				break;
			default:
				Console.Write ("It's another symbol.");
				break;
			}
		}
		public static void vowelIf() {
			char symbol;

			Console.Write ("Enter a symbol: ");
			symbol=Convert.ToChar(Console.ReadLine());

			if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
				Console.WriteLine ("It's a lowercase vowel.");
			else if ((symbol >= '0') && (symbol <= '9'))
				Console.WriteLine ("It's a digit.");
			else
				Console.Write ("It's another symbol.");        
		}
		public static void triangleNE() {
			int width, height;    
			int row,column;   
			int max;

			Console.Write ("Enter the desired width: ");
			height = Convert.ToInt32( Console.ReadLine() );
			width = 0;
			max = height;

			for (row = 0; row < height; row++) {
				for (column = 0; column < width; column++)
					Console.Write (" ");
				for (int asterisks = 0; asterisks < max; asterisks++)
					Console.Write ("*");

				Console.WriteLine ();
				width++;
				max--;
			}
		}
		public static void primeFactor() {
			int n;
			int d = 2; 

			Console.Write ("Enter the number: ");
			n = Convert.ToInt32( Console.ReadLine() );
	
			while (n > 1) {
				while (n % d == 0) {
					Console.Write (d);
					Console.Write (" · ");
					n = n / d;
				}
				d++;
			}
			Console.Write(1);
		}
		public static void symbolIf() {
			char symbol;

			Console.Write("insert anything: ");
			symbol = Convert.ToChar(Console.ReadLine());

			if(symbol>='0' && symbol <='9')
				Console.WriteLine ("it's a number");
			else if ((symbol=='a') || (symbol=='e') || (symbol=='i')
				|| (symbol=='o') || (symbol=='u'))
				Console.WriteLine ("it's a lowercase vowel");
			else if ((symbol=='A') || (symbol=='E') || (symbol=='I')
				|| (symbol=='O') || (symbol=='U'))
				Console.WriteLine ("it's a upercase vowel");
			else
				Console.WriteLine ("it's a symbol");
		}
		public static void charFor() {
			for(char i = 'B'; i <= 'N'; i++) {
				Console.Write("{0} ", i);
			}
			Console.WriteLine(); 
		}
		public static void approxPI() {
			int terms;
			double result = 0;

			Console.WriteLine ("PI estimator!");
			Console.Write ("Enter the amount of terms to test: ");
			terms = Convert.ToInt32(Console.ReadLine());

			for (int i=1; i<=terms; i++) {
				int divisor = 2*i - 1;
				if (i%2 == 1) //  Odd term: positive
					result += 1.0f/divisor;
				else          //  Even term: negative
					result -= 1.0f/divisor;
				Console.WriteLine("To term {0}: {1}", i, 4*result);
			}
		}
		public static void calRecInfo() {
			double width;
			double height;
			double perimeter, area, diagonal;

			do {
				Console.Write ("Enter the desired width: ");
				width = Convert.ToDouble(Console.ReadLine());

				if (width != 0) {
					Console.Write ("Enter the desired height: ");
					height = Convert.ToDouble(Console.ReadLine());
					perimeter = width * 2 + height * 2;        
					Console.WriteLine ("Perimeter: {0}", perimeter);
					area = width * height;        
					Console.WriteLine ("Area: {0} ", area);
					diagonal = Math.Sqrt((width * width) + (height * height));        
					Console.WriteLine ("Diagonal: {0} ", diagonal);
				}
			}
			while (width != 0);
		}
		public static void hexadecimal() {
			int n;

			do {
				Console.Write ("Enter a number:");
				n = Convert.ToInt32 (Console.ReadLine ());

				if (n != 0) {
					Console.Write ("Hexadecimal: ");
					Console.WriteLine (Convert.ToString (n, 16));
					Console.Write ("Binary: ");
					Console.WriteLine (Convert.ToString (n, 2));
				}
			} while (n != 0);
		}
		public static void hexadecimalTable() {
			for (int i = 0; i <= 255; i++) {
				if (i < 16)  // 0 in the beginning of the first row
					Console.Write ("0");
				Console.Write ("{0} ", Convert.ToString (i, 16));  // Hexadecimal
				if (i % 16 == 15)    // Jump to next line after 16 data
					Console.WriteLine ();
			}
		}
		public static void binary() {
			string answer;  // What the user enters
			string result;  // The result to display
			do {
				Console.Write ("Number to convert (or \"end\")? ");
				answer = Console.ReadLine();

				if (answer != "end") {
					int n = Convert.ToInt32(answer);
					result = "";
					while (n > 1) {
						int remainder = n % 2;
						result = Convert.ToString(remainder) + result;
						n /= 2;
					}
					result = Convert.ToString(n) + result;
					Console.WriteLine ("Binary: {0}", result);
				}
			}
			while (answer != "end");    
		}
		public static void conditionalBoolean() {
			int num1, num2;
			bool bothEven;
			Console.Write ("Enter First number: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write ("Enter Second number: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			//bothEven = ((num1%2!=0) || (num1%2!=0))? false:true;
			bothEven = ((num1 % 2 == 0) && (num2 % 2 ==0))? true : false;

			Console.WriteLine( bothEven ? "there're numbers both even" : "there's some odd numbers");
		}
		public static void exceptionFloat() {
			float result;
			float num;

			Console.Write("Enter Number ");
			try {
				num = Convert.ToSingle( Console.ReadLine() );
				result=(float) Math.Sqrt(num);
				Console.WriteLine ("The result is: {0}", result);
			}
			catch (Exception) {
				Console.WriteLine ("Error, I cannot calculate the Square Root");
			}
		}
	}
}

