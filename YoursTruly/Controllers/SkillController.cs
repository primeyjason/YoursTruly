using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Threading;
using YoursTruly.Models;
namespace YoursTruly.Controllers
{
    public class SkillController : ApiController
    {
        // GET api/<controller>


        private AssetDBContext assetDBContext = new AssetDBContext();
        public string Get()
        {
            var skillRetrievalTask = RetrieveSkillsAsync();

            

            var json =  Newtonsoft.Json.JsonConvert.SerializeObject(skillRetrievalTask.Result.ToList());

            return json; 
            
                             

        }


        private async Task<IQueryable<Skill>> RetrieveSkillsAsync()
        {
            var result = Task.Run<IQueryable<Skill>>(() =>
            {
                return (from skill in assetDBContext.Skills
                        select skill).AsQueryable();
            });

            return result.Result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}