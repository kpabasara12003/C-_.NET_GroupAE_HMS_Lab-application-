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
            this.panelone = new Guna.UI.WinForms.GunaPanel();
            this.doctxt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.subbut = new Guna.UI.WinForms.GunaButton();
            this.paneltwo = new System.Windows.Forms.Panel();
            this.valbut = new Guna.UI.WinForms.GunaTextBox();
            this.uppanel.SuspendLayout();
            this.panelone.SuspendLayout();
            this.paneltwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 59);
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
            this.uppanel.Location = new System.Drawing.Point(314, 59);
            this.uppanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uppanel.Name = "uppanel";
            this.uppanel.Size = new System.Drawing.Size(708, 493);
            this.uppanel.TabIndex = 1;
            // 
            // panelone
            // 
            this.panelone.Controls.Add(this.doctxt);
            this.panelone.Controls.Add(this.gunaButton1);
            this.panelone.Location = new System.Drawing.Point(31, 41);
            this.panelone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelone.Name = "panelone";
            this.panelone.Size = new System.Drawing.Size(656, 138);
            this.panelone.TabIndex = 4;
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
            this.doctxt.Location = new System.Drawing.Point(21, 22);
            this.doctxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctxt.Name = "doctxt";
            this.doctxt.PasswordChar = '\0';
            this.doctxt.SelectedText = "";
            this.doctxt.Size = new System.Drawing.Size(612, 46);
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
            this.gunaButton1.Location = new System.Drawing.Point(236, 79);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(173, 45);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.Text = "Upload";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
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
            this.subbut.Location = new System.Drawing.Point(460, 403);
            this.subbut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subbut.Name = "subbut";
            this.subbut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subbut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.subbut.OnHoverForeColor = System.Drawing.Color.White;
            this.subbut.OnHoverImage = null;
            this.subbut.OnPressedColor = System.Drawing.Color.Black;
            this.subbut.Radius = 15;
            this.subbut.Size = new System.Drawing.Size(211, 65);
            this.subbut.TabIndex = 3;
            this.subbut.Text = "Submit";
            this.subbut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subbut.Click += new System.EventHandler(this.subbut_Click);
            // 
            // paneltwo
            // 
            this.paneltwo.Controls.Add(this.valbut);
            this.paneltwo.Location = new System.Drawing.Point(29, 223);
            this.paneltwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneltwo.Name = "paneltwo";
            this.paneltwo.Size = new System.Drawing.Size(657, 103);
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
            this.valbut.Location = new System.Drawing.Point(43, 29);
            this.valbut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valbut.Name = "valbut";
            this.valbut.PasswordChar = '\0';
            this.valbut.SelectedText = "";
            this.valbut.Size = new System.Drawing.Size(575, 43);
            this.valbut.TabIndex = 0;
            this.valbut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Uploade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uppanel);
            this.Controls.Add(this.button1);
            this.Name = "Uploade";
            this.Size = new System.Drawing.Size(1154, 593);
            this.Load += new System.EventHandler(this.Uploade_Load);
            this.uppanel.ResumeLayout(false);
            this.panelone.ResumeLayout(false);
            this.paneltwo.ResumeLayout(false);
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
