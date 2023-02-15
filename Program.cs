//поиск что в задаче 10 что в 13 можно свести к одному решению, попытаемся написать прогу 
//для универсального решения для любого числа
Console.WriteLine("Попробуем найти любое число по счету в любом заданном числе");
Console.WriteLine("Введите любое целое число ");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь укажите какое по счету число вы хотите что бы мы нашли");
int controlCount=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А вы хотите что бы мы нашли его справа или слева? Введите число 1 если справа налево и число 2 если слева направо");
int side=Convert.ToInt32(Console.ReadLine());
int degree=1;
//закончили ввод данных, пошло тело программы
if (number<0)
{
    number=number*(-1);
}// проверка на знак, нам нужно цифра-показатель разряда,, поэтому знак самого числа не важен
//нам нужно определить сколько знаков всего содержит число, для этого делим его на 10 в степени пока не будет 0
while((number/(Convert.ToInt32(Math.Pow(10, degree))))!=0)
{
    degree=degree+1;
}//после того как результат от деления будет равен 0, то значение degree бутем показывать сколько знаков в числе
//теперь считаем слева или спраава числа
//int controlNumber требуемое число
if (side==2)
{
    if (controlCount>degree)
    {
        Console.WriteLine($"в этом числе нет {controlCount} знаков, попробуйте другое или измените требуемый разряд");
    }
    else
    {
        int controlNumber=((number/Convert.ToInt32(Math.Pow(10, (degree-controlCount)))%10));
        Console.WriteLine($"Вы хотели найти {controlCount} по счету цифру от числа {number} и это число {controlNumber}");
    }
}
if (side==1)
{
    if ((controlCount-1)>=degree)
    {
        Console.WriteLine($"в этом числе нет {controlCount} знаков, попробуйте другое или измените требуемый разряд");
    }
    else
    {
        int controlNumber=((number/(Convert.ToInt32(Math.Pow(10, (controlCount-1))))%10));
        Console.WriteLine($"Вы хотели найти {controlCount} по счету цифру от числа {number} и это число {controlNumber} ");
    }
}



