using OOPCollections.Models;
using System;
using System.Collections.Generic;

namespace OOPCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bir akademiya var. Akademiyanin muellimleri var, sinifleri var
            //Siniflerin telebeleri var . Muellimin adi , soyadi , yasi.
            //Siniflerin telebeleri , adi , baslama tarixi , biteceyi tarix.
            //Telebenin adi , soyadi.


            //Akademiyaya muellim elave etmek
            //Akademiyaya sinif elave etmek
            //Sinife telebe elave etmek

            //Yuxardaki mentiqlerin silinmesi


            //Academy academy = new Academy("High Result Academy");

            //Teacher t = new Teacher("Tərlan", "Usubov");

            //Student s = new Student("Urfan", "Məmmədov");

            //DateTime startDate = DateTime.Parse("22.09.2021");
            //DateTime endDate = DateTime.Parse("22.05.2022");

            //Group g = new Group("Geneva", startDate, endDate);

            //academy.AddTeacher(t);

            //academy.AddGroup(g);

            //academy.AddStudent(s);


            int a = 10;

            int b = 7;


            a = b;

            b = 16;

            Console.WriteLine(a);



            Student student1 = new Student("Orxan", "Seyidli");

            Student student2 = new Student("Babek", "Ağamuradlı");


            student1 = student2;

            student2.Name = "Urfan";

            Console.Write(student1.Name);

            //Value type
            //Reference type
            
        }
    }
}
