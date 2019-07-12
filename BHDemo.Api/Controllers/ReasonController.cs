using BHDemo.Common.Dto;
using BHDemo.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BHDemo.Api.Controllers
{
    /// <summary>
    /// Provides read and write functionality for ReasonDto objects.
    /// </summary>
    [RoutePrefix("api/v1/Reason")]
    public class ReasonController : ApiController
    {
        private readonly ReasonRepository repo = new ReasonRepository();

        /// <summary>
        /// Returns the list of all Reasons available.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public IEnumerable<ReasonDto> Get()
        {
            return repo.List();
        }

        /// <summary>
        /// Returns the Reason that matches the provided ID.
        /// </summary>
        /// <param name="id">The ID of the Reason to fetch from the data store.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int}")]
        public ReasonDto Get([FromUri] int id)
        {
            return repo.GetById(id);
        }

        /// <summary>
        /// Creates and saves a new Reason.
        /// </summary>
        /// <param name="newItem">The new Reason to insert into the data store.</param>
        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody] ReasonDto newItem)
        {
            var item = repo.Insert(newItem);
            return Ok(item);
        }

        /// <summary>
        /// Makes updates to the specified Reason from the properties in the <param name="updatedItem"></param>.
        /// </summary>
        /// <param name="id">The ID of the Reason to update.</param>
        /// <param name="updatedItem">The Reason with the updated properties.</param>
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult Put([FromUri] int id, [FromBody] ReasonDto updatedItem)
        {
            var item = repo.Update(updatedItem);
            return Ok(item);
        }

        /// <summary>
        /// Deletes the Reason with the specified ID from the data store.
        /// </summary>
        /// <param name="id">The ID of the Reason to delete.</param>
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete([FromUri] int id)
        {
            repo.Delete(id);
            return Ok();
        }
    }
}
