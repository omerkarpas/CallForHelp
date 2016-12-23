using System;
using System.Configuration;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Twilio;


namespace CallForHelp
{
    public partial class Form1 : Form
    {
        //private readonly string _webReuestUrl = "https://maker.ifttt.com/trigger/{event}/with/key/{IFTTTUID}";
        readonly string _defaultRingState = ConfigurationManager.AppSettings["DefaultRingState"];
        readonly string _defaultSmsState = ConfigurationManager.AppSettings["DefaultSmsState"];

        readonly string _helper1Number = ConfigurationManager.AppSettings["Helper1Number"];
        readonly string _helper2Number = ConfigurationManager.AppSettings["Helper2Number"];
        readonly string _helper3Number = ConfigurationManager.AppSettings["Helper3Number"];
        readonly string _helper4Number = ConfigurationManager.AppSettings["Helper4Number"];


        readonly string _twilloNumber = ConfigurationManager.AppSettings["TwilloNumber"];
        readonly string _accountSid = ConfigurationManager.AppSettings["AccountSid"];
        readonly string _authToken = ConfigurationManager.AppSettings["AuthToken"];

        enum OptionsEnum
        {
            General,
            Food,
            Toilet,
            Water,
            Suction,
            HotCold,
            Other
        }

        private string _radioButtonSelectedValue = OptionsEnum.General.ToString();

        private bool _sendSmsBtnClickState = false;
        private bool _sendAlertBtnClickState = true;
        
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - Height);
            if (_defaultRingState.ToLower()=="true")
            {
                _sendAlertBtnClickState = true;
                Alert.BackgroundImage = ((Properties.Resources.alert_family_UI_alert_selected));
            }
            else
            {
                _sendAlertBtnClickState = false;
                Alert.BackgroundImage = ((Properties.Resources.alert_family_UI_alert));
            }

