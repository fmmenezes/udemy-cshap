﻿using System;

namespace A45Exercicio02
{
    class Program

    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcioanrio: " + func);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porc = double.Parse(Console.ReadLine());
            func.AumentarSalario(porc);
            Console.WriteLine("Dados atualizados: " + func);

        }

    }
}
