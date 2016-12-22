using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Net.Http;
using System.Configuration;
using Twilio;


namespace CallForHelp
{
    public partial class Form1 : Form
    {
        //private readonly string _webReuestUrl = "https://maker.ifttt.com/trigger/{event}/with/key/{IFTTTUID}";
        //readonly string _iftttuid = ConfigurationManager.AppSettings["IFTTTUID"];
        //readonly string _defaultRing = ConfigurationManager.AppSettings["DefaultRing"];
        //readonly string _defaultSms = ConfigurationManager.AppSettings["DefaultSms"];
        //readonly string _defaultMail = ConfigurationManager.AppSettings["DefaultMail"];

        //readonly string _ringEventName = ConfigurationManager.AppSettings["RingEventName"];
        //readonly string _smsEventName = ConfigurationManager.AppSettings["SmsEventName"];
        //readonly string _mailEventName = ConfigurationManager.AppSettings["MailEventName"];

        //readonly string _userOption1 = ConfigurationManager.AppSettings["UserOption1"];
        //readonly string _userOption2 = ConfigurationManager.AppSettings["UserOption2"];

        enum options
        {
            Food,
            Toilet,
            Water,
            Suction,
            HotCold,
            Other
        }


        private string _radioButtonSelectedValue = "";

        private const string twilloNumber = "+972526001364";
        private bool sendSmsBtnClickState = false;
        private bool sendAlertBtnClickState = true;
        private bool foodBtnClickState = false;
        private bool hotcoldBtnClickState = false;
        private bool otherBtnClickState = false;
        private bool toiletBtnClickState = false;
        private bool suctionBtnClickState = false;
        private bool waterBtnClickState = false;


        public Form1()
        {
            InitializeComponent();
            //_webReuestUrl = _webReuestUrl.Replace("{IFTTTUID}", _iftttuid);
            //if (_defaultRing.ToLower() == "true") chkboxRingBell.Checked = true;
            //if (_defaultSms.ToLower() == "true") chkboxSms.Checked = true;
            //if (_defaultMail.ToLower() == "true") chkboxMail.Checked = true;


            //if (_userOption1 != "") rBtnUser1.Visible = true;
            //if (_userOption2 != "") rBtnUser2.Visible = true;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            
        //    if (rBtnFreeText.Checked)
        //    {
        //        _radioButtonSelectedValue = richTextBox1.Text;
        //    }
            
        //    if (chkboxSms.Checked)
        //        SendPostMesage(_smsEventName, _radioButtonSelectedValue);
        //    if (chkboxMail.Checked)
        //        SendPostMesage(_mailEventName, _radioButtonSelectedValue);
        //    if (chkboxRingBell.Checked)
        //        SendPostMesage(_ringEventName, _radioButtonSelectedValue);
        //}

        //private async void SendPostMesage(string eventName, string value1 = "", string value2 = "", string value3 = "")
        //{
        //    string webReuestUrl = _webReuestUrl.Replace("{event}", eventName);
            
        //    using (var client = new HttpClient())
        //    {
        //        var values = new Dictionary<string, string>
        //        {
        //           { "value1", value1 },
        //           { "value2", value2 },
        //           { "value3", value3 }
        //        };

        //        var content = new FormUrlEncodedContent(values);
        //        var response = await client.PostAsync(webReuestUrl, content);
        //        var responseString = await response.Content.ReadAsStringAsync();
        //    }
        //}

        //private void CheckedChanged(object sender, EventArgs e)
        //{
        //    var cb = (CheckBox) sender;
        //    cb.BackColor = cb.Checked ? Color.Green : Color.FromKnownColor(KnownColor.Control);
        //}

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (Button)sender;
            _radioButtonSelectedValue = rb.Name.ToLower();
            textBox.Text = "I want " + rb.Name.ToLower();
        }

        private void SendSmsUsingTwillo(string to,string body)
        {
            string AccountSid = "AC629dd9f188d9fbf3b81a04838e3aafd8";
            string AuthToken = "ce8cc33f6629b48e2943e48811eec081";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            var message = twilio.SendMessage(twilloNumber, to, body);
            Console.WriteLine(message.Sid);
        }

        private void WriteToComPort(SerialPort port,string s)
        {
            port.Open();
            port.WriteLine(s.ToLower());
            Thread.Sleep(1000);
            port.WriteLine(s.ToUpper());
            port.Close();
        }

        private void RingBell(string aToDBellId)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                try
                {
                    var _port = new SerialPort(port, 9600);
                    WriteToComPort(_port, aToDBellId);
                }
                catch (Exception) { }
            }

        }

        private void sms_Click(object sender, EventArgs e)
        {
            clickBtnChangeState(ref sendSmsBtnClickState);
        }

        private void All_Click(object sender, EventArgs e)
        {
            if (sendAlertBtnClickState)
            {
                RingBell("A");
            }
            if (sendSmsBtnClickState)
            {
                SendSmsUsingTwillo("+972526837504",textBox.Text);
            }
        }

          void FoodBtn_MouseHover(object sender, EventArgs e)
          {
              //Food.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.other));
          }

          void FoodBtn_MouseLeave(object sender, EventArgs e)
          {
              //Food.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.food));
          }

        private void Alert_Click(object sender, EventArgs e)
        {
            clickBtnChangeState(ref sendAlertBtnClickState);
        }

        //private void Food_Click(object sender, EventArgs e)
        //{
        //    OpptionBtnClicked(foodBtnClickState);
        //    textBox.Text = "i want Food";
        //}

        private void clickBtnChangeState(ref bool buttonState)
        {
            if (buttonState == false)
                buttonState = true;
            else if (buttonState)
                buttonState = false;
        }

        private void disableAllButtons()
        {
             foodBtnClickState = false;
             hotcoldBtnClickState = false;
             otherBtnClickState = false;
             toiletBtnClickState = false;
             suctionBtnClickState = false;
             waterBtnClickState = false;
        }

        private void OptionBtnClicked(bool buttonState)
        {
            disableAllButtons();
            clickBtnChangeState(ref buttonState);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Other_Click(object sender, EventArgs e)
        {
            textBox.Text = "I want ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sendAlertBtnClickState)
            {
                RingBell("B");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sendAlertBtnClickState)
            {
                RingBell("C");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sendAlertBtnClickState)
            {
                RingBell("D");
            }
        }

        private void General_Click(object sender, EventArgs e)
        {
            textBox.Text = "I Need Something ";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
