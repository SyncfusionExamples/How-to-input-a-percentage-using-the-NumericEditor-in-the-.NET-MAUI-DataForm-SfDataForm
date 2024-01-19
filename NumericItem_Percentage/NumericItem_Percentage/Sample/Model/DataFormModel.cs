using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace NumericItem_Percentage
{
    public class DataFormModel
    {
        public DataFormModel()
        {
            this.Name = string.Empty;
            this.Date = DateTime.Now;
            this.Venue = string.Empty;
            this.PaymentMethod = string.Empty;
            this.Occupancy = 0.0;
        }

        [DataFormDisplayOptions(ColumnSpan = 2)]
        public string Name { get; set; }


        public DateTime Date { get; set; }

        [Display(Name = "Number of tickects")]
        public int Tickets { get; set; }

        public string Venue { get; set; }
        public double Occupancy { get; set; }

        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; }
    }
}