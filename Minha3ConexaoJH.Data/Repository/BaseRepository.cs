using Minha3ConexaoJH.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Minha3ConexaoJH.Data.Repository
{
    public class BaseRepository<T> where T : class, IEntity
    {
        protected readonly Context context;
        public BaseRepository()
        {
            context = new Context();
        }

        public virtual void Incluir(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Alterar(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public T Selecionar(int id)
        {
            return context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> SelecionarTudo()
        {
            return context.Set<T>().ToList();
        }

        public void Excluir(int id)
        {
            var entity = Selecionar(id);
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
    }
}
