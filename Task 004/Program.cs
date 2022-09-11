int numberA = 1;
Console.WriteLine("Введите число - ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA;
for(int i = 1; i <= numberB; i++){
    result = result*i;
}
Console.WriteLine(result);