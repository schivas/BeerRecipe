namespace BeerRecipe
{
   partial class ModifyItem
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.txtMengdeKg = new System.Windows.Forms.TextBox();
         this.txtMengdePercent = new System.Windows.Forms.TextBox();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnOK = new System.Windows.Forms.Button();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.lblMalttype = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(8, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(55, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Malttype:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(195, 49);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(75, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Mengde (kg):";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(199, 77);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(71, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Mengde (%):";
         // 
         // txtMengdeKg
         // 
         this.txtMengdeKg.Location = new System.Drawing.Point(284, 44);
         this.txtMengdeKg.Name = "txtMengdeKg";
         this.txtMengdeKg.Size = new System.Drawing.Size(96, 22);
         this.txtMengdeKg.TabIndex = 1;
         this.txtMengdeKg.Enter += new System.EventHandler(this.OnEnter);
         this.txtMengdeKg.Leave += new System.EventHandler(this.OnLeave);
         this.txtMengdeKg.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
         // 
         // txtMengdePercent
         // 
         this.txtMengdePercent.Location = new System.Drawing.Point(284, 72);
         this.txtMengdePercent.Name = "txtMengdePercent";
         this.txtMengdePercent.Size = new System.Drawing.Size(96, 22);
         this.txtMengdePercent.TabIndex = 3;
         this.txtMengdePercent.Enter += new System.EventHandler(this.OnEnter);
         this.txtMengdePercent.Leave += new System.EventHandler(this.OnLeave);
         this.txtMengdePercent.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidating);
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(314, 117);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 5;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnOK
         // 
         this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnOK.Location = new System.Drawing.Point(210, 117);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 4;
         this.btnOK.Text = "OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // lblMalttype
         // 
         this.lblMalttype.BackColor = System.Drawing.SystemColors.Info;
         this.lblMalttype.Location = new System.Drawing.Point(68, 16);
         this.lblMalttype.Name = "lblMalttype";
         this.lblMalttype.Size = new System.Drawing.Size(312, 22);
         this.lblMalttype.TabIndex = 8;
         this.lblMalttype.Text = "Malttype:";
         this.lblMalttype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // ModifyItem
         // 
         this.AcceptButton = this.btnOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(397, 152);
         this.Controls.Add(this.lblMalttype);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.txtMengdePercent);
         this.Controls.Add(this.txtMengdeKg);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ModifyItem";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Modifiser";
         this.Load += new System.EventHandler(this.ModifyItem_Load);
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtMengdeKg;
      private System.Windows.Forms.TextBox txtMengdePercent;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.ErrorProvider errorProvider1;
      private System.Windows.Forms.Label lblMalttype;
   }
}