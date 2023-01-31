
/*Console.WriteLine("Input your number_1: "); 
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your number_2: "); 
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 == number_2 * number_2);

    Console.WriteLine($"Число {number_1} является квадратом числа {number_2}");

else
{
    Console.WriteLine($"Число {number_1} не является квадратом числа {number_2}");
}
*/

/*Console.WriteLine("Input your number N: "); 
int num = Convert.ToInt32(Console.ReadLine());

int current_num = (-1) * num;

while (current_num <= num)
{
    Console.Write(current_num + " ");
    current_num++;//инкремент//

}*/
//Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Input your number N: "); 
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 & num<1000)
{
int digit_3 = num % 10;
Console.WriteLine("$ Third digit is {int digit_3}");
}
else
{
    Console.WriteLine("Your number is not 3-digit!");

}