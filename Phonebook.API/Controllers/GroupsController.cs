using Phonebook.BusinessLogic.Services;
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
    }
}
