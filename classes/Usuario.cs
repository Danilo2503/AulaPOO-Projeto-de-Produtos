using System;

namespace AulaPOO_Projeto_de_Produtos.classes
{
    public class Usuario
    {
        public Usuario(){
            Cadastrar();
        }

        public Usuario(int codigo, string nome, string email, string senha){
            Codigo = codigo;
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCadastro = DateTime.UtcNow;
        }

        int Codigo {get;set;}
        string Nome {get;set;}
        string Email {get;set;}
        string Senha {get;set;}
        DateTime DataCadastro {get;set;}

        public void Cadastrar(){
            Nome = "Danilo";
            Email = "admin@admin.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;
        }

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}