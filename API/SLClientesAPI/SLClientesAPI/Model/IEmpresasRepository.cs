namespace SLClientesAPI.Model
{
    public interface IEmpresasRepository
    {
        void Add(Empresas empresas);
        void Update(Empresas empresas);
        void Delete(Empresas empresas);
        List<Empresas> GetAll();
    }
}
