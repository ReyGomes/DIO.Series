using System;

namespace Dio.Series
{
    public class Filme : EntidadeBase
    {
        public string Titulo{get;set;}
        public string Descricao{get;set;}
        public int Ano{get;set;}
        public Genero Genero{get;set;}
        public bool Excluido{get;set;}

        public Filme(int id,Genero genero,string titulo,string descricao, int ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno ="" ;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Exclido: " + this.Excluido;
            
            return retorno;
        
        }
        public string retornaTitulo(){
            return this.Titulo;
        }
        public int retornaId(){
            return this.Id;
        }
        public bool retornaExcluido(){
            return this.Excluido;
        }
        public void Excluir(){
            this.Excluido = true;
        }

    }
}