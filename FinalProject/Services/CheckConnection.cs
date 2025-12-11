using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    public class CheckConnection : ICheckConnection
    {
        public NetworkAccess accessType { get; private set; } = Connectivity.Current.NetworkAccess;

        public delegate void NotifyOnConnection();
        public event NotifyOnConnection? OnConnection;

        public CheckConnection() 
        {
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }


        public NetworkAccess CheckConnectivity()
        {
            
            return accessType;
        }

        private void Connectivity_ConnectivityChanged(object? sender, ConnectivityChangedEventArgs e)
        {
            accessType = e.NetworkAccess;
            OnConnection?.Invoke();
        }



        

        




    }
}
