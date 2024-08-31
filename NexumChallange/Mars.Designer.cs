namespace NexumChallange
{
    partial class Mars
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
            btnSave = new Button();
            label4 = new Label();
            txtTag = new TextBox();
            label3 = new Label();
            txtInfo = new TextBox();
            label2 = new Label();
            txtLocation = new TextBox();
            txtSize = new TextBox();
            label1 = new Label();
            lstTravelers = new ListBox();
            btnSend = new Button();
            groupBox2 = new GroupBox();
            lblTagResult = new Label();
            label8 = new Label();
            lblDirectionResult = new Label();
            lblYResult = new Label();
            lblXResult = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lstResultTravelers = new ListBox();
            groupBox3 = new GroupBox();
            lblTag = new Label();
            label10 = new Label();
            lblDirection = new Label();
            lblY = new Label();
            lblX = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTag);
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
            // btnSave
            // 
            btnSave.Location = new Point(6, 319);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(268, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 45);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 5;
            label4.Text = "Tag";
            // 
            // txtTag
            // 
            txtTag.Location = new Point(6, 71);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(268, 31);
            txtTag.TabIndex = 4;
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
            txtInfo.CharacterCasing = CharacterCasing.Upper;
            txtInfo.Location = new Point(6, 237);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(268, 31);
            txtInfo.TabIndex = 2;
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
            // txtLocation
            // 
            txtLocation.CharacterCasing = CharacterCasing.Upper;
            txtLocation.Location = new Point(6, 148);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(268, 31);
            txtLocation.TabIndex = 0;
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
            // lstTravelers
            // 
            lstTravelers.FormattingEnabled = true;
            lstTravelers.ItemHeight = 23;
            lstTravelers.Location = new Point(301, 29);
            lstTravelers.Name = "lstTravelers";
            lstTravelers.Size = new Size(288, 211);
            lstTravelers.TabIndex = 3;
            lstTravelers.SelectedIndexChanged += lstTravelers_SelectedIndexChanged;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 479);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(577, 40);
            btnSend.TabIndex = 7;
            btnSend.Text = "Gönder";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTagResult);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(lblDirectionResult);
            groupBox2.Controls.Add(lblYResult);
            groupBox2.Controls.Add(lblXResult);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lstResultTravelers);
            groupBox2.Location = new Point(12, 536);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(577, 253);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sonuç";
            // 
            // lblTagResult
            // 
            lblTagResult.AutoSize = true;
            lblTagResult.ForeColor = Color.FromArgb(255, 128, 0);
            lblTagResult.Location = new Point(319, 46);
            lblTagResult.Name = "lblTagResult";
            lblTagResult.Size = new Size(43, 23);
            lblTagResult.TabIndex = 8;
            lblTagResult.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 46);
            label8.Name = "label8";
            label8.Size = new Size(65, 23);
            label8.TabIndex = 7;
            label8.Text = "Tag :";
            // 
            // lblDirectionResult
            // 
            lblDirectionResult.AutoSize = true;
            lblDirectionResult.ForeColor = Color.FromArgb(255, 128, 0);
            lblDirectionResult.Location = new Point(319, 193);
            lblDirectionResult.Name = "lblDirectionResult";
            lblDirectionResult.Size = new Size(43, 23);
            lblDirectionResult.TabIndex = 6;
            lblDirectionResult.Text = "N/A";
            // 
            // lblYResult
            // 
            lblYResult.AutoSize = true;
            lblYResult.ForeColor = Color.FromArgb(255, 128, 0);
            lblYResult.Location = new Point(319, 143);
            lblYResult.Name = "lblYResult";
            lblYResult.Size = new Size(43, 23);
            lblYResult.TabIndex = 5;
            lblYResult.Text = "N/A";
            // 
            // lblXResult
            // 
            lblXResult.AutoSize = true;
            lblXResult.ForeColor = Color.FromArgb(255, 128, 0);
            lblXResult.Location = new Point(319, 92);
            lblXResult.Name = "lblXResult";
            lblXResult.Size = new Size(43, 23);
            lblXResult.TabIndex = 4;
            lblXResult.Text = "N/A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 193);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 3;
            label7.Text = "Yön :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 143);
            label6.Name = "label6";
            label6.Size = new Size(43, 23);
            label6.TabIndex = 2;
            label6.Text = "Y :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 92);
            label5.Name = "label5";
            label5.Size = new Size(43, 23);
            label5.TabIndex = 1;
            label5.Text = "X :";
            // 
            // lstResultTravelers
            // 
            lstResultTravelers.FormattingEnabled = true;
            lstResultTravelers.ItemHeight = 23;
            lstResultTravelers.Location = new Point(6, 46);
            lstResultTravelers.Name = "lstResultTravelers";
            lstResultTravelers.Size = new Size(208, 188);
            lstResultTravelers.TabIndex = 0;
            lstResultTravelers.SelectedIndexChanged += lstResultTravelers_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTag);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lblDirection);
            groupBox3.Controls.Add(lblY);
            groupBox3.Controls.Add(lblX);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(301, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(288, 224);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detay";
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.ForeColor = Color.FromArgb(255, 128, 0);
            lblTag.Location = new Point(91, 45);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(43, 23);
            lblTag.TabIndex = 14;
            lblTag.Text = "N/A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 45);
            label10.Name = "label10";
            label10.Size = new Size(65, 23);
            label10.TabIndex = 13;
            label10.Text = "Tag :";
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.ForeColor = Color.FromArgb(255, 128, 0);
            lblDirection.Location = new Point(91, 169);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new Size(43, 23);
            lblDirection.TabIndex = 12;
            lblDirection.Text = "N/A";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.ForeColor = Color.FromArgb(255, 128, 0);
            lblY.Location = new Point(91, 127);
            lblY.Name = "lblY";
            lblY.Size = new Size(43, 23);
            lblY.TabIndex = 11;
            lblY.Text = "N/A";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.ForeColor = Color.FromArgb(255, 128, 0);
            lblX.Location = new Point(91, 87);
            lblX.Name = "lblX";
            lblX.Size = new Size(43, 23);
            lblX.TabIndex = 10;
            lblX.Text = "N/A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 169);
            label11.Name = "label11";
            label11.Size = new Size(65, 23);
            label11.TabIndex = 9;
            label11.Text = "Yön :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 127);
            label12.Name = "label12";
            label12.Size = new Size(43, 23);
            label12.TabIndex = 8;
            label12.Text = "Y :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(42, 87);
            label13.Name = "label13";
            label13.Size = new Size(43, 23);
            label13.TabIndex = 7;
            label13.Text = "X :";
            // 
            // Mars
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 801);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnSend);
            Controls.Add(lstTravelers);
            Controls.Add(label1);
            Controls.Add(txtSize);
            Controls.Add(groupBox1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Mars";
            Text = "Mars";
            Load += Menu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSave;
        private Label label4;
        private TextBox txtTag;
        private Label label3;
        private TextBox txtInfo;
        private Label label2;
        private TextBox txtLocation;
        private TextBox txtSize;
        private Label label1;
        private ListBox lstTravelers;
        private Button btnSend;
        private GroupBox groupBox2;
        private Label lblDirectionResult;
        private Label lblYResult;
        private Label lblXResult;
        private Label label7;
        private Label label6;
        private Label label5;
        private ListBox lstResultTravelers;
        private GroupBox groupBox3;
        private Label lblDirection;
        private Label lblY;
        private Label lblX;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label lblTagResult;
        private Label label8;
        private Label lblTag;
        private Label label10;
    }
}