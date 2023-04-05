//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a));


Console.WriteLine($"Informe seu nome");
string nome = Console.ReadLine();

while (nome == "")
{
    Console.WriteLine($"digite novamente seu nome: ");
    nome = Console.ReadLine();    
}


Console.WriteLine($"Informe sua idade");
int idade = int.Parse(Console.ReadLine());

while ((idade < 0 || idade >100))
{
    Console.WriteLine($"Digite sua idade novamente");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"informe seu salário");
float salario = float.Parse(Console.ReadLine());

while (salario == 0) 
{
    Console.WriteLine($"digite seu salário novamente");
    salario = float.Parse(Console.ReadLine());
}

Console.WriteLine(@$"
Me informe seu estado civil usando
s para solteiro
c para casado
v para viuvo
d para divorciado
");

char estCivil = char.Parse(Console.ReadLine());

while (estCivil != 's' && estCivil != 'c' && estCivil != 'v' && estCivil != 'v') {
    Console.WriteLine($"digite seu estado civil de novo");
    estCivil = char.Parse(Console.ReadLine());
}






