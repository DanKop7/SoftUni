int lengthInCm = int.Parse(Console.ReadLine());
int widthInCm = int.Parse(Console.ReadLine());
int heightInCm = int.Parse(Console.ReadLine());
double percentage = int.Parse(Console.ReadLine());

double aquaroumVolume = lengthInCm * widthInCm * heightInCm;
double litterVolume = aquaroumVolume / 1000;

double requaredLitters = litterVolume * (1 - percentage / 100);

Console.WriteLine($"{requaredLitters:F2}");

