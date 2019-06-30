using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
            
        { GroupType programming = new GroupType("programming");
            GroupType design = new GroupType("design");
            GroupType digitalMarketing = new GroupType("digital marketing");

           
            Person leman = new Person("Leman","Aliyeva",3500,programming,new DateTime(1995,08,27));
            Person ayten = new Person("Ayten", "Quliyeva", 3900, programming,new DateTime(1992,08,30));
            Person vaqif = new Person("Vaqif", "Dadasov", 3900, programming,new DateTime(1986,09,26));
            Person mirze = new Person("Mirze", "Aliyev", 3900, programming, new DateTime(1994, 04, 04));

            Person eli = new Person("Eli", "Eliyev", 3500, design, new DateTime(1990, 05, 27));
            Person adil = new Person("Adil", "Quliyev", 3900, design, new DateTime(1996, 08, 05));
            Person almaz = new Person("Almaz", "Dadaszade", 3900, design, new DateTime(1997, 06, 26));
            Person gulnar = new Person("Gulnar", "Rzayeva", 3900, design, new DateTime(1992, 02, 02));

            Groups programming1 = new Groups("programming1");
            programming1.AddPerson(leman);
            programming1.AddPerson(ayten);
            programming1.AddPerson(vaqif);
            programming1.AddPerson(mirze);
            programming1.GetAllPerson();

            Groups design2 = new Groups("design2");
            design2.AddPerson(eli);
            design2.AddPerson(adil);
            design2.AddPerson(almaz);
            design2.AddPerson(gulnar);
            design2.GetAllPerson();



        }
    }
}
