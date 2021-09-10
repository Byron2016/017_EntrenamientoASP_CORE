using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.ParaAnalisisEjemplos
{
    public class FuncionAggretateAnalisis
    {
        public static void AnalizaAggregate()
        {          
            //Aggregate<TSource,TAccumulate,TResult>(IEnumerable<TSource>, TAccumulate, Func<TAccumulate,TSource,TAccumulate>, Func<TAccumulate,TResult>)
            //public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector);

            //string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };
            string[] fruits = { "zzz", "cccc", "vvvvv", "bbbbbb", "nnnn", "mmmmmmm" };

            // Determine whether any string in the array is longer than "banana".
            string longestName =
                fruits.Aggregate("xxxx",
                                (longest, next) =>
                                {
                                    if (next.Length > longest.Length)
                                    {
                                        return next;
                                    }
                                    else
                                    {
                                        return longest;
                                    }
                                    //next.Length > longest.Length ? next : longest,
                                },
                                // Return the final result as an upper case string.
                                fruit => fruit.ToUpper());

            Console.WriteLine(
                "The fruit with the longest name is {0}.",
                longestName);

            // This code produces the following output:
            //
            // The fruit with the longest name is PASSIONFRUIT.

            //Aggregate<TSource,TAccumulate>(IEnumerable<TSource>, TAccumulate, Func<TAccumulate,TSource,TAccumulate>)
            /*
             * public static TAccumulate Aggregate<TSource, TAccumulate>(
             * this System.Collections.Generic.IEnumerable<TSource> source, 
             * TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func);
             * */
            //int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };

            // Count the even numbers in the array, using a seed value of 0.
            //int numEven = ints.Aggregate(0, (total, next) =>  next % 2 == 0 ? total + 1 : total);
            longestName = "";
            longestName = fruits.Aggregate("", (total, next) => {
                if (next.Length > total.Length)
                {
                    return next.ToUpper();
                }
                else
                {
                    return total.ToUpper();
                }
            });

            Console.WriteLine("The second overload example : {0}", longestName);

            // This code produces the following output:
            //
            // The number of even integers is: 6
            //Aggregate<TSource>(IEnumerable<TSource>, Func<TSource, TSource, TSource>)
            //string sentence = "the quick brown fox jumps over the lazy dog";
            //string[] words = sentence.Split(' ');
            //string reversed = words.Aggregate((workingSentence, next) =>
            //                          next + " " + workingSentence);
            longestName = "";
            longestName = fruits.Aggregate((workingSentence, next) =>
            {
                if (next.Length > workingSentence.Length)
                {
                    return next.ToUpper();
                }
                else
                {
                    return workingSentence.ToUpper();
                }
            });



            //reversed = words.Aggregate();
            /*
            public static TResult     Aggregate<TSource, TAccumulate, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector);

            public static TAccumulate Aggregate<TSource, TAccumulate>         (this System.Collections.Generic.IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func);

            public static TSource     Aggregate<TSource>                      (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource, TSource, TSource> func);


            1.- the this keyword in front of the source parameter identifies it as an Extension method, which means the above code is syntax sugar for:
                string reversed =      words.Aggregate(       (workingSentence, next) => next + " " + workingSentence);
                string reversed = Enumerable.Aggregate(words, (workingSentence, next) => next + " " + workingSentence);

            2.- TSource is a generic parameter, which in this case is substituted with string because the compiler is 
                able to infer this type from the fact that words is an IEnumerable < string >.

            3.- Func<TSource, TSource, TSource> is a generic delegate representing a function that takes two parameters
                (the first two TSources), and returns a TSource. 
                This is in contrast to Action<TSource, TSource>, which would take two parameters and not return a value.
                Either of these types can be represented with a lambda expression with the form(param1, param2) => expression.


                */


        }
        /*
        public static TResult Aggregate<TSource, TAccumulate, TResult>(
            this System.Collections.Generic.IEnumerable<TSource> source, 
            TAccumulate seed, 
            Func<TAccumulate, TSource, TAccumulate> func, 
            Func<TAccumulate, TResult> resultSelector
        );

        public static TAccumulate Aggregate<TSource, TAccumulate>(
            this System.Collections.Generic.IEnumerable<TSource> source, 
            TAccumulate seed, 
            Func<TAccumulate, TSource, TAccumulate> func
        );

        public static TSource Aggregate<TSource>(
            this System.Collections.Generic.IEnumerable<TSource> source, 
            Func<TSource, TSource, TSource> func
        );

        */
    }
}
