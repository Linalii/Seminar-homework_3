Random random = new Random();
int number = 1;
bool isEven = false;
while(!isEven){
    number = random.Next(1,100);
    if((number*number*number)%2 == 0){
        isEven = true;
        Console.WriteLine("У числа "+number+" куб заканчивается на четное число: "+number*number*number);
    }
}