            if (_defaultSmsState.ToLower() == "true")
            {
                _sendSmsBtnClickState = true;
                sms.BackgroundImage = ((Properties.Resources.alert_family_UI_SMS_selected));
            }
            else
            {
                _sendSmsBtnClickState = false;
                sms.BackgroundImage = ((Properties.Resources.alert_family_UI_SMS));
            }
            if (_sendSmsBtnClickState == false && _sendAlertBtnClickState==false)
                DisableAllPeople();
            else
            {
                EnableAllPeople();
            }

        }

        private void SendSmsUsingTwillo(string to,string body)
        {
            var twilio = new TwilioRestClient(_accountSid, _authToken);
            var state = twilio.SendMessage(_twilloNumber, to, "Roee:" + body);
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
            if (_sendSmsBtnClickState == false)
            {
                _sendSmsBtnClickState = true;
                sms.BackgroundImage = ((Properties.Resources.alert_family_UI_SMS_selected));
                EnableAllPeople();
            }

            else if (_sendSmsBtnClickState)
            {
                _sendSmsBtnClickState = false;
                sms.BackgroundImage = ((Properties.Resources.alert_family_UI_SMS));
                if (_sendAlertBtnClickState == false)
                {
                    DisableAllPeople();
                }
            }
        }

        void Sms_MouseHover(object sender, EventArgs e)
        {
            if (_sendSmsBtnClickState)
                return;
            sms.BackgroundImage = ((Properties.Resources.alert_family_UI_SMS_hover));
        }

        void Alert_MouseHover(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState)
                return;
            Alert.BackgroundImage = ((Properties.Resources.alert_family_UI_alert_hover));
        }

        void Sms_MouseLeave(object sender, EventArgs e)
        {
            if (_sendSmsBtnClickState)
                return;
            sms.BackgroundImage = ((Properties.Resources.alert_family_UI_SMS));
        }

        void Alert_MouseLeave(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState)
                return;
            Alert.BackgroundImage = ((Properties.Resources.alert_family_UI_alert));
        }


        void FoodBtn_MouseClick(object sender, EventArgs e)
        {
            textBox.ForeColor = SystemColors.WindowText;
            if (_radioButtonSelectedValue == OptionsEnum.Food.ToString())
                return;
            DisableAllButtons();
            textBox.Text = "I want food";
            _radioButtonSelectedValue = OptionsEnum.Food.ToString();
            Food.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_food_selected));
        } 

        void FoodBtn_MouseHover(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Food.ToString())
                return;
            Food.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_food_hover));
        }

        void FoodBtn_MouseLeave(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Food.ToString())
                return;
            Food.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_food));
        }


        void ToiletBtn_MouseClick(object sender, EventArgs e)
        {
            textBox.ForeColor = SystemColors.WindowText;
            if (_radioButtonSelectedValue == OptionsEnum.Toilet.ToString())
                return;
            DisableAllButtons();
            textBox.Text = "I need to go to the restroom";
            _radioButtonSelectedValue = OptionsEnum.Toilet.ToString();
            Toilet.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_toilet_selected));
        } 

        void ToiletBtn_MouseHover(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Toilet.ToString())
                return;
            Toilet.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_toilet_hover));
        }

        void ToiletBtn_MouseLeave(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Toilet.ToString())
                return;
            Toilet.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_toilet));
        }


        void WaterBtn_MouseClick(object sender, EventArgs e)
        {
            textBox.ForeColor = SystemColors.WindowText;
            if (_radioButtonSelectedValue == OptionsEnum.Water.ToString())
                return;
            DisableAllButtons();
            textBox.Text = "I want water";
            _radioButtonSelectedValue = OptionsEnum.Water.ToString();
            Water.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_water_selected));
        } 
        
        void WaterBtn_MouseHover(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Water.ToString())
                return;
            Water.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_water_hover));
        }

        void WaterBtn_MouseLeave(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Water.ToString())
                return;
            Water.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_water));
        }



        void HotColdBtn_MouseClick(object sender, EventArgs e)
        {
            textBox.ForeColor = SystemColors.WindowText;
            if (_radioButtonSelectedValue == OptionsEnum.HotCold.ToString())
                return;
            DisableAllButtons();
            textBox.Text = "I feel too hot or too cold";
            _radioButtonSelectedValue = OptionsEnum.HotCold.ToString();
            HotCold.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_temperature_selected));
        } 

        void HotColdBtn_MouseHover(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.HotCold.ToString())
                return;
            HotCold.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_temperature_hover));
        }

        void HotColdBtn_MouseLeave(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.HotCold.ToString())
                return;
            HotCold.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_temperature));
        }




        void SuctionBtn_MouseClick(object sender, EventArgs e)
        {
            textBox.ForeColor = SystemColors.WindowText;
            if (_radioButtonSelectedValue == OptionsEnum.Suction.ToString())
                return;
            DisableAllButtons();
            textBox.Text = "I need suction";
            _radioButtonSelectedValue = OptionsEnum.Suction.ToString();
            Suction.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_cleaning_selected));
        } 
        
        void SuctionBtn_MouseHover(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Suction.ToString())
                return;
            Suction.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_cleaning_hover));
        }

        void SuctionBtn_MouseLeave(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Suction.ToString())
                return;
            Suction.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_cleaning));
        }


        void OtherBtn_MouseClick(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Other.ToString())
                return;
            DisableAllButtons();
            textBox.Text = "Enter text here";
            textBox.ForeColor = Color.Gray;
            _radioButtonSelectedValue = OptionsEnum.Other.ToString();
            Other.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_write_selected));
        } 

        void OtherBtn_MouseHover(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Other.ToString())
                return;
            Other.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_write_hover));
        }

        void OtherBtn_MouseLeave(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Other.ToString())
                return;
            Other.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_write));
        }


        void GeneralBtn_MouseClick(object sender, EventArgs e)
        {
            textBox.ForeColor = SystemColors.WindowText;
            if (_radioButtonSelectedValue == OptionsEnum.General.ToString())
                return;
            DisableAllButtons();
            textBox.Text = "I need something... ";
            _radioButtonSelectedValue = OptionsEnum.General.ToString();
            General.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_help_seelcted));
        }

        void GeneralBtn_MouseHover(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.General.ToString())
                return;
            General.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_help_hover));
        }

        void GeneralBtn_MouseLeave(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.General.ToString())
                return;
            General.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_help));
        }

        private void Alert_Click(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState == false)
            {
                _sendAlertBtnClickState = true;
                Alert.BackgroundImage = ((Properties.Resources.alert_family_UI_alert_selected));
                EnableAllPeople();
            }

            else if (_sendAlertBtnClickState)
            {
                _sendAlertBtnClickState = false;
                Alert.BackgroundImage = ((Properties.Resources.alert_family_UI_alert));
                if (_sendSmsBtnClickState == false)
                {
                    DisableAllPeople();
                }
            }
        }


        private void DisableAllPeople()
        {
            help1.BackgroundImage = ((Properties.Resources.alert_family_UI_p5_disabled));
            help2.BackgroundImage = ((Properties.Resources.alert_family_UI_p1_disabled));
            help3.BackgroundImage = ((Properties.Resources.alert_family_UI_p3_disabled));
            help4.BackgroundImage = ((Properties.Resources.alert_family_UI_p4_disabled));
            help1.Enabled = false;
            help2.Enabled = false;
            help3.Enabled = false;
            help4.Enabled = false;
        }

        private void EnableAllPeople()
        {
            help1.BackgroundImage = ((Properties.Resources.alert_family_UI_p5));
            help2.BackgroundImage = ((Properties.Resources.alert_family_UI_p1));
            help3.BackgroundImage = ((Properties.Resources.alert_family_UI_p3));
            help4.BackgroundImage = ((Properties.Resources.alert_family_UI_p4));
            help1.Enabled = true;
            help2.Enabled = true;
            help3.Enabled = true;
            help4.Enabled = true;
        }

        //private void Alert_Hover(object sender, EventArgs e)
        //{
        //    if (_sendAlertBtnClickState == false)
        //    {
        //        _sendAlertBtnClickState = true;
        //        Alert.BackgroundImage = ((Properties.Resources.alert_family_UI_alert_selected));
        //    }

        //    else if (_sendAlertBtnClickState)
        //    {
        //        _sendAlertBtnClickState = false;
        //        Alert.BackgroundImage = ((Properties.Resources.alert_family_UI_alert));
        //    }
        //}

        private void DisableAllButtons()
        {
            Food.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_food));
            Toilet.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_toilet));
            Water.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_water));
            Suction.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_cleaning));
            Other.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_write));
            General.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_help));
            HotCold.BackgroundImage = ((Properties.Resources.alert_family_UI_tab_temperature));
        }

        private void Help1_Click(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState || _sendSmsBtnClickState)
            {
                help1.BackgroundImage = ((Properties.Resources.alert_family_UI_p5_selected));
                help1.Refresh();
            }
            if (_sendAlertBtnClickState)
            {
                RingBell("A");
            }
            if (_sendSmsBtnClickState)
            {
                SendSmsUsingTwillo(_helper1Number, textBox.Text);
            }
        }

        private void Help1_Hover(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState || _sendSmsBtnClickState)
            {
                help1.BackgroundImage = ((Properties.Resources.alert_family_UI_p5_hover));
            }
        }

        private void Help1_Leave(object sender, EventArgs e)
        {
            help1.BackgroundImage = ((Properties.Resources.alert_family_UI_p5));
        }

        private void Help2_Click(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState || _sendSmsBtnClickState)
            {
                help2.BackgroundImage = ((Properties.Resources.alert_family_UI_p1_selected));
                help2.Refresh();
            }
            if (_sendAlertBtnClickState)
            {
                RingBell("B");
            }
            if (_sendSmsBtnClickState)
            {
                SendSmsUsingTwillo(_helper2Number, textBox.Text);
            }
        }

        private void Help2_Hover(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState || _sendSmsBtnClickState)
            {
                help2.BackgroundImage = ((Properties.Resources.alert_family_UI_p1_hover));
            }
        }

        private void Help2_Leave(object sender, EventArgs e)
        {
            help2.BackgroundImage = ((Properties.Resources.alert_family_UI_p1));
        }
        
        private void Help3_Click(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState || _sendSmsBtnClickState)
            {
                help3.BackgroundImage = ((Properties.Resources.alert_family_UI_p3_selected));
                help3.Refresh();
            }
            if (_sendAlertBtnClickState)
            {
                RingBell("C");
            }
            if (_sendSmsBtnClickState)
            {
                SendSmsUsingTwillo(_helper3Number, textBox.Text);
            }
        }

        private void Help3_Hover(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState || _sendSmsBtnClickState)
            {
                help3.BackgroundImage = ((Properties.Resources.alert_family_UI_p3_hover));
            }
        }

        private void Help3_Leave(object sender, EventArgs e)
        {
            help3.BackgroundImage = ((Properties.Resources.alert_family_UI_p3));
        }

        private void Help4_Click(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState || _sendSmsBtnClickState)
            {
                help4.BackgroundImage = ((Properties.Resources.alert_family_UI_p4_selected));
                help4.Refresh();
            }
            if (_sendAlertBtnClickState)
            {
                RingBell("D");
            }
            if (_sendSmsBtnClickState)
            {
                SendSmsUsingTwillo(_helper4Number, textBox.Text);
            }
        }

        private void Help4_Hover(object sender, EventArgs e)
        {
            if (_sendAlertBtnClickState || _sendSmsBtnClickState)
            {
                help4.BackgroundImage = ((Properties.Resources.alert_family_UI_p4_hover));
            }
        }

        private void Help4_Leave(object sender, EventArgs e)
        {
            help4.BackgroundImage = ((Properties.Resources.alert_family_UI_p4));
        }


        private void textBox_Click(object sender, EventArgs e)
        {
            if (_radioButtonSelectedValue == OptionsEnum.Other.ToString())
                textBox.Text = "";
            textBox.ForeColor = SystemColors.WindowText;
        }


    }
}
