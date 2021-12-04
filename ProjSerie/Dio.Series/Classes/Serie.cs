namespace Dio.Series
{


    public class Serie : EntidaBase
    {
        //Atributos
        private Genero Genero {get; set; }
        private string Titulo {get; set; }
        private string Inscricao {get; set; }
        private int Ano {get; set; }

        private bool Excluido{get; set;}

        //metodos

        public Serie ( int id, Genero genero, String titulo, string inscricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Inscricao = inscricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Inscrição: " + this.Inscricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
             retorno += "Excluído: " + this.Excluido;
        	return retorno;
		}
        public string retomatitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}