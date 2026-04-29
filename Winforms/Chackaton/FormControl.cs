using ROBOPROJECT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace Chackaton
{
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
            SerialPortManager.DataReceived += DataSensors;
        }
        private void UpdatePortStatus() //обновление состояния кнопок подключения
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                comboBoxPorts.Enabled = false;
                groupBoxData.Enabled = true;
                buttonConnect.Text = "Отключиться";
                buttonConnect.ForeColor = Color.Red;
                if (!comboBoxPorts.Items.Contains(SerialPortManager.mySerialPort.PortName))
                {
                    comboBoxPorts.Items.Add(SerialPortManager.mySerialPort.PortName);
                }
                comboBoxPorts.Text = SerialPortManager.mySerialPort.PortName;
            }
            else
            {
                comboBoxPorts.Enabled = true;
                groupBoxData.Enabled = false;
                buttonConnect.Text = "Подключиться";
                buttonConnect.ForeColor = Color.Green;
            }
        }

        private void DataSensors(string data) //обновление датчиков
        {
            if (data.StartsWith("DATA:"))
            {
                string values = data.Substring(5);
                string[] parts = values.Split(',');
                if (parts.Length == 5)
                {
                    try
                    {
                        labelWaterTemp.Text = $"{parts[0]} °C";
                        labelCO2.Text = $"{parts[1]} ppm";
                        labelAirHum.Text = $"{parts[2]} %";
                        labelAirTemp.Text = $"{parts[3]} °C";
                        labelLightLevel.Text = $"{parts[4]} %";
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!SerialPortManager.mySerialPort.IsOpen)
            {
                if (!string.IsNullOrWhiteSpace(comboBoxPorts.Text))
                {
                    SerialPortManager.OpenPort(comboBoxPorts.Text);
                    MessageBox.Show("Подключено успешно!");
                    UpdatePortStatus();
                }
                else
                {
                    MessageBox.Show("Выберите порт!");
                }
            }
            else
            {
                SerialPortManager.ClosePort();
                MessageBox.Show("Отключено успешно!");
                UpdatePortStatus();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.Clear();
            if (ports.Length > 0)
            {
                comboBoxPorts.Items.AddRange(ports);
                comboBoxPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Не удалось найти порты!");
            }
        }

        private void checkBoxTENStop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTENStop.Checked)
            {
                groupBoxTENStop.Enabled = true;
                comboBoxTENInterval.SelectedIndex = 0;
            }
            else
            {
                groupBoxTENStop.Enabled = false;
            }
        }

        private void buttonTENOn_Click(object sender, EventArgs e)
        {
            SerialPortManager.mySerialPort.WriteLine("H");
            labelTENStatus.Text = "СТАТУС:\r\nВКЛЮЧЕНО";
            if (checkBoxTENStop.Checked && int.TryParse(comboBoxTENInterval.Text, out int interval))
            {
                timerTENStop.Interval = interval;
                timerTENStop.Tick += TimerTickTEN;
                timerTENStop.Start();
            }
        }

        private void TimerTickTEN(object sender, EventArgs e)
        {
            timerTENStop.Stop();
            timerTENStop.Tick -= TimerTickTEN;
            SerialPortManager.mySerialPort.WriteLine("h");
            labelTENStatus.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
        }

        private void buttonTENOff_Click(object sender, EventArgs e)
        {
            SerialPortManager.mySerialPort.WriteLine("h");
            labelTENStatus.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
        }

        private void checkBoxPumpStop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPumpStop.Checked)
            {
                groupBoxPumpStop.Enabled = true;
                comboBoxPumpInterval.SelectedIndex = 0;
            }
            else
            {
                groupBoxPumpStop.Enabled = false;
            }
        }

        private void buttonPumpOn_Click(object sender, EventArgs e)
        {
            SerialPortManager.mySerialPort.WriteLine("P");
            labelPumpStatus.Text = "СТАТУС:\r\nВКЛЮЧЕНО";
            if (checkBoxPumpStop.Checked && int.TryParse(comboBoxPumpInterval.Text, out int interval))
            {
                timerPumpStop.Interval = interval;
                timerPumpStop.Tick += TimerTickPump;
                timerPumpStop.Start();
            }
        }

        private void TimerTickPump(object sender, EventArgs e)
        {
            timerPumpStop.Stop();
            timerPumpStop.Tick -= TimerTickPump;
            SerialPortManager.mySerialPort.WriteLine("p");
            labelPumpStatus.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
        }

        private void buttonPumpOff_Click(object sender, EventArgs e)
        {
            SerialPortManager.mySerialPort.WriteLine("p");
            labelPumpStatus.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
        }

        private void checkBoxMotor1Stop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMotor1Stop.Checked)
            {
                groupBoxMotor1Stop.Enabled = true;
                comboBoxMotor1Interval.SelectedIndex = 0;
            }
            else
            {
                groupBoxMotor1Stop.Enabled = false;
            }
        }

        private void buttonMotor1On_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                if (uint.TryParse(textBoxMotor1Speed.Text, out uint valueMotor1Speed) && valueMotor1Speed < 256)
                {

                    SerialPortManager.mySerialPort.WriteLine($"Y{valueMotor1Speed}");
                    labelMotor1Status.Text = "СТАТУС:\r\nВКЛЮЧЕНО";
                    if (checkBoxMotor1Stop.Checked && int.TryParse(comboBoxMotor1Interval.Text, out int interval))
                    {
                        timerMotor1Stop.Interval = interval;
                        timerMotor1Stop.Tick += TimerTickMotor1;
                        timerMotor1Stop.Start();
                    }
                }
            }
        }

        private void TimerTickMotor1(object sender, EventArgs e)
        {
            timerMotor1Stop.Stop();
            timerMotor1Stop.Tick -= TimerTickMotor1;
            SerialPortManager.mySerialPort.WriteLine("y");
            labelMotor1Status.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
        }

        private void buttonMotor1Off_Click(object sender, EventArgs e)
        {
            SerialPortManager.mySerialPort.WriteLine("y");
            labelMotor1Status.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
        }

        private void buttonLedChipOn_Click(object sender, EventArgs e)
        {
            SerialPortManager.mySerialPort.WriteLine("L");
            labelLedChipStatus.Text = "СТАТУС:\r\nВКЛЮЧЕНО";
            if (checkBoxLedChipStop.Checked && int.TryParse(comboBoxLedChipInterval.Text, out int interval))
            {
                timerLedChipStop.Interval = interval;
                timerLedChipStop.Tick += TimerTickLedChip;
                timerLedChipStop.Start();
            }
        }

        private void TimerTickLedChip(object sender, EventArgs e)
        {
            timerLedChipStop.Stop();
            timerLedChipStop.Tick -= TimerTickLedChip;
            SerialPortManager.mySerialPort.WriteLine("l");
            labelLedChipStatus.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
        }

        private void buttonLedChipOff_Click(object sender, EventArgs e)
        {
            SerialPortManager.mySerialPort.WriteLine("l");
            labelLedChipStatus.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
        }

        private void checkBoxLedChipStop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLedChipStop.Checked)
            {
                groupBoxLedChipInterval.Enabled = true;
                comboBoxLedChipInterval.SelectedIndex = 0;
            }
            else
            {
                groupBoxLedChip.Enabled = false;
            }
        }
    }
}