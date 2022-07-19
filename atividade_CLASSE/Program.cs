using atividade_CLASSE.src;
using System;

namespace atividade_CLASSE { 
    class Program
    {
        static void Main(string[] args)
        {
            ChampLeagueOfLegends Garen = new ChampLeagueOfLegends(Categoria.Tanque, "Garen", 616, 0, 57.88);
            ChampLeagueOfLegends Lucian = new ChampLeagueOfLegends(Categoria.Atirador, "Lucian", 390,0, 46);
            ChampLeagueOfLegends Anivia = new ChampLeagueOfLegends(Categoria.Mago, "Anivia", 467, 60, 51.37);
            ChampLeagueOfLegends Janna = new ChampLeagueOfLegends(Categoria.Suporte, "Janna", 356, 50, 49);
            ChampLeagueOfLegends Jax = new ChampLeagueOfLegends(Categoria.Lutador, "Jax", 463, 40, 56.3);

            Console.WriteLine(Garen.ToString());
            Console.WriteLine(Lucian.ToString());
            Console.WriteLine(Anivia.ToString());
            Console.WriteLine(Janna.ToString());
            Console.WriteLine(Jax.ToString());
        }
    }
}
