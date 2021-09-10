using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.ParaAnalisisEjemplos
{
    public class ActionsFuncPredicate
    {
        // PARA INVOCAR: ProjEmptyWebApplicationCore.ParaAnalisisEjemplos.ActionsFuncPredicate.EjecutaPrograma();
        public static void EjecutaPrograma()
        {
            ActionDelegates("Hello!!!");
            FuncDelegates(50000);
            PredicateDelegates(2);

        }

        #region DelegadosDeAcciones
        public static void ActionDelegates(string mensaje)
        {
            // Action<TParameter>
            // public delegate void Action<in T>(T obj);
            Action<string> action = new Action<string>(Display);
            action(mensaje);
        }

        static void Display(string message)
        {
            Console.WriteLine(message);
        }
        #endregion

        #region DelegadosDeFunc
        public static void FuncDelegates(int sueldo)
        {
            // Func<TParameter, TOutput>
            Func<int, double> func = new Func<int, double>(CalculateHra);
            double elValor = func(sueldo);
        }

        static double CalculateHra(int basic)
        {
            return (double)(basic * .4);
        }
        #endregion

        #region DelegadosDePredicado
        public static void PredicateDelegates(int id)
        {
            // Predicate<T>
            List<Customer> custList = new List<Customer>();
            custList.Add(new Customer { Id = 1, FirstName = "Joydip", LastName = "Kanjilal", State = "Telengana", City = "Hyderabad", Address = "Begumpet", Country = "India" });
            custList.Add(new Customer { Id = 2, FirstName = "Steve", LastName = "Jones", State = "OA", City = "New York", Address = "Lake Avenue", Country = "US" });

            Predicate<Customer> hydCustomers = x => x.Id == id;
            Customer customer = custList.Find(hydCustomers);
            string nombre = customer.FirstName;
            Console.WriteLine(customer.FirstName);
            // Console.Read();
        }
        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
        }
        #endregion
    }
}
