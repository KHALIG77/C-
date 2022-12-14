using System.Text;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] convertInput = input.Split(' ');


            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < convertInput.Length; i++)
            {
                for (int j = convertInput[i].Length - 1; j >= 0; j--)
                {
                    strBuilder.Append(convertInput[i][j]);
                }
                if (i != convertInput.Length - 1)
                {
                    strBuilder.Append(" ");
                }
                 input=strBuilder.ToString();
            }
          

            Console.WriteLine(strBuilder);








        }
    }
}
//int[] arr = {1,6,2};
//int[] arr2 = arr;
//arr2[0]=9;
//Console.WriteLine(arr[0]);
//Console.WriteLine(arr2[0]);
