using System;

string nome;
int senha;
int receberSenha;
string receberNome;




Console.WriteLine("Registre seu Nome");
nome = Console.ReadLine();

Console.WriteLine("Registre sua Senha");
senha = int.Parse(Console.ReadLine());

Console.WriteLine("Usuario Registrado!");

Console.WriteLine("Faça seu Login");

Console.WriteLine("Digite seu Nome: ");
receberNome = Console.ReadLine();



if (nome == receberNome)
{
    Console.WriteLine("Nome Correto! ");
    

} else { Console.WriteLine("Nome Incorreto"); }

while (nome != receberNome)
{
    Console.WriteLine("Nome Incorreto digite novamente! ");
    receberNome = Console.ReadLine();
};


Console.WriteLine("Digite sua senha");
receberSenha = int.Parse(Console.ReadLine());


if (senha == receberSenha)
{
    Console.WriteLine("Senha Correta!");
    
} else { Console.WriteLine("Senha Incorreta!"); }

while (senha != receberSenha)
{
    Console.WriteLine("Senha Incorreta Digite Novamente! ");
    receberSenha = int.Parse(Console.ReadLine());

}




Console.WriteLine("Logado com sucesso");








