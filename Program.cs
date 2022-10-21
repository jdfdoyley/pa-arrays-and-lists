/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: October 21, 2022
* CIS214 Performance Assessment - Calculations & Unique Numbers
*
* The main application class must meet the following requirements
* - Print a line that states "Your Name - Week 3 PA Calculations & Unique
*   Numbers"
* - Get 10 integer values from the user and store them in an array
* - Store the unique numbers in a List
*   - HINT: use the List "contains" method to see if the value is already in
*     the List
*   - This can be done while gathering the values from the user or after all
*     values are in the array
* - Write a method to calculate the total (sum) of all elements in a collection
*   - Method to calculate the sum of integers in an array
*   - Overloaded method to calculate the sum of integers in an List
* - Display the following information for both the array and the List objects
*   - Count of elements in the collection
*   - Sum of all elements in the collection
*   - Average of values in the collection
\******************************************************************************/

public class CalUniqueNumbers
{
    static void Main(string[] args)
    {
        // Print header line
        Console.WriteLine(
            "\nJason D'Oyley - Week 3 PA Calculations & Unique\n"
        );

        // Get 10 integer values from the user and store them in an array
        int[] numValues = new int[10];
        List<int> uniqueValues = new List<int>();
        int arrSum = 0;
        int lstSum = 0;

        for (int i = 0; i < numValues.Length; i++)
        {
            Console.Write("Please enter an integer value: ");
            string? val = Console.ReadLine();
            numValues[i] = Convert.ToInt32(val);

            // Add unique integer value if not already in list variable
            if (!uniqueValues.Contains(numValues[i]))
            {
                uniqueValues.Add(numValues[i]);
                lstSum += numValues[i];
            }

            arrSum += numValues[i];
        }

        // ARRAY: Count of elements in the collection
        Console.WriteLine(
            "\nThe count of integers entered is: {0}",
            numValues.Length
        );

        // ARRAY: Sum of all elements in the collection
        Console.WriteLine(
            "The sum of integers entered is: {0}",
            arrSum
        );

        // ARRAY: Average of values in the collection
        Console.WriteLine(
            "The average of integers entered is: {0}",
            (arrSum / numValues.Length)
        );

        // LIST: Count of elements in the collection
        Console.WriteLine(
            "\nThe count of unique integers entered is: {0}",
            uniqueValues.Count
        );

        // LIST: Sum of all elements in the collection
        Console.WriteLine(
            "The sum of unique integers entered is: {0}",
            lstSum
        );

        // LIST: Average of values in the collection
        Console.WriteLine(
            "The average of unique integers entered is: {0}",
            (lstSum / uniqueValues.Count)
        );
    }
}