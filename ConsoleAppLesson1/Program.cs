
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppLesson1
{

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public string Birthday { get; set; }
        public string Sex { get; set; }
        public string Contacts { get; set; }

        public void Print()
        {
            Console.WriteLine($"id:{Id} Имя:{Name} Фамилия:{LastName} Отчество:{SurName} Дата Рождения:{Birthday} Пол:{Sex} Телефон:{Contacts}");
        }
        public void Data()
        {
            Console.WriteLine("Введите данные пациента:");
            Console.WriteLine("Имя:");
            Name = Console.ReadLine();
            Console.WriteLine("Фамилия:");
            LastName = Console.ReadLine();
            Console.WriteLine("Отчество:");
            SurName = Console.ReadLine();
            Console.WriteLine("Дата Рождения:");
            Birthday = Console.ReadLine();
            Console.WriteLine("Пол");
            Sex = Console.ReadLine();
            Console.WriteLine("Телефон:");
            Contacts = Console.ReadLine();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Создать пациента");
            Console.WriteLine("2 - Найти пациента");
            Console.WriteLine("3 - Изменить данные пациента");
            Console.WriteLine("4 - Удалить данные пациента");
            string choice = Console.ReadLine();
            List<Person> PersonList = new List<Person>();
            if (choice == "1")
            {
                Person patient = new Person();
                //patient.Id = i;
                patient.Data();
                patient.Print();
                PersonList.Add(patient);
            }
            /*for (int i = 0; i<=5; i++)
          {
            Person patient = new Person();
            patient.Id = i;
            patient.Data();
            patient.Print();
            Console.WriteLine("Сохранить данные пациента? (Да/Нет)");
            string Choice2 = Console.ReadLine();
            if (Choice2 == "Да")
            {
                PersonList.Add(patient);
                Console.WriteLine("Данные пациента сохранены");
            }
            else
            {
                Console.WriteLine("Данные пациента не сохранены");
            }  
          }*/
            else if (choice == "2")
            {
                Console.WriteLine("Ввод данных завершен");
            }
            foreach (Person patient in PersonList)
            {
                patient.Print();
            }
            Console.ReadLine();
        }
        //Console.WriteLine(PersonList.Count);
    }      
}

