using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Net.Http;
using System.Configuration;

namespace CallForHelp
{
    public partial class Form1 : Form
    {
        private readonly string _webReuestUrl = "https://maker.ifttt.com/trigger/{event}/with/key/{IFTTTUID}";
        readonly string _iftttuid = ConfigurationManager.AppSettings["IFTTTUID"];
        readonly string _DefaultRing = ConfigurationManager.AppSettings["DefaultRing"];
        readonly string _DefaultSms = ConfigurationManager.AppSettings["DefaultSms"];
        readonly string _DefaultMail = ConfigurationManager.AppSettings["DefaultMail"];

        readonly string _RingEventName = ConfigurationManager.AppSettings["RingEventName"];
        readonly string _SmsEventName = ConfigurationManager.AppSettings["SmsEventName"];
        readonly string _MailEventName = ConfigurationManager.AppSettings["MailEventName"];

        readonly string _UserOption1 = ConfigurationManager.AppSettings["UserOption1"];
        readonly string _UserOption2 = ConfigurationManager.AppSettings["UserOption2"];

        private string RadioButtonSelectedValue = "";


        public Form1()
        {
            InitializeComponent();
            _webReuestUrl = _webReuestUrl.Replace("{IFTTTUID}", _iftttuid);
            if (_DefaultRing.ToLower() == "true") chkboxRingBell.Checked = true;
            if (_DefaultSms.ToLower() == "true") chkboxSms.Checked = true;
            if (_DefaultMail.ToLower() == "true") chkboxMail.Checked = true;


            if (_UserOption1 != "") rBtnUser1.Visible = true;
            if (_UserOption2 != "") rBtnUser2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                try
                {
                    var Port = new SerialPort(port, 9600);
                    Port.Open();
                    Port.WriteLine("H");
                    Thread.Sleep(100);
                    Port.WriteLine("L");
                    Port.Close();
                }
                catch (Exception){}
            }
            
            //var currentPort = new SerialPort("COM8", 9600);
            //currentPort.Open();
            //currentPort.WriteLine("H");
            //System.Threading.Thread.Sleep(2000);
            //currentPort.WriteLine("L");
            //currentPort.Close();

            if (rBtnFreeText.Checked)
            {
                RadioButtonSelectedValue = richTextBox1.Text;
            }
            
            if (chkboxSms.Checked)
                SendPostMesage(_SmsEventName, RadioButtonSelectedValue);
            if (chkboxMail.Checked)
                SendPostMesage(_MailEventName, RadioButtonSelectedValue);
            if (chkboxRingBell.Checked)
                SendPostMesage(_RingEventName, RadioButtonSelectedValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void SendPostMesage(string eventName, string value1 = "", string value2 = "", string value3 = "")
        {
            string webReuestUrl = _webReuestUrl.Replace("{event}", eventName);
            
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                   { "value1", value1 },
                   { "value2", value2 },
                   { "value3", value3 }
                };

                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(webReuestUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox) sender;
            cb.BackColor = cb.Checked ? Color.Green : Color.FromKnownColor(KnownColor.Control);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            if (rb.Text.ToLower() == "free text")
            {
                richTextBox1.Visible = true;
                //RadioButtonSelectedValue = richTextBox1.Text;
            }
            else
            {
                richTextBox1.Visible = false;
                RadioButtonSelectedValue = rb.Text;
            }
        }

    }
}
