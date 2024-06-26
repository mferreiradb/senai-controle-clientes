using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f), Pessoa Juridica (j)");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar RG");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar CPF");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar valor da compra");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Física --------");

                Console.WriteLine("Nome: " + pf.nome);
                Console.WriteLine("Endereço: " + pf.endereco);
                Console.WriteLine("RG: " + pf.rg);
                Console.WriteLine("CPF: " + pf.cpf);
                Console.WriteLine("Valor da compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Valor do imposto: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Valor total: " + pf.total.ToString("C"));
            }
            if(var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar valor da compra");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Juridica --------");

                Console.WriteLine("Nome: " + pj.nome);
                Console.WriteLine("Endereço: " + pj.endereco);
                Console.WriteLine("CNPJ: " + pj.cnpj);
                Console.WriteLine("IE: " + pj.ie);
                Console.WriteLine("Valor da compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Valor do imposto: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Valor total: " + pj.total.ToString("C"));
            }
        }
    }
}