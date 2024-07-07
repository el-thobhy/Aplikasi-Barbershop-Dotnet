using AplikasiBarbershop.DataModel;

namespace AplikasiBarbershop.Repositories
{
    public interface InterfaceCrud<T>
    {
        Task<ResponseResult> Create(T model);
        Task<ResponseResult> ReadAll();
        Task<ResponseResult> ReadById(int id);
        Task<ResponseResult> Update(T model);
        Task<ResponseResult> Delete(int id);
    }
}
