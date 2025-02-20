using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;

namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// Ou seja, vamos implementar os métodos, toda a lógica dos metodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {

        /// <summary>
        /// Variavel privada e somente leitura que "Guarda" os dados do contexto
        /// </summary>
        private readonly Filmes_Context _context;

        /// <summary>
        /// Construtor do repositorio
        /// Aqui, toda vez que o construtor for chamado, os dados do contexto estarão disponiveis
        /// </summary>
        /// <param name="contexto">Dados do contexto</param>

        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;
        }


        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo para cadastrar um novo genero
        /// </summary>
        /// <param name="novoGenero">objeto genero a ser cadastrado</param>
        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //Adiciona um novo genero na tabela Generos(BD)
                _context.Generos.Add(novoGenero);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> listaGeneros = _context.Generos.ToList();
                return listaGeneros;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
