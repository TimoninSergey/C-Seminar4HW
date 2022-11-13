int Degreeing (int A, int B)
{
	int count = 1;
	int result = A;
	while (count < B) 
		{
		result = result * A;
		count++;
		}
	return result;
}

Console.WriteLine("Введите основание");
int BaseNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int DegreeNumber = int.Parse(Console.ReadLine());

int Answer = Degreeing (BaseNumber, DegreeNumber);
Console.WriteLine("Ответ равен");
Console.WriteLine(Answer);