namespace Aula26Interface
{
    public interface ICarrinho
    {
         void Listar();
         void Adicionar(Produto produto);
         void Alterar(int _codigo, Produto produto);
         void Deletar(Produto produto);
    }
}