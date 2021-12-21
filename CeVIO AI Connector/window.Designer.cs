namespace CeVIO_AI_Connector
{
    partial class window
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.CeVIO_Start_Button = new System.Windows.Forms.Button();
            this.CeVIO_Close_Button = new System.Windows.Forms.Button();
            this.CeVIO_AI_Label = new System.Windows.Forms.Label();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.CeVIO_Info_GroupBox = new System.Windows.Forms.GroupBox();
            this.HTTP_URL_Text = new System.Windows.Forms.Label();
            this.CeVIO_Status_Text = new System.Windows.Forms.Label();
            this.CeVIO_Version_Text = new System.Windows.Forms.Label();
            this.CeVIO_Version_Label = new System.Windows.Forms.Label();
            this.CeVIO_ToneScale_Value = new System.Windows.Forms.NumericUpDown();
            this.CeVIO_Alpha_Value = new System.Windows.Forms.NumericUpDown();
            this.CeVIO_Tone_Value = new System.Windows.Forms.NumericUpDown();
            this.CeVIO_Speed_Value = new System.Windows.Forms.NumericUpDown();
            this.CeVIO_ToneScale_Text = new System.Windows.Forms.Label();
            this.CeVIO_Alpha_Text = new System.Windows.Forms.Label();
            this.CeVIO_Tone_Text = new System.Windows.Forms.Label();
            this.CeVIO_Speed_Text = new System.Windows.Forms.Label();
            this.CeVIO_Clear_Button = new System.Windows.Forms.Button();
            this.CeVIO_Stop_Button = new System.Windows.Forms.Button();
            this.CeVIO_Speak_Button = new System.Windows.Forms.Button();
            this.CeVIO_Volume_Value = new System.Windows.Forms.NumericUpDown();
            this.CeVIO_Volume_Text = new System.Windows.Forms.Label();
            this.CeVIO_Text_TextBox = new System.Windows.Forms.TextBox();
            this.CeVIO_Text_Text = new System.Windows.Forms.Label();
            this.CeVIO_Voice_Text = new System.Windows.Forms.Label();
            this.CeVIO_Voice_DropDown = new System.Windows.Forms.ComboBox();
            this.CeVIO_Status_Button = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HTTP_Port_Text = new System.Windows.Forms.Label();
            this.HTTP_Port_TextBox = new System.Windows.Forms.TextBox();
            this.dictionaly = new System.Windows.Forms.TabPage();
            this.Tab.SuspendLayout();
            this.Main.SuspendLayout();
            this.CeVIO_Info_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_ToneScale_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_Alpha_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_Tone_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_Speed_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_Volume_Value)).BeginInit();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // CeVIO_Start_Button
            // 
            this.CeVIO_Start_Button.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Start_Button.Location = new System.Drawing.Point(402, 165);
            this.CeVIO_Start_Button.Name = "CeVIO_Start_Button";
            this.CeVIO_Start_Button.Size = new System.Drawing.Size(105, 25);
            this.CeVIO_Start_Button.TabIndex = 0;
            this.CeVIO_Start_Button.Text = "CeVIO AI 起動";
            this.CeVIO_Start_Button.UseVisualStyleBackColor = true;
            this.CeVIO_Start_Button.Click += new System.EventHandler(this.CeVIO_Start_Button_Click);
            // 
            // CeVIO_Close_Button
            // 
            this.CeVIO_Close_Button.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Close_Button.Location = new System.Drawing.Point(402, 194);
            this.CeVIO_Close_Button.Name = "CeVIO_Close_Button";
            this.CeVIO_Close_Button.Size = new System.Drawing.Size(105, 25);
            this.CeVIO_Close_Button.TabIndex = 1;
            this.CeVIO_Close_Button.Text = "CeVIO AI 終了";
            this.CeVIO_Close_Button.UseVisualStyleBackColor = true;
            this.CeVIO_Close_Button.Click += new System.EventHandler(this.CeVIO_Close_Button_Click);
            // 
            // CeVIO_AI_Label
            // 
            this.CeVIO_AI_Label.AutoSize = true;
            this.CeVIO_AI_Label.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_AI_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CeVIO_AI_Label.Location = new System.Drawing.Point(84, 17);
            this.CeVIO_AI_Label.Name = "CeVIO_AI_Label";
            this.CeVIO_AI_Label.Size = new System.Drawing.Size(37, 14);
            this.CeVIO_AI_Label.TabIndex = 2;
            this.CeVIO_AI_Label.Text = "None";
            // 
            // Tab
            // 
            this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab.Controls.Add(this.Main);
            this.Tab.Controls.Add(this.Setting);
            this.Tab.Controls.Add(this.dictionaly);
            this.Tab.Location = new System.Drawing.Point(3, 3);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(560, 256);
            this.Tab.TabIndex = 3;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.CeVIO_Info_GroupBox);
            this.Main.Controls.Add(this.CeVIO_ToneScale_Value);
            this.Main.Controls.Add(this.CeVIO_Alpha_Value);
            this.Main.Controls.Add(this.CeVIO_Tone_Value);
            this.Main.Controls.Add(this.CeVIO_Speed_Value);
            this.Main.Controls.Add(this.CeVIO_ToneScale_Text);
            this.Main.Controls.Add(this.CeVIO_Alpha_Text);
            this.Main.Controls.Add(this.CeVIO_Tone_Text);
            this.Main.Controls.Add(this.CeVIO_Speed_Text);
            this.Main.Controls.Add(this.CeVIO_Clear_Button);
            this.Main.Controls.Add(this.CeVIO_Stop_Button);
            this.Main.Controls.Add(this.CeVIO_Speak_Button);
            this.Main.Controls.Add(this.CeVIO_Volume_Value);
            this.Main.Controls.Add(this.CeVIO_Volume_Text);
            this.Main.Controls.Add(this.CeVIO_Text_TextBox);
            this.Main.Controls.Add(this.CeVIO_Text_Text);
            this.Main.Controls.Add(this.CeVIO_Voice_Text);
            this.Main.Controls.Add(this.CeVIO_Voice_DropDown);
            this.Main.Controls.Add(this.CeVIO_Status_Button);
            this.Main.Controls.Add(this.CeVIO_Close_Button);
            this.Main.Controls.Add(this.CeVIO_Start_Button);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(552, 230);
            this.Main.TabIndex = 0;
            this.Main.Text = "CeVIO";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // CeVIO_Info_GroupBox
            // 
            this.CeVIO_Info_GroupBox.Controls.Add(this.HTTP_URL_Text);
            this.CeVIO_Info_GroupBox.Controls.Add(this.CeVIO_Status_Text);
            this.CeVIO_Info_GroupBox.Controls.Add(this.CeVIO_AI_Label);
            this.CeVIO_Info_GroupBox.Controls.Add(this.CeVIO_Version_Text);
            this.CeVIO_Info_GroupBox.Controls.Add(this.CeVIO_Version_Label);
            this.CeVIO_Info_GroupBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Info_GroupBox.Location = new System.Drawing.Point(3, 137);
            this.CeVIO_Info_GroupBox.Name = "CeVIO_Info_GroupBox";
            this.CeVIO_Info_GroupBox.Size = new System.Drawing.Size(353, 90);
            this.CeVIO_Info_GroupBox.TabIndex = 31;
            this.CeVIO_Info_GroupBox.TabStop = false;
            this.CeVIO_Info_GroupBox.Text = "Status";
            // 
            // HTTP_URL_Text
            // 
            this.HTTP_URL_Text.AutoSize = true;
            this.HTTP_URL_Text.Location = new System.Drawing.Point(6, 51);
            this.HTTP_URL_Text.Name = "HTTP_URL_Text";
            this.HTTP_URL_Text.Size = new System.Drawing.Size(134, 14);
            this.HTTP_URL_Text.TabIndex = 13;
            this.HTTP_URL_Text.Text = "HTTP Request URL  :";
            // 
            // CeVIO_Status_Text
            // 
            this.CeVIO_Status_Text.AutoSize = true;
            this.CeVIO_Status_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Status_Text.Location = new System.Drawing.Point(6, 17);
            this.CeVIO_Status_Text.Name = "CeVIO_Status_Text";
            this.CeVIO_Status_Text.Size = new System.Drawing.Size(72, 14);
            this.CeVIO_Status_Text.TabIndex = 6;
            this.CeVIO_Status_Text.Text = "CeVIO AI  :";
            // 
            // CeVIO_Version_Text
            // 
            this.CeVIO_Version_Text.AutoSize = true;
            this.CeVIO_Version_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Version_Text.Location = new System.Drawing.Point(6, 34);
            this.CeVIO_Version_Text.Name = "CeVIO_Version_Text";
            this.CeVIO_Version_Text.Size = new System.Drawing.Size(120, 14);
            this.CeVIO_Version_Text.TabIndex = 11;
            this.CeVIO_Version_Text.Text = "CeVIO AI Version  :";
            // 
            // CeVIO_Version_Label
            // 
            this.CeVIO_Version_Label.AutoSize = true;
            this.CeVIO_Version_Label.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Version_Label.Location = new System.Drawing.Point(132, 34);
            this.CeVIO_Version_Label.Name = "CeVIO_Version_Label";
            this.CeVIO_Version_Label.Size = new System.Drawing.Size(37, 14);
            this.CeVIO_Version_Label.TabIndex = 12;
            this.CeVIO_Version_Label.Text = "None";
            // 
            // CeVIO_ToneScale_Value
            // 
            this.CeVIO_ToneScale_Value.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_ToneScale_Value.Location = new System.Drawing.Point(476, 134);
            this.CeVIO_ToneScale_Value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.CeVIO_ToneScale_Value.Name = "CeVIO_ToneScale_Value";
            this.CeVIO_ToneScale_Value.Size = new System.Drawing.Size(50, 21);
            this.CeVIO_ToneScale_Value.TabIndex = 30;
            this.CeVIO_ToneScale_Value.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // CeVIO_Alpha_Value
            // 
            this.CeVIO_Alpha_Value.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Alpha_Value.Location = new System.Drawing.Point(476, 107);
            this.CeVIO_Alpha_Value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.CeVIO_Alpha_Value.Name = "CeVIO_Alpha_Value";
            this.CeVIO_Alpha_Value.Size = new System.Drawing.Size(50, 21);
            this.CeVIO_Alpha_Value.TabIndex = 29;
            this.CeVIO_Alpha_Value.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // CeVIO_Tone_Value
            // 
            this.CeVIO_Tone_Value.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Tone_Value.Location = new System.Drawing.Point(476, 80);
            this.CeVIO_Tone_Value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.CeVIO_Tone_Value.Name = "CeVIO_Tone_Value";
            this.CeVIO_Tone_Value.Size = new System.Drawing.Size(50, 21);
            this.CeVIO_Tone_Value.TabIndex = 28;
            this.CeVIO_Tone_Value.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // CeVIO_Speed_Value
            // 
            this.CeVIO_Speed_Value.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Speed_Value.Location = new System.Drawing.Point(476, 53);
            this.CeVIO_Speed_Value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.CeVIO_Speed_Value.Name = "CeVIO_Speed_Value";
            this.CeVIO_Speed_Value.Size = new System.Drawing.Size(50, 21);
            this.CeVIO_Speed_Value.TabIndex = 27;
            this.CeVIO_Speed_Value.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // CeVIO_ToneScale_Text
            // 
            this.CeVIO_ToneScale_Text.AutoSize = true;
            this.CeVIO_ToneScale_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_ToneScale_Text.Location = new System.Drawing.Point(377, 136);
            this.CeVIO_ToneScale_Text.Name = "CeVIO_ToneScale_Text";
            this.CeVIO_ToneScale_Text.Size = new System.Drawing.Size(72, 14);
            this.CeVIO_ToneScale_Text.TabIndex = 26;
            this.CeVIO_ToneScale_Text.Text = "Tone Scale";
            // 
            // CeVIO_Alpha_Text
            // 
            this.CeVIO_Alpha_Text.AutoSize = true;
            this.CeVIO_Alpha_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Alpha_Text.Location = new System.Drawing.Point(377, 109);
            this.CeVIO_Alpha_Text.Name = "CeVIO_Alpha_Text";
            this.CeVIO_Alpha_Text.Size = new System.Drawing.Size(40, 14);
            this.CeVIO_Alpha_Text.TabIndex = 25;
            this.CeVIO_Alpha_Text.Text = "Alpha";
            // 
            // CeVIO_Tone_Text
            // 
            this.CeVIO_Tone_Text.AutoSize = true;
            this.CeVIO_Tone_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Tone_Text.Location = new System.Drawing.Point(377, 82);
            this.CeVIO_Tone_Text.Name = "CeVIO_Tone_Text";
            this.CeVIO_Tone_Text.Size = new System.Drawing.Size(36, 14);
            this.CeVIO_Tone_Text.TabIndex = 24;
            this.CeVIO_Tone_Text.Text = "Tone";
            // 
            // CeVIO_Speed_Text
            // 
            this.CeVIO_Speed_Text.AutoSize = true;
            this.CeVIO_Speed_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Speed_Text.Location = new System.Drawing.Point(377, 55);
            this.CeVIO_Speed_Text.Name = "CeVIO_Speed_Text";
            this.CeVIO_Speed_Text.Size = new System.Drawing.Size(43, 14);
            this.CeVIO_Speed_Text.TabIndex = 23;
            this.CeVIO_Speed_Text.Text = "Speed";
            // 
            // CeVIO_Clear_Button
            // 
            this.CeVIO_Clear_Button.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Clear_Button.Location = new System.Drawing.Point(281, 112);
            this.CeVIO_Clear_Button.Name = "CeVIO_Clear_Button";
            this.CeVIO_Clear_Button.Size = new System.Drawing.Size(75, 25);
            this.CeVIO_Clear_Button.TabIndex = 21;
            this.CeVIO_Clear_Button.Text = "Clear";
            this.CeVIO_Clear_Button.UseVisualStyleBackColor = true;
            this.CeVIO_Clear_Button.Click += new System.EventHandler(this.CeVIO_Clear_Button_Click);
            // 
            // CeVIO_Stop_Button
            // 
            this.CeVIO_Stop_Button.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Stop_Button.Location = new System.Drawing.Point(281, 81);
            this.CeVIO_Stop_Button.Name = "CeVIO_Stop_Button";
            this.CeVIO_Stop_Button.Size = new System.Drawing.Size(75, 25);
            this.CeVIO_Stop_Button.TabIndex = 20;
            this.CeVIO_Stop_Button.Text = "Stop";
            this.CeVIO_Stop_Button.UseVisualStyleBackColor = true;
            this.CeVIO_Stop_Button.Click += new System.EventHandler(this.CeVIO_Stop_Button_Click);
            // 
            // CeVIO_Speak_Button
            // 
            this.CeVIO_Speak_Button.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Speak_Button.Location = new System.Drawing.Point(200, 81);
            this.CeVIO_Speak_Button.Name = "CeVIO_Speak_Button";
            this.CeVIO_Speak_Button.Size = new System.Drawing.Size(75, 25);
            this.CeVIO_Speak_Button.TabIndex = 19;
            this.CeVIO_Speak_Button.Text = "Speak";
            this.CeVIO_Speak_Button.UseVisualStyleBackColor = true;
            this.CeVIO_Speak_Button.Click += new System.EventHandler(this.CeVIO_Speak_Button_Click);
            // 
            // CeVIO_Volume_Value
            // 
            this.CeVIO_Volume_Value.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Volume_Value.Location = new System.Drawing.Point(476, 26);
            this.CeVIO_Volume_Value.Name = "CeVIO_Volume_Value";
            this.CeVIO_Volume_Value.Size = new System.Drawing.Size(50, 21);
            this.CeVIO_Volume_Value.TabIndex = 18;
            // 
            // CeVIO_Volume_Text
            // 
            this.CeVIO_Volume_Text.AutoSize = true;
            this.CeVIO_Volume_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Volume_Text.Location = new System.Drawing.Point(377, 28);
            this.CeVIO_Volume_Text.Name = "CeVIO_Volume_Text";
            this.CeVIO_Volume_Text.Size = new System.Drawing.Size(50, 14);
            this.CeVIO_Volume_Text.TabIndex = 17;
            this.CeVIO_Volume_Text.Text = "Volume";
            // 
            // CeVIO_Text_TextBox
            // 
            this.CeVIO_Text_TextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Text_TextBox.Location = new System.Drawing.Point(6, 25);
            this.CeVIO_Text_TextBox.Multiline = true;
            this.CeVIO_Text_TextBox.Name = "CeVIO_Text_TextBox";
            this.CeVIO_Text_TextBox.Size = new System.Drawing.Size(350, 50);
            this.CeVIO_Text_TextBox.TabIndex = 16;
            // 
            // CeVIO_Text_Text
            // 
            this.CeVIO_Text_Text.AutoSize = true;
            this.CeVIO_Text_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Text_Text.Location = new System.Drawing.Point(6, 8);
            this.CeVIO_Text_Text.Name = "CeVIO_Text_Text";
            this.CeVIO_Text_Text.Size = new System.Drawing.Size(33, 14);
            this.CeVIO_Text_Text.TabIndex = 15;
            this.CeVIO_Text_Text.Text = "Text";
            // 
            // CeVIO_Voice_Text
            // 
            this.CeVIO_Voice_Text.AutoSize = true;
            this.CeVIO_Voice_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Voice_Text.Location = new System.Drawing.Point(11, 86);
            this.CeVIO_Voice_Text.Name = "CeVIO_Voice_Text";
            this.CeVIO_Voice_Text.Size = new System.Drawing.Size(40, 14);
            this.CeVIO_Voice_Text.TabIndex = 14;
            this.CeVIO_Voice_Text.Text = "Voice";
            // 
            // CeVIO_Voice_DropDown
            // 
            this.CeVIO_Voice_DropDown.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Voice_DropDown.FormattingEnabled = true;
            this.CeVIO_Voice_DropDown.Location = new System.Drawing.Point(57, 83);
            this.CeVIO_Voice_DropDown.Name = "CeVIO_Voice_DropDown";
            this.CeVIO_Voice_DropDown.Size = new System.Drawing.Size(125, 21);
            this.CeVIO_Voice_DropDown.TabIndex = 13;
            // 
            // CeVIO_Status_Button
            // 
            this.CeVIO_Status_Button.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CeVIO_Status_Button.Location = new System.Drawing.Point(200, 112);
            this.CeVIO_Status_Button.Name = "CeVIO_Status_Button";
            this.CeVIO_Status_Button.Size = new System.Drawing.Size(75, 25);
            this.CeVIO_Status_Button.TabIndex = 10;
            this.CeVIO_Status_Button.Text = "Load";
            this.CeVIO_Status_Button.UseVisualStyleBackColor = true;
            this.CeVIO_Status_Button.Click += new System.EventHandler(this.CeVIO_Status_Button_Click);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.button1);
            this.Setting.Controls.Add(this.label1);
            this.Setting.Controls.Add(this.HTTP_Port_Text);
            this.Setting.Controls.Add(this.HTTP_Port_TextBox);
            this.Setting.Location = new System.Drawing.Point(4, 22);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(3);
            this.Setting.Size = new System.Drawing.Size(552, 280);
            this.Setting.TabIndex = 1;
            this.Setting.Text = "設定";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "HTTP通信(localのみ)";
            // 
            // HTTP_Port_Text
            // 
            this.HTTP_Port_Text.AutoSize = true;
            this.HTTP_Port_Text.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.HTTP_Port_Text.Location = new System.Drawing.Point(139, 8);
            this.HTTP_Port_Text.Name = "HTTP_Port_Text";
            this.HTTP_Port_Text.Size = new System.Drawing.Size(33, 14);
            this.HTTP_Port_Text.TabIndex = 4;
            this.HTTP_Port_Text.Text = "Port";
            // 
            // HTTP_Port_TextBox
            // 
            this.HTTP_Port_TextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.HTTP_Port_TextBox.Location = new System.Drawing.Point(178, 5);
            this.HTTP_Port_TextBox.Name = "HTTP_Port_TextBox";
            this.HTTP_Port_TextBox.Size = new System.Drawing.Size(70, 21);
            this.HTTP_Port_TextBox.TabIndex = 5;
            this.HTTP_Port_TextBox.Text = "50081";
            // 
            // dictionaly
            // 
            this.dictionaly.Location = new System.Drawing.Point(4, 22);
            this.dictionaly.Name = "dictionaly";
            this.dictionaly.Padding = new System.Windows.Forms.Padding(3);
            this.dictionaly.Size = new System.Drawing.Size(552, 280);
            this.dictionaly.TabIndex = 2;
            this.dictionaly.Text = "辞書";
            this.dictionaly.UseVisualStyleBackColor = true;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 261);
            this.Controls.Add(this.Tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "window";
            this.Text = "CeVIO AI Connector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tab.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.CeVIO_Info_GroupBox.ResumeLayout(false);
            this.CeVIO_Info_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_ToneScale_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_Alpha_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_Tone_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_Speed_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CeVIO_Volume_Value)).EndInit();
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CeVIO_Start_Button;
        private System.Windows.Forms.Button CeVIO_Close_Button;
        private System.Windows.Forms.Label CeVIO_AI_Label;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.Label CeVIO_Status_Text;
        private System.Windows.Forms.Button CeVIO_Status_Button;
        private System.Windows.Forms.Label CeVIO_Version_Label;
        private System.Windows.Forms.Label CeVIO_Version_Text;
        private System.Windows.Forms.Label CeVIO_ToneScale_Text;
        private System.Windows.Forms.Label CeVIO_Alpha_Text;
        private System.Windows.Forms.Label CeVIO_Tone_Text;
        private System.Windows.Forms.Label CeVIO_Speed_Text;
        private System.Windows.Forms.Button CeVIO_Clear_Button;
        private System.Windows.Forms.Button CeVIO_Stop_Button;
        private System.Windows.Forms.Button CeVIO_Speak_Button;
        private System.Windows.Forms.NumericUpDown CeVIO_Volume_Value;
        private System.Windows.Forms.Label CeVIO_Volume_Text;
        private System.Windows.Forms.TextBox CeVIO_Text_TextBox;
        private System.Windows.Forms.Label CeVIO_Text_Text;
        private System.Windows.Forms.Label CeVIO_Voice_Text;
        private System.Windows.Forms.ComboBox CeVIO_Voice_DropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HTTP_Port_Text;
        private System.Windows.Forms.TextBox HTTP_Port_TextBox;
        private System.Windows.Forms.NumericUpDown CeVIO_ToneScale_Value;
        private System.Windows.Forms.NumericUpDown CeVIO_Alpha_Value;
        private System.Windows.Forms.NumericUpDown CeVIO_Tone_Value;
        private System.Windows.Forms.NumericUpDown CeVIO_Speed_Value;
        private System.Windows.Forms.GroupBox CeVIO_Info_GroupBox;
        private System.Windows.Forms.TabPage dictionaly;
        private System.Windows.Forms.Label HTTP_URL_Text;
        private System.Windows.Forms.Button button1;
    }
}

