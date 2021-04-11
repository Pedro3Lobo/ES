using System;
using System.Collections.Generic;
using System.Text;
//Registo de animais de estimação (Nome, Idade, Género, Espécie, Nº de Identificação)
namespace Animais
{
    public class Animal : IAnimais
    {
        public Animal(string nameA, int idade, string genero, String especie, int id)
        {
            NameA = nameA;
            Idade = idade;
            Genero = genero;
            Especie = especie;
            Id = id;
            
        }

        //...........................................REMINDER TO CHANGE TO PRIVATE..................................................................
        public String NameA { get; }
        public int Idade { get; }
        public String Genero { get; }
        public String Especie { get; }
        public int Id { get; }
        
        
        public void Relatar()
        {
            Console.WriteLine("|-------------Animal-------------|");
            Console.WriteLine("|Nome do animal:" + NameA);
            Console.WriteLine("|Idade do animal:" + Idade);
            Console.WriteLine("|Genero do animal:" + Genero);
            Console.WriteLine("|Especie do animal:" + Especie);
            Console.WriteLine("|Id do animal:" + Id);
            Console.WriteLine("|--------------------------------|");
        }

        
    }
}
