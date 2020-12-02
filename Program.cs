using System;

namespace Orientacao_a_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamento objeto

            Personagem jogador1 = new Personagem();
            jogador1.nome = "Lux";
            jogador1.idade = 20;
            jogador1.armadura = "Todas as Skins da Lux";
            jogador1.skill = "Desfile de Skin";




            Personagem jogador2 = new Personagem();
            jogador2.nome = "Ornn";
            jogador2.idade = 500;
            jogador2.armadura = "Escudo do Esquecimento";
            jogador2.skill = "Motivação Inabalavel";

            Console.Clear();
            Console.WriteLine($"Partida {jogador1.nome} VS {jogador2.nome}");
            Console.WriteLine($"Jogador 1 Armadura: {jogador1.armadura} || Jogador 2 Armadura {jogador2.armadura}");
            Console.WriteLine($"Jogador 1 Habilidade: {jogador1.skill} || Jogador 2 Habilidade: {jogador2.skill}");

            //COMECE A LUTA

            int vidaDoJogador2 = jogador2.Defender(jogador1.Atacar2());

            if(vidaDoJogador2 <= 0){
                Console.WriteLine($"O Jogador Morreu");
            }else{
                Console.WriteLine($"Jogador 2 Depois do ataque ficou com {jogador2.vida}");
            }
        }
    }
}
