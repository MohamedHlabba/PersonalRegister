using System;
using System.Collections.Generic;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Register register = new Register();
            string choice = "";


            do
            {

                Employe em = new Employe();



                Console.WriteLine("Enter employe's full name");
               
                var name = Console.ReadLine();

                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name can't be empty! Input the employees name once more");
                    name = Console.ReadLine();
                }


                em.name = name;
                Console.WriteLine("Enter employe salary");

            
                var salaryAsString = Console.ReadLine();

                double salary;
                while (!double.TryParse(salaryAsString, out salary))
                {
                    Console.WriteLine("This is not a salary !");
                    salaryAsString = Console.ReadLine();
                }

                
                em.Salary = salary;


                Console.WriteLine("you add a new employe");


                register.addemploye(em);

                foreach (String resulat in register.affichemplyee())
                {
                    Console.WriteLine(resulat);
                }
                Console.WriteLine("Do you want to add a new employee yes or no ? ");
                choice = Console.ReadLine();


            }
            while (choice =="yes");
           
               






            }









    }
    }
