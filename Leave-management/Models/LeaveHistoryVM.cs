using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Models
{
    public class LeaveHistoryVM
    {

        public int Id { get; set; }

       public EmployeeVM RequestingEmployee { get; set; }
        public string RequestingEmployeeID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public DetailsLeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeID { get; set; }
        
        //D:  Bring in the list of Leave TYpes
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
        //D: ================================================================
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }

       
        public EmployeeVM ApprovedBy { get; set; }
        public string ApprovedByID { get; set; }
    }
}
