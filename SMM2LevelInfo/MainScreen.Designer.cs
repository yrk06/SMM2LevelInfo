namespace SMM2LevelInfo
{
    partial class MainScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drambar_connection_status = new System.Windows.Forms.Label();
            this.drambar_connect = new System.Windows.Forms.Button();
            this.drambar_port = new System.Windows.Forms.TextBox();
            this.drambar_ip = new System.Windows.Forms.TextBox();
            this.drambar_conection_header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LIB_header = new System.Windows.Forms.Label();
            this.LIB_api_key = new System.Windows.Forms.TextBox();
            this.Save_key = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 110);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drambar_connection_status);
            this.panel1.Controls.Add(this.drambar_connect);
            this.panel1.Controls.Add(this.drambar_port);
            this.panel1.Controls.Add(this.drambar_ip);
            this.panel1.Controls.Add(this.drambar_conection_header);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 102);
            this.panel1.TabIndex = 0;
            // 
            // drambar_connection_status
            // 
            this.drambar_connection_status.AutoSize = true;
            this.drambar_connection_status.ForeColor = System.Drawing.Color.Red;
            this.drambar_connection_status.Location = new System.Drawing.Point(14, 72);
            this.drambar_connection_status.Name = "drambar_connection_status";
            this.drambar_connection_status.Size = new System.Drawing.Size(72, 13);
            this.drambar_connection_status.TabIndex = 4;
            this.drambar_connection_status.Text = "Not conected";
            // 
            // drambar_connect
            // 
            this.drambar_connect.Location = new System.Drawing.Point(119, 29);
            this.drambar_connect.Name = "drambar_connect";
            this.drambar_connect.Size = new System.Drawing.Size(75, 23);
            this.drambar_connect.TabIndex = 3;
            this.drambar_connect.Text = "connect";
            this.drambar_connect.UseVisualStyleBackColor = true;
            this.drambar_connect.Click += new System.EventHandler(this.drambar_connect_Click);
            // 
            // drambar_port
            // 
            this.drambar_port.Location = new System.Drawing.Point(76, 32);
            this.drambar_port.Name = "drambar_port";
            this.drambar_port.Size = new System.Drawing.Size(37, 20);
            this.drambar_port.TabIndex = 2;
            this.drambar_port.Text = "3000";
            // 
            // drambar_ip
            // 
            this.drambar_ip.Location = new System.Drawing.Point(14, 32);
            this.drambar_ip.Name = "drambar_ip";
            this.drambar_ip.Size = new System.Drawing.Size(56, 20);
            this.drambar_ip.TabIndex = 1;
            this.drambar_ip.Text = "localhost";
            // 
            // drambar_conection_header
            // 
            this.drambar_conection_header.AutoSize = true;
            this.drambar_conection_header.Location = new System.Drawing.Point(11, 7);
            this.drambar_conection_header.Name = "drambar_conection_header";
            this.drambar_conection_header.Size = new System.Drawing.Size(102, 13);
            this.drambar_conection_header.TabIndex = 0;
            this.drambar_conection_header.Text = "Dram Bar Conection";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Save_key);
            this.panel2.Controls.Add(this.LIB_header);
            this.panel2.Controls.Add(this.LIB_api_key);
            this.panel2.Location = new System.Drawing.Point(217, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 102);
            this.panel2.TabIndex = 1;
            // 
            // LIB_header
            // 
            this.LIB_header.AutoSize = true;
            this.LIB_header.Location = new System.Drawing.Point(3, 7);
            this.LIB_header.Name = "LIB_header";
            this.LIB_header.Size = new System.Drawing.Size(107, 13);
            this.LIB_header.TabIndex = 2;
            this.LIB_header.Text = "LevelInfoBot API key";
            // 
            // LIB_api_key
            // 
            this.LIB_api_key.Location = new System.Drawing.Point(3, 28);
            this.LIB_api_key.Name = "LIB_api_key";
            this.LIB_api_key.Size = new System.Drawing.Size(142, 20);
            this.LIB_api_key.TabIndex = 0;
            this.LIB_api_key.UseSystemPasswordChar = true;
            // 
            // Save_key
            // 
            this.Save_key.Location = new System.Drawing.Point(35, 62);
            this.Save_key.Name = "Save_key";
            this.Save_key.Size = new System.Drawing.Size(75, 23);
            this.Save_key.TabIndex = 3;
            this.Save_key.Text = "Save key";
            this.Save_key.UseVisualStyleBackColor = true;
            this.Save_key.Click += new System.EventHandler(this.Save_key_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 112);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "LevelInfoBot";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox drambar_ip;
        private System.Windows.Forms.Label drambar_conection_header;
        private System.Windows.Forms.Button drambar_connect;
        private System.Windows.Forms.TextBox drambar_port;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LIB_header;
        private System.Windows.Forms.TextBox LIB_api_key;
        private System.Windows.Forms.Label drambar_connection_status;
        private System.Windows.Forms.Button Save_key;
    }
}

