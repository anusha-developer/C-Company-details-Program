using Companydetails.Models;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Companydetails.Controllers
{
    public class CompanyController : ApiController
    {
        // GET: api/Company
        [HttpGet]
        [Route("api/Companydetails")]
        public List<comp> GetCompanydetails()
        {
            List<comp> c = new List<comp>();
            comp cp= new comp();
            SqlConnection con = new SqlConnection("data source=.;database=Companydetails1,integrated security=false");
            try
            { 
            con.Open();
            string query = "select * from Companydetails";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cp = new comp();
                    cp.Sno = Convert.ToInt32(dr["Sno"]);
                    cp.Companyname = dr["Companyname"].ToString();
                    cp.Yearsofexp = Convert.ToInt32(dr["Yearsofexp"]);
                    cp.Techonologies = dr["Techonologies"].ToString();
                    cp.Date = (Date)dr["Date"];
                    cp.Jobapplicants = Convert.ToInt32(dr["Jobapplicants"]);
                    cp.Phonenum = dr[" Phonenum"].ToString();
                    cp.Location = dr["Location"].ToString();
                    cp.Openings = Convert.ToInt32(dr["Openings"]);
                    cp.Links = dr["Links"].ToString();
                    c.Add(cp);
                }

            }
            catch(Exception ex)
            {

            }
            return c;
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Company/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Company
        [HttpPost]
        [Route("api/insertCompanydetails")]

        public string insertcomp([FromBody] comp obj)

        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =.;database=Companydetails1,integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand("insert into Companydetails values(" + obj.Sno + ",'" + obj.Companyname + "'," + obj.Yearsofexp + ",'" + obj.Techonologies + "','" + obj.Date + "','" + obj.Jobapplicants + "','" + obj.Phonenum + "','" + obj.Location + "','" + obj.Openings + "','" + obj.Links + "');", con);
                SqlDataReader dr = cm.ExecuteReader();


            }
            catch (Exception ex)
            {

            }
            return "inserted data successfully";


        }



        // PUT: api/Company/5
        [HttpPut]
        [Route("api/updatecomp")]

        public string updatecomp(int id, [FromBody] comp cpdata)
        {
            SqlConnection con = new SqlConnection("data source=.;database=Companydetails1,integrated security=SSPI");
            con.Open();
            SqlCommand cm = new SqlCommand("update cpdata set Companyname='" + cpdata.Companyname + "',Yearsofexp = '" + cpdata.Yearsofexp + "' where id=3", con);
            cm.ExecuteNonQuery();
            con.Close();
            return "updated";
        }
        

        // DELETE: api/Company/5
        public void Delete(int id)
        {
        }
        [HttpDelete]
        [Route("api/comp")]
        public string comp(int Sno)
        {

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.;database=Companydetails1,integrated security=SSPI");
                con.Open();
                string query = "delete from Psdetails1 where Sno='" + Sno + "'";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader dr = cm.ExecuteReader();

            }
            catch (Exception ex)
            {
            }
            return "deleted";
        }
    }
}
