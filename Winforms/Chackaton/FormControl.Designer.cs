namespace Chackaton
{
    partial class FormControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBoxConnection = new GroupBox();
            comboBoxPorts = new ComboBox();
            buttonUpdate = new Button();
            buttonConnect = new Button();
            groupBoxData = new GroupBox();
            groupBoxWaterTemp = new GroupBox();
            labelWaterTemp = new Label();
            groupBoxCO2 = new GroupBox();
            labelCO2 = new Label();
            groupBoxAirTemp = new GroupBox();
            labelAirTemp = new Label();
            groupBoxLightLevel = new GroupBox();
            labelLightLevel = new Label();
            groupBoxAirHum = new GroupBox();
            labelAirHum = new Label();
            groupBoxDevices = new GroupBox();
            groupBoxLedChip = new GroupBox();
            labelLedChipStatus = new Label();
            buttonLedChipOff = new Button();
            buttonLedChipOn = new Button();
            checkBoxLedChipStop = new CheckBox();
            groupBoxLedChipInterval = new GroupBox();
            comboBoxLedChipInterval = new ComboBox();
            labelLedChipStop = new Label();
            groupBoxMotor1 = new GroupBox();
            label1 = new Label();
            textBoxMotor1Speed = new TextBox();
            labelMotor1Status = new Label();
            buttonMotor1Off = new Button();
            buttonMotor1On = new Button();
            checkBoxMotor1Stop = new CheckBox();
            groupBoxMotor1Stop = new GroupBox();
            comboBoxMotor1Interval = new ComboBox();
            labelMotor1Stop = new Label();
            groupBoxPump = new GroupBox();
            labelPumpStatus = new Label();
            buttonPumpOff = new Button();
            buttonPumpOn = new Button();
            checkBoxPumpStop = new CheckBox();
            groupBoxPumpStop = new GroupBox();
            comboBoxPumpInterval = new ComboBox();
            labelPumpStop = new Label();
            groupBoxTEN = new GroupBox();
            labelTENStatus = new Label();
            buttonTENOff = new Button();
            buttonTENOn = new Button();
            checkBoxTENStop = new CheckBox();
            groupBoxTENStop = new GroupBox();
            comboBoxTENInterval = new ComboBox();
            labelTENStop = new Label();
            timerTENStop = new System.Windows.Forms.Timer(components);
            timerPumpStop = new System.Windows.Forms.Timer(components);
            timerMotor1Stop = new System.Windows.Forms.Timer(components);
            timerLedChipStop = new System.Windows.Forms.Timer(components);
            groupBoxConnection.SuspendLayout();
            groupBoxData.SuspendLayout();
            groupBoxWaterTemp.SuspendLayout();
            groupBoxCO2.SuspendLayout();
            groupBoxAirTemp.SuspendLayout();
            groupBoxLightLevel.SuspendLayout();
            groupBoxAirHum.SuspendLayout();
            groupBoxDevices.SuspendLayout();
            groupBoxLedChip.SuspendLayout();
            groupBoxLedChipInterval.SuspendLayout();
            groupBoxMotor1.SuspendLayout();
            groupBoxMotor1Stop.SuspendLayout();
            groupBoxPump.SuspendLayout();
            groupBoxPumpStop.SuspendLayout();
            groupBoxTEN.SuspendLayout();
            groupBoxTENStop.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConnection
            // 
            groupBoxConnection.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxConnection.Controls.Add(comboBoxPorts);
            groupBoxConnection.Controls.Add(buttonUpdate);
            groupBoxConnection.Controls.Add(buttonConnect);
            groupBoxConnection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxConnection.Location = new Point(10, 10);
            groupBoxConnection.Name = "groupBoxConnection";
            groupBoxConnection.Size = new Size(290, 135);
            groupBoxConnection.TabIndex = 1;
            groupBoxConnection.TabStop = false;
            groupBoxConnection.Text = "ПОДКЛЮЧЕНИЕ";
            // 
            // comboBoxPorts
            // 
            comboBoxPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPorts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxPorts.ForeColor = Color.Black;
            comboBoxPorts.FormattingEnabled = true;
            comboBoxPorts.Location = new Point(5, 30);
            comboBoxPorts.Name = "comboBoxPorts";
            comboBoxPorts.Size = new Size(121, 29);
            comboBoxPorts.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonUpdate.ForeColor = Color.Black;
            buttonUpdate.Location = new Point(150, 70);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(135, 50);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonConnect
            // 
            buttonConnect.Cursor = Cursors.Hand;
            buttonConnect.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonConnect.ForeColor = Color.Green;
            buttonConnect.Location = new Point(150, 15);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(135, 50);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Подключиться";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // groupBoxData
            // 
            groupBoxData.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxData.Controls.Add(groupBoxWaterTemp);
            groupBoxData.Controls.Add(groupBoxCO2);
            groupBoxData.Controls.Add(groupBoxAirTemp);
            groupBoxData.Controls.Add(groupBoxLightLevel);
            groupBoxData.Controls.Add(groupBoxAirHum);
            groupBoxData.Enabled = false;
            groupBoxData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxData.ForeColor = Color.Black;
            groupBoxData.Location = new Point(310, 10);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(290, 450);
            groupBoxData.TabIndex = 3;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "ДАТЧИКИ";
            // 
            // groupBoxWaterTemp
            // 
            groupBoxWaterTemp.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxWaterTemp.Controls.Add(labelWaterTemp);
            groupBoxWaterTemp.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxWaterTemp.ForeColor = Color.Black;
            groupBoxWaterTemp.Location = new Point(5, 319);
            groupBoxWaterTemp.Name = "groupBoxWaterTemp";
            groupBoxWaterTemp.Size = new Size(130, 110);
            groupBoxWaterTemp.TabIndex = 6;
            groupBoxWaterTemp.TabStop = false;
            groupBoxWaterTemp.Text = "ТЕМПЕРАТУРА ВОДЫ";
            // 
            // labelWaterTemp
            // 
            labelWaterTemp.AutoSize = true;
            labelWaterTemp.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWaterTemp.ForeColor = Color.Black;
            labelWaterTemp.Location = new Point(30, 50);
            labelWaterTemp.Name = "labelWaterTemp";
            labelWaterTemp.Size = new Size(32, 37);
            labelWaterTemp.TabIndex = 4;
            labelWaterTemp.Text = "0";
            // 
            // groupBoxCO2
            // 
            groupBoxCO2.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxCO2.Controls.Add(labelCO2);
            groupBoxCO2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxCO2.ForeColor = Color.Black;
            groupBoxCO2.Location = new Point(155, 180);
            groupBoxCO2.Name = "groupBoxCO2";
            groupBoxCO2.Size = new Size(130, 110);
            groupBoxCO2.TabIndex = 7;
            groupBoxCO2.TabStop = false;
            groupBoxCO2.Text = "CO2";
            // 
            // labelCO2
            // 
            labelCO2.AutoSize = true;
            labelCO2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCO2.ForeColor = Color.Black;
            labelCO2.Location = new Point(30, 50);
            labelCO2.Name = "labelCO2";
            labelCO2.Size = new Size(32, 37);
            labelCO2.TabIndex = 4;
            labelCO2.Text = "0";
            // 
            // groupBoxAirTemp
            // 
            groupBoxAirTemp.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxAirTemp.Controls.Add(labelAirTemp);
            groupBoxAirTemp.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxAirTemp.ForeColor = Color.Black;
            groupBoxAirTemp.Location = new Point(155, 25);
            groupBoxAirTemp.Name = "groupBoxAirTemp";
            groupBoxAirTemp.Size = new Size(130, 110);
            groupBoxAirTemp.TabIndex = 8;
            groupBoxAirTemp.TabStop = false;
            groupBoxAirTemp.Text = "ТЕМПЕРАТУРА ВОЗДУХА";
            // 
            // labelAirTemp
            // 
            labelAirTemp.AutoSize = true;
            labelAirTemp.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAirTemp.ForeColor = Color.Black;
            labelAirTemp.Location = new Point(30, 50);
            labelAirTemp.Name = "labelAirTemp";
            labelAirTemp.Size = new Size(32, 37);
            labelAirTemp.TabIndex = 4;
            labelAirTemp.Text = "0";
            // 
            // groupBoxLightLevel
            // 
            groupBoxLightLevel.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxLightLevel.Controls.Add(labelLightLevel);
            groupBoxLightLevel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxLightLevel.ForeColor = Color.Black;
            groupBoxLightLevel.Location = new Point(5, 180);
            groupBoxLightLevel.Name = "groupBoxLightLevel";
            groupBoxLightLevel.Size = new Size(130, 110);
            groupBoxLightLevel.TabIndex = 6;
            groupBoxLightLevel.TabStop = false;
            groupBoxLightLevel.Text = "МУТНОСТЬ / СВЕТ";
            // 
            // labelLightLevel
            // 
            labelLightLevel.AutoSize = true;
            labelLightLevel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLightLevel.ForeColor = Color.Black;
            labelLightLevel.Location = new Point(30, 50);
            labelLightLevel.Name = "labelLightLevel";
            labelLightLevel.Size = new Size(32, 37);
            labelLightLevel.TabIndex = 4;
            labelLightLevel.Text = "0";
            // 
            // groupBoxAirHum
            // 
            groupBoxAirHum.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxAirHum.Controls.Add(labelAirHum);
            groupBoxAirHum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxAirHum.ForeColor = Color.Black;
            groupBoxAirHum.Location = new Point(5, 25);
            groupBoxAirHum.Name = "groupBoxAirHum";
            groupBoxAirHum.Size = new Size(130, 110);
            groupBoxAirHum.TabIndex = 5;
            groupBoxAirHum.TabStop = false;
            groupBoxAirHum.Text = "ВЛАЖНОСТЬ ВОЗДУХА";
            // 
            // labelAirHum
            // 
            labelAirHum.AutoSize = true;
            labelAirHum.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAirHum.ForeColor = Color.Black;
            labelAirHum.Location = new Point(30, 50);
            labelAirHum.Name = "labelAirHum";
            labelAirHum.Size = new Size(32, 37);
            labelAirHum.TabIndex = 4;
            labelAirHum.Text = "0";
            // 
            // groupBoxDevices
            // 
            groupBoxDevices.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxDevices.Controls.Add(groupBoxLedChip);
            groupBoxDevices.Controls.Add(groupBoxMotor1);
            groupBoxDevices.Controls.Add(groupBoxPump);
            groupBoxDevices.Controls.Add(groupBoxTEN);
            groupBoxDevices.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxDevices.Location = new Point(615, 10);
            groupBoxDevices.Name = "groupBoxDevices";
            groupBoxDevices.Size = new Size(780, 560);
            groupBoxDevices.TabIndex = 4;
            groupBoxDevices.TabStop = false;
            groupBoxDevices.Text = "ИСПОЛНИТЕЛЬНЫЕ УСТРОЙСТВА";
            // 
            // groupBoxLedChip
            // 
            groupBoxLedChip.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxLedChip.Controls.Add(labelLedChipStatus);
            groupBoxLedChip.Controls.Add(buttonLedChipOff);
            groupBoxLedChip.Controls.Add(buttonLedChipOn);
            groupBoxLedChip.Controls.Add(checkBoxLedChipStop);
            groupBoxLedChip.Controls.Add(groupBoxLedChipInterval);
            groupBoxLedChip.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxLedChip.ForeColor = Color.Black;
            groupBoxLedChip.Location = new Point(474, 294);
            groupBoxLedChip.Name = "groupBoxLedChip";
            groupBoxLedChip.Size = new Size(295, 245);
            groupBoxLedChip.TabIndex = 25;
            groupBoxLedChip.TabStop = false;
            groupBoxLedChip.Text = "СВЕТОВОЙ ЧИП";
            // 
            // labelLedChipStatus
            // 
            labelLedChipStatus.AutoSize = true;
            labelLedChipStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelLedChipStatus.ForeColor = Color.Black;
            labelLedChipStatus.Location = new Point(10, 170);
            labelLedChipStatus.Name = "labelLedChipStatus";
            labelLedChipStatus.Size = new Size(115, 42);
            labelLedChipStatus.TabIndex = 23;
            labelLedChipStatus.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
            // 
            // buttonLedChipOff
            // 
            buttonLedChipOff.Cursor = Cursors.Hand;
            buttonLedChipOff.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLedChipOff.ForeColor = Color.Black;
            buttonLedChipOff.Location = new Point(140, 167);
            buttonLedChipOff.Name = "buttonLedChipOff";
            buttonLedChipOff.Size = new Size(150, 70);
            buttonLedChipOff.TabIndex = 22;
            buttonLedChipOff.Text = "Выключить";
            buttonLedChipOff.UseVisualStyleBackColor = true;
            buttonLedChipOff.Click += buttonLedChipOff_Click;
            // 
            // buttonLedChipOn
            // 
            buttonLedChipOn.Cursor = Cursors.Hand;
            buttonLedChipOn.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLedChipOn.ForeColor = Color.Black;
            buttonLedChipOn.Location = new Point(140, 50);
            buttonLedChipOn.Name = "buttonLedChipOn";
            buttonLedChipOn.Size = new Size(150, 70);
            buttonLedChipOn.TabIndex = 19;
            buttonLedChipOn.Text = "Включить";
            buttonLedChipOn.UseVisualStyleBackColor = true;
            buttonLedChipOn.Click += buttonLedChipOn_Click;
            // 
            // checkBoxLedChipStop
            // 
            checkBoxLedChipStop.AutoSize = true;
            checkBoxLedChipStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxLedChipStop.Location = new Point(10, 25);
            checkBoxLedChipStop.Name = "checkBoxLedChipStop";
            checkBoxLedChipStop.Size = new Size(213, 25);
            checkBoxLedChipStop.TabIndex = 20;
            checkBoxLedChipStop.Text = "Выключить по таймеру?";
            checkBoxLedChipStop.UseVisualStyleBackColor = true;
            checkBoxLedChipStop.CheckedChanged += checkBoxLedChipStop_CheckedChanged;
            // 
            // groupBoxLedChipInterval
            // 
            groupBoxLedChipInterval.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxLedChipInterval.Controls.Add(comboBoxLedChipInterval);
            groupBoxLedChipInterval.Controls.Add(labelLedChipStop);
            groupBoxLedChipInterval.Enabled = false;
            groupBoxLedChipInterval.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxLedChipInterval.ForeColor = Color.Black;
            groupBoxLedChipInterval.Location = new Point(5, 35);
            groupBoxLedChipInterval.Name = "groupBoxLedChipInterval";
            groupBoxLedChipInterval.Size = new Size(130, 125);
            groupBoxLedChipInterval.TabIndex = 21;
            groupBoxLedChipInterval.TabStop = false;
            // 
            // comboBoxLedChipInterval
            // 
            comboBoxLedChipInterval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxLedChipInterval.ForeColor = Color.Black;
            comboBoxLedChipInterval.FormattingEnabled = true;
            comboBoxLedChipInterval.Items.AddRange(new object[] { "5000", "10000", "30000", "60000" });
            comboBoxLedChipInterval.Location = new Point(5, 15);
            comboBoxLedChipInterval.Name = "comboBoxLedChipInterval";
            comboBoxLedChipInterval.Size = new Size(121, 29);
            comboBoxLedChipInterval.TabIndex = 4;
            // 
            // labelLedChipStop
            // 
            labelLedChipStop.AutoSize = true;
            labelLedChipStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelLedChipStop.ForeColor = Color.Black;
            labelLedChipStop.Location = new Point(13, 50);
            labelLedChipStop.Name = "labelLedChipStop";
            labelLedChipStop.Size = new Size(105, 63);
            labelLedChipStop.TabIndex = 6;
            labelLedChipStop.Text = "Время в мс, \r\nкогда чип\r\nостановится";
            // 
            // groupBoxMotor1
            // 
            groupBoxMotor1.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotor1.Controls.Add(label1);
            groupBoxMotor1.Controls.Add(textBoxMotor1Speed);
            groupBoxMotor1.Controls.Add(labelMotor1Status);
            groupBoxMotor1.Controls.Add(buttonMotor1Off);
            groupBoxMotor1.Controls.Add(buttonMotor1On);
            groupBoxMotor1.Controls.Add(checkBoxMotor1Stop);
            groupBoxMotor1.Controls.Add(groupBoxMotor1Stop);
            groupBoxMotor1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotor1.ForeColor = Color.Black;
            groupBoxMotor1.Location = new Point(15, 294);
            groupBoxMotor1.Name = "groupBoxMotor1";
            groupBoxMotor1.Size = new Size(442, 245);
            groupBoxMotor1.TabIndex = 24;
            groupBoxMotor1.TabStop = false;
            groupBoxMotor1.Text = "МОТОР ПЕРЕМЕШИВАНИЕ 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(149, 53);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 25;
            label1.Text = "Скорость 0-255:";
            // 
            // textBoxMotor1Speed
            // 
            textBoxMotor1Speed.Location = new Point(162, 85);
            textBoxMotor1Speed.Name = "textBoxMotor1Speed";
            textBoxMotor1Speed.Size = new Size(100, 29);
            textBoxMotor1Speed.TabIndex = 24;
            // 
            // labelMotor1Status
            // 
            labelMotor1Status.AutoSize = true;
            labelMotor1Status.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelMotor1Status.ForeColor = Color.Black;
            labelMotor1Status.Location = new Point(10, 170);
            labelMotor1Status.Name = "labelMotor1Status";
            labelMotor1Status.Size = new Size(115, 42);
            labelMotor1Status.TabIndex = 23;
            labelMotor1Status.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
            // 
            // buttonMotor1Off
            // 
            buttonMotor1Off.Cursor = Cursors.Hand;
            buttonMotor1Off.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMotor1Off.ForeColor = Color.Black;
            buttonMotor1Off.Location = new Point(286, 169);
            buttonMotor1Off.Name = "buttonMotor1Off";
            buttonMotor1Off.Size = new Size(150, 70);
            buttonMotor1Off.TabIndex = 22;
            buttonMotor1Off.Text = "Выключить";
            buttonMotor1Off.UseVisualStyleBackColor = true;
            buttonMotor1Off.Click += buttonMotor1Off_Click;
            // 
            // buttonMotor1On
            // 
            buttonMotor1On.Cursor = Cursors.Hand;
            buttonMotor1On.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMotor1On.ForeColor = Color.Black;
            buttonMotor1On.Location = new Point(286, 50);
            buttonMotor1On.Name = "buttonMotor1On";
            buttonMotor1On.Size = new Size(150, 70);
            buttonMotor1On.TabIndex = 19;
            buttonMotor1On.Text = "Включить";
            buttonMotor1On.UseVisualStyleBackColor = true;
            buttonMotor1On.Click += buttonMotor1On_Click;
            // 
            // checkBoxMotor1Stop
            // 
            checkBoxMotor1Stop.AutoSize = true;
            checkBoxMotor1Stop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxMotor1Stop.Location = new Point(10, 25);
            checkBoxMotor1Stop.Name = "checkBoxMotor1Stop";
            checkBoxMotor1Stop.Size = new Size(213, 25);
            checkBoxMotor1Stop.TabIndex = 20;
            checkBoxMotor1Stop.Text = "Выключить по таймеру?";
            checkBoxMotor1Stop.UseVisualStyleBackColor = true;
            checkBoxMotor1Stop.CheckedChanged += checkBoxMotor1Stop_CheckedChanged;
            // 
            // groupBoxMotor1Stop
            // 
            groupBoxMotor1Stop.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotor1Stop.Controls.Add(comboBoxMotor1Interval);
            groupBoxMotor1Stop.Controls.Add(labelMotor1Stop);
            groupBoxMotor1Stop.Enabled = false;
            groupBoxMotor1Stop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotor1Stop.ForeColor = Color.Black;
            groupBoxMotor1Stop.Location = new Point(5, 35);
            groupBoxMotor1Stop.Name = "groupBoxMotor1Stop";
            groupBoxMotor1Stop.Size = new Size(130, 125);
            groupBoxMotor1Stop.TabIndex = 21;
            groupBoxMotor1Stop.TabStop = false;
            // 
            // comboBoxMotor1Interval
            // 
            comboBoxMotor1Interval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxMotor1Interval.ForeColor = Color.Black;
            comboBoxMotor1Interval.FormattingEnabled = true;
            comboBoxMotor1Interval.Items.AddRange(new object[] { "5000", "10000", "30000", "60000" });
            comboBoxMotor1Interval.Location = new Point(5, 15);
            comboBoxMotor1Interval.Name = "comboBoxMotor1Interval";
            comboBoxMotor1Interval.Size = new Size(121, 29);
            comboBoxMotor1Interval.TabIndex = 4;
            // 
            // labelMotor1Stop
            // 
            labelMotor1Stop.AutoSize = true;
            labelMotor1Stop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelMotor1Stop.ForeColor = Color.Black;
            labelMotor1Stop.Location = new Point(13, 50);
            labelMotor1Stop.Name = "labelMotor1Stop";
            labelMotor1Stop.Size = new Size(113, 63);
            labelMotor1Stop.TabIndex = 6;
            labelMotor1Stop.Text = "Время в мс, \r\nкогда мотор 1\r\nостановится";
            // 
            // groupBoxPump
            // 
            groupBoxPump.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxPump.Controls.Add(labelPumpStatus);
            groupBoxPump.Controls.Add(buttonPumpOff);
            groupBoxPump.Controls.Add(buttonPumpOn);
            groupBoxPump.Controls.Add(checkBoxPumpStop);
            groupBoxPump.Controls.Add(groupBoxPumpStop);
            groupBoxPump.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxPump.ForeColor = Color.Black;
            groupBoxPump.Location = new Point(334, 30);
            groupBoxPump.Name = "groupBoxPump";
            groupBoxPump.Size = new Size(295, 245);
            groupBoxPump.TabIndex = 23;
            groupBoxPump.TabStop = false;
            groupBoxPump.Text = "ПОМПА";
            // 
            // labelPumpStatus
            // 
            labelPumpStatus.AutoSize = true;
            labelPumpStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelPumpStatus.ForeColor = Color.Black;
            labelPumpStatus.Location = new Point(10, 170);
            labelPumpStatus.Name = "labelPumpStatus";
            labelPumpStatus.Size = new Size(115, 42);
            labelPumpStatus.TabIndex = 23;
            labelPumpStatus.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
            // 
            // buttonPumpOff
            // 
            buttonPumpOff.Cursor = Cursors.Hand;
            buttonPumpOff.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPumpOff.ForeColor = Color.Black;
            buttonPumpOff.Location = new Point(140, 167);
            buttonPumpOff.Name = "buttonPumpOff";
            buttonPumpOff.Size = new Size(150, 70);
            buttonPumpOff.TabIndex = 22;
            buttonPumpOff.Text = "Выключить";
            buttonPumpOff.UseVisualStyleBackColor = true;
            buttonPumpOff.Click += buttonPumpOff_Click;
            // 
            // buttonPumpOn
            // 
            buttonPumpOn.Cursor = Cursors.Hand;
            buttonPumpOn.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPumpOn.ForeColor = Color.Black;
            buttonPumpOn.Location = new Point(140, 50);
            buttonPumpOn.Name = "buttonPumpOn";
            buttonPumpOn.Size = new Size(150, 70);
            buttonPumpOn.TabIndex = 19;
            buttonPumpOn.Text = "Включить";
            buttonPumpOn.UseVisualStyleBackColor = true;
            buttonPumpOn.Click += buttonPumpOn_Click;
            // 
            // checkBoxPumpStop
            // 
            checkBoxPumpStop.AutoSize = true;
            checkBoxPumpStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxPumpStop.Location = new Point(10, 25);
            checkBoxPumpStop.Name = "checkBoxPumpStop";
            checkBoxPumpStop.Size = new Size(213, 25);
            checkBoxPumpStop.TabIndex = 20;
            checkBoxPumpStop.Text = "Выключить по таймеру?";
            checkBoxPumpStop.UseVisualStyleBackColor = true;
            checkBoxPumpStop.CheckedChanged += checkBoxPumpStop_CheckedChanged;
            // 
            // groupBoxPumpStop
            // 
            groupBoxPumpStop.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxPumpStop.Controls.Add(comboBoxPumpInterval);
            groupBoxPumpStop.Controls.Add(labelPumpStop);
            groupBoxPumpStop.Enabled = false;
            groupBoxPumpStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxPumpStop.ForeColor = Color.Black;
            groupBoxPumpStop.Location = new Point(5, 35);
            groupBoxPumpStop.Name = "groupBoxPumpStop";
            groupBoxPumpStop.Size = new Size(130, 125);
            groupBoxPumpStop.TabIndex = 21;
            groupBoxPumpStop.TabStop = false;
            // 
            // comboBoxPumpInterval
            // 
            comboBoxPumpInterval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxPumpInterval.ForeColor = Color.Black;
            comboBoxPumpInterval.FormattingEnabled = true;
            comboBoxPumpInterval.Items.AddRange(new object[] { "5000", "10000", "30000", "60000" });
            comboBoxPumpInterval.Location = new Point(5, 15);
            comboBoxPumpInterval.Name = "comboBoxPumpInterval";
            comboBoxPumpInterval.Size = new Size(121, 29);
            comboBoxPumpInterval.TabIndex = 4;
            // 
            // labelPumpStop
            // 
            labelPumpStop.AutoSize = true;
            labelPumpStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelPumpStop.ForeColor = Color.Black;
            labelPumpStop.Location = new Point(13, 50);
            labelPumpStop.Name = "labelPumpStop";
            labelPumpStop.Size = new Size(105, 63);
            labelPumpStop.TabIndex = 6;
            labelPumpStop.Text = "Время в мс, \r\nкогда помпа\r\nостановится";
            // 
            // groupBoxTEN
            // 
            groupBoxTEN.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxTEN.Controls.Add(labelTENStatus);
            groupBoxTEN.Controls.Add(buttonTENOff);
            groupBoxTEN.Controls.Add(buttonTENOn);
            groupBoxTEN.Controls.Add(checkBoxTENStop);
            groupBoxTEN.Controls.Add(groupBoxTENStop);
            groupBoxTEN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxTEN.ForeColor = Color.Black;
            groupBoxTEN.Location = new Point(15, 30);
            groupBoxTEN.Name = "groupBoxTEN";
            groupBoxTEN.Size = new Size(295, 245);
            groupBoxTEN.TabIndex = 22;
            groupBoxTEN.TabStop = false;
            groupBoxTEN.Text = "ПЕЛЬТЬЕ";
            // 
            // labelTENStatus
            // 
            labelTENStatus.AutoSize = true;
            labelTENStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelTENStatus.ForeColor = Color.Black;
            labelTENStatus.Location = new Point(10, 170);
            labelTENStatus.Name = "labelTENStatus";
            labelTENStatus.Size = new Size(115, 42);
            labelTENStatus.TabIndex = 23;
            labelTENStatus.Text = "СТАТУС:\r\nВЫКЛЮЧЕНО";
            // 
            // buttonTENOff
            // 
            buttonTENOff.Cursor = Cursors.Hand;
            buttonTENOff.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTENOff.ForeColor = Color.Black;
            buttonTENOff.Location = new Point(140, 167);
            buttonTENOff.Name = "buttonTENOff";
            buttonTENOff.Size = new Size(150, 70);
            buttonTENOff.TabIndex = 22;
            buttonTENOff.Text = "Выключить";
            buttonTENOff.UseVisualStyleBackColor = true;
            buttonTENOff.Click += buttonTENOff_Click;
            // 
            // buttonTENOn
            // 
            buttonTENOn.Cursor = Cursors.Hand;
            buttonTENOn.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTENOn.ForeColor = Color.Black;
            buttonTENOn.Location = new Point(140, 50);
            buttonTENOn.Name = "buttonTENOn";
            buttonTENOn.Size = new Size(150, 70);
            buttonTENOn.TabIndex = 19;
            buttonTENOn.Text = "Включить";
            buttonTENOn.UseVisualStyleBackColor = true;
            buttonTENOn.Click += buttonTENOn_Click;
            // 
            // checkBoxTENStop
            // 
            checkBoxTENStop.AutoSize = true;
            checkBoxTENStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxTENStop.Location = new Point(10, 25);
            checkBoxTENStop.Name = "checkBoxTENStop";
            checkBoxTENStop.Size = new Size(213, 25);
            checkBoxTENStop.TabIndex = 20;
            checkBoxTENStop.Text = "Выключить по таймеру?";
            checkBoxTENStop.UseVisualStyleBackColor = true;
            checkBoxTENStop.CheckedChanged += checkBoxTENStop_CheckedChanged;
            // 
            // groupBoxTENStop
            // 
            groupBoxTENStop.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxTENStop.Controls.Add(comboBoxTENInterval);
            groupBoxTENStop.Controls.Add(labelTENStop);
            groupBoxTENStop.Enabled = false;
            groupBoxTENStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxTENStop.ForeColor = Color.Black;
            groupBoxTENStop.Location = new Point(5, 35);
            groupBoxTENStop.Name = "groupBoxTENStop";
            groupBoxTENStop.Size = new Size(130, 125);
            groupBoxTENStop.TabIndex = 21;
            groupBoxTENStop.TabStop = false;
            // 
            // comboBoxTENInterval
            // 
            comboBoxTENInterval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxTENInterval.ForeColor = Color.Black;
            comboBoxTENInterval.FormattingEnabled = true;
            comboBoxTENInterval.Items.AddRange(new object[] { "5000", "10000", "30000", "60000" });
            comboBoxTENInterval.Location = new Point(5, 15);
            comboBoxTENInterval.Name = "comboBoxTENInterval";
            comboBoxTENInterval.Size = new Size(121, 29);
            comboBoxTENInterval.TabIndex = 4;
            // 
            // labelTENStop
            // 
            labelTENStop.AutoSize = true;
            labelTENStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelTENStop.ForeColor = Color.Black;
            labelTENStop.Location = new Point(13, 50);
            labelTENStop.Name = "labelTENStop";
            labelTENStop.Size = new Size(105, 63);
            labelTENStop.TabIndex = 6;
            labelTENStop.Text = "Время в мс, \r\nкогда пельте\r\nостановится";
            // 
            // FormControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1404, 621);
            Controls.Add(groupBoxDevices);
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxConnection);
            Name = "FormControl";
            Text = "FormControl";
            groupBoxConnection.ResumeLayout(false);
            groupBoxData.ResumeLayout(false);
            groupBoxWaterTemp.ResumeLayout(false);
            groupBoxWaterTemp.PerformLayout();
            groupBoxCO2.ResumeLayout(false);
            groupBoxCO2.PerformLayout();
            groupBoxAirTemp.ResumeLayout(false);
            groupBoxAirTemp.PerformLayout();
            groupBoxLightLevel.ResumeLayout(false);
            groupBoxLightLevel.PerformLayout();
            groupBoxAirHum.ResumeLayout(false);
            groupBoxAirHum.PerformLayout();
            groupBoxDevices.ResumeLayout(false);
            groupBoxLedChip.ResumeLayout(false);
            groupBoxLedChip.PerformLayout();
            groupBoxLedChipInterval.ResumeLayout(false);
            groupBoxLedChipInterval.PerformLayout();
            groupBoxMotor1.ResumeLayout(false);
            groupBoxMotor1.PerformLayout();
            groupBoxMotor1Stop.ResumeLayout(false);
            groupBoxMotor1Stop.PerformLayout();
            groupBoxPump.ResumeLayout(false);
            groupBoxPump.PerformLayout();
            groupBoxPumpStop.ResumeLayout(false);
            groupBoxPumpStop.PerformLayout();
            groupBoxTEN.ResumeLayout(false);
            groupBoxTEN.PerformLayout();
            groupBoxTENStop.ResumeLayout(false);
            groupBoxTENStop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConnection;
        private ComboBox comboBoxPorts;
        private Button buttonUpdate;
        private Button buttonConnect;
        private GroupBox groupBoxData;
        private GroupBox groupBoxWaterTemp;
        private Label labelWaterTemp;
        private GroupBox groupBoxCO2;
        private Label labelCO2;
        private GroupBox groupBoxAirTemp;
        private Label labelAirTemp;
        private GroupBox groupBoxLightLevel;
        private Label labelLightLevel;
        private GroupBox groupBoxAirHum;
        private Label labelAirHum;
        private GroupBox groupBoxDevices;
        private GroupBox groupBoxTEN;
        private Button buttonTENOn;
        private CheckBox checkBoxTENStop;
        private GroupBox groupBoxTENStop;
        private ComboBox comboBoxTENInterval;
        private Label labelTENStop;
        private Button buttonTENOff;
        private System.Windows.Forms.Timer timerTENStop;
        private Label labelTENStatus;
        private GroupBox groupBoxPump;
        private Label labelPumpStatus;
        private Button buttonPumpOff;
        private Button buttonPumpOn;
        private CheckBox checkBoxPumpStop;
        private GroupBox groupBoxPumpStop;
        private ComboBox comboBoxPumpInterval;
        private Label labelPumpStop;
        private System.Windows.Forms.Timer timerPumpStop;
        private GroupBox groupBoxMotor1;
        private Label labelMotor1Status;
        private Button buttonMotor1Off;
        private Button buttonMotor1On;
        private CheckBox checkBoxMotor1Stop;
        private GroupBox groupBoxMotor1Stop;
        private ComboBox comboBoxMotor1Interval;
        private Label labelMotor1Stop;
        private Label label1;
        private TextBox textBoxMotor1Speed;
        private System.Windows.Forms.Timer timerMotor1Stop;
        private GroupBox groupBoxLedChip;
        private Label labelLedChipStatus;
        private Button buttonLedChipOff;
        private Button buttonLedChipOn;
        private CheckBox checkBoxLedChipStop;
        private GroupBox groupBoxLedChipInterval;
        private ComboBox comboBoxLedChipInterval;
        private Label labelLedChipStop;
        private System.Windows.Forms.Timer timerLedChipStop;
    }
}