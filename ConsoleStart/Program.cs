// See https://aka.ms/new-console-template for more information

using ConsoleStart;
using System;

Console.WriteLine("ServiceMethods.getAvarage(20, 21, 24)= " + ServiceMethods.getAvarage(20, 21, 24));
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

