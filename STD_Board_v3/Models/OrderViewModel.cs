using System;
using System.ComponentModel.DataAnnotations;

namespace STD_Board_v3.Models
{
    public class OrderViewModel
    {
        public int Phone
        {
            get;
            set;
        }

        public string CustomerID { get; set; }

        public string Name
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Notes
        {
            get;
            set;
        }

        [Required]
        public DateTime? Hours
        {
            get;
            set;
        }

        public string Jurisdiction
        {
            get;
            set;
        }

        public string Role
        {
            get;
            set;
        }

        public string ShipCity
        {
            get;
            set;
        }

        public string ShipName
        {
            get;
            set;
        }

        public int? EmployeeID
        {
            get;
            set;
        }
    }
}