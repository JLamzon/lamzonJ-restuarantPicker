//Jessie Lamzon
//10/20/22
//Restuarant Picker
//Randomize restuarants by selecting a type or random all

Console.Clear();

int noNumber;
bool validEntry = true;
int number = 0;
int numberAll = 0;
string playAgain = "";
string userPick = "";

Console.WriteLine("Welcome to Random Picker: Restaraunt Edition");

while (playAgain != "no")
{
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("Type in a category...");
    Console.WriteLine("Mexican | Thai | Chinese | Indian | American | Random\n");
    Console.Write("Pick: ");
    userPick = Console.ReadLine().ToLower();
    validEntry = Int32.TryParse(userPick, out noNumber);

    Random random = new Random();
    number = random.Next(1, 6);

    Random allRandom = new Random();
    numberAll = random.Next(1, 26);

    if (userPick == "mexican")
    {
        switch (number)
        {
            case 1:
                Console.Write("Results: ");
                Console.WriteLine("La Estrella");
                break;

            case 2:
                Console.Write("Results: ");
                Console.WriteLine("El Jardin Restaurant");
                break;

            case 3:
                Console.Write("Results: ");
                Console.WriteLine("El Chappala");
                break;

            case 4:
                Console.Write("Results: ");
                Console.WriteLine("Tepa Taqueria");
                break;

            case 5:
                Console.Write("Results: ");
                Console.WriteLine("Taqueria El Azteca");
                break;
        }
    }
    else if (userPick == "thai")
    {
        switch (number)
        {
            case 1:
                Console.Write("Results: ");
                Console.WriteLine("Spice it up!");
                break;

            case 2:
                Console.Write("Results: ");
                Console.WriteLine("Royal Siam");
                break;

            case 3:
                Console.Write("Results: ");
                Console.WriteLine("Chim");
                break;

            case 4:
                Console.Write("Results: ");
                Console.WriteLine("Green Papaya");
                break;

            case 5:
                Console.Write("Results: ");
                Console.WriteLine("Bangkok Restaurant");
                break;
        }
    }
    else if (userPick == "chinese")
    {
        switch (number)
        {
            case 1:
                Console.Write("Results: ");
                Console.WriteLine("Kitty’s Kitchen");
                break;

            case 2:
                Console.Write("Results: ");
                Console.WriteLine("Bamboo Inn");
                break;

            case 3:
                Console.Write("Results: ");
                Console.WriteLine("Lee’s Chinese Restaurant");
                break;

            case 4:
                Console.Write("Results: ");
                Console.WriteLine("Dragon Palace");
                break;

            case 5:
                Console.Write("Results: ");
                Console.WriteLine("China Palace");
                break;
        }
    }
    else if (userPick == "indian")
    {
        switch (number)
        {
            case 1:
                Console.Write("Results: ");
                Console.WriteLine("Maharaja");
                break;

            case 2:
                Console.Write("Results: ");
                Console.WriteLine("Swagat");
                break;

            case 3:
                Console.Write("Results: ");
                Console.WriteLine("Tandoori Grill");
                break;

            case 4:
                Console.Write("Results: ");
                Console.WriteLine("Indian Cafe Restaurant");
                break;

            case 5:
                Console.Write("Results: ");
                Console.WriteLine("India 4 U");
                break;
        }
    }
    else if (userPick == "american")
    {
        switch (number)
        {
            case 1:
                Console.Write("Results: ");
                Console.WriteLine("Chilis");
                break;

            case 2:
                Console.Write("Results: ");
                Console.WriteLine("Applebees");
                break;

            case 3:
                Console.Write("Results: ");
                Console.WriteLine("BJ's");
                break;

            case 4:
                Console.Write("Results: ");
                Console.WriteLine("Denny's");
                break;

            case 5:
                Console.Write("Results: ");
                Console.WriteLine("Red Robbin");
                break;
        }

    }
    else if (userPick == "random")
    {
        switch (numberAll)
        {
            case 1:
                Console.Write("Results: ");
                Console.WriteLine("Chilis");
                break;

            case 2:
                Console.Write("Results: ");
                Console.WriteLine("Applebees");
                break;

            case 3:
                Console.Write("Results: ");
                Console.WriteLine("BJ's");
                break;

            case 4:
                Console.Write("Results: ");
                Console.WriteLine("Denny's");
                break;

            case 5:
                Console.Write("Results: ");
                Console.WriteLine("Red Robbin");
                break;
            case 6:
                Console.Write("Results: ");
                Console.WriteLine("Maharaja");
                break;

            case 7:
                Console.Write("Results: ");
                Console.WriteLine("Swagat");
                break;

            case 8:
                Console.Write("Results: ");
                Console.WriteLine("Tandoori Grill");
                break;

            case 9:
                Console.Write("Results: ");
                Console.WriteLine("Indian Cafe Restaurant");
                break;

            case 10:
                Console.Write("Results: ");
                Console.WriteLine("India 4 U");
                break;
            case 11:
                Console.Write("Results: ");
                Console.WriteLine("Kitty’s Kitchen");
                break;

            case 12:
                Console.Write("Results: ");
                Console.WriteLine("Bamboo Inn");
                break;

            case 13:
                Console.Write("Results: ");
                Console.WriteLine("Lee’s Chinese Restaurant");
                break;

            case 14:
                Console.Write("Results: ");
                Console.WriteLine("Dragon Palace");
                break;

            case 15:
                Console.Write("Results: ");
                Console.WriteLine("China Palace");
                break;
            case 16:
                Console.Write("Results: ");
                Console.WriteLine("Spice it up!");
                break;

            case 17:
                Console.Write("Results: ");
                Console.WriteLine("Royal Siam");
                break;

            case 18:
                Console.Write("Results: ");
                Console.WriteLine("Chim");
                break;

            case 19:
                Console.Write("Results: ");
                Console.WriteLine("Green Papaya");
                break;

            case 20:
                Console.Write("Results: ");
                Console.WriteLine("Bangkok Restaurant");
                break;
            case 21:
                Console.Write("Results: ");
                Console.WriteLine("La Estrella");
                break;

            case 22:
                Console.Write("Results: ");
                Console.WriteLine("El Jardin Restaurant");
                break;

            case 23:
                Console.Write("Results: ");
                Console.WriteLine("El Chappala");
                break;

            case 24:
                Console.Write("Results: ");
                Console.WriteLine("Tepa Taqueria");
                break;

            case 25:
                Console.Write("Results: ");
                Console.WriteLine("Taqueria El Azteca");
                break;


            default:
                break;
        }

    }
    //     else if (validEntry == true || userPick == string.Empty)
    // {
    //     Console.WriteLine("\ntry again with correct input...\n");
    // }

    Console.WriteLine("\nPress any key to try again or type no to exit...");
    playAgain = Console.ReadLine();
}
Console.WriteLine("Thanks for playing!");



