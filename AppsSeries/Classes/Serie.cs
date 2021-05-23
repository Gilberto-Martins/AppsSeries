using System;

namespace AppsSeries

{
    public class Serie : Base 
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}

        public Serie(int id,string Titulo, Genero Genero, string Descricao, int Ano, int episodios)
        {
            this.id = id; 
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Ano = Ano;
            this.Descricao = Descricao;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno = "Titulo: " + this.Titulo + Environment.NewLine;
            retorno = "Gênero: " + this.Titulo + Environment.NewLine;
            retorno = "Descrição: " + this.Descricao + Environment.NewLine;
            retorno = "Ano de lançamento: " + this.Ano + Environment.NewLine;
            return retorno;
        }

        public string retonaTitulo (){
            return this.Titulo;
        }

        public int retornaId (){
            return this.id;
        }

        public bool retornaExcluido(){
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}