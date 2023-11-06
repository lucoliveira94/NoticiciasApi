using System.Threading.Tasks;
using BlogNoticias.Data.Dtos;

namespace BlogNoticias.Services
{
    public interface IEditorService
    {
        Task Cadastra(CreateEditorDto editorDto);
        Task<string> Login(LoginEditorDto loginEditorDto);
    }
}
