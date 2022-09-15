string[] array;                                                     
Console.WriteLine("Введите массив строк через пробел");             
string stroka = Console.ReadLine()!;                                
array = stroka.Split(' ');                                          
var result = new string[array.Length];                              
var realSize = 0;                                                   
foreach (var value in array)                                      
{
    if (value.Length <= 3)                                         
    {
        result[realSize] = value;                                   
        realSize++;                                              
        Console.WriteLine(value);                                             
    }
}
  