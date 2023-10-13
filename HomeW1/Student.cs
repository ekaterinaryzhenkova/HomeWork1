namespace HomeW1;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Bag StudentBag { get; set; }

    public Student(string name, int age, Bag studentBag)
    {
        Name = name;
        Age = age;
        StudentBag = studentBag;
    }

    public string CountSatiety()
    {
        int pizzaPieces = StudentBag.PizzaPieces;

        if (Age < 18 && pizzaPieces < 2)
        {
            return "голоден";
        }
        
        if (Age < 18 && pizzaPieces >= 2 && pizzaPieces <= 5)
        {
            return "в самый раз";
        }
        
        if (Age < 18 && pizzaPieces > 5)
        {
            return "переел";
        }
        
        if (Age >= 18 && pizzaPieces < 4)
        {
            return "голоден";
        }
        
        if (Age >= 18 && pizzaPieces >= 4 && pizzaPieces <= 8)
        {
            return "в самый раз";
        }
        else
        {
            return "переел";
        }
    }

    public string CountDrunk()
    {
        int beerBottles = StudentBag.BeerBottles;

        if (Age < 18 && beerBottles < 1)
        {
            return "трезв";
        }
        
        if (Age < 18 && beerBottles >= 1 && beerBottles <= 3)
        {
            return "немного опьянел";
        }

        if (Age < 18 && beerBottles > 3)
        {
            return "сильно опьянел";
        }
        
        if (Age >= 18 && beerBottles < 3)
        {
            return "трезв";
        }
        
        if (Age >= 18 && beerBottles >= 3 && beerBottles <= 6)
        {
            return "немного опьянел";
        }
        else
        {
            return "сильно опьянел";
        }
    }
}
