namespace BeerRecipe
{
   partial class Form2
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.label1 = new System.Windows.Forms.Label();
         this.txtSluttVolum = new System.Windows.Forms.TextBox();
         this.txtBHE = new System.Windows.Forms.TextBox();
         this.lblBHE = new System.Windows.Forms.Label();
         this.txtKokevolum = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.lblEvaporation = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.lblEstimatedSG = new System.Windows.Forms.Label();
         this.txtMaltMengde = new System.Windows.Forms.TextBox();
         this.txtSkyllevann = new System.Windows.Forms.TextBox();
         this.txtMeskevolum = new System.Windows.Forms.TextBox();
         this.btnAdd = new System.Windows.Forms.Button();
         this.listView1 = new System.Windows.Forms.ListView();
         this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chBeskrivelse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chYield = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chPPG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chPotential = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chPlato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.btnDelete = new System.Windows.Forms.Button();
         this.txtOG = new System.Windows.Forms.TextBox();
         this.btnClearAll = new System.Windows.Forms.Button();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
         this.tsslSpring = new System.Windows.Forms.ToolStripStatusLabel();
         this.tsslTotalVolum = new System.Windows.Forms.ToolStripStatusLabel();
         this.txtMesketap = new System.Windows.Forms.TextBox();
         this.txtWGR = new System.Windows.Forms.TextBox();
         this.txtEvaporation = new System.Windows.Forms.TextBox();
         this.txtKoketid = new System.Windows.Forms.TextBox();
         this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.txtSG = new System.Windows.Forms.TextBox();
         this.txtVal_In = new System.Windows.Forms.TextBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.cbFrom = new System.Windows.Forms.ComboBox();
         this.lblConvertTo = new System.Windows.Forms.Label();
         this.label14 = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.btnConvert = new System.Windows.Forms.Button();
         this.txtVal_Out = new System.Windows.Forms.TextBox();
         this.lblTrubLoss = new System.Windows.Forms.Label();
         this.txtTrubLoss = new System.Windows.Forms.TextBox();
         this.lblKettleLoss = new System.Windows.Forms.Label();
         this.txtKettleLoss = new System.Windows.Forms.TextBox();
         this.chkAdjustForVolTempChangeInWater = new System.Windows.Forms.CheckBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.statusStrip1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.SuspendLayout();
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(16, 28);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(157, 14);
         this.label1.TabIndex = 0;
         this.label1.Text = "Ønsket sluttvolum [liter]:";
         this.toolTip1.SetToolTip(this.label1, "Settes til sluttvolumet oppgitt i oppskrift (batch size, altså volum som skal på " +
        "flaske)");
         // 
         // txtSluttVolum
         // 
         this.txtSluttVolum.Location = new System.Drawing.Point(201, 23);
         this.txtSluttVolum.Name = "txtSluttVolum";
         this.txtSluttVolum.Size = new System.Drawing.Size(62, 20);
         this.txtSluttVolum.TabIndex = 1;
         this.txtSluttVolum.Text = "0";
         this.txtSluttVolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtBHE
         // 
         this.txtBHE.Location = new System.Drawing.Point(201, 94);
         this.txtBHE.Name = "txtBHE";
         this.txtBHE.Size = new System.Drawing.Size(62, 20);
         this.txtBHE.TabIndex = 7;
         this.txtBHE.Text = "0";
         this.txtBHE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // lblBHE
         // 
         this.lblBHE.AutoSize = true;
         this.lblBHE.Location = new System.Drawing.Point(15, 99);
         this.lblBHE.Name = "lblBHE";
         this.lblBHE.Size = new System.Drawing.Size(99, 14);
         this.lblBHE.TabIndex = 6;
         this.lblBHE.Text = "Effektivitet [%]:";
         // 
         // txtKokevolum
         // 
         this.txtKokevolum.Location = new System.Drawing.Point(425, 8);
         this.txtKokevolum.Name = "txtKokevolum";
         this.txtKokevolum.ReadOnly = true;
         this.txtKokevolum.Size = new System.Drawing.Size(62, 20);
         this.txtKokevolum.TabIndex = 3;
         this.txtKokevolum.Text = "0";
         this.txtKokevolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(304, 13);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(114, 14);
         this.label3.TabIndex = 2;
         this.label3.Text = "Kokevolum [liter]:";
         this.toolTip1.SetToolTip(this.label3, "Avdampning + Ønsket sluttvolum");
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(304, 44);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(110, 14);
         this.label4.TabIndex = 8;
         this.label4.Text = "Maltmengde [kg]:";
         this.toolTip1.SetToolTip(this.label4, "Denne beregnes utifra valgt malt i tabell under.");
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(16, 54);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(72, 14);
         this.label5.TabIndex = 2;
         this.label5.Text = "Ønsket OG:";
         this.toolTip1.SetToolTip(this.label5, "Settes til Original Gravity (OG) oppgitt i oppskrift.");
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(507, 44);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(123, 14);
         this.label6.TabIndex = 10;
         this.label6.Text = "Skyllevolum [liter]:";
         this.toolTip1.SetToolTip(this.label6, "Skyllevann, eller på engelsk - sparge water. Brukes til å skylle ut sukkerrester " +
        "fra malten når meskingen er ferdig. Vil typisk ha en temp. på 78°C.");
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(15, 125);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(177, 14);
         this.label7.TabIndex = 8;
         this.label7.Text = "Mesketap [liter per kg malt]):";
         this.toolTip1.SetToolTip(this.label7, "Her kan du sette opp hvor mye vann malten vil stjele med seg per kg malt  (typisk" +
        " 0,8 liter).");
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(15, 107);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(158, 14);
         this.label8.TabIndex = 6;
         this.label8.Text = "Vann/malt forhold [liter]:";
         this.toolTip1.SetToolTip(this.label8, "Water to grain ratio (WGR), typisk 3.");
         // 
         // lblEvaporation
         // 
         this.lblEvaporation.AutoSize = true;
         this.lblEvaporation.Location = new System.Drawing.Point(15, 22);
         this.lblEvaporation.Name = "lblEvaporation";
         this.lblEvaporation.Size = new System.Drawing.Size(158, 14);
         this.lblEvaporation.TabIndex = 0;
         this.lblEvaporation.Text = "Avdampning [liter/time]:";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(15, 80);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(121, 14);
         this.label10.TabIndex = 4;
         this.label10.Text = "Koketid [minutter]:";
         this.toolTip1.SetToolTip(this.label10, "Angir hvor lenge vørteren skal koke (minutter).");
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(507, 13);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(121, 14);
         this.label11.TabIndex = 4;
         this.label11.Text = "Meskevolum [liter]:";
         this.toolTip1.SetToolTip(this.label11, "Meskevann, eller på engelsk - strike water. Dette er vannet som brukes til å mesk" +
        "e maltet. Vil typisk ha en temp. på 60°C til 70°C.");
         // 
         // lblEstimatedSG
         // 
         this.lblEstimatedSG.AutoSize = true;
         this.lblEstimatedSG.Location = new System.Drawing.Point(716, 13);
         this.lblEstimatedSG.Name = "lblEstimatedSG";
         this.lblEstimatedSG.Size = new System.Drawing.Size(110, 14);
         this.lblEstimatedSG.TabIndex = 6;
         this.lblEstimatedSG.Text = "SG etter mesking:";
         // 
         // txtMaltMengde
         // 
         this.txtMaltMengde.Location = new System.Drawing.Point(425, 38);
         this.txtMaltMengde.Name = "txtMaltMengde";
         this.txtMaltMengde.ReadOnly = true;
         this.txtMaltMengde.Size = new System.Drawing.Size(62, 20);
         this.txtMaltMengde.TabIndex = 9;
         this.txtMaltMengde.Text = "0";
         this.txtMaltMengde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtSkyllevann
         // 
         this.txtSkyllevann.BackColor = System.Drawing.SystemColors.Info;
         this.txtSkyllevann.Location = new System.Drawing.Point(628, 38);
         this.txtSkyllevann.Name = "txtSkyllevann";
         this.txtSkyllevann.ReadOnly = true;
         this.txtSkyllevann.Size = new System.Drawing.Size(62, 20);
         this.txtSkyllevann.TabIndex = 11;
         this.txtSkyllevann.Text = "0";
         this.txtSkyllevann.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtMeskevolum
         // 
         this.txtMeskevolum.BackColor = System.Drawing.SystemColors.Info;
         this.txtMeskevolum.Location = new System.Drawing.Point(628, 8);
         this.txtMeskevolum.Name = "txtMeskevolum";
         this.txtMeskevolum.ReadOnly = true;
         this.txtMeskevolum.Size = new System.Drawing.Size(62, 20);
         this.txtMeskevolum.TabIndex = 5;
         this.txtMeskevolum.Text = "0";
         this.txtMeskevolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnAdd
         // 
         this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnAdd.Location = new System.Drawing.Point(853, 421);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(87, 25);
         this.btnAdd.TabIndex = 14;
         this.btnAdd.Text = "Add";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.OnAddItem);
         // 
         // listView1
         // 
         this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAmount,
            this.chBeskrivelse,
            this.chYield,
            this.chPPG,
            this.chPotential,
            this.chPlato});
         this.listView1.FullRowSelect = true;
         this.listView1.Location = new System.Drawing.Point(9, 18);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(830, 309);
         this.listView1.TabIndex = 0;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         this.listView1.DoubleClick += new System.EventHandler(this.OnDoubleClicked);
         // 
         // chAmount
         // 
         this.chAmount.Text = "Mengde kg (%)";
         this.chAmount.Width = 100;
         // 
         // chBeskrivelse
         // 
         this.chBeskrivelse.Text = "Beskrivelse";
         this.chBeskrivelse.Width = 200;
         // 
         // chYield
         // 
         this.chYield.Text = "Effektivitet (%)";
         this.chYield.Width = 85;
         // 
         // chPPG
         // 
         this.chPPG.Text = "PPG (Points/Pound/Gallon)";
         this.chPPG.Width = 150;
         // 
         // chPotential
         // 
         this.chPotential.Text = "Potensial (gravity)";
         this.chPotential.Width = 105;
         // 
         // chPlato
         // 
         this.chPlato.Text = "°P (Plato)";
         // 
         // btnDelete
         // 
         this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnDelete.Location = new System.Drawing.Point(953, 421);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(87, 25);
         this.btnDelete.TabIndex = 15;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.OnDeleteItem);
         // 
         // txtOG
         // 
         this.txtOG.Location = new System.Drawing.Point(201, 49);
         this.txtOG.Name = "txtOG";
         this.txtOG.Size = new System.Drawing.Size(62, 20);
         this.txtOG.TabIndex = 3;
         this.txtOG.Text = "0";
         this.txtOG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnClearAll
         // 
         this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnClearAll.Location = new System.Drawing.Point(1053, 421);
         this.btnClearAll.Name = "btnClearAll";
         this.btnClearAll.Size = new System.Drawing.Size(87, 25);
         this.btnClearAll.TabIndex = 16;
         this.btnClearAll.Text = "Clear all";
         this.btnClearAll.UseVisualStyleBackColor = true;
         this.btnClearAll.Click += new System.EventHandler(this.OnClearItems);
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslSpring,
            this.tsslTotalVolum});
         this.statusStrip1.Location = new System.Drawing.Point(0, 456);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
         this.statusStrip1.Size = new System.Drawing.Size(1147, 22);
         this.statusStrip1.TabIndex = 18;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // tsslStatus
         // 
         this.tsslStatus.Name = "tsslStatus";
         this.tsslStatus.Size = new System.Drawing.Size(39, 17);
         this.tsslStatus.Text = "Ready";
         // 
         // tsslSpring
         // 
         this.tsslSpring.Name = "tsslSpring";
         this.tsslSpring.Size = new System.Drawing.Size(1087, 17);
         this.tsslSpring.Spring = true;
         // 
         // tsslTotalVolum
         // 
         this.tsslTotalVolum.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
         this.tsslTotalVolum.Name = "tsslTotalVolum";
         this.tsslTotalVolum.Size = new System.Drawing.Size(4, 17);
         this.tsslTotalVolum.ToolTipText = "Total maltmengde (%)";
         // 
         // txtMesketap
         // 
         this.txtMesketap.Location = new System.Drawing.Point(201, 120);
         this.txtMesketap.Name = "txtMesketap";
         this.txtMesketap.Size = new System.Drawing.Size(62, 20);
         this.txtMesketap.TabIndex = 9;
         this.txtMesketap.Text = "0";
         this.txtMesketap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtWGR
         // 
         this.txtWGR.Location = new System.Drawing.Point(201, 101);
         this.txtWGR.Name = "txtWGR";
         this.txtWGR.Size = new System.Drawing.Size(62, 20);
         this.txtWGR.TabIndex = 7;
         this.txtWGR.Text = "0";
         this.txtWGR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtEvaporation
         // 
         this.txtEvaporation.Location = new System.Drawing.Point(201, 16);
         this.txtEvaporation.Name = "txtEvaporation";
         this.txtEvaporation.Size = new System.Drawing.Size(62, 20);
         this.txtEvaporation.TabIndex = 1;
         this.txtEvaporation.Text = "0";
         this.txtEvaporation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtKoketid
         // 
         this.txtKoketid.Location = new System.Drawing.Point(201, 75);
         this.txtKoketid.Name = "txtKoketid";
         this.txtKoketid.Size = new System.Drawing.Size(62, 20);
         this.txtKoketid.TabIndex = 5;
         this.txtKoketid.Text = "0";
         this.txtKoketid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.listView1);
         this.groupBox1.Location = new System.Drawing.Point(298, 70);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(849, 338);
         this.groupBox1.TabIndex = 13;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Ingredienser ";
         // 
         // txtSG
         // 
         this.txtSG.Location = new System.Drawing.Point(836, 10);
         this.txtSG.Name = "txtSG";
         this.txtSG.ReadOnly = true;
         this.txtSG.Size = new System.Drawing.Size(62, 20);
         this.txtSG.TabIndex = 7;
         this.txtSG.Text = "0";
         this.txtSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtVal_In
         // 
         this.txtVal_In.Location = new System.Drawing.Point(177, 14);
         this.txtVal_In.Name = "txtVal_In";
         this.txtVal_In.Size = new System.Drawing.Size(46, 20);
         this.txtVal_In.TabIndex = 1;
         this.txtVal_In.Text = "68";
         this.txtVal_In.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.cbFrom);
         this.groupBox2.Controls.Add(this.lblConvertTo);
         this.groupBox2.Controls.Add(this.label14);
         this.groupBox2.Controls.Add(this.label13);
         this.groupBox2.Controls.Add(this.btnConvert);
         this.groupBox2.Controls.Add(this.txtVal_Out);
         this.groupBox2.Controls.Add(this.txtVal_In);
         this.groupBox2.Location = new System.Drawing.Point(8, 337);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(275, 107);
         this.groupBox2.TabIndex = 17;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Temperaturomregner";
         // 
         // cbFrom
         // 
         this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbFrom.FormattingEnabled = true;
         this.cbFrom.Items.AddRange(new object[] {
            "°C",
            "°F"});
         this.cbFrom.Location = new System.Drawing.Point(226, 15);
         this.cbFrom.Name = "cbFrom";
         this.cbFrom.Size = new System.Drawing.Size(41, 22);
         this.cbFrom.TabIndex = 2;
         this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
         // 
         // lblConvertTo
         // 
         this.lblConvertTo.AutoSize = true;
         this.lblConvertTo.Location = new System.Drawing.Point(226, 54);
         this.lblConvertTo.Name = "lblConvertTo";
         this.lblConvertTo.Size = new System.Drawing.Size(19, 14);
         this.lblConvertTo.TabIndex = 5;
         this.lblConvertTo.Tag = "";
         this.lblConvertTo.Text = "°F";
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(153, 54);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(20, 14);
         this.label14.TabIndex = 3;
         this.label14.Text = "til";
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(146, 19);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(27, 14);
         this.label13.TabIndex = 0;
         this.label13.Text = "Fra";
         // 
         // btnConvert
         // 
         this.btnConvert.Location = new System.Drawing.Point(159, 76);
         this.btnConvert.Name = "btnConvert";
         this.btnConvert.Size = new System.Drawing.Size(112, 25);
         this.btnConvert.TabIndex = 6;
         this.btnConvert.Text = "Regn om";
         this.btnConvert.UseVisualStyleBackColor = true;
         this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
         // 
         // txtVal_Out
         // 
         this.txtVal_Out.Location = new System.Drawing.Point(177, 48);
         this.txtVal_Out.Name = "txtVal_Out";
         this.txtVal_Out.ReadOnly = true;
         this.txtVal_Out.Size = new System.Drawing.Size(46, 20);
         this.txtVal_Out.TabIndex = 4;
         this.txtVal_Out.Text = "0";
         this.txtVal_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // lblTrubLoss
         // 
         this.lblTrubLoss.AutoSize = true;
         this.lblTrubLoss.Location = new System.Drawing.Point(16, 74);
         this.lblTrubLoss.Name = "lblTrubLoss";
         this.lblTrubLoss.Size = new System.Drawing.Size(83, 14);
         this.lblTrubLoss.TabIndex = 4;
         this.lblTrubLoss.Text = "Gjæringstap:";
         // 
         // txtTrubLoss
         // 
         this.txtTrubLoss.Location = new System.Drawing.Point(201, 68);
         this.txtTrubLoss.Name = "txtTrubLoss";
         this.txtTrubLoss.Size = new System.Drawing.Size(62, 20);
         this.txtTrubLoss.TabIndex = 5;
         this.txtTrubLoss.Text = "0";
         this.txtTrubLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // lblKettleLoss
         // 
         this.lblKettleLoss.AutoSize = true;
         this.lblKettleLoss.Location = new System.Drawing.Point(16, 48);
         this.lblKettleLoss.Name = "lblKettleLoss";
         this.lblKettleLoss.Size = new System.Drawing.Size(89, 14);
         this.lblKettleLoss.TabIndex = 2;
         this.lblKettleLoss.Text = "Tap i kokekar:";
         // 
         // txtKettleLoss
         // 
         this.txtKettleLoss.Location = new System.Drawing.Point(201, 42);
         this.txtKettleLoss.Name = "txtKettleLoss";
         this.txtKettleLoss.Size = new System.Drawing.Size(62, 20);
         this.txtKettleLoss.TabIndex = 3;
         this.txtKettleLoss.Text = "0";
         this.txtKettleLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // chkAdjustForVolTempChangeInWater
         // 
         this.chkAdjustForVolTempChangeInWater.AutoSize = true;
         this.chkAdjustForVolTempChangeInWater.Location = new System.Drawing.Point(719, 42);
         this.chkAdjustForVolTempChangeInWater.Name = "chkAdjustForVolTempChangeInWater";
         this.chkAdjustForVolTempChangeInWater.Size = new System.Drawing.Size(267, 18);
         this.chkAdjustForVolTempChangeInWater.TabIndex = 12;
         this.chkAdjustForVolTempChangeInWater.Text = "Juster for tetthet av vann vs. temperatur";
         this.chkAdjustForVolTempChangeInWater.UseVisualStyleBackColor = true;
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.txtEvaporation);
         this.groupBox3.Controls.Add(this.lblEvaporation);
         this.groupBox3.Controls.Add(this.txtTrubLoss);
         this.groupBox3.Controls.Add(this.lblTrubLoss);
         this.groupBox3.Controls.Add(this.txtKettleLoss);
         this.groupBox3.Controls.Add(this.lblKettleLoss);
         this.groupBox3.Controls.Add(this.txtBHE);
         this.groupBox3.Controls.Add(this.lblBHE);
         this.groupBox3.Controls.Add(this.txtMesketap);
         this.groupBox3.Controls.Add(this.label7);
         this.groupBox3.Location = new System.Drawing.Point(8, 166);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(275, 159);
         this.groupBox3.TabIndex = 1;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Utstyr etc.";
         // 
         // groupBox4
         // 
         this.groupBox4.Controls.Add(this.txtSluttVolum);
         this.groupBox4.Controls.Add(this.label1);
         this.groupBox4.Controls.Add(this.txtOG);
         this.groupBox4.Controls.Add(this.label5);
         this.groupBox4.Controls.Add(this.txtKoketid);
         this.groupBox4.Controls.Add(this.label10);
         this.groupBox4.Controls.Add(this.txtWGR);
         this.groupBox4.Controls.Add(this.label8);
         this.groupBox4.Location = new System.Drawing.Point(8, 13);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(275, 141);
         this.groupBox4.TabIndex = 0;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Oppskrift ";
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1147, 478);
         this.Controls.Add(this.groupBox4);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.chkAdjustForVolTempChangeInWater);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.txtSG);
         this.Controls.Add(this.lblEstimatedSG);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.txtMeskevolum);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.txtSkyllevann);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.btnClearAll);
         this.Controls.Add(this.txtMaltMengde);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.txtKokevolum);
         this.Controls.Add(this.label3);
         this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(1160, 515);
         this.Name = "Form2";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Beer Recipe - Humlepungene - 2";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.ErrorProvider errorProvider1;
      private System.Windows.Forms.TextBox txtBHE;
      private System.Windows.Forms.Label lblBHE;
      private System.Windows.Forms.TextBox txtSluttVolum;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtKokevolum;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.ListView listView1;
      private System.Windows.Forms.ColumnHeader chAmount;
      private System.Windows.Forms.ColumnHeader chBeskrivelse;
      private System.Windows.Forms.ColumnHeader chYield;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.TextBox txtMaltMengde;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtOG;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button btnClearAll;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
      private System.Windows.Forms.ToolStripStatusLabel tsslSpring;
      private System.Windows.Forms.ToolStripStatusLabel tsslTotalVolum;
      private System.Windows.Forms.TextBox txtSkyllevann;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox txtMesketap;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox txtWGR;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label lblEvaporation;
      private System.Windows.Forms.TextBox txtEvaporation;
      private System.Windows.Forms.TextBox txtKoketid;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.TextBox txtMeskevolum;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.ToolTip toolTip2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ColumnHeader chPPG;
      private System.Windows.Forms.TextBox txtSG;
      private System.Windows.Forms.Label lblEstimatedSG;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button btnConvert;
      private System.Windows.Forms.TextBox txtVal_Out;
      private System.Windows.Forms.TextBox txtVal_In;
      private System.Windows.Forms.Label lblConvertTo;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.ComboBox cbFrom;
      private System.Windows.Forms.ColumnHeader chPotential;
      private System.Windows.Forms.ColumnHeader chPlato;
      private System.Windows.Forms.Label lblTrubLoss;
      private System.Windows.Forms.TextBox txtTrubLoss;
      private System.Windows.Forms.TextBox txtKettleLoss;
      private System.Windows.Forms.Label lblKettleLoss;
      private System.Windows.Forms.CheckBox chkAdjustForVolTempChangeInWater;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.GroupBox groupBox3;
   }
}

