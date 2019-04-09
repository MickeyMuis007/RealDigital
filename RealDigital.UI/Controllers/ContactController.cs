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
            return Ok(await _contactLogic.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContactViewModel>> GetById(Guid id)
        {
            return Ok(await _contactLogic.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ContactViewModel>> Insert(ContactModel contactModel)
        {
            return Created("", await _contactLogic.Insert(contactModel));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, ContactModel contactModel)
        {
            await _contactLogic.Update(id, contactModel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _contactLogic.Delete(id);
            return NoContent();
        }

        #endregion Methods
    }
}
