namespace CustomerXCittà
{
    partial class Form1
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
            this.cbx_citta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgr_customerXcitta = new System.Windows.Forms.DataGridView();
            this.btn_cerca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_customerXcitta)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_citta
            // 
            this.cbx_citta.FormattingEnabled = true;
            this.cbx_citta.Location = new System.Drawing.Point(65, 64);
            this.cbx_citta.Name = "cbx_citta";
            this.cbx_citta.Size = new System.Drawing.Size(335, 28);
            this.cbx_citta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Città";
            // 
            // dgr_customerXcitta
            // 
            this.dgr_customerXcitta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_customerXcitta.Location = new System.Drawing.Point(68, 173);
            this.dgr_customerXcitta.Name = "dgr_customerXcitta";
            this.dgr_customerXcitta.RowHeadersWidth = 62;
            this.dgr_customerXcitta.RowTemplate.Height = 28;
            this.dgr_customerXcitta.Size = new System.Drawing.Size(677, 233);
            this.dgr_customerXcitta.TabIndex = 2;
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(466, 50);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(278, 56);
            this.btn_cerca.TabIndex = 3;
            this.btn_cerca.Text = "Cerca clienti per città";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.dgr_customerXcitta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_citta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_customerXcitta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_citta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgr_customerXcitta;
        private System.Windows.Forms.Button btn_cerca;
    }
}

