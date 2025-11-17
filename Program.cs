using DRAKE.models;


Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();






































// Aluno a1 = new Aluno();
// a1.Nome = "Gabriel";
// a1.Idade = 20;
// a1.Email = "gabrielolivr.16@gmail.com";
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "José";
// p1.Idade = 37;
// p1.Salario = 1000M;
// p1.Apresentar();

















































// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.Json", serializado);

// Console.WriteLine(serializado);





































// int numero = 144;
// bool ehPar = false;
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
































// Pessoa p1 = new Pessoa("Gabriel", "Estevam");
// (string nome, string sobrenome) = p1;


// Console.WriteLine($"{nome} {sobrenome}");


































// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivosLeitura.txt");
// if (sucesso)
// {
//     Console.WriteLine("Quantidade linhas do Arquivo:" + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("não foi possível ler o arquivo");
// }








































// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Gabriel", "Estevam", 1.70M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");





























// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


























// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivosLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Caminho não encontrado. " + ex.Message);
// }    
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }













































// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);



// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();



//  Pessoa p1 = new Pessoa();
//  p1.Nome = "Gabriel";
//  p1.Sobrenome = "Estevam";

//  Pessoa p2 = new Pessoa();
//  p2.Nome = "Jose";
//  p2.Sobrenome = "Eraldo";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();




// Pessoa p1 = new Pessoa();
// p1.Nome = "Gabriel";
// p1.Idade = 24;
// p1.Sobrenome = "Estevam";
// p1.Apresentar();