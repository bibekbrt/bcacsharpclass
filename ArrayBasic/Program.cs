using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            Person objPerson = new Person();
            Person objPerson1 = new Person();
            Person objpers2 = new Person();


            objPerson.PersonId = 4;
            objPerson.PersonName = "Ram kumar sharma";
            objPerson.ShowPersonName();




            //Sum of Array Element

            //ShowSumOfArray();
            //Array.Sort

            int[] arraySort = { 3, 1, 4, 2 };
            Array.Sort(arraySort);
            // numbers is now [1, 2, 3, 4]
            Array.Reverse(arraySort);
            //Console.WriteLine(arraySort[1]);


            //sortNew(new int[] { 1, 232, 555, 6, 7, 7 });

            //sortt(new int[] { 1, 232, 555, 6, 7, 7 });




            //Array arrayReverse
            //int[] arrayReverse = {18,17,10,9,80 };
            //Array.Sort(arrayReverse);
            //// numbers is now [4, 3, 2, 1]

            //Console.WriteLine(arrayReverse[arrayReverse.Length-1]);


            int j = 10;
            int sum = 5 + j++;
            //Console.WriteLine(sum);

            char[] newArrayInt = new char[5];
            newArrayInt[0] = 'C';
            newArrayInt[1] = 'A';

            for (int i = 0; i < newArrayInt.Length; i++)
            {
                //Console.WriteLine(newArrayInt[i]);

            }

            Console.ReadKey();


            //Array Declaration
            int[] intArr = new int[3] { 10, 20, 30 };

            int[] intArrWithoutSize = new int[] { 10, 20, 3434, 34343 };

            //int[] arrWithOutNewKeyword = { 10, 20, 30, 40, 50 };




            Console.WriteLine("For Loop");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine(intArr[i]);
            }
            Console.WriteLine("Foreach loop");



            //foreach (var item in intArr)
            //{

            //    Console.WriteLine(item);
            //}









            int[] arr = new int[5];//creating array




            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            numbers[2] = 10; // Replaces the third element with the value 10

            //For Loop
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //Foreach
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }



            //Declaring single dimensional array
            string[] Books = new string[5];
            Books[0] = "C#";
            Books[1] = "Java";
            Books[2] = "VB.NET";
            Books[3] = "C++";
            Books[4] = "C";




            //Multi Dimensional Array
            int[,] x = { { 1, 2, 3 }, { 3, 4, 5 } };

            // a 2D array
            int[,] multiArray = { { 1, 2, 3 }, { 3, 4, 5 } };

            // access first element from first row
            multiArray[0, 0] = 1;  // returns 1

            // access third element from second row
            multiArray[1, 2] = 5;  // returns 5

            // access third element from first row
            multiArray[0, 2] = 3;  // returns 3



            Console.WriteLine("----------Multi dimensional Array--------------------------");

            //2d array loop
            int[,] twoDimensionalArraynumbers = { { 2, 3, 9 }
                                                , { 4, 5, 9 } };

            for (int rows = 0; rows < 2; rows++)
            {
                for (int cols = 0; cols < 3; cols++)
                {
                    Console.Write(twoDimensionalArraynumbers[rows, cols] + " ");
                }
                Console.WriteLine();//new line at each row      
            }

            Console.WriteLine("----------Jagged Array--------------------------");

            int[][] jaggedArray =
                                    {
                                        new int[] { 1, 2, 3, 4 },
                                        new int[] { 5, 6, 7 },
                                        new int[] { 8, 9 },
                                        new int[] { 10 }
                                    };


            for (int jaggedi = 0; jaggedi < jaggedArray.Length; jaggedi++)
            {
                for (int jaggedj = 0; jaggedj < jaggedArray[jaggedi].Length; jaggedj++)
                {
                    Console.Write(jaggedArray[jaggedi][jaggedj] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadKey();

        }

        public static void sortt(int[] arr)
        {

            int temp = 0;
            //1, 232, 555, 6, 7, 7
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int currentValofI = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int ValueOfi = arr[i];
                    int ValueOfJ = arr[j];

                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            //for (int j = 0; j < arr.Length - 1; j++)
            //{
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        int outputnumber = arr[i];
            //        int swap = 0;
            //        if (arr[i] > arr[i + 1])
            //        {
            //            swap = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = swap;
            //        }
            //    }
            //}
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
        }

        public static void sortNew(int[] arr)
        {



            int temp = 0;
            //1, 232, 555, 6, 7, 7
            for (int i = 0; i <= arr.Length; i++)
            {

                for (int j = i; j < arr.Length; j++)
                {
                    int ValueOfi = arr[i];
                    int ValueOfJ = arr[j];

                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            //for (int j = 0; j < arr.Length - 1; j++)
            //{
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        int outputnumber = arr[i];
            //        int swap = 0;
            //        if (arr[i] > arr[i + 1])
            //        {
            //            swap = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = swap;
            //        }
            //    }
            //}
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
        }


        public static void ShowSumOfArray()
        {

            int inputNumber, sum = 0;
            Console.Write("Enter Total Element");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            int[] sumOrArray = new int[inputNumber];

            Console.WriteLine("Input Arrays Elements:");

            for (int i = 0; i < inputNumber; i++)
            {

                int Number = Convert.ToInt16(Console.ReadLine());
                sumOrArray[i] = Number;

            }

            for (int i = 0; i < inputNumber; i++)
            {
                sum = sum + sumOrArray[i];
            }

            Console.WriteLine("Sum of total Array Element is :" + sum);





        }
    }
}
