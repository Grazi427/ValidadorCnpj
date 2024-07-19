using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorCnpj
{
    public class Validacao
    {
        public bool validarCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int somador;
            int resto;
            string digito;
            string cnpjAux;
            //evitar erros
            cnpj = cnpj.Trim();//tira espaços
            cnpj = cnpj.Replace(",", "").Replace("/", "").Replace("-", "");//deixa so numero
            if (cnpj.Length != 14)
            {
                return false;
            }
            else
            {
                cnpjAux = cnpj.Substring(0, 12);
                somador = 0;
                for (int i = 0; i < 12; i++)
                {
                    somador += int.Parse(cnpjAux[i].ToString()) * multiplicador1[i];
                }
                resto = (somador % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                cnpjAux = cnpjAux + digito;
                //13 digitos
                somador = 0;
                for (int i = 0; i < 13; i++)
                {
                    somador += Convert.ToInt16(cnpjAux[i].ToString()) * multiplicador2[i];
                }
                resto = (somador % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cnpj.EndsWith(digito);
            }
        }

    }
}

