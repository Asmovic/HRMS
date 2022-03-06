using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for PaymentWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class PaymentWebService : System.Web.Services.WebService {



    //[WebMethod]

    //List<BookingPayment> payment = new List<BookingPayment>()
    //{
    //    new BookingPayment { RoomId = 001, RoomType = "AC Deluxe", BookingStatus = "Pending"},
    //    new BookingPayment { RoomId = 002, RoomType = "NO AC Deluxe", BookingStatus = "Booked"},
    //    new BookingPayment { RoomId = 003, RoomType = "AC Diplomat", BookingStatus = "Free"},
    //    new BookingPayment { RoomId = 004, RoomType = "AC Executive", BookingStatus = "Pending"}
    //};

    //public List<BookingPayment> HotelBookingStatus()
    //{
    //    return payment;
    //}
    //public List<BookingPayment> HotelBookingStatus(int RoomId)
    //{
    //    return payment.Where(p => p.RoomId == RoomId).ToList();
    //}

    //public class BookingPayment
    //{
    //    public int RoomId { get; set; }
    //    public string RoomType { get; set; }
    //    public string BookingStatus { get; set; }
    //}   
    public string HelloWorld() {
        return "Hello World";
    }
    
}
