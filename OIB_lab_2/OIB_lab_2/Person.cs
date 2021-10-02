using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIB_lab_2
{
    public class Person
    {
        private String ID;
        private String Pass;
        private String Surname;
        private String Otch;
        private String BornDate;
        private String BornPlace;
        private String Phone;

        public Person (String id, String pass, String surname, 
            String otch, String bornDate, String bornPlace, String phone)
        {
            ID = id;
            Pass = pass;
            Surname = surname;
            Otch = otch;
            BornDate = bornDate;
            BornPlace = bornPlace;
            Phone = phone;
        }
        public Person()
        {

        }
        //Тупо сеттеры полей
        public void SetID(String id)
        {
            ID = id;
        }
        public void SetPass(String newPass)
        {
            Pass = newPass;
        }
        public void SetSurname(String surname)
        {
            Surname = surname;
        }
        public void SetOtch(String otch)
        {
            Otch = otch;
        }
        public void SetBornDate(String bornDate)
        {
            BornDate = bornDate;
        }
        public void SetBornPlace(String bornPlace)
        {
            BornPlace = bornPlace;
        }
        public void SetPhone(String phone)
        {
            Phone = phone;
        }

        //Тупо геттеры полей
        public String GetID()
        {
            return ID;
        }
        public String GetPass()
        {
            return Pass;
        }
        public String GetSurname()
        {
            return Surname;
        }
        public String GetOtch()
        {
            return Otch;
        }
        public String GetBornDate()
        {
            return BornDate;
        }
        public String GetBornPlace()
        {
            return BornPlace;
        }
        public String GetPhone()
        {
            return Phone;
        }

    }
}
