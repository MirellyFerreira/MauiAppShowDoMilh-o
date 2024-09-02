using MauiAppShowDoMilhão.Models;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace MauiAppShowDoMilhão
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                    new Alternativa { Correta = false, Descricao = "GASOSO" },
                    new Alternativa { Correta = false, Descricao = "VAPOROSO" },
                }
            },

            new Pergunta
            {
                Id = 2,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MONSTRO" },
                    new Alternativa { Correta = false, Descricao = "GORILA"},
                    new Alternativa { Correta = false, Descricao = "PRÍNCIPE"},
                    new Alternativa { Correta = false, Descricao = "SAPO"},
                }

            },

            new Pergunta
            {
                Id = 3,
                Enunciado = "Quem proclamou a república no Brasil em 1889",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RONDON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO II"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },

            new Pergunta
            {

                Id = 4,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "HARRISON FORD"},
                    new Alternativa { Correta = false, Descricao = "GERALD FORD"},
                    new Alternativa { Correta = true, Descricao = "HENRY FORD"},
                    new Alternativa { Correta = false, Descricao = "ANNA FORD"},
                    
                }
            },

            new Pergunta
            {

                Id = 5,
                Enunciado = "Quem tem por lema a frase: 'Sempre alerta'?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "MÉDICOS"},
                    new Alternativa { Correta = true, Descricao = "ESCOTEIROS"},
                    new Alternativa { Correta = false, Descricao = "BOMBEIROS"},
                    new Alternativa { Correta = false, Descricao = "POLICIAIS"},
                }
            },

            new Pergunta
            {
                Id=6,
                Enunciado = "Em qual país surgiu a máfia?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "ESTADOS UNIDOS"},
                    new Alternativa { Correta = false, Descricao = "INGLATERRA"},
                    new Alternativa { Correta = true, Descricao = "ITÁLIA"},
                    new Alternativa { Correta = false, Descricao = "ESPANHA"},
                }

            },

            new Pergunta
            {
                Id=7, 
                Enunciado = "Quem é o inimigo do Piu-Piu nos desenhos animados?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "FÉLIX"},
                    new Alternativa { Correta = false, Descricao = "TOM"},
                    new Alternativa { Correta = true, Descricao = "FRAJOLA"},
                    new Alternativa { Correta = false, Descricao = "MINGAU"},
                }
            },

            new Pergunta
            {
                Id =8,
                Enunciado = "Qual é o significado da frase inglesa 'i love you'?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "BOM DIA"},
                    new Alternativa { Correta = true, Descricao = "EU TE AMO"},
                    new Alternativa { Correta = false, Descricao = "ATÉ LOGO"},
                    new Alternativa { Correta = false, Descricao = "ESTOU COM FOME"},
                }
            },

            new Pergunta
            {

                Id =9,
                Enunciado = "Qual a planta que fortalece o marinheiro Popoye?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "ALFACE"},
                    new Alternativa { Correta = true, Descricao = "ESPINAFRE"},
                    new Alternativa { Correta = false, Descricao = "CENOURA"},
                    new Alternativa { Correta = false, Descricao = "REPOLHO"},
                }
            },

            new Pergunta
            {
                
                Id =10,
                Enunciado = "Quem é o Homem de Aço das histórias em quadrinhos?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "BATMAN"},
                    new Alternativa { Correta = false, Descricao = "HUCK"},
                    new Alternativa { Correta = false, Descricao = "HE-MAN"},
                    new Alternativa { Correta = true, Descricao = "SUPER-HOMEM"},
                }
            },

            new Pergunta
            {

                Id=11,
                Enunciado = "Como se chama o lugar onde se guardam vinhos?",
                Alternativas = new()
                {

                    new Alternativa { Correta = true, Descricao = "ADEGA"},
                    new Alternativa { Correta = false, Descricao = "BIBLIOTECA"},
                    new Alternativa { Correta = false, Descricao = "SÓTÃO"},
                    new Alternativa { Correta = false, Descricao = "SALA"},
                }
            },

            new Pergunta
            {
                Id=12,
                Enunciado = "Qual era o código da identidade secreta de James Bond?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "707"},
                    new Alternativa { Correta = false, Descricao = "907"},
                    new Alternativa { Correta = true, Descricao = "007"},
                    new Alternativa { Correta = false, Descricao = "008"},
                }

            },

            new Pergunta
            {
                Id =13,
                Enunciado = "Qual ator do cinema brasileiro é conhecido por ter unhas enormes?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "PENADINHO"},
                    new Alternativa { Correta = true, Descricao = "ZÉ DO CAIXÃO"},
                    new Alternativa { Correta = false, Descricao = "ZÉ DO CASARÃO"},
                    new Alternativa { Correta = false, Descricao = "TONINHO DO DIABO"},
                }

            },

            new Pergunta
            {
                Id = 14,
                Enunciado = "Quando é comemorado o dia da mentira no Brasil?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "28 DE DEZEMBRO"},
                    new Alternativa { Correta = false, Descricao = "7 DE SETEMBRO"},
                    new Alternativa { Correta = true, Descricao = "1 DE ABRIL"},
                    new Alternativa { Correta = false, Descricao = "15 DE NOVEMBRO"},
                }

            },

            new Pergunta
            {
                Id=15,
                Enunciado = "Quantos titulares possui uma equipe de vôlei?",
                Alternativas = new()
                {

                    new Alternativa { Correta = false, Descricao = "CINCO"},
                    new Alternativa { Correta = true, Descricao = "SEIS"},
                    new Alternativa { Correta = false, Descricao = "SETE"},
                    new Alternativa { Correta = false, Descricao = "OITO"},
                }
            },

        };

        List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                 Id = 1,
                 Enunciado = "Que animais são criados nas pocilgas?",
                 Alternativas = new()
                 {
                     new Alternativa { Correta = false, Descricao = "CAMELO"},
                     new Alternativa { Correta = false, Descricao = "BÚFALOS"},
                     new Alternativa { Correta = false, Descricao = "CARNEIROS"},
                     new Alternativa { Correta = true, Descricao = "PORCOS"},

                 }
            },

            new Pergunta
            {
                Id= 2,
                Enunciado = "Que colônia britânica foi devolvida à China em 1997?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PEQUIM"},
                    new Alternativa { Correta = false, Descricao = "HANÓI"},
                    new Alternativa { Correta = true, Descricao = "HONG KONG"},
                    new Alternativa { Correta = false, Descricao = "HIROSHIMA"},

                }
            },

            new Pergunta
            {
                Id=3,
                Enunciado = "Como é chamada a doença que causa perda desigual da melanina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ASTIGMATISMO"},
                    new Alternativa { Correta = false, Descricao = "TENDINITE"},
                    new Alternativa { Correta = true, Descricao = "VITILIGO"},
                    new Alternativa { Correta = false, Descricao = "VITINGA"},
                }
            },

            new Pergunta
            {
                Id = 4,
                Enunciado = "O que os filatelistas colecionam?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "QUADROS"},
                    new Alternativa { Correta = true, Descricao = "SELOS"},
                    new Alternativa { Correta = false, Descricao = "FIGURINHAS"},
                    new Alternativa { Correta = false, Descricao = "MOEDAS"},

                }
            },

            new Pergunta
            {
                Id = 5,
                Enunciado = "Em que cidade está situada a famosa Praça Vermelha?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MOSCOU"},
                    new Alternativa { Correta = false, Descricao = "BERLIM"},
                    new Alternativa { Correta = false, Descricao = "PARIS"},
                    new Alternativa { Correta = false, Descricao = "ROMA"},
                }
            },

            new Pergunta
            {
                Id= 6,
                Enunciado ="Qual é o nome do vulcão que ,sepultou cidades na Itália no ano de 79?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VÊNUS"},
                    new Alternativa { Correta = true, Descricao = "VÊSUVIO"},
                    new Alternativa { Correta = false, Descricao = "VARSÓVIA"},
                    new Alternativa { Correta = false, Descricao = "VENEZA"},
                }

            },

            new Pergunta
            {
                Id= 7,
                Enunciado= "Qual é a história que Francis Ford Coppola dirigiu em três partes?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TITANIC"},
                    new Alternativa { Correta = false, Descricao = "SEXTA - FEIRA 13"},
                    new Alternativa { Correta = true, Descricao = "O PODEROSO CHEFÂO"},
                    new Alternativa { Correta = false, Descricao = "GUERRA NAS ESTRELRAS"},
                }

            },

            new Pergunta
            {
                Id = 8,
                Enunciado = "Quem disse a frase: “Vim, vi e venci”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARCO ANTONIO"},
                    new Alternativa { Correta = false, Descricao = "CALIGULA"},
                    new Alternativa { Correta = false, Descricao = "NERO"},
                    new Alternativa { Correta = true, Descricao = "JULIO CÉSAR"},
                }

                
            },

            new Pergunta
            {
                Id=9,
                Enunciado = "Quais são os naipes vermelhos do baralho?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "COPAS E PAUS"},
                    new Alternativa { Correta = true, Descricao = "OUROS E COPAS"},
                    new Alternativa { Correta = false, Descricao = "PAUS E OUROS"},
                    new Alternativa { Correta = false, Descricao = "ESPADAS E PAUS"},
                }


            },

            new Pergunta
            {
                Id=10,
                Enunciado = "Qual é o país que participou de todas as copas do mundo de futebol, até 1998?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao= "ITÁLIA"},
                    new Alternativa { Correta = false, Descricao = "URUGUAI"},
                    new Alternativa { Correta = false, Descricao = "ARGENTINA"},
                    new Alternativa { Correta = true, Descricao = "BRASIL"},
                }


            },

        };

        List<Pergunta> perguntas_dificeis = new()
        {

            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual produto gerou guerras e conflitos no século XX?",
                Alternativas= new()
                {
                    new Alternativa{ Correta = false, Descricao = "ÁLCOOL" },
                    new Alternativa{ Correta = true, Descricao = "PETRÓLEO"},
                    new Alternativa{ Correta = false, Descricao= "OURO" },
                    new Alternativa{ Correta = false, Descricao= "ALUMÍNIO" },
                }

            },

            new Pergunta
            {
                Id= 2,
                Enunciado = "Em que país Leonardo da Vinci viveu seus últimos dias?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao = "ESPANHA" },
                    new Alternativa{ Correta = false, Descricao = "HOLANDA"},
                    new Alternativa{ Correta = true, Descricao = "FRANÇA"},
                    new Alternativa{ Correta = false, Descricao = "ITÁLIA"},
                }
            },

            new Pergunta
            {
                Id=3,
                Enunciado = "Quem ganhou a 1ª medalha de ouro olímpico para o Brasil",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "AFRANIO ANTONIO COSTA"},
                    new Alternativa { Correta = true, Descricao = "GUILHERME PARAENSE"},
                    new Alternativa { Correta = false, Descricao = "FERNANDO SOLEDADE"},
                    new Alternativa { Correta = false, Descricao = "SEBASTIÃO WOLF"},
                }
            },

             new Pergunta
             {
                Id=4,
                Enunciado = "Qual atleta foi desclassificado por uso de doping nas Olimpíadas de 1988?",
                Alternativas = new()
                { 
                    new Alternativa { Correta = false, Descricao = "MIKE POWELL"},
                    new Alternativa { Correta = true, Descricao = "BEN JOHNSON"},
                    new Alternativa { Correta = false, Descricao = "CARL LEWIS"},
                    new Alternativa { Correta = false, Descricao = "LINFORD CHRISTIE"},
                }
             },

             new Pergunta
             {
                Id=5,
                Enunciado = "O que construía Stradivarius?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CASAS"},
                    new Alternativa { Correta = true, Descricao = "VIOLINOS"},
                    new Alternativa { Correta = false, Descricao = "ARMAS"},
                    new Alternativa { Correta = false, Descricao = "ESTRADAS"},
                }
             },

             new Pergunta
             {
                Id=6,
                Enunciado = "A que país deve-se viajar para subir o Monte Parnaso?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ITÁLIA"},
                    new Alternativa { Correta = false, Descricao = "FRANÇA"},
                    new Alternativa { Correta = true, Descricao = "GRÉCIA"},
                    new Alternativa { Correta = false, Descricao = "TURQUIA"},
                }
             },

             new Pergunta
             { 
                Id=7,
                Enunciado = "Em que ano foi inaugurada a estátua do Cristo Redentor no Rio de Janeiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1921"},
                    new Alternativa { Correta = false, Descricao = "1941"},
                    new Alternativa { Correta = true, Descricao = "1931"},
                    new Alternativa { Correta = false, Descricao = "1951"},
                }
             },

             new Pergunta
             {
                Id=8,
                Enunciado = "Que significa o prefixo exo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DENTRO DE"},
                    new Alternativa { Correta = false, Descricao = "DEBAIXO DE"},
                    new Alternativa { Correta = true, Descricao = "FORA DE"},
                    new Alternativa { Correta = false, Descricao = "ATRÁS DE"},
                }
             },

             new Pergunta
             {
                Id=9,
                Enunciado = "Que nome recebe a foz de um rio que se abre para o mar?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ALAGADO"},
                    new Alternativa { Correta = false, Descricao = "MANGUEZAL"},
                    new Alternativa { Correta = false, Descricao = "PÂNTANO"},
                    new Alternativa { Correta = true, Descricao = "ESTUÁRIO"},
                }
             },

             new Pergunta
             {
                Id=10,
                Enunciado = "Em que país você pode gastar rublos?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "HOLANDA"},
                    new Alternativa { Correta = false, Descricao = "ESPANHA"},
                    new Alternativa { Correta = false, Descricao = "ÁFRICA DO SUL"},
                    new Alternativa { Correta = true, Descricao = "RÚSSIA"},
                }
             },

        };
        List<Pergunta> perguntas_sorteadas = new()
        {

        };

        public static Pergunta getRadowPerguntaFacil()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 15);
                pergunta_sorteada = perguntas_faceis[sorteado];

                if (!perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }
            return pergunta_sorteada;
        }
        

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
