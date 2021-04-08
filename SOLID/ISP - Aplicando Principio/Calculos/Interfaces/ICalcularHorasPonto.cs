using ISP___Violacao.Entitites.RH;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISP___Aplicando_Principio.Calculos.Interfaces
{
    public interface ICalcularHorasPonto
    {
        int CalcularHoras(Ponto tempo);
        int CalcularHorasExtras(Ponto tempo);
    }
}
