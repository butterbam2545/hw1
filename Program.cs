using System;

public class Program {

 public static void Main(string[] args) {
    Console.Write("Please input Name:");
    string name = Console.ReadLine();
    Console.Write("Please input Number:");
    double number = double.Parse(Console.ReadLine());
    Console.Write("Please input Ownername:");
    string ownername = Console.ReadLine();
    Console.Write("Please input Registeredvalue:");
    double registeredvalue = double.Parse(Console.ReadLine());
    shop myshop = new shop(name, number, ownername, registeredvalue);
    myshop.PrintInformation();
    string money = Console.ReadLine();
    shop myshop1 = new shop(money);
    myshop1.ExchangeMoney();
 }
}