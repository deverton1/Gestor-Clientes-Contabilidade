using SLClientesAPI.Model;

namespace SLClientesAPI.Infrastructure
{
    public class EmpresasRepository : IEmpresasRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public List<Empresas> GetAll()
        {
            return _context.Empresas.ToList();
        }
        public void Add(Empresas empresas)
        {
            _context.Add(empresas);
            _context.SaveChanges();
        }

        public void Delete(Empresas empresas)
        {
            throw new NotImplementedException();
        }


        public void Update(Empresas empresas)
        {
            throw new NotImplementedException();
        }
    }
}
