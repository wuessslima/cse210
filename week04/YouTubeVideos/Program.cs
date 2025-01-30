using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Bully SE :: ALL ERRANDS in CHAPTER 2[100% Walkthrough]", "Badinfos", 1085);
        video1.AddComment(new Comment("@andytoskovic", "The randomness of these errands is on point! I really loved the one where you throw water balloons at people"));
        video1.AddComment(new Comment("@Nuh_Ozkartal", "Am I the only one who likes to rewind Badinfos’ Intro like 5 times before continuing on with the video because it’s awesome?"));
        video1.AddComment(new Comment("@barracudaboi790", "9:18 so apparently, it is not OK to smoke near a gas station, but it is OK to toss fireworks at people. LOL"));
        videos.Add(video1);

        Video video2 = new Video("GOD OF WAR: ASCENSION - Parte 4 / FINAL", "alanzoka", 8973);
        video2.AddComment(new Comment("@matoosu", @"NÚMERO DE MORTES E FRACASSOS DO ALAN EM CADA JOGO DA MARATONA GOW

    TOTAL NO GOD OF WAR I: 89 MORTES e 9 FRACASSOS

    TOTAL NO GOD OF WAR II: 69 MORTES

    TOTAL NO GOD OF WAR III: 75 MORTES

    TOTAL NO GOD OF WAR ASCENSION: 22 MORTES

    SOMA TOTAL: 255 MORTES e 9 FRCASSOS

    E com isso encerramos essa maratona insana, agora é só aguardar até a próxima e estaremos de volta!"));
        video2.AddComment(new Comment("@Calebe_Sagaz", "1:17:20 Kratos mandando um novo áudio pro nosso menino Alan e ainda falando ''budega''. kkk"));
        video2.AddComment(new Comment("@chuckskullmage5444", "O cara atrasa atrasa os vídeo das 12hrs mas não atrasa os da 18hrs, não podemos deixar isso assim zokers"));
        videos.Add(video2);

        Video video3 = new Video("GANADOS de BRANCO? Tapete AZUL? - MOD WORLD S #8", "MasterReset", 2767);
        video3.AddComment(new Comment("@MasterReset7", "🎮 Participe do SORTEIO ➡ https://MasterReset.store/"));
        video3.AddComment(new Comment("@kakashi3268", "33:23 'Sacão' que isso meu amigo  Master kkkkk"));
        video3.AddComment(new Comment("@toarumajutsuverso2086", "Master nunca upa a velocidade de recarga das armas, Master também: Que merda vei nunca da tempo de recarregar kkkkkkkkkkkkk, ta óbvio que a velocidade dos inimigos no Mod esta maior, o ganado ataca e recupera muito rápido e já ta encima, tu tem que upar velocidade de recarga das armas cara, isso não é desperdício, é necessário, desde a série do resident evil 4 remake o master comete esses erros, e nunca se da conta, recarga e quantidade de balas é importante também, para de focar só em fire power mano."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetAllComment())
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._commentText}");
            }
            Console.WriteLine();
        }
    }
}