using Microsoft.AspNetCore.Mvc;
using Test1.Models;
using Test1.Service;

namespace Test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Fields
        IRepository<Student> _repository;
        #endregion
        #region Constructors
        public StudentController(IRepository<Student> repository)
        {
            this._repository = repository;
        }
        #endregion

        #region Methods
        #region Get

        #endregion

        #region Add

        #endregion

        #region update

        #endregion

        #region Delete

        #endregion
        #endregion
    }
}
