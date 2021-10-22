
namespace Grupp_33
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
            this.listViewPod = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.coBoxFreq = new System.Windows.Forms.ComboBox();
            this.coBoxCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPodCreate = new System.Windows.Forms.Button();
            this.btnPodSave = new System.Windows.Forms.Button();
            this.btnPodDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.btnCatCreate = new System.Windows.Forms.Button();
            this.btnCatSave = new System.Windows.Forms.Button();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.txtEpDes = new System.Windows.Forms.TextBox();
            this.lblPodEp = new System.Windows.Forms.Label();
            this.listViewEp = new System.Windows.Forms.ListView();
            this.listViewCat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewPod
            // 
            this.listViewPod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Avsnitt,
            this.Frekvens,
            this.Kategori});
            this.listViewPod.HideSelection = false;
            this.listViewPod.Location = new System.Drawing.Point(37, 51);
            this.listViewPod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewPod.Name = "listViewPod";
            this.listViewPod.Size = new System.Drawing.Size(1328, 440);
            this.listViewPod.TabIndex = 0;
            this.listViewPod.UseCompatibleStateImageBehavior = false;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(37, 573);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(569, 38);
            this.txtUrl.TabIndex = 2;
            // 
            // coBoxFreq
            // 
            this.coBoxFreq.FormattingEnabled = true;
            this.coBoxFreq.Location = new System.Drawing.Point(661, 573);
            this.coBoxFreq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.coBoxFreq.Name = "coBoxFreq";
            this.coBoxFreq.Size = new System.Drawing.Size(329, 39);
            this.coBoxFreq.TabIndex = 3;
            // 
            // coBoxCat
            // 
            this.coBoxCat.FormattingEnabled = true;
            this.coBoxCat.Location = new System.Drawing.Point(1035, 573);
            this.coBoxCat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.coBoxCat.Name = "coBoxCat";
            this.coBoxCat.Size = new System.Drawing.Size(329, 39);
            this.coBoxCat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 522);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 522);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1029, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori:";
            // 
            // btnPodCreate
            // 
            this.btnPodCreate.Location = new System.Drawing.Point(475, 654);
            this.btnPodCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPodCreate.Name = "btnPodCreate";
            this.btnPodCreate.Size = new System.Drawing.Size(281, 62);
            this.btnPodCreate.TabIndex = 8;
            this.btnPodCreate.Text = "Skapa Podcast";
            this.btnPodCreate.UseVisualStyleBackColor = true;
            this.btnPodCreate.Click += new System.EventHandler(this.btnPodCreate_Click);
            // 
            // btnPodSave
            // 
            this.btnPodSave.Location = new System.Drawing.Point(780, 654);
            this.btnPodSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPodSave.Name = "btnPodSave";
            this.btnPodSave.Size = new System.Drawing.Size(281, 62);
            this.btnPodSave.TabIndex = 9;
            this.btnPodSave.Text = "Spara Ändringar";
            this.btnPodSave.UseVisualStyleBackColor = true;
            this.btnPodSave.Click += new System.EventHandler(this.btnPodSave_Click);
            // 
            // btnPodDelete
            // 
            this.btnPodDelete.Location = new System.Drawing.Point(1083, 654);
            this.btnPodDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPodDelete.Name = "btnPodDelete";
            this.btnPodDelete.Size = new System.Drawing.Size(281, 62);
            this.btnPodDelete.TabIndex = 10;
            this.btnPodDelete.Text = "Ta Bort";
            this.btnPodDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 756);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selected Podcast: Episodes...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1481, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kategorier:";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(1486, 519);
            this.txtCat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(811, 38);
            this.txtCat.TabIndex = 14;
            // 
            // btnCatCreate
            // 
            this.btnCatCreate.Location = new System.Drawing.Point(1486, 594);
            this.btnCatCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCatCreate.Name = "btnCatCreate";
            this.btnCatCreate.Size = new System.Drawing.Size(249, 60);
            this.btnCatCreate.TabIndex = 15;
            this.btnCatCreate.Text = "Skapa Kategori";
            this.btnCatCreate.UseVisualStyleBackColor = true;
            this.btnCatCreate.Click += new System.EventHandler(this.btnCatCreate_Click);
            // 
            // btnCatSave
            // 
            this.btnCatSave.Location = new System.Drawing.Point(1780, 594);
            this.btnCatSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCatSave.Name = "btnCatSave";
            this.btnCatSave.Size = new System.Drawing.Size(249, 60);
            this.btnCatSave.TabIndex = 16;
            this.btnCatSave.Text = "Spara Ändringar";
            this.btnCatSave.UseVisualStyleBackColor = true;
            this.btnCatSave.Click += new System.EventHandler(this.btnCatSave_Click);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.Location = new System.Drawing.Point(2068, 594);
            this.btnCatDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(231, 60);
            this.btnCatDelete.TabIndex = 17;
            this.btnCatDelete.Text = "Ta Bort";
            this.btnCatDelete.UseVisualStyleBackColor = true;
            // 
            // txtEpDes
            // 
            this.txtEpDes.Location = new System.Drawing.Point(1486, 811);
            this.txtEpDes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEpDes.Multiline = true;
            this.txtEpDes.Name = "txtEpDes";
            this.txtEpDes.Size = new System.Drawing.Size(811, 376);
            this.txtEpDes.TabIndex = 18;
            // 
            // lblPodEp
            // 
            this.lblPodEp.AutoSize = true;
            this.lblPodEp.Location = new System.Drawing.Point(1481, 756);
            this.lblPodEp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodEp.Name = "lblPodEp";
            this.lblPodEp.Size = new System.Drawing.Size(389, 32);
            this.lblPodEp.TabIndex = 19;
            this.lblPodEp.Text = "Namn på Podcast : Episode...";
            // 
            // listViewEp
            // 
            this.listViewEp.HideSelection = false;
            this.listViewEp.Location = new System.Drawing.Point(37, 811);
            this.listViewEp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewEp.Name = "listViewEp";
            this.listViewEp.Size = new System.Drawing.Size(1328, 376);
            this.listViewEp.TabIndex = 20;
            this.listViewEp.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCat
            // 
            this.listViewCat.HideSelection = false;
            this.listViewCat.Location = new System.Drawing.Point(1486, 107);
            this.listViewCat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewCat.Name = "listViewCat";
            this.listViewCat.Size = new System.Drawing.Size(811, 384);
            this.listViewCat.TabIndex = 21;
            this.listViewCat.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2286, 1049);
            this.Controls.Add(this.listViewCat);
            this.Controls.Add(this.listViewEp);
            this.Controls.Add(this.lblPodEp);
            this.Controls.Add(this.txtEpDes);
            this.Controls.Add(this.btnCatDelete);
            this.Controls.Add(this.btnCatSave);
            this.Controls.Add(this.btnCatCreate);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPodDelete);
            this.Controls.Add(this.btnPodSave);
            this.Controls.Add(this.btnPodCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coBoxCat);
            this.Controls.Add(this.coBoxFreq);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.listViewPod);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPod;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox coBoxFreq;
        private System.Windows.Forms.ComboBox coBoxCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPodCreate;
        private System.Windows.Forms.Button btnPodSave;
        private System.Windows.Forms.Button btnPodDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Button btnCatCreate;
        private System.Windows.Forms.Button btnCatSave;
        private System.Windows.Forms.Button btnCatDelete;
        private System.Windows.Forms.TextBox txtEpDes;
        private System.Windows.Forms.Label lblPodEp;
        private System.Windows.Forms.ListView listViewEp;
        private System.Windows.Forms.ListView listViewCat;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
    }
}

