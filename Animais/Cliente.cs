using System;
using System.Collections.Generic;
using System.Text;

namespace Animais
{
    public class Cliente : ICliente
    {
        public Cliente(String nome, int contacto, String endereco,Animal animals)
        {
            Nome = nome;
            Contacto= contacto;
            Endereco= endereco;
            Animals = animals;
            Servicos = new Servico[10];
            Servicos[0] = new Servico(null, 0.0, null, null, new Horario("", ""));
            Servicos[1] = new Servico(null, 0.0, null, null, new Horario("", ""));
            Servicos[2] = new Servico(null, 0.0, null, null, new Horario("", ""));
            Servicos[3] = new Servico(null, 0.0, null, null, new Horario("", ""));
            Servicos[4] = new Servico(null, 0.0, null, null, new Horario("", ""));
            Servicos[5] = new Servico(null, 0.0, null, null, new Horario("", ""));
            Servicos[6] = new Servico(null, 0.0, null, null, new Horario("", ""));
            Servicos[7] = new Servico(null, 0.0, null, null, new Horario("", ""));
            Servicos[8] = new Servico(null, 0.0, null, null, new Horario("", ""));
            Servicos[9] = new Servico(null, 0.0, null, null, new Horario("",""));
            n_servico = 0;


        }
       

        public String Nome { get; }
        public int Contacto { get; }
        public int n_servico { get; set; }
        public String Endereco { get; }
        public Animal Animals { get; }
        public Servico[] Servicos { get; }


        public void Relatar(){
            Console.WriteLine("|-------------Cliente------------|");
            Console.WriteLine("|Nome do Cliente:" + Nome);
            Console.WriteLine("|Contacto:" + Contacto);
            Console.WriteLine("|Endereco:" + Endereco);
            Console.WriteLine("|--------------------------------|");

            int i = 0;
            Animals.Relatar();
            Servico[] servico_vazio=null;

            if (Servicos != servico_vazio || Servicos.Length != 0) { 
                while (Servicos[i].Nome != null)
                {
                    Servicos[i].Relatar();
                    i++;
                }
                Console.WriteLine(frequencia());
            }

        }

        
         private String frequencia()
          {
            double freq =  3;
            freq = n_servico / freq;
            return ("Frequencia:"+ freq + " por 3 anos");
          }


        public void indicar_servico(  Servico[] Sel_servicos, Horario[] consultas)
        {
            int i = 0,  SelS = 0, SelH = 0;

           

            //Indicar os servicos.......................................
            Console.WriteLine("..............Servico:.............");
            i = 0;
            while (Sel_servicos[i] != null)
            {
                Console.WriteLine(i + "->" + Sel_servicos[i].Nome);
                i++;
            }
            SelS = int.Parse(Console.ReadLine());


            //Indicar o Horario.......................................
            i = 0;
            while (i != consultas.Length)
            {
                Console.WriteLine(i + "->" + consultas[i].Profissional);
                Console.WriteLine(i + "->" + consultas[i].Horarios);
                i++;
            }
            SelH = int.Parse(Console.ReadLine());

            add_new_service(new Servico(Sel_servicos[SelS].Nome, Sel_servicos[SelS].Preco, Sel_servicos[SelS].Duracao, Sel_servicos[SelS].Medicamentos, consultas[SelH]));
        }


        public void add_new_service(Servico new_service)
        {
           
            Servicos[n_servico] = new_service;
            n_servico++;
           
        }
        
    }

}

