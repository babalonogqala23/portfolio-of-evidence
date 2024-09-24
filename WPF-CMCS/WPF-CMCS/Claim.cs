using System;

namespace WPF_CMCS
{
    public class Claim
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 18 || value > 100)
                    throw new ArgumentException("Age must be between 18 and 100.");
                _age = value;
            }
        }

       
        public string? LecturerName { get; set; }
        public double Hours { get; set; }
        public double Rate { get; set; }
        public double TotalPayment { get; set; }
        public string? Status { get; set; }




    }
}
