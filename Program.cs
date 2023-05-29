// See https://aka.ms/new-console-template for more information
double annualInterest;
double ratio;
double monthlyDeposit;
double targetSum;
int numberOfYears;
double yearlyAmount;
double rate;

Console.Write("Target Sum: ");
string received = Console.ReadLine();
while (!Double.TryParse(received, out targetSum) ||
    targetSum < 0)
{
    Console.Write("Not valid, try again: ");
    received = Console.ReadLine();
}
Console.Write("Annual interest rate (%): ");
 received = Console.ReadLine();
while (!Double.TryParse(received, out annualInterest) ||
    annualInterest < 0)
{
    Console.Write("Not valid, try again: ");
    received = Console.ReadLine();
}
ratio = 1 + annualInterest /100;
rate = annualInterest / 100;

Console.Write("For how many years: ");
received = Console.ReadLine();
while (!Int32.TryParse(received, out numberOfYears) ||
    numberOfYears < 0)
{
    Console.Write("Not valid, try again: ");
    received = Console.ReadLine();
}
yearlyAmount = targetSum * ((1 - ratio) / (1 - Math.Pow(ratio, numberOfYears)));
monthlyDeposit = yearlyAmount / (12 + (78 * rate)/ 12);
Console.WriteLine("Monthly deposit value is {0:F2} euros.", monthlyDeposit);


