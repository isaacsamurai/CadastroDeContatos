using CadastroDeContatos.Models;

namespace CadastroDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);

        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Salvar (ContatoModel contato);
        bool Apagar(int id);
    }
}
