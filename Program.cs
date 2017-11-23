using System;
using System.Security.Cryptography;
using System.Text;

namespace SysLog
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            bool status = false;
            
            do
            {   

                op = Convert.ToInt32(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        System.Console.WriteLine("Digite o nome: ");
                        string nome = Console.ReadLine();
                        System.Console.WriteLine("Digite a senha: ");
                        string senha = Console.ReadLine();
                        Usuario cas = new Usuario(senha,nome);
                        System.Console.WriteLine(cas.Cadastrar());
                    break;

                    case 2:
                        System.Console.WriteLine("Digite o nome: ");
                        nome = Console.ReadLine();
                        System.Console.WriteLine("Digite a senha: ");
                        senha = Console.ReadLine();
                        Usuario login = new Usuario(senha,nome);
                        if(login.Login())
                            status = true;
                    break;

                    default:
                    break;
                }
            } while (op != 9);
        }
    }
}
