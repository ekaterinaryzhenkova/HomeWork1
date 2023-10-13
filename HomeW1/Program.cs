using HomeW1;

class Program
{
    static void Main() 
    {
        Bag studentBag = new Bag(0, 0, 10);
        Student student = new Student("Иван", 20, studentBag);
        int pieces = 0;
        int bottles = 0;

        while (true)
        {
            Console.WriteLine("Введите количество кусков пиццы:");
            pieces = int.Parse(Console.ReadLine());

            if (pieces < 0 || pieces > 40)
            {
                continue;
            }

            break;
        }

        while (true)
        {
            Console.WriteLine("Введите количество бутылок пива:");
            bottles = int.Parse(Console.ReadLine());

            if (bottles < 0 || bottles > 40)
            {
                continue;
            }

            break;
        }

        if (!student.StudentBag.AddPizza(pieces))
        {
            Console.WriteLine("Не удалось добавить столько кусков пиццы, сумка переполнена");
            return;
        }

       
        if (!student.StudentBag.AddBeer(bottles))
        {
            Console.WriteLine("Не удалось добавить столько банок пива, сумка переполнена");
            return;
        }

        Console.WriteLine($"Студент {student.Name} взял {pieces} кусков пиццы и {bottles} банок пива");
        Console.WriteLine($"Степень сытости: {student.CountSatiety()}");
        Console.WriteLine($"Степень алкогольного опьянения: {student.CountDrunk()}");
    }
}
    
