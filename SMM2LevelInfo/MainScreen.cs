using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Threading;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;

namespace SMM2LevelInfo
{
    public partial class MainScreen : Form
    {
        private ClientWebSocket drambar;
        private CancellationTokenSource source;
        private Thread levelListenerThread;
        private static readonly HttpClient client = new HttpClient();
        public MainScreen()
        {
            InitializeComponent();
            source = new CancellationTokenSource();

            //Load API key
            string filename = "apikey";
            if (File.Exists(filename))
            {
                string api_key = File.ReadAllText(filename);
                LIB_api_key.Text = api_key;
            }
        }

        delegate void SetConnectionStatusCallback(bool status);
        private void SetConnectionStatus(bool status)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (drambar_connection_status.InvokeRequired)
            {
                SetConnectionStatusCallback d = new SetConnectionStatusCallback(SetConnectionStatus);
                Invoke(d, new object[] { status });
            }
            else
            {
                if (status)
                {
                    drambar_connection_status.Text = "Connected";
                    drambar_connection_status.ForeColor = Color.Green;
                } else
                {
                    drambar_connection_status.Text = "Not connected";
                    drambar_connection_status.ForeColor = Color.Red;
                }

            }
        }
        private async void drambar_connect_Click(object sender, EventArgs e)
        {
            //Cancel the current connection and Level Listener Thread
            if(source != null)
            {
                source.Cancel();
            }

            //Create new Tokens
            source = new CancellationTokenSource();
            CancellationToken token = source.Token;

            //Connect to the Dram bar WS server
            drambar = new ClientWebSocket();
            try
            {
                await drambar.ConnectAsync(new Uri($"ws://{this.drambar_ip.Text}:{this.drambar_port.Text}/wss"), CancellationToken.None);
            }
            catch(WebSocketException excp)
            {
                return;
            }
            
            //If the connection is open, then start listening for levels
            if(drambar.State == WebSocketState.Open)
            {
                SetConnectionStatus(true);

                levelListenerThread = new Thread(LevelInfoListener);
                levelListenerThread.Start(token);
            }
            

        }

        private async void LevelInfoListener(object token_obj)
        {
            CancellationToken token = (CancellationToken) token_obj;
            while (!token.IsCancellationRequested)
            {
                //This method runs in a separate thread since it will be awaiting data
                ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[4000]);
                try
                {
                    await drambar.ReceiveAsync(buffer, token);
                }
                catch(OperationCanceledException e)
                {
                    continue;
                }
                catch(WebSocketException e)
                {
                    SetConnectionStatus(false);
                    source.Cancel();
                    continue;
                }

                //Convert the buffer into a string
                string info = System.Text.Encoding.UTF8.GetString(buffer.Array);
                

                //Deserialize the Json into a dynamic object to save some time
                dynamic lvlinfo = JsonConvert.DeserializeObject(info);
                if(lvlinfo == null || lvlinfo.level == null)
                {
                    continue;
                }
                //If this has a level info, then grab the code
                string level_code = lvlinfo.level.code;
                level_code = level_code.Replace("-", "");
                Debug.WriteLine($"Level code is: {level_code}\n");

                client.GetStringAsync($"https://yrk06.com.br/api/levelinfo/{LIB_api_key.Text}/{level_code}");

            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (source != null)
            {
                source.Cancel();
            }
            base.OnFormClosed(e);
        }

        private void Save_key_Click(object sender, EventArgs e)
        {
            string filename = "apikey";
            File.WriteAllText(filename, LIB_api_key.Text);
        }
    }
}
