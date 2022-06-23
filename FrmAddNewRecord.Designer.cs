namespace ETEATestTask
{
    partial class FrmAddNewRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewRecord));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnic = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnsubmit = new DevExpress.XtraEditors.SimpleButton();
            this.txtdate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(963, 58);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(69, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 6691;
            this.label3.Text = "Date of Birth:";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(204, 239);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfname.Name = "txtfname";
            this.txtfname.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Properties.Appearance.Options.UseFont = true;
            this.txtfname.Size = new System.Drawing.Size(417, 36);
            this.txtfname.TabIndex = 6686;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(65, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 6690;
            this.label2.Text = "Father Name:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(204, 195);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Properties.Appearance.Options.UseFont = true;
            this.txtname.Size = new System.Drawing.Size(417, 36);
            this.txtname.TabIndex = 6685;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(33, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 6689;
            this.label1.Text = "Candidate Name:";
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(204, 149);
            this.txtnic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnic.Name = "txtnic";
            this.txtnic.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnic.Properties.Appearance.Options.UseFont = true;
            this.txtnic.Properties.Mask.EditMask = "00000-0000000-0";
            this.txtnic.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtnic.Size = new System.Drawing.Size(417, 36);
            this.txtnic.TabIndex = 6684;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(132, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 6688;
            this.label6.Text = "CNIC:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(658, 151);
            this.pictureEdit1.MenuManager = this.ribbonControl1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(254, 209);
            this.pictureEdit1.TabIndex = 6692;
            // 
            // btncancel
            // 
            this.btncancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Appearance.Options.UseFont = true;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.Location = new System.Drawing.Point(302, 389);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(153, 56);
            this.btncancel.TabIndex = 6694;
            this.btncancel.Text = "Cancel";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Appearance.Options.UseFont = true;
            this.btnsubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnsubmit.Image")));
            this.btnsubmit.Location = new System.Drawing.Point(464, 389);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(153, 56);
            this.btnsubmit.TabIndex = 6693;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtdate
            // 
            this.txtdate.EditValue = null;
            this.txtdate.Location = new System.Drawing.Point(204, 285);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdate.Name = "txtdate";
            this.txtdate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Properties.Appearance.Options.UseFont = true;
            this.txtdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdate.Properties.Mask.EditMask = "";
            this.txtdate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtdate.Size = new System.Drawing.Size(417, 36);
            this.txtdate.TabIndex = 6687;
            // 
            // FrmAddNewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 532);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewRecord";
            this.Ribbon = this.ribbonControl1;
            this.Text = "FrmAddNewRecord";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        internal System.Windows.Forms.Label label3;
        protected internal DevExpress.XtraEditors.TextEdit txtfname;
        internal System.Windows.Forms.Label label2;
        protected internal DevExpress.XtraEditors.TextEdit txtname;
        internal System.Windows.Forms.Label label1;
        protected internal DevExpress.XtraEditors.TextEdit txtnic;
        internal System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        protected internal DevExpress.XtraEditors.SimpleButton btncancel;
        protected internal DevExpress.XtraEditors.SimpleButton btnsubmit;
        private DevExpress.XtraEditors.DateEdit txtdate;
    }
}