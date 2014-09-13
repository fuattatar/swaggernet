using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Swagger4Demo.Controllers
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Get all of the values.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a single Value by it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Post api/values
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Put api/values
        /// </summary>
        /// <param name="value"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Remove a Value by it's id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}