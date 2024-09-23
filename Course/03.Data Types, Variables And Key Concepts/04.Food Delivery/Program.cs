int chickenMenuNumber = int.Parse(Console.ReadLine());
int fishMenuNumber = int.Parse(Console.ReadLine());
int vegetarianMenuNumber = int.Parse(Console.ReadLine());

double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarianMenuPrice = 8.15;
double deliveryPrice = 2.50;

double chickenPrice = chickenMenuNumber * chickenMenuPrice;
double fishPrice = fishMenuNumber * fishMenuPrice;
double vegeterianPrice = vegetarianMenuNumber * vegetarianMenuPrice;

double totalCoastMenu = chickenPrice + fishPrice + vegeterianPrice;

double dessertPrice = totalCoastMenu * 0.2;

double totalCoast = totalCoastMenu + dessertPrice + deliveryPrice;

Console.WriteLine(totalCoast);















