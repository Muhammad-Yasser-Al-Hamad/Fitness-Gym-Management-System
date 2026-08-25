namespace fitness_gym_system
{
    partial class UC_ManageSessions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSessionName = new System.Windows.Forms.TextBox();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.dtpSessionDate = new System.Windows.Forms.DateTimePicker();
            this.txtSessionTime = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSaveSession = new System.Windows.Forms.Button();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.btnClearSession = new System.Windows.Forms.Button();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.lblSessionName = new System.Windows.Forms.Label();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSessionName
            // 
            this.txtSessionName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtSessionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSessionName.ForeColor = System.Drawing.Color.White;
            this.txtSessionName.Location = new System.Drawing.Point(130, 18);
            this.txtSessionName.Name = "txtSessionName";
            this.txtSessionName.Size = new System.Drawing.Size(200, 20);
            this.txtSessionName.TabIndex = 0;
            // 
            // txtCoachName
            // 
            this.txtCoachName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtCoachName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoachName.ForeColor = System.Drawing.Color.White;
            this.txtCoachName.Location = new System.Drawing.Point(130, 53);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(200, 20);
            this.txtCoachName.TabIndex = 1;
            // 
            // dtpSessionDate
            // 
            this.dtpSessionDate.Location = new System.Drawing.Point(130, 88);
            this.dtpSessionDate.Name = "dtpSessionDate";
            this.dtpSessionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSessionDate.TabIndex = 2;
            // 
            // txtSessionTime
            // 
            this.txtSessionTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtSessionTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSessionTime.ForeColor = System.Drawing.Color.White;
            this.txtSessionTime.Location = new System.Drawing.Point(130, 123);
            this.txtSessionTime.Name = "txtSessionTime";
            this.txtSessionTime.Size = new System.Drawing.Size(200, 20);
            this.txtSessionTime.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(130, 158);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSaveSession.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSession.Location = new System.Drawing.Point(20, 200);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(90, 30);
            this.btnSaveSession.TabIndex = 5;
            this.btnSaveSession.Text = "Save";
            this.btnSaveSession.UseVisualStyleBackColor = false;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDeleteSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSession.Location = new System.Drawing.Point(120, 200);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteSession.TabIndex = 6;
            this.btnDeleteSession.Text = "Delete";
            this.btnDeleteSession.UseVisualStyleBackColor = false;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // btnClearSession
            // 
            this.btnClearSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClearSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearSession.Location = new System.Drawing.Point(220, 200);
            this.btnClearSession.Name = "btnClearSession";
            this.btnClearSession.Size = new System.Drawing.Size(90, 30);
            this.btnClearSession.TabIndex = 7;
            this.btnClearSession.Text = "Clear";
            this.btnClearSession.UseVisualStyleBackColor = false;
            this.btnClearSession.Click += new System.EventHandler(this.btnClearSession_Click);
            // 
            // dgvSessions
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgvSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSessions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSessions.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSessions.EnableHeadersVisualStyles = false;
            this.dgvSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgvSessions.Location = new System.Drawing.Point(20, 250);
            this.dgvSessions.Name = "dgvSessions";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessions.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSessions.Size = new System.Drawing.Size(750, 250);
            this.dgvSessions.TabIndex = 8;
            this.dgvSessions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessions_CellClick);
            // 
            // lblSessionName
            // 
            this.lblSessionName.ForeColor = System.Drawing.Color.White;
            this.lblSessionName.Location = new System.Drawing.Point(20, 20);
            this.lblSessionName.Name = "lblSessionName";
            this.lblSessionName.Size = new System.Drawing.Size(100, 20);
            this.lblSessionName.TabIndex = 0;
            this.lblSessionName.Text = "Session Name:";
            // 
            // lblCoachName
            // 
            this.lblCoachName.ForeColor = System.Drawing.Color.White;
            this.lblCoachName.Location = new System.Drawing.Point(20, 55);
            this.lblCoachName.Name = "lblCoachName";
            this.lblCoachName.Size = new System.Drawing.Size(100, 20);
            this.lblCoachName.TabIndex = 1;
            this.lblCoachName.Text = "Coach Name:";
            // 
            // lblDate
            // 
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(20, 90);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Session Date:";
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(20, 125);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Session Time:";
            // 
            // lblPrice
            // 
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(20, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::fitness_gym_system.Properties.Resources.dumbbell_xxl;
            this.pictureBox1.Location = new System.Drawing.Point(739, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // UC_ManageSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSessionName);
            this.Controls.Add(this.txtSessionName);
            this.Controls.Add(this.lblCoachName);
            this.Controls.Add(this.txtCoachName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpSessionDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtSessionTime);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSaveSession);
            this.Controls.Add(this.btnDeleteSession);
            this.Controls.Add(this.btnClearSession);
            this.Controls.Add(this.dgvSessions);
            this.Name = "UC_ManageSessions";
            this.Size = new System.Drawing.Size(809, 547);
            this.Load += new System.EventHandler(this.UC_ManageSessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtSessionName;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.DateTimePicker dtpSessionDate;
        private System.Windows.Forms.TextBox txtSessionTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSaveSession;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.Button btnClearSession;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.Label lblSessionName;
        private System.Windows.Forms.Label lblCoachName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}