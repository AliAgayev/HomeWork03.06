using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork06._03
{
    class PersonManager
    {
        public void ManagerPerson()
        {

            Person person = new Person();
            Console.WriteLine("Musterinin adini daxil edin : ");
            person.Name = Console.ReadLine();

            Console.WriteLine("Musterinin soyadini daxil edin : ");
            person.Surname = Console.ReadLine();

            Console.WriteLine("Musterinin ata adini daxil edin : ");
            person.FatherName = Console.ReadLine();

            Console.WriteLine("Musterinin cinsiyyetini daxil edin (kisi/qadin) : ");
            person.Gender = Console.ReadLine();

            Console.WriteLine("Musterinin email adresini girin : ");
            person.Email = Console.ReadLine();
          
            Console.WriteLine("Musterinin telefon nomresini daxil edin : ");
            string isContiniue = "";
            do
            {
                string phones = Console.ReadLine();
                person.AddPhones(phones);
                Console.WriteLine("Musterinin yeni telefon nomresi varmi (he/yox) : ");
                isContiniue = Console.ReadLine();
            } while (isContiniue == "he");

            Console.WriteLine("Musterinin addresini daxil edin : ");
            string responseAddress = "";
            do
            {
                string Address = Console.ReadLine();
                person.AddAddress(Address);
                Console.WriteLine("Musterinin yeni addresi varmi (he/yox) : ");
                responseAddress = Console.ReadLine();

            } while (responseAddress == "he");

            person.PersonInfo();

        }
    }
}
