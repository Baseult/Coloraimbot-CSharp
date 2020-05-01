namespace ValorantAimbotUI
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002A9F File Offset: 0x00000C9F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002AC0 File Offset: 0x00000CC0
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.CheckBox AimbotBtt;
            System.Windows.Forms.NumericUpDown Speed;
            System.Windows.Forms.NumericUpDown FovXNum;
            System.Windows.Forms.NumericUpDown FovYNum;
            System.Windows.Forms.NumericUpDown offsetNum;
            System.Windows.Forms.NumericUpDown Speed3;
            System.Windows.Forms.NumericUpDown Delayx;
            System.Windows.Forms.NumericUpDown SmoothY;
            System.Windows.Forms.NumericUpDown SmoothX;
            System.Windows.Forms.Button AimkeyBtt;
            System.Windows.Forms.NumericUpDown rcs;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RecoilBtt = new System.Windows.Forms.CheckBox();
            this.TriggerbotBtt = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RedRadio = new System.Windows.Forms.RadioButton();
            this.PurpleRadio = new System.Windows.Forms.RadioButton();
            this.ChangeMonitorBtt = new System.Windows.Forms.Button();
            this.AimKeyToggle = new System.Windows.Forms.CheckBox();
            this.IsHoldToggle = new System.Windows.Forms.CheckBox();
            this.StartBtt = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FireRateNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Customcolor = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.Redinput = new System.Windows.Forms.NumericUpDown();
            this.Greeninput = new System.Windows.Forms.NumericUpDown();
            this.Blueinput = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Pingx = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PixelY = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.ScreenX2 = new System.Windows.Forms.NumericUpDown();
            this.ScreenY2 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.ScreenY = new System.Windows.Forms.Label();
            this.CustomScreen = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Bhopbox = new System.Windows.Forms.CheckBox();
            this.Bhopinput = new System.Windows.Forms.NumericUpDown();
            this.TriggerKeyBtt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Ping = new System.Windows.Forms.CheckBox();
            this.Calloutchat = new System.Windows.Forms.CheckBox();
            AimbotBtt = new System.Windows.Forms.CheckBox();
            Speed = new System.Windows.Forms.NumericUpDown();
            FovXNum = new System.Windows.Forms.NumericUpDown();
            FovYNum = new System.Windows.Forms.NumericUpDown();
            offsetNum = new System.Windows.Forms.NumericUpDown();
            Speed3 = new System.Windows.Forms.NumericUpDown();
            Delayx = new System.Windows.Forms.NumericUpDown();
            SmoothY = new System.Windows.Forms.NumericUpDown();
            SmoothX = new System.Windows.Forms.NumericUpDown();
            AimkeyBtt = new System.Windows.Forms.Button();
            rcs = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(FovXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(FovYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(offsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Speed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Delayx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SmoothY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SmoothX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(rcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireRateNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Redinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeninput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blueinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pingx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bhopinput)).BeginInit();
            this.SuspendLayout();
            // 
            // AimbotBtt
            // 
            AimbotBtt.AutoCheck = false;
            AimbotBtt.AutoSize = true;
            AimbotBtt.Cursor = System.Windows.Forms.Cursors.No;
            AimbotBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AimbotBtt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            AimbotBtt.Location = new System.Drawing.Point(15, 777);
            AimbotBtt.Margin = new System.Windows.Forms.Padding(2);
            AimbotBtt.Name = "AimbotBtt";
            AimbotBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            AimbotBtt.Size = new System.Drawing.Size(55, 17);
            AimbotBtt.TabIndex = 0;
            AimbotBtt.TabStop = false;
            AimbotBtt.Text = "Aimbot";
            this.toolTip1.SetToolTip(AimbotBtt, "(DISABLED FOR NOW)\r\n\r\nThis feature aims automatically at your enemy");
            AimbotBtt.UseVisualStyleBackColor = true;
            AimbotBtt.CheckedChanged += new System.EventHandler(this.IsAimbot_changed);
            // 
            // Speed
            // 
            Speed.BackColor = System.Drawing.SystemColors.ControlDark;
            Speed.Cursor = System.Windows.Forms.Cursors.No;
            Speed.DecimalPlaces = 2;
            Speed.Enabled = false;
            Speed.ForeColor = System.Drawing.SystemColors.ControlLight;
            Speed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Speed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            Speed.InterceptArrowKeys = false;
            Speed.Location = new System.Drawing.Point(15, 869);
            Speed.Margin = new System.Windows.Forms.Padding(2);
            Speed.Name = "Speed";
            Speed.ReadOnly = true;
            Speed.Size = new System.Drawing.Size(90, 20);
            Speed.TabIndex = 3;
            Speed.TabStop = false;
            this.toolTip1.SetToolTip(Speed, "Change the Speed of your Aimbot.\r\n\r\nLower Values are more legit.");
            Speed.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            Speed.ValueChanged += new System.EventHandler(this.Speed_changed);
            // 
            // FovXNum
            // 
            FovXNum.BackColor = System.Drawing.SystemColors.ControlDark;
            FovXNum.Cursor = System.Windows.Forms.Cursors.No;
            FovXNum.Enabled = false;
            FovXNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            FovXNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            FovXNum.InterceptArrowKeys = false;
            FovXNum.Location = new System.Drawing.Point(15, 893);
            FovXNum.Margin = new System.Windows.Forms.Padding(2);
            FovXNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            FovXNum.Name = "FovXNum";
            FovXNum.ReadOnly = true;
            FovXNum.Size = new System.Drawing.Size(90, 20);
            FovXNum.TabIndex = 5;
            FovXNum.TabStop = false;
            this.toolTip1.SetToolTip(FovXNum, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
            FovXNum.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            FovXNum.ValueChanged += new System.EventHandler(this.FovX_changed);
            // 
            // FovYNum
            // 
            FovYNum.BackColor = System.Drawing.SystemColors.ControlDark;
            FovYNum.Cursor = System.Windows.Forms.Cursors.No;
            FovYNum.Enabled = false;
            FovYNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            FovYNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            FovYNum.InterceptArrowKeys = false;
            FovYNum.Location = new System.Drawing.Point(15, 917);
            FovYNum.Margin = new System.Windows.Forms.Padding(2);
            FovYNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            FovYNum.Name = "FovYNum";
            FovYNum.ReadOnly = true;
            FovYNum.Size = new System.Drawing.Size(90, 20);
            FovYNum.TabIndex = 7;
            FovYNum.TabStop = false;
            this.toolTip1.SetToolTip(FovYNum, "Your Y Fov for Up and Down.\r\n\r\nHigher Value will increase the Fov.\r\n");
            FovYNum.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            FovYNum.ValueChanged += new System.EventHandler(this.FovY_changed);
            // 
            // offsetNum
            // 
            offsetNum.BackColor = System.Drawing.SystemColors.ControlDark;
            offsetNum.Cursor = System.Windows.Forms.Cursors.No;
            offsetNum.Enabled = false;
            offsetNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            offsetNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            offsetNum.InterceptArrowKeys = false;
            offsetNum.Location = new System.Drawing.Point(15, 941);
            offsetNum.Margin = new System.Windows.Forms.Padding(2);
            offsetNum.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            offsetNum.Name = "offsetNum";
            offsetNum.ReadOnly = true;
            offsetNum.Size = new System.Drawing.Size(90, 20);
            offsetNum.TabIndex = 16;
            offsetNum.TabStop = false;
            this.toolTip1.SetToolTip(offsetNum, "Will change the Aimspot.\r\n\r\n- Lower Value (Aims lower at your Body)\r\n- High Value" +
        " (Aims higher at your Head)");
            offsetNum.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            offsetNum.ValueChanged += new System.EventHandler(this.OffsetY_changed);
            // 
            // RecoilBtt
            // 
            this.RecoilBtt.AutoCheck = false;
            this.RecoilBtt.AutoSize = true;
            this.RecoilBtt.Cursor = System.Windows.Forms.Cursors.No;
            this.RecoilBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecoilBtt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RecoilBtt.Location = new System.Drawing.Point(15, 798);
            this.RecoilBtt.Margin = new System.Windows.Forms.Padding(2);
            this.RecoilBtt.Name = "RecoilBtt";
            this.RecoilBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecoilBtt.Size = new System.Drawing.Size(67, 17);
            this.RecoilBtt.TabIndex = 47;
            this.RecoilBtt.TabStop = false;
            this.RecoilBtt.Text = "NoRecoil";
            this.toolTip1.SetToolTip(this.RecoilBtt, "(DISABLED FOR NOW)\r\n\r\nThis feature will countermeasures against the recoil");
            this.RecoilBtt.UseVisualStyleBackColor = true;
            this.RecoilBtt.CheckedChanged += new System.EventHandler(this.Recoilcheckbox_CheckedChanged_1);
            // 
            // Speed3
            // 
            Speed3.BackColor = System.Drawing.SystemColors.ControlDark;
            Speed3.Cursor = System.Windows.Forms.Cursors.No;
            Speed3.DecimalPlaces = 2;
            Speed3.Enabled = false;
            Speed3.ForeColor = System.Drawing.SystemColors.ControlLight;
            Speed3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Speed3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            Speed3.InterceptArrowKeys = false;
            Speed3.Location = new System.Drawing.Point(15, 1000);
            Speed3.Margin = new System.Windows.Forms.Padding(2);
            Speed3.Name = "Speed3";
            Speed3.ReadOnly = true;
            Speed3.Size = new System.Drawing.Size(90, 20);
            Speed3.TabIndex = 55;
            Speed3.TabStop = false;
            this.toolTip1.SetToolTip(Speed3, "Changes the Speed of your Aimbot as soon as you reach your Enemy with the Crossha" +
        "ir or the Smooth Aim Pixels.\r\n\r\nLower Values are more legit.\r\n");
            Speed3.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            Speed3.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged_1);
            // 
            // Delayx
            // 
            Delayx.BackColor = System.Drawing.SystemColors.ControlDark;
            Delayx.Cursor = System.Windows.Forms.Cursors.No;
            Delayx.Enabled = false;
            Delayx.ForeColor = System.Drawing.SystemColors.ControlLight;
            Delayx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Delayx.InterceptArrowKeys = false;
            Delayx.Location = new System.Drawing.Point(15, 1024);
            Delayx.Margin = new System.Windows.Forms.Padding(2);
            Delayx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            Delayx.Name = "Delayx";
            Delayx.ReadOnly = true;
            Delayx.Size = new System.Drawing.Size(90, 20);
            Delayx.TabIndex = 59;
            Delayx.TabStop = false;
            this.toolTip1.SetToolTip(Delayx, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
            Delayx.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            Delayx.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged_2);
            // 
            // SmoothY
            // 
            SmoothY.BackColor = System.Drawing.SystemColors.ControlDark;
            SmoothY.Cursor = System.Windows.Forms.Cursors.No;
            SmoothY.Enabled = false;
            SmoothY.ForeColor = System.Drawing.SystemColors.ControlLight;
            SmoothY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            SmoothY.InterceptArrowKeys = false;
            SmoothY.Location = new System.Drawing.Point(15, 1072);
            SmoothY.Margin = new System.Windows.Forms.Padding(2);
            SmoothY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            SmoothY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            SmoothY.Name = "SmoothY";
            SmoothY.ReadOnly = true;
            SmoothY.Size = new System.Drawing.Size(90, 20);
            SmoothY.TabIndex = 64;
            SmoothY.TabStop = false;
            this.toolTip1.SetToolTip(SmoothY, "Pixels Y around your Enemy");
            SmoothY.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // SmoothX
            // 
            SmoothX.BackColor = System.Drawing.SystemColors.ControlDark;
            SmoothX.Cursor = System.Windows.Forms.Cursors.No;
            SmoothX.Enabled = false;
            SmoothX.ForeColor = System.Drawing.SystemColors.ControlLight;
            SmoothX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            SmoothX.InterceptArrowKeys = false;
            SmoothX.Location = new System.Drawing.Point(15, 1048);
            SmoothX.Margin = new System.Windows.Forms.Padding(2);
            SmoothX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            SmoothX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            SmoothX.Name = "SmoothX";
            SmoothX.ReadOnly = true;
            SmoothX.Size = new System.Drawing.Size(90, 20);
            SmoothX.TabIndex = 62;
            SmoothX.TabStop = false;
            this.toolTip1.SetToolTip(SmoothX, "Pixels X around your Enemy");
            SmoothX.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // AimkeyBtt
            // 
            AimkeyBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            AimkeyBtt.Enabled = false;
            AimkeyBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AimkeyBtt.ForeColor = System.Drawing.SystemColors.ControlDark;
            AimkeyBtt.Location = new System.Drawing.Point(15, 1131);
            AimkeyBtt.Margin = new System.Windows.Forms.Padding(2);
            AimkeyBtt.Name = "AimkeyBtt";
            AimkeyBtt.Size = new System.Drawing.Size(82, 25);
            AimkeyBtt.TabIndex = 14;
            AimkeyBtt.Text = "Keybind";
            this.toolTip1.SetToolTip(AimkeyBtt, "Keybinding for Triggerbot and Aimbot");
            AimkeyBtt.UseVisualStyleBackColor = false;
            AimkeyBtt.Click += new System.EventHandler(this.AimKeyDrop);
            // 
            // rcs
            // 
            rcs.BackColor = System.Drawing.SystemColors.ControlDark;
            rcs.Enabled = false;
            rcs.ForeColor = System.Drawing.SystemColors.ControlLight;
            rcs.Location = new System.Drawing.Point(15, 845);
            rcs.Margin = new System.Windows.Forms.Padding(2);
            rcs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            rcs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            rcs.Name = "rcs";
            rcs.Size = new System.Drawing.Size(90, 20);
            rcs.TabIndex = 57;
            this.toolTip1.SetToolTip(rcs, "change the strength of the norecoil.");
            // 
            // TriggerbotBtt
            // 
            this.TriggerbotBtt.AutoSize = true;
            this.TriggerbotBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriggerbotBtt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TriggerbotBtt.Location = new System.Drawing.Point(15, 31);
            this.TriggerbotBtt.Margin = new System.Windows.Forms.Padding(2);
            this.TriggerbotBtt.Name = "TriggerbotBtt";
            this.TriggerbotBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TriggerbotBtt.Size = new System.Drawing.Size(71, 17);
            this.TriggerbotBtt.TabIndex = 1;
            this.TriggerbotBtt.Text = "Triggerbot";
            this.toolTip1.SetToolTip(this.TriggerbotBtt, "Enable or Disable the Triggerbot\r\n\r\n- This feature will automatically shoot at yo" +
        "ur Enemy as soon as you aim at him.");
            this.TriggerbotBtt.UseVisualStyleBackColor = true;
            this.TriggerbotBtt.CheckedChanged += new System.EventHandler(this.IsTriggerbot_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(109, 871);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "On Aim Smoothing";
            this.toolTip1.SetToolTip(this.label1, "Changes the Speed of your Aimbot while searching / aiming for your target.\r\n\r\nLow" +
        "er Values are more legit.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(109, 895);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aimbot Fov left/right";
            this.toolTip1.SetToolTip(this.label2, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(109, 919);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aimbot Fov up/down";
            this.toolTip1.SetToolTip(this.label3, "Your Y Fov for Up and Down.\r\n\r\nHigher Value will increase the Fov.\r\n");
            // 
            // RedRadio
            // 
            this.RedRadio.AutoSize = true;
            this.RedRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RedRadio.Location = new System.Drawing.Point(15, 197);
            this.RedRadio.Margin = new System.Windows.Forms.Padding(0);
            this.RedRadio.Name = "RedRadio";
            this.RedRadio.Size = new System.Drawing.Size(44, 17);
            this.RedRadio.TabIndex = 9;
            this.RedRadio.TabStop = true;
            this.RedRadio.Text = "Red";
            this.toolTip1.SetToolTip(this.RedRadio, "Enemy outline Color. Switch to the Color which your enemy has.");
            this.RedRadio.UseVisualStyleBackColor = true;
            this.RedRadio.CheckedChanged += new System.EventHandler(this.Red_changed);
            // 
            // PurpleRadio
            // 
            this.PurpleRadio.AutoSize = true;
            this.PurpleRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurpleRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PurpleRadio.Location = new System.Drawing.Point(59, 197);
            this.PurpleRadio.Margin = new System.Windows.Forms.Padding(0);
            this.PurpleRadio.Name = "PurpleRadio";
            this.PurpleRadio.Size = new System.Drawing.Size(54, 17);
            this.PurpleRadio.TabIndex = 10;
            this.PurpleRadio.TabStop = true;
            this.PurpleRadio.Text = "Purple";
            this.toolTip1.SetToolTip(this.PurpleRadio, "Enemy outline Color. Switch to the Color which your enemy has.");
            this.PurpleRadio.UseVisualStyleBackColor = true;
            this.PurpleRadio.CheckedChanged += new System.EventHandler(this.Purple_changed);
            // 
            // ChangeMonitorBtt
            // 
            this.ChangeMonitorBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ChangeMonitorBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeMonitorBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChangeMonitorBtt.Location = new System.Drawing.Point(15, 656);
            this.ChangeMonitorBtt.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeMonitorBtt.Name = "ChangeMonitorBtt";
            this.ChangeMonitorBtt.Size = new System.Drawing.Size(148, 25);
            this.ChangeMonitorBtt.TabIndex = 11;
            this.ChangeMonitorBtt.Text = "Change Screen";
            this.toolTip1.SetToolTip(this.ChangeMonitorBtt, "Change your Monitor");
            this.ChangeMonitorBtt.UseVisualStyleBackColor = false;
            this.ChangeMonitorBtt.Click += new System.EventHandler(this.MonitorChanged);
            // 
            // AimKeyToggle
            // 
            this.AimKeyToggle.AutoSize = true;
            this.AimKeyToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AimKeyToggle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AimKeyToggle.Location = new System.Drawing.Point(15, 632);
            this.AimKeyToggle.Margin = new System.Windows.Forms.Padding(2);
            this.AimKeyToggle.Name = "AimKeyToggle";
            this.AimKeyToggle.Size = new System.Drawing.Size(58, 17);
            this.AimKeyToggle.TabIndex = 12;
            this.AimKeyToggle.Text = "AimKey";
            this.AimKeyToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.AimKeyToggle, "Enables the Aimkey Keybind");
            this.AimKeyToggle.UseVisualStyleBackColor = true;
            this.AimKeyToggle.CheckedChanged += new System.EventHandler(this.AimKeyToggle_CheckedChanged);
            this.AimKeyToggle.Click += new System.EventHandler(this.IsAimKeyChanged);
            // 
            // IsHoldToggle
            // 
            this.IsHoldToggle.AutoSize = true;
            this.IsHoldToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsHoldToggle.ForeColor = System.Drawing.Color.Snow;
            this.IsHoldToggle.Location = new System.Drawing.Point(77, 632);
            this.IsHoldToggle.Margin = new System.Windows.Forms.Padding(2);
            this.IsHoldToggle.Name = "IsHoldToggle";
            this.IsHoldToggle.Size = new System.Drawing.Size(45, 17);
            this.IsHoldToggle.TabIndex = 13;
            this.IsHoldToggle.Text = "Hold";
            this.toolTip1.SetToolTip(this.IsHoldToggle, "Press and Hold the Aimkey for Triggerbot and Aimbot");
            this.IsHoldToggle.UseVisualStyleBackColor = true;
            this.IsHoldToggle.CheckedChanged += new System.EventHandler(this.IsHold_changed);
            // 
            // StartBtt
            // 
            this.StartBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.StartBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartBtt.Location = new System.Drawing.Point(15, 685);
            this.StartBtt.Margin = new System.Windows.Forms.Padding(2);
            this.StartBtt.Name = "StartBtt";
            this.StartBtt.Size = new System.Drawing.Size(148, 25);
            this.StartBtt.TabIndex = 15;
            this.StartBtt.Text = "Start";
            this.StartBtt.UseVisualStyleBackColor = false;
            this.StartBtt.Click += new System.EventHandler(this.Start_click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(109, 943);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Aimoffset";
            this.toolTip1.SetToolTip(this.label4, "Will change the Aimspot.\r\n\r\n- Lower Value (Aims lower at your Body)\r\n- High Value" +
        " (Aims higher at your Head)");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(111, 406);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Firerate";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // FireRateNum
            // 
            this.FireRateNum.Location = new System.Drawing.Point(15, 404);
            this.FireRateNum.Margin = new System.Windows.Forms.Padding(2);
            this.FireRateNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FireRateNum.Name = "FireRateNum";
            this.FireRateNum.Size = new System.Drawing.Size(90, 20);
            this.FireRateNum.TabIndex = 18;
            this.toolTip1.SetToolTip(this.FireRateNum, resources.GetString("FireRateNum.ToolTip"));
            this.FireRateNum.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.FireRateNum.ValueChanged += new System.EventHandler(this.FireRate_changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Features:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Outlines:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(12, 1111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Keybinds Aimbot:";
            // 
            // Customcolor
            // 
            this.Customcolor.AutoSize = true;
            this.Customcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customcolor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Customcolor.Location = new System.Drawing.Point(117, 196);
            this.Customcolor.Margin = new System.Windows.Forms.Padding(0);
            this.Customcolor.Name = "Customcolor";
            this.Customcolor.Size = new System.Drawing.Size(60, 18);
            this.Customcolor.TabIndex = 25;
            this.Customcolor.TabStop = true;
            this.Customcolor.Text = "Custom";
            this.toolTip1.SetToolTip(this.Customcolor, "Custom RGB Color if it doesn\'t detect the predefined one.");
            this.Customcolor.UseCompatibleTextRendering = true;
            this.Customcolor.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(109, 224);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Red";
            this.toolTip1.SetToolTip(this.label11, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // Redinput
            // 
            this.Redinput.Location = new System.Drawing.Point(15, 222);
            this.Redinput.Margin = new System.Windows.Forms.Padding(2);
            this.Redinput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Redinput.Name = "Redinput";
            this.Redinput.Size = new System.Drawing.Size(90, 20);
            this.Redinput.TabIndex = 28;
            this.toolTip1.SetToolTip(this.Redinput, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // Greeninput
            // 
            this.Greeninput.Location = new System.Drawing.Point(15, 244);
            this.Greeninput.Margin = new System.Windows.Forms.Padding(2);
            this.Greeninput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Greeninput.Name = "Greeninput";
            this.Greeninput.Size = new System.Drawing.Size(90, 20);
            this.Greeninput.TabIndex = 29;
            this.toolTip1.SetToolTip(this.Greeninput, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // Blueinput
            // 
            this.Blueinput.Location = new System.Drawing.Point(15, 266);
            this.Blueinput.Margin = new System.Windows.Forms.Padding(2);
            this.Blueinput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Blueinput.Name = "Blueinput";
            this.Blueinput.Size = new System.Drawing.Size(90, 20);
            this.Blueinput.TabIndex = 30;
            this.toolTip1.SetToolTip(this.Blueinput, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(109, 246);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Green";
            this.toolTip1.SetToolTip(this.label12, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(109, 268);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Blue";
            this.toolTip1.SetToolTip(this.label13, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(12, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Triggerbot Settings";
            // 
            // Pingx
            // 
            this.Pingx.Location = new System.Drawing.Point(15, 356);
            this.Pingx.Margin = new System.Windows.Forms.Padding(2);
            this.Pingx.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Pingx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pingx.Name = "Pingx";
            this.Pingx.Size = new System.Drawing.Size(90, 20);
            this.Pingx.TabIndex = 34;
            this.toolTip1.SetToolTip(this.Pingx, resources.GetString("Pingx.ToolTip"));
            this.Pingx.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Pingx.ValueChanged += new System.EventHandler(this.PixelX_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(109, 358);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Pixel X";
            this.toolTip1.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(109, 382);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Pixel Y";
            this.toolTip1.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
            // 
            // PixelY
            // 
            this.PixelY.Location = new System.Drawing.Point(15, 380);
            this.PixelY.Margin = new System.Windows.Forms.Padding(2);
            this.PixelY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PixelY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelY.Name = "PixelY";
            this.PixelY.Size = new System.Drawing.Size(90, 20);
            this.PixelY.TabIndex = 36;
            this.toolTip1.SetToolTip(this.PixelY, resources.GetString("PixelY.ToolTip"));
            this.PixelY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PixelY.ValueChanged += new System.EventHandler(this.PixelY_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label17.Location = new System.Drawing.Point(12, 455);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 20);
            this.label17.TabIndex = 38;
            this.label17.Text = "Custom Screenresolution:";
            // 
            // ScreenX2
            // 
            this.ScreenX2.Location = new System.Drawing.Point(15, 496);
            this.ScreenX2.Margin = new System.Windows.Forms.Padding(2);
            this.ScreenX2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ScreenX2.Name = "ScreenX2";
            this.ScreenX2.Size = new System.Drawing.Size(90, 20);
            this.ScreenX2.TabIndex = 39;
            this.ScreenX2.Tag = "";
            this.toolTip1.SetToolTip(this.ScreenX2, "Screen Resoltuion X");
            this.ScreenX2.ValueChanged += new System.EventHandler(this.ScreenX2_ValueChanged);
            // 
            // ScreenY2
            // 
            this.ScreenY2.Location = new System.Drawing.Point(15, 520);
            this.ScreenY2.Margin = new System.Windows.Forms.Padding(2);
            this.ScreenY2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ScreenY2.Name = "ScreenY2";
            this.ScreenY2.Size = new System.Drawing.Size(90, 20);
            this.ScreenY2.TabIndex = 40;
            this.toolTip1.SetToolTip(this.ScreenY2, "Screen Resoltuion Y");
            this.ScreenY2.ValueChanged += new System.EventHandler(this.ScreenY2_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(114, 498);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Pixel X";
            // 
            // ScreenY
            // 
            this.ScreenY.AutoSize = true;
            this.ScreenY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScreenY.Location = new System.Drawing.Point(114, 522);
            this.ScreenY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScreenY.Name = "ScreenY";
            this.ScreenY.Size = new System.Drawing.Size(39, 13);
            this.ScreenY.TabIndex = 42;
            this.ScreenY.Text = "Pixel Y";
            // 
            // CustomScreen
            // 
            this.CustomScreen.AutoSize = true;
            this.CustomScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomScreen.Location = new System.Drawing.Point(15, 475);
            this.CustomScreen.Margin = new System.Windows.Forms.Padding(2);
            this.CustomScreen.Name = "CustomScreen";
            this.CustomScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomScreen.Size = new System.Drawing.Size(111, 17);
            this.CustomScreen.TabIndex = 44;
            this.CustomScreen.Text = "Custom Resolution";
            this.toolTip1.SetToolTip(this.CustomScreen, "You don\'t need this. Only if it doesn\'t detect your Screen Resolution.");
            this.CustomScreen.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(15, 335);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Prefire";
            this.toolTip1.SetToolTip(this.checkBox1, resources.GetString("checkBox1.ToolTip"));
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Bhopbox
            // 
            this.Bhopbox.AllowDrop = true;
            this.Bhopbox.AutoSize = true;
            this.Bhopbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bhopbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bhopbox.Location = new System.Drawing.Point(15, 52);
            this.Bhopbox.Margin = new System.Windows.Forms.Padding(2);
            this.Bhopbox.Name = "Bhopbox";
            this.Bhopbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bhopbox.Size = new System.Drawing.Size(48, 17);
            this.Bhopbox.TabIndex = 48;
            this.Bhopbox.Text = "Bhop";
            this.toolTip1.SetToolTip(this.Bhopbox, "Enable or Disable the Triggerbot\r\n\r\n- This feature will let you jump to infinity");
            this.Bhopbox.UseMnemonic = false;
            this.Bhopbox.UseVisualStyleBackColor = true;
            this.Bhopbox.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Bhopinput
            // 
            this.Bhopinput.Location = new System.Drawing.Point(15, 128);
            this.Bhopinput.Margin = new System.Windows.Forms.Padding(2);
            this.Bhopinput.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.Bhopinput.Name = "Bhopinput";
            this.Bhopinput.Size = new System.Drawing.Size(53, 20);
            this.Bhopinput.TabIndex = 49;
            this.toolTip1.SetToolTip(this.Bhopinput, "Keybind for Bhop.\r\n\r\n(Spacebar does not work)\r\n\r\nKeybinds here: http://cherrytree" +
        ".at/misc/vk.htm");
            this.Bhopinput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Bhopinput.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // TriggerKeyBtt
            // 
            this.TriggerKeyBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TriggerKeyBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriggerKeyBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TriggerKeyBtt.Location = new System.Drawing.Point(15, 588);
            this.TriggerKeyBtt.Margin = new System.Windows.Forms.Padding(2);
            this.TriggerKeyBtt.Name = "TriggerKeyBtt";
            this.TriggerKeyBtt.Size = new System.Drawing.Size(82, 25);
            this.TriggerKeyBtt.TabIndex = 52;
            this.TriggerKeyBtt.Text = "Keybind";
            this.toolTip1.SetToolTip(this.TriggerKeyBtt, "Keybinding for Triggerbot and Aimbot");
            this.TriggerKeyBtt.UseVisualStyleBackColor = false;
            this.TriggerKeyBtt.Click += new System.EventHandler(this.TriggerKeyDrop);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Bhop Keycode:";
            this.toolTip1.SetToolTip(this.label10, "Keybind for Bhop.\r\n\r\n(Spacebar does not work)\r\n\r\nKeybinds here: http://cherrytree" +
        ".at/misc/vk.htm");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.No;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label20.Location = new System.Drawing.Point(109, 1002);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "On Enemy Smoothing";
            this.toolTip1.SetToolTip(this.label20, "Changes the Speed of your Aimbot as soon as you reach your Enemy with the Crossha" +
        "ir or the Smooth Aim Pixels.\r\nThis is like a second Fov on Lockon.\r\n\r\nLower Valu" +
        "es are more legit.");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.No;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label21.Location = new System.Drawing.Point(109, 847);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "RCS Amount";
            this.toolTip1.SetToolTip(this.label21, "Firerate of your Weapon in Triggerbotmode");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.No;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label22.Location = new System.Drawing.Point(109, 1026);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "On Enemy Delay";
            this.toolTip1.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Cursor = System.Windows.Forms.Cursors.No;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label24.Location = new System.Drawing.Point(109, 1074);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 13);
            this.label24.TabIndex = 65;
            this.label24.Text = "Smooth Aim Pixel Y";
            this.toolTip1.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Cursor = System.Windows.Forms.Cursors.No;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label25.Location = new System.Drawing.Point(109, 1050);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 13);
            this.label25.TabIndex = 63;
            this.label25.Text = "Smooth Aim Pixel X";
            this.toolTip1.SetToolTip(this.label25, resources.GetString("label25.ToolTip"));
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.Location = new System.Drawing.Point(12, 568);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(173, 20);
            this.label19.TabIndex = 53;
            this.label19.Text = "Keybinds Triggerbot:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip2_Opening);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label23.Location = new System.Drawing.Point(12, 980);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 20);
            this.label23.TabIndex = 61;
            this.label23.Text = "Smooth Aimbot:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label26.Location = new System.Drawing.Point(12, 757);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(161, 20);
            this.label26.TabIndex = 66;
            this.label26.Text = "Disabled Features:";
            // 
            // Ping
            // 
            this.Ping.AllowDrop = true;
            this.Ping.AutoSize = true;
            this.Ping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ping.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ping.Location = new System.Drawing.Point(15, 94);
            this.Ping.Margin = new System.Windows.Forms.Padding(2);
            this.Ping.Name = "Ping";
            this.Ping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ping.Size = new System.Drawing.Size(94, 17);
            this.Ping.TabIndex = 68;
            this.Ping.Text = "Ping on Enemy";
            this.toolTip1.SetToolTip(this.Ping, "This Feature will Ping \"Warning\" if you aim at an Enemy\r\n\r\n- Chane your Keybind f" +
        "or Warning to \"P\"");
            this.Ping.UseMnemonic = false;
            this.Ping.UseVisualStyleBackColor = true;
            this.Ping.CheckedChanged += new System.EventHandler(this.Ping_CheckedChanged);
            // 
            // Calloutchat
            // 
            this.Calloutchat.AutoSize = true;
            this.Calloutchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calloutchat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calloutchat.Location = new System.Drawing.Point(15, 73);
            this.Calloutchat.Margin = new System.Windows.Forms.Padding(2);
            this.Calloutchat.Name = "Calloutchat";
            this.Calloutchat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calloutchat.Size = new System.Drawing.Size(76, 17);
            this.Calloutchat.TabIndex = 67;
            this.Calloutchat.Text = "Calloutchat";
            this.toolTip1.SetToolTip(this.Calloutchat, "- If you Aim at an Enemy it will write your current Location 3 Seconds later in t" +
        "he Chat.\r\n\r\n(just a fun feature - only works for 2560 x 1440 Resoultion rn)");
            this.Calloutchat.UseVisualStyleBackColor = true;
            this.Calloutchat.CheckedChanged += new System.EventHandler(this.Calloutchat_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(249, 322);
            this.Controls.Add(this.Ping);
            this.Controls.Add(this.Calloutchat);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label24);
            this.Controls.Add(SmoothY);
            this.Controls.Add(this.label25);
            this.Controls.Add(SmoothX);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(Delayx);
            this.Controls.Add(this.label21);
            this.Controls.Add(rcs);
            this.Controls.Add(this.label20);
            this.Controls.Add(Speed3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TriggerKeyBtt);
            this.Controls.Add(this.Bhopinput);
            this.Controls.Add(this.Bhopbox);
            this.Controls.Add(this.RecoilBtt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CustomScreen);
            this.Controls.Add(this.ScreenY);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ScreenY2);
            this.Controls.Add(this.ScreenX2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PixelY);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Pingx);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Blueinput);
            this.Controls.Add(this.Greeninput);
            this.Controls.Add(this.Redinput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Customcolor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FireRateNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(offsetNum);
            this.Controls.Add(this.StartBtt);
            this.Controls.Add(AimkeyBtt);
            this.Controls.Add(this.IsHoldToggle);
            this.Controls.Add(this.AimKeyToggle);
            this.Controls.Add(this.ChangeMonitorBtt);
            this.Controls.Add(this.PurpleRadio);
            this.Controls.Add(this.RedRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(FovYNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(FovXNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(Speed);
            this.Controls.Add(this.TriggerbotBtt);
            this.Controls.Add(AimbotBtt);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "iBaseult - Valorant Cheat";
            this.Load += new System.EventHandler(this.Main_load);
            ((System.ComponentModel.ISupportInitialize)(Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(FovXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(FovYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(offsetNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Speed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Delayx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SmoothY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SmoothX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(rcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireRateNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Redinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeninput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blueinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pingx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bhopinput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.CheckBox TriggerbotBtt;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.RadioButton RedRadio;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.RadioButton PurpleRadio;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button ChangeMonitorBtt;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.CheckBox AimKeyToggle;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.CheckBox IsHoldToggle;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button StartBtt;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.NumericUpDown FireRateNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton Customcolor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Redinput;
        private System.Windows.Forms.NumericUpDown Greeninput;
        private System.Windows.Forms.NumericUpDown Blueinput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Pingx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown PixelY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown ScreenX2;
        private System.Windows.Forms.NumericUpDown ScreenY2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label ScreenY;
        private System.Windows.Forms.CheckBox CustomScreen;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox Bhopbox;
        private System.Windows.Forms.NumericUpDown Bhopinput;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button TriggerKeyBtt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox RecoilBtt;
        private System.Windows.Forms.CheckBox Ping;
        private System.Windows.Forms.CheckBox Calloutchat;
    }
}
