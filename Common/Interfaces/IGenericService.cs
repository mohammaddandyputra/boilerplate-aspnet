using boilerplate_aspnet.Models;
namespace boilerplate_aspnet.Common.Interface;
public interface IGenericService<M, CreateDTO, UpdateDTO>
{
    Task<IEnumerable<M>> getList();
    Task<M> get(Guid id);
    Task<M> create(CreateDTO body);
    Task<M> update(UpdateDTO body, Guid id);
}