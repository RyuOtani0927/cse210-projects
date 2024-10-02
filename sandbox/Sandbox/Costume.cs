
class Costume
{
    // attributes (member variables)
    public string headWear;

    public string gloves;

    public string shoes;

    public string upperGarmet;

    public string lowerGarment;

    public string accessory;



    // behaviors (member functions, or *methods*)

    public void ShowWardrobe()
    {
        string result = "";

        result += "Head gear: " + headWear;
        result += "\nHand gear: " + gloves;
        result += "\nFoot gear: " + shoes;
        result += "\nTorso covering: " + upperGarmet;
        result += "\nLeg covering: " + lowerGarment;
        result += "\nAccessory: " + accessory;
        Console.WriteLine(result);

    }
}