using MEETINGAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MEETINGAPP.Models

{
    public class MeetingInfO
    {
        public int Id { get; set; } 
        
        public string? Location { get; set; }
        public DateTime Date { get; set;}

        public int NumberofPeople {  get; set;}



    }
}
