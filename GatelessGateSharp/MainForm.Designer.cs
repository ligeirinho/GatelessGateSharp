﻿namespace GatelessGateSharp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMainForm = new System.Windows.Forms.TabControl();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cartesianChartCPUUsage = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartPower = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartTemperature = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartDeviceActivity = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartFanSpeed = new LiveCharts.WinForms.CartesianChart();
            this.comboBoxGraphType = new System.Windows.Forms.ComboBox();
            this.comboBoxGraphCoverage = new System.Windows.Forms.ComboBox();
            this.cartesianChartShare1Month = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartShare1Day = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartShare1Hour = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartShare1Minute = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartSpeedSecondaryAlgorithm = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartSpeedPrimaryAlgorithm = new LiveCharts.WinForms.CartesianChart();
            this.comboBoxSecondGraphType = new System.Windows.Forms.ComboBox();
            this.comboBoxSecondGraphCoverage = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRestoreStockSettings = new System.Windows.Forms.Button();
            this.buttonBoostPerformance = new System.Windows.Forms.Button();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCurrentSpeed = new System.Windows.Forms.Label();
            this.labelCurrentSecondaryPool = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.labelCurrentPool = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPriceDay = new System.Windows.Forms.Label();
            this.labelPriceWeek = new System.Windows.Forms.Label();
            this.labelPriceMonth = new System.Windows.Forms.Label();
            this.dataGridViewDevices = new System.Windows.Forms.DataGridView();
            this.enabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.core_clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.core_voltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memory_clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memory_used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memory_reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagePoolSettings = new System.Windows.Forms.TabPage();
            this.groupBoxWalletAddresses = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonLbryBalance = new System.Windows.Forms.Button();
            this.textBoxLbryAddress = new System.Windows.Forms.TextBox();
            this.textBoxPascalAddress = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.buttonViewPascalBalance = new System.Windows.Forms.Button();
            this.textBoxBitcoinAddress = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxEthereumAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMoneroAddress = new System.Windows.Forms.TextBox();
            this.buttonMoneroBalance = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonEthereumBalance = new System.Windows.Forms.Button();
            this.textBoxZcashAddress = new System.Windows.Forms.TextBox();
            this.buttonViewBalancesAtNiceHash = new System.Windows.Forms.Button();
            this.groupBoxPoolParameters = new System.Windows.Forms.GroupBox();
            this.textBoxRigID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBoxPoolPriorities = new System.Windows.Forms.GroupBox();
            this.buttonPoolPrioritiesDown = new System.Windows.Forms.Button();
            this.buttonPoolPrioritiesUp = new System.Windows.Forms.Button();
            this.listBoxPoolPriorities = new System.Windows.Forms.ListBox();
            this.groupBoxCoinsToMine = new System.Windows.Forms.GroupBox();
            this.radioButtonMonacoin = new System.Windows.Forms.RadioButton();
            this.radioButtonFeathercoin = new System.Windows.Forms.RadioButton();
            this.radioButtonPascal = new System.Windows.Forms.RadioButton();
            this.radioButtonLbry = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonEthereumPascal = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonZcash = new System.Windows.Forms.RadioButton();
            this.radioButtonMonero = new System.Windows.Forms.RadioButton();
            this.radioButtonEthereum = new System.Windows.Forms.RadioButton();
            this.radioButtonMostProfitable = new System.Windows.Forms.RadioButton();
            this.tabPageCustomPoolSettings = new System.Windows.Forms.TabPage();
            this.groupBoxCustmPool1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCustomPool1SecondaryAlgorithm = new System.Windows.Forms.ComboBox();
            this.label165 = new System.Windows.Forms.Label();
            this.numericUpDownCustomPool1SecondaryPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomPool1SecondaryHost = new System.Windows.Forms.TextBox();
            this.textBoxCustomPool1SecondaryPassword = new System.Windows.Forms.TextBox();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.textBoxCustomPool1SecondaryLogin = new System.Windows.Forms.TextBox();
            this.label168 = new System.Windows.Forms.Label();
            this.comboBoxCustomPool1Algorithm = new System.Windows.Forms.ComboBox();
            this.checkBoxCustomPool1Enable = new System.Windows.Forms.CheckBox();
            this.label151 = new System.Windows.Forms.Label();
            this.numericUpDownCustomPool1Port = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomPool1Host = new System.Windows.Forms.TextBox();
            this.textBoxCustomPool1Password = new System.Windows.Forms.TextBox();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.textBoxCustomPool1Login = new System.Windows.Forms.TextBox();
            this.label154 = new System.Windows.Forms.Label();
            this.groupBoxCustmPool2 = new System.Windows.Forms.GroupBox();
            this.comboBoxCustomPool2SecondaryAlgorithm = new System.Windows.Forms.ComboBox();
            this.label169 = new System.Windows.Forms.Label();
            this.numericUpDownCustomPool2SecondaryPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomPool2SecondaryHost = new System.Windows.Forms.TextBox();
            this.textBoxCustomPool2SecondaryPassword = new System.Windows.Forms.TextBox();
            this.label170 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.textBoxCustomPool2SecondaryLogin = new System.Windows.Forms.TextBox();
            this.label172 = new System.Windows.Forms.Label();
            this.comboBoxCustomPool2Algorithm = new System.Windows.Forms.ComboBox();
            this.checkBoxCustomPool2Enable = new System.Windows.Forms.CheckBox();
            this.label156 = new System.Windows.Forms.Label();
            this.numericUpDownCustomPool2Port = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomPool2Host = new System.Windows.Forms.TextBox();
            this.textBoxCustomPool2Password = new System.Windows.Forms.TextBox();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.textBoxCustomPool2Login = new System.Windows.Forms.TextBox();
            this.label159 = new System.Windows.Forms.Label();
            this.groupBoxCustmPool3 = new System.Windows.Forms.GroupBox();
            this.comboBoxCustomPool3SecondaryAlgorithm = new System.Windows.Forms.ComboBox();
            this.label173 = new System.Windows.Forms.Label();
            this.numericUpDownCustomPool3SecondaryPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomPool3SecondaryHost = new System.Windows.Forms.TextBox();
            this.textBoxCustomPool3SecondaryPassword = new System.Windows.Forms.TextBox();
            this.label174 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.textBoxCustomPool3SecondaryLogin = new System.Windows.Forms.TextBox();
            this.label176 = new System.Windows.Forms.Label();
            this.comboBoxCustomPool3Algorithm = new System.Windows.Forms.ComboBox();
            this.checkBoxCustomPool3Enable = new System.Windows.Forms.CheckBox();
            this.label161 = new System.Windows.Forms.Label();
            this.numericUpDownCustomPool3Port = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomPool3Host = new System.Windows.Forms.TextBox();
            this.textBoxCustomPool3Password = new System.Windows.Forms.TextBox();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.textBoxCustomPool3Login = new System.Windows.Forms.TextBox();
            this.label164 = new System.Windows.Forms.Label();
            this.groupBoxCustmPool0 = new System.Windows.Forms.GroupBox();
            this.label149 = new System.Windows.Forms.Label();
            this.numericUpDownCustomPool0SecondaryPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomPool0SecondaryHost = new System.Windows.Forms.TextBox();
            this.textBoxCustomPool0SecondaryPassword = new System.Windows.Forms.TextBox();
            this.label150 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.textBoxCustomPool0SecondaryLogin = new System.Windows.Forms.TextBox();
            this.label160 = new System.Windows.Forms.Label();
            this.comboBoxCustomPool0SecondaryAlgorithm = new System.Windows.Forms.ComboBox();
            this.checkBoxCustomPool0Enable = new System.Windows.Forms.CheckBox();
            this.comboBoxCustomPool0Algorithm = new System.Windows.Forms.ComboBox();
            this.label147 = new System.Windows.Forms.Label();
            this.numericUpDownCustomPool0Port = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomPool0Host = new System.Windows.Forms.TextBox();
            this.textBoxCustomPool0Password = new System.Windows.Forms.TextBox();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.textBoxCustomPool0Login = new System.Windows.Forms.TextBox();
            this.label148 = new System.Windows.Forms.Label();
            this.tabPageDeviceSettings = new System.Windows.Forms.TabPage();
            this.buttonResetOverclockingSettings = new System.Windows.Forms.Button();
            this.buttonResetAllSettings = new System.Windows.Forms.Button();
            this.buttonResetAlgorithmSettings = new System.Windows.Forms.Button();
            this.buttonResetFanControlSettings = new System.Windows.Forms.Button();
            this.groupBoxHadrwareAcceleration = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableOverclockingForDefaultSettings = new System.Windows.Forms.CheckBox();
            this.label144 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnablePhymem = new System.Windows.Forms.CheckBox();
            this.tabControlDeviceSettings = new System.Windows.Forms.TabControl();
            this.tabPageAPI = new System.Windows.Forms.TabPage();
            this.groupBoxAPIIPRange = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxAdminIPRange = new System.Windows.Forms.TextBox();
            this.textBoxDeniedIPRange = new System.Windows.Forms.TextBox();
            this.textBoxAllowedIPRange = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownAPIPort = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBoxAPIEnabled = new System.Windows.Forms.CheckBox();
            this.tabPageMiscSettings = new System.Windows.Forms.TabPage();
            this.groupBoxOpenCLBinaries = new System.Windows.Forms.GroupBox();
            this.buttonOpenOpenCLBinaryFolder = new System.Windows.Forms.Button();
            this.checkBoxReuseCompiledBinaries = new System.Windows.Forms.CheckBox();
            this.checkBoxUseDefaultOpenCLBinaries = new System.Windows.Forms.CheckBox();
            this.groupBoxUserSettings = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBoxSettingsBackups = new System.Windows.Forms.GroupBox();
            this.checkBoxAutomaticBackups = new System.Windows.Forms.CheckBox();
            this.buttonDeleteAllSettingsBackups = new System.Windows.Forms.Button();
            this.buttonDeleteSettingsBackup = new System.Windows.Forms.Button();
            this.buttonRestoreSettingsBackup = new System.Windows.Forms.Button();
            this.buttonCreateSettingsBackup = new System.Windows.Forms.Button();
            this.listBoxSettingBackups = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonDisableUserAccountControl = new System.Windows.Forms.Button();
            this.buttonDisableUserAccountControlSettings = new System.Windows.Forms.Button();
            this.buttonDownloadDisplayDriverUninstaller = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonConfigureAutomaticLogin = new System.Windows.Forms.Button();
            this.buttonInstallRecommendedAMDDriver = new System.Windows.Forms.Button();
            this.buttonDisableAuomaticRepair = new System.Windows.Forms.Button();
            this.buttonDisableDriverInstallation = new System.Windows.Forms.Button();
            this.groupBoxAutomation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDisableAutoStartPrompt = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.checkBoxLaunchAtStartup = new System.Windows.Forms.CheckBox();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.buttonOpenLogContainingFolder = new System.Windows.Forms.Button();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.buttonOpenLog = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.richTextBoxAbout = new System.Windows.Forms.RichTextBox();
            this.timerStatsUpdates = new System.Windows.Forms.Timer(this.components);
            this.timerDevFee = new System.Windows.Forms.Timer(this.components);
            this.timerWatchdog = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateLog = new System.Windows.Forms.Timer(this.components);
            this.timerAutoStart = new System.Windows.Forms.Timer(this.components);
            this.buttonRelaunch = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripMainFormProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerFailOver = new System.Windows.Forms.Timer(this.components);
            this.buttonReleaseMemory = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControlMainForm.SuspendLayout();
            this.tabPageDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).BeginInit();
            this.tabPagePoolSettings.SuspendLayout();
            this.groupBoxWalletAddresses.SuspendLayout();
            this.groupBoxPoolParameters.SuspendLayout();
            this.groupBoxPoolPriorities.SuspendLayout();
            this.groupBoxCoinsToMine.SuspendLayout();
            this.tabPageCustomPoolSettings.SuspendLayout();
            this.groupBoxCustmPool1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool1SecondaryPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool1Port)).BeginInit();
            this.groupBoxCustmPool2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool2SecondaryPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool2Port)).BeginInit();
            this.groupBoxCustmPool3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool3SecondaryPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool3Port)).BeginInit();
            this.groupBoxCustmPool0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool0SecondaryPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool0Port)).BeginInit();
            this.tabPageDeviceSettings.SuspendLayout();
            this.groupBoxHadrwareAcceleration.SuspendLayout();
            this.tabPageAPI.SuspendLayout();
            this.groupBoxAPIIPRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAPIPort)).BeginInit();
            this.tabPageMiscSettings.SuspendLayout();
            this.groupBoxOpenCLBinaries.SuspendLayout();
            this.groupBoxUserSettings.SuspendLayout();
            this.groupBoxSettingsBackups.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxAutomation.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.statusStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainForm
            // 
            this.tabControlMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMainForm.Controls.Add(this.tabPageDashboard);
            this.tabControlMainForm.Controls.Add(this.tabPagePoolSettings);
            this.tabControlMainForm.Controls.Add(this.tabPageCustomPoolSettings);
            this.tabControlMainForm.Controls.Add(this.tabPageDeviceSettings);
            this.tabControlMainForm.Controls.Add(this.tabPageAPI);
            this.tabControlMainForm.Controls.Add(this.tabPageMiscSettings);
            this.tabControlMainForm.Controls.Add(this.tabPageLog);
            this.tabControlMainForm.Controls.Add(this.tabPageAbout);
            this.tabControlMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlMainForm.Location = new System.Drawing.Point(11, 8);
            this.tabControlMainForm.Name = "tabControlMainForm";
            this.tabControlMainForm.SelectedIndex = 0;
            this.tabControlMainForm.Size = new System.Drawing.Size(989, 559);
            this.tabControlMainForm.TabIndex = 0;
            this.tabControlMainForm.SelectedIndexChanged += new System.EventHandler(this.tabControlMainForm_SelectedIndexChanged);
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Controls.Add(this.splitContainer1);
            this.tabPageDashboard.Controls.Add(this.groupBox3);
            this.tabPageDashboard.Controls.Add(this.groupBox4);
            this.tabPageDashboard.Controls.Add(this.dataGridViewDevices);
            this.tabPageDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Size = new System.Drawing.Size(981, 533);
            this.tabPageDashboard.TabIndex = 2;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.splitContainer1.Location = new System.Drawing.Point(343, 8);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cartesianChartCPUUsage);
            this.splitContainer1.Panel1.Controls.Add(this.cartesianChartPower);
            this.splitContainer1.Panel1.Controls.Add(this.cartesianChartTemperature);
            this.splitContainer1.Panel1.Controls.Add(this.cartesianChartDeviceActivity);
            this.splitContainer1.Panel1.Controls.Add(this.cartesianChartFanSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxGraphType);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxGraphCoverage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cartesianChartShare1Month);
            this.splitContainer1.Panel2.Controls.Add(this.cartesianChartShare1Day);
            this.splitContainer1.Panel2.Controls.Add(this.cartesianChartShare1Hour);
            this.splitContainer1.Panel2.Controls.Add(this.cartesianChartShare1Minute);
            this.splitContainer1.Panel2.Controls.Add(this.cartesianChartSpeedSecondaryAlgorithm);
            this.splitContainer1.Panel2.Controls.Add(this.cartesianChartSpeedPrimaryAlgorithm);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSecondGraphType);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSecondGraphCoverage);
            this.splitContainer1.Size = new System.Drawing.Size(626, 276);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 2;
            // 
            // cartesianChartCPUUsage
            // 
            this.cartesianChartCPUUsage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartCPUUsage.BackColor = System.Drawing.Color.Black;
            this.cartesianChartCPUUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartCPUUsage.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartCPUUsage.Name = "cartesianChartCPUUsage";
            this.cartesianChartCPUUsage.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartCPUUsage.TabIndex = 154;
            this.cartesianChartCPUUsage.Text = "cartesianChart1";
            // 
            // cartesianChartPower
            // 
            this.cartesianChartPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartPower.BackColor = System.Drawing.Color.Black;
            this.cartesianChartPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartPower.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartPower.Name = "cartesianChartPower";
            this.cartesianChartPower.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartPower.TabIndex = 154;
            this.cartesianChartPower.Visible = false;
            // 
            // cartesianChartTemperature
            // 
            this.cartesianChartTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartTemperature.BackColor = System.Drawing.Color.Black;
            this.cartesianChartTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartTemperature.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartTemperature.Name = "cartesianChartTemperature";
            this.cartesianChartTemperature.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartTemperature.TabIndex = 145;
            this.cartesianChartTemperature.Text = "cartesianChart1";
            // 
            // cartesianChartDeviceActivity
            // 
            this.cartesianChartDeviceActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartDeviceActivity.BackColor = System.Drawing.Color.Black;
            this.cartesianChartDeviceActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartDeviceActivity.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartDeviceActivity.Name = "cartesianChartDeviceActivity";
            this.cartesianChartDeviceActivity.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartDeviceActivity.TabIndex = 153;
            // 
            // cartesianChartFanSpeed
            // 
            this.cartesianChartFanSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartFanSpeed.BackColor = System.Drawing.Color.Black;
            this.cartesianChartFanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartFanSpeed.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartFanSpeed.Name = "cartesianChartFanSpeed";
            this.cartesianChartFanSpeed.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartFanSpeed.TabIndex = 152;
            this.cartesianChartFanSpeed.Text = "cartesianChart1";
            // 
            // comboBoxGraphType
            // 
            this.comboBoxGraphType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGraphType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGraphType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxGraphType.FormattingEnabled = true;
            this.comboBoxGraphType.Items.AddRange(new object[] {
            "Temperature",
            "Fan Speed",
            "Activity",
            "CPU Usage"});
            this.comboBoxGraphType.Location = new System.Drawing.Point(0, 3);
            this.comboBoxGraphType.Name = "comboBoxGraphType";
            this.comboBoxGraphType.Size = new System.Drawing.Size(225, 21);
            this.comboBoxGraphType.TabIndex = 0;
            this.comboBoxGraphType.Tag = "parameter:graph_type";
            this.comboBoxGraphType.SelectedIndexChanged += new System.EventHandler(this.comboBoxGraphType_SelectedIndexChanged);
            // 
            // comboBoxGraphCoverage
            // 
            this.comboBoxGraphCoverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGraphCoverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGraphCoverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxGraphCoverage.FormattingEnabled = true;
            this.comboBoxGraphCoverage.Items.AddRange(new object[] {
            "1 Minute",
            "1 Hour",
            "1 Day",
            "1 Month"});
            this.comboBoxGraphCoverage.Location = new System.Drawing.Point(233, 3);
            this.comboBoxGraphCoverage.Name = "comboBoxGraphCoverage";
            this.comboBoxGraphCoverage.Size = new System.Drawing.Size(78, 21);
            this.comboBoxGraphCoverage.TabIndex = 1;
            this.comboBoxGraphCoverage.Tag = "parameter:graph_coverage";
            this.comboBoxGraphCoverage.SelectedIndexChanged += new System.EventHandler(this.comboBoxGraphCoverage_SelectedIndexChanged);
            // 
            // cartesianChartShare1Month
            // 
            this.cartesianChartShare1Month.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartShare1Month.BackColor = System.Drawing.Color.Black;
            this.cartesianChartShare1Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartShare1Month.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartShare1Month.Name = "cartesianChartShare1Month";
            this.cartesianChartShare1Month.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartShare1Month.TabIndex = 157;
            this.cartesianChartShare1Month.Text = "cartesianChart4";
            // 
            // cartesianChartShare1Day
            // 
            this.cartesianChartShare1Day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartShare1Day.BackColor = System.Drawing.Color.Black;
            this.cartesianChartShare1Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartShare1Day.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartShare1Day.Name = "cartesianChartShare1Day";
            this.cartesianChartShare1Day.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartShare1Day.TabIndex = 156;
            this.cartesianChartShare1Day.Text = "cartesianChart3";
            // 
            // cartesianChartShare1Hour
            // 
            this.cartesianChartShare1Hour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartShare1Hour.BackColor = System.Drawing.Color.Black;
            this.cartesianChartShare1Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartShare1Hour.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartShare1Hour.Name = "cartesianChartShare1Hour";
            this.cartesianChartShare1Hour.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartShare1Hour.TabIndex = 155;
            this.cartesianChartShare1Hour.Text = "cartesianChart2";
            // 
            // cartesianChartShare1Minute
            // 
            this.cartesianChartShare1Minute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartShare1Minute.BackColor = System.Drawing.Color.Black;
            this.cartesianChartShare1Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartShare1Minute.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartShare1Minute.Name = "cartesianChartShare1Minute";
            this.cartesianChartShare1Minute.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartShare1Minute.TabIndex = 154;
            this.cartesianChartShare1Minute.Text = "cartesianChart1";
            // 
            // cartesianChartSpeedSecondaryAlgorithm
            // 
            this.cartesianChartSpeedSecondaryAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartSpeedSecondaryAlgorithm.BackColor = System.Drawing.Color.Black;
            this.cartesianChartSpeedSecondaryAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartSpeedSecondaryAlgorithm.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartSpeedSecondaryAlgorithm.Name = "cartesianChartSpeedSecondaryAlgorithm";
            this.cartesianChartSpeedSecondaryAlgorithm.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartSpeedSecondaryAlgorithm.TabIndex = 153;
            this.cartesianChartSpeedSecondaryAlgorithm.Text = "cartesianChart1";
            // 
            // cartesianChartSpeedPrimaryAlgorithm
            // 
            this.cartesianChartSpeedPrimaryAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartSpeedPrimaryAlgorithm.BackColor = System.Drawing.Color.Black;
            this.cartesianChartSpeedPrimaryAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cartesianChartSpeedPrimaryAlgorithm.Location = new System.Drawing.Point(0, 27);
            this.cartesianChartSpeedPrimaryAlgorithm.Name = "cartesianChartSpeedPrimaryAlgorithm";
            this.cartesianChartSpeedPrimaryAlgorithm.Size = new System.Drawing.Size(311, 249);
            this.cartesianChartSpeedPrimaryAlgorithm.TabIndex = 151;
            this.cartesianChartSpeedPrimaryAlgorithm.Text = "cartesianChart1";
            // 
            // comboBoxSecondGraphType
            // 
            this.comboBoxSecondGraphType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSecondGraphType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecondGraphType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxSecondGraphType.FormattingEnabled = true;
            this.comboBoxSecondGraphType.Items.AddRange(new object[] {
            "Speed (Primary Algorithm)",
            "Speed (Secondary Algorithm)",
            "Share"});
            this.comboBoxSecondGraphType.Location = new System.Drawing.Point(0, 3);
            this.comboBoxSecondGraphType.Name = "comboBoxSecondGraphType";
            this.comboBoxSecondGraphType.Size = new System.Drawing.Size(225, 21);
            this.comboBoxSecondGraphType.TabIndex = 0;
            this.comboBoxSecondGraphType.Tag = "parameter:second_graph_type";
            this.comboBoxSecondGraphType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondGraphType_SelectedIndexChanged);
            // 
            // comboBoxSecondGraphCoverage
            // 
            this.comboBoxSecondGraphCoverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSecondGraphCoverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecondGraphCoverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxSecondGraphCoverage.FormattingEnabled = true;
            this.comboBoxSecondGraphCoverage.Items.AddRange(new object[] {
            "1 Minute",
            "1 Hour",
            "1 Day",
            "1 Month"});
            this.comboBoxSecondGraphCoverage.Location = new System.Drawing.Point(233, 3);
            this.comboBoxSecondGraphCoverage.Name = "comboBoxSecondGraphCoverage";
            this.comboBoxSecondGraphCoverage.Size = new System.Drawing.Size(78, 21);
            this.comboBoxSecondGraphCoverage.TabIndex = 1;
            this.comboBoxSecondGraphCoverage.Tag = "parameter:second_graph_coverage";
            this.comboBoxSecondGraphCoverage.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondGraphCoverage_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRestoreStockSettings);
            this.groupBox3.Controls.Add(this.buttonBoostPerformance);
            this.groupBox3.Controls.Add(this.labelElapsedTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.labelCurrentSpeed);
            this.groupBox3.Controls.Add(this.labelCurrentSecondaryPool);
            this.groupBox3.Controls.Add(this.label70);
            this.groupBox3.Controls.Add(this.labelCurrentPool);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(11, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 136);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compute";
            // 
            // buttonRestoreStockSettings
            // 
            this.buttonRestoreStockSettings.Location = new System.Drawing.Point(167, 107);
            this.buttonRestoreStockSettings.Name = "buttonRestoreStockSettings";
            this.buttonRestoreStockSettings.Size = new System.Drawing.Size(153, 23);
            this.buttonRestoreStockSettings.TabIndex = 1;
            this.buttonRestoreStockSettings.Text = "Restore Stock Settings";
            this.buttonRestoreStockSettings.UseVisualStyleBackColor = true;
            this.buttonRestoreStockSettings.Click += new System.EventHandler(this.buttonRestoreStockSettings_Click);
            // 
            // buttonBoostPerformance
            // 
            this.buttonBoostPerformance.Location = new System.Drawing.Point(6, 107);
            this.buttonBoostPerformance.Name = "buttonBoostPerformance";
            this.buttonBoostPerformance.Size = new System.Drawing.Size(155, 23);
            this.buttonBoostPerformance.TabIndex = 0;
            this.buttonBoostPerformance.Text = "Boost Performance";
            this.buttonBoostPerformance.UseVisualStyleBackColor = true;
            this.buttonBoostPerformance.Click += new System.EventHandler(this.buttonBoostPerformance_Click);
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelElapsedTime.Location = new System.Drawing.Point(93, 20);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(227, 17);
            this.labelElapsedTime.TabIndex = 143;
            this.labelElapsedTime.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(5, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed(s):";
            // 
            // labelCurrentSpeed
            // 
            this.labelCurrentSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCurrentSpeed.Location = new System.Drawing.Point(93, 75);
            this.labelCurrentSpeed.Name = "labelCurrentSpeed";
            this.labelCurrentSpeed.Size = new System.Drawing.Size(227, 17);
            this.labelCurrentSpeed.TabIndex = 8;
            this.labelCurrentSpeed.Text = "-";
            // 
            // labelCurrentSecondaryPool
            // 
            this.labelCurrentSecondaryPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCurrentSecondaryPool.Location = new System.Drawing.Point(93, 55);
            this.labelCurrentSecondaryPool.Name = "labelCurrentSecondaryPool";
            this.labelCurrentSecondaryPool.Size = new System.Drawing.Size(369, 20);
            this.labelCurrentSecondaryPool.TabIndex = 148;
            this.labelCurrentSecondaryPool.Text = "-";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label70.Location = new System.Drawing.Point(5, 37);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(79, 13);
            this.label70.TabIndex = 22;
            this.label70.Text = "Current Pool(s):";
            // 
            // labelCurrentPool
            // 
            this.labelCurrentPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCurrentPool.Location = new System.Drawing.Point(93, 37);
            this.labelCurrentPool.Name = "labelCurrentPool";
            this.labelCurrentPool.Size = new System.Drawing.Size(369, 18);
            this.labelCurrentPool.TabIndex = 23;
            this.labelCurrentPool.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(5, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "Elapsed Time:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxCurrency);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.labelBalance);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.labelPriceDay);
            this.groupBox4.Controls.Add(this.labelPriceWeek);
            this.groupBox4.Controls.Add(this.labelPriceMonth);
            this.groupBox4.Location = new System.Drawing.Point(11, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 134);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profitability";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "USD",
            "JPY"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(66, 18);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(57, 21);
            this.comboBoxCurrency.TabIndex = 0;
            this.comboBoxCurrency.Tag = "parameter:currency";
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(8, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 142;
            this.label12.Text = "Currency:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estimated Profits:";
            // 
            // labelBalance
            // 
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelBalance.Location = new System.Drawing.Point(96, 102);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(158, 13);
            this.labelBalance.TabIndex = 10;
            this.labelBalance.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(8, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Balance:";
            // 
            // labelPriceDay
            // 
            this.labelPriceDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPriceDay.Location = new System.Drawing.Point(96, 48);
            this.labelPriceDay.Name = "labelPriceDay";
            this.labelPriceDay.Size = new System.Drawing.Size(232, 17);
            this.labelPriceDay.TabIndex = 16;
            this.labelPriceDay.Text = "-";
            // 
            // labelPriceWeek
            // 
            this.labelPriceWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPriceWeek.Location = new System.Drawing.Point(96, 65);
            this.labelPriceWeek.Name = "labelPriceWeek";
            this.labelPriceWeek.Size = new System.Drawing.Size(232, 17);
            this.labelPriceWeek.TabIndex = 17;
            this.labelPriceWeek.Text = "-";
            // 
            // labelPriceMonth
            // 
            this.labelPriceMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPriceMonth.Location = new System.Drawing.Point(96, 82);
            this.labelPriceMonth.Name = "labelPriceMonth";
            this.labelPriceMonth.Size = new System.Drawing.Size(232, 17);
            this.labelPriceMonth.TabIndex = 141;
            this.labelPriceMonth.Text = "-";
            // 
            // dataGridViewDevices
            // 
            this.dataGridViewDevices.AllowUserToAddRows = false;
            this.dataGridViewDevices.AllowUserToDeleteRows = false;
            this.dataGridViewDevices.AllowUserToResizeColumns = false;
            this.dataGridViewDevices.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDevices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDevices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDevices.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDevices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewDevices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enabled,
            this.id,
            this.vendor,
            this.name,
            this.speed,
            this.shares,
            this.activity,
            this.temperature,
            this.fan,
            this.power,
            this.power_limit,
            this.core_clock,
            this.core_voltage,
            this.memory_clock,
            this.memory_used,
            this.memory_reserved});
            this.dataGridViewDevices.Location = new System.Drawing.Point(11, 290);
            this.dataGridViewDevices.Name = "dataGridViewDevices";
            this.dataGridViewDevices.ReadOnly = true;
            this.dataGridViewDevices.RowHeadersVisible = false;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGridViewDevices.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewDevices.Size = new System.Drawing.Size(958, 233);
            this.dataGridViewDevices.TabIndex = 3;
            this.dataGridViewDevices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevices_CellContentClick);
            this.dataGridViewDevices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevices_CellValueChanged);
            this.dataGridViewDevices.SelectionChanged += new System.EventHandler(this.dataGridViewDevices_SelectionChanged);
            // 
            // enabled
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.NullValue = false;
            this.enabled.DefaultCellStyle = dataGridViewCellStyle17;
            this.enabled.FalseValue = "";
            this.enabled.FillWeight = 50F;
            this.enabled.HeaderText = "";
            this.enabled.Name = "enabled";
            this.enabled.ReadOnly = true;
            this.enabled.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.enabled.TrueValue = "";
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vendor
            // 
            this.vendor.FillWeight = 80F;
            this.vendor.HeaderText = "Vendor";
            this.vendor.Name = "vendor";
            this.vendor.ReadOnly = true;
            this.vendor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.FillWeight = 200F;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // speed
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.speed.DefaultCellStyle = dataGridViewCellStyle18;
            this.speed.FillWeight = 180F;
            this.speed.HeaderText = "Speed(s)";
            this.speed.Name = "speed";
            this.speed.ReadOnly = true;
            this.speed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.speed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // shares
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.shares.DefaultCellStyle = dataGridViewCellStyle19;
            this.shares.FillWeight = 120F;
            this.shares.HeaderText = "Shares";
            this.shares.Name = "shares";
            this.shares.ReadOnly = true;
            this.shares.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.shares.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activity
            // 
            this.activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.activity.DataPropertyName = "activity";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.activity.DefaultCellStyle = dataGridViewCellStyle20;
            this.activity.FillWeight = 60F;
            this.activity.HeaderText = "Act.";
            this.activity.Name = "activity";
            this.activity.ReadOnly = true;
            this.activity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.activity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.activity.Width = 45;
            // 
            // temperature
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.temperature.DefaultCellStyle = dataGridViewCellStyle21;
            this.temperature.FillWeight = 60F;
            this.temperature.HeaderText = "Temp.";
            this.temperature.Name = "temperature";
            this.temperature.ReadOnly = true;
            this.temperature.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.temperature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fan
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.fan.DefaultCellStyle = dataGridViewCellStyle22;
            this.fan.FillWeight = 60F;
            this.fan.HeaderText = "Fan";
            this.fan.Name = "fan";
            this.fan.ReadOnly = true;
            this.fan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // power
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.power.DefaultCellStyle = dataGridViewCellStyle23;
            this.power.FillWeight = 80F;
            this.power.HeaderText = "Power";
            this.power.Name = "power";
            this.power.ReadOnly = true;
            this.power.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.power.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // power_limit
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.power_limit.DefaultCellStyle = dataGridViewCellStyle24;
            this.power_limit.FillWeight = 60F;
            this.power_limit.HeaderText = "";
            this.power_limit.Name = "power_limit";
            this.power_limit.ReadOnly = true;
            this.power_limit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.power_limit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // core_clock
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.core_clock.DefaultCellStyle = dataGridViewCellStyle25;
            this.core_clock.HeaderText = "Core";
            this.core_clock.Name = "core_clock";
            this.core_clock.ReadOnly = true;
            this.core_clock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.core_clock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // core_voltage
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.core_voltage.DefaultCellStyle = dataGridViewCellStyle26;
            this.core_voltage.HeaderText = "";
            this.core_voltage.Name = "core_voltage";
            this.core_voltage.ReadOnly = true;
            this.core_voltage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.core_voltage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // memory_clock
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.memory_clock.DefaultCellStyle = dataGridViewCellStyle27;
            this.memory_clock.HeaderText = "Memory";
            this.memory_clock.Name = "memory_clock";
            this.memory_clock.ReadOnly = true;
            this.memory_clock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.memory_clock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // memory_used
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.memory_used.DefaultCellStyle = dataGridViewCellStyle28;
            this.memory_used.FillWeight = 80F;
            this.memory_used.HeaderText = "(Used)";
            this.memory_used.Name = "memory_used";
            this.memory_used.ReadOnly = true;
            // 
            // memory_reserved
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.memory_reserved.DefaultCellStyle = dataGridViewCellStyle29;
            this.memory_reserved.FillWeight = 80F;
            this.memory_reserved.HeaderText = "(Rsvd.)";
            this.memory_reserved.Name = "memory_reserved";
            this.memory_reserved.ReadOnly = true;
            this.memory_reserved.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPagePoolSettings
            // 
            this.tabPagePoolSettings.Controls.Add(this.groupBoxWalletAddresses);
            this.tabPagePoolSettings.Controls.Add(this.groupBoxPoolParameters);
            this.tabPagePoolSettings.Controls.Add(this.groupBoxPoolPriorities);
            this.tabPagePoolSettings.Controls.Add(this.groupBoxCoinsToMine);
            this.tabPagePoolSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPagePoolSettings.Name = "tabPagePoolSettings";
            this.tabPagePoolSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePoolSettings.Size = new System.Drawing.Size(981, 533);
            this.tabPagePoolSettings.TabIndex = 0;
            this.tabPagePoolSettings.Text = "Default Pools";
            this.tabPagePoolSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxWalletAddresses
            // 
            this.groupBoxWalletAddresses.Controls.Add(this.label28);
            this.groupBoxWalletAddresses.Controls.Add(this.buttonLbryBalance);
            this.groupBoxWalletAddresses.Controls.Add(this.textBoxLbryAddress);
            this.groupBoxWalletAddresses.Controls.Add(this.textBoxPascalAddress);
            this.groupBoxWalletAddresses.Controls.Add(this.label27);
            this.groupBoxWalletAddresses.Controls.Add(this.buttonViewPascalBalance);
            this.groupBoxWalletAddresses.Controls.Add(this.textBoxBitcoinAddress);
            this.groupBoxWalletAddresses.Controls.Add(this.button5);
            this.groupBoxWalletAddresses.Controls.Add(this.label13);
            this.groupBoxWalletAddresses.Controls.Add(this.label14);
            this.groupBoxWalletAddresses.Controls.Add(this.textBoxEthereumAddress);
            this.groupBoxWalletAddresses.Controls.Add(this.label15);
            this.groupBoxWalletAddresses.Controls.Add(this.textBoxMoneroAddress);
            this.groupBoxWalletAddresses.Controls.Add(this.buttonMoneroBalance);
            this.groupBoxWalletAddresses.Controls.Add(this.label16);
            this.groupBoxWalletAddresses.Controls.Add(this.buttonEthereumBalance);
            this.groupBoxWalletAddresses.Controls.Add(this.textBoxZcashAddress);
            this.groupBoxWalletAddresses.Controls.Add(this.buttonViewBalancesAtNiceHash);
            this.groupBoxWalletAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWalletAddresses.Location = new System.Drawing.Point(6, 176);
            this.groupBoxWalletAddresses.Name = "groupBoxWalletAddresses";
            this.groupBoxWalletAddresses.Size = new System.Drawing.Size(708, 128);
            this.groupBoxWalletAddresses.TabIndex = 2;
            this.groupBoxWalletAddresses.TabStop = false;
            this.groupBoxWalletAddresses.Text = "Wallet Addresses";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label28.Location = new System.Drawing.Point(357, 50);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 13);
            this.label28.TabIndex = 23;
            this.label28.Text = "Lbry (LBC)";
            // 
            // buttonLbryBalance
            // 
            this.buttonLbryBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonLbryBalance.Location = new System.Drawing.Point(633, 48);
            this.buttonLbryBalance.Name = "buttonLbryBalance";
            this.buttonLbryBalance.Size = new System.Drawing.Size(62, 20);
            this.buttonLbryBalance.TabIndex = 11;
            this.buttonLbryBalance.Text = "Balance";
            this.buttonLbryBalance.UseVisualStyleBackColor = true;
            // 
            // textBoxLbryAddress
            // 
            this.textBoxLbryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxLbryAddress.Location = new System.Drawing.Point(448, 47);
            this.textBoxLbryAddress.MaxLength = 512;
            this.textBoxLbryAddress.Name = "textBoxLbryAddress";
            this.textBoxLbryAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxLbryAddress.TabIndex = 10;
            this.textBoxLbryAddress.Tag = "parameter:lbry_address";
            this.textBoxLbryAddress.TextChanged += new System.EventHandler(this.textBoxLbryAddress_TextChanged);
            // 
            // textBoxPascalAddress
            // 
            this.textBoxPascalAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxPascalAddress.Location = new System.Drawing.Point(448, 20);
            this.textBoxPascalAddress.MaxLength = 512;
            this.textBoxPascalAddress.Name = "textBoxPascalAddress";
            this.textBoxPascalAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxPascalAddress.TabIndex = 8;
            this.textBoxPascalAddress.Tag = "parameter:pascal_address";
            this.textBoxPascalAddress.TextChanged += new System.EventHandler(this.textBoxPascalAddress_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label27.Location = new System.Drawing.Point(357, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 13);
            this.label27.TabIndex = 18;
            this.label27.Text = "Pascal (PASC):";
            // 
            // buttonViewPascalBalance
            // 
            this.buttonViewPascalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonViewPascalBalance.Location = new System.Drawing.Point(633, 20);
            this.buttonViewPascalBalance.Name = "buttonViewPascalBalance";
            this.buttonViewPascalBalance.Size = new System.Drawing.Size(62, 20);
            this.buttonViewPascalBalance.TabIndex = 9;
            this.buttonViewPascalBalance.Text = "Balance";
            this.buttonViewPascalBalance.UseVisualStyleBackColor = true;
            // 
            // textBoxBitcoinAddress
            // 
            this.textBoxBitcoinAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxBitcoinAddress.Location = new System.Drawing.Point(100, 20);
            this.textBoxBitcoinAddress.MaxLength = 512;
            this.textBoxBitcoinAddress.Name = "textBoxBitcoinAddress";
            this.textBoxBitcoinAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxBitcoinAddress.TabIndex = 0;
            this.textBoxBitcoinAddress.Tag = "parameter:bitcoin_address";
            this.textBoxBitcoinAddress.TextChanged += new System.EventHandler(this.textBoxBitcoinAddress_TextChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button5.Location = new System.Drawing.Point(285, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 20);
            this.button5.TabIndex = 7;
            this.button5.Text = "Balance";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(9, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Bitcoin (BTC):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(9, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Ethereum (ETH):";
            // 
            // textBoxEthereumAddress
            // 
            this.textBoxEthereumAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEthereumAddress.Location = new System.Drawing.Point(100, 46);
            this.textBoxEthereumAddress.MaxLength = 512;
            this.textBoxEthereumAddress.Name = "textBoxEthereumAddress";
            this.textBoxEthereumAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxEthereumAddress.TabIndex = 2;
            this.textBoxEthereumAddress.Tag = "parameter:ethereum_address";
            this.textBoxEthereumAddress.TextChanged += new System.EventHandler(this.textBoxEthereumAddress_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.Location = new System.Drawing.Point(9, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Monero (XMR):";
            // 
            // textBoxMoneroAddress
            // 
            this.textBoxMoneroAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxMoneroAddress.Location = new System.Drawing.Point(100, 72);
            this.textBoxMoneroAddress.MaxLength = 512;
            this.textBoxMoneroAddress.Name = "textBoxMoneroAddress";
            this.textBoxMoneroAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxMoneroAddress.TabIndex = 4;
            this.textBoxMoneroAddress.Tag = "parameter:monero_address";
            this.textBoxMoneroAddress.TextChanged += new System.EventHandler(this.textBoxMoneroAddress_TextChanged);
            // 
            // buttonMoneroBalance
            // 
            this.buttonMoneroBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonMoneroBalance.Location = new System.Drawing.Point(285, 73);
            this.buttonMoneroBalance.Name = "buttonMoneroBalance";
            this.buttonMoneroBalance.Size = new System.Drawing.Size(62, 20);
            this.buttonMoneroBalance.TabIndex = 5;
            this.buttonMoneroBalance.Text = "Balance";
            this.buttonMoneroBalance.UseVisualStyleBackColor = true;
            this.buttonMoneroBalance.Click += new System.EventHandler(this.buttonMoneroBalance_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.Location = new System.Drawing.Point(9, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Zcash (ZEC):";
            this.label16.Visible = false;
            // 
            // buttonEthereumBalance
            // 
            this.buttonEthereumBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonEthereumBalance.Location = new System.Drawing.Point(285, 46);
            this.buttonEthereumBalance.Name = "buttonEthereumBalance";
            this.buttonEthereumBalance.Size = new System.Drawing.Size(62, 20);
            this.buttonEthereumBalance.TabIndex = 3;
            this.buttonEthereumBalance.Text = "Balance";
            this.buttonEthereumBalance.UseVisualStyleBackColor = true;
            this.buttonEthereumBalance.Click += new System.EventHandler(this.buttonEthereumBalance_Click);
            // 
            // textBoxZcashAddress
            // 
            this.textBoxZcashAddress.Enabled = false;
            this.textBoxZcashAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxZcashAddress.Location = new System.Drawing.Point(100, 98);
            this.textBoxZcashAddress.MaxLength = 512;
            this.textBoxZcashAddress.Name = "textBoxZcashAddress";
            this.textBoxZcashAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxZcashAddress.TabIndex = 6;
            this.textBoxZcashAddress.Tag = "parameter:zcash_address";
            this.textBoxZcashAddress.Visible = false;
            this.textBoxZcashAddress.TextChanged += new System.EventHandler(this.textBoxZcashAddress_TextChanged);
            // 
            // buttonViewBalancesAtNiceHash
            // 
            this.buttonViewBalancesAtNiceHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonViewBalancesAtNiceHash.Location = new System.Drawing.Point(285, 20);
            this.buttonViewBalancesAtNiceHash.Name = "buttonViewBalancesAtNiceHash";
            this.buttonViewBalancesAtNiceHash.Size = new System.Drawing.Size(62, 20);
            this.buttonViewBalancesAtNiceHash.TabIndex = 1;
            this.buttonViewBalancesAtNiceHash.Text = "Balance";
            this.buttonViewBalancesAtNiceHash.UseVisualStyleBackColor = true;
            this.buttonViewBalancesAtNiceHash.Click += new System.EventHandler(this.buttonViewBalancesAtNiceHash_Click);
            // 
            // groupBoxPoolParameters
            // 
            this.groupBoxPoolParameters.Controls.Add(this.textBoxRigID);
            this.groupBoxPoolParameters.Controls.Add(this.label1);
            this.groupBoxPoolParameters.Controls.Add(this.labelEmail);
            this.groupBoxPoolParameters.Controls.Add(this.textBoxEmail);
            this.groupBoxPoolParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPoolParameters.Location = new System.Drawing.Point(6, 310);
            this.groupBoxPoolParameters.Name = "groupBoxPoolParameters";
            this.groupBoxPoolParameters.Size = new System.Drawing.Size(414, 78);
            this.groupBoxPoolParameters.TabIndex = 3;
            this.groupBoxPoolParameters.TabStop = false;
            this.groupBoxPoolParameters.Text = "Pool Parameters";
            // 
            // textBoxRigID
            // 
            this.textBoxRigID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRigID.Location = new System.Drawing.Point(116, 20);
            this.textBoxRigID.Name = "textBoxRigID";
            this.textBoxRigID.Size = new System.Drawing.Size(285, 20);
            this.textBoxRigID.TabIndex = 0;
            this.textBoxRigID.Tag = "parameter:pool_rig_id";
            this.textBoxRigID.TextChanged += new System.EventHandler(this.textBoxRigID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Rig ID (optional):";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(8, 48);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(81, 13);
            this.labelEmail.TabIndex = 28;
            this.labelEmail.Text = "Email (optional):";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(116, 46);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(285, 20);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.Tag = "parameter:pool_email";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // groupBoxPoolPriorities
            // 
            this.groupBoxPoolPriorities.Controls.Add(this.buttonPoolPrioritiesDown);
            this.groupBoxPoolPriorities.Controls.Add(this.buttonPoolPrioritiesUp);
            this.groupBoxPoolPriorities.Controls.Add(this.listBoxPoolPriorities);
            this.groupBoxPoolPriorities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPoolPriorities.Location = new System.Drawing.Point(547, 7);
            this.groupBoxPoolPriorities.Name = "groupBoxPoolPriorities";
            this.groupBoxPoolPriorities.Size = new System.Drawing.Size(167, 164);
            this.groupBoxPoolPriorities.TabIndex = 1;
            this.groupBoxPoolPriorities.TabStop = false;
            this.groupBoxPoolPriorities.Text = "Pool Priorities";
            // 
            // buttonPoolPrioritiesDown
            // 
            this.buttonPoolPrioritiesDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonPoolPrioritiesDown.Location = new System.Drawing.Point(109, 48);
            this.buttonPoolPrioritiesDown.Name = "buttonPoolPrioritiesDown";
            this.buttonPoolPrioritiesDown.Size = new System.Drawing.Size(51, 23);
            this.buttonPoolPrioritiesDown.TabIndex = 2;
            this.buttonPoolPrioritiesDown.Text = "Down";
            this.buttonPoolPrioritiesDown.UseVisualStyleBackColor = true;
            this.buttonPoolPrioritiesDown.Click += new System.EventHandler(this.buttonPoolPrioritiesDown_Click);
            // 
            // buttonPoolPrioritiesUp
            // 
            this.buttonPoolPrioritiesUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonPoolPrioritiesUp.Location = new System.Drawing.Point(109, 20);
            this.buttonPoolPrioritiesUp.Name = "buttonPoolPrioritiesUp";
            this.buttonPoolPrioritiesUp.Size = new System.Drawing.Size(51, 23);
            this.buttonPoolPrioritiesUp.TabIndex = 1;
            this.buttonPoolPrioritiesUp.Text = "Up";
            this.buttonPoolPrioritiesUp.UseVisualStyleBackColor = true;
            this.buttonPoolPrioritiesUp.Click += new System.EventHandler(this.buttonPoolPrioritiesUp_Click);
            // 
            // listBoxPoolPriorities
            // 
            this.listBoxPoolPriorities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listBoxPoolPriorities.FormattingEnabled = true;
            this.listBoxPoolPriorities.Items.AddRange(new object[] {
            "NiceHash",
            "zpool",
            "ethermine.org",
            "ethpool.org",
            "Nanopool",
            "DwarfPool",
            "mineXMR.com"});
            this.listBoxPoolPriorities.Location = new System.Drawing.Point(6, 20);
            this.listBoxPoolPriorities.Name = "listBoxPoolPriorities";
            this.listBoxPoolPriorities.Size = new System.Drawing.Size(97, 134);
            this.listBoxPoolPriorities.TabIndex = 0;
            this.listBoxPoolPriorities.SelectedIndexChanged += new System.EventHandler(this.listBoxPoolPriorities_SelectedIndexChanged);
            // 
            // groupBoxCoinsToMine
            // 
            this.groupBoxCoinsToMine.Controls.Add(this.radioButtonMonacoin);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButtonFeathercoin);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButtonPascal);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButtonLbry);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButton4);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButton3);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButtonEthereumPascal);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButton1);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButtonZcash);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButtonMonero);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButtonEthereum);
            this.groupBoxCoinsToMine.Controls.Add(this.radioButtonMostProfitable);
            this.groupBoxCoinsToMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCoinsToMine.Location = new System.Drawing.Point(3, 7);
            this.groupBoxCoinsToMine.Name = "groupBoxCoinsToMine";
            this.groupBoxCoinsToMine.Size = new System.Drawing.Size(535, 167);
            this.groupBoxCoinsToMine.TabIndex = 0;
            this.groupBoxCoinsToMine.TabStop = false;
            this.groupBoxCoinsToMine.Text = "Coin(s) to Mine";
            // 
            // radioButtonMonacoin
            // 
            this.radioButtonMonacoin.AutoSize = true;
            this.radioButtonMonacoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonMonacoin.Location = new System.Drawing.Point(222, 111);
            this.radioButtonMonacoin.Name = "radioButtonMonacoin";
            this.radioButtonMonacoin.Size = new System.Drawing.Size(72, 17);
            this.radioButtonMonacoin.TabIndex = 10;
            this.radioButtonMonacoin.Text = "Monacoin";
            this.radioButtonMonacoin.UseVisualStyleBackColor = true;
            this.radioButtonMonacoin.CheckedChanged += new System.EventHandler(this.radioButtonMonacoin_CheckedChanged);
            // 
            // radioButtonFeathercoin
            // 
            this.radioButtonFeathercoin.AutoSize = true;
            this.radioButtonFeathercoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonFeathercoin.Location = new System.Drawing.Point(222, 88);
            this.radioButtonFeathercoin.Name = "radioButtonFeathercoin";
            this.radioButtonFeathercoin.Size = new System.Drawing.Size(81, 17);
            this.radioButtonFeathercoin.TabIndex = 9;
            this.radioButtonFeathercoin.Text = "Feathercoin";
            this.radioButtonFeathercoin.UseVisualStyleBackColor = true;
            this.radioButtonFeathercoin.CheckedChanged += new System.EventHandler(this.radioButtonFeathercoin_CheckedChanged);
            // 
            // radioButtonPascal
            // 
            this.radioButtonPascal.AutoSize = true;
            this.radioButtonPascal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonPascal.Location = new System.Drawing.Point(222, 65);
            this.radioButtonPascal.Name = "radioButtonPascal";
            this.radioButtonPascal.Size = new System.Drawing.Size(57, 17);
            this.radioButtonPascal.TabIndex = 8;
            this.radioButtonPascal.Text = "Pascal";
            this.radioButtonPascal.UseVisualStyleBackColor = true;
            this.radioButtonPascal.CheckedChanged += new System.EventHandler(this.radioButtonPascal_CheckedChanged);
            // 
            // radioButtonLbry
            // 
            this.radioButtonLbry.AutoSize = true;
            this.radioButtonLbry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonLbry.Location = new System.Drawing.Point(222, 42);
            this.radioButtonLbry.Name = "radioButtonLbry";
            this.radioButtonLbry.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLbry.TabIndex = 7;
            this.radioButtonLbry.Text = "Lbry";
            this.radioButtonLbry.UseVisualStyleBackColor = true;
            this.radioButtonLbry.CheckedChanged += new System.EventHandler(this.radioButtonLbry_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButton4.Location = new System.Drawing.Point(106, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Ethereum/Decred";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButton3.Location = new System.Drawing.Point(106, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Ethereum/Sia";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonEthereumPascal
            // 
            this.radioButtonEthereumPascal.AutoSize = true;
            this.radioButtonEthereumPascal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonEthereumPascal.Location = new System.Drawing.Point(106, 111);
            this.radioButtonEthereumPascal.Name = "radioButtonEthereumPascal";
            this.radioButtonEthereumPascal.Size = new System.Drawing.Size(107, 17);
            this.radioButtonEthereumPascal.TabIndex = 5;
            this.radioButtonEthereumPascal.Text = "Ethereum/Pascal";
            this.radioButtonEthereumPascal.UseVisualStyleBackColor = true;
            this.radioButtonEthereumPascal.CheckedChanged += new System.EventHandler(this.radioButtonEthereumPascal_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButton1.Location = new System.Drawing.Point(106, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Ethereum/Lbry";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonZcash
            // 
            this.radioButtonZcash.AutoSize = true;
            this.radioButtonZcash.Enabled = false;
            this.radioButtonZcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonZcash.Location = new System.Drawing.Point(222, 134);
            this.radioButtonZcash.Name = "radioButtonZcash";
            this.radioButtonZcash.Size = new System.Drawing.Size(55, 17);
            this.radioButtonZcash.TabIndex = 11;
            this.radioButtonZcash.Text = "Zcash";
            this.radioButtonZcash.UseVisualStyleBackColor = true;
            this.radioButtonZcash.Visible = false;
            this.radioButtonZcash.CheckedChanged += new System.EventHandler(this.radioButtonZcash_CheckedChanged);
            // 
            // radioButtonMonero
            // 
            this.radioButtonMonero.AutoSize = true;
            this.radioButtonMonero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonMonero.Location = new System.Drawing.Point(222, 20);
            this.radioButtonMonero.Name = "radioButtonMonero";
            this.radioButtonMonero.Size = new System.Drawing.Size(61, 17);
            this.radioButtonMonero.TabIndex = 6;
            this.radioButtonMonero.Text = "Monero";
            this.radioButtonMonero.UseVisualStyleBackColor = true;
            this.radioButtonMonero.CheckedChanged += new System.EventHandler(this.radioButtonMonero_CheckedChanged);
            // 
            // radioButtonEthereum
            // 
            this.radioButtonEthereum.AutoSize = true;
            this.radioButtonEthereum.Checked = true;
            this.radioButtonEthereum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonEthereum.Location = new System.Drawing.Point(106, 20);
            this.radioButtonEthereum.Name = "radioButtonEthereum";
            this.radioButtonEthereum.Size = new System.Drawing.Size(70, 17);
            this.radioButtonEthereum.TabIndex = 1;
            this.radioButtonEthereum.TabStop = true;
            this.radioButtonEthereum.Text = "Ethereum";
            this.radioButtonEthereum.UseVisualStyleBackColor = true;
            this.radioButtonEthereum.CheckedChanged += new System.EventHandler(this.radioButtonEthereum_CheckedChanged);
            // 
            // radioButtonMostProfitable
            // 
            this.radioButtonMostProfitable.AutoSize = true;
            this.radioButtonMostProfitable.Enabled = false;
            this.radioButtonMostProfitable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonMostProfitable.Location = new System.Drawing.Point(6, 20);
            this.radioButtonMostProfitable.Name = "radioButtonMostProfitable";
            this.radioButtonMostProfitable.Size = new System.Drawing.Size(94, 17);
            this.radioButtonMostProfitable.TabIndex = 0;
            this.radioButtonMostProfitable.Text = "Most profitable";
            this.radioButtonMostProfitable.UseVisualStyleBackColor = true;
            this.radioButtonMostProfitable.CheckedChanged += new System.EventHandler(this.radioButtonMostProfitable_CheckedChanged);
            // 
            // tabPageCustomPoolSettings
            // 
            this.tabPageCustomPoolSettings.Controls.Add(this.groupBoxCustmPool1);
            this.tabPageCustomPoolSettings.Controls.Add(this.groupBoxCustmPool2);
            this.tabPageCustomPoolSettings.Controls.Add(this.groupBoxCustmPool3);
            this.tabPageCustomPoolSettings.Controls.Add(this.groupBoxCustmPool0);
            this.tabPageCustomPoolSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomPoolSettings.Name = "tabPageCustomPoolSettings";
            this.tabPageCustomPoolSettings.Size = new System.Drawing.Size(981, 533);
            this.tabPageCustomPoolSettings.TabIndex = 6;
            this.tabPageCustomPoolSettings.Text = "Custom Pools";
            this.tabPageCustomPoolSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustmPool1
            // 
            this.groupBoxCustmPool1.Controls.Add(this.comboBoxCustomPool1SecondaryAlgorithm);
            this.groupBoxCustmPool1.Controls.Add(this.label165);
            this.groupBoxCustmPool1.Controls.Add(this.numericUpDownCustomPool1SecondaryPort);
            this.groupBoxCustmPool1.Controls.Add(this.textBoxCustomPool1SecondaryHost);
            this.groupBoxCustmPool1.Controls.Add(this.textBoxCustomPool1SecondaryPassword);
            this.groupBoxCustmPool1.Controls.Add(this.label166);
            this.groupBoxCustmPool1.Controls.Add(this.label167);
            this.groupBoxCustmPool1.Controls.Add(this.textBoxCustomPool1SecondaryLogin);
            this.groupBoxCustmPool1.Controls.Add(this.label168);
            this.groupBoxCustmPool1.Controls.Add(this.comboBoxCustomPool1Algorithm);
            this.groupBoxCustmPool1.Controls.Add(this.checkBoxCustomPool1Enable);
            this.groupBoxCustmPool1.Controls.Add(this.label151);
            this.groupBoxCustmPool1.Controls.Add(this.numericUpDownCustomPool1Port);
            this.groupBoxCustmPool1.Controls.Add(this.textBoxCustomPool1Host);
            this.groupBoxCustmPool1.Controls.Add(this.textBoxCustomPool1Password);
            this.groupBoxCustmPool1.Controls.Add(this.label152);
            this.groupBoxCustmPool1.Controls.Add(this.label153);
            this.groupBoxCustmPool1.Controls.Add(this.textBoxCustomPool1Login);
            this.groupBoxCustmPool1.Controls.Add(this.label154);
            this.groupBoxCustmPool1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustmPool1.Location = new System.Drawing.Point(3, 81);
            this.groupBoxCustmPool1.Name = "groupBoxCustmPool1";
            this.groupBoxCustmPool1.Size = new System.Drawing.Size(812, 72);
            this.groupBoxCustmPool1.TabIndex = 1;
            this.groupBoxCustmPool1.TabStop = false;
            this.groupBoxCustmPool1.Text = "Custom Pool 1";
            // 
            // comboBoxCustomPool1SecondaryAlgorithm
            // 
            this.comboBoxCustomPool1SecondaryAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomPool1SecondaryAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomPool1SecondaryAlgorithm.FormattingEnabled = true;
            this.comboBoxCustomPool1SecondaryAlgorithm.Items.AddRange(new object[] {
            "",
            "Pascal"});
            this.comboBoxCustomPool1SecondaryAlgorithm.Location = new System.Drawing.Point(71, 43);
            this.comboBoxCustomPool1SecondaryAlgorithm.Name = "comboBoxCustomPool1SecondaryAlgorithm";
            this.comboBoxCustomPool1SecondaryAlgorithm.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCustomPool1SecondaryAlgorithm.TabIndex = 6;
            this.comboBoxCustomPool1SecondaryAlgorithm.Tag = "parameter:custom_pool1_secondary_algorithm";
            this.comboBoxCustomPool1SecondaryAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomPool1SecondaryAlgorithm_SelectedIndexChanged);
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label165.Location = new System.Drawing.Point(375, 46);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(29, 13);
            this.label165.TabIndex = 53;
            this.label165.Text = "Port:";
            // 
            // numericUpDownCustomPool1SecondaryPort
            // 
            this.numericUpDownCustomPool1SecondaryPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCustomPool1SecondaryPort.Location = new System.Drawing.Point(410, 42);
            this.numericUpDownCustomPool1SecondaryPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownCustomPool1SecondaryPort.Name = "numericUpDownCustomPool1SecondaryPort";
            this.numericUpDownCustomPool1SecondaryPort.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCustomPool1SecondaryPort.TabIndex = 8;
            this.numericUpDownCustomPool1SecondaryPort.Tag = "parameter:custom_pool1_secondary_port";
            this.numericUpDownCustomPool1SecondaryPort.ValueChanged += new System.EventHandler(this.numericUpDownCustomPool1SecondaryPort_ValueChanged);
            // 
            // textBoxCustomPool1SecondaryHost
            // 
            this.textBoxCustomPool1SecondaryHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool1SecondaryHost.Location = new System.Drawing.Point(254, 43);
            this.textBoxCustomPool1SecondaryHost.Name = "textBoxCustomPool1SecondaryHost";
            this.textBoxCustomPool1SecondaryHost.Size = new System.Drawing.Size(115, 20);
            this.textBoxCustomPool1SecondaryHost.TabIndex = 7;
            this.textBoxCustomPool1SecondaryHost.Tag = "parameter:custom_pool1_secondary_host";
            this.textBoxCustomPool1SecondaryHost.TextChanged += new System.EventHandler(this.textBoxCustomPool1SecondaryHost_TextChanged);
            // 
            // textBoxCustomPool1SecondaryPassword
            // 
            this.textBoxCustomPool1SecondaryPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool1SecondaryPassword.Location = new System.Drawing.Point(692, 42);
            this.textBoxCustomPool1SecondaryPassword.Name = "textBoxCustomPool1SecondaryPassword";
            this.textBoxCustomPool1SecondaryPassword.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool1SecondaryPassword.TabIndex = 10;
            this.textBoxCustomPool1SecondaryPassword.Tag = "parameter:custom_pool1_secondary_password";
            this.textBoxCustomPool1SecondaryPassword.TextChanged += new System.EventHandler(this.textBoxCustomPool1SecondaryPassword_TextChanged);
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label166.Location = new System.Drawing.Point(216, 46);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(32, 13);
            this.label166.TabIndex = 47;
            this.label166.Text = "Host:";
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label167.Location = new System.Drawing.Point(630, 45);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(56, 13);
            this.label167.TabIndex = 51;
            this.label167.Text = "Password:";
            // 
            // textBoxCustomPool1SecondaryLogin
            // 
            this.textBoxCustomPool1SecondaryLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool1SecondaryLogin.Location = new System.Drawing.Point(510, 41);
            this.textBoxCustomPool1SecondaryLogin.Name = "textBoxCustomPool1SecondaryLogin";
            this.textBoxCustomPool1SecondaryLogin.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool1SecondaryLogin.TabIndex = 9;
            this.textBoxCustomPool1SecondaryLogin.Tag = "parameter:custom_pool1_secondary_login";
            this.textBoxCustomPool1SecondaryLogin.TextChanged += new System.EventHandler(this.textBoxCustomPool1SecondaryLogin_TextChanged);
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label168.Location = new System.Drawing.Point(468, 46);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(36, 13);
            this.label168.TabIndex = 49;
            this.label168.Text = "Login:";
            // 
            // comboBoxCustomPool1Algorithm
            // 
            this.comboBoxCustomPool1Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomPool1Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomPool1Algorithm.FormattingEnabled = true;
            this.comboBoxCustomPool1Algorithm.Items.AddRange(new object[] {
            "Ethash",
            "Ethash (NiceHash)",
            "CryptoNight",
            "CryptoNight (NiceHash)",
            "Lbry",
            "Pascal",
            "NeoScrypt",
            "Lyra2REv2"});
            this.comboBoxCustomPool1Algorithm.Location = new System.Drawing.Point(71, 16);
            this.comboBoxCustomPool1Algorithm.Name = "comboBoxCustomPool1Algorithm";
            this.comboBoxCustomPool1Algorithm.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCustomPool1Algorithm.TabIndex = 1;
            this.comboBoxCustomPool1Algorithm.Tag = "parameter:custom_pool1_algorithm";
            this.comboBoxCustomPool1Algorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomPool1Algorithm_SelectedIndexChanged);
            // 
            // checkBoxCustomPool1Enable
            // 
            this.checkBoxCustomPool1Enable.AutoSize = true;
            this.checkBoxCustomPool1Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomPool1Enable.Location = new System.Drawing.Point(6, 31);
            this.checkBoxCustomPool1Enable.Name = "checkBoxCustomPool1Enable";
            this.checkBoxCustomPool1Enable.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCustomPool1Enable.TabIndex = 0;
            this.checkBoxCustomPool1Enable.Tag = "parameter:custom_pool1_enabled";
            this.checkBoxCustomPool1Enable.Text = "Enable";
            this.checkBoxCustomPool1Enable.UseVisualStyleBackColor = true;
            this.checkBoxCustomPool1Enable.CheckedChanged += new System.EventHandler(this.checkBoxCustomPool1Enable_CheckedChanged);
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label151.Location = new System.Drawing.Point(375, 19);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(29, 13);
            this.label151.TabIndex = 42;
            this.label151.Text = "Port:";
            // 
            // numericUpDownCustomPool1Port
            // 
            this.numericUpDownCustomPool1Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCustomPool1Port.Location = new System.Drawing.Point(410, 15);
            this.numericUpDownCustomPool1Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownCustomPool1Port.Name = "numericUpDownCustomPool1Port";
            this.numericUpDownCustomPool1Port.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCustomPool1Port.TabIndex = 3;
            this.numericUpDownCustomPool1Port.Tag = "parameter:custom_pool1_port";
            this.numericUpDownCustomPool1Port.ValueChanged += new System.EventHandler(this.numericUpDownCustomPool1Port_ValueChanged);
            // 
            // textBoxCustomPool1Host
            // 
            this.textBoxCustomPool1Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool1Host.Location = new System.Drawing.Point(254, 16);
            this.textBoxCustomPool1Host.Name = "textBoxCustomPool1Host";
            this.textBoxCustomPool1Host.Size = new System.Drawing.Size(115, 20);
            this.textBoxCustomPool1Host.TabIndex = 2;
            this.textBoxCustomPool1Host.Tag = "parameter:custom_pool1_host";
            this.textBoxCustomPool1Host.TextChanged += new System.EventHandler(this.textBoxCustomPool1Host_TextChanged);
            // 
            // textBoxCustomPool1Password
            // 
            this.textBoxCustomPool1Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool1Password.Location = new System.Drawing.Point(692, 15);
            this.textBoxCustomPool1Password.Name = "textBoxCustomPool1Password";
            this.textBoxCustomPool1Password.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool1Password.TabIndex = 5;
            this.textBoxCustomPool1Password.Tag = "parameter:custom_pool1_password";
            this.textBoxCustomPool1Password.TextChanged += new System.EventHandler(this.textBoxCustomPool1Password_TextChanged);
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label152.Location = new System.Drawing.Point(216, 19);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(32, 13);
            this.label152.TabIndex = 34;
            this.label152.Text = "Host:";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label153.Location = new System.Drawing.Point(630, 17);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(56, 13);
            this.label153.TabIndex = 40;
            this.label153.Text = "Password:";
            // 
            // textBoxCustomPool1Login
            // 
            this.textBoxCustomPool1Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool1Login.Location = new System.Drawing.Point(510, 14);
            this.textBoxCustomPool1Login.Name = "textBoxCustomPool1Login";
            this.textBoxCustomPool1Login.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool1Login.TabIndex = 4;
            this.textBoxCustomPool1Login.Tag = "parameter:custom_pool1_login";
            this.textBoxCustomPool1Login.TextChanged += new System.EventHandler(this.textBoxCustomPool1Login_TextChanged);
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label154.Location = new System.Drawing.Point(468, 19);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(36, 13);
            this.label154.TabIndex = 38;
            this.label154.Text = "Login:";
            // 
            // groupBoxCustmPool2
            // 
            this.groupBoxCustmPool2.Controls.Add(this.comboBoxCustomPool2SecondaryAlgorithm);
            this.groupBoxCustmPool2.Controls.Add(this.label169);
            this.groupBoxCustmPool2.Controls.Add(this.numericUpDownCustomPool2SecondaryPort);
            this.groupBoxCustmPool2.Controls.Add(this.textBoxCustomPool2SecondaryHost);
            this.groupBoxCustmPool2.Controls.Add(this.textBoxCustomPool2SecondaryPassword);
            this.groupBoxCustmPool2.Controls.Add(this.label170);
            this.groupBoxCustmPool2.Controls.Add(this.label171);
            this.groupBoxCustmPool2.Controls.Add(this.textBoxCustomPool2SecondaryLogin);
            this.groupBoxCustmPool2.Controls.Add(this.label172);
            this.groupBoxCustmPool2.Controls.Add(this.comboBoxCustomPool2Algorithm);
            this.groupBoxCustmPool2.Controls.Add(this.checkBoxCustomPool2Enable);
            this.groupBoxCustmPool2.Controls.Add(this.label156);
            this.groupBoxCustmPool2.Controls.Add(this.numericUpDownCustomPool2Port);
            this.groupBoxCustmPool2.Controls.Add(this.textBoxCustomPool2Host);
            this.groupBoxCustmPool2.Controls.Add(this.textBoxCustomPool2Password);
            this.groupBoxCustmPool2.Controls.Add(this.label157);
            this.groupBoxCustmPool2.Controls.Add(this.label158);
            this.groupBoxCustmPool2.Controls.Add(this.textBoxCustomPool2Login);
            this.groupBoxCustmPool2.Controls.Add(this.label159);
            this.groupBoxCustmPool2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustmPool2.Location = new System.Drawing.Point(3, 159);
            this.groupBoxCustmPool2.Name = "groupBoxCustmPool2";
            this.groupBoxCustmPool2.Size = new System.Drawing.Size(812, 72);
            this.groupBoxCustmPool2.TabIndex = 2;
            this.groupBoxCustmPool2.TabStop = false;
            this.groupBoxCustmPool2.Text = "Custom Pool 2";
            // 
            // comboBoxCustomPool2SecondaryAlgorithm
            // 
            this.comboBoxCustomPool2SecondaryAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomPool2SecondaryAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomPool2SecondaryAlgorithm.FormattingEnabled = true;
            this.comboBoxCustomPool2SecondaryAlgorithm.Items.AddRange(new object[] {
            "",
            "Pascal"});
            this.comboBoxCustomPool2SecondaryAlgorithm.Location = new System.Drawing.Point(71, 43);
            this.comboBoxCustomPool2SecondaryAlgorithm.Name = "comboBoxCustomPool2SecondaryAlgorithm";
            this.comboBoxCustomPool2SecondaryAlgorithm.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCustomPool2SecondaryAlgorithm.TabIndex = 6;
            this.comboBoxCustomPool2SecondaryAlgorithm.Tag = "parameter:custom_pool2_secondary_algorithm";
            this.comboBoxCustomPool2SecondaryAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomPool2SecondaryAlgorithm_SelectedIndexChanged);
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label169.Location = new System.Drawing.Point(375, 47);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(29, 13);
            this.label169.TabIndex = 53;
            this.label169.Text = "Port:";
            // 
            // numericUpDownCustomPool2SecondaryPort
            // 
            this.numericUpDownCustomPool2SecondaryPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCustomPool2SecondaryPort.Location = new System.Drawing.Point(410, 43);
            this.numericUpDownCustomPool2SecondaryPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownCustomPool2SecondaryPort.Name = "numericUpDownCustomPool2SecondaryPort";
            this.numericUpDownCustomPool2SecondaryPort.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCustomPool2SecondaryPort.TabIndex = 8;
            this.numericUpDownCustomPool2SecondaryPort.Tag = "parameter:custom_pool2_secondary_port";
            this.numericUpDownCustomPool2SecondaryPort.ValueChanged += new System.EventHandler(this.numericUpDownCustomPool2SecondaryPort_ValueChanged);
            // 
            // textBoxCustomPool2SecondaryHost
            // 
            this.textBoxCustomPool2SecondaryHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool2SecondaryHost.Location = new System.Drawing.Point(254, 43);
            this.textBoxCustomPool2SecondaryHost.Name = "textBoxCustomPool2SecondaryHost";
            this.textBoxCustomPool2SecondaryHost.Size = new System.Drawing.Size(115, 20);
            this.textBoxCustomPool2SecondaryHost.TabIndex = 7;
            this.textBoxCustomPool2SecondaryHost.Tag = "parameter:custom_pool2_secondary_host";
            this.textBoxCustomPool2SecondaryHost.TextChanged += new System.EventHandler(this.textBoxCustomPool2SecondaryHost_TextChanged);
            // 
            // textBoxCustomPool2SecondaryPassword
            // 
            this.textBoxCustomPool2SecondaryPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool2SecondaryPassword.Location = new System.Drawing.Point(692, 43);
            this.textBoxCustomPool2SecondaryPassword.Name = "textBoxCustomPool2SecondaryPassword";
            this.textBoxCustomPool2SecondaryPassword.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool2SecondaryPassword.TabIndex = 10;
            this.textBoxCustomPool2SecondaryPassword.Tag = "parameter:custom_pool2_secondary_password";
            this.textBoxCustomPool2SecondaryPassword.TextChanged += new System.EventHandler(this.textBoxCustomPool2SecondaryPassword_TextChanged);
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label170.Location = new System.Drawing.Point(216, 47);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(32, 13);
            this.label170.TabIndex = 47;
            this.label170.Text = "Host:";
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label171.Location = new System.Drawing.Point(630, 47);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(56, 13);
            this.label171.TabIndex = 51;
            this.label171.Text = "Password:";
            // 
            // textBoxCustomPool2SecondaryLogin
            // 
            this.textBoxCustomPool2SecondaryLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool2SecondaryLogin.Location = new System.Drawing.Point(510, 43);
            this.textBoxCustomPool2SecondaryLogin.Name = "textBoxCustomPool2SecondaryLogin";
            this.textBoxCustomPool2SecondaryLogin.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool2SecondaryLogin.TabIndex = 9;
            this.textBoxCustomPool2SecondaryLogin.Tag = "parameter:custom_pool2_secondary_login";
            this.textBoxCustomPool2SecondaryLogin.TextChanged += new System.EventHandler(this.textBoxCustomPool2SecondaryLogin_TextChanged);
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label172.Location = new System.Drawing.Point(468, 47);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(36, 13);
            this.label172.TabIndex = 49;
            this.label172.Text = "Login:";
            // 
            // comboBoxCustomPool2Algorithm
            // 
            this.comboBoxCustomPool2Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomPool2Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomPool2Algorithm.FormattingEnabled = true;
            this.comboBoxCustomPool2Algorithm.Items.AddRange(new object[] {
            "Ethash",
            "Ethash (NiceHash)",
            "CryptoNight",
            "CryptoNight (NiceHash)",
            "Lbry",
            "Pascal",
            "NeoScrypt",
            "Lyra2REv2"});
            this.comboBoxCustomPool2Algorithm.Location = new System.Drawing.Point(71, 16);
            this.comboBoxCustomPool2Algorithm.Name = "comboBoxCustomPool2Algorithm";
            this.comboBoxCustomPool2Algorithm.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCustomPool2Algorithm.TabIndex = 1;
            this.comboBoxCustomPool2Algorithm.Tag = "parameter:custom_pool2_algorithm";
            this.comboBoxCustomPool2Algorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomPool2Algorithm_SelectedIndexChanged);
            // 
            // checkBoxCustomPool2Enable
            // 
            this.checkBoxCustomPool2Enable.AutoSize = true;
            this.checkBoxCustomPool2Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomPool2Enable.Location = new System.Drawing.Point(6, 31);
            this.checkBoxCustomPool2Enable.Name = "checkBoxCustomPool2Enable";
            this.checkBoxCustomPool2Enable.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCustomPool2Enable.TabIndex = 0;
            this.checkBoxCustomPool2Enable.Tag = "parameter:custom_pool2_enabled";
            this.checkBoxCustomPool2Enable.Text = "Enable";
            this.checkBoxCustomPool2Enable.UseVisualStyleBackColor = true;
            this.checkBoxCustomPool2Enable.CheckedChanged += new System.EventHandler(this.checkBoxCustomPool2Enable_CheckedChanged);
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label156.Location = new System.Drawing.Point(375, 21);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(29, 13);
            this.label156.TabIndex = 42;
            this.label156.Text = "Port:";
            // 
            // numericUpDownCustomPool2Port
            // 
            this.numericUpDownCustomPool2Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCustomPool2Port.Location = new System.Drawing.Point(410, 16);
            this.numericUpDownCustomPool2Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownCustomPool2Port.Name = "numericUpDownCustomPool2Port";
            this.numericUpDownCustomPool2Port.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCustomPool2Port.TabIndex = 3;
            this.numericUpDownCustomPool2Port.Tag = "parameter:custom_pool2_port";
            this.numericUpDownCustomPool2Port.ValueChanged += new System.EventHandler(this.numericUpDownCustomPool2Port_ValueChanged);
            // 
            // textBoxCustomPool2Host
            // 
            this.textBoxCustomPool2Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool2Host.Location = new System.Drawing.Point(254, 16);
            this.textBoxCustomPool2Host.Name = "textBoxCustomPool2Host";
            this.textBoxCustomPool2Host.Size = new System.Drawing.Size(115, 20);
            this.textBoxCustomPool2Host.TabIndex = 2;
            this.textBoxCustomPool2Host.Tag = "parameter:custom_pool2_host";
            this.textBoxCustomPool2Host.TextChanged += new System.EventHandler(this.textBoxCustomPool2Host_TextChanged);
            // 
            // textBoxCustomPool2Password
            // 
            this.textBoxCustomPool2Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool2Password.Location = new System.Drawing.Point(692, 16);
            this.textBoxCustomPool2Password.Name = "textBoxCustomPool2Password";
            this.textBoxCustomPool2Password.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool2Password.TabIndex = 5;
            this.textBoxCustomPool2Password.Tag = "parameter:custom_pool2_password";
            this.textBoxCustomPool2Password.TextChanged += new System.EventHandler(this.textBoxCustomPool2Password_TextChanged);
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label157.Location = new System.Drawing.Point(216, 21);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(32, 13);
            this.label157.TabIndex = 34;
            this.label157.Text = "Host:";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label158.Location = new System.Drawing.Point(630, 19);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(56, 13);
            this.label158.TabIndex = 40;
            this.label158.Text = "Password:";
            // 
            // textBoxCustomPool2Login
            // 
            this.textBoxCustomPool2Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool2Login.Location = new System.Drawing.Point(510, 16);
            this.textBoxCustomPool2Login.Name = "textBoxCustomPool2Login";
            this.textBoxCustomPool2Login.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool2Login.TabIndex = 4;
            this.textBoxCustomPool2Login.Tag = "parameter:custom_pool2_login";
            this.textBoxCustomPool2Login.TextChanged += new System.EventHandler(this.textBoxCustomPool2Login_TextChanged);
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label159.Location = new System.Drawing.Point(468, 19);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(36, 13);
            this.label159.TabIndex = 38;
            this.label159.Text = "Login:";
            // 
            // groupBoxCustmPool3
            // 
            this.groupBoxCustmPool3.Controls.Add(this.comboBoxCustomPool3SecondaryAlgorithm);
            this.groupBoxCustmPool3.Controls.Add(this.label173);
            this.groupBoxCustmPool3.Controls.Add(this.numericUpDownCustomPool3SecondaryPort);
            this.groupBoxCustmPool3.Controls.Add(this.textBoxCustomPool3SecondaryHost);
            this.groupBoxCustmPool3.Controls.Add(this.textBoxCustomPool3SecondaryPassword);
            this.groupBoxCustmPool3.Controls.Add(this.label174);
            this.groupBoxCustmPool3.Controls.Add(this.label175);
            this.groupBoxCustmPool3.Controls.Add(this.textBoxCustomPool3SecondaryLogin);
            this.groupBoxCustmPool3.Controls.Add(this.label176);
            this.groupBoxCustmPool3.Controls.Add(this.comboBoxCustomPool3Algorithm);
            this.groupBoxCustmPool3.Controls.Add(this.checkBoxCustomPool3Enable);
            this.groupBoxCustmPool3.Controls.Add(this.label161);
            this.groupBoxCustmPool3.Controls.Add(this.numericUpDownCustomPool3Port);
            this.groupBoxCustmPool3.Controls.Add(this.textBoxCustomPool3Host);
            this.groupBoxCustmPool3.Controls.Add(this.textBoxCustomPool3Password);
            this.groupBoxCustmPool3.Controls.Add(this.label162);
            this.groupBoxCustmPool3.Controls.Add(this.label163);
            this.groupBoxCustmPool3.Controls.Add(this.textBoxCustomPool3Login);
            this.groupBoxCustmPool3.Controls.Add(this.label164);
            this.groupBoxCustmPool3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustmPool3.Location = new System.Drawing.Point(3, 237);
            this.groupBoxCustmPool3.Name = "groupBoxCustmPool3";
            this.groupBoxCustmPool3.Size = new System.Drawing.Size(812, 72);
            this.groupBoxCustmPool3.TabIndex = 3;
            this.groupBoxCustmPool3.TabStop = false;
            this.groupBoxCustmPool3.Text = "Custom Pool 3";
            // 
            // comboBoxCustomPool3SecondaryAlgorithm
            // 
            this.comboBoxCustomPool3SecondaryAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomPool3SecondaryAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomPool3SecondaryAlgorithm.FormattingEnabled = true;
            this.comboBoxCustomPool3SecondaryAlgorithm.Items.AddRange(new object[] {
            "",
            "Pascal"});
            this.comboBoxCustomPool3SecondaryAlgorithm.Location = new System.Drawing.Point(71, 46);
            this.comboBoxCustomPool3SecondaryAlgorithm.Name = "comboBoxCustomPool3SecondaryAlgorithm";
            this.comboBoxCustomPool3SecondaryAlgorithm.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCustomPool3SecondaryAlgorithm.TabIndex = 6;
            this.comboBoxCustomPool3SecondaryAlgorithm.Tag = "parameter:custom_pool3_secondary_algorithm";
            this.comboBoxCustomPool3SecondaryAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomPool3SecondaryAlgorithm_SelectedIndexChanged);
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label173.Location = new System.Drawing.Point(375, 48);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(29, 13);
            this.label173.TabIndex = 53;
            this.label173.Text = "Port:";
            // 
            // numericUpDownCustomPool3SecondaryPort
            // 
            this.numericUpDownCustomPool3SecondaryPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCustomPool3SecondaryPort.Location = new System.Drawing.Point(410, 45);
            this.numericUpDownCustomPool3SecondaryPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownCustomPool3SecondaryPort.Name = "numericUpDownCustomPool3SecondaryPort";
            this.numericUpDownCustomPool3SecondaryPort.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCustomPool3SecondaryPort.TabIndex = 8;
            this.numericUpDownCustomPool3SecondaryPort.Tag = "parameter:custom_pool3_secondary_port";
            this.numericUpDownCustomPool3SecondaryPort.ValueChanged += new System.EventHandler(this.numericUpDownCustomPool3SecondaryPort_ValueChanged);
            // 
            // textBoxCustomPool3SecondaryHost
            // 
            this.textBoxCustomPool3SecondaryHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool3SecondaryHost.Location = new System.Drawing.Point(254, 45);
            this.textBoxCustomPool3SecondaryHost.Name = "textBoxCustomPool3SecondaryHost";
            this.textBoxCustomPool3SecondaryHost.Size = new System.Drawing.Size(115, 20);
            this.textBoxCustomPool3SecondaryHost.TabIndex = 7;
            this.textBoxCustomPool3SecondaryHost.Tag = "parameter:custom_pool3_secondary_host";
            this.textBoxCustomPool3SecondaryHost.TextChanged += new System.EventHandler(this.textBoxCustomPool3SecondaryHost_TextChanged);
            // 
            // textBoxCustomPool3SecondaryPassword
            // 
            this.textBoxCustomPool3SecondaryPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool3SecondaryPassword.Location = new System.Drawing.Point(692, 46);
            this.textBoxCustomPool3SecondaryPassword.Name = "textBoxCustomPool3SecondaryPassword";
            this.textBoxCustomPool3SecondaryPassword.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool3SecondaryPassword.TabIndex = 10;
            this.textBoxCustomPool3SecondaryPassword.Tag = "parameter:custom_pool3_secondary_password";
            this.textBoxCustomPool3SecondaryPassword.TextChanged += new System.EventHandler(this.textBoxCustomPool3SecondaryPassword_TextChanged);
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label174.Location = new System.Drawing.Point(216, 48);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(32, 13);
            this.label174.TabIndex = 47;
            this.label174.Text = "Host:";
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label175.Location = new System.Drawing.Point(630, 49);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(56, 13);
            this.label175.TabIndex = 51;
            this.label175.Text = "Password:";
            // 
            // textBoxCustomPool3SecondaryLogin
            // 
            this.textBoxCustomPool3SecondaryLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool3SecondaryLogin.Location = new System.Drawing.Point(510, 45);
            this.textBoxCustomPool3SecondaryLogin.Name = "textBoxCustomPool3SecondaryLogin";
            this.textBoxCustomPool3SecondaryLogin.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool3SecondaryLogin.TabIndex = 9;
            this.textBoxCustomPool3SecondaryLogin.Tag = "parameter:custom_pool3_secondary_login";
            this.textBoxCustomPool3SecondaryLogin.TextChanged += new System.EventHandler(this.textBoxCustomPool3SecondaryLogin_TextChanged);
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label176.Location = new System.Drawing.Point(468, 48);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(36, 13);
            this.label176.TabIndex = 49;
            this.label176.Text = "Login:";
            // 
            // comboBoxCustomPool3Algorithm
            // 
            this.comboBoxCustomPool3Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomPool3Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomPool3Algorithm.FormattingEnabled = true;
            this.comboBoxCustomPool3Algorithm.Items.AddRange(new object[] {
            "Ethash",
            "Ethash (NiceHash)",
            "CryptoNight",
            "CryptoNight (NiceHash)",
            "Lbry",
            "Pascal",
            "NeoScrypt",
            "Lyra2REv2"});
            this.comboBoxCustomPool3Algorithm.Location = new System.Drawing.Point(71, 15);
            this.comboBoxCustomPool3Algorithm.Name = "comboBoxCustomPool3Algorithm";
            this.comboBoxCustomPool3Algorithm.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCustomPool3Algorithm.TabIndex = 1;
            this.comboBoxCustomPool3Algorithm.Tag = "parameter:custom_pool3_algorithm";
            this.comboBoxCustomPool3Algorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomPool3Algorithm_SelectedIndexChanged);
            // 
            // checkBoxCustomPool3Enable
            // 
            this.checkBoxCustomPool3Enable.AutoSize = true;
            this.checkBoxCustomPool3Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomPool3Enable.Location = new System.Drawing.Point(6, 31);
            this.checkBoxCustomPool3Enable.Name = "checkBoxCustomPool3Enable";
            this.checkBoxCustomPool3Enable.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCustomPool3Enable.TabIndex = 0;
            this.checkBoxCustomPool3Enable.Tag = "parameter:custom_pool3_enabled";
            this.checkBoxCustomPool3Enable.Text = "Enable";
            this.checkBoxCustomPool3Enable.UseVisualStyleBackColor = true;
            this.checkBoxCustomPool3Enable.CheckedChanged += new System.EventHandler(this.checkBoxCustomPool3Enable_CheckedChanged);
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label161.Location = new System.Drawing.Point(375, 17);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(29, 13);
            this.label161.TabIndex = 42;
            this.label161.Text = "Port:";
            // 
            // numericUpDownCustomPool3Port
            // 
            this.numericUpDownCustomPool3Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCustomPool3Port.Location = new System.Drawing.Point(410, 14);
            this.numericUpDownCustomPool3Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownCustomPool3Port.Name = "numericUpDownCustomPool3Port";
            this.numericUpDownCustomPool3Port.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCustomPool3Port.TabIndex = 3;
            this.numericUpDownCustomPool3Port.Tag = "parameter:custom_pool3_port";
            this.numericUpDownCustomPool3Port.ValueChanged += new System.EventHandler(this.numericUpDownCustomPool3Port_ValueChanged);
            // 
            // textBoxCustomPool3Host
            // 
            this.textBoxCustomPool3Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool3Host.Location = new System.Drawing.Point(254, 14);
            this.textBoxCustomPool3Host.Name = "textBoxCustomPool3Host";
            this.textBoxCustomPool3Host.Size = new System.Drawing.Size(115, 20);
            this.textBoxCustomPool3Host.TabIndex = 2;
            this.textBoxCustomPool3Host.Tag = "parameter:custom_pool3_host";
            this.textBoxCustomPool3Host.TextChanged += new System.EventHandler(this.textBoxCustomPool3Host_TextChanged);
            // 
            // textBoxCustomPool3Password
            // 
            this.textBoxCustomPool3Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool3Password.Location = new System.Drawing.Point(692, 15);
            this.textBoxCustomPool3Password.Name = "textBoxCustomPool3Password";
            this.textBoxCustomPool3Password.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool3Password.TabIndex = 5;
            this.textBoxCustomPool3Password.Tag = "parameter:custom_pool3_password";
            this.textBoxCustomPool3Password.TextChanged += new System.EventHandler(this.textBoxCustomPool3Password_TextChanged);
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label162.Location = new System.Drawing.Point(216, 17);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(32, 13);
            this.label162.TabIndex = 34;
            this.label162.Text = "Host:";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label163.Location = new System.Drawing.Point(630, 19);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(56, 13);
            this.label163.TabIndex = 40;
            this.label163.Text = "Password:";
            // 
            // textBoxCustomPool3Login
            // 
            this.textBoxCustomPool3Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool3Login.Location = new System.Drawing.Point(510, 14);
            this.textBoxCustomPool3Login.Name = "textBoxCustomPool3Login";
            this.textBoxCustomPool3Login.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool3Login.TabIndex = 4;
            this.textBoxCustomPool3Login.Tag = "parameter:custom_pool3_login";
            this.textBoxCustomPool3Login.TextChanged += new System.EventHandler(this.textBoxCustomPool3Login_TextChanged);
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label164.Location = new System.Drawing.Point(468, 17);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(36, 13);
            this.label164.TabIndex = 38;
            this.label164.Text = "Login:";
            // 
            // groupBoxCustmPool0
            // 
            this.groupBoxCustmPool0.Controls.Add(this.label149);
            this.groupBoxCustmPool0.Controls.Add(this.numericUpDownCustomPool0SecondaryPort);
            this.groupBoxCustmPool0.Controls.Add(this.textBoxCustomPool0SecondaryHost);
            this.groupBoxCustmPool0.Controls.Add(this.textBoxCustomPool0SecondaryPassword);
            this.groupBoxCustmPool0.Controls.Add(this.label150);
            this.groupBoxCustmPool0.Controls.Add(this.label155);
            this.groupBoxCustmPool0.Controls.Add(this.textBoxCustomPool0SecondaryLogin);
            this.groupBoxCustmPool0.Controls.Add(this.label160);
            this.groupBoxCustmPool0.Controls.Add(this.comboBoxCustomPool0SecondaryAlgorithm);
            this.groupBoxCustmPool0.Controls.Add(this.checkBoxCustomPool0Enable);
            this.groupBoxCustmPool0.Controls.Add(this.comboBoxCustomPool0Algorithm);
            this.groupBoxCustmPool0.Controls.Add(this.label147);
            this.groupBoxCustmPool0.Controls.Add(this.numericUpDownCustomPool0Port);
            this.groupBoxCustmPool0.Controls.Add(this.textBoxCustomPool0Host);
            this.groupBoxCustmPool0.Controls.Add(this.textBoxCustomPool0Password);
            this.groupBoxCustmPool0.Controls.Add(this.label145);
            this.groupBoxCustmPool0.Controls.Add(this.label146);
            this.groupBoxCustmPool0.Controls.Add(this.textBoxCustomPool0Login);
            this.groupBoxCustmPool0.Controls.Add(this.label148);
            this.groupBoxCustmPool0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustmPool0.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCustmPool0.Name = "groupBoxCustmPool0";
            this.groupBoxCustmPool0.Size = new System.Drawing.Size(812, 72);
            this.groupBoxCustmPool0.TabIndex = 0;
            this.groupBoxCustmPool0.TabStop = false;
            this.groupBoxCustmPool0.Text = "Custom Pool 0";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label149.Location = new System.Drawing.Point(375, 47);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(29, 13);
            this.label149.TabIndex = 54;
            this.label149.Text = "Port:";
            // 
            // numericUpDownCustomPool0SecondaryPort
            // 
            this.numericUpDownCustomPool0SecondaryPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCustomPool0SecondaryPort.Location = new System.Drawing.Point(410, 43);
            this.numericUpDownCustomPool0SecondaryPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownCustomPool0SecondaryPort.Name = "numericUpDownCustomPool0SecondaryPort";
            this.numericUpDownCustomPool0SecondaryPort.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCustomPool0SecondaryPort.TabIndex = 8;
            this.numericUpDownCustomPool0SecondaryPort.Tag = "parameter:custom_pool0_secondary_port";
            this.numericUpDownCustomPool0SecondaryPort.ValueChanged += new System.EventHandler(this.numericUpDownCustomPool0SecondaryPort_ValueChanged);
            // 
            // textBoxCustomPool0SecondaryHost
            // 
            this.textBoxCustomPool0SecondaryHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool0SecondaryHost.Location = new System.Drawing.Point(254, 43);
            this.textBoxCustomPool0SecondaryHost.Name = "textBoxCustomPool0SecondaryHost";
            this.textBoxCustomPool0SecondaryHost.Size = new System.Drawing.Size(115, 20);
            this.textBoxCustomPool0SecondaryHost.TabIndex = 7;
            this.textBoxCustomPool0SecondaryHost.Tag = "parameter:custom_pool0_secondary_host";
            this.textBoxCustomPool0SecondaryHost.TextChanged += new System.EventHandler(this.textBoxCustomPool0SecondaryHost_TextChanged);
            // 
            // textBoxCustomPool0SecondaryPassword
            // 
            this.textBoxCustomPool0SecondaryPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool0SecondaryPassword.Location = new System.Drawing.Point(692, 43);
            this.textBoxCustomPool0SecondaryPassword.Name = "textBoxCustomPool0SecondaryPassword";
            this.textBoxCustomPool0SecondaryPassword.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool0SecondaryPassword.TabIndex = 10;
            this.textBoxCustomPool0SecondaryPassword.Tag = "parameter:custom_pool0_secondary_password";
            this.textBoxCustomPool0SecondaryPassword.TextChanged += new System.EventHandler(this.textBoxCustomPool0SecondaryPassword_TextChanged);
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.Location = new System.Drawing.Point(216, 47);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(32, 13);
            this.label150.TabIndex = 48;
            this.label150.Text = "Host:";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label155.Location = new System.Drawing.Point(630, 47);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(56, 13);
            this.label155.TabIndex = 52;
            this.label155.Text = "Password:";
            // 
            // textBoxCustomPool0SecondaryLogin
            // 
            this.textBoxCustomPool0SecondaryLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool0SecondaryLogin.Location = new System.Drawing.Point(510, 42);
            this.textBoxCustomPool0SecondaryLogin.Name = "textBoxCustomPool0SecondaryLogin";
            this.textBoxCustomPool0SecondaryLogin.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool0SecondaryLogin.TabIndex = 9;
            this.textBoxCustomPool0SecondaryLogin.Tag = "parameter:custom_pool0_secondary_login";
            this.textBoxCustomPool0SecondaryLogin.TextChanged += new System.EventHandler(this.textBoxCustomPool0SecondaryLogin_TextChanged);
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label160.Location = new System.Drawing.Point(468, 45);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(36, 13);
            this.label160.TabIndex = 50;
            this.label160.Text = "Login:";
            // 
            // comboBoxCustomPool0SecondaryAlgorithm
            // 
            this.comboBoxCustomPool0SecondaryAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomPool0SecondaryAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomPool0SecondaryAlgorithm.FormattingEnabled = true;
            this.comboBoxCustomPool0SecondaryAlgorithm.Items.AddRange(new object[] {
            "",
            "Pascal"});
            this.comboBoxCustomPool0SecondaryAlgorithm.Location = new System.Drawing.Point(71, 43);
            this.comboBoxCustomPool0SecondaryAlgorithm.Name = "comboBoxCustomPool0SecondaryAlgorithm";
            this.comboBoxCustomPool0SecondaryAlgorithm.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCustomPool0SecondaryAlgorithm.TabIndex = 6;
            this.comboBoxCustomPool0SecondaryAlgorithm.Tag = "parameter:custom_pool0_secondary_algorithm";
            this.comboBoxCustomPool0SecondaryAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomPool0SecondaryAlgorithm_SelectedIndexChanged);
            // 
            // checkBoxCustomPool0Enable
            // 
            this.checkBoxCustomPool0Enable.AutoSize = true;
            this.checkBoxCustomPool0Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomPool0Enable.Location = new System.Drawing.Point(6, 31);
            this.checkBoxCustomPool0Enable.Name = "checkBoxCustomPool0Enable";
            this.checkBoxCustomPool0Enable.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCustomPool0Enable.TabIndex = 0;
            this.checkBoxCustomPool0Enable.Tag = "parameter:custom_pool0_enabled";
            this.checkBoxCustomPool0Enable.Text = "Enable";
            this.checkBoxCustomPool0Enable.UseVisualStyleBackColor = true;
            this.checkBoxCustomPool0Enable.CheckedChanged += new System.EventHandler(this.checkBoxCustomPool0Enable_CheckedChanged);
            // 
            // comboBoxCustomPool0Algorithm
            // 
            this.comboBoxCustomPool0Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomPool0Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomPool0Algorithm.FormattingEnabled = true;
            this.comboBoxCustomPool0Algorithm.Items.AddRange(new object[] {
            "Ethash",
            "Ethash (NiceHash)",
            "CryptoNight",
            "CryptoNight (NiceHash)",
            "Lbry",
            "Pascal",
            "NeoScrypt",
            "Lyra2REv2"});
            this.comboBoxCustomPool0Algorithm.Location = new System.Drawing.Point(71, 16);
            this.comboBoxCustomPool0Algorithm.Name = "comboBoxCustomPool0Algorithm";
            this.comboBoxCustomPool0Algorithm.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCustomPool0Algorithm.TabIndex = 1;
            this.comboBoxCustomPool0Algorithm.Tag = "parameter:custom_pool0_algorithm";
            this.comboBoxCustomPool0Algorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomPool0Algorithm_SelectedIndexChanged);
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label147.Location = new System.Drawing.Point(375, 21);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(29, 13);
            this.label147.TabIndex = 42;
            this.label147.Text = "Port:";
            // 
            // numericUpDownCustomPool0Port
            // 
            this.numericUpDownCustomPool0Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCustomPool0Port.Location = new System.Drawing.Point(410, 17);
            this.numericUpDownCustomPool0Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownCustomPool0Port.Name = "numericUpDownCustomPool0Port";
            this.numericUpDownCustomPool0Port.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCustomPool0Port.TabIndex = 3;
            this.numericUpDownCustomPool0Port.Tag = "parameter:custom_pool0_port";
            this.numericUpDownCustomPool0Port.ValueChanged += new System.EventHandler(this.numericUpDownCustomPool0Port_ValueChanged);
            // 
            // textBoxCustomPool0Host
            // 
            this.textBoxCustomPool0Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool0Host.Location = new System.Drawing.Point(254, 17);
            this.textBoxCustomPool0Host.Name = "textBoxCustomPool0Host";
            this.textBoxCustomPool0Host.Size = new System.Drawing.Size(115, 20);
            this.textBoxCustomPool0Host.TabIndex = 2;
            this.textBoxCustomPool0Host.Tag = "parameter:custom_pool0_host";
            this.textBoxCustomPool0Host.TextChanged += new System.EventHandler(this.textBoxCustomPool0Host_TextChanged);
            // 
            // textBoxCustomPool0Password
            // 
            this.textBoxCustomPool0Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool0Password.Location = new System.Drawing.Point(692, 17);
            this.textBoxCustomPool0Password.Name = "textBoxCustomPool0Password";
            this.textBoxCustomPool0Password.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool0Password.TabIndex = 5;
            this.textBoxCustomPool0Password.Tag = "parameter:custom_pool0_password";
            this.textBoxCustomPool0Password.TextChanged += new System.EventHandler(this.textBoxCustomPool0Password_TextChanged);
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label145.Location = new System.Drawing.Point(216, 21);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(32, 13);
            this.label145.TabIndex = 34;
            this.label145.Text = "Host:";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label146.Location = new System.Drawing.Point(630, 21);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(56, 13);
            this.label146.TabIndex = 40;
            this.label146.Text = "Password:";
            // 
            // textBoxCustomPool0Login
            // 
            this.textBoxCustomPool0Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomPool0Login.Location = new System.Drawing.Point(510, 16);
            this.textBoxCustomPool0Login.Name = "textBoxCustomPool0Login";
            this.textBoxCustomPool0Login.Size = new System.Drawing.Size(114, 20);
            this.textBoxCustomPool0Login.TabIndex = 4;
            this.textBoxCustomPool0Login.Tag = "parameter:custom_pool0_login";
            this.textBoxCustomPool0Login.TextChanged += new System.EventHandler(this.textBoxCustomPool0Login_TextChanged);
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label148.Location = new System.Drawing.Point(468, 19);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(36, 13);
            this.label148.TabIndex = 38;
            this.label148.Text = "Login:";
            // 
            // tabPageDeviceSettings
            // 
            this.tabPageDeviceSettings.Controls.Add(this.buttonResetOverclockingSettings);
            this.tabPageDeviceSettings.Controls.Add(this.buttonResetAllSettings);
            this.tabPageDeviceSettings.Controls.Add(this.buttonResetAlgorithmSettings);
            this.tabPageDeviceSettings.Controls.Add(this.buttonResetFanControlSettings);
            this.tabPageDeviceSettings.Controls.Add(this.groupBoxHadrwareAcceleration);
            this.tabPageDeviceSettings.Controls.Add(this.tabControlDeviceSettings);
            this.tabPageDeviceSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeviceSettings.Name = "tabPageDeviceSettings";
            this.tabPageDeviceSettings.Size = new System.Drawing.Size(981, 533);
            this.tabPageDeviceSettings.TabIndex = 3;
            this.tabPageDeviceSettings.Text = "Devices";
            this.tabPageDeviceSettings.UseVisualStyleBackColor = true;
            // 
            // buttonResetOverclockingSettings
            // 
            this.buttonResetOverclockingSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetOverclockingSettings.Location = new System.Drawing.Point(652, 61);
            this.buttonResetOverclockingSettings.Name = "buttonResetOverclockingSettings";
            this.buttonResetOverclockingSettings.Size = new System.Drawing.Size(163, 23);
            this.buttonResetOverclockingSettings.TabIndex = 4;
            this.buttonResetOverclockingSettings.Text = "Reset Overclocking Settings";
            this.buttonResetOverclockingSettings.UseVisualStyleBackColor = true;
            this.buttonResetOverclockingSettings.Click += new System.EventHandler(this.buttonResetDeviceOverclockingSettings_Click);
            // 
            // buttonResetAllSettings
            // 
            this.buttonResetAllSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetAllSettings.Location = new System.Drawing.Point(652, 96);
            this.buttonResetAllSettings.Name = "buttonResetAllSettings";
            this.buttonResetAllSettings.Size = new System.Drawing.Size(163, 23);
            this.buttonResetAllSettings.TabIndex = 5;
            this.buttonResetAllSettings.Text = "Reset All";
            this.buttonResetAllSettings.UseVisualStyleBackColor = true;
            this.buttonResetAllSettings.Click += new System.EventHandler(this.buttonResetAll_Click);
            // 
            // buttonResetAlgorithmSettings
            // 
            this.buttonResetAlgorithmSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetAlgorithmSettings.Location = new System.Drawing.Point(652, 32);
            this.buttonResetAlgorithmSettings.Name = "buttonResetAlgorithmSettings";
            this.buttonResetAlgorithmSettings.Size = new System.Drawing.Size(163, 23);
            this.buttonResetAlgorithmSettings.TabIndex = 3;
            this.buttonResetAlgorithmSettings.Text = "Reset Algorithm Settings";
            this.buttonResetAlgorithmSettings.UseVisualStyleBackColor = true;
            this.buttonResetAlgorithmSettings.Click += new System.EventHandler(this.buttonResetDeviceAlgorithmSettings_Click);
            // 
            // buttonResetFanControlSettings
            // 
            this.buttonResetFanControlSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetFanControlSettings.Location = new System.Drawing.Point(652, 3);
            this.buttonResetFanControlSettings.Name = "buttonResetFanControlSettings";
            this.buttonResetFanControlSettings.Size = new System.Drawing.Size(163, 23);
            this.buttonResetFanControlSettings.TabIndex = 2;
            this.buttonResetFanControlSettings.Text = "Reset Fan-Control Settings";
            this.buttonResetFanControlSettings.UseVisualStyleBackColor = true;
            this.buttonResetFanControlSettings.Click += new System.EventHandler(this.buttonResetFanControlSettings_Click);
            // 
            // groupBoxHadrwareAcceleration
            // 
            this.groupBoxHadrwareAcceleration.Controls.Add(this.checkBoxEnableOverclockingForDefaultSettings);
            this.groupBoxHadrwareAcceleration.Controls.Add(this.label144);
            this.groupBoxHadrwareAcceleration.Controls.Add(this.checkBox3);
            this.groupBoxHadrwareAcceleration.Controls.Add(this.checkBox2);
            this.groupBoxHadrwareAcceleration.Controls.Add(this.checkBoxEnablePhymem);
            this.groupBoxHadrwareAcceleration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.245F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHadrwareAcceleration.Location = new System.Drawing.Point(3, 294);
            this.groupBoxHadrwareAcceleration.Name = "groupBoxHadrwareAcceleration";
            this.groupBoxHadrwareAcceleration.Size = new System.Drawing.Size(387, 134);
            this.groupBoxHadrwareAcceleration.TabIndex = 1;
            this.groupBoxHadrwareAcceleration.TabStop = false;
            this.groupBoxHadrwareAcceleration.Text = "Hardware Acceleration";
            // 
            // checkBoxEnableOverclockingForDefaultSettings
            // 
            this.checkBoxEnableOverclockingForDefaultSettings.AutoSize = true;
            this.checkBoxEnableOverclockingForDefaultSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableOverclockingForDefaultSettings.Location = new System.Drawing.Point(6, 19);
            this.checkBoxEnableOverclockingForDefaultSettings.Name = "checkBoxEnableOverclockingForDefaultSettings";
            this.checkBoxEnableOverclockingForDefaultSettings.Size = new System.Drawing.Size(212, 17);
            this.checkBoxEnableOverclockingForDefaultSettings.TabIndex = 0;
            this.checkBoxEnableOverclockingForDefaultSettings.Tag = "parameter:enable_overclocking_for_default_settings";
            this.checkBoxEnableOverclockingForDefaultSettings.Text = "Enable overclocking for default settings";
            this.checkBoxEnableOverclockingForDefaultSettings.UseVisualStyleBackColor = true;
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label144.Location = new System.Drawing.Point(2, 108);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(375, 13);
            this.label144.TabIndex = 31;
            this.label144.Text = "Note: These features are highly experimental and may cause system instability.";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(6, 88);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(235, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Enable on-the-fly memory timing mods (AMD)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(6, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Enable GDS (AMD)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxEnablePhymem
            // 
            this.checkBoxEnablePhymem.AutoSize = true;
            this.checkBoxEnablePhymem.Enabled = false;
            this.checkBoxEnablePhymem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnablePhymem.Location = new System.Drawing.Point(6, 42);
            this.checkBoxEnablePhymem.Name = "checkBoxEnablePhymem";
            this.checkBoxEnablePhymem.Size = new System.Drawing.Size(235, 17);
            this.checkBoxEnablePhymem.TabIndex = 1;
            this.checkBoxEnablePhymem.Tag = "parameter:enable_phymem";
            this.checkBoxEnablePhymem.Text = "Enable phymem (Application restart required)";
            this.checkBoxEnablePhymem.UseVisualStyleBackColor = true;
            this.checkBoxEnablePhymem.CheckedChanged += new System.EventHandler(this.checkBoxEnablePhymem_CheckedChanged);
            // 
            // tabControlDeviceSettings
            // 
            this.tabControlDeviceSettings.Location = new System.Drawing.Point(3, 3);
            this.tabControlDeviceSettings.Name = "tabControlDeviceSettings";
            this.tabControlDeviceSettings.SelectedIndex = 0;
            this.tabControlDeviceSettings.Size = new System.Drawing.Size(643, 285);
            this.tabControlDeviceSettings.TabIndex = 0;
            // 
            // tabPageAPI
            // 
            this.tabPageAPI.Controls.Add(this.groupBoxAPIIPRange);
            this.tabPageAPI.Controls.Add(this.numericUpDownAPIPort);
            this.tabPageAPI.Controls.Add(this.label6);
            this.tabPageAPI.Controls.Add(this.linkLabel1);
            this.tabPageAPI.Controls.Add(this.checkBoxAPIEnabled);
            this.tabPageAPI.Location = new System.Drawing.Point(4, 22);
            this.tabPageAPI.Name = "tabPageAPI";
            this.tabPageAPI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAPI.Size = new System.Drawing.Size(981, 533);
            this.tabPageAPI.TabIndex = 7;
            this.tabPageAPI.Text = "API";
            this.tabPageAPI.UseVisualStyleBackColor = true;
            // 
            // groupBoxAPIIPRange
            // 
            this.groupBoxAPIIPRange.Controls.Add(this.label19);
            this.groupBoxAPIIPRange.Controls.Add(this.label18);
            this.groupBoxAPIIPRange.Controls.Add(this.label17);
            this.groupBoxAPIIPRange.Controls.Add(this.label11);
            this.groupBoxAPIIPRange.Controls.Add(this.label22);
            this.groupBoxAPIIPRange.Controls.Add(this.label20);
            this.groupBoxAPIIPRange.Controls.Add(this.label9);
            this.groupBoxAPIIPRange.Controls.Add(this.label21);
            this.groupBoxAPIIPRange.Controls.Add(this.textBoxAdminIPRange);
            this.groupBoxAPIIPRange.Controls.Add(this.textBoxDeniedIPRange);
            this.groupBoxAPIIPRange.Controls.Add(this.textBoxAllowedIPRange);
            this.groupBoxAPIIPRange.Controls.Add(this.label8);
            this.groupBoxAPIIPRange.Enabled = false;
            this.groupBoxAPIIPRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxAPIIPRange.Location = new System.Drawing.Point(11, 57);
            this.groupBoxAPIIPRange.Name = "groupBoxAPIIPRange";
            this.groupBoxAPIIPRange.Size = new System.Drawing.Size(310, 168);
            this.groupBoxAPIIPRange.TabIndex = 3;
            this.groupBoxAPIIPRange.TabStop = false;
            this.groupBoxAPIIPRange.Text = "IP/IP Range";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(62, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "192.168.0.0/24";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(62, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "192.168.0.0/255.255.255.0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(62, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "192.168.0.0-192.168.0.255";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Examples:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Admin:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Admin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Admin:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Allow:";
            // 
            // textBoxAdminIPRange
            // 
            this.textBoxAdminIPRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdminIPRange.Location = new System.Drawing.Point(51, 19);
            this.textBoxAdminIPRange.Name = "textBoxAdminIPRange";
            this.textBoxAdminIPRange.Size = new System.Drawing.Size(249, 20);
            this.textBoxAdminIPRange.TabIndex = 0;
            this.textBoxAdminIPRange.Tag = "parameter:admin_ip_range";
            // 
            // textBoxDeniedIPRange
            // 
            this.textBoxDeniedIPRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeniedIPRange.Location = new System.Drawing.Point(51, 71);
            this.textBoxDeniedIPRange.Name = "textBoxDeniedIPRange";
            this.textBoxDeniedIPRange.Size = new System.Drawing.Size(249, 20);
            this.textBoxDeniedIPRange.TabIndex = 2;
            this.textBoxDeniedIPRange.Tag = "parameter:denied_ip_range";
            // 
            // textBoxAllowedIPRange
            // 
            this.textBoxAllowedIPRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAllowedIPRange.Location = new System.Drawing.Point(51, 45);
            this.textBoxAllowedIPRange.Name = "textBoxAllowedIPRange";
            this.textBoxAllowedIPRange.Size = new System.Drawing.Size(249, 20);
            this.textBoxAllowedIPRange.TabIndex = 1;
            this.textBoxAllowedIPRange.Tag = "parameter:allowed_ip_range";
            this.textBoxAllowedIPRange.Text = "0.0.0.0/0.0.0.0";
            this.textBoxAllowedIPRange.TextChanged += new System.EventHandler(this.textBoxAllowedIPRange_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Deny:";
            // 
            // numericUpDownAPIPort
            // 
            this.numericUpDownAPIPort.Enabled = false;
            this.numericUpDownAPIPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAPIPort.Location = new System.Drawing.Point(43, 31);
            this.numericUpDownAPIPort.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDownAPIPort.Name = "numericUpDownAPIPort";
            this.numericUpDownAPIPort.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownAPIPort.TabIndex = 2;
            this.numericUpDownAPIPort.Tag = "parameter:api_port";
            this.numericUpDownAPIPort.Value = new decimal(new int[] {
            4028,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Port:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(210, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "API Documentation";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBoxAPIEnabled
            // 
            this.checkBoxAPIEnabled.AutoSize = true;
            this.checkBoxAPIEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAPIEnabled.Location = new System.Drawing.Point(7, 7);
            this.checkBoxAPIEnabled.Name = "checkBoxAPIEnabled";
            this.checkBoxAPIEnabled.Size = new System.Drawing.Size(197, 17);
            this.checkBoxAPIEnabled.TabIndex = 0;
            this.checkBoxAPIEnabled.Tag = "parameter:api_enabled";
            this.checkBoxAPIEnabled.Text = "Enable sgminer-compatible RPC API";
            this.checkBoxAPIEnabled.UseVisualStyleBackColor = true;
            this.checkBoxAPIEnabled.CheckedChanged += new System.EventHandler(this.checkBoxAPIEnabled_CheckedChanged);
            // 
            // tabPageMiscSettings
            // 
            this.tabPageMiscSettings.Controls.Add(this.groupBoxOpenCLBinaries);
            this.tabPageMiscSettings.Controls.Add(this.groupBoxUserSettings);
            this.tabPageMiscSettings.Controls.Add(this.groupBox1);
            this.tabPageMiscSettings.Controls.Add(this.groupBoxAutomation);
            this.tabPageMiscSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageMiscSettings.Name = "tabPageMiscSettings";
            this.tabPageMiscSettings.Size = new System.Drawing.Size(981, 533);
            this.tabPageMiscSettings.TabIndex = 4;
            this.tabPageMiscSettings.Text = "Misc.";
            this.tabPageMiscSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxOpenCLBinaries
            // 
            this.groupBoxOpenCLBinaries.Controls.Add(this.buttonOpenOpenCLBinaryFolder);
            this.groupBoxOpenCLBinaries.Controls.Add(this.checkBoxReuseCompiledBinaries);
            this.groupBoxOpenCLBinaries.Controls.Add(this.checkBoxUseDefaultOpenCLBinaries);
            this.groupBoxOpenCLBinaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxOpenCLBinaries.Location = new System.Drawing.Point(3, 119);
            this.groupBoxOpenCLBinaries.Name = "groupBoxOpenCLBinaries";
            this.groupBoxOpenCLBinaries.Size = new System.Drawing.Size(192, 94);
            this.groupBoxOpenCLBinaries.TabIndex = 1;
            this.groupBoxOpenCLBinaries.TabStop = false;
            this.groupBoxOpenCLBinaries.Text = "OpenCL Binaries";
            // 
            // buttonOpenOpenCLBinaryFolder
            // 
            this.buttonOpenOpenCLBinaryFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenOpenCLBinaryFolder.Location = new System.Drawing.Point(6, 65);
            this.buttonOpenOpenCLBinaryFolder.Name = "buttonOpenOpenCLBinaryFolder";
            this.buttonOpenOpenCLBinaryFolder.Size = new System.Drawing.Size(180, 23);
            this.buttonOpenOpenCLBinaryFolder.TabIndex = 2;
            this.buttonOpenOpenCLBinaryFolder.Text = "Open Containing Folder";
            this.buttonOpenOpenCLBinaryFolder.UseVisualStyleBackColor = true;
            this.buttonOpenOpenCLBinaryFolder.Click += new System.EventHandler(this.buttonOpenOpenCLBinaryFolder_Click);
            // 
            // checkBoxReuseCompiledBinaries
            // 
            this.checkBoxReuseCompiledBinaries.AutoSize = true;
            this.checkBoxReuseCompiledBinaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReuseCompiledBinaries.Location = new System.Drawing.Point(6, 42);
            this.checkBoxReuseCompiledBinaries.Name = "checkBoxReuseCompiledBinaries";
            this.checkBoxReuseCompiledBinaries.Size = new System.Drawing.Size(141, 17);
            this.checkBoxReuseCompiledBinaries.TabIndex = 1;
            this.checkBoxReuseCompiledBinaries.Tag = "parameter:reuse_compiled_binaries";
            this.checkBoxReuseCompiledBinaries.Text = "Reuse compiled binaries";
            this.checkBoxReuseCompiledBinaries.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseDefaultOpenCLBinaries
            // 
            this.checkBoxUseDefaultOpenCLBinaries.AutoSize = true;
            this.checkBoxUseDefaultOpenCLBinaries.Checked = true;
            this.checkBoxUseDefaultOpenCLBinaries.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseDefaultOpenCLBinaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseDefaultOpenCLBinaries.Location = new System.Drawing.Point(6, 19);
            this.checkBoxUseDefaultOpenCLBinaries.Name = "checkBoxUseDefaultOpenCLBinaries";
            this.checkBoxUseDefaultOpenCLBinaries.Size = new System.Drawing.Size(119, 17);
            this.checkBoxUseDefaultOpenCLBinaries.TabIndex = 0;
            this.checkBoxUseDefaultOpenCLBinaries.Tag = "parameter:use_default_binaries";
            this.checkBoxUseDefaultOpenCLBinaries.Text = "Use default binaries";
            this.checkBoxUseDefaultOpenCLBinaries.UseVisualStyleBackColor = true;
            // 
            // groupBoxUserSettings
            // 
            this.groupBoxUserSettings.Controls.Add(this.button11);
            this.groupBoxUserSettings.Controls.Add(this.button8);
            this.groupBoxUserSettings.Controls.Add(this.groupBoxSettingsBackups);
            this.groupBoxUserSettings.Controls.Add(this.button9);
            this.groupBoxUserSettings.Controls.Add(this.buttonSaveSettings);
            this.groupBoxUserSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxUserSettings.Location = new System.Drawing.Point(500, 4);
            this.groupBoxUserSettings.Name = "groupBoxUserSettings";
            this.groupBoxUserSettings.Size = new System.Drawing.Size(273, 245);
            this.groupBoxUserSettings.TabIndex = 3;
            this.groupBoxUserSettings.TabStop = false;
            this.groupBoxUserSettings.Text = "User Settings";
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(138, 45);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(126, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Load From...";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(138, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Save As...";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonSaveSettingsAs_Click);
            // 
            // groupBoxSettingsBackups
            // 
            this.groupBoxSettingsBackups.Controls.Add(this.checkBoxAutomaticBackups);
            this.groupBoxSettingsBackups.Controls.Add(this.buttonDeleteAllSettingsBackups);
            this.groupBoxSettingsBackups.Controls.Add(this.buttonDeleteSettingsBackup);
            this.groupBoxSettingsBackups.Controls.Add(this.buttonRestoreSettingsBackup);
            this.groupBoxSettingsBackups.Controls.Add(this.buttonCreateSettingsBackup);
            this.groupBoxSettingsBackups.Controls.Add(this.listBoxSettingBackups);
            this.groupBoxSettingsBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxSettingsBackups.Location = new System.Drawing.Point(6, 77);
            this.groupBoxSettingsBackups.Name = "groupBoxSettingsBackups";
            this.groupBoxSettingsBackups.Size = new System.Drawing.Size(258, 160);
            this.groupBoxSettingsBackups.TabIndex = 2;
            this.groupBoxSettingsBackups.TabStop = false;
            this.groupBoxSettingsBackups.Text = "Backups";
            // 
            // checkBoxAutomaticBackups
            // 
            this.checkBoxAutomaticBackups.AutoSize = true;
            this.checkBoxAutomaticBackups.Checked = true;
            this.checkBoxAutomaticBackups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutomaticBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutomaticBackups.Location = new System.Drawing.Point(6, 134);
            this.checkBoxAutomaticBackups.Name = "checkBoxAutomaticBackups";
            this.checkBoxAutomaticBackups.Size = new System.Drawing.Size(235, 17);
            this.checkBoxAutomaticBackups.TabIndex = 0;
            this.checkBoxAutomaticBackups.Tag = "parameter:automatic_backups";
            this.checkBoxAutomaticBackups.Text = "Create backup whenever settings are saved";
            this.checkBoxAutomaticBackups.UseVisualStyleBackColor = true;
            this.checkBoxAutomaticBackups.CheckedChanged += new System.EventHandler(this.checkBoxCreateSettingsBackupWhenSettingsAreSaved_CheckedChanged);
            // 
            // buttonDeleteAllSettingsBackups
            // 
            this.buttonDeleteAllSettingsBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAllSettingsBackups.Location = new System.Drawing.Point(185, 105);
            this.buttonDeleteAllSettingsBackups.Name = "buttonDeleteAllSettingsBackups";
            this.buttonDeleteAllSettingsBackups.Size = new System.Drawing.Size(67, 23);
            this.buttonDeleteAllSettingsBackups.TabIndex = 5;
            this.buttonDeleteAllSettingsBackups.Text = "Delete All";
            this.buttonDeleteAllSettingsBackups.UseVisualStyleBackColor = true;
            this.buttonDeleteAllSettingsBackups.Click += new System.EventHandler(this.button13_Click);
            // 
            // buttonDeleteSettingsBackup
            // 
            this.buttonDeleteSettingsBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSettingsBackup.Location = new System.Drawing.Point(185, 76);
            this.buttonDeleteSettingsBackup.Name = "buttonDeleteSettingsBackup";
            this.buttonDeleteSettingsBackup.Size = new System.Drawing.Size(67, 23);
            this.buttonDeleteSettingsBackup.TabIndex = 4;
            this.buttonDeleteSettingsBackup.Text = "Delete";
            this.buttonDeleteSettingsBackup.UseVisualStyleBackColor = true;
            this.buttonDeleteSettingsBackup.Click += new System.EventHandler(this.buttonDeleteSettingsBackup_Click);
            // 
            // buttonRestoreSettingsBackup
            // 
            this.buttonRestoreSettingsBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreSettingsBackup.Location = new System.Drawing.Point(185, 47);
            this.buttonRestoreSettingsBackup.Name = "buttonRestoreSettingsBackup";
            this.buttonRestoreSettingsBackup.Size = new System.Drawing.Size(67, 23);
            this.buttonRestoreSettingsBackup.TabIndex = 3;
            this.buttonRestoreSettingsBackup.Text = "Restore";
            this.buttonRestoreSettingsBackup.UseVisualStyleBackColor = true;
            this.buttonRestoreSettingsBackup.Click += new System.EventHandler(this.buttonRestoreSettings_Click);
            // 
            // buttonCreateSettingsBackup
            // 
            this.buttonCreateSettingsBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSettingsBackup.Location = new System.Drawing.Point(185, 18);
            this.buttonCreateSettingsBackup.Name = "buttonCreateSettingsBackup";
            this.buttonCreateSettingsBackup.Size = new System.Drawing.Size(67, 23);
            this.buttonCreateSettingsBackup.TabIndex = 1;
            this.buttonCreateSettingsBackup.Text = "Create";
            this.buttonCreateSettingsBackup.UseVisualStyleBackColor = true;
            this.buttonCreateSettingsBackup.Click += new System.EventHandler(this.buttonCreateSettingsBackup_Click);
            // 
            // listBoxSettingBackups
            // 
            this.listBoxSettingBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSettingBackups.FormattingEnabled = true;
            this.listBoxSettingBackups.Location = new System.Drawing.Point(6, 20);
            this.listBoxSettingBackups.Name = "listBoxSettingBackups";
            this.listBoxSettingBackups.Size = new System.Drawing.Size(173, 108);
            this.listBoxSettingBackups.TabIndex = 0;
            this.listBoxSettingBackups.SelectedIndexChanged += new System.EventHandler(this.listBoxSettingBackups_SelectedIndexChanged);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(6, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "Load";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonLoadSettings_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSettings.Location = new System.Drawing.Point(6, 16);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(126, 23);
            this.buttonSaveSettings.TabIndex = 0;
            this.buttonSaveSettings.Text = "Save";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.buttonDisableUserAccountControl);
            this.groupBox1.Controls.Add(this.buttonDisableUserAccountControlSettings);
            this.groupBox1.Controls.Add(this.buttonDownloadDisplayDriverUninstaller);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonConfigureAutomaticLogin);
            this.groupBox1.Controls.Add(this.buttonInstallRecommendedAMDDriver);
            this.groupBox1.Controls.Add(this.buttonDisableAuomaticRepair);
            this.groupBox1.Controls.Add(this.buttonDisableDriverInstallation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(201, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Configurations";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 223);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(216, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "8. Download TeamViewer";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonInstallTeamViewer_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(6, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "1. Install Latest Version";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonDisableUserAccountControl
            // 
            this.buttonDisableUserAccountControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisableUserAccountControl.Location = new System.Drawing.Point(6, 136);
            this.buttonDisableUserAccountControl.Name = "buttonDisableUserAccountControl";
            this.buttonDisableUserAccountControl.Size = new System.Drawing.Size(216, 23);
            this.buttonDisableUserAccountControl.TabIndex = 5;
            this.buttonDisableUserAccountControl.Text = "5. Disable User Account Control";
            this.buttonDisableUserAccountControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDisableUserAccountControl.UseVisualStyleBackColor = true;
            this.buttonDisableUserAccountControl.Click += new System.EventHandler(this.buttonDisableUserAccountControl_Click);
            // 
            // buttonDisableUserAccountControlSettings
            // 
            this.buttonDisableUserAccountControlSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisableUserAccountControlSettings.Location = new System.Drawing.Point(228, 136);
            this.buttonDisableUserAccountControlSettings.Name = "buttonDisableUserAccountControlSettings";
            this.buttonDisableUserAccountControlSettings.Size = new System.Drawing.Size(57, 23);
            this.buttonDisableUserAccountControlSettings.TabIndex = 6;
            this.buttonDisableUserAccountControlSettings.Text = "Restore";
            this.buttonDisableUserAccountControlSettings.UseVisualStyleBackColor = true;
            this.buttonDisableUserAccountControlSettings.Click += new System.EventHandler(this.buttonUserAccountControlSettings_Click);
            // 
            // buttonDownloadDisplayDriverUninstaller
            // 
            this.buttonDownloadDisplayDriverUninstaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadDisplayDriverUninstaller.Location = new System.Drawing.Point(6, 78);
            this.buttonDownloadDisplayDriverUninstaller.Name = "buttonDownloadDisplayDriverUninstaller";
            this.buttonDownloadDisplayDriverUninstaller.Size = new System.Drawing.Size(216, 23);
            this.buttonDownloadDisplayDriverUninstaller.TabIndex = 3;
            this.buttonDownloadDisplayDriverUninstaller.Text = "3. Download Display Driver Uninstaller";
            this.buttonDownloadDisplayDriverUninstaller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownloadDisplayDriverUninstaller.UseVisualStyleBackColor = true;
            this.buttonDownloadDisplayDriverUninstaller.Click += new System.EventHandler(this.buttonDownloadDisplayDriverUninstaller_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDeviceInstallationSettings_Click);
            // 
            // buttonConfigureAutomaticLogin
            // 
            this.buttonConfigureAutomaticLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigureAutomaticLogin.Location = new System.Drawing.Point(6, 165);
            this.buttonConfigureAutomaticLogin.Name = "buttonConfigureAutomaticLogin";
            this.buttonConfigureAutomaticLogin.Size = new System.Drawing.Size(216, 23);
            this.buttonConfigureAutomaticLogin.TabIndex = 7;
            this.buttonConfigureAutomaticLogin.Text = "6. Configure Automatic Login";
            this.buttonConfigureAutomaticLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfigureAutomaticLogin.UseVisualStyleBackColor = true;
            this.buttonConfigureAutomaticLogin.Click += new System.EventHandler(this.buttonConfigureAutomaticLogin_Click);
            // 
            // buttonInstallRecommendedAMDDriver
            // 
            this.buttonInstallRecommendedAMDDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstallRecommendedAMDDriver.Location = new System.Drawing.Point(6, 107);
            this.buttonInstallRecommendedAMDDriver.Name = "buttonInstallRecommendedAMDDriver";
            this.buttonInstallRecommendedAMDDriver.Size = new System.Drawing.Size(216, 23);
            this.buttonInstallRecommendedAMDDriver.TabIndex = 4;
            this.buttonInstallRecommendedAMDDriver.Text = "4. Download Recommended AMD Driver";
            this.buttonInstallRecommendedAMDDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInstallRecommendedAMDDriver.UseVisualStyleBackColor = true;
            this.buttonInstallRecommendedAMDDriver.Click += new System.EventHandler(this.buttonInstallRecommendedAMDDriver_Click);
            // 
            // buttonDisableAuomaticRepair
            // 
            this.buttonDisableAuomaticRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisableAuomaticRepair.Location = new System.Drawing.Point(6, 194);
            this.buttonDisableAuomaticRepair.Name = "buttonDisableAuomaticRepair";
            this.buttonDisableAuomaticRepair.Size = new System.Drawing.Size(216, 23);
            this.buttonDisableAuomaticRepair.TabIndex = 8;
            this.buttonDisableAuomaticRepair.Text = "7. Disable Automatic Repair";
            this.buttonDisableAuomaticRepair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDisableAuomaticRepair.UseVisualStyleBackColor = true;
            this.buttonDisableAuomaticRepair.Click += new System.EventHandler(this.buttonDisableAuomaticRepair_Click);
            // 
            // buttonDisableDriverInstallation
            // 
            this.buttonDisableDriverInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisableDriverInstallation.Location = new System.Drawing.Point(6, 49);
            this.buttonDisableDriverInstallation.Name = "buttonDisableDriverInstallation";
            this.buttonDisableDriverInstallation.Size = new System.Drawing.Size(216, 23);
            this.buttonDisableDriverInstallation.TabIndex = 1;
            this.buttonDisableDriverInstallation.Text = "2. Disable Driver Installation";
            this.buttonDisableDriverInstallation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDisableDriverInstallation.UseVisualStyleBackColor = true;
            this.buttonDisableDriverInstallation.Click += new System.EventHandler(this.buttonDisableDriverInstallation_Click);
            // 
            // groupBoxAutomation
            // 
            this.groupBoxAutomation.Controls.Add(this.label2);
            this.groupBoxAutomation.Controls.Add(this.checkBoxDisableAutoStartPrompt);
            this.groupBoxAutomation.Controls.Add(this.checkBoxAutoStart);
            this.groupBoxAutomation.Controls.Add(this.checkBoxLaunchAtStartup);
            this.groupBoxAutomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxAutomation.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAutomation.Name = "groupBoxAutomation";
            this.groupBoxAutomation.Size = new System.Drawing.Size(192, 110);
            this.groupBoxAutomation.TabIndex = 0;
            this.groupBoxAutomation.TabStop = false;
            this.groupBoxAutomation.Text = "Automation";
            this.groupBoxAutomation.Enter += new System.EventHandler(this.groupBoxAutomation_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Hold Shift to disable auto-start.)";
            // 
            // checkBoxDisableAutoStartPrompt
            // 
            this.checkBoxDisableAutoStartPrompt.AutoSize = true;
            this.checkBoxDisableAutoStartPrompt.Checked = true;
            this.checkBoxDisableAutoStartPrompt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisableAutoStartPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisableAutoStartPrompt.Location = new System.Drawing.Point(6, 82);
            this.checkBoxDisableAutoStartPrompt.Name = "checkBoxDisableAutoStartPrompt";
            this.checkBoxDisableAutoStartPrompt.Size = new System.Drawing.Size(176, 17);
            this.checkBoxDisableAutoStartPrompt.TabIndex = 2;
            this.checkBoxDisableAutoStartPrompt.Tag = "parameter:disable_auto_start_prompt";
            this.checkBoxDisableAutoStartPrompt.Text = "Disable prompt before auto-start";
            this.checkBoxDisableAutoStartPrompt.UseVisualStyleBackColor = true;
            this.checkBoxDisableAutoStartPrompt.CheckedChanged += new System.EventHandler(this.checkBoxDisableAutoStartPrompt_CheckedChanged);
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoStart.Location = new System.Drawing.Point(8, 20);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(104, 17);
            this.checkBoxAutoStart.TabIndex = 0;
            this.checkBoxAutoStart.Tag = "parameter:auto_start";
            this.checkBoxAutoStart.Text = "Auto-start mining";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            this.checkBoxAutoStart.CheckedChanged += new System.EventHandler(this.checkBoxAutoStart_CheckedChanged);
            // 
            // checkBoxLaunchAtStartup
            // 
            this.checkBoxLaunchAtStartup.AutoSize = true;
            this.checkBoxLaunchAtStartup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLaunchAtStartup.Location = new System.Drawing.Point(6, 59);
            this.checkBoxLaunchAtStartup.Name = "checkBoxLaunchAtStartup";
            this.checkBoxLaunchAtStartup.Size = new System.Drawing.Size(163, 17);
            this.checkBoxLaunchAtStartup.TabIndex = 1;
            this.checkBoxLaunchAtStartup.Tag = "parameter:launch_at_startup";
            this.checkBoxLaunchAtStartup.Text = "Launch application at startup";
            this.checkBoxLaunchAtStartup.UseVisualStyleBackColor = true;
            this.checkBoxLaunchAtStartup.CheckedChanged += new System.EventHandler(this.checkBoxLaunchAtStartup_CheckedChanged);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.buttonOpenLogContainingFolder);
            this.tabPageLog.Controls.Add(this.buttonClearLog);
            this.tabPageLog.Controls.Add(this.buttonOpenLog);
            this.tabPageLog.Controls.Add(this.richTextBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(981, 533);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // buttonOpenLogContainingFolder
            // 
            this.buttonOpenLogContainingFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenLogContainingFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenLogContainingFolder.Location = new System.Drawing.Point(833, 36);
            this.buttonOpenLogContainingFolder.Name = "buttonOpenLogContainingFolder";
            this.buttonOpenLogContainingFolder.Size = new System.Drawing.Size(142, 23);
            this.buttonOpenLogContainingFolder.TabIndex = 2;
            this.buttonOpenLogContainingFolder.Text = "Open Containing Folder";
            this.buttonOpenLogContainingFolder.UseVisualStyleBackColor = true;
            this.buttonOpenLogContainingFolder.Click += new System.EventHandler(this.buttonOpenLogContainingFolder_Click);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearLog.Location = new System.Drawing.Point(833, 65);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(142, 23);
            this.buttonClearLog.TabIndex = 3;
            this.buttonClearLog.Text = "Clear Log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // buttonOpenLog
            // 
            this.buttonOpenLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenLog.Location = new System.Drawing.Point(833, 7);
            this.buttonOpenLog.Name = "buttonOpenLog";
            this.buttonOpenLog.Size = new System.Drawing.Size(142, 23);
            this.buttonOpenLog.TabIndex = 1;
            this.buttonOpenLog.Text = "Open Log File";
            this.buttonOpenLog.UseVisualStyleBackColor = true;
            this.buttonOpenLog.Click += new System.EventHandler(this.buttonOpenLog_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.BackColor = System.Drawing.Color.Black;
            this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLog.ForeColor = System.Drawing.Color.Lime;
            this.richTextBoxLog.Location = new System.Drawing.Point(6, 7);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(821, 476);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.richTextBoxAbout);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(981, 533);
            this.tabPageAbout.TabIndex = 5;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAbout
            // 
            this.richTextBoxAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.richTextBoxAbout.Location = new System.Drawing.Point(4, 4);
            this.richTextBoxAbout.Name = "richTextBoxAbout";
            this.richTextBoxAbout.ReadOnly = true;
            this.richTextBoxAbout.Size = new System.Drawing.Size(974, 482);
            this.richTextBoxAbout.TabIndex = 0;
            this.richTextBoxAbout.Text = resources.GetString("richTextBoxAbout.Text");
            // 
            // timerStatsUpdates
            // 
            this.timerStatsUpdates.Interval = 1000;
            this.timerStatsUpdates.Tick += new System.EventHandler(this.timerDeviceStatusUpdates_Tick);
            // 
            // timerDevFee
            // 
            this.timerDevFee.Interval = 60000;
            this.timerDevFee.Tick += new System.EventHandler(this.timerDevFee_Tick);
            // 
            // timerWatchdog
            // 
            this.timerWatchdog.Interval = 2000;
            this.timerWatchdog.Tick += new System.EventHandler(this.timerWatchdog_Tick);
            // 
            // timerUpdateLog
            // 
            this.timerUpdateLog.Enabled = true;
            this.timerUpdateLog.Interval = 10;
            this.timerUpdateLog.Tick += new System.EventHandler(this.timerUpdateLog_Tick);
            // 
            // timerAutoStart
            // 
            this.timerAutoStart.Tick += new System.EventHandler(this.timerAutoStart_Tick);
            // 
            // buttonRelaunch
            // 
            this.buttonRelaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRelaunch.Location = new System.Drawing.Point(753, 573);
            this.buttonRelaunch.Name = "buttonRelaunch";
            this.buttonRelaunch.Size = new System.Drawing.Size(121, 23);
            this.buttonRelaunch.TabIndex = 2;
            this.buttonRelaunch.Text = "Relaunch and Start";
            this.buttonRelaunch.UseVisualStyleBackColor = true;
            this.buttonRelaunch.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(878, 573);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMainFormProgressBar,
            this.toolStripStatusLabel1});
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 606);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(1012, 23);
            this.statusStripMainForm.TabIndex = 5;
            // 
            // toolStripMainFormProgressBar
            // 
            this.toolStripMainFormProgressBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripMainFormProgressBar.Name = "toolStripMainFormProgressBar";
            this.toolStripMainFormProgressBar.Size = new System.Drawing.Size(100, 17);
            this.toolStripMainFormProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(158, 18);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabelMessage";
            // 
            // timerFailOver
            // 
            this.timerFailOver.Interval = 10;
            this.timerFailOver.Tick += new System.EventHandler(this.timerFailOver_Tick);
            // 
            // buttonReleaseMemory
            // 
            this.buttonReleaseMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReleaseMemory.Location = new System.Drawing.Point(628, 573);
            this.buttonReleaseMemory.Name = "buttonReleaseMemory";
            this.buttonReleaseMemory.Size = new System.Drawing.Size(121, 23);
            this.buttonReleaseMemory.TabIndex = 1;
            this.buttonReleaseMemory.Text = "Release Memory";
            this.buttonReleaseMemory.UseVisualStyleBackColor = true;
            this.buttonReleaseMemory.Click += new System.EventHandler(this.buttonReleaseMemory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1012, 629);
            this.Controls.Add(this.buttonRelaunch);
            this.Controls.Add(this.statusStripMainForm);
            this.Controls.Add(this.buttonReleaseMemory);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.tabControlMainForm);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1028, 668);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Gateless Gate Sharp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMainForm.ResumeLayout(false);
            this.tabPageDashboard.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).EndInit();
            this.tabPagePoolSettings.ResumeLayout(false);
            this.groupBoxWalletAddresses.ResumeLayout(false);
            this.groupBoxWalletAddresses.PerformLayout();
            this.groupBoxPoolParameters.ResumeLayout(false);
            this.groupBoxPoolParameters.PerformLayout();
            this.groupBoxPoolPriorities.ResumeLayout(false);
            this.groupBoxCoinsToMine.ResumeLayout(false);
            this.groupBoxCoinsToMine.PerformLayout();
            this.tabPageCustomPoolSettings.ResumeLayout(false);
            this.groupBoxCustmPool1.ResumeLayout(false);
            this.groupBoxCustmPool1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool1SecondaryPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool1Port)).EndInit();
            this.groupBoxCustmPool2.ResumeLayout(false);
            this.groupBoxCustmPool2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool2SecondaryPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool2Port)).EndInit();
            this.groupBoxCustmPool3.ResumeLayout(false);
            this.groupBoxCustmPool3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool3SecondaryPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool3Port)).EndInit();
            this.groupBoxCustmPool0.ResumeLayout(false);
            this.groupBoxCustmPool0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool0SecondaryPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomPool0Port)).EndInit();
            this.tabPageDeviceSettings.ResumeLayout(false);
            this.groupBoxHadrwareAcceleration.ResumeLayout(false);
            this.groupBoxHadrwareAcceleration.PerformLayout();
            this.tabPageAPI.ResumeLayout(false);
            this.tabPageAPI.PerformLayout();
            this.groupBoxAPIIPRange.ResumeLayout(false);
            this.groupBoxAPIIPRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAPIPort)).EndInit();
            this.tabPageMiscSettings.ResumeLayout(false);
            this.groupBoxOpenCLBinaries.ResumeLayout(false);
            this.groupBoxOpenCLBinaries.PerformLayout();
            this.groupBoxUserSettings.ResumeLayout(false);
            this.groupBoxSettingsBackups.ResumeLayout(false);
            this.groupBoxSettingsBackups.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxAutomation.ResumeLayout(false);
            this.groupBoxAutomation.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainForm;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TabPage tabPagePoolSettings;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPriceDay;
        private System.Windows.Forms.Label labelPriceWeek;
        private System.Windows.Forms.TextBox textBoxZcashAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxMoneroAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxEthereumAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonMoneroBalance;
        private System.Windows.Forms.Button buttonEthereumBalance;
        private System.Windows.Forms.Button buttonViewBalancesAtNiceHash;
        private System.Windows.Forms.GroupBox groupBoxCoinsToMine;
        private System.Windows.Forms.RadioButton radioButtonZcash;
        private System.Windows.Forms.RadioButton radioButtonMonero;
        private System.Windows.Forms.RadioButton radioButtonEthereum;
        private System.Windows.Forms.RadioButton radioButtonMostProfitable;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Timer timerStatsUpdates;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Label labelPriceMonth;
        private System.Windows.Forms.GroupBox groupBoxPoolPriorities;
        private System.Windows.Forms.Button buttonPoolPrioritiesDown;
        private System.Windows.Forms.Button buttonPoolPrioritiesUp;
        private System.Windows.Forms.ListBox listBoxPoolPriorities;
        private System.Windows.Forms.Timer timerDevFee;
        private System.Windows.Forms.Timer timerWatchdog;
        private System.Windows.Forms.GroupBox groupBoxPoolParameters;
        private System.Windows.Forms.TextBox textBoxRigID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxBitcoinAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timerUpdateLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Button buttonOpenLog;
        private System.Windows.Forms.GroupBox groupBoxWalletAddresses;
        private System.Windows.Forms.TabPage tabPageDeviceSettings;
        private System.Windows.Forms.TabControl tabControlDeviceSettings;
        private System.Windows.Forms.GroupBox groupBoxHadrwareAcceleration;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxEnablePhymem;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Timer timerAutoStart;
        private System.Windows.Forms.TabPage tabPageCustomPoolSettings;
        private System.Windows.Forms.GroupBox groupBoxCustmPool0;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomPool0Port;
        private System.Windows.Forms.TextBox textBoxCustomPool0Host;
        private System.Windows.Forms.TextBox textBoxCustomPool0Password;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.TextBox textBoxCustomPool0Login;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.CheckBox checkBoxCustomPool0Enable;
        private System.Windows.Forms.TabPage tabPageMiscSettings;
        private System.Windows.Forms.GroupBox groupBoxAutomation;
        private System.Windows.Forms.CheckBox checkBoxDisableAutoStartPrompt;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.CheckBox checkBoxLaunchAtStartup;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.ComboBox comboBoxCustomPool0Algorithm;
        private System.Windows.Forms.GroupBox groupBoxCustmPool1;
        private System.Windows.Forms.CheckBox checkBoxCustomPool1Enable;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomPool1Port;
        private System.Windows.Forms.TextBox textBoxCustomPool1Host;
        private System.Windows.Forms.TextBox textBoxCustomPool1Password;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.TextBox textBoxCustomPool1Login;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.GroupBox groupBoxCustmPool2;
        private System.Windows.Forms.CheckBox checkBoxCustomPool2Enable;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomPool2Port;
        private System.Windows.Forms.TextBox textBoxCustomPool2Host;
        private System.Windows.Forms.TextBox textBoxCustomPool2Password;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.TextBox textBoxCustomPool2Login;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.GroupBox groupBoxCustmPool3;
        private System.Windows.Forms.CheckBox checkBoxCustomPool3Enable;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomPool3Port;
        private System.Windows.Forms.TextBox textBoxCustomPool3Host;
        private System.Windows.Forms.TextBox textBoxCustomPool3Password;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.TextBox textBoxCustomPool3Login;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.RichTextBox richTextBoxAbout;
        private System.Windows.Forms.RadioButton radioButtonLbry;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButtonEthereumPascal;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBoxCustomPool1Algorithm;
        private System.Windows.Forms.ComboBox comboBoxCustomPool2Algorithm;
        private System.Windows.Forms.ComboBox comboBoxCustomPool3Algorithm;
        private System.Windows.Forms.ComboBox comboBoxCustomPool1SecondaryAlgorithm;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomPool1SecondaryPort;
        private System.Windows.Forms.TextBox textBoxCustomPool1SecondaryHost;
        private System.Windows.Forms.TextBox textBoxCustomPool1SecondaryPassword;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.TextBox textBoxCustomPool1SecondaryLogin;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.ComboBox comboBoxCustomPool2SecondaryAlgorithm;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomPool2SecondaryPort;
        private System.Windows.Forms.TextBox textBoxCustomPool2SecondaryHost;
        private System.Windows.Forms.TextBox textBoxCustomPool2SecondaryPassword;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.TextBox textBoxCustomPool2SecondaryLogin;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.ComboBox comboBoxCustomPool3SecondaryAlgorithm;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomPool3SecondaryPort;
        private System.Windows.Forms.TextBox textBoxCustomPool3SecondaryHost;
        private System.Windows.Forms.TextBox textBoxCustomPool3SecondaryPassword;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.TextBox textBoxCustomPool3SecondaryLogin;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomPool0SecondaryPort;
        private System.Windows.Forms.TextBox textBoxCustomPool0SecondaryHost;
        private System.Windows.Forms.TextBox textBoxCustomPool0SecondaryPassword;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.TextBox textBoxCustomPool0SecondaryLogin;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.ComboBox comboBoxCustomPool0SecondaryAlgorithm;
        private System.Windows.Forms.RadioButton radioButtonPascal;
        private System.Windows.Forms.TextBox textBoxPascalAddress;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button buttonViewPascalBalance;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button buttonLbryBalance;
        private System.Windows.Forms.TextBox textBoxLbryAddress;
        private System.Windows.Forms.RadioButton radioButtonFeathercoin;
        private System.Windows.Forms.RadioButton radioButtonMonacoin;
        private System.Windows.Forms.DataGridView dataGridViewDevices;
        private System.Windows.Forms.Button buttonRelaunch;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.StatusStrip statusStripMainForm;
        private System.Windows.Forms.ToolStripProgressBar toolStripMainFormProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonConfigureAutomaticLogin;
        private System.Windows.Forms.Button buttonDisableAuomaticRepair;
        private System.Windows.Forms.Button buttonDisableDriverInstallation;
        private System.Windows.Forms.Button buttonInstallRecommendedAMDDriver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDownloadDisplayDriverUninstaller;
        private System.Windows.Forms.Button buttonDisableUserAccountControl;
        private System.Windows.Forms.Button buttonDisableUserAccountControlSettings;
        private System.Windows.Forms.Button buttonResetOverclockingSettings;
        private System.Windows.Forms.Button buttonResetAllSettings;
        private System.Windows.Forms.Button buttonResetAlgorithmSettings;
        private System.Windows.Forms.Button buttonResetFanControlSettings;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private LiveCharts.WinForms.CartesianChart cartesianChartTemperature;
        private System.Windows.Forms.ComboBox comboBoxGraphType;
        private System.Windows.Forms.ComboBox comboBoxGraphCoverage;
        private LiveCharts.WinForms.CartesianChart cartesianChartSpeedPrimaryAlgorithm;
        private LiveCharts.WinForms.CartesianChart cartesianChartSpeedSecondaryAlgorithm;
        private LiveCharts.WinForms.CartesianChart cartesianChartFanSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxUserSettings;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBoxSettingsBackups;
        private System.Windows.Forms.CheckBox checkBoxAutomaticBackups;
        private System.Windows.Forms.Button buttonDeleteAllSettingsBackups;
        private System.Windows.Forms.Button buttonDeleteSettingsBackup;
        private System.Windows.Forms.Button buttonRestoreSettingsBackup;
        private System.Windows.Forms.Button buttonCreateSettingsBackup;
        private System.Windows.Forms.ListBox listBoxSettingBackups;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Timer timerFailOver;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxOpenCLBinaries;
        private System.Windows.Forms.Button buttonOpenOpenCLBinaryFolder;
        private System.Windows.Forms.CheckBox checkBoxReuseCompiledBinaries;
        private System.Windows.Forms.CheckBox checkBoxUseDefaultOpenCLBinaries;
        private System.Windows.Forms.Button buttonReleaseMemory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBoxSecondGraphType;
        private System.Windows.Forms.ComboBox comboBoxSecondGraphCoverage;
        private LiveCharts.WinForms.CartesianChart cartesianChartDeviceActivity;
        private LiveCharts.WinForms.CartesianChart cartesianChartPower;
        private LiveCharts.WinForms.CartesianChart cartesianChartCPUUsage;
        private LiveCharts.WinForms.CartesianChart cartesianChartShare1Month;
        private LiveCharts.WinForms.CartesianChart cartesianChartShare1Day;
        private LiveCharts.WinForms.CartesianChart cartesianChartShare1Hour;
        private LiveCharts.WinForms.CartesianChart cartesianChartShare1Minute;
        private System.Windows.Forms.TabPage tabPageAPI;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBoxAPIEnabled;
        private System.Windows.Forms.NumericUpDown numericUpDownAPIPort;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxDeniedIPRange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAllowedIPRange;
        private System.Windows.Forms.GroupBox groupBoxAPIIPRange;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAdminIPRange;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBoxEnableOverclockingForDefaultSettings;
        private System.Windows.Forms.Button buttonOpenLogContainingFolder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn shares;
        private System.Windows.Forms.DataGridViewTextBoxColumn activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn fan;
        private System.Windows.Forms.DataGridViewTextBoxColumn power;
        private System.Windows.Forms.DataGridViewTextBoxColumn power_limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn core_clock;
        private System.Windows.Forms.DataGridViewTextBoxColumn core_voltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn memory_clock;
        private System.Windows.Forms.DataGridViewTextBoxColumn memory_used;
        private System.Windows.Forms.DataGridViewTextBoxColumn memory_reserved;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonBoostPerformance;
        private System.Windows.Forms.Button buttonRestoreStockSettings;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Label labelCurrentSpeed;
        private System.Windows.Forms.Label labelCurrentSecondaryPool;
        private System.Windows.Forms.Label labelCurrentPool;
    }
}
