namespace BDO_Enhacement
{
    partial class EnhancementCalculatorMainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCronTet = new System.Windows.Forms.CheckBox();
            this.chkCronTri = new System.Windows.Forms.CheckBox();
            this.chkCronDuo = new System.Windows.Forms.CheckBox();
            this.chkCronPri = new System.Windows.Forms.CheckBox();
            this.chkCronPen = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.nudPriStack = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudTriStack = new System.Windows.Forms.NumericUpDown();
            this.nudPenStack = new System.Windows.Forms.NumericUpDown();
            this.nudTetStack = new System.Windows.Forms.NumericUpDown();
            this.nudDuoStack = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPriCronsNeeded = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTriCronsNeeded = new System.Windows.Forms.Label();
            this.lblDuoCronsNeeded = new System.Windows.Forms.Label();
            this.lblPenCronsNeeded = new System.Windows.Forms.Label();
            this.lblTetCronsNeeded = new System.Windows.Forms.Label();
            this.lblPriSoftcapStack = new System.Windows.Forms.Label();
            this.lblDuoSoftcapStack = new System.Windows.Forms.Label();
            this.lblTetSoftcapStack = new System.Windows.Forms.Label();
            this.lblTriSoftcapStack = new System.Windows.Forms.Label();
            this.lblPenSoftcapStack = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudBaseItemCost = new System.Windows.Forms.NumericUpDown();
            this.nudCurItemCost = new System.Windows.Forms.NumericUpDown();
            this.nudCronCost = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbDesiredItemLevel = new System.Windows.Forms.ComboBox();
            this.cmbCurrentItemLevel = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTetStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuoStack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseItemCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurItemCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCronCost)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTetCronsNeeded);
            this.groupBox1.Controls.Add(this.lblPenCronsNeeded);
            this.groupBox1.Controls.Add(this.lblDuoCronsNeeded);
            this.groupBox1.Controls.Add(this.lblTriCronsNeeded);
            this.groupBox1.Controls.Add(this.lblPriCronsNeeded);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.chkCronPen);
            this.groupBox1.Controls.Add(this.chkCronPri);
            this.groupBox1.Controls.Add(this.chkCronDuo);
            this.groupBox1.Controls.Add(this.chkCronTri);
            this.groupBox1.Controls.Add(this.chkCronTet);
            this.groupBox1.Location = new System.Drawing.Point(701, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(370, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cron Usage";
            // 
            // chkCronTet
            // 
            this.chkCronTet.AutoSize = true;
            this.chkCronTet.Location = new System.Drawing.Point(19, 176);
            this.chkCronTet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCronTet.Name = "chkCronTet";
            this.chkCronTet.Size = new System.Drawing.Size(141, 25);
            this.chkCronTet.TabIndex = 4;
            this.chkCronTet.Text = "Cron on Tet taps";
            this.chkCronTet.UseVisualStyleBackColor = true;
            // 
            // chkCronTri
            // 
            this.chkCronTri.AutoSize = true;
            this.chkCronTri.Location = new System.Drawing.Point(19, 143);
            this.chkCronTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCronTri.Name = "chkCronTri";
            this.chkCronTri.Size = new System.Drawing.Size(139, 25);
            this.chkCronTri.TabIndex = 5;
            this.chkCronTri.Text = "Cron on Tri taps";
            this.chkCronTri.UseVisualStyleBackColor = true;
            // 
            // chkCronDuo
            // 
            this.chkCronDuo.AutoSize = true;
            this.chkCronDuo.Location = new System.Drawing.Point(19, 110);
            this.chkCronDuo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCronDuo.Name = "chkCronDuo";
            this.chkCronDuo.Size = new System.Drawing.Size(151, 25);
            this.chkCronDuo.TabIndex = 6;
            this.chkCronDuo.Text = "Cron on Duo taps";
            this.chkCronDuo.UseVisualStyleBackColor = true;
            // 
            // chkCronPri
            // 
            this.chkCronPri.AutoSize = true;
            this.chkCronPri.Location = new System.Drawing.Point(19, 77);
            this.chkCronPri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCronPri.Name = "chkCronPri";
            this.chkCronPri.Size = new System.Drawing.Size(141, 25);
            this.chkCronPri.TabIndex = 7;
            this.chkCronPri.Text = "Cron on Pri taps";
            this.chkCronPri.UseVisualStyleBackColor = true;
            // 
            // chkCronPen
            // 
            this.chkCronPen.AutoSize = true;
            this.chkCronPen.Location = new System.Drawing.Point(19, 209);
            this.chkCronPen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCronPen.Name = "chkCronPen";
            this.chkCronPen.Size = new System.Drawing.Size(147, 25);
            this.chkCronPen.TabIndex = 8;
            this.chkCronPen.Text = "Cron on Pen taps";
            this.chkCronPen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPenSoftcapStack);
            this.groupBox2.Controls.Add(this.lblTriSoftcapStack);
            this.groupBox2.Controls.Add(this.lblTetSoftcapStack);
            this.groupBox2.Controls.Add(this.lblDuoSoftcapStack);
            this.groupBox2.Controls.Add(this.lblPriSoftcapStack);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nudDuoStack);
            this.groupBox2.Controls.Add(this.nudTetStack);
            this.groupBox2.Controls.Add(this.nudPenStack);
            this.groupBox2.Controls.Add(this.nudTriStack);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudPriStack);
            this.groupBox2.Location = new System.Drawing.Point(701, 360);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(414, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stack Size Used";
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Items.AddRange(new object[] {
            "Accessory (Green, Blue, Yellow)",
            "Weapon (Green)",
            "Weapon (Blue, Yellow)",
            "Weapon (Blackstar)",
            "Armor (Green)",
            "Armor (Blue, Yellow)",
            "Armor (Blackstar)",
            "Armor (Fallen God\'s)"});
            this.cmbItemType.Location = new System.Drawing.Point(159, 48);
            this.cmbItemType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(291, 29);
            this.cmbItemType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name";
            // 
            // cmbItemName
            // 
            this.cmbItemName.Enabled = false;
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(159, 111);
            this.cmbItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(291, 29);
            this.cmbItemName.TabIndex = 5;
            // 
            // nudPriStack
            // 
            this.nudPriStack.Enabled = false;
            this.nudPriStack.Location = new System.Drawing.Point(142, 73);
            this.nudPriStack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPriStack.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPriStack.Name = "nudPriStack";
            this.nudPriStack.Size = new System.Drawing.Size(120, 29);
            this.nudPriStack.TabIndex = 0;
            this.nudPriStack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tet stack size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tri stack size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Duo stack size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pri stack size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pen stack size";
            // 
            // nudTriStack
            // 
            this.nudTriStack.Enabled = false;
            this.nudTriStack.Location = new System.Drawing.Point(142, 153);
            this.nudTriStack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudTriStack.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTriStack.Name = "nudTriStack";
            this.nudTriStack.Size = new System.Drawing.Size(120, 29);
            this.nudTriStack.TabIndex = 10;
            this.nudTriStack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudPenStack
            // 
            this.nudPenStack.Enabled = false;
            this.nudPenStack.Location = new System.Drawing.Point(142, 235);
            this.nudPenStack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudPenStack.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPenStack.Name = "nudPenStack";
            this.nudPenStack.Size = new System.Drawing.Size(120, 29);
            this.nudPenStack.TabIndex = 11;
            this.nudPenStack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudTetStack
            // 
            this.nudTetStack.Enabled = false;
            this.nudTetStack.Location = new System.Drawing.Point(142, 194);
            this.nudTetStack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudTetStack.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTetStack.Name = "nudTetStack";
            this.nudTetStack.Size = new System.Drawing.Size(120, 29);
            this.nudTetStack.TabIndex = 12;
            this.nudTetStack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudDuoStack
            // 
            this.nudDuoStack.Enabled = false;
            this.nudDuoStack.Location = new System.Drawing.Point(142, 112);
            this.nudDuoStack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudDuoStack.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudDuoStack.Name = "nudDuoStack";
            this.nudDuoStack.Size = new System.Drawing.Size(120, 29);
            this.nudDuoStack.TabIndex = 13;
            this.nudDuoStack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.exitToolStripMenuItem.Text = "Menu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Softcap Stack";
            // 
            // lblPriCronsNeeded
            // 
            this.lblPriCronsNeeded.AutoSize = true;
            this.lblPriCronsNeeded.Location = new System.Drawing.Point(226, 78);
            this.lblPriCronsNeeded.Name = "lblPriCronsNeeded";
            this.lblPriCronsNeeded.Size = new System.Drawing.Size(24, 21);
            this.lblPriCronsNeeded.TabIndex = 9;
            this.lblPriCronsNeeded.Text = "( )";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Crons needed";
            // 
            // lblTriCronsNeeded
            // 
            this.lblTriCronsNeeded.AutoSize = true;
            this.lblTriCronsNeeded.Location = new System.Drawing.Point(226, 147);
            this.lblTriCronsNeeded.Name = "lblTriCronsNeeded";
            this.lblTriCronsNeeded.Size = new System.Drawing.Size(24, 21);
            this.lblTriCronsNeeded.TabIndex = 11;
            this.lblTriCronsNeeded.Text = "( )";
            // 
            // lblDuoCronsNeeded
            // 
            this.lblDuoCronsNeeded.AutoSize = true;
            this.lblDuoCronsNeeded.Location = new System.Drawing.Point(226, 114);
            this.lblDuoCronsNeeded.Name = "lblDuoCronsNeeded";
            this.lblDuoCronsNeeded.Size = new System.Drawing.Size(24, 21);
            this.lblDuoCronsNeeded.TabIndex = 12;
            this.lblDuoCronsNeeded.Text = "( )";
            // 
            // lblPenCronsNeeded
            // 
            this.lblPenCronsNeeded.AutoSize = true;
            this.lblPenCronsNeeded.Location = new System.Drawing.Point(226, 210);
            this.lblPenCronsNeeded.Name = "lblPenCronsNeeded";
            this.lblPenCronsNeeded.Size = new System.Drawing.Size(24, 21);
            this.lblPenCronsNeeded.TabIndex = 13;
            this.lblPenCronsNeeded.Text = "( )";
            // 
            // lblTetCronsNeeded
            // 
            this.lblTetCronsNeeded.AutoSize = true;
            this.lblTetCronsNeeded.Location = new System.Drawing.Point(226, 180);
            this.lblTetCronsNeeded.Name = "lblTetCronsNeeded";
            this.lblTetCronsNeeded.Size = new System.Drawing.Size(24, 21);
            this.lblTetCronsNeeded.TabIndex = 14;
            this.lblTetCronsNeeded.Text = "( )";
            // 
            // lblPriSoftcapStack
            // 
            this.lblPriSoftcapStack.AutoSize = true;
            this.lblPriSoftcapStack.Location = new System.Drawing.Point(290, 75);
            this.lblPriSoftcapStack.Name = "lblPriSoftcapStack";
            this.lblPriSoftcapStack.Size = new System.Drawing.Size(24, 21);
            this.lblPriSoftcapStack.TabIndex = 14;
            this.lblPriSoftcapStack.Text = "( )";
            // 
            // lblDuoSoftcapStack
            // 
            this.lblDuoSoftcapStack.AutoSize = true;
            this.lblDuoSoftcapStack.Location = new System.Drawing.Point(290, 114);
            this.lblDuoSoftcapStack.Name = "lblDuoSoftcapStack";
            this.lblDuoSoftcapStack.Size = new System.Drawing.Size(24, 21);
            this.lblDuoSoftcapStack.TabIndex = 15;
            this.lblDuoSoftcapStack.Text = "( )";
            // 
            // lblTetSoftcapStack
            // 
            this.lblTetSoftcapStack.AutoSize = true;
            this.lblTetSoftcapStack.Location = new System.Drawing.Point(290, 196);
            this.lblTetSoftcapStack.Name = "lblTetSoftcapStack";
            this.lblTetSoftcapStack.Size = new System.Drawing.Size(24, 21);
            this.lblTetSoftcapStack.TabIndex = 16;
            this.lblTetSoftcapStack.Text = "( )";
            // 
            // lblTriSoftcapStack
            // 
            this.lblTriSoftcapStack.AutoSize = true;
            this.lblTriSoftcapStack.Location = new System.Drawing.Point(290, 155);
            this.lblTriSoftcapStack.Name = "lblTriSoftcapStack";
            this.lblTriSoftcapStack.Size = new System.Drawing.Size(24, 21);
            this.lblTriSoftcapStack.TabIndex = 17;
            this.lblTriSoftcapStack.Text = "( )";
            // 
            // lblPenSoftcapStack
            // 
            this.lblPenSoftcapStack.AutoSize = true;
            this.lblPenSoftcapStack.Location = new System.Drawing.Point(290, 237);
            this.lblPenSoftcapStack.Name = "lblPenSoftcapStack";
            this.lblPenSoftcapStack.Size = new System.Drawing.Size(24, 21);
            this.lblPenSoftcapStack.TabIndex = 18;
            this.lblPenSoftcapStack.Text = "( )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Cron Cost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 457);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Current Item Cost";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "Base Item Cost (accessory only)";
            // 
            // nudBaseItemCost
            // 
            this.nudBaseItemCost.Enabled = false;
            this.nudBaseItemCost.Location = new System.Drawing.Point(330, 501);
            this.nudBaseItemCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudBaseItemCost.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudBaseItemCost.Name = "nudBaseItemCost";
            this.nudBaseItemCost.Size = new System.Drawing.Size(262, 29);
            this.nudBaseItemCost.TabIndex = 10;
            this.nudBaseItemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBaseItemCost.ThousandsSeparator = true;
            // 
            // nudCurItemCost
            // 
            this.nudCurItemCost.Enabled = false;
            this.nudCurItemCost.Location = new System.Drawing.Point(330, 449);
            this.nudCurItemCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCurItemCost.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudCurItemCost.Name = "nudCurItemCost";
            this.nudCurItemCost.Size = new System.Drawing.Size(262, 29);
            this.nudCurItemCost.TabIndex = 11;
            this.nudCurItemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCurItemCost.ThousandsSeparator = true;
            // 
            // nudCronCost
            // 
            this.nudCronCost.Enabled = false;
            this.nudCronCost.Location = new System.Drawing.Point(330, 400);
            this.nudCronCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCronCost.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudCronCost.Name = "nudCronCost";
            this.nudCronCost.Size = new System.Drawing.Size(262, 29);
            this.nudCronCost.TabIndex = 12;
            this.nudCronCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCronCost.ThousandsSeparator = true;
            this.nudCronCost.Value = new decimal(new int[] {
            1350000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 21);
            this.label14.TabIndex = 13;
            this.label14.Text = "Desired Level";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Current Item Level";
            // 
            // cmbDesiredItemLevel
            // 
            this.cmbDesiredItemLevel.Enabled = false;
            this.cmbDesiredItemLevel.FormattingEnabled = true;
            this.cmbDesiredItemLevel.Items.AddRange(new object[] {
            "Pri",
            "Duo",
            "Tri",
            "Tet",
            "Pen"});
            this.cmbDesiredItemLevel.Location = new System.Drawing.Point(329, 298);
            this.cmbDesiredItemLevel.Name = "cmbDesiredItemLevel";
            this.cmbDesiredItemLevel.Size = new System.Drawing.Size(103, 29);
            this.cmbDesiredItemLevel.TabIndex = 15;
            // 
            // cmbCurrentItemLevel
            // 
            this.cmbCurrentItemLevel.Enabled = false;
            this.cmbCurrentItemLevel.FormattingEnabled = true;
            this.cmbCurrentItemLevel.Items.AddRange(new object[] {
            "Pri",
            "Duo",
            "Tri",
            "Tet",
            "Pen"});
            this.cmbCurrentItemLevel.Location = new System.Drawing.Point(330, 252);
            this.cmbCurrentItemLevel.Name = "cmbCurrentItemLevel";
            this.cmbCurrentItemLevel.Size = new System.Drawing.Size(102, 29);
            this.cmbCurrentItemLevel.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 696);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 21);
            this.label17.TabIndex = 18;
            this.label17.Text = "Developed by: JG";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(438, 678);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(222, 39);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // EnhancementCalculatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 729);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbCurrentItemLevel);
            this.Controls.Add(this.cmbDesiredItemLevel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nudCronCost);
            this.Controls.Add(this.nudCurItemCost);
            this.Controls.Add(this.nudBaseItemCost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EnhancementCalculatorMainForm";
            this.Text = "BDO Enhancement Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTetStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuoStack)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseItemCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurItemCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCronCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkCronPen;
        private CheckBox chkCronPri;
        private CheckBox chkCronDuo;
        private CheckBox chkCronTri;
        private CheckBox chkCronTet;
        private GroupBox groupBox2;
        private NumericUpDown nudDuoStack;
        private NumericUpDown nudTetStack;
        private NumericUpDown nudPenStack;
        private NumericUpDown nudTriStack;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown nudPriStack;
        private ComboBox cmbItemType;
        private Label label1;
        private Label label3;
        private ComboBox cmbItemName;
        private Label lblTetCronsNeeded;
        private Label lblPenCronsNeeded;
        private Label lblDuoCronsNeeded;
        private Label lblTriCronsNeeded;
        private Label lblPriCronsNeeded;
        private Label label12;
        private Label lblPenSoftcapStack;
        private Label lblTriSoftcapStack;
        private Label lblTetSoftcapStack;
        private Label lblDuoSoftcapStack;
        private Label lblPriSoftcapStack;
        private Label label9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label10;
        private Label label11;
        private Label label13;
        private NumericUpDown nudBaseItemCost;
        private NumericUpDown nudCurItemCost;
        private NumericUpDown nudCronCost;
        private Label label14;
        private Label label15;
        private ComboBox cmbDesiredItemLevel;
        private ComboBox cmbCurrentItemLevel;
        private Label label17;
        private Button btnCalculate;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}