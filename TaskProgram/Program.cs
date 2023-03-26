namespace TaskProgram;
class Program
{
    // Написать программу, которая из имеющегося массива строк формирует массив из строк,
    // длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
    // либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
    // лучше обойтись исключительно массивами.
    
    //     Примеры:
    // ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
    // ["1234", "1567", "-2", "computer science"] -> ["-2"]
    // ["Russia", "Denmark", "Kazan"] -> []
    static void Main(string[] args)
    {
        string[] array1 = new string[] {"hello", "2", "world", ":-)"};
        string[] array2 = new string[] {"1234", "1567", "-2", "computer science"};
        string[] array3 = new string[] {"Russia", "Denmark", "Kazan"};
        
        PrintArray(FilterThreeSybmolArray(array1));
        PrintArray(FilterThreeSybmolArray(array2));
        PrintArray(FilterThreeSybmolArray(array3));
    }
    
    static string[] FilterThreeSybmolArray(string[] array)
    {
        int[] itemId = new int[array.Length];
        int countItem = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i].Length <= 3)
            {
                itemId[countItem] = i;
                countItem++;
            }
        }
        
        string[] resultArray = new string[countItem];
        for(int i = 0; i < countItem; i++)
        {
            resultArray[i] = array[itemId[i]];
        }
        return resultArray;
    }

    static void PrintArray(string[] array)
    {
        Console.Write("Out array: [");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.Write("]\n");
    }
} 
