using System;
using System.IO;
using System.Text;

namespace SysLog
{
    public class Usuario
    {
        public string Senha { get; set; }
        public string Nome { get; set; }


        public Usuario(string senha, string nome)
        {
            Senha = new Util().encripSenha(senha);
            Nome = nome;
        }

        public string Cadastrar()
        {
            string rt = "Cadastro não realizado";
            StreamWriter ar = null;

            try
            {
                ar = new StreamWriter("cadusUario.txt", true);
                ar.WriteLine(Nome + ";" + Senha);
                rt = "Cadastro efetuado com sucesso!";
            }
            catch (Exception e)
            {
                rt = "Falha ao realizar cadastro. " + e.Message;
            }
            finally
            {
                ar.Close();
            }
            return rt;
        }

        public bool Login()
        {
            bool rt = false;
            string c;
            StreamReader ar = null;
            {
                try
                {
                    ar = new StreamReader("cadUsuario.txt", Encoding.Default);
                    while ((c = ar.ReadLine()) != null)
                    {
                        string[] data = c.Split(';');
                        if ((data[1] == Senha) && data[0] == Nome);
                        rt = true;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Falha ao tentar realizar login: " + e.Message);
                }
                finally
                {
                    ar.Close();
                }
            }
            return rt;
        }
    }
}