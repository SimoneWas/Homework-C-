//Task 2
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.

string[] studentsG1 = { "Lidija", "Sara", "Gorgi", "David", "Emilija" };
string[] studentsG2 = { "Simona", "Martina", "Martin", "Petko", "Trajko" };

Console.Write("Enter a number between 1 and 2: ");
int groupNumber = Convert.ToInt32(Console.ReadLine());

string[] selectedStudents;

if (groupNumber == 1)
{
    selectedStudents = studentsG1;
}
else
{
    selectedStudents = studentsG2;
}

Console.WriteLine("\nStudents in the selected group:");

foreach (string student in selectedStudents)
{
    Console.WriteLine(student);
}