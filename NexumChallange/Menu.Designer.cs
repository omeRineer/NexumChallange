namespace NexumChallange
{
    partial class Menu
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
            groupBox1 = new GroupBox();
            txtSize = new TextBox();
            label1 = new Label();
            txtLocation = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtInfo = new TextBox();
            lstTravelers = new ListBox();
            label4 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            btnSend = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gezgin Değerleri";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(12, 41);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(283, 31);
            txtSize.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(274, 23);
            label1.TabIndex = 2;
            label1.Text = "Koordinat Düzlemi Boyutu";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(6, 148);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(268, 31);
            txtLocation.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 122);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 1;
            label2.Text = "Konum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 211);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 3;
            label3.Text = "Katar Bilgisi";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 237);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(268, 31);
            txtInfo.TabIndex = 2;
            // 
            // lstTravelers
            // 
            lstTravelers.FormattingEnabled = true;
            lstTravelers.ItemHeight = 23;
            lstTravelers.Location = new Point(301, 29);
            lstTravelers.Name = "lstTravelers";
            lstTravelers.Size = new Size(288, 441);
            lstTravelers.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 45);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 5;
            label4.Text = "İsim";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(6, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 31);
            txtName.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 319);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(268, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 479);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(577, 40);
            btnSend.TabIndex = 7;
            btnSend.Text = "Gönder";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 531);
            Controls.Add(btnSend);
            Controls.Add(lstTravelers);
            Controls.Add(label1);
            Controls.Add(txtSize);
            Controls.Add(groupBox1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Menu";
            Text = "Menu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSave;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtInfo;
        private Label label2;
        private TextBox txtLocation;
        private TextBox txtSize;
        private Label label1;
        private ListBox lstTravelers;
        private Button btnSend;
    }
}