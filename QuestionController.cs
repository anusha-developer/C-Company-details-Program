using CompanyTask.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompanyTask.Controllers
{
    public class QuestionController : ApiController
    {
        

        [HttpGet]
        [Route("api/getQuetion")]
        public List<Questions> GettblQuestions1()
        {
            List<Questions> qns = new List<Questions>();
            Questions Q1 = new Questions();

            SqlConnection con = null;
            try
            {

                con = new SqlConnection("data source=.;database=Task;integrated security=SSPI");
                con.Open();
                //SqlCommand cm = new SqlCommand("select * from tblQuestions1", con);
                //String Query = "select * from tblQuestions1";
                SqlCommand cm = new SqlCommand("select * from tblQuestions1", con);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Q1.QuestionsID = Convert.ToInt32(dr["QuestionsID"]);
                    Q1.QuestionsName = dr["QuestionsName"].ToString();
                    Q1.Description = dr["Description"].ToString();
                    Q1.Image = dr["Image"].ToString();
                    Q1.StartDate = Convert.ToInt32(dr["StartDate"]);
                    Q1.EndDate = Convert.ToInt32(dr["EndDate"]);
                    Q1.QuestionType = dr["QuestionType"].ToString();
                    qns.Add(Q1);
                }
            }
            catch (Exception ex)
            {
                con.Close();
            }


            return qns;


        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Question/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Question
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Question/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Question/5
        public void Delete(int id)
        {
        }
    }
}
