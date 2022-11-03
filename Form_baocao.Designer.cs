
namespace Qly_KTX
{
    partial class Form_baocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_baocao));
            this.vbButton4 = new CustomButton.VBButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetRadioButton1 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.metroSetRadioButton2 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.metroSetRadioButton3 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.metroSetRadioButton4 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.vbButton5 = new CustomButton.VBButton();
            this.SuspendLayout();
            // 
            // vbButton4
            // 
            this.vbButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.vbButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.vbButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton4.BorderRadius = 20;
            this.vbButton4.BorderSize = 0;
            this.vbButton4.FlatAppearance.BorderSize = 0;
            this.vbButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton4.ForeColor = System.Drawing.Color.White;
            this.vbButton4.ImageIndex = 0;
            this.vbButton4.ImageList = this.imageList1;
            this.vbButton4.Location = new System.Drawing.Point(23, 17);
            this.vbButton4.Name = "vbButton4";
            this.vbButton4.Size = new System.Drawing.Size(115, 37);
            this.vbButton4.TabIndex = 5;
            this.vbButton4.TextColor = System.Drawing.Color.White;
            this.vbButton4.UseVisualStyleBackColor = false;
            this.vbButton4.Click += new System.EventHandler(this.vbButton4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "previous.png");
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(168, 50);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 4;
            this.metroSetLabel2.Text = "Báo cáo";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetRadioButton1
            // 
            this.metroSetRadioButton1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetRadioButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRadioButton1.Checked = false;
            this.metroSetRadioButton1.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetRadioButton1.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetRadioButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetRadioButton1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetRadioButton1.Group = 0;
            this.metroSetRadioButton1.IsDerivedStyle = true;
            this.metroSetRadioButton1.Location = new System.Drawing.Point(84, 146);
            this.metroSetRadioButton1.Name = "metroSetRadioButton1";
            this.metroSetRadioButton1.Size = new System.Drawing.Size(164, 17);
            this.metroSetRadioButton1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetRadioButton1.StyleManager = null;
            this.metroSetRadioButton1.TabIndex = 6;
            this.metroSetRadioButton1.Text = "Báo cáo cán bộ";
            this.metroSetRadioButton1.ThemeAuthor = "Narwin";
            this.metroSetRadioButton1.ThemeName = "MetroLite";
            // 
            // metroSetRadioButton2
            // 
            this.metroSetRadioButton2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetRadioButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRadioButton2.Checked = false;
            this.metroSetRadioButton2.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetRadioButton2.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetRadioButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetRadioButton2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetRadioButton2.Group = 0;
            this.metroSetRadioButton2.IsDerivedStyle = true;
            this.metroSetRadioButton2.Location = new System.Drawing.Point(84, 180);
            this.metroSetRadioButton2.Name = "metroSetRadioButton2";
            this.metroSetRadioButton2.Size = new System.Drawing.Size(164, 17);
            this.metroSetRadioButton2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetRadioButton2.StyleManager = null;
            this.metroSetRadioButton2.TabIndex = 6;
            this.metroSetRadioButton2.Text = "Báo cáo hóa đơn";
            this.metroSetRadioButton2.ThemeAuthor = "Narwin";
            this.metroSetRadioButton2.ThemeName = "MetroLite";
            // 
            // metroSetRadioButton3
            // 
            this.metroSetRadioButton3.BackgroundColor = System.Drawing.Color.White;
            this.metroSetRadioButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRadioButton3.Checked = false;
            this.metroSetRadioButton3.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetRadioButton3.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetRadioButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetRadioButton3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetRadioButton3.Group = 0;
            this.metroSetRadioButton3.IsDerivedStyle = true;
            this.metroSetRadioButton3.Location = new System.Drawing.Point(289, 146);
            this.metroSetRadioButton3.Name = "metroSetRadioButton3";
            this.metroSetRadioButton3.Size = new System.Drawing.Size(164, 17);
            this.metroSetRadioButton3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetRadioButton3.StyleManager = null;
            this.metroSetRadioButton3.TabIndex = 6;
            this.metroSetRadioButton3.Text = "Báo cáo khu phòng";
            this.metroSetRadioButton3.ThemeAuthor = "Narwin";
            this.metroSetRadioButton3.ThemeName = "MetroLite";
            // 
            // metroSetRadioButton4
            // 
            this.metroSetRadioButton4.BackgroundColor = System.Drawing.Color.White;
            this.metroSetRadioButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRadioButton4.Checked = false;
            this.metroSetRadioButton4.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetRadioButton4.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetRadioButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetRadioButton4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetRadioButton4.Group = 0;
            this.metroSetRadioButton4.IsDerivedStyle = true;
            this.metroSetRadioButton4.Location = new System.Drawing.Point(289, 180);
            this.metroSetRadioButton4.Name = "metroSetRadioButton4";
            this.metroSetRadioButton4.Size = new System.Drawing.Size(164, 17);
            this.metroSetRadioButton4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetRadioButton4.StyleManager = null;
            this.metroSetRadioButton4.TabIndex = 6;
            this.metroSetRadioButton4.Text = "Báo cáo dịch vụ";
            this.metroSetRadioButton4.ThemeAuthor = "Narwin";
            this.metroSetRadioButton4.ThemeName = "MetroLite";
            // 
            // vbButton5
            // 
            this.vbButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.vbButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.vbButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton5.BorderRadius = 20;
            this.vbButton5.BorderSize = 0;
            this.vbButton5.FlatAppearance.BorderSize = 0;
            this.vbButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton5.ForeColor = System.Drawing.Color.White;
            this.vbButton5.Location = new System.Drawing.Point(176, 251);
            this.vbButton5.Name = "vbButton5";
            this.vbButton5.Size = new System.Drawing.Size(150, 40);
            this.vbButton5.TabIndex = 7;
            this.vbButton5.Text = "Xem báo cáo";
            this.vbButton5.TextColor = System.Drawing.Color.White;
            this.vbButton5.UseVisualStyleBackColor = false;
            this.vbButton5.Click += new System.EventHandler(this.vbButton5_Click);
            // 
            // Form_baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.vbButton5);
            this.Controls.Add(this.metroSetRadioButton4);
            this.Controls.Add(this.metroSetRadioButton3);
            this.Controls.Add(this.metroSetRadioButton2);
            this.Controls.Add(this.metroSetRadioButton1);
            this.Controls.Add(this.vbButton4);
            this.Controls.Add(this.metroSetLabel2);
            this.Name = "Form_baocao";
            this.Load += new System.EventHandler(this.Form_baocao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton.VBButton vbButton4;
        private System.Windows.Forms.ImageList imageList1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetRadioButton metroSetRadioButton1;
        private MetroSet_UI.Controls.MetroSetRadioButton metroSetRadioButton2;
        private MetroSet_UI.Controls.MetroSetRadioButton metroSetRadioButton3;
        private MetroSet_UI.Controls.MetroSetRadioButton metroSetRadioButton4;
        private CustomButton.VBButton vbButton5;
    }
}