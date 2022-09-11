Console.WriteLine("Введите число - ");
string number = Console.ReadLine();
int result = 0;
string temp = "";
for (int i = 0; i < number.Length; i++){
    temp = ""+number[i];
    result = result + Convert.ToInt32(temp);
}
Console.WriteLine("Сумма чисел "+number+" = "+result);