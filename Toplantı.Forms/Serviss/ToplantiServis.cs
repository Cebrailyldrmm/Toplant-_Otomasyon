using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplantı.Forms.Serviss
{
    public class ToplantiServis
    {
       private HubConnection connection;
        public HubConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new HubConnectionBuilder().WithUrl("https://localhost:7292/genelhub").Build();
                    connection.Closed += HubConnection_Closed;
                }
                return connection;
            }
        }

        private async Task HubConnection_Closed(Exception exception)
        {
            await connection.StartAsync();
        }

    }
}
