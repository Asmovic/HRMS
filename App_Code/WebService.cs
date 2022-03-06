using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using Newtonsoft.Json;


/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
 [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }



    List<BookingPayment> payment = new List<BookingPayment>()
    {
        new BookingPayment { RoomId = 001, RoomType = "AC Deluxe", BookingStatus = "Pending"},
        new BookingPayment { RoomId = 002, RoomType = "NO AC Deluxe", BookingStatus = "Booked"},
        new BookingPayment { RoomId = 003, RoomType = "AC Diplomat", BookingStatus = "Free"},
        new BookingPayment { RoomId = 004, RoomType = "AC Executive", BookingStatus = "Pending"}

       };
   

    [WebMethod]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
    public void  HotelBookingStatus()
    {

        JavaScriptSerializer js = new JavaScriptSerializer();
        Context.Response.Clear();
        Context.Response.ContentType = "application/json";
        Context.Response.Write(js.Serialize(payment));
  
        
    }
    [WebMethod]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
    public void HotelBookingStatusById(int roomId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        Context.Response.Clear();
        Context.Response.ContentType = "application/json";

        List<BookingPayment> tst = payment.Where(p => p.RoomId == roomId).ToList();
   
        if (tst.Equals(""))
        {

            Console.WriteLine("Room nunmber not found");
        }
        else
        {
            Context.Response.Write(js.Serialize(payment.Where(p => p.RoomId == roomId).ToList()));
        }

       
        
    }

    public class BookingPayment
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public string BookingStatus { get; set; }
    }

    [WebMethod]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
    public void StaffInfo()
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        Context.Response.Clear();
        Context.Response.ContentType = "application/json";

        List<Info> lst = new List<Info>();


        using (SqlConnection objConn = DBConnection.Connect())
        {
            using (SqlCommand sqlcmd = new SqlCommand())
            {
                sqlcmd.Connection = objConn;
                sqlcmd.CommandText = "select * from Staff_Master ";
                SqlDataReader dq = sqlcmd.ExecuteReader();
                while (dq.Read())
                {
                    string stId = dq[0].ToString().Trim();
                    string sn = dq[1].ToString().Trim();
                    string fn = dq[2].ToString().Trim();
                    string ln = dq[3].ToString().Trim();

                    lst.Add(new Info { staffId = stId, surname = sn, firstName = fn, lastName = ln });
                }

            }
        }
      
        Context.Response.Write(js.Serialize(lst));
        
    }

}

public class Info
{

    public string staffId { get; set; }
    public string surname { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }

}



    