using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
         
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                      //  AtualizarSerie();
                        break;
                    case "4":
                      //  ExcluirSerie();
                        break;
                    case "5":
                      //  VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio series");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();
            if(lista.Count == 0)
                Console.WriteLine("Nenhuma serie cadastrada");
            else
                foreach(var serie in lista)
                {
                    var excluido = serie.retornaExcluido();
                    Console.WriteLine("ID {0}: {1} - {2}", serie.retornaId(), serie.retornaTitulo(), excluido ? "*Excluido*" : "");
                }
        }
        private static void InserirSerie()
        {
            System.Console.WriteLine("Inserir nova série");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}",i, Enum.GetName(typeof(Genero),i));
            }
            System.Console.WriteLine("Digite o genêro entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o titulo da Série:");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de inicio da Série:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série:");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(
                id: repositorio.ProximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao
                );
            repositorio.Insere(novaSerie);
        }
        private static void AtualizarSerie()
        {
            System.Console.Write("Digite o id da série:");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.Write("Digite o gênero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de Inicio da Série:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie
            (
                id: indiceSerie,
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao
            );
            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exlcui(indiceSerie);
        }
    }
}
