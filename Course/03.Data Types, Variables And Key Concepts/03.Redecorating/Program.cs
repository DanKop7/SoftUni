int amaountInNylonSqm = int.Parse(Console.ReadLine());
int amaountInPaintLiters = int.Parse(Console.ReadLine());
int quantityOfThinnerLiters = int.Parse(Console.ReadLine());
int hoursToDoTheWork = int.Parse(Console.ReadLine());

double priceNylonSqm = 1.5;
double pricePaintPerLiter = 14.50;
double priceThinnerPerLiter = 5;
double priceForbags = 0.4;

double nylonAmaount = (amaountInNylonSqm + 2) * priceNylonSqm;
double paintamaount = amaountInPaintLiters * 1.1  * pricePaintPerLiter;
double thinnerAmaount = quantityOfThinnerLiters * priceThinnerPerLiter;

double totalPriceFormaterials = nylonAmaount + paintamaount + thinnerAmaount + priceForbags;

double PriceForHour = totalPriceFormaterials * 0.30;
double priceForWork = PriceForHour * hoursToDoTheWork;


double totalPrice = totalPriceFormaterials + priceForWork;

Console.WriteLine(totalPrice);

