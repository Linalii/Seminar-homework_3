int [] array = new int[8];
Random random = new Random();
int positiveSum = 0;
int negativeSum = 0;
for(int i = 0; i< array.Length; i++){
    array[i] = random.Next(-10,10);
    if(array[i] < 0){
        negativeSum = negativeSum+array[i];
    }
    else positiveSum = positiveSum + array[i];
}
Console.WriteLine("Все элементы массива: ");
foreach(int n in array){
    Console.WriteLine(n);
}
Console.WriteLine("Сумма положительных элементов: "+positiveSum);
Console.WriteLine("Сумма отрицательных элементов: "+negativeSum);


