using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_CLASSE.src
{
    public class ChampLeagueOfLegends
    {
        Categoria Posicao { get; set; }
        string Nome { get; set; }

        int Vida { get; set; }

        double PoderDeHabilidade { get; set; }

        double Ataque { get; set; }

        public ChampLeagueOfLegends(Categoria posicao, string nome, int vida, double poderDeHabilidade, double ataque)
        {
            Posicao = posicao;
            Nome = nome;
            Vida = vida;
            PoderDeHabilidade = poderDeHabilidade;
            Ataque = ataque;
        }
        public override string ToString()
        {
            return $"\n Nome do Campeão: {Nome}" +
                   $"\n Tipo: {Posicao}" +
                   $"\n Vida inicial: {Vida}" +
                   $"\n AP inicial: {PoderDeHabilidade}" +
                   $"\n Dano inicial: {Ataque}";
        }
    }

    public enum Categoria
    {
        Atirador,
        Tanque,
        Mago,
        Suporte,
        Lutador,
    }


}
