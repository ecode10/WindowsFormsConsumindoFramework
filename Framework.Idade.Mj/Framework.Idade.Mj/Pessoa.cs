using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Idade.Mj
{
    /// <summary>
    /// 
    /// Classe de pessoa com dois métodos específicos para calcular a idade.
    /// </summary>
    public class Pessoa
    {
        /// <summary>
        /// Método que calcula a idade da pessoa
        /// </summary>
        /// <param name="ano">ano de nascimento</param>
        /// <returns>Int32</returns>
        public Int32 calculaIdade(Int32 ano)
        {
            return calculaIdadeInterno(ano);
        }

        /// <summary>
        /// Método que calcula a idade da pessoa e retorna o ano
        /// Este método recebe também o nome.
        /// </summary>
        /// <param name="ano">ano de nascimento</param>
        /// <param name="nome">nome da pessoa</param>
        /// <returns>String</returns>
        public String calculaIdade(Int32 ano, string nome)
        {
            return "Nome: " + nome + " Idade:" + calculaIdadeInterno(ano);
        }

        private static int calculaIdadeInterno(int ano)
        {
            var _idade = 0;
            try
            {
                //verificacao de dado atual
                if (ano <= 0 || ano > DateTime.Now.Year)
                    throw new Exception("Envie o ano corretamente. Maior que 0 ou menor que o ano atual");

                //pega o ano atual
                var _anoAtual = DateTime.Now.Year;

                //diminui o ano atual pelo ano de nascimento do usuário
                _idade = _anoAtual - ano;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _idade;
        }

        
    }
}
