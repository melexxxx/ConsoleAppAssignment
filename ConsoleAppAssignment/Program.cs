using System;
using System.Collections.Generic;
using System.Threading;

namespace StringArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array of strings
            string[] textArray = new string[5]; // Change the size as needed

            // Ask the user to input some text
            Console.WriteLine("Please enter some text:");

            // Loop to input text into the array
            for (int i = 0; i < textArray.Length; i++)
            {
                Console.Write($"Text {i + 1}: ");
                textArray[i] = Console.ReadLine();
            }

            // Loop to append user's text input to each string in the array
            for (int i = 0; i < textArray.Length; i++)
            {
                // Ask the user to input some additional text
                Console.WriteLine($"\nEnter additional text to append to Text {i + 1}: ");
                string additionalText = Console.ReadLine();

                // Append the additional text to the current string in the array with a space
                textArray[i] += " " + additionalText;
            }

            // Display the modified text
            Console.WriteLine("\nModified Text:");
            foreach (string text in textArray)
            {
                Console.WriteLine(text);
            }

            // Loop where the comparison is done using "<" operator
            for (int i = 0; i < textArray.Length; i++)
            {
                Console.WriteLine($"Text {i + 1}: {textArray[i]}");
            }

            // Loop where the comparison is done using "<=" operator
            for (int i = 0; i <= textArray.Length - 1; i++)
            {
                Console.WriteLine($"Text {i + 1}: {textArray[i]}");
            }

            Console.WriteLine("\nNow to the list part:");

            Thread.Sleep(2000);

            // Initialize a list of strings with unique items
            List<string> stringList = new List<string> { "apple", "banana", "orange", "grape", "pineapple" };

            // Variable to keep track of whether a match is found
            bool matchFound = false;

            while (!matchFound)
            {
                // Ask the user to input text to search for in the list
                Console.WriteLine("Please enter fruit to search for in the list:");

                // Read user input
                string searchText = Console.ReadLine();

                // Loop that iterates through the list and displays the index of the list item that contains matching text
                for (int i = 0; i < stringList.Count; i++)
                {
                    // Check if the current list item is exactly equal to the search text
                    if (stringList[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                    {
                        // Display the index of the list item containing the match
                        Console.WriteLine($"Matching text found at index {i}: {stringList[i]}");

                        // Set matchFound to true and exit the loop
                        matchFound = true;
                        break;
                    }
                }

                // If no match is found, inform the user and continue the loop
                if (!matchFound)
                {
                    Console.WriteLine("Your input is not on the list. Please try again.");
                }
            }

            Console.WriteLine("\nList with one chance to guess: ");
            Thread.Sleep(2000);
            // Initialize a list of strings with at least two identical items
            List<string> carList = new List<string> { "Toyota", "Honda", "Ford", "Toyota", "Chevrolet" };

            // Ask the user to input text to search for in the list
            Console.WriteLine("Please enter a car to search for in the list:");

            // Read user input
            string searchText2 = Console.ReadLine();

            // Variable to keep track of whether a match is found
            bool matchFound2 = false;

            // Loop that iterates through the list and displays the indices of the list that contain matching text
            for (int i = 0; i < carList.Count; i++)
            {
                // Check if the current list item is exactly equal to the search text
                if (carList[i].Equals(searchText2, StringComparison.OrdinalIgnoreCase))
                {
                    // Display the index of the list item containing the match
                    Console.WriteLine($"Matching car found at index {i}: {carList[i]}");

                    // Set matchFound to true as match is found
                    matchFound2 = true;
                }
            }

            // If no match is found, inform the user
            if (!matchFound2)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            Console.WriteLine("\nCheck for duplicates on the list:");
            Thread.Sleep(2000);

            // Create a list of strings with at least two identical items
            // Create a list of strings with at least two identical items
            List<string> bookTitles = new List<string>
            {
                "The Great Gatsby",
                "To Kill a Mockingbird",
                "1984",
                "The Catcher in the Rye",
                "The Great Gatsby"
            };

            // Create a dictionary to keep track of book titles and their occurrences
            Dictionary<string, int> bookOccurrences = new Dictionary<string, int>();

            // Iterate through each book title in the list
            foreach (string title in bookTitles)
            {
                // Check if the title already exists in the dictionary
                if (bookOccurrences.ContainsKey(title))
                {
                    // If the title already exists, it's a duplicate
                    Console.WriteLine($"{title} - this title is a duplicate");
                }
                else
                {
                    // If the title doesn't exist, it's unique
                    Console.WriteLine($"{title} - this title is unique");

                    // Add the title to the dictionary with occurrence count as 1
                    bookOccurrences[title] = 1;
                }
            }

            // Infinite Loop countdown
            Console.WriteLine("Duplicate check completed.");
            Console.WriteLine("Infinite loop launching in 3 seconds:");
            Thread.Sleep(1000);
            Console.WriteLine("Infinite loop launching in 2 seconds:");
            Thread.Sleep(2000);
            Console.WriteLine("Infinite loop launching in 1 second1:");
            Thread.Sleep(1000);



            // Infinite loop
            while (true)
            {
                // Infinite loop
                Console.WriteLine("This is an infinite loop! Press 'Ctrl + C' to exit.");
                // To exit the infinite loop, press 'Ctrl + C'
            }

        }
    }
}
