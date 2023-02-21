using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] { { 3,4,5 }, { 6,7,8 }, { 9, 10, 11 } };

            for (int i = 0; i < array.GetLength(0); i++)  // проходим по строкам массива 
            {
                for (int j = 0; j < array.GetLength(1); j++) // проходим по столбцам массива 
                {

                    for (int k = 0; k < array.GetLength(1) - 1; k++) // сравниваем элементы внутри строки 
                    {

                        if (array[i, k] < array[i, k + 1]) // если значение текущего элемента меньше следующего - меняем их местами  
                        {

                            int temp = array[i, k];

                            array[i, k] = array[i, k + 1];

                            array[i, k + 1] = temp;

                        }

                    }

                }

            }

            Console.WriteLine("Отсортированный двумерный массив:"); //выводим результат  

            for (int i = 0; i < array.GetLength(0); i++) //проходим по строкам  

            {

                for (int j = 0; j < array.GetLength(1); j++) //проходим по столбцам  

                {

                    Console.Write("{0}\t", array[i, j]); //выводим ячейку  

                }

                Console.WriteLine();//для красоты  

            }            
        }        
    }    
}
