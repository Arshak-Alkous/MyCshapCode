// See https://aka.ms/new-console-template for more information

using ConsoleStart;
using System;
using System.IO;

UseStringDemo();
void UseStringDemo()
{
    StringDemo demo = new StringDemo();
    string[] result= demo.SplitTextToArray();
    string printOutText = "";
    for (int i = 0; i < result.Length; i++)
    {
        printOutText+=result[i]+", ";
    }
    //Console.WriteLine(printOutText.TrimEnd(',',' '));
    //Console.WriteLine(printOutText);

    string text = "Nick sat against the wall of the church where they had dragged him to be clear of machine gun fire in the street. Both legs stuck out awkwardly. He had been hit in the spine. His face was sweaty and dirty. The sun shone on his face. The day was very hot. Rinaldi, big backed, his equipment sprawling, lay face downward against the wall. Nick looked straight ahead brilliantly. The pink wall of the house opposite had fallen out from the roof, and an iron bedstead hung twisted toward the street. Two Austrian dead lay in the rubble in the shade of the house. Up the street were other dead. Things were getting forward in the town. It was going well. Stretcher bearers would be along any time now. Nick turned his head carefully and looked down at Rinaldi. “Senta Rinaldi. Senta. You and me we’ve made a separate peace.” Rinaldi lay still in the sun breathing with difficulty. “Not patriots.” Nick turned his head carefully away smiling sweatily. Rinaldi was a disappointing audience. While the bombardment was knocking the trench to pieces at Fossalta, he lay very flat and sweated and prayed oh jesus christ get me out of here. Dear jesus please get me out. Christ please please please christ. If you’ll only keep me from getting killed I’ll do anything you say. I believe in you and I’ll tell everyone in the world that you are the only thing that matters. Please please dear jesus. The shelling moved further up the line. We went to work on the trench and in the morning the sun came up and the day was hot and muggy and cheerful and quiet. The next night back at Mestre he did not tell the girl he went upstairs with at the Villa Rossa about Jesus. And he never told anybody.";
    string result2=demo.spitTextToParagraph(text);
    Console.WriteLine(result2);
}
string[] ProductBackend() 
{
    return new string[] { "Milk", "Yoghurt", "Cream", "Cottage Cheese" };
}
string TransferProductToPresentation(string[] product)
{
    string productAsString= "";
    for (int i = 0;i < product.Length; i++) 
    {
        productAsString+=product[i]+", ";
    }
    return productAsString;
}
void ProductPresentation(string product) 
{
    Console.WriteLine("The products are: "+ product);
}

ProductPresentation(TransferProductToPresentation(ProductBackend()));

void UseServiceMethod()
{
Console.WriteLine("ServiceMethods.getAvarage(20, 21, 24)= " + ServiceMethods.getAvarage(20,21,24));
Console.WriteLine("ServiceMethods.getAvarage(20, 20, 20)= " + ServiceMethods.getAvarage(20, 20, 20));
Console.WriteLine("ServiceMethods.getAvarage(9, 43 , 89)= " + ServiceMethods.getAvarage(9, 43 , 89));

Console.WriteLine("ServiceMethods.getLowestNum(12, 19)= " + ServiceMethods.getLowestNum(12, 19));
 
Console.WriteLine("ServiceMethods.getLowestNum(12.5m, 19.6m)= " + ServiceMethods.getLowestNum(12.5m, 19.6m));

Console.WriteLine("ServiceMethods.getSumOfDiffers(4, 5, 6)= " + ServiceMethods.getSumOfDiffers(4, 5, 6));
Console.WriteLine("ServiceMethods.getSumOfDiffers(9, 43, 89)= " + ServiceMethods.getSumOfDiffers(9, 43, 89));
Console.WriteLine("ServiceMethods.getSumOfDiffers(20, 20, 20)= " + ServiceMethods.getSumOfDiffers(20, 20, 20));
Console.WriteLine("ServiceMethods.getSumOfDiffers(20, 21, 24)= " + ServiceMethods.getSumOfDiffers(20, 21, 24));
Console.WriteLine();
ServiceMethods.loopForprintB(5);
Console.WriteLine();
ServiceMethods.loopForprintB();
Console.WriteLine();
ServiceMethods.loopForPrintNumberSeven();
Console.WriteLine();
Console.WriteLine("the VAT for food is " + ServiceMethods.calculatVAT("food", 98.99m));
Console.WriteLine();
Console.WriteLine("The price of Gym membership is " + ServiceMethods.getPricceOfGymMembership(45,true));
Console.WriteLine();
Console.WriteLine("Calculate the sum of Two numbers using calculator(adding, 56.8, 43.2) method is " + ServiceMethods.calculator("adding",56.8,43.2));
Console.WriteLine();
ServiceMethods.menuOption("delete");
Console.WriteLine();
int penalty = ServiceMethods.GetPenalty(6, 6, 1);
Console.WriteLine(penalty);
}




//StringDemo.SplitTextToArray();
