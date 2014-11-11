﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
                                                    //Expected result.
            Console.WriteLine(DigitalRoot("31337")); //3+1+3+3+7=17, 1+7=8
            Console.WriteLine(DigitalRoot("45734")); //4+5+7+3+4=23, 2+3=5
            Console.WriteLine(DigitalRoot("0")); //0
            Console.WriteLine(DigitalRoot("a")); //0 returned on invalid input.
            Console.WriteLine(DigitalRoot("242424T")); //0 - invalid input.
            Console.WriteLine(DigitalRoot("8746238746238746238746")); //Added = 115, 1+1+5=7.
            Console.WriteLine(DigitalRoot("999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999")); //Added = 1350, 1+3+5+0=9.
            Console.WriteLine();
            Console.WriteLine(DigitalRoot("2587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847"));
            Console.WriteLine(DigitalRoot("1234.5678")); //0 - invalid input.
            Console.WriteLine(DigitalRoot("5")); //5
            Console.WriteLine(DigitalRoot("52")); //7
            //All tests successful.

            Console.WriteLine(DigitalRoot2("8746238746238746238746"));
            Console.WriteLine(DigitalRoot2("999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999")); //Added = 1350, 1+3+5+0=9.
            Console.WriteLine(DigitalRoot2("2587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847258700295734985734209857342098573420985732409857234095834270598327509328472587002957349857342098573420985734209857324098572340958342705983275093284725870029573498573420985734209857342098573240985723409583427059832750932847"));
            Console.WriteLine(DigitalRoot2("1234.5678")); //0 - invalid input.
            Console.WriteLine(DigitalRoot2("5")); //5

            Console.ReadKey();
        }




        /// <summary>
        /// Returns the digital root of given number.
        /// </summary>
        /// <param name="rootThis">Number to process in string data type.</param>
        /// <returns>The digital root, or -1 if input is invalid.</returns>
        static int DigitalRoot(string rootThis)
        {
            foreach (char i in rootThis) //Input validation. Returns 0 if any char rootThis is not a number.
                if (!char.IsNumber(i))
                    return -1;

            int result = 0; //Sums stored here.

            while(rootThis.Length > 1)                  //Done when rootThis's lengh is 1.
            {
                result = 0;                             //Reset sum to 0
                
                foreach (char i in rootThis)            //For every digit in rootThis...
                    result += int.Parse(i.ToString());  //...add sum of digit to result. Int.Parse only takes a string.
                
                rootThis = result.ToString();           //Set rootThis to this sum...
            }                                           //...then loop again.
            
            return int.Parse(rootThis);                 //The processed string is returned.

        }

        /// <summary>
        /// Returns the digital root of given number.
        /// </summary>
        /// <param name="rootThis">Number to process in string data type.</param>
        /// <returns>The digital root, or -1 if input is invalid.</returns>
        static int DigitalRoot2(string rootThis)
        {
            
            /* ANY single character in the rootThis string is NOT a number, return -1.
               If the length of rootThis is more than 1...
                 -Convert the value of the first two characters in rootThis to int, and add them together.
                 -Convert that sum to a string and add it to end of the rootThis string.
                 -Remove the first two values of rootThis.
                   +(Their total is at the end of the string, so it remains mathematically stable.) */

            if (rootThis.All(x => !char.IsNumber(x))) return -1;
            while (rootThis.Length > 1) rootThis = (rootThis + (int.Parse(rootThis[0].ToString()) + int.Parse(rootThis[1].ToString()))).Remove(0, 2);
            return int.Parse(rootThis);
        }
    }
 }
