using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OIB_lab_2
{
    public class PersonCheck
    {
        /*private String IDCheck;
        private String PassCheck;*/
        private static Person person1 = new Person("Oleg", "root", "Ivanov", "Ivanovich",
            "02.11.1911", "Moscow", "2345654321");
        private static Person person2 = new Person("Dima", "admin", "Papich", "Olegovich",
            "22.09.1945", "Riga", "000938765");
        //private Person[] PersonArray = {person1, person2};
        private ArrayList PersonAL = new ArrayList(){person1, person2};
        
        public PersonCheck ()
        {
           /* IDCheck = idCheck;
            PassCheck = passCheck;*/
        }
        public ArrayList GetPersonList()
        {
            return PersonAL;
        }
        public void AddPerson(Person person)
        {
            PersonAL.Add(person);
        }
        public String CheckPerson(String idCheck, String passCheck)
        {
            String flag = "Введены неверные данные";
            foreach (Person person in PersonAL)
            {
                if (person.GetID().Equals(idCheck) && person.GetPass().Equals(passCheck))
                {
                    flag = "";
                    break;
                }
                    
            }
            return flag;
        }
        public int GetPersonIndex(String idCheck, String passCheck)
        {
            int index = -1;
            foreach (Person person in PersonAL)
            {
                index++;
                if (person.GetID().Equals(idCheck))
                {
                    break;
                }

            }
            return index;
        }

    }
}
