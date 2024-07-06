using AplikasiBarbershop.DataModel;

namespace AplikasiBarbershop.Repositories
{
    public interface InterfaceCrud<T>
    {
        T Create(T model);
        Task<ResponseResult> ReadAll();
        ResponseResult ReadById(int id);
        T Update(T model);
        T Delete(int id);
    }
}
