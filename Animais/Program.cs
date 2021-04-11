using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            int Selector = 0, cli_con, nclientes = 0, i = 0, SelC =0,  idade,  id;
            String cli_nome,  cli_end,  nameA,  genero,  especie;

            Cliente[] clientes = new Cliente[20];
            Animal[] animal = new Animal[20];
            Horario[] horarios= new Horario[3];
            Servico[] servicos = new Servico[5];

            Animal[] vazio_animal = new Animal[20];
            Horario vazio_horarios =new Horario(null,null);
            Servico[] vazio_servicos = new Servico[20];

            horarios[0] = new Horario("Darios Silva", "18/4/2019");
            horarios[1] = new Horario("Maggy Gouveia", "18/3/2020");
            horarios[2] = new Horario("Nuno Silva", "18/2/2020");

            servicos[0] = new Servico("Cortar Pelo", 99.9, "20 min", "none", vazio_horarios);
            servicos[1] = new Servico("Curtar as unhas", 99.9, "40 min", "none", vazio_horarios);
            servicos[2] = new Servico("Vacinar da Raiva", 99.9, "60 min", "none", vazio_horarios);
            servicos[3] = new Servico("Vacinar da Hepatite canina", 99.9, "30 min", "none", vazio_horarios);


            while (Selector != 4)
            {
                Console.WriteLine("|--------------Menu--------------|");
                Console.WriteLine("|Adicionar Cliente..............1|");
                Console.WriteLine("|Indicar o Servico..............2|");
                Console.WriteLine("|Relatorio......................3|");
                Console.WriteLine("|Sair...........................4|");
                Console.WriteLine("|--------------------------------|");
                
                Selector =int.Parse(Console.ReadLine());
                Console.Clear();

                switch (Selector)
                {
                    case 1:
                        //Adicionar Cliente
                        Console.WriteLine("|----------Novo Cliente----------|");

                        Console.WriteLine("|Nome:");
                        cli_nome = Console.ReadLine();

                        Console.WriteLine("|Contacto");
                        cli_con = int.Parse(Console.ReadLine());

                        Console.WriteLine("|Enderço");
                        cli_end=Console.ReadLine();

                        Console.WriteLine("|----------Novo Animal----------|");

                        Console.WriteLine("|Nome do Animal:");
                        nameA = Console.ReadLine();

                        Console.WriteLine("|Idade do Animal:");
                        idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("|Genero:");
                        genero = Console.ReadLine();

                        Console.WriteLine("|Especie:");
                        especie = Console.ReadLine();

                        Console.WriteLine("|Id:");
                        id = int.Parse(Console.ReadLine());

                        clientes[nclientes] =new Cliente(cli_nome, cli_con, cli_end, new Animal(nameA, idade, genero, especie, id));
                        nclientes = nclientes + 1;
                      
                        break;

                    case 2:
                        //Indicar o Servico
                        if (clientes.Length != 0)
                        {
                           
                            i = 0;
                            Console.WriteLine("Escolhe cliente");

                            while (clientes[i] != null)
                            {
                                Console.WriteLine(i + "->" + clientes[i].Nome);
                                i++;
                            }
                            SelC = int.Parse(Console.ReadLine());

                            clientes[SelC].indicar_servico(servicos,horarios );
                        }
                        else
                        {
                            Console.WriteLine("Não existe cliente por favor crie os cliente");
                        }
                       
                        break;

                    case 3:
                        
                        i = 0;
                        while (clientes[i] != null)
                        {
                            clientes[i].Relatar();
                            Console.WriteLine("------------------------------------------------");
                            i++;
                        }
                        break;

                    case 4:

                        Console.WriteLine("BYE BYE");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("UPS este menu nao existe :(");
                        break;
                }
                
                Console.WriteLine("carreguem  qualquer botão");
                Console.ReadLine();
                Console.Clear();


            }




        }
    }
}
