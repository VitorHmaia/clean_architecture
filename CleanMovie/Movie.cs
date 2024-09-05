namespace CleanMovie.Domain
{
    /// <summary>
    /// Representa um filme no domínio do sistema.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Identificador único do filme.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Título do filme.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Descrição do enredo ou informações sobre o filme.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Nome da empresa responsável pela produção do filme.
        /// </summary>
        public string ProductionCompany { get; set; }
    }
}
