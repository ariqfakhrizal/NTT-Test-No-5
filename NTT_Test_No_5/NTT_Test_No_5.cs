using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;

namespace NTT;

public class NTT_Test_No_5
{
    static void Main(string[] args)
    {
        int[] dataArray = new int[] { 3, 1, 2, 4, 3 };
        //int[] dataArray = new int[] { 2, 5, 3, 6 };

        int result = functionSelisih(dataArray);

        Console.WriteLine(result);
    }

    public static int functionSelisih(int[] dataArray)
    {
        try
        {
            int[] dataDifferenceArray = new int[] { };
            List<int> dataResult = new List<int>();

            for (int start = 0; start < dataArray.Length; start++)
            {
                //TOTAL A
                int totalStart = 0;
                int totalEnd = 0;

                for (int startCountTotalA = 0; startCountTotalA < start; startCountTotalA++)
                {
                    totalStart += dataArray[startCountTotalA];
                    //Console.WriteLine(dataArray[startCountTotalA]);
                }
                //TOTAL B
                for (int startCountTotalB = start; startCountTotalB < dataArray.Length; startCountTotalB++)
                {
                    totalEnd += dataArray[startCountTotalB];

                    //Console.WriteLine(dataArray[startCountTotalB]);
                }


                dataResult.Add(Math.Abs(totalStart - totalEnd));
                dataDifferenceArray = dataResult.ToArray();
            }
            return dataDifferenceArray.Min();
        }
        catch (Exception ex)
        {
            // Log Data Error disini
            Console.WriteLine("Error  : " + ex.Message);
            throw;
        }

    }
}