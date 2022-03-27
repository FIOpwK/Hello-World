using Humanizer;

var text = "Quantities:";
Console.WriteLine(text);


//get the length of text
System.Console.WriteLine(text.Length);

static void HumaizeQuantities()
{
    System.Console.WriteLine("cases:".ToQuantity(0));
    System.Console.WriteLine("case:".ToQuantity(1));
    System.Console.WriteLine("cases:".ToQuantity(5));
}

HumaizeQuantities();