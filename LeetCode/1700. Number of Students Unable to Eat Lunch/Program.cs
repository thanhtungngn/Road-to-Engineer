// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Console.WriteLine(CountStudents(students : [1, 1, 0, 0], sandwiches : [0, 1, 0, 1]));
Console.WriteLine(CountStudents(students: [1, 1, 1, 0, 0, 1], sandwiches: [1, 0, 0, 0, 1, 1]));

int CountStudents(int[] students, int[] sandwiches)
{
    var queueStudent = new Queue<int>();

    for (int i = 0; i < students.Length; i++)
    {
        queueStudent.Enqueue(students[i]);
    }

    var end = true;
    var index = 0;
    var retry = 0;
    while (end && queueStudent.Count > 0)
    {
        var student = queueStudent.Dequeue();
        if(student == sandwiches[index])
        {
            index++;
            retry = 0;
        }
        else
        {
            queueStudent.Enqueue(student);
            retry++;
        }
        if(retry == queueStudent.Count)
        {
            return queueStudent.Count;
        }
    }
    return queueStudent.Count;
}