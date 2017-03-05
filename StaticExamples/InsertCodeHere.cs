﻿using System;
using System.Collections.Generic;

namespace StaticExamples
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> aList = new List<int> {23, 86, 51, 11, 39};

            //ListMethods listMethodsObject = new ListMethods();

            //int smallest = listMethodsObject.FindSmallestNumber(aList);
            int smallest = ListMethods.FindSmallestNumber(aList);
            Console.WriteLine("The smallest number in the list is : {0}", smallest);

            //int average = listMethodsObject.FindAverage(aList);
            int average = ListMethods.FindAverage(aList);
            Console.WriteLine("The average of the list is : {0}", average);

            // The LAST line of code should be ABOVE this line
        }
    }
}