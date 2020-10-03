namespace exporter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_datasource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dbname = new System.Windows.Forms.TextBox();
            this.pictureBox_gif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // txt_user_name
            // 
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.Location = new System.Drawing.Point(179, 169);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(167, 26);
            this.txt_user_name.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(179, 225);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(167, 26);
            this.txt_password.TabIndex = 4;
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Location = new System.Drawing.Point(146, 287);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(119, 33);
            this.btn_export.TabIndex = 5;
            this.btn_export.Text = "E X P O R T";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataSource";
            // 
            // txt_datasource
            // 
            this.txt_datasource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datasource.Location = new System.Drawing.Point(179, 52);
            this.txt_datasource.Name = "txt_datasource";
            this.txt_datasource.Size = new System.Drawing.Size(167, 26);
            this.txt_datasource.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "DbName";
            // 
            // txt_dbname
            // 
            this.txt_dbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dbname.Location = new System.Drawing.Point(179, 111);
            this.txt_dbname.Name = "txt_dbname";
            this.txt_dbname.Size = new System.Drawing.Size(167, 26);
            this.txt_dbname.TabIndex = 2;
            // 
            // pictureBox_gif
            // 
            this.pictureBox_gif.Image = global::exporter.Properties.Resources.loading;
            this.pictureBox_gif.Location = new System.Drawing.Point(277, 286);
            this.pictureBox_gif.Name = "pictureBox_gif";
            this.pictureBox_gif.Size = new System.Drawing.Size(38, 34);
            this.pictureBox_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_gif.TabIndex = 10;
            this.pictureBox_gif.TabStop = false;
            this.pictureBox_gif.Visible = false;
            this.pictureBox_gif.Click += new System.EventHandler(this.pictureBox_gif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 368);
            this.Controls.Add(this.pictureBox_gif);
            this.Controls.Add(this.txt_dbname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_datasource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Exporter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_datasource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dbname;
        private System.Windows.Forms.PictureBox pictureBox_gif;
    }
}

