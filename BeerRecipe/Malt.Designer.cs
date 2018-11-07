namespace BeerRecipe
{
   partial class Malt
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Malt));
         this.listView1 = new System.Windows.Forms.ListView();
         this.chMalttype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chMalteri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chKornsort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chEnzymaktivitet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chFargebidrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chAnbefaltMengde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chSmaksbidrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chBruksområde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chKommentar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.btnOK = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.cboMaltLister = new System.Windows.Forms.ComboBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.txtFilter = new System.Windows.Forms.TextBox();
         this.chkFilterStartsWith = new System.Windows.Forms.CheckBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.txtPercentageAmount = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.SuspendLayout();
         // 
         // listView1
         // 
         this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMalttype,
            this.chMalteri,
            this.chKornsort,
            this.chME,
            this.chEnzymaktivitet,
            this.chFargebidrag,
            this.chAnbefaltMengde,
            this.chSmaksbidrag,
            this.chBruksområde,
            this.chKommentar});
         this.listView1.FullRowSelect = true;
         this.listView1.Location = new System.Drawing.Point(12, 37);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(560, 232);
         this.listView1.TabIndex = 10;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         this.listView1.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
         // 
         // chMalttype
         // 
         this.chMalttype.Text = "Malttype";
         this.chMalttype.Width = 150;
         // 
         // chMalteri
         // 
         this.chMalteri.Text = "Malteri";
         this.chMalteri.Width = 100;
         // 
         // chKornsort
         // 
         this.chKornsort.Text = "Kornsort";
         // 
         // chME
         // 
         this.chME.Text = "Sukkerbidrag (%)";
         this.chME.Width = 100;
         // 
         // chEnzymaktivitet
         // 
         this.chEnzymaktivitet.Text = "Enzymaktivitet";
         this.chEnzymaktivitet.Width = 85;
         // 
         // chFargebidrag
         // 
         this.chFargebidrag.Text = "Fargebidrag [EBC (L°)]";
         this.chFargebidrag.Width = 130;
         // 
         // chAnbefaltMengde
         // 
         this.chAnbefaltMengde.Text = "Anbefalt mengde";
         this.chAnbefaltMengde.Width = 105;
         // 
         // chSmaksbidrag
         // 
         this.chSmaksbidrag.Text = "Smaksbidrag";
         this.chSmaksbidrag.Width = 100;
         // 
         // chBruksområde
         // 
         this.chBruksområde.Text = "Bruksområde";
         this.chBruksområde.Width = 100;
         // 
         // chKommentar
         // 
         this.chKommentar.Text = "Kommentar";
         this.chKommentar.Width = 150;
         // 
         // btnOK
         // 
         this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnOK.Location = new System.Drawing.Point(393, 327);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 3;
         this.btnOK.Text = "OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(497, 327);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 4;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(218, 18);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(73, 13);
         this.label1.TabIndex = 13;
         this.label1.Text = "Maltsamling:";
         // 
         // cboMaltLister
         // 
         this.cboMaltLister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboMaltLister.FormattingEnabled = true;
         this.cboMaltLister.Location = new System.Drawing.Point(297, 15);
         this.cboMaltLister.Name = "cboMaltLister";
         this.cboMaltLister.Size = new System.Drawing.Size(199, 21);
         this.cboMaltLister.TabIndex = 1;
         this.cboMaltLister.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(15, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(16, 16);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pictureBox1.TabIndex = 15;
         this.pictureBox1.TabStop = false;
         // 
         // txtFilter
         // 
         this.txtFilter.Location = new System.Drawing.Point(37, 9);
         this.txtFilter.Name = "txtFilter";
         this.txtFilter.Size = new System.Drawing.Size(302, 22);
         this.txtFilter.TabIndex = 0;
         this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
         // 
         // chkFilterStartsWith
         // 
         this.chkFilterStartsWith.AutoSize = true;
         this.chkFilterStartsWith.Location = new System.Drawing.Point(345, 12);
         this.chkFilterStartsWith.Name = "chkFilterStartsWith";
         this.chkFilterStartsWith.Size = new System.Drawing.Size(81, 17);
         this.chkFilterStartsWith.TabIndex = 17;
         this.chkFilterStartsWith.Text = "Starts with";
         this.chkFilterStartsWith.UseVisualStyleBackColor = true;
         this.chkFilterStartsWith.CheckedChanged += new System.EventHandler(this.chkFilterStartsWith_CheckedChanged);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.txtPercentageAmount);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.cboMaltLister);
         this.groupBox1.Location = new System.Drawing.Point(15, 275);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(557, 46);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         // 
         // txtPercentageAmount
         // 
         this.txtPercentageAmount.Location = new System.Drawing.Point(119, 15);
         this.txtPercentageAmount.Name = "txtPercentageAmount";
         this.txtPercentageAmount.Size = new System.Drawing.Size(62, 22);
         this.txtPercentageAmount.TabIndex = 1;
         this.txtPercentageAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.txtPercentageAmount.TextChanged += new System.EventHandler(this.OnTextChanged);
         this.txtPercentageAmount.Enter += new System.EventHandler(this.OnEnter);
         this.txtPercentageAmount.Leave += new System.EventHandler(this.OnLeave);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 18);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(107, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Prosentvis mengde:";
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // Malt
         // 
         this.AcceptButton = this.btnOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(584, 361);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.chkFilterStartsWith);
         this.Controls.Add(this.txtFilter);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.listView1);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(500, 300);
         this.Name = "Malt";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Malt";
         this.Load += new System.EventHandler(this.Malt_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListView listView1;
      private System.Windows.Forms.ColumnHeader chMalttype;
      private System.Windows.Forms.ColumnHeader chMalteri;
      private System.Windows.Forms.ColumnHeader chKornsort;
      private System.Windows.Forms.ColumnHeader chME;
      private System.Windows.Forms.ColumnHeader chEnzymaktivitet;
      private System.Windows.Forms.ColumnHeader chFargebidrag;
      private System.Windows.Forms.ColumnHeader chAnbefaltMengde;
      private System.Windows.Forms.ColumnHeader chSmaksbidrag;
      private System.Windows.Forms.ColumnHeader chBruksområde;
      private System.Windows.Forms.ColumnHeader chKommentar;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cboMaltLister;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.TextBox txtFilter;
      private System.Windows.Forms.CheckBox chkFilterStartsWith;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox txtPercentageAmount;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ErrorProvider errorProvider1;
   }
}