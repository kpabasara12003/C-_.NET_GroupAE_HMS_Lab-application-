namespace TrustWell_Hospital_Lab_Application
{
    partial class Uploade
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.uppanel = new Guna.UI.WinForms.GunaPanel();
            this.doctxt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.paneltwo = new System.Windows.Forms.Panel();
            this.valbut = new Guna.UI.WinForms.GunaTextBox();
            this.subbut = new Guna.UI.WinForms.GunaButton();
            this.panelone = new Guna.UI.WinForms.GunaPanel();
            this.uppanel.SuspendLayout();
            this.paneltwo.SuspendLayout();
            this.panelone.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // uppanel
            // 
            this.uppanel.Controls.Add(this.panelone);
            this.uppanel.Controls.Add(this.subbut);
            this.uppanel.Controls.Add(this.paneltwo);
            this.uppanel.Location = new System.Drawing.Point(432, 88);
            this.uppanel.Name = "uppanel";
            this.uppanel.Size = new System.Drawing.Size(973, 740);
            this.uppanel.TabIndex = 1;
            // 
            // doctxt
            // 
            this.doctxt.BaseColor = System.Drawing.Color.White;
            this.doctxt.BorderColor = System.Drawing.Color.Silver;
            this.doctxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.doctxt.FocusedBaseColor = System.Drawing.Color.White;
            this.doctxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.doctxt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.doctxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.doctxt.Location = new System.Drawing.Point(29, 33);
            this.doctxt.Name = "doctxt";
            this.doctxt.PasswordChar = '\0';
            this.doctxt.SelectedText = "";
            this.doctxt.Size = new System.Drawing.Size(842, 69);
            this.doctxt.TabIndex = 0;
            this.doctxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doctxt.TextChanged += new System.EventHandler(this.doctxt_TextChanged);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(325, 119);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(238, 68);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.Text = "Upload";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // paneltwo
            // 
            this.paneltwo.Controls.Add(this.valbut);
            this.paneltwo.Location = new System.Drawing.Point(40, 334);
            this.paneltwo.Name = "paneltwo";
            this.paneltwo.Size = new System.Drawing.Size(904, 154);
            this.paneltwo.TabIndex = 2;
            this.paneltwo.Visible = false;
            // 
            // valbut
            // 
            this.valbut.BaseColor = System.Drawing.Color.White;
            this.valbut.BorderColor = System.Drawing.Color.Silver;
            this.valbut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valbut.FocusedBaseColor = System.Drawing.Color.White;
            this.valbut.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.valbut.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.valbut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.valbut.Location = new System.Drawing.Point(59, 44);
            this.valbut.Name = "valbut";
            this.valbut.PasswordChar = '\0';
            this.valbut.SelectedText = "";
            this.valbut.Size = new System.Drawing.Size(790, 65);
            this.valbut.TabIndex = 0;
            this.valbut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subbut
            // 
            this.subbut.AnimationHoverSpeed = 0.07F;
            this.subbut.AnimationSpeed = 0.03F;
            this.subbut.BackColor = System.Drawing.Color.Transparent;
            this.subbut.BaseColor = System.Drawing.Color.White;
            this.subbut.BorderColor = System.Drawing.Color.Black;
            this.subbut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.subbut.FocusedColor = System.Drawing.Color.Empty;
            this.subbut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.subbut.ForeColor = System.Drawing.Color.Black;
            this.subbut.Image = null;
            this.subbut.ImageSize = new System.Drawing.Size(20, 20);
            this.subbut.Location = new System.Drawing.Point(632, 605);
            this.subbut.Name = "subbut";
            this.subbut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subbut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.subbut.OnHoverForeColor = System.Drawing.Color.White;
            this.subbut.OnHoverImage = null;
            this.subbut.OnPressedColor = System.Drawing.Color.Black;
            this.subbut.Radius = 15;
            this.subbut.Size = new System.Drawing.Size(290, 98);
            this.subbut.TabIndex = 3;
            this.subbut.Text = "Submit";
            this.subbut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelone
            // 
            this.panelone.Controls.Add(this.doctxt);
            this.panelone.Controls.Add(this.gunaButton1);
            this.panelone.Location = new System.Drawing.Point(42, 62);
            this.panelone.Name = "panelone";
            this.panelone.Size = new System.Drawing.Size(902, 207);
            this.panelone.TabIndex = 4;
            // 
            // Uploade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uppanel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Uploade";
            this.Size = new System.Drawing.Size(1587, 890);
            this.Load += new System.EventHandler(this.Uploade_Load);
            this.uppanel.ResumeLayout(false);
            this.paneltwo.ResumeLayout(false);
            this.panelone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaPanel uppanel;
        private Guna.UI.WinForms.GunaTextBox doctxt;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton subbut;
        private System.Windows.Forms.Panel paneltwo;
        private Guna.UI.WinForms.GunaTextBox valbut;
        private Guna.UI.WinForms.GunaPanel panelone;

        
    }
}
