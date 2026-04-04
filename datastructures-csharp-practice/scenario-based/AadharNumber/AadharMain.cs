using System;

namespace AadharNumberSort
{
    class AadharMain
    {
        static void Main()
        {
            Aadhar[] arr =
            {
                new Aadhar(987654321012),
                new Aadhar(123456789012),
                new Aadhar(987654321045),
                new Aadhar(123456789099)
            };

            IAadharService service = new AadharService(arr);
            AadharMenu menu = new AadharMenu(service);
            menu.Show();
        }
    }
}