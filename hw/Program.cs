Console.WriteLine("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());

switch(task)
{
    case 1:
        task1();
        break;
    
    case 2:
        task2();
        break;
    
    default:
        break;
}


void task1()
{
    Console.WriteLine("Введите числа: ");
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
    int count = 0;  

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел: {count}");
    
}

void task2()
{
    Console.WriteLine("Введите b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b2");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    
    double x = -(k1 - k2) / (b1 - b2); 
    double y = b1 * x + k1;

    Console.WriteLine($"Точка пересечения - [{x}, {y}]");
}