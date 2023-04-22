// Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. 

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num >9){
  while (num > 99){
    num = num / 10;
  } 
  Console.WriteLine(num % 10);
}
else{
    Console.WriteLine("нет");
}