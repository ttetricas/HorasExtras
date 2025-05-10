Console.WriteLine("--Horas Extras--\n");

Console.Write("Digite o salário por hora base: R$ ");
double salarioHoraBase = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o número de horas trabalhadas no mês: ");
double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o número de horas extras trabalhadas no mês: ");
double horasExtras = Convert.ToDouble(Console.ReadLine());

double salarioBase = salarioHoraBase * horasTrabalhadas;

double valorHorasExtras = salarioHoraBase * 1.4;

double valorHoraExtra = horasExtras * valorHorasExtras;

double salarioTotal = salarioBase + valorHoraExtra;

Console.WriteLine("O salário total a ser recebido é de: R$" + salarioTotal);




