using System;
using System.Globalization;

class AumentoDeSalario
{

    static void Main(string[] args)
    {



        double salario = 0.00;

        double novoSalario = 0.00;

        double reajuste = 0.00;

        double percentual = 0;

        salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        //salario.ToString("F2", CultureInfo.InvariantCulture);




        if (salario <= 0.00)
        {
            return;
        }

        else if (salario > 0.00 && salario <= 400.00)
        {
            reajuste = salario * 0.15;
            novoSalario = salario + reajuste;
            percentual = ((novoSalario - salario) * 100) / salario;

        }
        else if (salario > 400.00 && salario <= 800.00)
        {
            reajuste = salario * 0.12;
            novoSalario = salario + reajuste;
            percentual = ((novoSalario - salario) * 100) / salario;
            
        }
        else if (salario > 800.00 && salario <= 1200.00)
        {
            reajuste = salario * 0.10;
            novoSalario = salario + reajuste;
            percentual = ((novoSalario - salario) * 100) / salario;
           
        }
        else if (salario > 1200.00 && salario <= 2000.00)
        {
            reajuste = salario * 0.07;
            novoSalario = salario + reajuste;
            percentual = ((novoSalario - salario) * 100) / salario;
            
        }
        else
        {
            //complete o codigo
            reajuste = salario * 0.04;
            novoSalario = salario + reajuste;
            percentual = ((novoSalario - salario) * 100) / salario;
            
        }


        Console.WriteLine("Novo salario: {0:0.00}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: {0:0} %", percentual);


    }

}