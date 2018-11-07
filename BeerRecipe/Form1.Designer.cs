namespace BeerRecipe
{
   partial class Form1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.label1 = new System.Windows.Forms.Label();
         this.txtSluttVolum = new System.Windows.Forms.TextBox();
         this.txtBHE = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtKokevolum = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.txtMaltMengde = new System.Windows.Forms.TextBox();
         this.txtSkyllevann = new System.Windows.Forms.TextBox();
         this.txtMeskevolum = new System.Windows.Forms.TextBox();
         this.btnAdd = new System.Windows.Forms.Button();
         this.listView1 = new System.Windows.Forms.ListView();
         this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chBeskrivelse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chYield = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chPPG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.statusStrip1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(5, 18);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(133, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Ønsket sluttvolum [liter]:";
         this.toolTip1.SetToolTip(this.label1, "Settes til sluttvolumet oppgitt i oppskrift.");
         // 
         // txtSluttVolum
         // 
         this.txtSluttVolum.Location = new System.Drawing.Point(164, 13);
         this.txtSluttVolum.Name = "txtSluttVolum";
         this.txtSluttVolum.Size = new System.Drawing.Size(40, 22);
         this.txtSluttVolum.TabIndex = 1;
         this.txtSluttVolum.Text = "0";
         this.txtSluttVolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtBHE
         // 
         this.txtBHE.Location = new System.Drawing.Point(164, 129);
         this.txtBHE.Name = "txtBHE";
         this.txtBHE.Size = new System.Drawing.Size(40, 22);
         this.txtBHE.TabIndex = 9;
         this.txtBHE.Text = "0";
         this.txtBHE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(4, 134);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(83, 13);
         this.label2.TabIndex = 8;
         this.label2.Text = "Effektivitet [%]:";
         this.toolTip1.SetToolTip(this.label2, "Bryggehuseffektivitet (Brew House Efficiency - BHE), settes iht. til utstyr (alt " +
        "fra 60 - 80 %, typisk 75 %)");
         // 
         // txtKokevolum
         // 
         this.txtKokevolum.Location = new System.Drawing.Point(351, 13);
         this.txtKokevolum.Name = "txtKokevolum";
         this.txtKokevolum.ReadOnly = true;
         this.txtKokevolum.Size = new System.Drawing.Size(53, 22);
         this.txtKokevolum.TabIndex = 15;
         this.txtKokevolum.Text = "0";
         this.txtKokevolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(247, 18);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(95, 13);
         this.label3.TabIndex = 14;
         this.label3.Text = "Kokevolum [liter]:";
         this.toolTip1.SetToolTip(this.label3, "Avdampning + Ønsket sluttvolum");
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(247, 46);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(97, 13);
         this.label4.TabIndex = 16;
         this.label4.Text = "Maltmengde [kg]:";
         this.toolTip1.SetToolTip(this.label4, "Denne beregnes utifra valgt malt i tabell under.");
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(5, 47);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(67, 13);
         this.label5.TabIndex = 2;
         this.label5.Text = "Ønsket OG:";
         this.toolTip1.SetToolTip(this.label5, "Settes til Original Gravity (OG) oppgitt i oppskrift.");
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(421, 46);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(99, 13);
         this.label6.TabIndex = 20;
         this.label6.Text = "Skyllevolum [liter]:";
         this.toolTip1.SetToolTip(this.label6, "Skyllevann, eller på engelsk - sparge water. Brukes til å skylle ut sukkerrester " +
        "fra malten når meskingen er ferdig. Vil typisk ha en temp. på 78°C.");
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(4, 163);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(153, 13);
         this.label7.TabIndex = 10;
         this.label7.Text = "Mesketap [liter per kg malt]):";
         this.toolTip1.SetToolTip(this.label7, "Her kan du sette opp hvor mye vann malten vil stjele med seg per kg malt  (typisk" +
        " 0,8 liter).");
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(4, 192);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(133, 13);
         this.label8.TabIndex = 12;
         this.label8.Text = "Vann/malt forhold [liter]:";
         this.toolTip1.SetToolTip(this.label8, "Water to grain ratio (WGR), typisk 3.");
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(4, 105);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(130, 13);
         this.label9.TabIndex = 6;
         this.label9.Text = "Avdampning [liter/time]:";
         this.toolTip1.SetToolTip(this.label9, "Et mål for hvor mye vann som fordamper under koking.");
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(4, 76);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(102, 13);
         this.label10.TabIndex = 4;
         this.label10.Text = "Koketid [minutter]:";
         this.toolTip1.SetToolTip(this.label10, "Angir hvor lenge vørteren skal koke (minutter).");
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(421, 18);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(103, 13);
         this.label11.TabIndex = 18;
         this.label11.Text = "Meskevolum [liter]:";
         this.toolTip1.SetToolTip(this.label11, "Meskevann, eller på engelsk - strike water. Dette er vannet som brukes til å mesk" +
        "e maltet. Vil typisk ha en temp. på 60°C til 70°C.");
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(600, 18);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(97, 13);
         this.label12.TabIndex = 28;
         this.label12.Text = "SG etter mesking:";
         this.toolTip1.SetToolTip(this.label12, "Måle på SG etter mesking, før koking. Kan brukes til å regulere OG slik at den bl" +
        "ir korrekt i forhold til oppskriften.");
         // 
         // txtMaltMengde
         // 
         this.txtMaltMengde.Location = new System.Drawing.Point(351, 41);
         this.txtMaltMengde.Name = "txtMaltMengde";
         this.txtMaltMengde.ReadOnly = true;
         this.txtMaltMengde.Size = new System.Drawing.Size(53, 22);
         this.txtMaltMengde.TabIndex = 17;
         this.txtMaltMengde.Text = "0";
         this.txtMaltMengde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtSkyllevann
         // 
         this.txtSkyllevann.Location = new System.Drawing.Point(525, 41);
         this.txtSkyllevann.Name = "txtSkyllevann";
         this.txtSkyllevann.ReadOnly = true;
         this.txtSkyllevann.Size = new System.Drawing.Size(53, 22);
         this.txtSkyllevann.TabIndex = 21;
         this.txtSkyllevann.Text = "0";
         this.txtSkyllevann.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtMeskevolum
         // 
         this.txtMeskevolum.Location = new System.Drawing.Point(525, 13);
         this.txtMeskevolum.Name = "txtMeskevolum";
         this.txtMeskevolum.ReadOnly = true;
         this.txtMeskevolum.Size = new System.Drawing.Size(53, 22);
         this.txtMeskevolum.TabIndex = 19;
         this.txtMeskevolum.Text = "0";
         this.txtMeskevolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnAdd
         // 
         this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnAdd.Location = new System.Drawing.Point(561, 362);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(75, 23);
         this.btnAdd.TabIndex = 22;
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
            this.chPPG});
         this.listView1.FullRowSelect = true;
         this.listView1.Location = new System.Drawing.Point(8, 17);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(542, 258);
         this.listView1.TabIndex = 25;
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
         this.chBeskrivelse.Width = 280;
         // 
         // chYield
         // 
         this.chYield.Text = "Effektivitet (%)";
         this.chYield.Width = 100;
         // 
         // chPPG
         // 
         this.chPPG.Text = "PPG";
         // 
         // btnDelete
         // 
         this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnDelete.Location = new System.Drawing.Point(647, 362);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(75, 23);
         this.btnDelete.TabIndex = 23;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.OnDeleteItem);
         // 
         // txtOG
         // 
         this.txtOG.Location = new System.Drawing.Point(164, 42);
         this.txtOG.Name = "txtOG";
         this.txtOG.Size = new System.Drawing.Size(40, 22);
         this.txtOG.TabIndex = 3;
         this.txtOG.Text = "0";
         this.txtOG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnClearAll
         // 
         this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnClearAll.Location = new System.Drawing.Point(733, 362);
         this.btnClearAll.Name = "btnClearAll";
         this.btnClearAll.Size = new System.Drawing.Size(75, 23);
         this.btnClearAll.TabIndex = 24;
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
         this.statusStrip1.Location = new System.Drawing.Point(0, 393);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(813, 22);
         this.statusStrip1.TabIndex = 26;
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
         this.tsslSpring.Size = new System.Drawing.Size(755, 17);
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
         this.txtMesketap.Location = new System.Drawing.Point(164, 158);
         this.txtMesketap.Name = "txtMesketap";
         this.txtMesketap.Size = new System.Drawing.Size(40, 22);
         this.txtMesketap.TabIndex = 11;
         this.txtMesketap.Text = "0";
         this.txtMesketap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtWGR
         // 
         this.txtWGR.Location = new System.Drawing.Point(164, 187);
         this.txtWGR.Name = "txtWGR";
         this.txtWGR.Size = new System.Drawing.Size(40, 22);
         this.txtWGR.TabIndex = 13;
         this.txtWGR.Text = "0";
         this.txtWGR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtEvaporation
         // 
         this.txtEvaporation.Location = new System.Drawing.Point(164, 100);
         this.txtEvaporation.Name = "txtEvaporation";
         this.txtEvaporation.Size = new System.Drawing.Size(40, 22);
         this.txtEvaporation.TabIndex = 7;
         this.txtEvaporation.Text = "0";
         this.txtEvaporation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtKoketid
         // 
         this.txtKoketid.Location = new System.Drawing.Point(164, 71);
         this.txtKoketid.Name = "txtKoketid";
         this.txtKoketid.Size = new System.Drawing.Size(40, 22);
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
         this.groupBox1.Location = new System.Drawing.Point(250, 71);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(558, 285);
         this.groupBox1.TabIndex = 27;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Ingredienser ";
         // 
         // txtSG
         // 
         this.txtSG.Location = new System.Drawing.Point(703, 15);
         this.txtSG.Name = "txtSG";
         this.txtSG.ReadOnly = true;
         this.txtSG.Size = new System.Drawing.Size(53, 22);
         this.txtSG.TabIndex = 29;
         this.txtSG.Text = "0";
         this.txtSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtVal_In
         // 
         this.txtVal_In.Location = new System.Drawing.Point(152, 13);
         this.txtVal_In.Name = "txtVal_In";
         this.txtVal_In.Size = new System.Drawing.Size(40, 22);
         this.txtVal_In.TabIndex = 30;
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
         this.groupBox2.Location = new System.Drawing.Point(12, 257);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(234, 99);
         this.groupBox2.TabIndex = 31;
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
         this.cbFrom.Location = new System.Drawing.Point(194, 14);
         this.cbFrom.Name = "cbFrom";
         this.cbFrom.Size = new System.Drawing.Size(36, 21);
         this.cbFrom.TabIndex = 39;
         this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
         // 
         // lblConvertTo
         // 
         this.lblConvertTo.AutoSize = true;
         this.lblConvertTo.Location = new System.Drawing.Point(194, 50);
         this.lblConvertTo.Name = "lblConvertTo";
         this.lblConvertTo.Size = new System.Drawing.Size(17, 13);
         this.lblConvertTo.TabIndex = 38;
         this.lblConvertTo.Tag = "";
         this.lblConvertTo.Text = "°F";
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(131, 50);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(17, 13);
         this.label14.TabIndex = 36;
         this.label14.Text = "til";
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(125, 18);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(23, 13);
         this.label13.TabIndex = 35;
         this.label13.Text = "Fra";
         // 
         // btnConvert
         // 
         this.btnConvert.Location = new System.Drawing.Point(136, 71);
         this.btnConvert.Name = "btnConvert";
         this.btnConvert.Size = new System.Drawing.Size(96, 23);
         this.btnConvert.TabIndex = 34;
         this.btnConvert.Text = "Regn om";
         this.btnConvert.UseVisualStyleBackColor = true;
         this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
         // 
         // txtVal_Out
         // 
         this.txtVal_Out.Location = new System.Drawing.Point(152, 45);
         this.txtVal_Out.Name = "txtVal_Out";
         this.txtVal_Out.ReadOnly = true;
         this.txtVal_Out.Size = new System.Drawing.Size(40, 22);
         this.txtVal_Out.TabIndex = 33;
         this.txtVal_Out.Text = "0";
         this.txtVal_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(813, 415);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.txtSG);
         this.Controls.Add(this.label12);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.txtMeskevolum);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.txtKoketid);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.txtEvaporation);
         this.Controls.Add(this.txtWGR);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.txtMesketap);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.txtSkyllevann);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.btnClearAll);
         this.Controls.Add(this.txtOG);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtMaltMengde);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.txtKokevolum);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtBHE);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtSluttVolum);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(600, 300);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Beer Recipe - Humlepungene";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.ErrorProvider errorProvider1;
      private System.Windows.Forms.TextBox txtBHE;
      private System.Windows.Forms.Label label2;
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
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox txtEvaporation;
      private System.Windows.Forms.TextBox txtKoketid;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.TextBox txtMeskevolum;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.ToolTip toolTip2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ColumnHeader chPPG;
      private System.Windows.Forms.TextBox txtSG;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button btnConvert;
      private System.Windows.Forms.TextBox txtVal_Out;
      private System.Windows.Forms.TextBox txtVal_In;
      private System.Windows.Forms.Label lblConvertTo;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.ComboBox cbFrom;
   }
}

