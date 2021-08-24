namespace Vista
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnacceder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblclave = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 123);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 541);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(482, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido ";
            // 
            // Btnacceder
            // 
            this.Btnacceder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btnacceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btnacceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnacceder.BorderRadius = 0;
            this.Btnacceder.ButtonText = "Acceder";
            this.Btnacceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnacceder.DisabledColor = System.Drawing.Color.Gray;
            this.Btnacceder.Iconcolor = System.Drawing.Color.Transparent;
            this.Btnacceder.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btnacceder.Iconimage")));
            this.Btnacceder.Iconimage_right = null;
            this.Btnacceder.Iconimage_right_Selected = null;
            this.Btnacceder.Iconimage_Selected = null;
            this.Btnacceder.IconMarginLeft = 0;
            this.Btnacceder.IconMarginRight = 0;
            this.Btnacceder.IconRightVisible = true;
            this.Btnacceder.IconRightZoom = 0D;
            this.Btnacceder.IconVisible = true;
            this.Btnacceder.IconZoom = 90D;
            this.Btnacceder.IsTab = false;
            this.Btnacceder.Location = new System.Drawing.Point(487, 472);
            this.Btnacceder.Name = "Btnacceder";
            this.Btnacceder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btnacceder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btnacceder.OnHoverTextColor = System.Drawing.Color.White;
            this.Btnacceder.selected = false;
            this.Btnacceder.Size = new System.Drawing.Size(241, 48);
            this.Btnacceder.TabIndex = 3;
            this.Btnacceder.Text = "Acceder";
            this.Btnacceder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnacceder.Textcolor = System.Drawing.Color.White;
            this.Btnacceder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(521, 397);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(174, 20);
            this.txtclave.TabIndex = 4;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(521, 290);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(174, 20);
            this.txtusuario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(518, 268);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(161, 18);
            this.lblusuario.TabIndex = 7;
            this.lblusuario.Text = "Ingrese su usuario:";
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclave.Location = new System.Drawing.Point(521, 376);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(144, 18);
            this.lblclave.TabIndex = 8;
            this.lblclave.Text = "Ingrese su clave:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 620);
            this.Controls.Add(this.lblclave);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.Btnacceder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private Bunifu.Framework.UI.BunifuFlatButton Btnacceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

