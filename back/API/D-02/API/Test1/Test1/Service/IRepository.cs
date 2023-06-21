namespace Test1.Service
{
    public interface IRepository<T> where T : class
    {
        #region Get
        /// <summary>
        ///  Get Data 
        /// </summary>
        /// <returns> List of Entity</returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// GET by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Object of Entity</returns>
        Task<T> GetByIdAsync(int id);
        #endregion

        #region Add == POST
        /// <summary>
        /// Add new Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>void</returns>
        Task AddAsync(T entity);

        #endregion

        #region Update == PUT
        /// <summary>
        /// Update Object
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id"></param>
        /// <returns>Void</returns>
        Task UpdateAsync(T entity, int id);

        #endregion

        #region Delete
        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Deleted Object </returns>
        Task DeleteAsync(int id);

        #endregion
    }
}
