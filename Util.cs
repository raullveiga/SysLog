using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SysLog{
    public class Util{
        public string encripSenha(string senha){
            
            byte[] senhaOriginal, senhaModificada;
            SHA512 md5;

            senhaOriginal = Encoding.Default.GetBytes(senha);
            md5 = SHA512.Create();
            senhaModificada = md5.ComputeHash(senhaOriginal);
            return Convert.ToBase64String(senhaModificada);
        }
    }
}