using UHotel9.Tables;

namespace UHotel9
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
          
            Application.Run(new Reservation_Form());
            

        }
    }
}