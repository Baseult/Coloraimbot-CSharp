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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AimbotBtt = new System.Windows.Forms.CheckBox();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.FovXNum = new System.Windows.Forms.NumericUpDown();
            this.FovYNum = new System.Windows.Forms.NumericUpDown();
            this.offsetNum = new System.Windows.Forms.NumericUpDown();
            this.Speed3 = new System.Windows.Forms.NumericUpDown();
            this.Delayx = new System.Windows.Forms.NumericUpDown();
            this.SmoothY = new System.Windows.Forms.NumericUpDown();
            this.SmoothX = new System.Windows.Forms.NumericUpDown();
            this.AimkeyBtt = new System.Windows.Forms.Button();
            this.rcs = new System.Windows.Forms.NumericUpDown();
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
            this.Ping = new System.Windows.Forms.CheckBox();
            this.EspBtt = new System.Windows.Forms.CheckBox();
            this.CircleBtt = new System.Windows.Forms.CheckBox();
            this.PixelBtt = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.Bdelay = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.CircleBlue = new System.Windows.Forms.NumericUpDown();
            this.CircleGreen = new System.Windows.Forms.NumericUpDown();
            this.CircleRed = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.PingDelay = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.ColB = new System.Windows.Forms.NumericUpDown();
            this.ColG = new System.Windows.Forms.NumericUpDown();
            this.ColR = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.ColY = new System.Windows.Forms.NumericUpDown();
            this.ColX = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.PixY = new System.Windows.Forms.NumericUpDown();
            this.PixX = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.PixBlue = new System.Windows.Forms.NumericUpDown();
            this.PixGreen = new System.Windows.Forms.NumericUpDown();
            this.PixRed = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.CircleWidth = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.PixWidth = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.Label();
            this.ColWidth = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.PingBind = new System.Windows.Forms.TextBox();
            this.TargetCheck = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label50 = new System.Windows.Forms.Label();
            this.RageBtt = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delayx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireRateNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Redinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeninput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blueinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pingx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bhopinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bdelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // AimbotBtt
            // 
            this.AimbotBtt.AutoSize = true;
            this.AimbotBtt.BackColor = System.Drawing.Color.Transparent;
            this.AimbotBtt.Cursor = System.Windows.Forms.Cursors.Default;
            this.AimbotBtt.ForeColor = System.Drawing.Color.White;
            this.AimbotBtt.Location = new System.Drawing.Point(23, 32);
            this.AimbotBtt.Margin = new System.Windows.Forms.Padding(2);
            this.AimbotBtt.Name = "AimbotBtt";
            this.AimbotBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AimbotBtt.Size = new System.Drawing.Size(58, 17);
            this.AimbotBtt.TabIndex = 0;
            this.AimbotBtt.TabStop = false;
            this.AimbotBtt.Text = "Aimbot";
            this.toolTip1.SetToolTip(this.AimbotBtt, "This feature aims automatically at your enemy");
            this.AimbotBtt.UseVisualStyleBackColor = false;
            this.AimbotBtt.CheckedChanged += new System.EventHandler(this.IsAimbot_changed);
            // 
            // Speed
            // 
            this.Speed.BackColor = System.Drawing.SystemColors.Window;
            this.Speed.Cursor = System.Windows.Forms.Cursors.Default;
            this.Speed.DecimalPlaces = 2;
            this.Speed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Speed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Speed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Speed.InterceptArrowKeys = false;
            this.Speed.Location = new System.Drawing.Point(21, 276);
            this.Speed.Margin = new System.Windows.Forms.Padding(2);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(90, 20);
            this.Speed.TabIndex = 3;
            this.Speed.TabStop = false;
            this.toolTip1.SetToolTip(this.Speed, "Change the Speed of your Aimbot while it is searching and aiming for your target." +
        "\r\n\r\nLower Values are more legit.");
            this.Speed.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.Speed.ValueChanged += new System.EventHandler(this.Speed_changed);
            // 
            // FovXNum
            // 
            this.FovXNum.BackColor = System.Drawing.SystemColors.Window;
            this.FovXNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.FovXNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FovXNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FovXNum.InterceptArrowKeys = false;
            this.FovXNum.Location = new System.Drawing.Point(21, 300);
            this.FovXNum.Margin = new System.Windows.Forms.Padding(2);
            this.FovXNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FovXNum.Name = "FovXNum";
            this.FovXNum.Size = new System.Drawing.Size(90, 20);
            this.FovXNum.TabIndex = 5;
            this.FovXNum.TabStop = false;
            this.toolTip1.SetToolTip(this.FovXNum, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
            this.FovXNum.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.FovXNum.ValueChanged += new System.EventHandler(this.FovX_changed);
            // 
            // FovYNum
            // 
            this.FovYNum.BackColor = System.Drawing.SystemColors.Window;
            this.FovYNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.FovYNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FovYNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FovYNum.InterceptArrowKeys = false;
            this.FovYNum.Location = new System.Drawing.Point(21, 324);
            this.FovYNum.Margin = new System.Windows.Forms.Padding(2);
            this.FovYNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FovYNum.Name = "FovYNum";
            this.FovYNum.Size = new System.Drawing.Size(90, 20);
            this.FovYNum.TabIndex = 7;
            this.FovYNum.TabStop = false;
            this.toolTip1.SetToolTip(this.FovYNum, "Your Y Fov for Up and Down.\r\n\r\nHigher Value will increase the Fov.\r\n");
            this.FovYNum.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.FovYNum.ValueChanged += new System.EventHandler(this.FovY_changed);
            // 
            // offsetNum
            // 
            this.offsetNum.BackColor = System.Drawing.SystemColors.Window;
            this.offsetNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.offsetNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.offsetNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.offsetNum.InterceptArrowKeys = false;
            this.offsetNum.Location = new System.Drawing.Point(21, 348);
            this.offsetNum.Margin = new System.Windows.Forms.Padding(2);
            this.offsetNum.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.offsetNum.Name = "offsetNum";
            this.offsetNum.Size = new System.Drawing.Size(90, 20);
            this.offsetNum.TabIndex = 16;
            this.offsetNum.TabStop = false;
            this.toolTip1.SetToolTip(this.offsetNum, "Will change the Aimspot.\r\n\r\n- Lower Value (Aims lower at your Body)\r\n- High Value" +
        " (Aims higher at your Head)");
            this.offsetNum.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.offsetNum.ValueChanged += new System.EventHandler(this.OffsetY_changed);
            // 
            // Speed3
            // 
            this.Speed3.BackColor = System.Drawing.SystemColors.Window;
            this.Speed3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Speed3.DecimalPlaces = 2;
            this.Speed3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Speed3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Speed3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Speed3.Location = new System.Drawing.Point(21, 453);
            this.Speed3.Margin = new System.Windows.Forms.Padding(2);
            this.Speed3.Name = "Speed3";
            this.Speed3.Size = new System.Drawing.Size(90, 20);
            this.Speed3.TabIndex = 55;
            this.toolTip1.SetToolTip(this.Speed3, "Changes the Speed of your Aimbot as soon as you reach your Enemy with the Crossha" +
        "ir or the Smooth Aim Pixels.\r\nThis is like a second Fov on Lockon.\r\n\r\nLower Valu" +
        "es are more legit.\r\n");
            this.Speed3.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Speed3.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged_1);
            // 
            // Delayx
            // 
            this.Delayx.BackColor = System.Drawing.SystemColors.Window;
            this.Delayx.Cursor = System.Windows.Forms.Cursors.Default;
            this.Delayx.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Delayx.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Delayx.Location = new System.Drawing.Point(21, 477);
            this.Delayx.Margin = new System.Windows.Forms.Padding(2);
            this.Delayx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Delayx.Name = "Delayx";
            this.Delayx.Size = new System.Drawing.Size(90, 20);
            this.Delayx.TabIndex = 59;
            this.toolTip1.SetToolTip(this.Delayx, resources.GetString("Delayx.ToolTip"));
            this.Delayx.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged_2);
            // 
            // SmoothY
            // 
            this.SmoothY.BackColor = System.Drawing.SystemColors.Window;
            this.SmoothY.Cursor = System.Windows.Forms.Cursors.Default;
            this.SmoothY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SmoothY.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SmoothY.Location = new System.Drawing.Point(21, 525);
            this.SmoothY.Margin = new System.Windows.Forms.Padding(2);
            this.SmoothY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.SmoothY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SmoothY.Name = "SmoothY";
            this.SmoothY.Size = new System.Drawing.Size(90, 20);
            this.SmoothY.TabIndex = 64;
            this.toolTip1.SetToolTip(this.SmoothY, resources.GetString("SmoothY.ToolTip"));
            this.SmoothY.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // SmoothX
            // 
            this.SmoothX.BackColor = System.Drawing.SystemColors.Window;
            this.SmoothX.Cursor = System.Windows.Forms.Cursors.Default;
            this.SmoothX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SmoothX.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SmoothX.Location = new System.Drawing.Point(21, 501);
            this.SmoothX.Margin = new System.Windows.Forms.Padding(2);
            this.SmoothX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.SmoothX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SmoothX.Name = "SmoothX";
            this.SmoothX.Size = new System.Drawing.Size(90, 20);
            this.SmoothX.TabIndex = 62;
            this.toolTip1.SetToolTip(this.SmoothX, resources.GetString("SmoothX.ToolTip"));
            this.SmoothX.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // AimkeyBtt
            // 
            this.AimkeyBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AimkeyBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AimkeyBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AimkeyBtt.Location = new System.Drawing.Point(22, 1736);
            this.AimkeyBtt.Margin = new System.Windows.Forms.Padding(2);
            this.AimkeyBtt.Name = "AimkeyBtt";
            this.AimkeyBtt.Size = new System.Drawing.Size(82, 25);
            this.AimkeyBtt.TabIndex = 14;
            this.AimkeyBtt.Text = "Keybind";
            this.toolTip1.SetToolTip(this.AimkeyBtt, "Keybinding for Aimbot");
            this.AimkeyBtt.UseVisualStyleBackColor = false;
            this.AimkeyBtt.Click += new System.EventHandler(this.AimKeyDrop);
            // 
            // rcs
            // 
            this.rcs.BackColor = System.Drawing.SystemColors.Window;
            this.rcs.Cursor = System.Windows.Forms.Cursors.Default;
            this.rcs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rcs.Location = new System.Drawing.Point(21, 858);
            this.rcs.Margin = new System.Windows.Forms.Padding(2);
            this.rcs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rcs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.rcs.Name = "rcs";
            this.rcs.Size = new System.Drawing.Size(90, 20);
            this.rcs.TabIndex = 57;
            this.toolTip1.SetToolTip(this.rcs, "change the strength of the norecoil.\r\n\r\n+ 1 = 1 pixel stronger recoilreduction\r\n-" +
        "1 = 1 pixel less recoilreduction");
            // 
            // RecoilBtt
            // 
            this.RecoilBtt.AutoSize = true;
            this.RecoilBtt.BackColor = System.Drawing.Color.Transparent;
            this.RecoilBtt.Cursor = System.Windows.Forms.Cursors.Default;
            this.RecoilBtt.ForeColor = System.Drawing.Color.White;
            this.RecoilBtt.Location = new System.Drawing.Point(23, 74);
            this.RecoilBtt.Margin = new System.Windows.Forms.Padding(2);
            this.RecoilBtt.Name = "RecoilBtt";
            this.RecoilBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecoilBtt.Size = new System.Drawing.Size(70, 17);
            this.RecoilBtt.TabIndex = 47;
            this.RecoilBtt.TabStop = false;
            this.RecoilBtt.Text = "NoRecoil";
            this.toolTip1.SetToolTip(this.RecoilBtt, "This feature will countermeasures against the recoil");
            this.RecoilBtt.UseVisualStyleBackColor = false;
            this.RecoilBtt.CheckedChanged += new System.EventHandler(this.Recoilcheckbox_CheckedChanged_1);
            // 
            // TriggerbotBtt
            // 
            this.TriggerbotBtt.AutoSize = true;
            this.TriggerbotBtt.BackColor = System.Drawing.Color.Transparent;
            this.TriggerbotBtt.Cursor = System.Windows.Forms.Cursors.Default;
            this.TriggerbotBtt.ForeColor = System.Drawing.Color.White;
            this.TriggerbotBtt.Location = new System.Drawing.Point(23, 53);
            this.TriggerbotBtt.Margin = new System.Windows.Forms.Padding(2);
            this.TriggerbotBtt.Name = "TriggerbotBtt";
            this.TriggerbotBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TriggerbotBtt.Size = new System.Drawing.Size(74, 17);
            this.TriggerbotBtt.TabIndex = 1;
            this.TriggerbotBtt.Text = "Triggerbot";
            this.toolTip1.SetToolTip(this.TriggerbotBtt, "This feature will automatically shoot at your Enemy as soon as you aim at him.");
            this.TriggerbotBtt.UseVisualStyleBackColor = false;
            this.TriggerbotBtt.CheckedChanged += new System.EventHandler(this.IsTriggerbot_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(121, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Humanizer";
            this.toolTip1.SetToolTip(this.label1, "Change the Speed of your Aimbot while it is searching and aiming for your target." +
        "\r\n\r\nLower Values are more legit.\r\n");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(121, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aimbot Fov X";
            this.toolTip1.SetToolTip(this.label2, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(121, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aimbot Fov Y";
            this.toolTip1.SetToolTip(this.label3, "Your Y Fov for Up and Down.\r\n\r\nHigher Value will increase the Fov.\r\n");
            // 
            // RedRadio
            // 
            this.RedRadio.AutoSize = true;
            this.RedRadio.BackColor = System.Drawing.Color.Transparent;
            this.RedRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RedRadio.Location = new System.Drawing.Point(22, 597);
            this.RedRadio.Margin = new System.Windows.Forms.Padding(0);
            this.RedRadio.Name = "RedRadio";
            this.RedRadio.Size = new System.Drawing.Size(45, 17);
            this.RedRadio.TabIndex = 9;
            this.RedRadio.TabStop = true;
            this.RedRadio.Text = "Red";
            this.toolTip1.SetToolTip(this.RedRadio, "Enemy outline Color. Switch to the Color which your enemy has.");
            this.RedRadio.UseVisualStyleBackColor = false;
            this.RedRadio.CheckedChanged += new System.EventHandler(this.Red_changed);
            // 
            // PurpleRadio
            // 
            this.PurpleRadio.AutoSize = true;
            this.PurpleRadio.BackColor = System.Drawing.Color.Transparent;
            this.PurpleRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PurpleRadio.Location = new System.Drawing.Point(66, 597);
            this.PurpleRadio.Margin = new System.Windows.Forms.Padding(0);
            this.PurpleRadio.Name = "PurpleRadio";
            this.PurpleRadio.Size = new System.Drawing.Size(55, 17);
            this.PurpleRadio.TabIndex = 10;
            this.PurpleRadio.TabStop = true;
            this.PurpleRadio.Text = "Purple";
            this.toolTip1.SetToolTip(this.PurpleRadio, "Enemy outline Color. Switch to the Color which your enemy has.");
            this.PurpleRadio.UseVisualStyleBackColor = false;
            this.PurpleRadio.CheckedChanged += new System.EventHandler(this.Purple_changed);
            // 
            // ChangeMonitorBtt
            // 
            this.ChangeMonitorBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ChangeMonitorBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeMonitorBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChangeMonitorBtt.Location = new System.Drawing.Point(22, 1904);
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
            this.AimKeyToggle.BackColor = System.Drawing.Color.Transparent;
            this.AimKeyToggle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AimKeyToggle.Location = new System.Drawing.Point(22, 1880);
            this.AimKeyToggle.Margin = new System.Windows.Forms.Padding(2);
            this.AimKeyToggle.Name = "AimKeyToggle";
            this.AimKeyToggle.Size = new System.Drawing.Size(61, 17);
            this.AimKeyToggle.TabIndex = 12;
            this.AimKeyToggle.Text = "AimKey";
            this.AimKeyToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.AimKeyToggle, "Enables the Aimkey Keybind");
            this.AimKeyToggle.UseVisualStyleBackColor = false;
            this.AimKeyToggle.CheckedChanged += new System.EventHandler(this.AimKeyToggle_CheckedChanged);
            this.AimKeyToggle.Click += new System.EventHandler(this.IsAimKeyChanged);
            // 
            // IsHoldToggle
            // 
            this.IsHoldToggle.AutoSize = true;
            this.IsHoldToggle.BackColor = System.Drawing.Color.Transparent;
            this.IsHoldToggle.ForeColor = System.Drawing.Color.Snow;
            this.IsHoldToggle.Location = new System.Drawing.Point(84, 1880);
            this.IsHoldToggle.Margin = new System.Windows.Forms.Padding(2);
            this.IsHoldToggle.Name = "IsHoldToggle";
            this.IsHoldToggle.Size = new System.Drawing.Size(48, 17);
            this.IsHoldToggle.TabIndex = 13;
            this.IsHoldToggle.Text = "Hold";
            this.toolTip1.SetToolTip(this.IsHoldToggle, "Press and Hold the Aimkey for Triggerbot and Aimbot");
            this.IsHoldToggle.UseVisualStyleBackColor = false;
            this.IsHoldToggle.CheckedChanged += new System.EventHandler(this.IsHold_changed);
            // 
            // StartBtt
            // 
            this.StartBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.StartBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartBtt.Location = new System.Drawing.Point(22, 1933);
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
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(121, 350);
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
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(122, 790);
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
            this.FireRateNum.Location = new System.Drawing.Point(22, 788);
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
            40,
            0,
            0,
            0});
            this.FireRateNum.ValueChanged += new System.EventHandler(this.FireRate_changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(19, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Movement:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(18, 573);
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
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(18, 1714);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Keybinds Aimbot:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Customcolor
            // 
            this.Customcolor.AutoSize = true;
            this.Customcolor.BackColor = System.Drawing.Color.Transparent;
            this.Customcolor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Customcolor.Location = new System.Drawing.Point(120, 596);
            this.Customcolor.Margin = new System.Windows.Forms.Padding(0);
            this.Customcolor.Name = "Customcolor";
            this.Customcolor.Size = new System.Drawing.Size(61, 18);
            this.Customcolor.TabIndex = 25;
            this.Customcolor.TabStop = true;
            this.Customcolor.Text = "Custom";
            this.toolTip1.SetToolTip(this.Customcolor, "Custom RGB Color if it doesn\'t detect the predefined one.");
            this.Customcolor.UseCompatibleTextRendering = true;
            this.Customcolor.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(122, 620);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Red";
            this.toolTip1.SetToolTip(this.label11, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // Redinput
            // 
            this.Redinput.Location = new System.Drawing.Point(22, 618);
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
            this.Greeninput.Location = new System.Drawing.Point(22, 642);
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
            this.Blueinput.Location = new System.Drawing.Point(22, 666);
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
            this.label12.Location = new System.Drawing.Point(122, 644);
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
            this.label13.Location = new System.Drawing.Point(122, 668);
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
            this.label14.Location = new System.Drawing.Point(18, 709);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Triggerbot Settings";
            // 
            // Pingx
            // 
            this.Pingx.Location = new System.Drawing.Point(22, 740);
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
            20,
            0,
            0,
            0});
            this.Pingx.ValueChanged += new System.EventHandler(this.PixelX_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(122, 742);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Trigger Fov X";
            this.toolTip1.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(122, 766);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Trigger Fov Y";
            this.toolTip1.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
            // 
            // PixelY
            // 
            this.PixelY.Location = new System.Drawing.Point(22, 764);
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
            15,
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
            this.label17.Location = new System.Drawing.Point(18, 1587);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 20);
            this.label17.TabIndex = 38;
            this.label17.Text = "Custom Screenresolution:";
            // 
            // ScreenX2
            // 
            this.ScreenX2.Location = new System.Drawing.Point(22, 1630);
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
            this.ScreenY2.Location = new System.Drawing.Point(22, 1654);
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
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(121, 1632);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Pixel X";
            // 
            // ScreenY
            // 
            this.ScreenY.AutoSize = true;
            this.ScreenY.BackColor = System.Drawing.Color.Transparent;
            this.ScreenY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScreenY.Location = new System.Drawing.Point(121, 1656);
            this.ScreenY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScreenY.Name = "ScreenY";
            this.ScreenY.Size = new System.Drawing.Size(39, 13);
            this.ScreenY.TabIndex = 42;
            this.ScreenY.Text = "Pixel Y";
            // 
            // CustomScreen
            // 
            this.CustomScreen.AutoSize = true;
            this.CustomScreen.BackColor = System.Drawing.Color.Black;
            this.CustomScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomScreen.Location = new System.Drawing.Point(22, 1609);
            this.CustomScreen.Margin = new System.Windows.Forms.Padding(2);
            this.CustomScreen.Name = "CustomScreen";
            this.CustomScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomScreen.Size = new System.Drawing.Size(111, 17);
            this.CustomScreen.TabIndex = 44;
            this.CustomScreen.Text = "Custom Resolution";
            this.toolTip1.SetToolTip(this.CustomScreen, "You don\'t need this. Only if it doesn\'t detect your Screen Resolution.");
            this.CustomScreen.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Bhopbox
            // 
            this.Bhopbox.AllowDrop = true;
            this.Bhopbox.AutoSize = true;
            this.Bhopbox.BackColor = System.Drawing.Color.Transparent;
            this.Bhopbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bhopbox.ForeColor = System.Drawing.Color.White;
            this.Bhopbox.Location = new System.Drawing.Point(23, 95);
            this.Bhopbox.Margin = new System.Windows.Forms.Padding(2);
            this.Bhopbox.Name = "Bhopbox";
            this.Bhopbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bhopbox.Size = new System.Drawing.Size(51, 17);
            this.Bhopbox.TabIndex = 48;
            this.Bhopbox.Text = "Bhop";
            this.toolTip1.SetToolTip(this.Bhopbox, "This feature will let you jump to infinity");
            this.Bhopbox.UseMnemonic = false;
            this.Bhopbox.UseVisualStyleBackColor = false;
            this.Bhopbox.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Bhopinput
            // 
            this.Bhopinput.Location = new System.Drawing.Point(22, 922);
            this.Bhopinput.Margin = new System.Windows.Forms.Padding(2);
            this.Bhopinput.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.Bhopinput.Name = "Bhopinput";
            this.Bhopinput.Size = new System.Drawing.Size(90, 20);
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
            this.TriggerKeyBtt.Location = new System.Drawing.Point(21, 1813);
            this.TriggerKeyBtt.Margin = new System.Windows.Forms.Padding(2);
            this.TriggerKeyBtt.Name = "TriggerKeyBtt";
            this.TriggerKeyBtt.Size = new System.Drawing.Size(82, 25);
            this.TriggerKeyBtt.TabIndex = 52;
            this.TriggerKeyBtt.Text = "Keybind";
            this.toolTip1.SetToolTip(this.TriggerKeyBtt, "Keybinding for Triggerbot");
            this.TriggerKeyBtt.UseVisualStyleBackColor = false;
            this.TriggerKeyBtt.Click += new System.EventHandler(this.TriggerKeyDrop);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(122, 924);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Bhop Keycode";
            this.toolTip1.SetToolTip(this.label10, "Keybind for Bhop.\r\n\r\n(Spacebar does not work)\r\n\r\nKeybinds here: http://cherrytree" +
        ".at/misc/vk.htm");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(120, 455);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "Humanizer";
            this.toolTip1.SetToolTip(this.label20, "Changes the Speed of your Aimbot as soon as you reach your Enemy with the Crossha" +
        "ir or the Smooth Aim Pixels.\r\nThis is like a second Fov on Lockon.\r\n\r\nLower Valu" +
        "es are more legit.");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(121, 860);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "NoRecoil Adjuster";
            this.toolTip1.SetToolTip(this.label21, "Firerate of your Weapon in Triggerbotmode");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(120, 479);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "Delay";
            this.toolTip1.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(120, 527);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 65;
            this.label24.Text = "Pixel Y";
            this.toolTip1.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Cursor = System.Windows.Forms.Cursors.Default;
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(120, 503);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 63;
            this.label25.Text = "Pixel X";
            this.toolTip1.SetToolTip(this.label25, resources.GetString("label25.ToolTip"));
            // 
            // Ping
            // 
            this.Ping.AllowDrop = true;
            this.Ping.AutoSize = true;
            this.Ping.BackColor = System.Drawing.Color.Transparent;
            this.Ping.Cursor = System.Windows.Forms.Cursors.Default;
            this.Ping.ForeColor = System.Drawing.Color.White;
            this.Ping.Location = new System.Drawing.Point(21, 211);
            this.Ping.Margin = new System.Windows.Forms.Padding(2);
            this.Ping.Name = "Ping";
            this.Ping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ping.Size = new System.Drawing.Size(82, 17);
            this.Ping.TabIndex = 68;
            this.Ping.Text = "Ping Enemy";
            this.toolTip1.SetToolTip(this.Ping, "This Feature will Ping \"Warning\" if you aim at an Enemy\r\n\r\n- Change your Keybind " +
        "for Warning to \"P\"");
            this.Ping.UseMnemonic = false;
            this.Ping.UseVisualStyleBackColor = false;
            this.Ping.CheckedChanged += new System.EventHandler(this.Ping_CheckedChanged);
            // 
            // EspBtt
            // 
            this.EspBtt.AllowDrop = true;
            this.EspBtt.AutoSize = true;
            this.EspBtt.BackColor = System.Drawing.Color.Transparent;
            this.EspBtt.Cursor = System.Windows.Forms.Cursors.Default;
            this.EspBtt.ForeColor = System.Drawing.Color.White;
            this.EspBtt.Location = new System.Drawing.Point(21, 169);
            this.EspBtt.Margin = new System.Windows.Forms.Padding(2);
            this.EspBtt.Name = "EspBtt";
            this.EspBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EspBtt.Size = new System.Drawing.Size(74, 17);
            this.EspBtt.TabIndex = 69;
            this.EspBtt.Text = "Color ESP";
            this.toolTip1.SetToolTip(this.EspBtt, "This Feature will show you visible Enemies in an ESP Box\r\n\r\n(Only works on one En" +
        "emy at a time rn and needs some resources - Better disable this)");
            this.EspBtt.UseMnemonic = false;
            this.EspBtt.UseVisualStyleBackColor = false;
            this.EspBtt.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_2);
            // 
            // CircleBtt
            // 
            this.CircleBtt.AllowDrop = true;
            this.CircleBtt.AutoSize = true;
            this.CircleBtt.BackColor = System.Drawing.Color.Transparent;
            this.CircleBtt.Cursor = System.Windows.Forms.Cursors.Default;
            this.CircleBtt.ForeColor = System.Drawing.Color.White;
            this.CircleBtt.Location = new System.Drawing.Point(21, 148);
            this.CircleBtt.Margin = new System.Windows.Forms.Padding(2);
            this.CircleBtt.Name = "CircleBtt";
            this.CircleBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CircleBtt.Size = new System.Drawing.Size(76, 17);
            this.CircleBtt.TabIndex = 70;
            this.CircleBtt.Text = "FOV Circle";
            this.toolTip1.SetToolTip(this.CircleBtt, "This Feature shows your Fov in a Circle\r\n\r\n(refreshtime 5 seconds)");
            this.CircleBtt.UseMnemonic = false;
            this.CircleBtt.UseVisualStyleBackColor = false;
            this.CircleBtt.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // PixelBtt
            // 
            this.PixelBtt.AllowDrop = true;
            this.PixelBtt.AutoSize = true;
            this.PixelBtt.BackColor = System.Drawing.Color.Transparent;
            this.PixelBtt.Cursor = System.Windows.Forms.Cursors.Default;
            this.PixelBtt.ForeColor = System.Drawing.Color.White;
            this.PixelBtt.Location = new System.Drawing.Point(21, 190);
            this.PixelBtt.Margin = new System.Windows.Forms.Padding(2);
            this.PixelBtt.Name = "PixelBtt";
            this.PixelBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PixelBtt.Size = new System.Drawing.Size(98, 17);
            this.PixelBtt.TabIndex = 71;
            this.PixelBtt.Text = "Pixelfinder ESP";
            this.toolTip1.SetToolTip(this.PixelBtt, "This Feature shows you the nearest scanned outline Pixel\r\n\r\n(Use this for debuggi" +
        "ng? - Disable it on Default just needs too much resources)");
            this.PixelBtt.UseMnemonic = false;
            this.PixelBtt.UseVisualStyleBackColor = false;
            this.PixelBtt.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(122, 948);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 13);
            this.label28.TabIndex = 76;
            this.label28.Text = "Bhop Delay";
            this.toolTip1.SetToolTip(this.label28, "Delay for Bhop \r\n\r\n(Pressing each X ms your Spacebar to jump)\r\n");
            // 
            // Bdelay
            // 
            this.Bdelay.Location = new System.Drawing.Point(22, 946);
            this.Bdelay.Margin = new System.Windows.Forms.Padding(2);
            this.Bdelay.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.Bdelay.Name = "Bdelay";
            this.Bdelay.Size = new System.Drawing.Size(90, 20);
            this.Bdelay.TabIndex = 75;
            this.toolTip1.SetToolTip(this.Bdelay, "Delay for Bhop \r\n\r\n(Pressing each X ms your Spacebar to jump)");
            this.Bdelay.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label30.Location = new System.Drawing.Point(122, 1091);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(28, 13);
            this.label30.TabIndex = 85;
            this.label30.Text = "Blue";
            this.toolTip1.SetToolTip(this.label30, "Amount of Blue Color in your Circle\r\n\r\n");
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label31.Location = new System.Drawing.Point(122, 1067);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 13);
            this.label31.TabIndex = 84;
            this.label31.Text = "Green";
            this.toolTip1.SetToolTip(this.label31, "Amount of Green Color in your Circle\r\n\r\n");
            // 
            // CircleBlue
            // 
            this.CircleBlue.Location = new System.Drawing.Point(22, 1089);
            this.CircleBlue.Margin = new System.Windows.Forms.Padding(2);
            this.CircleBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CircleBlue.Name = "CircleBlue";
            this.CircleBlue.Size = new System.Drawing.Size(90, 20);
            this.CircleBlue.TabIndex = 83;
            this.toolTip1.SetToolTip(this.CircleBlue, "Amount of Blue Color in your Circle\r\n");
            this.CircleBlue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CircleGreen
            // 
            this.CircleGreen.Location = new System.Drawing.Point(22, 1065);
            this.CircleGreen.Margin = new System.Windows.Forms.Padding(2);
            this.CircleGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CircleGreen.Name = "CircleGreen";
            this.CircleGreen.Size = new System.Drawing.Size(90, 20);
            this.CircleGreen.TabIndex = 82;
            this.toolTip1.SetToolTip(this.CircleGreen, "Amount of Green Color in your Circle\r\n");
            this.CircleGreen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CircleGreen.ValueChanged += new System.EventHandler(this.CircleGreen_ValueChanged);
            // 
            // CircleRed
            // 
            this.CircleRed.Location = new System.Drawing.Point(22, 1041);
            this.CircleRed.Margin = new System.Windows.Forms.Padding(2);
            this.CircleRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CircleRed.Name = "CircleRed";
            this.CircleRed.Size = new System.Drawing.Size(90, 20);
            this.CircleRed.TabIndex = 81;
            this.toolTip1.SetToolTip(this.CircleRed, "Amount of Red Color in your Circle");
            this.CircleRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CircleRed.ValueChanged += new System.EventHandler(this.CircleRed_ValueChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label32.Location = new System.Drawing.Point(122, 1043);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(27, 13);
            this.label32.TabIndex = 80;
            this.label32.Text = "Red";
            this.toolTip1.SetToolTip(this.label32, "Amount of Red Color in your Circle\r\n");
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(122, 1514);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 13);
            this.label34.TabIndex = 88;
            this.label34.Text = "Ping Delay";
            this.toolTip1.SetToolTip(this.label34, "Change your Warning Ping Delay\r\n\r\n(Will Ping each x ms on an Enemy)");
            // 
            // PingDelay
            // 
            this.PingDelay.Location = new System.Drawing.Point(22, 1512);
            this.PingDelay.Margin = new System.Windows.Forms.Padding(2);
            this.PingDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PingDelay.Name = "PingDelay";
            this.PingDelay.Size = new System.Drawing.Size(90, 20);
            this.PingDelay.TabIndex = 87;
            this.toolTip1.SetToolTip(this.PingDelay, "Change your Warning Ping Delay\r\n\r\n(Will Ping each x ms on an Enemy)\r\n");
            this.PingDelay.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(122, 1540);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(69, 13);
            this.label35.TabIndex = 90;
            this.label35.Text = "Ping Keybind";
            this.toolTip1.SetToolTip(this.label35, "Keybind for Ping\r\n\r\nDefault \"P\" - Bind your Warning Ping to your key \"P\"");
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label37.Location = new System.Drawing.Point(122, 1246);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(28, 13);
            this.label37.TabIndex = 98;
            this.label37.Text = "Blue";
            this.toolTip1.SetToolTip(this.label37, "Amount of Blue Color in your Box\r\n");
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label38.Location = new System.Drawing.Point(122, 1220);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(36, 13);
            this.label38.TabIndex = 97;
            this.label38.Text = "Green";
            this.toolTip1.SetToolTip(this.label38, "Amount of Red Color in your Box\r\n");
            // 
            // ColB
            // 
            this.ColB.Location = new System.Drawing.Point(22, 1244);
            this.ColB.Margin = new System.Windows.Forms.Padding(2);
            this.ColB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColB.Name = "ColB";
            this.ColB.Size = new System.Drawing.Size(90, 20);
            this.ColB.TabIndex = 96;
            this.toolTip1.SetToolTip(this.ColB, "Amount of Blue Color in your Box");
            // 
            // ColG
            // 
            this.ColG.Location = new System.Drawing.Point(22, 1220);
            this.ColG.Margin = new System.Windows.Forms.Padding(2);
            this.ColG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColG.Name = "ColG";
            this.ColG.Size = new System.Drawing.Size(90, 20);
            this.ColG.TabIndex = 95;
            this.toolTip1.SetToolTip(this.ColG, "Amount of Green Color in your Box\r\n");
            // 
            // ColR
            // 
            this.ColR.Location = new System.Drawing.Point(22, 1196);
            this.ColR.Margin = new System.Windows.Forms.Padding(2);
            this.ColR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColR.Name = "ColR";
            this.ColR.Size = new System.Drawing.Size(90, 20);
            this.ColR.TabIndex = 94;
            this.toolTip1.SetToolTip(this.ColR, "Amount of Red Color in your Box");
            this.ColR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label39.Location = new System.Drawing.Point(122, 1198);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 13);
            this.label39.TabIndex = 93;
            this.label39.Text = "Red";
            this.toolTip1.SetToolTip(this.label39, "Amount of Red Color in your Box\r\n");
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label41.Location = new System.Drawing.Point(122, 1174);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(37, 13);
            this.label41.TabIndex = 103;
            this.label41.Text = "Size Y";
            this.toolTip1.SetToolTip(this.label41, "Size of your ESP Boxes in Y");
            // 
            // ColY
            // 
            this.ColY.Location = new System.Drawing.Point(22, 1172);
            this.ColY.Margin = new System.Windows.Forms.Padding(2);
            this.ColY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColY.Name = "ColY";
            this.ColY.Size = new System.Drawing.Size(90, 20);
            this.ColY.TabIndex = 101;
            this.toolTip1.SetToolTip(this.ColY, "Size of your ESP Boxes in Y\r\n\r\n");
            this.ColY.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // ColX
            // 
            this.ColX.Location = new System.Drawing.Point(22, 1148);
            this.ColX.Margin = new System.Windows.Forms.Padding(2);
            this.ColX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColX.Name = "ColX";
            this.ColX.Size = new System.Drawing.Size(90, 20);
            this.ColX.TabIndex = 100;
            this.toolTip1.SetToolTip(this.ColX, "Size of your ESP Boxes in X\r\n");
            this.ColX.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label42.Location = new System.Drawing.Point(122, 1150);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(37, 13);
            this.label42.TabIndex = 99;
            this.label42.Text = "Size X";
            this.toolTip1.SetToolTip(this.label42, "Size of your ESP Boxes in X\r\n\r\n");
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label43.Location = new System.Drawing.Point(122, 1357);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(37, 13);
            this.label43.TabIndex = 114;
            this.label43.Text = "Size Y";
            this.toolTip1.SetToolTip(this.label43, "Size of the Pixelfinder Esp in Y\r\n\r\n");
            // 
            // PixY
            // 
            this.PixY.Location = new System.Drawing.Point(22, 1355);
            this.PixY.Margin = new System.Windows.Forms.Padding(2);
            this.PixY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PixY.Name = "PixY";
            this.PixY.Size = new System.Drawing.Size(90, 20);
            this.PixY.TabIndex = 113;
            this.toolTip1.SetToolTip(this.PixY, "Size of the Pixelfinder Esp in Y\r\n");
            this.PixY.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // PixX
            // 
            this.PixX.Location = new System.Drawing.Point(22, 1331);
            this.PixX.Margin = new System.Windows.Forms.Padding(2);
            this.PixX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PixX.Name = "PixX";
            this.PixX.Size = new System.Drawing.Size(90, 20);
            this.PixX.TabIndex = 112;
            this.toolTip1.SetToolTip(this.PixX, "Size of the Pixelfinder Esp in X");
            this.PixX.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label44.Location = new System.Drawing.Point(122, 1333);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(37, 13);
            this.label44.TabIndex = 111;
            this.label44.Text = "Size X";
            this.toolTip1.SetToolTip(this.label44, "Size of the Pixelfinder Esp in X\r\n");
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label45.Location = new System.Drawing.Point(122, 1429);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(28, 13);
            this.label45.TabIndex = 110;
            this.label45.Text = "Blue";
            this.toolTip1.SetToolTip(this.label45, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label46.Location = new System.Drawing.Point(122, 1405);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(36, 13);
            this.label46.TabIndex = 109;
            this.label46.Text = "Green";
            this.toolTip1.SetToolTip(this.label46, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // PixBlue
            // 
            this.PixBlue.Location = new System.Drawing.Point(22, 1427);
            this.PixBlue.Margin = new System.Windows.Forms.Padding(2);
            this.PixBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PixBlue.Name = "PixBlue";
            this.PixBlue.Size = new System.Drawing.Size(90, 20);
            this.PixBlue.TabIndex = 108;
            this.toolTip1.SetToolTip(this.PixBlue, "Amount of Blue Color in your Circle\r\n\r\n");
            // 
            // PixGreen
            // 
            this.PixGreen.Location = new System.Drawing.Point(22, 1403);
            this.PixGreen.Margin = new System.Windows.Forms.Padding(2);
            this.PixGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PixGreen.Name = "PixGreen";
            this.PixGreen.Size = new System.Drawing.Size(90, 20);
            this.PixGreen.TabIndex = 107;
            this.toolTip1.SetToolTip(this.PixGreen, "Amount of Green Color in your Circle\r\n\r\n");
            // 
            // PixRed
            // 
            this.PixRed.Location = new System.Drawing.Point(22, 1379);
            this.PixRed.Margin = new System.Windows.Forms.Padding(2);
            this.PixRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PixRed.Name = "PixRed";
            this.PixRed.Size = new System.Drawing.Size(90, 20);
            this.PixRed.TabIndex = 106;
            this.toolTip1.SetToolTip(this.PixRed, "Amount of Red Color in your Circle\r\n");
            this.PixRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label47.Location = new System.Drawing.Point(122, 1381);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(27, 13);
            this.label47.TabIndex = 105;
            this.label47.Text = "Red";
            this.toolTip1.SetToolTip(this.label47, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // CircleWidth
            // 
            this.CircleWidth.Location = new System.Drawing.Point(22, 1017);
            this.CircleWidth.Margin = new System.Windows.Forms.Padding(2);
            this.CircleWidth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CircleWidth.Name = "CircleWidth";
            this.CircleWidth.Size = new System.Drawing.Size(90, 20);
            this.CircleWidth.TabIndex = 116;
            this.toolTip1.SetToolTip(this.CircleWidth, "Width of your Fov Circle");
            this.CircleWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CircleWidth.ValueChanged += new System.EventHandler(this.CircleWidth_ValueChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label48.Location = new System.Drawing.Point(122, 1019);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(35, 13);
            this.label48.TabIndex = 115;
            this.label48.Text = "Width";
            this.toolTip1.SetToolTip(this.label48, "Width of your Fov Circle\r\n");
            // 
            // PixWidth
            // 
            this.PixWidth.Location = new System.Drawing.Point(22, 1451);
            this.PixWidth.Margin = new System.Windows.Forms.Padding(2);
            this.PixWidth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PixWidth.Name = "PixWidth";
            this.PixWidth.Size = new System.Drawing.Size(90, 20);
            this.PixWidth.TabIndex = 117;
            this.toolTip1.SetToolTip(this.PixWidth, "Width of your Fov Circle\r\n");
            this.PixWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.BackColor = System.Drawing.Color.Transparent;
            this.width.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.width.Location = new System.Drawing.Point(122, 1453);
            this.width.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(35, 13);
            this.width.TabIndex = 118;
            this.width.Text = "Width";
            this.toolTip1.SetToolTip(this.width, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // ColWidth
            // 
            this.ColWidth.Location = new System.Drawing.Point(22, 1268);
            this.ColWidth.Margin = new System.Windows.Forms.Padding(2);
            this.ColWidth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColWidth.Name = "ColWidth";
            this.ColWidth.Size = new System.Drawing.Size(90, 20);
            this.ColWidth.TabIndex = 119;
            this.toolTip1.SetToolTip(this.ColWidth, "Amount of Width of your Box");
            this.ColWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label49.Location = new System.Drawing.Point(122, 1270);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(35, 13);
            this.label49.TabIndex = 120;
            this.label49.Text = "Width";
            this.toolTip1.SetToolTip(this.label49, "Amount of Width of your Box\r\n");
            // 
            // PingBind
            // 
            this.PingBind.Location = new System.Drawing.Point(22, 1537);
            this.PingBind.Name = "PingBind";
            this.PingBind.Size = new System.Drawing.Size(90, 20);
            this.PingBind.TabIndex = 121;
            this.PingBind.Text = "P";
            this.toolTip1.SetToolTip(this.PingBind, "Keybind for Ping");
            // 
            // TargetCheck
            // 
            this.TargetCheck.AutoSize = true;
            this.TargetCheck.Location = new System.Drawing.Point(21, 414);
            this.TargetCheck.Name = "TargetCheck";
            this.TargetCheck.Size = new System.Drawing.Size(105, 17);
            this.TargetCheck.TabIndex = 123;
            this.TargetCheck.Text = "Enable / Disable";
            this.toolTip1.SetToolTip(this.TargetCheck, "Checkbox to Enable - Disable the Target Aimbot\r\n\r\nWill Disable all Settings in \"A" +
        "imbot - Target\" and only use the \"Aimbot - Searching\" Settings.");
            this.TargetCheck.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.Location = new System.Drawing.Point(18, 1793);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(173, 20);
            this.label19.TabIndex = 53;
            this.label19.Text = "Keybinds Triggerbot:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
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
            this.label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label23.Location = new System.Drawing.Point(17, 393);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 20);
            this.label23.TabIndex = 61;
            this.label23.Text = "Aimbot - Target:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(17, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Aimbot - Searching:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label27.Location = new System.Drawing.Point(18, 834);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 20);
            this.label27.TabIndex = 73;
            this.label27.Text = "NoRecoil:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label26.Location = new System.Drawing.Point(19, 898);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 20);
            this.label26.TabIndex = 74;
            this.label26.Text = "Bhop:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label29.Location = new System.Drawing.Point(18, 994);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 20);
            this.label29.TabIndex = 77;
            this.label29.Text = "FOV Circle:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label33.Location = new System.Drawing.Point(19, 1489);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(108, 20);
            this.label33.TabIndex = 86;
            this.label33.Text = "Ping Enemy:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label36.Location = new System.Drawing.Point(18, 1126);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(96, 20);
            this.label36.TabIndex = 92;
            this.label36.Text = "Color ESP:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label40.Location = new System.Drawing.Point(18, 1309);
            this.label40.Name = "label40";
            this.label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label40.Size = new System.Drawing.Size(137, 20);
            this.label40.TabIndex = 104;
            this.label40.Text = "Pixelfinder ESP:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Cursor = System.Windows.Forms.Cursors.Default;
            this.label50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label50.Location = new System.Drawing.Point(17, 125);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(72, 20);
            this.label50.TabIndex = 122;
            this.label50.Text = "Visuals:";
            // 
            // RageBtt
            // 
            this.RageBtt.AutoSize = true;
            this.RageBtt.Location = new System.Drawing.Point(21, 431);
            this.RageBtt.Name = "RageBtt";
            this.RageBtt.Size = new System.Drawing.Size(89, 17);
            this.RageBtt.TabIndex = 124;
            this.RageBtt.Text = "Shoot on Aim";
            this.toolTip1.SetToolTip(this.RageBtt, resources.GetString("RageBtt.ToolTip"));
            this.RageBtt.UseVisualStyleBackColor = true;
            this.RageBtt.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.RageBtt);
            this.Controls.Add(this.TargetCheck);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.PingBind);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.ColWidth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.PixWidth);
            this.Controls.Add(this.CircleWidth);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.PixY);
            this.Controls.Add(this.PixX);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.PixBlue);
            this.Controls.Add(this.PixGreen);
            this.Controls.Add(this.PixRed);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.ColY);
            this.Controls.Add(this.ColX);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.ColB);
            this.Controls.Add(this.ColG);
            this.Controls.Add(this.ColR);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.PingDelay);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.CircleBlue);
            this.Controls.Add(this.CircleGreen);
            this.Controls.Add(this.CircleRed);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.Bdelay);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PixelBtt);
            this.Controls.Add(this.CircleBtt);
            this.Controls.Add(this.EspBtt);
            this.Controls.Add(this.Ping);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.SmoothY);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.SmoothX);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Delayx);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.rcs);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Speed3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TriggerKeyBtt);
            this.Controls.Add(this.Bhopinput);
            this.Controls.Add(this.Bhopbox);
            this.Controls.Add(this.RecoilBtt);
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
            this.Controls.Add(this.offsetNum);
            this.Controls.Add(this.StartBtt);
            this.Controls.Add(this.AimkeyBtt);
            this.Controls.Add(this.IsHoldToggle);
            this.Controls.Add(this.AimKeyToggle);
            this.Controls.Add(this.ChangeMonitorBtt);
            this.Controls.Add(this.PurpleRadio);
            this.Controls.Add(this.RedRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FovYNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FovXNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.TriggerbotBtt);
            this.Controls.Add(this.AimbotBtt);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_load);
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delayx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireRateNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Redinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeninput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blueinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pingx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bhopinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bdelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components;
        public System.Windows.Forms.NumericUpDown CircleBlue;
        public System.Windows.Forms.NumericUpDown CircleGreen;
        public System.Windows.Forms.NumericUpDown CircleRed;
        public System.Windows.Forms.NumericUpDown CircleWidth;
        public System.Windows.Forms.CheckBox TriggerbotBtt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton RedRadio;
        public System.Windows.Forms.RadioButton PurpleRadio;
        public System.Windows.Forms.Button ChangeMonitorBtt;
        public System.Windows.Forms.CheckBox AimKeyToggle;
        public System.Windows.Forms.CheckBox IsHoldToggle;
        public System.Windows.Forms.Button StartBtt;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown FireRateNum;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.RadioButton Customcolor;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.NumericUpDown Redinput;
        public System.Windows.Forms.NumericUpDown Greeninput;
        public System.Windows.Forms.NumericUpDown Blueinput;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.NumericUpDown Pingx;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.NumericUpDown PixelY;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.NumericUpDown ScreenX2;
        public System.Windows.Forms.NumericUpDown ScreenY2;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label ScreenY;
        public System.Windows.Forms.CheckBox CustomScreen;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.CheckBox Bhopbox;
        public System.Windows.Forms.NumericUpDown Bhopinput;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Button TriggerKeyBtt;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.CheckBox RecoilBtt;
        public System.Windows.Forms.CheckBox Ping;
        public System.Windows.Forms.CheckBox EspBtt;
        public System.Windows.Forms.CheckBox CircleBtt;
        public System.Windows.Forms.CheckBox PixelBtt;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.NumericUpDown Bdelay;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.Label label31;
        public System.Windows.Forms.Label label32;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.Label label33;
        public System.Windows.Forms.Label label34;
        public System.Windows.Forms.NumericUpDown PingDelay;
        public System.Windows.Forms.Label label35;
        public System.Windows.Forms.Label label36;
        public System.Windows.Forms.Label label37;
        public System.Windows.Forms.Label label38;
        public System.Windows.Forms.NumericUpDown ColB;
        public System.Windows.Forms.NumericUpDown ColG;
        public System.Windows.Forms.NumericUpDown ColR;
        public System.Windows.Forms.Label label39;
        public System.Windows.Forms.Label label41;
        public System.Windows.Forms.NumericUpDown ColY;
        public System.Windows.Forms.NumericUpDown ColX;
        public System.Windows.Forms.Label label42;
        public System.Windows.Forms.Label label40;
        public System.Windows.Forms.Label label43;
        public System.Windows.Forms.NumericUpDown PixY;
        public System.Windows.Forms.NumericUpDown PixX;
        public System.Windows.Forms.Label label44;
        public System.Windows.Forms.Label label45;
        public System.Windows.Forms.Label label46;
        public System.Windows.Forms.NumericUpDown PixBlue;
        public System.Windows.Forms.NumericUpDown PixGreen;
        public System.Windows.Forms.NumericUpDown PixRed;
        public System.Windows.Forms.Label label47;
        public System.Windows.Forms.CheckBox AimbotBtt;
        public System.Windows.Forms.NumericUpDown Speed;
        public System.Windows.Forms.NumericUpDown FovXNum;
        public System.Windows.Forms.NumericUpDown FovYNum;
        public System.Windows.Forms.NumericUpDown offsetNum;
        public System.Windows.Forms.NumericUpDown Speed3;
        public System.Windows.Forms.NumericUpDown Delayx;
        public System.Windows.Forms.NumericUpDown SmoothY;
        public System.Windows.Forms.NumericUpDown SmoothX;
        public System.Windows.Forms.NumericUpDown rcs;
        public System.Windows.Forms.Button AimkeyBtt;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label label48;
        public System.Windows.Forms.NumericUpDown PixWidth;
        public System.Windows.Forms.Label width;
        public System.Windows.Forms.NumericUpDown ColWidth;
        public System.Windows.Forms.Label label49;
        public System.Windows.Forms.TextBox PingBind;
        public System.Windows.Forms.Label label50;
        private System.Windows.Forms.CheckBox TargetCheck;
        private System.Windows.Forms.CheckBox RageBtt;
    }
}
