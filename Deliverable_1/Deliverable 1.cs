using System;


class Program

{
    static void Main(string[] args)
    {
        bool wantMoreSandwiches = true;

        while(wantMoreSandwiches)
        {
            MakeSandwichOrder();
            //ask if they want another sandwich?
            Console.WriteLine("Would you like to restart and make more sandwiches?");
            //if not, set wantMoreSandwiches to false
            string response = ReadKey();
            if(response == "y" || response == "yes")
            {
                //allow program to continue in loop.
            }
            else
            {
                wantMoreSandwiches = false;
            }
        }

        Console.WriteLine("Good Bye.");

        ////need to display the conversion including the 3 above.

        //Console.WriteLine("Would you like to restart?" + "y/num");
        ////lines below are to have input from user y or Y to restart program; n or N is to exit program
        //{
        //    while ((Console.ReadLine() == "Y") || (Console.ReadLine() == "y"))

        //        while ((Console.ReadLine() == "N") || (Console.ReadLine() == "n"))

        //            while ((Console.ReadLine() == "Y") && (Console.ReadLine() == "y"))

        //                if ((Console.ReadLine() == "Y")) ;

        //                else Console.WriteLine("Good Bye.");
        //}
    }

    static void MakeSandwichOrder()
    {
        Console.WriteLine("How many people are we making PB&J sandwiches for?");

        int sandwichCount = int.Parse(ReadKey());

        int breadSlices = sandwichCount * 2;
        int breadLoaves = RoundUp(breadSlices, 28);

        int peanutButterTbsp = sandwichCount * 2;
        int peanutButterJars = RoundUp(peanutButterTbsp, 32);

        int jellyTeaspoons = sandwichCount * 4;
        int jellyJars = RoundUp(jellyTeaspoons, 48);

        Console.WriteLine("you need...");
        Console.WriteLine(breadSlices + " slices of bread");
        Console.WriteLine(peanutButterTbsp + " tablespoons of peanut butter");
        Console.WriteLine(jellyTeaspoons + " teaspoons of jelly");

        Console.WriteLine();

        Console.WriteLine("which is...");
        Console.WriteLine(breadLoaves + " loaves of bread");
        Console.WriteLine(peanutButterJars + " jars of peanut butter");
        Console.WriteLine(jellyJars + " jars of jelly");
    }

    static void MakeSandwichOrderV2()
    {
        int sandwichCount = int.Parse(ReadKey());
        List<Sandwich> sandwiches = new List<Sandwich>();
        for(int i = 1; 1 <= sandwichCount; i++)
        {
            sandwiches.Add(new Sandwich());
        }

        WriteSandwichOrder(sandwiches);
    }

    static void MakeSandwichOrderV3()
    {
        var order = new SandwichOrder();
        order.TakeOrder();
        order.WriteOrder();
    }

    static void WriteSandwichOrder(List<Sandwich> sandwiches)
    {
        int breadLoaves = sandwiches.Sum(u => u.BreadSlices) / 28;
        int peanutButterJars = sandwiches.Sum(u => u.PeanutButterTbsp) / 32;
        int jellyJars = sandwiches.Sum(u => u.JellyTeaspoons) / 48;
    }

    static string ReadKey()
    {
        return Console.ReadLine();
    }

    static int RoundUp(int needed, int perContainer)
    {
        decimal partialContainers = Convert.ToDecimal(needed) / Convert.ToDecimal(perContainer);
        return (int)Math.Ceiling(partialContainers);
    }
}


class SandwichOrder
{
    public int SandwichesOrdered { get; set; }

    public List<Sandwich> Sandwiches { get; set; }

    public void TakeOrder()
    {

    }

    public void WriteOrder()
    {

    }
}

class Sandwich
{
    public int SandwichCount { get { return 1; } }
    public int BreadSlices { get { return 3; } }
    public int PeanutButterTbsp { get { return 3; } }
    public int JellyTeaspoons { get { return 5; } }
}