
namespace Grupp_33
{
    partial class CatCreateForm
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
            this.lblCatHeadtitle = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.btnCatCancel = new System.Windows.Forms.Button();
            this.btnCatCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCatHeadtitle
            // 
            this.lblCatHeadtitle.AutoSize = true;
            this.lblCatHeadtitle.Location = new System.Drawing.Point(288, 44);
            this.lblCatHeadtitle.Name = "lblCatHeadtitle";
            this.lblCatHeadtitle.Size = new System.Drawing.Size(217, 20);
            this.lblCatHeadtitle.TabIndex = 0;
            this.lblCatHeadtitle.Text = "Här kan du skapa en kategori";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(164, 210);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(55, 20);
            this.lblCatName.TabIndex = 1;
            this.lblCatName.Text = "Namn:";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(248, 204);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(336, 26);
            this.txtCatName.TabIndex = 2;
            // 
            // btnCatCancel
            // 
            this.btnCatCancel.Location = new System.Drawing.Point(68, 367);
            this.btnCatCancel.Name = "btnCatCancel";
            this.btnCatCancel.Size = new System.Drawing.Size(151, 36);
            this.btnCatCancel.TabIndex = 3;
            this.btnCatCancel.Text = "Tillbaka";
            this.btnCatCancel.UseVisualStyleBackColor = true;
            this.btnCatCancel.Click += new System.EventHandler(this.btnCatCancel_Click);
            // 
            // btnCatCreate
            // 
            this.btnCatCreate.Location = new System.Drawing.Point(567, 367);
            this.btnCatCreate.Name = "btnCatCreate";
            this.btnCatCreate.Size = new System.Drawing.Size(146, 36);
            this.btnCatCreate.TabIndex = 4;
            this.btnCatCreate.Text = "Skapa";
            this.btnCatCreate.UseVisualStyleBackColor = true;
            this.btnCatCreate.Click += new System.EventHandler(this.btnCatCreate_Click);
            // 
            // CatCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCatCreate);
            this.Controls.Add(this.btnCatCancel);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.lblCatHeadtitle);
            this.Name = "CatCreateForm";
            this.Text = "CatCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatHeadtitle;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Button btnCatCancel;
        private System.Windows.Forms.Button btnCatCreate;
    }
}