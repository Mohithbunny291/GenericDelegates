using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    public class Program
    {
        public static double Func_addition(int n1, float n2, double n3)
        {
            return n1 + n2 + n3;
        }

        public static void Action_Addition(int n1, float n2, double n3)
        {
            Console.WriteLine("Action delegate is called" + (n1 + n2 + n3));
        }

        public static bool Predicate_Length(string name)
        {
            if (name.Length <= 5) return false;
            return true;
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> f_delegate = new Func<int, float, double, double>(Func_addition);
            double res = f_delegate(3, 123.45f, 123.54); //f_delegate. Invoke(,,,);
            Console.WriteLine(" Func delegate invoke " + res);


            Action<int, float, double> a_delagete = new Action<int, float, double>(Action_Addition);
            a_delagete(9, 9.89f, 67.89);
            Predicate<string> p_delegate = new Predicate<string>(Predicate_Length);


            bool b = p_delegate("Mphasis");
            Console.WriteLine(" predicate delegate with string " + b);


            FuncAnonymousLambda funcAnonymousLamda = new FuncAnonymousLambda();
            Func<double, double, double> t1 = funcAnonymousLamda.Add2Num;
            double res2 = t1(3.3, 2.21);
            Console.WriteLine(res2);

            Func<double, double, double> t2 = delegate(double n1, double n2) {  return n1 + n2; };
            double ans = t2(4.3, 23.2);
            Console.WriteLine("Anonymous: "+ans);

            Func<double, double, double> t3 = (double n1, double n2) => { return n1 + n2; };
            double result = t3(32.4, 2.2);
            Console.WriteLine("Lambda "+result);


            //Action Delegate
            Console.WriteLine("Action Dele");
            ActionDelegAnonyLambda funcDeleg = new ActionDelegAnonyLambda();
             Action<string> act = funcDeleg.print; //generic action
             act("Mphasis"); // generic
            // or
            Action act1 = funcDeleg.print;  // non generic action 
            act1();
            

            Action<double, double> Add = funcDeleg.AddingNum;
            Add(32.1, 31.1);
            Add.Invoke(32.1, 31.1);

            //Anonymus 
            Console.WriteLine("Anonymus");
            Action<double, double> anony_Add = delegate(double n1, double n2) { Console.WriteLine(n1+n2); };
            anony_Add(32.23, 24.12);

            //Lambda
            Console.WriteLine("Lambda");
            Action<double, double> lamb_Add = (n1, n2) => { Console.WriteLine(n1 + n2); };
            lamb_Add(32.23, 24.12);


            //Predecate
            PredicateDeleAnonyLambda predicateDeleAnonyLambda = new PredicateDeleAnonyLambda();
            Predicate<int> pre_Check = predicateDeleAnonyLambda.IsEvenNum;
            Console.WriteLine(pre_Check(100));

            //Anonymus
            Console.WriteLine("Anonymus");
            Predicate<int> pre_Anany = delegate (int num)
            {
                if (num % 2 == 0) return true; return false;
            };
            Console.WriteLine(pre_Anany(15));

            //Lambda
            Console.WriteLine("Lambda");
            Predicate<int> pre_LambdaCheck = (num) => { if (num % 2 == 0) return true;return false; };
            Console.WriteLine(pre_LambdaCheck(15));
        }
    }

}
