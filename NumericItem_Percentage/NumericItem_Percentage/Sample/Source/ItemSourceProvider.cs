using Syncfusion.Maui.DataForm;

namespace NumericItem_Percentage
{
    class ItemSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "Tickets")
            {
                List<string> noOfTickets = new List<string>() { "1", "2", "3", "4", "5" };
                return noOfTickets;
            }
            if (sourceName == "Venue")
            {
                List<string> venue = new List<string>() { "Los Angeles", "Seattle", "New York", "Denver" };
                return venue;
            }
            if (sourceName == "PaymentMethod")
            {
                List<string> payment = new List<string>() { "Credit Card", "Debit Card", "PayPal" };
                return payment;
            }

            return new List<string>();
        }
    }
}
