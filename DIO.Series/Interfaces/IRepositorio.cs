using System.Collections.Generic;
namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Exlcui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}