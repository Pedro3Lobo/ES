using System;
using System.Collections.Generic;
using System.Text;
//Indicar 1 ou mais serviços a prestar (Preço, Duração, Medicamentos)
namespace Animais
{
    public class Servico: IServico
    {
         public Servico(String nome,double preco, String duracao, String medicamentos,Horario horarios)
        {
            Nome = nome;
            Preco = preco;
            Duracao= duracao;
            Medicamentos= medicamentos;
            Horarios = horarios;
        }
        //...........................................REMINDER TO CHANGE TO PRIVATE..................................................................
        
        public String Medicamentos { get; }
        public String Nome { get; }
        public String Duracao { get; }
        public double Preco { get; }
        public Horario Horarios { get; }

        public void Relatar()
        {
            //Console.WriteLine("FlagServico");
           // Console.WriteLine("...........Servico...........\nNome = " + Nome + "\n Medicamentos = " + Medicamentos + "\n Duracao = " + Duracao + "\n Preco= " + Preco);
            Console.WriteLine("|-------------Servico------------|");
            Console.WriteLine("|Serviço:" + Nome);
            Console.WriteLine("|Medicamentos:" + Medicamentos);
            Console.WriteLine("|Duracao:" + Duracao);
            Console.WriteLine("|Preco:" + Preco);
            Console.WriteLine("|--------------------------------|");


            Horarios.Relatar();
        }
        


    }
}
