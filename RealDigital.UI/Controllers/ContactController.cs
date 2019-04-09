using Microsoft.AspNetCore.Mvc;
using RealDigital.Application.ILogic;
using RealDigital.Application.Models;
using RealDigital.Application.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        #region Fields

        private readonly IContactLogic _contactLogic;

        #endregion Fields

        #region Constructors

        public ContactController(IContactLogic contactLogic)
        {
            _contactLogic = contactLogic;
        }

        #endregion Construtors

        #region Methods

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactViewModel>>> GetAllAsync()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContactViewModel>> GetById()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<ContactViewModel>> Insert(ContactModel contactModel)
        {
            return Created("", null);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, ContactModel contactModel)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            return Ok();
        }

        #endregion Methods
    }
}
