namespace Chat_Client_APP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textFriendsPort = new System.Windows.Forms.TextBox();
            this.textFriendsIp = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cliente 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puerto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP.";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(102, 59);
            this.textLocalPort.MaxLength = 2;
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(28, 20);
            this.textLocalPort.TabIndex = 1;
            this.textLocalPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLocalPort_KeyPress);
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(61, 22);
            this.textLocalIp.MaxLength = 11;
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(69, 20);
            this.textLocalIp.TabIndex = 0;
            this.textLocalIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLocalIp_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textFriendsPort);
            this.groupBox2.Controls.Add(this.textFriendsIp);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(214, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP:";
            // 
            // textFriendsPort
            // 
            this.textFriendsPort.Location = new System.Drawing.Point(95, 63);
            this.textFriendsPort.MaxLength = 2;
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new System.Drawing.Size(29, 20);
            this.textFriendsPort.TabIndex = 1;
            this.textFriendsPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFriendsPort_KeyPress);
            // 
            // textFriendsIp
            // 
            this.textFriendsIp.Location = new System.Drawing.Point(59, 22);
            this.textFriendsIp.MaxLength = 11;
            this.textFriendsIp.Name = "textFriendsIp";
            this.textFriendsIp.Size = new System.Drawing.Size(65, 20);
            this.textFriendsIp.TabIndex = 0;
            this.textFriendsIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFriendsIp_KeyPress);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(25, 317);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(389, 20);
            this.textMessage.TabIndex = 2;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(25, 143);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(389, 134);
            this.listMessage.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(410, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Comensar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(432, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chat_Client_APP.Properties.Resources.chat1;
            this.ClientSize = new System.Drawing.Size(528, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chat LA";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFriendsPort;
        private System.Windows.Forms.TextBox textFriendsIp;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

