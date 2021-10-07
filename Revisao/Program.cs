using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine(); 
                        Console.WriteLine("Informe a nota:");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota ))
                            aluno.Nota = nota;
                        else
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
    
                    case "2":
                        //TODO: listar alunos
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                                Console.WriteLine($"Aluno:{a.Nome} - Nota: {a.Nota}");
                        }
                        break;
                    case "3":
                        //TODO: calcular a media geral
                        decimal mediaGeral;
                        Conceito conceitoGeral;
                        DefinirConceito(alunos, out mediaGeral, out conceitoGeral);

                        Console.WriteLine($"MÉDIA GERAL{mediaGeral} - CONCEITO: {conceitoGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void DefinirConceito(
            Aluno[] alunos, 
            out decimal mediaGeral, 
            out Conceito conceitoGeral)
            {

            decimal notaTotal = 0;
            var nrAlunos = 0;
            for (int i = 0; i < alunos.Length; i++)
            {
                if (!string.IsNullOrEmpty(alunos[i].Nome))
                {
                    notaTotal = notaTotal + alunos[i].Nota;
                    nrAlunos++;
                }
            }
            mediaGeral = notaTotal / nrAlunos;
            if (mediaGeral < 2)
                conceitoGeral = Conceito.E;
            else if (mediaGeral < 4)
                conceitoGeral = Conceito.D;
            else if (mediaGeral < 6)
                conceitoGeral = Conceito.C;
            else if (mediaGeral < 8)
                conceitoGeral = Conceito.B;
            else
                conceitoGeral = Conceito.A;
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("\nInforme a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
