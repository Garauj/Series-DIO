using Dio.Series.Interface;
using System;
using System.Collections.Generic;


namespace Dio.Series
{
    public class SerieRepositorio : Irepositorio<Serie>
    {
        private List<Serie> listaserie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
           listaserie[id]= entidade;
        }

        public void Exclui(int id)
        {
            listaserie[id].Excluir();
            //aqui dá pra colcar um envio de e-mail ao
        }

        public void Insere(Serie objeto)
        {
            listaserie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaserie;
        }

        public int ProximoId()
        {
            return listaserie.Count;
        }

        public Serie RetornaPorId(int id)
        {
           return listaserie[id];
        }
    }
}