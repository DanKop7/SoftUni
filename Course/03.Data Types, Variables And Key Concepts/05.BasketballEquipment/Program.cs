int annualBasketballFee = int.Parse(Console.ReadLine());

double basketballSneakers = annualBasketballFee - (annualBasketballFee * 0.40);
double basketballUniform = basketballSneakers - (basketballSneakers * 0.20);
double basketballBall = basketballUniform / 4;
double basketballAccesories = basketballBall / 5;

double totalPrice =  annualBasketballFee + basketballSneakers + basketballUniform + basketballBall + basketballAccesories;

Console.WriteLine(totalPrice);

