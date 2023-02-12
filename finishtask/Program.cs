string[] Array1 = new string[8] {"result", "git", "run", "task", "nut", "push", "35", "rich"};
string[] Array2 = new string[Array1.Length];
void ChangeArray (string[] Array1, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
    if(Array1[i].Length <= 3)
        {
        Array2[count] = Array1[i];
        count++;
        }
    }
}
void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}
ChangeArray(Array1, Array2);
PrintArray(Array2);