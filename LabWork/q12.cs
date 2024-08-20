using System;

class MarksStatistics
{
    /*
    static void Main()
    {
        // Taking input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Create an array to store marks
        double[] marks = new double[numStudents];

        // Input marks from the user
        for (int i = 0; i < numStudents; i++)
        {
            Console.Write($"Enter marks for student {i + 1}: ");
            marks[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Initialize min, max, and sum
        double min = marks[0];
        double max = marks[0];
        double sum = 0;

        // Calculate min, max, and sum
        for (int i = 0; i < numStudents; i++)
        {
            if (marks[i] < min)
            {
                min = marks[i];
            }

            if (marks[i] > max)
            {
                max = marks[i];
            }

            sum += marks[i];
        }

        // Calculate average
        double average = sum / numStudents;

        // Output the results
        Console.WriteLine($"\nMinimum Marks: {min}");
        Console.WriteLine($"Maximum Marks: {max}");
        Console.WriteLine($"Average Marks: {average:F2}"); // Format to 2 decimal places
        Console.ReadLine();
    }*/
}
