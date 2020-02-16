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

        public IActionResult Lottery()
        {
            List<Attendee> attendees = _attendeeProvider.GetAttendees();
            attendees = Shuffle(attendees);

            Tuple<String, int, List<Attendee>>[] awardList =
            {
                Tuple.Create("รางวัลที่ 1", 1, new List<Attendee>()),
                Tuple.Create("รางวัลที่ 2", 3, new List<Attendee>()),
                Tuple.Create("รางวัลที่ 3", 10, new List<Attendee>())
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
