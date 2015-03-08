namespace PartsEncode
{
    partial class PartsEncodeApplication
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
            this.labelProject = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPart = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.buttonPart = new System.Windows.Forms.Button();
            this.buttonAssembly = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Location = new System.Drawing.Point(40, 78);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(43, 13);
            this.labelProject.TabIndex = 1;
            this.labelProject.Text = "Project:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Part#:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(122, 47);
            this.textBoxUser.MaxLength = 1;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 4;
            this.textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUser_KeyPress);
            // 
            // textBoxPart
            // 
            this.textBoxPart.Location = new System.Drawing.Point(122, 136);
            this.textBoxPart.Name = "textBoxPart";
            this.textBoxPart.ReadOnly = true;
            this.textBoxPart.Size = new System.Drawing.Size(100, 20);
            this.textBoxPart.TabIndex = 5;
            this.textBoxPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(122, 106);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 6;
            this.textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDate_KeyPress);
            // 
            // textBoxProject
            // 
            this.textBoxProject.Location = new System.Drawing.Point(122, 75);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(100, 20);
            this.textBoxProject.TabIndex = 7;
            this.textBoxProject.Text = "POL";
            this.textBoxProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPart
            // 
            this.buttonPart.Location = new System.Drawing.Point(43, 176);
            this.buttonPart.Name = "buttonPart";
            this.buttonPart.Size = new System.Drawing.Size(75, 23);
            this.buttonPart.TabIndex = 8;
            this.buttonPart.Text = "Part";
            this.buttonPart.UseVisualStyleBackColor = true;
            // 
            // buttonAssembly
            // 
            this.buttonAssembly.Location = new System.Drawing.Point(160, 176);
            this.buttonAssembly.Name = "buttonAssembly";
            this.buttonAssembly.Size = new System.Drawing.Size(75, 23);
            this.buttonAssembly.TabIndex = 9;
            this.buttonAssembly.Text = "Assembly";
            this.buttonAssembly.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PartsEncodeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonAssembly);
            this.Controls.Add(this.buttonPart);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxPart);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.label1);
            this.Name = "PartsEncodeApplication";
            this.Text = "Parts Encode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPart;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.Button buttonPart;
        private System.Windows.Forms.Button buttonAssembly;
        private System.Windows.Forms.Timer timer1;
    }
}

