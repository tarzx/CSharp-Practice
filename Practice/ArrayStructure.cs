using System;

namespace Practice
{
	public class ArrayStructure
	{
		public static void Main (String[] agrs)
		{
			//reverse ();
			//searchArray ();
			//arrayEven ();
			//arrayPosNeg ();
			//sumArray ();
			//twoDimensionArray ();
			//statistics ();
			//testStruct ();
			//structArray ();
			//structMenu ();
			//bookDB ();
			//triangleName ();
			//rectangleName ();
			//centeredTriangle ();
			//cityDB ();
			//banner ();
			//triangleE ();
			//stringManipulation ();
			//nestStruct ();
			//sortedData ();
			screen2D ();
		}
		public static void reverse() {
			int[] numbers = new int[5];

			for (int i=0; i < 5;i++) {
				Console.Write ("Number {0} =  ", i + 1);
				numbers[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine();
			for (int i=4; i >= 0;i--)
				Console.Write ("{0} ", numbers[i]);  
		}
		public static void searchArray() {
			Console.Write ("Size: ");
			int size = Convert.ToInt32(Console.ReadLine());
			float number;
			float[] listNumber = new float[size];

			for(int i=0; i<size; i++) {
				Console.Write ("Number {0} = ", i+1);
				listNumber[i] = Convert.ToSingle(Console.ReadLine());
			}
				
			do {
				Console.Write("Search number? ");
				number = Convert.ToSingle(Console.ReadLine());
				for (int i=0; i<size; i++) {
					if (listNumber[i] == number)
						Console.WriteLine ("Number {0} exists", number );
				}
			} while (number != 0);

		}
		public static void arrayEven() {
			int[] numbers = new int[10];

			for (int i = 0; i < 10;i++) {
				Console.Write ("Numero {0} = ", i+1);
				numbers[i] = Convert.ToInt32( Console.ReadLine());
			}

			for (int i = 0;i < 10;i++)
				if (numbers[i]%2==0)
					Console.Write ("{0} ", numbers[i]);
		}
		public static void arrayPosNeg() {
			float[] numbers = new float[10];
			float totalPositive = 0.0f;
			float totalNegative = 0.0f;
			int countPositive = 0;
			int countNegative = 0;

			for (int i=0;i < 10;i++) {
				Console.Write ("Number {0} = ", i+1);
				numbers[i] = Convert.ToSingle( Console.ReadLine());
			}

			for (int i=0;i < 10;i++) {   
				//Negative
				if (numbers[i] < 0) {
					totalNegative = totalNegative + numbers[i];
					countNegative++;
				}
				//Positive
				if (numbers[i] > 0) {
					totalPositive = totalPositive + numbers[i];
					countPositive++;
				}
			}

			Console.WriteLine ("Average numbers negatives = {0}", totalNegative / countNegative);
			Console.WriteLine ("Average numbers positives = {0}", totalPositive / countPositive);                                                    
		}
		public static void sumArray() {
			float[] numbers = new float[1000];
			float total = 0.0f;

			int countArray = 0;
			string ent;

			Console.Write ("Enter a number: ");
			ent = Console.ReadLine ();

			while (ent != "end") {
				numbers [countArray] = Convert.ToSingle (ent);
				total += numbers [countArray];
				countArray++;
				Console.WriteLine ("Sum = {0}", total);
				Console.Write ("Enter a number: ");
				ent = Console.ReadLine ();
			}

			Console.Write ("The number are: ");
			for (int i = 0; i < countArray; i++)
				Console.Write ("{0} ", numbers [i]);
			Console.WriteLine ();
			Console.WriteLine ("The sume is: {0}", total);
		}
		public static void twoDimensionArray() {
			float[ , ] puntuation = new float[2,10];
			for (int i = 0; i < 2; i++) {
				for (int j = 0; j < 10; j++) {
					Console.WriteLine ("Enter the puntuation {0} group {1}: ", j+1, i+1);
					puntuation[i,j] = Convert.ToSingle( Console.ReadLine() );
				}
			}
			for (int i=0; i<2; i++) {
				float total = 0.0f;
				for (int j=0; j<10; j++) {
					total += puntuation[i,j];
				}
				Console.WriteLine ("Average group {0} is {1}", i+1, total/10);
			}
		}
		public static void statistics() {
			float[] numbers = new float[1000];
			int count=0;
			float max = 0.0f, min = 0.0f, total = 0.0f, searchNumber = 0.0f;
			bool found=false;

			int option=0;
			do {
				Console.WriteLine ("1. Add");
				Console.WriteLine ("2. Show");
				Console.WriteLine ("3. Search");
				Console.WriteLine ("4. Statistics");
				Console.WriteLine ("5. Exit");

				option = Convert.ToInt32(Console.ReadLine());
				if (option != 5) {
					switch (option) {
					case 1: // Add
						Console.WriteLine ("Enter a number: ");
						numbers[count] = Convert.ToSingle( Console.ReadLine());
						max = numbers[count];
						min = numbers[count];
						total += numbers[count];
						count++;
						if (max < numbers[count])
							max = numbers[count];
						if (min > numbers[count])
							min = numbers[count];
						break;
					case 2: // Show
						for (int i = 0;i < count;i++)
							Console.WriteLine("{0} ", numbers[i]);
						break;
					case 3: // Search
						Console.WriteLine ("Enter a number for search: ");
						searchNumber = Convert.ToSingle( Console.ReadLine());

						int index=0;
						for (int i = 0;i < count;i++)
							if (numbers[i] == searchNumber) {
								index = i;
								found = true;
							}
						if (found)
							Console.WriteLine ("Number {0} found a amount of {1} ", index+1, numbers[index]);
						else {
							Console.WriteLine ("Not found");
							found = false;
						}   
						break;
					case 4: // Statistics
						Console.WriteLine ("Total data: {0}", count + 1);
						Console.WriteLine ("Sum: {0}", total);
						Console.WriteLine ("Average: {0}",total / ( count + 1 ));
						Console.WriteLine ("Min number: {0}", min);
						Console.WriteLine ("Max number: {0}", max);
						break;
					default:
						Console.WriteLine ("Error, option 1-5");
						break;
					}
				}
			}
			while(option!=5);                                              
		}
		struct point {
			public short x;  
			public short y;  
			public byte r;   
			public byte g;   
			public byte b;
		}
		public static void testStruct() {
			point p1, p2;

			Console.Write ("Enter X for first point: ");
			p1.x = Convert.ToInt16( Console.ReadLine() );
			Console.Write ("Enter Y for first point: ");
			p1.y = Convert.ToInt16( Console.ReadLine() );
			Console.Write ("Enter Red for first point: ");
			p1.r = Convert.ToByte( Console.ReadLine() );
			Console.Write ("Enter Green for first point: ");
			p1.g = Convert.ToByte( Console.ReadLine() );
			Console.Write ("Enter Blue for first point: ");
			p1.b = Convert.ToByte( Console.ReadLine() );
			Console.Write ("Enter X for second point: ");
			p2.x = Convert.ToInt16( Console.ReadLine() );
			Console.Write ("Enter Y for second point: ");
			p2.y = Convert.ToInt16( Console.ReadLine() );
			Console.Write ("Enter Red for second point: ");
			p2.r = Convert.ToByte( Console.ReadLine() );
			Console.Write ("Enter Green for second point: ");
			p2.g = Convert.ToByte( Console.ReadLine() );
			Console.Write ("Enter Blue for second point: ");
			p2.b = Convert.ToByte( Console.ReadLine() );

			Console.WriteLine ("P1 is located in ({0},{1}), colour ({2},{3},{4})", p1.x, p1.y, p1.r, p1.g, p1.b);
			Console.WriteLine ("P2 is located in ({0},{1}), colour ({2},{3},{4})", p2.x, p2.y, p2.r, p2.g, p2.b);
		}
		public static void structArray() {
			point[] p = new point[1000];

			Console.Write ("Enter X for first point: ");
			p[0].x = Convert.ToInt16( Console.ReadLine() );
			Console.Write ("Enter Y for first point: ");
			p[0].y = Convert.ToInt16( Console.ReadLine() );
			Console.Write ("Enter Red for first point: ");
			p[0].r = Convert.ToByte( Console.ReadLine() );
			Console.Write ("Enter Green for first point: ");
			p[0].g = Convert.ToByte( Console.ReadLine() );
			Console.Write ("Enter Blue for first point: ");
			p[0].b = Convert.ToByte (Console.ReadLine ());
			Console.Write ("Enter X for second point: ");
			p[1].x = Convert.ToInt16( Console.ReadLine() );
			Console.Write ("Enter Y for second point: ");
			p[1].y = Convert.ToInt16( Console.ReadLine() );
			Console.Write ("Enter Red for second point: ");
			p[1].r = Convert.ToByte( Console.ReadLine() );
			Console.Write ("Enter Green for second point: ");
			p[1].g = Convert.ToByte( Console.ReadLine() );
			Console.Write ("Enter Blue for second point: ");
			p[1].b = Convert.ToByte( Console.ReadLine() );

			Console.WriteLine ("P1 is located in ({0},{1}), colour ({2},{3},{4})", p[0].x, p[0].y, p[0].r, p[0].g, p[0].b);
			Console.WriteLine ("P2 is located in ({0},{1}), colour ({2},{3},{4})", p[1].x, p[1].y, p[1].r, p[1].g, p[1].b);
		}
		public static void structMenu() {
			point[] p = new point[1000];
			bool Finish = false;
			int countArray = 0;
			int TotalX = 0;
			int TotalY = 0;
			do {
				Console.WriteLine ("1.Add data for one point");
				Console.WriteLine ("2.Display all the entered points");
				Console.WriteLine ("3.Calculate (and display) the average values for x and y");
				Console.WriteLine ("0.Exit the program");
				Console.Write ("Enter a number: ");
				byte response = Convert.ToByte( Console.ReadLine() );

				switch (response) {
				case 1:
					Console.WriteLine ();
					Console.Write ("Enter a number for point x: ");
					p[countArray].x = Convert.ToByte(Console.ReadLine());
					TotalX += p[countArray].x;
					Console.WriteLine ();
					Console.Write ("Enter a number for point y: ");
					p[countArray].y = Convert.ToByte(Console.ReadLine());
					TotalY += p[countArray].y;
					Console.WriteLine();
					countArray++;
					break;
				case 2:
					if (countArray > 0)
					{
						for (int i = 0; i < countArray; i++)
						{
							Console.WriteLine ("Value x{0}: {1}", i+1, p[i].x);
							Console.WriteLine ("Value y{0}: {1}", i+1, p[i].y); 
						}
					}
					else
						Console.WriteLine ("No hay datos");
					break;
				case 3:
					if (countArray > 0)
					{
						Console.WriteLine ("Average x: {0}", TotalX / countArray);
						Console.WriteLine ("Average y: {0}", TotalY / countArray);
					}
					else
						Console.WriteLine ("No hay datos");
					break;
				case 0:
					Finish = true;
					break;
				default:
					break;
				}
			}
			while (!Finish);
		}
		struct book {
			public string title;
			public string author;
		}
		public static void bookDB() {
			int capacity = 1000;  
			book [] books = new book [capacity];  
			bool repeat = true;  
			string option;     
			int amount = 0;      
			string search;     
			bool found;       

			do {
				Console.WriteLine ();
				Console.WriteLine ("Books database");
				Console.WriteLine ();
				Console.WriteLine ("1- Add a new book");
				Console.WriteLine ("2- Display all books");
				Console.WriteLine ("3- Exact search for any book");
				Console.WriteLine ("4- Partial search");
				Console.WriteLine ("5- Delete a book");
				Console.WriteLine ("0- Exit");
				Console.Write ("Enter an option: ");
				option = Console.ReadLine();

				switch (option) {
				case "1": // Add a new book
					if (amount < capacity ) {
						Console.WriteLine ("Enter data for book {0}", amount+1);
						Console.Write ("Enter the name of the book: ");
						books[amount].title= Console.ReadLine();

						Console.Write ("Enter the author: ");
						books[amount].author= Console.ReadLine();

						amount++;
						Console.WriteLine ();
					}
					else
						Console.WriteLine ("Database full");
					break;
				case "2":  // Display all books
					if (amount == 0)
						Console.WriteLine ("No data to search");
					else {
						for(int i = 0;i < amount;i++)
							Console.WriteLine ("{0}: Title = {1},  Author = {2}", i+1, books[i].title, books[i].author);
						Console.WriteLine ();
					}
					break;
				case "3":  // Exact search
					Console.WriteLine ("Enter the name of the book");
					search = Console.ReadLine();
					found = false;
					for (int i = 0;i < amount;i++)
						if(books[i].title==search) {
							Console.WriteLine ("Book {0} found", books[i].title);
							found = true;
						}
					if (! found)
						Console.WriteLine ("Not found!");
					Console.WriteLine ();
					break;
				case "4":  // Partial search
					Console.WriteLine ("Enter the search string");
					search = Console.ReadLine();
					found = false;
					for (int i = 0;i < amount;i++)
						if(books[i].title.ToUpper().Contains(search.ToUpper()) || books[i].author.ToUpper().Contains(search.ToUpper())) {
							Console.WriteLine ("{0} found in {1}", search, books[i].title);
							found = true;
						}
					Console.WriteLine ();
					if (! found)
						Console.WriteLine ("Not found!");
					break;
				case "5":  // Delete
					if (amount == 0)
						Console.WriteLine ("No data to delete");
					else {        
						Console.WriteLine ("Enter the number of book to delete (1 to {0})", amount);
						int posToDelete = Convert.ToInt32(Console.ReadLine()) - 1;
						for (int i = posToDelete; i < amount - 1; i++)
							books[i] = books[i+1];
						amount--;
					}
					break;
				case "0":  // End
					repeat = false;
					break;
				default:
					Console.WriteLine ();
					Console.WriteLine ("Wrong option. Please re-enter\n");
					break;
				}

			}
			while(repeat);
		}
		public static void triangleName() {
			string name; 

			Console.Write ("Enter your name: ");
			name = Console.ReadLine();

			for (int i = 1; i <= name.Length; i++){
				Console.WriteLine(name.Substring(0,i));
			}
		}
		public static void rectangleName() {
			int width, height;   
			int row, column; 
			string name;

			Console.Write ("Enter your name: ");
			name = Console.ReadLine();

			Console.Write ("Enter the desired width: ");
			width = Convert.ToInt32 (Console.ReadLine ());

			Console.Write ("Enter the desired height: ");
			height = Convert.ToInt32 (Console.ReadLine ());

			for (row = 0; row < height; row++) {
				for (column = 0; column < width; column++) {
					if (row > 0 && row < height - 1 && column > 0 && column < width - 1) {
						for (int i = 0; i < name.Length; i++)
							Console.Write (" ");
					} else
						Console.Write (name);
				}
				Console.WriteLine ();
			}
		}
		public static void centeredTriangle() {
			string name;

			Console.Write ("Enter your name: ");
			name = Console.ReadLine ();
			if (name.Length % 2 == 0)
				name += " ";

			int position = name.Length / 2;
			int maxRows = name.Length / 2 + 1;
			int amount = 1;

			for (int i = 0; i < maxRows; i++) {
				for (int j = 0; j < position; j++)
					Console.Write (" ");

				Console.WriteLine (name.Substring (position, amount));
				position--;
				amount += 2;
			}
		}
		struct city {
			public string name;
			public uint inhabitants;
		}
		public static void cityDB() {
			int maxCities= 500;
			city[] cities = new city[maxCities];
			int amount = 0;
			int currentCityNumber;        
			string option;                
			string textToSearch;
			bool found;
			string textToModify;
			bool finished = false;        

			do {
				Console.WriteLine ();
				Console.WriteLine ("Cities database");
				Console.WriteLine ();
				Console.WriteLine ("1.- Add a new city");
				Console.WriteLine ("2.- View all cities");
				Console.WriteLine ("3.- Modify a record");
				Console.WriteLine ("4.- Insert a new record");
				Console.WriteLine ("5.- Delete a record");
				Console.WriteLine ("6.- Search in the records");
				Console.WriteLine ("7.- Correct the capitalization of the names");
				Console.WriteLine ("0.- Exit");
				Console.WriteLine ();
				Console.Write ("Choose an option: ");
				option = Console.ReadLine ();

				switch (option) {
				case "0":
					finished = true;
					break;

				case "1":
					if (amount > maxCities - 1)
						Console.WriteLine ("the database is full");
					else {
						Console.WriteLine ("Entering data for city number {0}", amount + 1);
						Console.Write ("Enter the city name: ");
						cities [amount].name = Console.ReadLine ();
						Console.Write ("Enter the inhabitants numbers: ");
						cities [amount].inhabitants = Convert.ToUInt32 (Console.ReadLine ());
						Console.WriteLine ("The data was entered correctly");
						amount++;
					}
					break;

				case "2":
					for (int i = 0; i < amount; i++) {
						Console.WriteLine ("{0}: {1}, {2} inhabitants", i + 1, cities [i].name, cities [i].inhabitants);
					}
					Console.WriteLine ();
					break;

				case "3":
					Console.Write ("Enter the city number: ");
					currentCityNumber = Convert.ToInt32 (Console.ReadLine ());

					Console.WriteLine ("Enter a new data for a city number: {0}", currentCityNumber);
					Console.Write ("City name (was {0}; hit ENTER to leave as is): ", cities [currentCityNumber - 1].name);
					textToModify = Console.ReadLine ();
					if (textToModify != "")
						cities [currentCityNumber - 1].name = textToModify;
					Console.Write ("Inhabitants (was {0}; hit ENTER to leave as is): ", cities [currentCityNumber - 1].inhabitants);
					textToModify = Console.ReadLine ();
					if (textToModify != "")
						cities [currentCityNumber - 1].inhabitants = Convert.ToUInt32 (textToModify);
					Console.WriteLine ();
					break;

				case "4":

					if (amount > maxCities - 1)
						Console.WriteLine ("The database is full");
					else {
						Console.Write ("Enter the number of the city to modify: ");
						currentCityNumber = Convert.ToInt32 (Console.ReadLine ());

						Console.WriteLine ("Insert a new data at {0} position: ", currentCityNumber);
						amount++;
						for (int i = (int)amount; i > currentCityNumber - 1; i--) {
							cities [i] = cities [i - 1];
						}
						Console.Write ("City name: ");
						cities [currentCityNumber - 1].name = Console.ReadLine ();
						Console.Write ("Inhabitants: ");
						cities [currentCityNumber - 1].inhabitants = Convert.ToUInt32 (Console.ReadLine ());
					}
					break;

				case "5":
					Console.Write ("Enter the city number for delete: ");
					currentCityNumber = Convert.ToInt32 (Console.ReadLine ());
					Console.WriteLine ("Deleting the number {0}", currentCityNumber);
					for (int i = currentCityNumber - 1; i < amount; i++) {
						cities [i] = cities [i + 1];
					}
					amount--;
					break;

				case "6":
					Console.Write ("Enter the text to search: ");
					textToSearch = Console.ReadLine ();
					found = false;
					for (int i = 0; i < amount; i++) {
						if (cities [i].name.ToUpper ().IndexOf (textToSearch.ToUpper ()) >= 0) {
							Console.WriteLine ("{0} found in {1}", textToSearch, cities [i].name);
							found = true;
						}
					}
					if (!found)
						Console.WriteLine ("Not found.");
					break;

				case "7":
					for (int i = 0; i < amount; i++) {
						// First, the whole name to lower case
						string lowerCaseName = cities [i].name.ToLower ();
						// then, first letter to uppercase
						string correctedName = lowerCaseName.Substring (0, 1).ToUpper () + lowerCaseName.Substring (1);
						// and then the letters after a space
						for (int j = 1; j < correctedName.Length - 2; j++) {
							if (correctedName [j] == ' ')
								correctedName = correctedName.Substring (0, j) + " " +
								correctedName.Substring (j + 1, 1).ToUpper () +
								correctedName.Substring (j + 2);
						}
						cities [i].name = correctedName;
					}
					break;

				default:
					Console.WriteLine ("Wrong option ");
					break;

				}

			} while (!finished);
		}
		public static void banner() {
			string[] alphabet =  {  
				"         ###  ### ###  # #   ##### ###   #  ##     ###  ", 
				"         ###  ### ###  # #  #  #  ## #  #  #  #    ###  ", 
				"         ###   #   # ########  #   ### #    ##      #   ", 
				"          #            # #   #####    #    ###     #    ", 
				"                     #######   #  #  # ####   # #       ", 
				"         ###           # #  #  #  # #  # ##    #        ", 
				"         ###           # #   ##### #   ### #### #       ", 
				"   ##    ##                                            #", 
				"  #        #   #   #    #                             # ", 
				" #          #   # #     #                            #  ", 
				" #          # ####### #####   ###   #####           #   ", 
				" #          #   # #     #     ###           ###    #    ", 
				"  #        #   #   #    #      #            ###   #     ", 
				"   ##    ##                   #             ###  #      ", 
				"  ###     #    #####  ##### #      ####### ##### #######", 
				" #   #   ##   #     ##     ##    # #      #     ##    # ", 
				"#     # # #         #      ##    # #      #          #  ", 
				"#     #   #    #####  ##### #    # ###### ######    #   ", 
				"#     #   #   #            ########      ##     #  #    ", 
				" #   #    #   #      #     #     # #     ##     #  #    ", 
				"  ###   ##### ####### #####      #  #####  #####   #    ", 
				" #####  #####    #     ###      #           #     ##### ", 
				"#     ##     #  ###    ###     #             #   #     #", 
				"#     ##     #   #            #     #####     #        #", 
				" #####  ######         ###   #                 #     ## ", 
				"#     #      #   #     ###    #     #####     #     #   ", 
				"#     ##     #  ###     #      #             #          ", 
				" #####  #####    #     #        #           #       #   ", 
				" #####    #   ######  ##### ###### ############## ##### ", 
				"#     #  # #  #     ##     ##     ##      #      #     #", 
				"# ### # #   # #     ##      #     ##      #      #      ", 
				"# # # ##     ####### #      #     ######  #####  #  ####", 
				"# #### ########     ##      #     ##      #      #     #", 
				"#      #     ##     ##     ##     ##      #      #     #", 
				" ##### #     #######  ##### ###### ########       ##### ", 
				"#     #  ###        ##    # #      #     ##     ########", 
				"#     #   #         ##   #  #      ##   ####    ##     #", 
				"#     #   #         ##  #   #      # # # ## #   ##     #", 
				"#######   #         ####    #      #  #  ##  #  ##     #", 
				"#     #   #   #     ##  #   #      #     ##   # ##     #", 
				"#     #   #   #     ##   #  #      #     ##    ###     #", 
				"#     #  ###   ##### #    # ########     ##     ########", 
				"######  ##### ######  ##### ########     ##     ##     #", 
				"#     ##     ##     ##     #   #   #     ##     ##  #  #", 
				"#     ##     ##     ##         #   #     ##     ##  #  #", 
				"###### #     #######  #####    #   #     ##     ##  #  #", 
				"#      #   # ##   #        #   #   #     # #   # #  #  #", 
				"#      #    # #    # #     #   #   #     #  # #  #  #  #", 
				"#       #### ##     # #####    #    #####    #    ## ## ", 
				"#     ##     ######## ##### #       #####    #          ", 
				" #   #  #   #      #  #      #          #   # #         ", 
				"  # #    # #      #   #       #         #  #   #        ", 
				"   #      #      #    #        #        #               ", 
				"  # #     #     #     #         #       #               ", 
				" #   #    #    #      #          #      #               ", 
				"#     #   #   ####### #####       # #####        #######", 
				"  ###                                                   ", 
				"  ###     ##   #####   ####  #####  ###### ######  #### ", 
				"   #     #  #  #    # #    # #    # #      #      #    #", 
				"        ###### #    # #      #    # #      #      #  ###", 
				"    #   #    # #####  #      #    # #####  #####  #     ", 
				"        #    # #    # #    # #    # #      #      #    #", 
				"        #    # #####   ####  #####  ###### #       #### ", 
				"                                                        ", 
				" #    #    #        # #    # #      #    # #    #  #### ", 
				" #    #    #        # #   #  #      ##  ## ##   # #    #", 
				" ######    #        # ####   #      # ## # # #  # #    #", 
				" #    #    #        # #  #   #      #    # #  # # #    #", 
				" #    #    #   #    # #   #  #      #    # #   ## #    #", 
				" #    #    #    ####  #    # ###### #    # #    #  #### ", 
				"                                                        ", 
				" #####   ####  #####   ####   ##### #    # #    # #    #", 
				" #    # #    # #    # #         #   #    # #    # #    #", 
				" #    # #    # #    #  ####     #   #    # #    # #    #", 
				" #####  #  # # #####       #    #   #    # #    # # ## #", 
				" #      #   #  #   #  #    #    #   #    #  #  #  ##  ##", 
				" #       ### # #    #  ####     #    ####    ##   #    #", 
				"                       ###     #     ###   ##    # # # #", 
				" #    #  #   # ###### #        #        # #  #  # # # # ", 
				"  #  #    # #      #  #        #        #     ## # # # #", 
				"   ##      #      #  ##                 ##        # # # ", 
				"   ##      #     #    #        #        #        # # # #", 
				"  #  #     #    #     #        #        #         # # # ", 
				" #    #    #   ######  ###     #     ###         # # # #"
			};

			Console.Write ("Tell a string:");
			string Entry = Console.ReadLine();

			byte j=1;
			char Letter;
			int[] CodeAscii = new int[Entry.Length];

			for (int i = 0; i < Entry.Length; i++) {
				Letter = Convert.ToChar(Entry.Substring(i, j));
				CodeAscii[i] = Convert.ToInt32(Letter);
			}

			int AnchorLetter = 7, AlterLetter = 7;
			int numberAscii = 32;
			int countLine = 0, countLetter = 0, countPosition = 0;
			bool LetterEncoded = false;
			string[] board = new string[AlterLetter];

			for (int i = 0; i < CodeAscii.Length; i++) { 
				for (int row = 0; row < alphabet.Length; row++) {
					if (countLetter == 8) {
						row += AlterLetter-1;
						countLetter = 0;
						countPosition = 0;
					}
					while ((!LetterEncoded) && (countLetter < 8)) {
						if (CodeAscii[i] == numberAscii)
							LetterEncoded = true;
						else {
							numberAscii++;
							countPosition += AnchorLetter;
							countLetter++;
						}   
					}
					if ( (LetterEncoded) && (countLine < 7) ) {
						if (i > 0)
							board[countLine] = board[countLine] + alphabet[row].Substring(countPosition, AnchorLetter);
						else
							board[countLine] = alphabet[row].Substring(countPosition, AnchorLetter);
						countLine++;
					}
				}
				countLine = 0;
				numberAscii = 32;
				LetterEncoded = false;
				countPosition = 0;
				countLetter = 0;
			}  

			for (int i = 0; i < board.Length; i++)
				Console.WriteLine (board[i]);
		}
		public static void triangleE() {
			Console.Write ("Tell a string:");
			string Entry = Console.ReadLine();
			for (int i=Entry.Length-1; i>=0; i--) {
				for (int c=0; c<i; c++)
					Console.Write ("_");
				Console.WriteLine (Convert.ToString (Entry.Substring (i, Entry.Length-i)));
			}

		}
		public static void stringManipulation() {
			Console.Write ("Tell a string: ");
			string Entry = Console.ReadLine();
			string result = Entry.Replace("a", "A");
			Console.WriteLine (result);
			Console.WriteLine (UppercaseFirst(Entry));
		}
		public static string UppercaseFirst(string s) {
			return char.ToUpper(s[0]) + s.Substring(1);
		}
		struct person {
			public string Name;
			public date BirthDate;
		}
		struct date {
			public int Day;
			public int Month;
			public int Year;
		}  
		public static void nestStruct() {
			int total = 2;
			person[] p = new person[total];

			for (int i = 0; i < total; i++) {
				Console.Write ("Enter name: ");
				string Name = Console.ReadLine();
				p[i].Name = Name;
				Console.Write ("Enter day: ");
				p[i].BirthDate.Day = Convert.ToInt32(Console.ReadLine());
				Console.Write ("Enter month: ");
				p[i].BirthDate.Month = Convert.ToInt32(Console.ReadLine());
				Console.Write ("Enter year: ");
				p[i].BirthDate.Year = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine ();
			}
			for (int i=0; i<total; i++) {
				Console.WriteLine ("Name: {0}, Date of Birth: {1}/{2}/{3}", p[i].Name, p[i].BirthDate.Day, p[i].BirthDate.Month, p[i].BirthDate.Year);
			}
		}
		public static void sortedData() {
			int total = 9;
			int[] data = new int[total];
			int i,j,aux; 

			for (i=0; i<total; i++) {
				Console.Write ("Enter number {0}: ", i+1);
				data[i] = Convert.ToInt32(Console.ReadLine());
			}   
			for(i=0; i<total-1; i++) {
				for(j=i+1; j<total; j++) {
					if (data[i]>data[j]) {
						aux = data[i];
						data[i] = data[j];
						data[j] = aux;
					}
				}
			}
			Console.Write("Sorted:");

			foreach (int value in data) 
				Console.Write("{0} ", value);
		}
		public static void screen2D() {
			char[,] position = new char[20,70];

			Random generator = new Random ();
			for (int i = 0; i<80; i++)
				position [generator.Next (0, 20), generator.Next (0, 70)] = 'X';

			for (int row = 0; row < 20; row++) {
				for (int col = 0; col < 70; col++) {
					if (position [row, col] == 'X')
						Console.Write (position [row, col]);
					else
						Console.Write (' ');
				}
				Console.WriteLine ();
			}
		}
	}
}

