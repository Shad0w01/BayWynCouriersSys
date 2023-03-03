namespace BayWyn_Couriers_System
{
    partial class frmDashboard
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
            this.btnNewCon = new System.Windows.Forms.Button();
            this.btnCreateJob = new System.Windows.Forms.Button();
            this.btnEditContract = new System.Windows.Forms.Button();
            this.btnViewContract = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnSetDtd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCon
            // 
            this.btnNewCon.Enabled = false;
            this.btnNewCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCon.Location = new System.Drawing.Point(134, 103);
            this.btnNewCon.Name = "btnNewCon";
            this.btnNewCon.Size = new System.Drawing.Size(130, 89);
            this.btnNewCon.TabIndex = 0;
            this.btnNewCon.Text = "Create new client contract";
            this.btnNewCon.UseVisualStyleBackColor = true;
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.Enabled = false;
            this.btnCreateJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateJob.Location = new System.Drawing.Point(270, 103);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(130, 89);
            this.btnCreateJob.TabIndex = 1;
            this.btnCreateJob.Text = "Create courier job (non-contracted client)";
            this.btnCreateJob.UseVisualStyleBackColor = true;
            // 
            // btnEditContract
            // 
            this.btnEditContract.Enabled = false;
            this.btnEditContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditContract.Location = new System.Drawing.Point(406, 103);
            this.btnEditContract.Name = "btnEditContract";
            this.btnEditContract.Size = new System.Drawing.Size(130, 89);
            this.btnEditContract.TabIndex = 2;
            this.btnEditContract.Text = "Edit Customer Contract";
            this.btnEditContract.UseVisualStyleBackColor = true;
            // 
            // btnViewContract
            // 
            this.btnViewContract.Enabled = false;
            this.btnViewContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewContract.Location = new System.Drawing.Point(542, 103);
            this.btnViewContract.Name = "btnViewContract";
            this.btnViewContract.Size = new System.Drawing.Size(130, 89);
            this.btnViewContract.TabIndex = 3;
            this.btnViewContract.Text = "View Customer Contract";
            this.btnViewContract.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(270, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 89);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel a delivery";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(406, 208);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(130, 89);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept delievery";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Enabled = false;
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(542, 208);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(130, 89);
            this.btnViewReport.TabIndex = 6;
            this.btnViewReport.Text = "View reports";
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // btnSetDtd
            // 
            this.btnSetDtd.Enabled = false;
            this.btnSetDtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDtd.Location = new System.Drawing.Point(134, 208);
            this.btnSetDtd.Name = "btnSetDtd";
            this.btnSetDtd.Size = new System.Drawing.Size(130, 89);
            this.btnSetDtd.TabIndex = 7;
            this.btnSetDtd.Text = "Set delivery time/date";
            this.btnSetDtd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(248, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "BayWyn Couriers Dashboard";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 240);
            this.dataGridView1.TabIndex = 9;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetDtd);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnViewContract);
            this.Controls.Add(this.btnEditContract);
            this.Controls.Add(this.btnCreateJob);
            this.Controls.Add(this.btnNewCon);
            this.Name = "frmDashboard";
            this.Text = "BayWyn Couriers Dashboard";
            //this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnNewCon;
        public System.Windows.Forms.Button btnCreateJob;
        public System.Windows.Forms.Button btnEditContract;
        public System.Windows.Forms.Button btnViewContract;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAccept;
        public System.Windows.Forms.Button btnViewReport;
        public System.Windows.Forms.Button btnSetDtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

