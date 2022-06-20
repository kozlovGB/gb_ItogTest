/*Задача 41: Написать программу, которая из имеющегося массива строк формирует
 новый массив из строк, длинна которых меньше или равна 3.*/
string test = Console.ReadLine();
string[] array = test.Split(new Char[] {' '});
int schet=0;
int j = 0;
for(int i=0;i<array.Length;i++)
{
    if (array[i].Length<=3) schet++;
}
string [] result =new string [schet] ;
for(int i=0;i<array.Length;i++)
{
    if (array[i].Length<=3) 
    {
        result[j]=array[i];
        j++;
    }
}
Console.WriteLine($"[{string.Join(", ",array)}]->[{string.Join(", ",result)}] ");
