using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasIdeias
{
    class Validar
    {
        public string ClassificarQIPessoa(int intQI)
        {
            string strQI = string.Empty;

            if (intQI >= 140)
            {
                strQI = " Inteligência Genial! ";
            }
            else if (intQI >= 120 && intQI <= 139)
            {
                strQI = " Inteligência Muito Superior! ";
            }
            else if (intQI >= 110 && intQI <= 119)
            {
                strQI = " Inteligência Superior! ";
            }
            else if (intQI >= 90 && intQI <= 109)
            {
                strQI = " Inteligência normal! ";
            }
            else if (intQI >= 80 && intQI <= 89)
            {
                strQI = " Inteligência com Debilidade Mental! ";
            }
            else if (intQI <= 79)
            {
                strQI = " Fora da tabela de medida! ";
            }
            return strQI;

        }
        public string CalcularIdadePessoa(int intDia, int intMes, int intAno)
        {
            Idade objIdade = new Idade();
            string strMensagem = string.Empty;
            strMensagem = objIdade.CalcularIdade(intDia, intMes, intAno);
            return strMensagem;
        }
        public string ClassificarQIeCalcularIdadePessoa(int intQI, int intAno, int intMes)
        {
            Idade objIdade = new Idade();
            string strMensagem = string.Empty;
            strMensagem = ClassificarQIPessoa(intQI);
            strMensagem += objIdade.CalcularIdade(intAno, intMes);
            return strMensagem;
        }
    }
}
