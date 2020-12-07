using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_registration.Context;
using web_registration.Models;
using web_registration.Providers;

namespace web_registration.Controllers
{
    public class AttendeeController : BaseController
    {
        private readonly IAttendeeProvider _attendeeProvider;
        private Random rng = new Random();  

        public AttendeeController(ApplicationDBContext context, 
                                 IAttendeeProvider attendeeProvider) : base(context) {
            _attendeeProvider = attendeeProvider;
        } 

        public IActionResult Index()
        {
            List<Attendee> attendees = _attendeeProvider.GetAttendees();
            return View(attendees);
        }

        public IActionResult Checkin(string code)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            attendee.isChecked = true;
            attendee.checkedDateTime = DateTime.Now;
            _context.SaveChanges();

            return Redirect("/attendee");
        }

        public IActionResult UnCheckin(string code)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            attendee.isChecked = false;
            attendee.checkedDateTime = null;
            _context.SaveChanges();

            return Redirect("/attendee");
        }

        public IActionResult BeginLottery() {
            return View();
        }

        public IActionResult Lottery()
        {
            var specialAttendees = new List<string>(){"1044461", "1044496", "1044355", "1044615", "1052492", "1075840", "1078732", "1075842", "1052488", "1052497"};
            List<Attendee> attendees = _attendeeProvider.GetAttendees().Where(x => specialAttendees.Contains(x.code) || ((x.isTemp ?? false) == false) && (x.isChecked ?? false)).ToList();
            attendees = Shuffle(attendees);

            Tuple<String, int, List<Attendee>>[] awardList =
            {
                Tuple.Create("Microwave Samsung มูลค่า 4,390 บาท", 1, new List<Attendee>()),
                Tuple.Create("เครื่องฟอกอากาศ Mi มูลค่า 5,790 บาท", 1, new List<Attendee>()),
                Tuple.Create("หม้อทอดไฟฟ้า Philips HD9220 มูลค่า 7,990 บาท", 1, new List<Attendee>()),
                // Tuple.Create("Fitbit Versa มูลค่า 8,990 บาท", 1, new List<Attendee>()),
                // Tuple.Create("Irobot Roomba605 มูลค่า 14,900 บาท", 1, new List<Attendee>()),
                // Tuple.Create("Gopro Max มูลค่า 16,500 บาท", 1, new List<Attendee>()),
                // Tuple.Create("ทองคำ 1 บาท", 1, new List<Attendee>()),
                // Tuple.Create("Canon EOS M50 มูลค่า 25,900  บาท", 1, new List<Attendee>()),
                // Tuple.Create("Ipad Air Cel+wifi 256 GB มูลค่า 27,400 บาท", 1, new List<Attendee>()),
                // Tuple.Create("Samsung note10 256GB มูลค่า 32,900 บาท", 1, new List<Attendee>()),
                // Tuple.Create("รางวัลจากคุณนิตยา", 1, new List<Attendee>()),
                // Tuple.Create("Iphone 11 Pro max 256 GB มูลค่า 45,900 บาท", 1, new List<Attendee>()),
                // Tuple.Create("Central 500 บาท 30 ใบ", 30, new List<Attendee>()),
                Tuple.Create("Central 1,000 บาท 40 ใบ", 40, new List<Attendee>()),
                Tuple.Create("Starbucks 300 บาท 60 ใบ", 60, new List<Attendee>()),
                Tuple.Create("Starbucks 500 บาท 30 ใบ", 30, new List<Attendee>())
            };

            var lotteryAttendeeViewModels = new List<LotteryAttendeeViewModel>();

            var pickedIndex = 0;
            foreach (var item in awardList)
            {
                var pickedAttendeeList = new List<Attendee>();
                for (int i = 0; i < item.Item2; i++)
                {
                    pickedAttendeeList.Add(attendees[pickedIndex]);
                    pickedIndex++;
                }
                var lotteryAttendee = new LotteryAttendeeViewModel {
                    name = item.Item1,
                    attendees = pickedAttendeeList
                };
                lotteryAttendeeViewModels.Add(lotteryAttendee);
            }

            return View(lotteryAttendeeViewModels);
        }

        public List<Attendee> Shuffle(List<Attendee> list)  
        {  
            var newList = new List<Attendee>(list);
            int n = newList.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                Attendee value = newList[k];  
                newList[k] = newList[n];  
                newList[n] = value;  
            }
            return newList;
        }
    }
}
