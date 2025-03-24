
namespace miPrimerAplicacion
{
    partial class frmPrincipal
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblEvento = new System.Windows.Forms.Label();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.txtejercicio2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.Info;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRun.FlatAppearance.BorderSize = 2;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRun.Image = global::miPrimerAplicacion.Properties.Resources.RobloxScreenShot20241005_214053687;
            this.btnRun.Location = new System.Drawing.Point(318, 23);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(138, 30);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEvento.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEvento.Location = new System.Drawing.Point(328, 73);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(115, 49);
            this.lblEvento.TabIndex = 1;
            this.lblEvento.Text = "Evento";
            this.lblEvento.MouseLeave += new System.EventHandler(this.lblEvento_MouseLeave);
            this.lblEvento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEvento_MouseMove);
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEjercicio.Location = new System.Drawing.Point(328, 151);
            this.txtEjercicio.MaxLength = 20;
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(100, 20);
            this.txtEjercicio.TabIndex = 2;
            this.txtEjercicio.Text = "FASDFASD1";
            this.txtEjercicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEjercicio_KeyPress);
            // 
            // txtejercicio2
            // 
            this.txtejercicio2.Location = new System.Drawing.Point(328, 204);
            this.txtejercicio2.Multiline = true;
            this.txtejercicio2.Name = "txtejercicio2";
            this.txtejercicio2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtejercicio2.Size = new System.Drawing.Size(100, 20);
            this.txtejercicio2.TabIndex = 3;
            this.txtejercicio2.Text = "12341";
            this.txtejercicio2.Leave += new System.EventHandler(this.txtejercicio2_Leave);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtejercicio2);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.btnRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi primera app";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Click += new System.EventHandler(this.frmPrincipal_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.TextBox txtejercicio2;
    }
}

