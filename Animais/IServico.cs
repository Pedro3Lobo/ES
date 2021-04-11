using System;
using System.Collections.Generic;
using System.Text;

namespace Animais
{
    interface IServico
    {
        String Medicamentos { get; }
        String Duracao { get; }
        double Preco { get; }
        Horario Horarios { get; }
    }
}
