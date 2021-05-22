using System;

namespace AppsSeries

{
    public class Serie : Base 
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Esta_Lancando {get; set;}
        private int Episodios{get; set;}
        private bool Excluido {get; set;}

        public Serie(string Titulo, Genero Genero, string Descricao, int Ano, bool lancando, int episodios)
        {
            this.Titulo = Titulo;
            this.Genero = Genero;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Esta_Lancando = lancando;
            this.Episodios = episodios;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno = "Titulo: " + this.Titulo + Environment.NewLine;
            retorno = "Gênero: " + this.Titulo + Environment.NewLine;
            retorno = "Descrição: " + this.Descricao + Environment.NewLine;
            retorno = "Ano de lançamento: " + this.Ano + Environment.NewLine;
            retorno = "Esta em lançamento: " + this.Esta_Lancando + Environment.NewLine;
            retorno = "quantidade de Episodios: " + this.Episodios + Environment.NewLine;
            return retorno;
        }

        public string retonaTitulo (){
            return this.Titulo;
        }

        public int retornaId (){
            return this.id;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}