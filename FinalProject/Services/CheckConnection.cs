using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    public class CheckConnection
    {
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;

        public void CheckConnectivity()
        {
            if (accessType != NetworkAccess.None)
            {
                // Green circle
            }
            else
            {
                // Red circle
            }
        }

        public class ConnectivityTest
        {
            public ConnectivityTest() =>
                Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

            ~ConnectivityTest() =>
                Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;

            void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
            {
                if (e.NetworkAccess == NetworkAccess.ConstrainedInternet)
                    Console.WriteLine("Internet access is available but is limited.");

                else if (e.NetworkAccess != NetworkAccess.Internet)
                    Console.WriteLine("Internet access has been lost.");

                // Log each active connection
                Console.Write("Connections active: ");

                foreach (var item in e.ConnectionProfiles)
                {
                    switch (item)
                    {
                        case ConnectionProfile.Bluetooth:
                            Console.Write("Bluetooth");
                            break;
                        case ConnectionProfile.Cellular:
                            Console.Write("Cell");
                            break;
                        case ConnectionProfile.Ethernet:
                            Console.Write("Ethernet");
                            break;
                        case ConnectionProfile.WiFi:
                            Console.Write("WiFi");
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
