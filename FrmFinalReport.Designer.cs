namespace Evaluation_Manager {
    partial class FrmFinalReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(198, 27);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(483, 310);
            this.dgvResults.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFinalReport
            // 
            this.ClientSize = new System.Drawing.Size(837, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvResults);
            this.Name = "FrmFinalReport";
            this.Text = "Zavrsni izvjestaj s kontinuiranog pracenja";
            this.Load += new System.EventHandler(this.FrmFinalReport_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrResaults;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGenerateEvaluationReport;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button button1;
    }
}