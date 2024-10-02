using System;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new Costume();
        nurse.headWear = "face mask";
        nurse.gloves = "nitrile gloves";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarmet = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new Costume();
        detective.headWear = "ffedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarmet = "trenchcoat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

        Costume rancher = new Costume();
        rancher.headWear = "cowboy hat";
        rancher.gloves = "work";
        rancher.shoes = "boots";
        rancher.upperGarmet = "fancy vest";
        rancher.lowerGarment = "jeans";
        rancher.accessory = "lasso";

        Console.WriteLine("Nurse Costume: ");
        nurse.ShowWardrobe();

        Console.WriteLine();

        Console.WriteLine("Detective Costume: ");
        detective.ShowWardrobe();

        Console.WriteLine();

        Console.WriteLine("Rancher Costume: ");
        rancher.ShowWardrobe();

        Console.WriteLine();
    }

}