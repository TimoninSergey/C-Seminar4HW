void MassiveCreator()
{
	double[] Numbers = new double [8];
	int count = 0;
	while (count < Numbers.Length) 
	{
		Console.WriteLine("Введите элемент массива номер " + count);
        double A = Convert.ToDouble(Console.ReadLine());
		Numbers[count] = A;
		count++;
    }

    int number = 0;
    while (number < Numbers.Length)
    {
        Console.WriteLine(Numbers[number]);
        number++;
    }
}

MassiveCreator();
