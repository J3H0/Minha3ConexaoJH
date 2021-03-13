using Minha3ConexaoJH.Data.Interface;
using Minha3ConexaoJH.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Minha3ConexaoJH.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity
    {
        protected readonly Context _context;
        public BaseRepository(Context context)
        {
            _context = context;
        }

        public virtual void Incluir(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Alterar(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public T Selecionar(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> SelecionarTudo()
        {
            return _context.Set<T>().ToList();
        }

        public void Excluir(int id)
        {
            var entity = Selecionar(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
