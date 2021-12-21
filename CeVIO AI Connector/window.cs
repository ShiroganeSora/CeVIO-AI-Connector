using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Web;
using CeVIO.Talk.RemoteService;
using CeVIO.Talk.RemoteService2;


namespace CeVIO_AI_Connector {
    public partial class window : Form {
        Talker2 CeVIO = new Talker2();
        HttpListener HTTPserver = new HttpListener();

        NotifyIcon notifyIcon;

        //string ip = "localhost";
        int port = 50081;

        string raw_data, tag, get_text;
        string[] cast_list, data, type, message, voice, volume, speed, tone;//alpha tone_scale
        int len, get_voice, get_volume = -1, get_speed = -1, get_tone = -1;
        
        public window() {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.setComponents();
        }

        private void setComponents()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon(@"F:\Project Files\VisualStudio2017\CeVIO AI Connector\CeVIO AI Connector\computer-icons-chain-hyperlink-symbol-png-favpng-jv8UK6tqFutQg4pxpBjaPdhsg.ico");
            notifyIcon.Visible = true;
            notifyIcon.Text = "CeVIO AI Connector";

            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = "&終了";
            toolStripMenuItem.Click += ToolStripMenuItem_Click;
            contextMenuStrip.Items.Add(toolStripMenuItem);
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            notifyIcon.Click += NotifyIcon_Click;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private async void Form1_Load(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (ServiceControl2.IsHostStarted == true) {
                CeVIO_AI_Label.Text = "起動しています";
                CeVIO_Version_Label.Text = ServiceControl2.HostVersion.ToString();
                cast_list = TalkerAgent2.AvailableCasts;
                CeVIO_Voice_DropDown.DataSource = cast_list;
            } else　{
                CeVIO_AI_Label.Text = "起動していません";
            }

            server:

            HTTPserver.Prefixes.Clear();
            HTTPserver.Prefixes.Add(@"http://+:" + port + "/");
            HTTPserver.Start();
            
            while (true) {
                await Task.Run(() => {
                    HttpListenerContext context = HTTPserver.GetContext();
                    HttpListenerRequest request = context.Request;

                    HttpListenerResponse response = context.Response;
                    if (request != null) {
                        byte[] text = Encoding.UTF8.GetBytes(
                            "<html><head><meta charset='utf-8'/><title>CeVIO AI Connector</title></head>" +
                            "<body><h1>HTTP Server</h1>" +
                            "<p>Server Status : started<br>GET Request : http://localhost(127.0.0.1):50081/talk?text={message}</p></body></html>");
                        response.OutputStream.Write(text, 0, text.Length);
                        if (request.UrlReferrer == null) {
                            /*
                            Console.WriteLine("KeepAlive: {0}", request.KeepAlive);
                            Console.WriteLine("Is local? {0}", request.IsLocal);
                            Console.WriteLine("HTTP method: {0}", request.HttpMethod);
                            Console.WriteLine("Protocol version: {0}", request.ProtocolVersion);
                            Console.WriteLine("Is authenticated: {0}", request.IsAuthenticated);
                            Console.WriteLine("Is secure: {0}", request.IsSecureConnection);
                            Console.WriteLine("URL: {0}", request.Url.OriginalString);
                            Console.WriteLine("Raw URL: {0}", request.RawUrl);
                            Console.WriteLine("Referred by: {0}", request.UrlReferrer);
                            Console.WriteLine("HTTP Method: {0}", request.HttpMethod);
                            Console.WriteLine("Host name: {0}", request.UserHostName);
                            Console.WriteLine("Host address: {0}", request.UserHostAddress);
                            Console.WriteLine("User agent: {0}", request.UserAgent);
                            */
                            //HTTP_URL_Label.Text = HttpUtility.UrlDecode(request.Url.OriginalString);
                            raw_data = HttpUtility.UrlDecode(request.RawUrl);
                            if (raw_data.Contains("?")) {
                                data = raw_data.Split('?');
                                tag = data[0];// /talk
                                type = data[1].Split('&');
                                len = type.Length - 1;
                                for (int cnt = 0; cnt <= len; cnt++) {
                                    if (type[cnt].Contains("text")) {
                                        message = type[cnt].Split('=');
                                        get_text = message[1];
                                    }
                                    if (type[cnt].Contains("voice")) {
                                        voice = type[cnt].Split('=');
                                        get_voice = int.Parse(voice[1]);
                                    }
                                    if (type[cnt].Contains("volume")) {
                                        volume = type[cnt].Split('=');
                                        get_volume = int.Parse(volume[1]);
                                    }
                                    if (type[cnt].Contains("speed")) {
                                        speed = type[cnt].Split('=');
                                        get_speed = int.Parse(speed[1]);
                                    }
                                    if (type[cnt].Contains("tone")) {
                                        tone = type[cnt].Split('=');
                                        get_tone = int.Parse(tone[1]);
                                    }
                                }
                            }
                            
                            if(tag == "/talk") {
                                CeVIO.Cast = "IA";
                                if(get_volume != -1) {
                                    CeVIO.Volume = (uint)get_volume;
                                }
                                if(get_speed != -1) {
                                    CeVIO.Speed = (uint)get_speed;
                                }
                                if(get_tone != -1) {
                                    CeVIO.Tone = (uint)get_tone;
                                }
                                CeVIO.Speak(get_text);
                            } else if(tag == "stop") {

                            } else {

                            }
                            //int num = Array.IndexOf(message, "text");
                        }
                    } else {
                        response.StatusCode = 404;
                    }
                    response.Close();
                });
            }
        }

