namespace PermissionsChecker
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
            this.m_Path = new System.Windows.Forms.TextBox();
            this.m_Target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_BrowsePath = new System.Windows.Forms.Button();
            this.m_Output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_Status = new System.Windows.Forms.TextBox();
            this.m_Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_Path
            // 
            this.m_Path.Location = new System.Drawing.Point(94, 12);
            this.m_Path.Name = "m_Path";
            this.m_Path.Size = new System.Drawing.Size(246, 20);
            this.m_Path.TabIndex = 0;
            // 
            // m_Target
            // 
            this.m_Target.Location = new System.Drawing.Point(94, 38);
            this.m_Target.Name = "m_Target";
            this.m_Target.Size = new System.Drawing.Size(246, 20);
            this.m_Target.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path to search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target:";
            // 
            // m_BrowsePath
            // 
            this.m_BrowsePath.Location = new System.Drawing.Point(346, 10);
            this.m_BrowsePath.Name = "m_BrowsePath";
            this.m_BrowsePath.Size = new System.Drawing.Size(37, 22);
            this.m_BrowsePath.TabIndex = 4;
            this.m_BrowsePath.Text = "...";
            this.m_BrowsePath.UseVisualStyleBackColor = true;
            this.m_BrowsePath.Click += new System.EventHandler(this.m_BrowsePath_Click);
            // 
            // m_Output
            // 
            this.m_Output.Location = new System.Drawing.Point(15, 94);
            this.m_Output.Multiline = true;
            this.m_Output.Name = "m_Output";
            this.m_Output.Size = new System.Drawing.Size(692, 360);
            this.m_Output.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status:";
            // 
            // m_Status
            // 
            this.m_Status.Location = new System.Drawing.Point(94, 64);
            this.m_Status.Name = "m_Status";
            this.m_Status.ReadOnly = true;
            this.m_Status.Size = new System.Drawing.Size(613, 20);
            this.m_Status.TabIndex = 6;
            // 
            // m_Go
            // 
            this.m_Go.Location = new System.Drawing.Point(346, 36);
            this.m_Go.Name = "m_Go";
            this.m_Go.Size = new System.Drawing.Size(37, 22);
            this.m_Go.TabIndex = 8;
            this.m_Go.Text = "Go";
            this.m_Go.UseVisualStyleBackColor = true;
            this.m_Go.Click += new System.EventHandler(this.m_Go_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 466);
            this.Controls.Add(this.m_Go);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_Status);
            this.Controls.Add(this.m_Output);
            this.Controls.Add(this.m_BrowsePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_Target);
            this.Controls.Add(this.m_Path);
            this.Name = "MainForm";
            this.Text = "ACL search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_Path;
        private System.Windows.Forms.TextBox m_Target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_BrowsePath;
        private System.Windows.Forms.TextBox m_Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_Status;
        private System.Windows.Forms.Button m_Go;
    }
}