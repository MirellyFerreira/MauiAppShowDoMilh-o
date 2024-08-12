using MauiAppShowDoMilhão.Models;

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
                Enunciado = ""
            }

        };


        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
