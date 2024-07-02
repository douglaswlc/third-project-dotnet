// int a = 22;
// int b = 20;

// int c = a + b;

// c += 5;

// c -= 5;

// c /= 5;

// c *= 5;

// Console.WriteLine(c);

// -----------------------------------------------

// Cast or Casting

// int a = Convert.ToInt32("10");

// int b = int.Parse("15");


// int inteiro = 5;
// string c = inteiro.ToString();

// Console.WriteLine(c);

// -----------------------------------------------

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 11;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// if (quantidadeCompra == 0)
// {
//   Console.WriteLine("Venda inválida!");
// }
// else if (possivelVenda)
// {
//   Console.WriteLine("Venda realizada!");
// }
// else
// {
//   Console.WriteLine($"Desculpe, temos apenas {quantidadeEmEstoque} produtos no estoque");
// }


// -----------------------------------------------

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;

//   default:
//     Console.WriteLine("Não é uma vogal");
//     break;
// }


// -----------------------------------------------

// bool ehMaiorDeIdade = true;
// bool temAutorizacaoDoResposavel = false;

// if (ehMaiorDeIdade || temAutorizacaoDoResposavel)
// {
//   Console.WriteLine("Entrada liberada!");
// }
// else
// {
//   Console.WriteLine("Entrada não liberada!");
// }


// -----------------------------------------------

// bool possuiPresencaMinima = true;
// double media = 8.3;

// if (possuiPresencaMinima && media >= 7)
// {
//   Console.WriteLine("Aprovado!");
// }
// else
// {
//   Console.WriteLine("Reprovado!");
// }


// -----------------------------------------------

bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{ 
  Console.WriteLine("Vou pedalar");
}
else 
{
  Console.WriteLine("VOu pedalar outro dia");
}