        private void Form1_FormClosing(object sender, EventArgs e) {

        }

        private void CeVIO_Speak_Button_Click(object sender, EventArgs e)
        {
            if (CeVIO_Text_TextBox.Text == "")
            {
                CeVIO_Text_TextBox.Text = "ここにしゃべらせたい文字を入力してください";
            }
            else
            {
                CeVIO.Cast = cast_list[CeVIO_Voice_DropDown.SelectedIndex];
                CeVIO.Volume = (uint)decimal.ToInt32(CeVIO_Volume_Value.Value);
                if (CeVIO_Speed_Value.Value != -1)
                {
                    CeVIO.Speed = (uint)decimal.ToInt32(CeVIO_Speed_Value.Value);
                }
                if (CeVIO_Tone_Value.Value != -1)
                {
                    CeVIO.Tone = (uint)decimal.ToInt32(CeVIO_Tone_Value.Value);
                }
                if (CeVIO_Alpha_Value.Value != -1)
                {
                    CeVIO.Alpha = (uint)decimal.ToInt32(CeVIO_Alpha_Value.Value);
                }
                if (CeVIO_ToneScale_Value.Value != -1)
                {
                    CeVIO.ToneScale = (uint)decimal.ToInt32(CeVIO_ToneScale_Value.Value);
                }
                CeVIO.Speak(CeVIO_Text_TextBox.Text);
            }
        }

        private void CeVIO_Stop_Button_Click(object sender, EventArgs e)
        {
            CeVIO.Stop();
        }

        private void CeVIO_Clear_Button_Click(object sender, EventArgs e)
        {
            CeVIO_Text_TextBox.Text = "";
        }
        //
        private void CeVIO_Status_Button_Click(object sender, EventArgs e)
        {
            if (ServiceControl2.HostVersion == null)
            {
                CeVIO_AI_Label.Text = "起動していません";
            }
            else
            {
                CeVIO_AI_Label.Text = "起動しています";
                CeVIO_Version_Label.Text = ServiceControl2.HostVersion.ToString();
            }
        }
        //
        private void CeVIO_Start_Button_Click(object sender, EventArgs e)
        {
            ServiceControl2.StartHost(false);
        }
        //
        private void CeVIO_Close_Button_Click(object sender, EventArgs e)
        {
            ServiceControl2.CloseHost();
        }
    }
}
