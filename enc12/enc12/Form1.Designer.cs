namespace enc12
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
            this.components = new System.ComponentModel.Container();
            this.pass_origin = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pass_after = new System.Windows.Forms.TextBox();
            this.ENC = new System.Windows.Forms.Button();
            this.DEC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Heset = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pass_origin
            // 
            this.pass_origin.Location = new System.Drawing.Point(81, 34);
            this.pass_origin.Name = "pass_origin";
            this.pass_origin.Size = new System.Drawing.Size(100, 20);
            this.pass_origin.TabIndex = 0;
            this.pass_origin.Text = "password123";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // pass_after
            // 
            this.pass_after.Location = new System.Drawing.Point(81, 63);
            this.pass_after.Name = "pass_after";
            this.pass_after.Size = new System.Drawing.Size(100, 20);
            this.pass_after.TabIndex = 4;
            // 
            // ENC
            // 
            this.ENC.Location = new System.Drawing.Point(145, 158);
            this.ENC.Name = "ENC";
            this.ENC.Size = new System.Drawing.Size(127, 91);
            this.ENC.TabIndex = 5;
            this.ENC.Text = "ENC";
            this.ENC.UseVisualStyleBackColor = true;
            this.ENC.Click += new System.EventHandler(this.ENC_Click);
            // 
            // DEC
            // 
            this.DEC.Location = new System.Drawing.Point(12, 158);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(127, 91);
            this.DEC.TabIndex = 6;
            this.DEC.Text = "DEC";
            this.DEC.UseVisualStyleBackColor = true;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "סיסמא";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "סיסמא מוצפנת";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "היסט";
            // 
            // Heset
            // 
            this.Heset.Location = new System.Drawing.Point(81, 98);
            this.Heset.Name = "Heset";
            this.Heset.Size = new System.Drawing.Size(100, 20);
            this.Heset.TabIndex = 10;
            this.Heset.Text = "20";
            this.Heset.TextChanged += new System.EventHandler(this.update_eset);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Heset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DEC);
            this.Controls.Add(this.ENC);
            this.Controls.Add(this.pass_after);
            this.Controls.Add(this.pass_origin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.update_eset);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass_origin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox pass_after;
        private System.Windows.Forms.Button ENC;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Heset;
    }
}

