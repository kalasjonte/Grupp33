
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
            this.txtName = new System.Windows.Forms.TextBox();
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
            this.lblPod = new System.Windows.Forms.Label();
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
            this.listViewPod.Location = new System.Drawing.Point(11, 45);
            this.listViewPod.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listViewPod.Name = "listViewPod";
            this.listViewPod.Size = new System.Drawing.Size(500, 187);
            this.listViewPod.TabIndex = 0;
            this.listViewPod.UseCompatibleStateImageBehavior = false;
            this.listViewPod.SelectedIndexChanged += new System.EventHandler(this.listViewPod_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title                                           ";
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens(ms)";
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(14, 266);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 2;
            // 
            // coBoxFreq
            // 
            this.coBoxFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxFreq.FormattingEnabled = true;
            this.coBoxFreq.Items.AddRange(new object[] {
            "15",
            "30",
            "60"});
            this.coBoxFreq.Location = new System.Drawing.Point(248, 265);
            this.coBoxFreq.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.coBoxFreq.Name = "coBoxFreq";
            this.coBoxFreq.Size = new System.Drawing.Size(126, 21);
            this.coBoxFreq.TabIndex = 3;
            // 
            // coBoxCat
            // 
            this.coBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxCat.FormattingEnabled = true;
            this.coBoxCat.Location = new System.Drawing.Point(388, 266);
            this.coBoxCat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.coBoxCat.Name = "coBoxCat";
            this.coBoxCat.Size = new System.Drawing.Size(126, 21);
            this.coBoxCat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori:";
            // 
            // btnPodCreate
            // 
            this.btnPodCreate.Location = new System.Drawing.Point(406, 14);
            this.btnPodCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPodCreate.Name = "btnPodCreate";
            this.btnPodCreate.Size = new System.Drawing.Size(105, 26);
            this.btnPodCreate.TabIndex = 8;
            this.btnPodCreate.Text = "Skapa Podcast";
            this.btnPodCreate.UseVisualStyleBackColor = true;
            this.btnPodCreate.Click += new System.EventHandler(this.btnPodCreate_Click);
            // 
            // btnPodSave
            // 
            this.btnPodSave.Location = new System.Drawing.Point(18, 298);
            this.btnPodSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPodSave.Name = "btnPodSave";
            this.btnPodSave.Size = new System.Drawing.Size(105, 26);
            this.btnPodSave.TabIndex = 9;
            this.btnPodSave.Text = "Spara Ändringar";
            this.btnPodSave.UseVisualStyleBackColor = true;
            this.btnPodSave.Click += new System.EventHandler(this.btnPodSave_Click);
            // 
            // btnPodDelete
            // 
            this.btnPodDelete.Location = new System.Drawing.Point(163, 298);
            this.btnPodDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPodDelete.Name = "btnPodDelete";
            this.btnPodDelete.Size = new System.Drawing.Size(105, 26);
            this.btnPodDelete.TabIndex = 10;
            this.btnPodDelete.Text = "Ta Bort";
            this.btnPodDelete.UseVisualStyleBackColor = true;
            this.btnPodDelete.Click += new System.EventHandler(this.btnPodDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vald Podcast: Avsnitt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kategorier:";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(683, 219);
            this.txtCat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(307, 20);
            this.txtCat.TabIndex = 14;
            // 
            // btnCatCreate
            // 
            this.btnCatCreate.Location = new System.Drawing.Point(683, 249);
            this.btnCatCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCatCreate.Name = "btnCatCreate";
            this.btnCatCreate.Size = new System.Drawing.Size(93, 25);
            this.btnCatCreate.TabIndex = 15;
            this.btnCatCreate.Text = "Skapa Kategori";
            this.btnCatCreate.UseVisualStyleBackColor = true;
            this.btnCatCreate.Click += new System.EventHandler(this.btnCatCreate_Click);
            // 
            // btnCatSave
            // 
            this.btnCatSave.Location = new System.Drawing.Point(796, 249);
            this.btnCatSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCatSave.Name = "btnCatSave";
            this.btnCatSave.Size = new System.Drawing.Size(93, 25);
            this.btnCatSave.TabIndex = 16;
            this.btnCatSave.Text = "Spara Ändringar";
            this.btnCatSave.UseVisualStyleBackColor = true;
            this.btnCatSave.Click += new System.EventHandler(this.btnCatSave_Click);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.Location = new System.Drawing.Point(903, 249);
            this.btnCatDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(87, 25);
            this.btnCatDelete.TabIndex = 17;
            this.btnCatDelete.Text = "Ta Bort";
            this.btnCatDelete.UseVisualStyleBackColor = true;
            this.btnCatDelete.Click += new System.EventHandler(this.btnCatDelete_Click);
            // 
            // txtEpDes
            // 
            this.txtEpDes.Location = new System.Drawing.Point(558, 386);
            this.txtEpDes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEpDes.Multiline = true;
            this.txtEpDes.Name = "txtEpDes";
            this.txtEpDes.ReadOnly = true;
            this.txtEpDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEpDes.Size = new System.Drawing.Size(331, 160);
            this.txtEpDes.TabIndex = 18;
            // 
            // lblPodEp
            // 
            this.lblPodEp.AutoSize = true;
            this.lblPodEp.Location = new System.Drawing.Point(555, 356);
            this.lblPodEp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodEp.Name = "lblPodEp";
            this.lblPodEp.Size = new System.Drawing.Size(101, 13);
            this.lblPodEp.TabIndex = 19;
            this.lblPodEp.Text = "Avsnittsbeskrivning:";
            // 
            // listViewEp
            // 
            this.listViewEp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewEp.HideSelection = false;
            this.listViewEp.Location = new System.Drawing.Point(14, 386);
            this.listViewEp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listViewEp.Name = "listViewEp";
            this.listViewEp.Size = new System.Drawing.Size(500, 160);
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
            this.listViewCat.FullRowSelect = true;
            this.listViewCat.HideSelection = false;
            this.listViewCat.Location = new System.Drawing.Point(683, 45);
            this.listViewCat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listViewCat.Name = "listViewCat";
            this.listViewCat.Size = new System.Drawing.Size(307, 163);
            this.listViewCat.TabIndex = 21;
            this.listViewCat.UseCompatibleStateImageBehavior = false;
            this.listViewCat.SelectedIndexChanged += new System.EventHandler(this.listViewCat_SelectedIndexChanged);
            // 
            // KategoriNamn
            // 
            this.KategoriNamn.Text = "Kategori namn";
            // 
            // lblPod
            // 
            this.lblPod.AutoSize = true;
            this.lblPod.Location = new System.Drawing.Point(15, 21);
            this.lblPod.Name = "lblPod";
            this.lblPod.Size = new System.Drawing.Size(78, 13);
            this.lblPod.TabIndex = 22;
            this.lblPod.Text = "Dina podcasts:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 642);
            this.Controls.Add(this.lblPod);
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
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listViewPod);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPod;
        private System.Windows.Forms.TextBox txtName;
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
        private System.Windows.Forms.Label lblPod;
    }
}

