using System;
using System.Collections.Generic;
using System.Text;

namespace Animais
{
    public interface IAnimais 
    {
        string NameA  { get; }
        int Idade  { get;}
        string Genero  { get; }
        string Especie  { get; }
        int Id  { get; }
       
    }
}
