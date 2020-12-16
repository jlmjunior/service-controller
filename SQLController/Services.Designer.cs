namespace SQLController
{
    partial class Services
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.servicesSelection = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusResult = new System.Windows.Forms.Label();
            this.textServiceList = new System.Windows.Forms.TextBox();
            this.lblServiceList = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 59);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(12, 99);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 34);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(149, 59);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(534, 74);
            this.txtResult.TabIndex = 2;
            // 
            // servicesSelection
            // 
            this.servicesSelection.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesSelection.FormattingEnabled = true;
            this.servicesSelection.Items.AddRange(new object[] {
            "SQL SERVER",
            "MYSQL"});
            this.servicesSelection.Location = new System.Drawing.Point(12, 12);
            this.servicesSelection.Name = "servicesSelection";
            this.servicesSelection.Size = new System.Drawing.Size(671, 28);
            this.servicesSelection.TabIndex = 3;
            this.servicesSelection.SelectedIndexChanged += new System.EventHandler(this.ServicesSelection_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStatus.Location = new System.Drawing.Point(145, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusResult
            // 
            this.lblStatusResult.AutoSize = true;
            this.lblStatusResult.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatusResult.Location = new System.Drawing.Point(210, 140);
            this.lblStatusResult.Name = "lblStatusResult";
            this.lblStatusResult.Size = new System.Drawing.Size(16, 20);
            this.lblStatusResult.TabIndex = 5;
            this.lblStatusResult.Text = "-";
            // 
            // textServiceList
            // 
            this.textServiceList.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textServiceList.Location = new System.Drawing.Point(12, 252);
            this.textServiceList.Multiline = true;
            this.textServiceList.Name = "textServiceList";
            this.textServiceList.ReadOnly = true;
            this.textServiceList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textServiceList.Size = new System.Drawing.Size(671, 146);
            this.textServiceList.TabIndex = 6;
            // 
            // lblServiceList
            // 
            this.lblServiceList.AutoSize = true;
            this.lblServiceList.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceList.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblServiceList.Location = new System.Drawing.Point(12, 189);
            this.lblServiceList.Name = "lblServiceList";
            this.lblServiceList.Size = new System.Drawing.Size(121, 20);
            this.lblServiceList.TabIndex = 7;
            this.lblServiceList.Text = "SERVICE LIST";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(625, 404);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(58, 28);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(12, 217);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(671, 27);
            this.textSearch.TabIndex = 9;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblServiceList);
            this.Controls.Add(this.textServiceList);
            this.Controls.Add(this.lblStatusResult);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.servicesSelection);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox servicesSelection;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusResult;
        private System.Windows.Forms.TextBox textServiceList;
        private System.Windows.Forms.Label lblServiceList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox textSearch;
    }
}

