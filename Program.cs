// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Strings and Concatenation
string cityName = "New Orleans";
string teamName = "Saints";
string footballTeam = cityName + " " + teamName;
Console.WriteLine(footballTeam);

//bool flow control Demo
bool CanRideTheRollerCoaster(int heightInches, double weightPounds)
{
    int heightRequirement = 60;
    int weightRequirement = 100;

    if (heightInches >= heightRequirement && weightPounds >= weightRequirement)
    {
        Console.WriteLine("Ride the Ride!!!");
        return true;
    }
    else if (heightInches >= heightRequirement && weightRequirement < weightPounds)
    {
        Console.WriteLine("You meet the height requirement but not the weight");
        return false;
    }
    else
    {
        Console.WriteLine("No ride for you");
        return false;
    }
}

CanRideTheRollerCoaster(60,100);