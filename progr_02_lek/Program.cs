void FillArray(int[] collection) //где collection это аргумент
{
    int length = collection.Length; //получаем длину массива
    int index =0; //позиция начинается с нолика
    while (index < length) //индекс меньше чем ленгс
    {
        collection[index]=new Random().Next(1,10); //обращаемся к аргументу collection на позицию индекс и положить туда случ цел числ на позиция 1 10
        //index = index+1; присвоить индексу индекс+1
        index++;
    }
}

//создадим войд который будет печатать массив
void PrintArray(int[] col) //void метод который не возвращает значения. return не используется
{
    int count  = col.Length;//обозначаем количество элементов
    int  position =0; //текущую позицию обозначим
    while (position < count) //цикл вайл. пока позиция меньше чем каунт
    {
        Console.WriteLine(col[position]); //будем выводить на экран
        position++; //увеличиваем значение текущей позиции
    }

}

int IndexOf(int[] collection ,int find)
{
    int count =collection.Length;
    int index =0;
    int position =0;
    while (index<count)
    {
        if(collection[index] == find)
    {
        position = index ;
        break; //оператор
    }
    index ++;
    }
    return position;
}

//создать массив с названием эррэй с десятью элементами. По умолчанию с нулями. сверху метод, заполняющий др цифрами 
int[] array = new int[10]; //определили массив из 10 элементов
FillArray(array); //заполняем массив
PrintArray(array); //распечатал
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

