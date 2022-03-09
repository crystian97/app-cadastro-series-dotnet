using DIO.SERIES.Interfaces;

namespace DIO.SERIES.classes
{
    public class SerieRepositorio: IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id]=objeto;
            throw new System.NotImplementedException();
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            throw new System.NotImplementedException();
        }
        public void insere(Serie objeto)
        {
            listaSerie.Add(objeto);
            throw new System.NotImplementedException();
        }
        public List<Serie> Lista()
        {
            return listaSerie;
            throw new System.NotImplementedException();
        }
        public int ProximoId()
        {
            return listaSerie.Count;
            throw new System.NotImplementedException();
        }
        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
            throw new System.NotImplementedException();
        }
      
        public void Insere (Serie entidade)
        {
            throw new System.NotImplementedException();
        }
    }
}