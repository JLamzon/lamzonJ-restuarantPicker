//Jessie Lamzon
//10/20/22
//Restuarant Picker
//Randomize restuarants by selecting a type or random all

Console.Clear();

int noNumber;
bool validEntry;
int number = 5;
string playAgain = "";
string userPick = "";

Console.WriteLine("Welcome to Random Picker: Restaraunt Edition");

while (playAgain != "no")
{
    Console.WriteLine("Pick a category...Mexican, Thai, Chinese, Indian, or American")
    userPick = Console.ReadLine().ToLower();
    validEntry = Int32.TryParse(userPick, out noNumber);
    Console.WriteLine(validEntry);



    Random random = new Random();
    number = random.Next(0, 4);


    if (userPick == "mexican")
    {
        switch (number)
        {
            case 1:
                Console.WriteLine("La Estrella");
                break;

            case 2:
                Console.WriteLine("Tepa Taqueria");
                break;

            case 3:
                Console.WriteLine("El Chappala");
                break;

            case 4:
                Console.WriteLine("Tepa Taqueria");
                break;

            case 5:
                Console.WriteLine("Taqueria El Azteca");
                break;
        }
    }
    else if (userPick == "thai")
    {
        switch (number)
        {
            case 1:
                Console.WriteLine("Spice it up!");
                break;

            case 2:
                Console.WriteLine("Royal Siam");
                break;

            case 3:
                Console.WriteLine("Chim");
                break;

            case 4:
                Console.WriteLine("Green Papaya");
                break;

            case 5:
                Console.WriteLine("Bangkok Restaurant");
                break;

            default:
                break;
        }
    }
    else if (validEntry == false)
    {
        Console.WriteLine("try again with correct input...\n");
    }

    Console.WriteLine("Press any key to try again or type no to exit...");
    playAgain = Console.ReadLine();
}
Console.WriteLine("Thanks for playing!");



