using HomeW1;

class Program
{

    static int InputCheck(string input)
    {
        int result = 0;

        while(!int.TryParse(input, out result))
        {
            Console.WriteLine("Повторите попытку");
            input = Console.ReadLine();
        }

        return result;
    }

    static void Main()
    {
        Bag studentBag = new Bag(0, 0, 10);
        Student student = new ("Иван", 20, studentBag);
        int pieces = 0;
        int bottles = 0;

        Console.WriteLine("Введите количество кусков пиццы:");
        pieces = InputCheck(Console.ReadLine());

        Console.WriteLine("Введите количество бутылок пива:");
        bottles = InputCheck(Console.ReadLine());

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
