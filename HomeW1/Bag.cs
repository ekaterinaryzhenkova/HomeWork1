namespace HomeW1;

class Bag
{
    public int PizzaPieces { get; set; }
    public int BeerBottles { get; set;}
    public double Capacity { get; set; }

    private const double PizzaWeight = 0.3;
    private const double BeerBottleWeight = 0.5;

    public Bag(int pizzaPieces, int beerBottles, double capacity) 
    { 
        PizzaPieces = pizzaPieces;
        BeerBottles = beerBottles;
        Capacity = capacity;
    }

    public bool AddPizza(int pieces)
    {
        double totalVolume = (pieces + PizzaPieces) * PizzaWeight + BeerBottles * BeerBottleWeight;

        if (totalVolume <= Capacity ) 
        {
            PizzaPieces += pieces;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool AddBeer(int bottles)
    {
        double totalVolume = PizzaPieces * PizzaWeight + (BeerBottles + bottles) * BeerBottleWeight;

        if (totalVolume <= Capacity)
        {
            BeerBottles += bottles;
            return true;
        }
        else
        {
            return false;
        }
    }
}
