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
        int[] numberEntered = new int[] { 3, 1, 2, 4, 3 };

        int numberEnteredResult = functionSelisih(numberEntered);

        Console.WriteLine(numberEnteredResult);
    }

    public static int functionSelisih(int[] numberEntered)
    {
        try
        {
            List<int> numberEnteredResult = new List<int>();
            int[] convertedNumberEnteredResult = new int[] { };

            for (int start = 0; start < numberEntered.Length; start++)
            {
                //TOTAL A
                int totalStart = 0;
                int totalEnd = 0;

                for (int startCountTotalA = 0; startCountTotalA < start; startCountTotalA++)
                {
                    totalStart += numberEntered[startCountTotalA];
                    //Console.WriteLine(dataArray[startCountTotalA]);
                }
                //TOTAL B
                for (int startCountTotalB = start; startCountTotalB < numberEntered.Length; startCountTotalB++)
                {
                    totalEnd += numberEntered[startCountTotalB];

                    //Console.WriteLine(dataArray[startCountTotalB]);
                }


                numberEnteredResult.Add(Math.Abs(totalStart - totalEnd));
                convertedNumberEnteredResult = numberEnteredResult.ToArray();
            }
            return convertedNumberEnteredResult.Min();
        }
        catch (Exception ex)
        {
            // Log Data Error disini
            Console.WriteLine("Error  : " + ex.Message);
            throw;
        }

    }
}