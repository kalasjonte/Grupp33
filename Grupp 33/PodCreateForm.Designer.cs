
namespace Grupp_33
{
    partial class PodCreateForm
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
            this.lblHeadtitle = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUpdFreq = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.coBoxCat = new System.Windows.Forms.ComboBox();
            this.coBoxUpdFreq = new System.Windows.Forms.ComboBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeadtitle
            // 
            this.lblHeadtitle.AutoSize = true;
            this.lblHeadtitle.Location = new System.Drawing.Point(466, 60);
            this.lblHeadtitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeadtitle.Name = "lblHeadtitle";
            this.lblHeadtitle.Size = new System.Drawing.Size(521, 32);
            this.lblHeadtitle.TabIndex = 0;
            this.lblHeadtitle.Text = "Här kan du lägga till en podd till ditt feed";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(284, 155);
            this.lblURL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(79, 32);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(292, 282);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Titel:";
            // 
            // lblUpdFreq
            // 
            this.lblUpdFreq.AutoSize = true;
            this.lblUpdFreq.Location = new System.Drawing.Point(814, 366);
            this.lblUpdFreq.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpdFreq.Name = "lblUpdFreq";
            this.lblUpdFreq.Size = new System.Drawing.Size(438, 32);
            this.lblUpdFreq.TabIndex = 3;
            this.lblUpdFreq.Text = "Uppdateringsfrekvens i sekunder:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(396, 366);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(130, 32);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kategori:";
            // 
            // coBoxCat
            // 
            this.coBoxCat.FormattingEnabled = true;
            this.coBoxCat.Location = new System.Drawing.Point(404, 418);
            this.coBoxCat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.coBoxCat.Name = "coBoxCat";
            this.coBoxCat.Size = new System.Drawing.Size(240, 39);
            this.coBoxCat.TabIndex = 5;
            // 
            // coBoxUpdFreq
            // 
            this.coBoxUpdFreq.FormattingEnabled = true;
            this.coBoxUpdFreq.Items.AddRange(new object[] {
            "15",
            "30",
            "60"});
            this.coBoxUpdFreq.Location = new System.Drawing.Point(821, 418);
            this.coBoxUpdFreq.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.coBoxUpdFreq.Name = "coBoxUpdFreq";
            this.coBoxUpdFreq.Size = new System.Drawing.Size(290, 39);
            this.coBoxUpdFreq.TabIndex = 6;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(404, 146);
            this.txtURL.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(708, 38);
            this.txtURL.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(404, 273);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(708, 38);
            this.txtTitle.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1111, 598);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(231, 51);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Lägg till";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(78, 598);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(231, 51);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Tillbaka";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PodCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 697);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.coBoxUpdFreq);
            this.Controls.Add(this.coBoxCat);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblUpdFreq);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblHeadtitle);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PodCreateForm";
            this.Text = "PodCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadtitle;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUpdFreq;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox coBoxCat;
        private System.Windows.Forms.ComboBox coBoxUpdFreq;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}