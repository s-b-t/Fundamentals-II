// Three Basic Arrays

// Random rand = new Random();

int[] intArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

string[] nameArray = { "Tim", "Martin", "Nikki", "Sara" };

bool[] boolArray = new bool[10];
for(int i = 0; i < boolArray.Length; i++)
{
    boolArray[i] = (i % 2 == 0);
    
    // Returns random value True/False
    // boolArray[i] = rand.Next(0, 2) == 0 ? true: false;
}
foreach(bool result in boolArray)
{
    System.Console.WriteLine(result);
}


// List of Flavors
List<string> flavors = new List<string>();
flavors.Add("Vanilla");
flavors.Add("Chocolate");
flavors.Add("Strawberry");
flavors.Add("Sherbet");
flavors.Add("Cookie Dough");
flavors.Add("Mint");
flavors.Add("Cherry");

// Output length of the List after adding flavors
System.Console.WriteLine($"All {flavors.Count} Flavors in This List:");
for(int i = 0; i < flavors.Count; i++)
{
    System.Console.WriteLine("-" + flavors[i]);
}

// Output third flavor in List
System.Console.WriteLine($"The third flavor in the list is: {flavors[2]}");

// Remove third flavor using index location
flavors.RemoveAt(2);
System.Console.WriteLine("We've just removed the third flavor from the list!");

// Output length of List again
System.Console.WriteLine($"There's now {flavors.Count} flavors in the list");


// User/Flavor Dictionary

// Create a dictionary storing string keys and string values
Dictionary<string, string> userFlavors = new Dictionary<string, string>();
// Usable random function for following tasks, defining what 'rand' is
Random rand = new Random();

// Each key is a name from the nameArray up above
// Each value is a ranomly selected flavor from the flavors List above
foreach(string name in nameArray)
{
    int RandomIndexNum = rand.Next(0, 6);
    string RandFlavor = flavors[RandomIndexNum];
    userFlavors.Add(name, RandFlavor);
}

System.Console.WriteLine("We're now showing a randomized selection of flavors for our users!");

// Looping through and printing out each user's name with their randomly selected flavor
foreach(KeyValuePair<string, string> key in userFlavors)
{
    System.Console.WriteLine(key);
}












