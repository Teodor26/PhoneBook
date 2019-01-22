using Phonebook.BusinessLogic.Services;
using Phonebook.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Phonebook.API.Controllers
{
    public class GroupsController : ApiController
    {

        public readonly IGroupService _groupService;

        public GroupsController()
        {
            _groupService = new GroupService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var groups = _groupService.GetList();

            return Ok(groups);
        }


        [HttpPost]

        public IHttpActionResult Add([FromBody]Group group)
        {
            //if (string.IsNullOrEmpty(group.Name))
            //    return BadRequest("OOppps");

            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);


            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetFake()
        {
            return Ok("fake");
        }
    }
}
