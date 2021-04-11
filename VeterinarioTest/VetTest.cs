using Microsoft.VisualStudio.TestTools.UnitTesting;

using Animais;
using System;

namespace VeterinarioTest
{
    [TestClass]
    public class VetTest
    {
        [TestMethod]
        public void Test_Classe_Animal()
        {
            Animal nnn = new Animal("op", 13,"male", "cao", 12345);

            string actual_name_nnn = nnn.NameA;
            int actual_id_nnn = nnn.Idade;
            string actual_genero_nnn = nnn.Genero;
            string actual_especie_nnn = nnn.Especie;
            int actual_Id_nnn = nnn.Id;

            try
            {
                Assert.AreEqual("op", actual_name_nnn);
                Assert.AreEqual(13, actual_id_nnn);
                Assert.AreEqual("male", actual_genero_nnn);
                Assert.AreEqual("cao", actual_especie_nnn);
                Assert.AreEqual(12345, actual_Id_nnn);

                Console.Write("Classe Animais funcionando");
            }
            catch (Exception q)
            {
                Console.Write("Classe Animais não está correta");
            }
        }

        [TestMethod]
        public void Test_Classe_Cliente()
        {
            
            Cliente www = new Cliente("Nuno", 12345,"endereco", new Animal("op", 13, "male", "cao", 12345));

            string actual_name_www = www.Nome;
            int actual_contacto_www = www.Contacto;
            string actual_endereco_www = www.Endereco;
            Animal actual_animais_www = www.Animals;

            try
            {

                Assert.AreEqual("Nuno", actual_name_www);
                Assert.AreEqual(12345, actual_contacto_www);
                Assert.AreEqual("endereço", actual_endereco_www);
                Assert.AreEqual("op", actual_animais_www.NameA);
                Assert.AreEqual(13, actual_animais_www.Idade);
                Assert.AreEqual("male",  actual_animais_www.Genero);
                Assert.AreEqual("cao", actual_animais_www.Especie);
                Assert.AreEqual( 12345, actual_animais_www.Id);


                Console.Write("Classe Cliente funcionando");
            }
            catch (Exception q)
            {
                Console.Write("Classe Cliente não está correta");
            }
            
        }

        [TestMethod]
        public void Test_Classe_Horario()
        {
            Horario eee = new Horario("profissional","horarios");

            string actual_profissional_eee = eee.Profissional;
            string actual_Horarios_eee = eee.Horarios;

            Assert.AreEqual("profissional", actual_profissional_eee);
            Assert.AreEqual("horarios", actual_Horarios_eee);
        }

       

        [TestMethod]
            public void Test_Classe_Servico()
        {
            Servico  ttt= new Servico("nome", 20.0, "duracao","medicamentos", new Horario("profissional", "horarios"));

            string actual_nome_ttt = ttt.Nome;
            double actual_preco_ttt = ttt.Preco;
            string actual_duração_ttt = ttt.Duracao;
            string actual_medicamentos_ttt = ttt.Medicamentos;
            Horario actual_horario_ttt = ttt.Horarios;


            Assert.AreEqual("nome", actual_nome_ttt);
            Assert.AreEqual(20.0, actual_preco_ttt);
            Assert.AreEqual("duracao", actual_duração_ttt);
            Assert.AreEqual("medicamentos", actual_medicamentos_ttt);
            Assert.AreEqual("profissional", actual_horario_ttt.Profissional);
            Assert.AreEqual("horarios", actual_horario_ttt.Horarios);
        }
    }
    
}
