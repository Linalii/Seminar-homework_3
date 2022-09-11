Console.WriteLine("Введите число - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень - ");
int powerB = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 1; i <= powerB; i++){
    result = result*numberA;
}
Console.WriteLine(result);