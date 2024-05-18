namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        #region Fibonacci
        //0,1,1,2,3,5,8
        //int num1 = 0;
        //int num2 = 1;

        //Console.Write(num1 + ",");
        //Console.Write(num2 + ",");
        //while (true)
        //{
        //    int num3 = num1 + num2;
        //    Console.Write(num3 + ",");
        //    num1 = num2;
        //    num2 = num3;
        //    Console.ReadLine();
        //}

        #endregion

        #region Elementlerin Console'a cixarilmasi
        //string[] names = { "Asiman", "ISmayil", "Musa" };

        //int index = 0;
        //while (true)
        //{
        //    Console.WriteLine(names[index]);
        //    index++;

        //    if (index >= names.Length)
        //        break;

        //}


        #endregion


        int[] numbers = { 4, 1, 6, 7, 8, 9, 2, 30, 2 }; 

        #region Arraydeki max deyeri tapmaq

        //int max = numbers[0];
        //int index = 0;

        //while (index < numbers.Length)  
        //{
        //    if (max < numbers[index])
        //    {
        //        max = numbers[index];
        //    }

        //    index++;
        //}


        //Console.WriteLine(max);

        #endregion

        #region Arrayin ededi ortasi

        //decimal total = 0;
        //int index = 0;

        //while (index < numbers.Length)
        //{
        //    total += numbers[index];
        //    index++;
        //}



        //decimal avarage;
        //if (numbers.Length == 0)
        //    avarage = 0;
        //else
        //    avarage = total / numbers.Length;

        //Console.WriteLine(avarage);

        #endregion

        #region Deyerin arrayda movcud olub olmamasi

        //Console.Write("Deyer daxil edin:");
        //int input = int.Parse(Console.ReadLine());

        //int index = 0;
        //bool result = false;

        //while(index<numbers.Length)
        //{

        //    if (numbers[index] == input)
        //    {
        //        result = true;
        //    }
        //    index++;
        //}

        //Console.WriteLine(result);


        #endregion

        #region Ededin siralanmis olub olmamasi
        //int index = 0;

        //bool isSorted = true;

        //while (index < numbers.Length-1)
        //{

        //    if (numbers[index] > numbers[index + 1])
        //    {

        //        isSorted = false;
        //        break;
        //    }

        //    index++;
        //}

        //Console.WriteLine(isSorted);
        #endregion

        #region Arraydaki max ve min elementlerin yerinin deyisdirilmesi


        int max = numbers[0];
        int min = numbers[0];

        int index = 0;

        while (index < numbers.Length)
        {
            if (max < numbers[index])
            {
                max = numbers[index];
            }
            if (min > numbers[index])
            {
                min = numbers[index];
            }
            index++;

        }

        index = 0;
        while (index < numbers.Length)
        {
            if (numbers[index] == max)
            {

                numbers[index] = min; //4, 30, 6, 7, 8, 9, 2, 1, 2
            }
            else if (numbers[index] == min)
            {
                numbers[index] = max;   //4,30, 6, 7, 8, 9, 2, 30, 2 

            }
            index++;
        }



        index = 0;

        while (index < numbers.Length)
        {
            Console.Write(numbers[index] + ",");
            index++;
        }

        #endregion

    }
}
