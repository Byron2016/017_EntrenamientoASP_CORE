using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.ParaAnalisisEjemplos
{
    public class ExpressionBodiedMembers
    {
        // PARA INVOCAR: ProjEmptyWebApplicationCore.ParaAnalisisEjemplos.ExpressionBodiedMembers.EjecutaPrograma();
        public static void EjecutaPrograma()
        {
            Person p = new Person("Mandy", "Dejesus");
            Console.WriteLine(p);
            p.DisplayName();
            p.DisplayNameXMi("Byron", "Trump").DisplayName();
            p.MetodoEncadenadoCambioNombres();
            p.PorBodyMembersXMi("Byron", "Trump") ;
        }
    }

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        private string fname;
        private string lname;

        public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());

        public void MetodoEncadenadoCambioNombres()
        {
            DisplayNameXMi("Byron", "Trump").DisplayName();
        }
        public Person DisplayNameXMi(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
            return this;
        }

        public void PorBodyMembersXMi(string firstName, string lastName) => DisplayNameXMi(firstName, lastName).DisplayName();
    }
}
