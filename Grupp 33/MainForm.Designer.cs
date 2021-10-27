
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCat = new System.Windows.Forms.ListView();
            this.KategoriNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.listViewPod.Location = new System.Drawing.Point(21, 33);
            this.listViewPod.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPod.Name = "listViewPod";
            this.listViewPod.Size = new System.Drawing.Size(749, 285);
            this.listViewPod.TabIndex = 0;
            this.listViewPod.UseCompatibleStateImageBehavior = false;
            this.listViewPod.SelectedIndexChanged += new System.EventHandler(this.listViewPod_SelectedIndexChanged);
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
            this.txtUrl.Location = new System.Drawing.Point(21, 370);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(322, 26);
            this.txtUrl.TabIndex = 2;
            // 
            // coBoxFreq
            // 
            this.coBoxFreq.FormattingEnabled = true;
            this.coBoxFreq.Location = new System.Drawing.Point(372, 370);
            this.coBoxFreq.Margin = new System.Windows.Forms.Padding(2);
            this.coBoxFreq.Name = "coBoxFreq";
            this.coBoxFreq.Size = new System.Drawing.Size(187, 28);
            this.coBoxFreq.TabIndex = 3;
            // 
            // coBoxCat
            // 
            this.coBoxCat.FormattingEnabled = true;
            this.coBoxCat.Location = new System.Drawing.Point(582, 370);
            this.coBoxCat.Margin = new System.Windows.Forms.Padding(2);
            this.coBoxCat.Name = "coBoxCat";
            this.coBoxCat.Size = new System.Drawing.Size(187, 28);
            this.coBoxCat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori:";
            // 
            // btnPodCreate
            // 
            this.btnPodCreate.Location = new System.Drawing.Point(267, 422);
            this.btnPodCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodCreate.Name = "btnPodCreate";
            this.btnPodCreate.Size = new System.Drawing.Size(158, 40);
            this.btnPodCreate.TabIndex = 8;
            this.btnPodCreate.Text = "Skapa Podcast";
            this.btnPodCreate.UseVisualStyleBackColor = true;
            this.btnPodCreate.Click += new System.EventHandler(this.btnPodCreate_Click);
            // 
            // btnPodSave
            // 
            this.btnPodSave.Location = new System.Drawing.Point(439, 422);
            this.btnPodSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodSave.Name = "btnPodSave";
            this.btnPodSave.Size = new System.Drawing.Size(158, 40);
            this.btnPodSave.TabIndex = 9;
            this.btnPodSave.Text = "Spara Ändringar";
            this.btnPodSave.UseVisualStyleBackColor = true;
            this.btnPodSave.Click += new System.EventHandler(this.btnPodSave_Click);
            // 
            // btnPodDelete
            // 
            this.btnPodDelete.Location = new System.Drawing.Point(609, 422);
            this.btnPodDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodDelete.Name = "btnPodDelete";
            this.btnPodDelete.Size = new System.Drawing.Size(158, 40);
            this.btnPodDelete.TabIndex = 10;
            this.btnPodDelete.Text = "Ta Bort";
            this.btnPodDelete.UseVisualStyleBackColor = true;
            this.btnPodDelete.Click += new System.EventHandler(this.btnPodDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 488);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selected Podcast: Episodes...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kategorier:";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(836, 335);
            this.txtCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(458, 26);
            this.txtCat.TabIndex = 14;
            // 
            // btnCatCreate
            // 
            this.btnCatCreate.Location = new System.Drawing.Point(836, 383);
            this.btnCatCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatCreate.Name = "btnCatCreate";
            this.btnCatCreate.Size = new System.Drawing.Size(140, 39);
            this.btnCatCreate.TabIndex = 15;
            this.btnCatCreate.Text = "Skapa Kategori";
            this.btnCatCreate.UseVisualStyleBackColor = true;
            this.btnCatCreate.Click += new System.EventHandler(this.btnCatCreate_Click);
            // 
            // btnCatSave
            // 
            this.btnCatSave.Location = new System.Drawing.Point(1001, 383);
            this.btnCatSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatSave.Name = "btnCatSave";
            this.btnCatSave.Size = new System.Drawing.Size(140, 39);
            this.btnCatSave.TabIndex = 16;
            this.btnCatSave.Text = "Spara Ändringar";
            this.btnCatSave.UseVisualStyleBackColor = true;
            this.btnCatSave.Click += new System.EventHandler(this.btnCatSave_Click);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.Location = new System.Drawing.Point(1163, 383);
            this.btnCatDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(130, 39);
            this.btnCatDelete.TabIndex = 17;
            this.btnCatDelete.Text = "Ta Bort";
            this.btnCatDelete.UseVisualStyleBackColor = true;
            this.btnCatDelete.Click += new System.EventHandler(this.btnCatDelete_Click);
            // 
            // txtEpDes
            // 
            this.txtEpDes.Location = new System.Drawing.Point(836, 523);
            this.txtEpDes.Margin = new System.Windows.Forms.Padding(2);
            this.txtEpDes.Multiline = true;
            this.txtEpDes.Name = "txtEpDes";
            this.txtEpDes.ReadOnly = true;
            this.txtEpDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEpDes.Size = new System.Drawing.Size(458, 244);
            this.txtEpDes.TabIndex = 18;
            // 
            // lblPodEp
            // 
            this.lblPodEp.AutoSize = true;
            this.lblPodEp.Location = new System.Drawing.Point(833, 488);
            this.lblPodEp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodEp.Name = "lblPodEp";
            this.lblPodEp.Size = new System.Drawing.Size(217, 20);
            this.lblPodEp.TabIndex = 19;
            this.lblPodEp.Text = "Namn på Podcast : Episode...";
            // 
            // listViewEp
            // 
            this.listViewEp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewEp.HideSelection = false;
            this.listViewEp.Location = new System.Drawing.Point(21, 523);
            this.listViewEp.Margin = new System.Windows.Forms.Padding(2);
            this.listViewEp.Name = "listViewEp";
            this.listViewEp.Size = new System.Drawing.Size(749, 244);
            this.listViewEp.TabIndex = 20;
            this.listViewEp.UseCompatibleStateImageBehavior = false;
            this.listViewEp.SelectedIndexChanged += new System.EventHandler(this.listViewEp_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Avsnitt:";
            // 
            // listViewCat
            // 
            this.listViewCat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KategoriNamn});
            this.listViewCat.HideSelection = false;
            this.listViewCat.Location = new System.Drawing.Point(836, 69);
            this.listViewCat.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCat.Name = "listViewCat";
            this.listViewCat.Size = new System.Drawing.Size(458, 249);
            this.listViewCat.TabIndex = 21;
            this.listViewCat.UseCompatibleStateImageBehavior = false;
            this.listViewCat.SelectedIndexChanged += new System.EventHandler(this.listViewCat_SelectedIndexChanged);
            // 
            // KategoriNamn
            // 
            this.KategoriNamn.Text = "Kategori namn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 793);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader KategoriNamn;
    }
}

