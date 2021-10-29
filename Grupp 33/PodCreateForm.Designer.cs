
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
            this.lblHeadtitle.Location = new System.Drawing.Point(262, 39);
            this.lblHeadtitle.Name = "lblHeadtitle";
            this.lblHeadtitle.Size = new System.Drawing.Size(290, 20);
            this.lblHeadtitle.TabIndex = 0;
            this.lblHeadtitle.Text = "Här kan du lägga till en podd till ditt feed";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(160, 100);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(46, 20);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(164, 182);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Titel:";
            // 
            // lblUpdFreq
            // 
            this.lblUpdFreq.AutoSize = true;
            this.lblUpdFreq.Location = new System.Drawing.Point(458, 236);
            this.lblUpdFreq.Name = "lblUpdFreq";
            this.lblUpdFreq.Size = new System.Drawing.Size(246, 20);
            this.lblUpdFreq.TabIndex = 3;
            this.lblUpdFreq.Text = "Uppdateringsfrekvens i sekunder:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(223, 236);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 20);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kategori:";
            // 
            // coBoxCat
            // 
            this.coBoxCat.FormattingEnabled = true;
            this.coBoxCat.Location = new System.Drawing.Point(227, 270);
            this.coBoxCat.Name = "coBoxCat";
            this.coBoxCat.Size = new System.Drawing.Size(137, 28);
            this.coBoxCat.TabIndex = 5;
            // 
            // coBoxUpdFreq
            // 
            this.coBoxUpdFreq.FormattingEnabled = true;
            this.coBoxUpdFreq.Items.AddRange(new object[] {
            "15",
            "30",
            "60"});
            this.coBoxUpdFreq.Location = new System.Drawing.Point(462, 270);
            this.coBoxUpdFreq.Name = "coBoxUpdFreq";
            this.coBoxUpdFreq.Size = new System.Drawing.Size(165, 28);
            this.coBoxUpdFreq.TabIndex = 6;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(227, 94);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(400, 26);
            this.txtURL.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(227, 176);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(400, 26);
            this.txtTitle.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(625, 386);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(130, 33);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Lägg till";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(44, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Tillbaka";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PodCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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