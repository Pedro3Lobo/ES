using System;
using System.Collections.Generic;
using System.Text;


namespace Animais
{
    interface ICliente
    {
          String Nome  { get;}
          int Contacto  { get;}
          String Endereco  { get;}
          Animal Animals { get; }
          Servico[] Servicos { get; }
    }
}
