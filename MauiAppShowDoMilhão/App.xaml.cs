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





        };
        
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
