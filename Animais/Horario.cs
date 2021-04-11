using System;
using System.Collections.Generic;
using System.Text;
//Indicar o profissional de saúde e a sua disponibilidade horária para efetuar o serviço
namespace Animais
{
    public class Horario: IHorario
    {
        public Horario(String profissional, String horarios)
        {
            Profissional= profissional;
            Horarios= horarios;
        }

        public String Profissional { get; }
        public String Horarios { get; }

        public void Relatar()
        {
            //String relato = "";
            //Console.WriteLine("...........Consulta...........\nHorarios = " + Horarios + "\nProfissional = " + Profissional );
            Console.WriteLine("|-------------Consulta-----------|");
            Console.WriteLine("|Horarios = " + Horarios);
            Console.WriteLine("|Profissional = " + Profissional);
            Console.WriteLine("|--------------------------------|");

        }
    }
}
