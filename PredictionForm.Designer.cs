namespace Classifier
{
    partial class PredictionForm
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
            this.Predictperc = new System.Windows.Forms.Button();
            this.predictMindistance = new System.Windows.Forms.Button();
            this.pnlTextBoxes = new System.Windows.Forms.Panel();
            this.dataGridViewresperc = new System.Windows.Forms.DataGridView();
            this.dataGridViewresdist = new System.Windows.Forms.DataGridView();
            this.dataGridViewdist = new System.Windows.Forms.DataGridView();
            this.dataGridViewperc = new System.Windows.Forms.DataGridView();
            this.btnQualAssess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresperc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresdist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewperc)).BeginInit();
            this.SuspendLayout();
            // 
            // Predictperc
            // 
            this.Predictperc.Location = new System.Drawing.Point(469, 130);
            this.Predictperc.Name = "Predictperc";
            this.Predictperc.Size = new System.Drawing.Size(138, 57);
            this.Predictperc.TabIndex = 0;
            this.Predictperc.Text = "Predict by Perceptron";
            this.Predictperc.UseVisualStyleBackColor = true;
            this.Predictperc.Click += new System.EventHandler(this.Predictperc_Click);
            // 
            // predictMindistance
            // 
            this.predictMindistance.Location = new System.Drawing.Point(650, 130);
            this.predictMindistance.Name = "predictMindistance";
            this.predictMindistance.Size = new System.Drawing.Size(138, 57);
            this.predictMindistance.TabIndex = 1;
            this.predictMindistance.Text = "Predict by Min Distance";
            this.predictMindistance.UseVisualStyleBackColor = true;
            this.predictMindistance.Click += new System.EventHandler(this.predictMindistance_Click);
            // 
            // pnlTextBoxes
            // 
            this.pnlTextBoxes.Location = new System.Drawing.Point(12, 45);
            this.pnlTextBoxes.Name = "pnlTextBoxes";
            this.pnlTextBoxes.Size = new System.Drawing.Size(776, 75);
            this.pnlTextBoxes.TabIndex = 2;
            // 
            // dataGridViewresperc
            // 
            this.dataGridViewresperc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewresperc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewresperc.Location = new System.Drawing.Point(469, 193);
            this.dataGridViewresperc.Name = "dataGridViewresperc";
            this.dataGridViewresperc.RowHeadersWidth = 51;
            this.dataGridViewresperc.RowTemplate.Height = 24;
            this.dataGridViewresperc.Size = new System.Drawing.Size(138, 57);
            this.dataGridViewresperc.TabIndex = 3;
            // 
            // dataGridViewresdist
            // 
            this.dataGridViewresdist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewresdist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewresdist.Location = new System.Drawing.Point(650, 193);
            this.dataGridViewresdist.Name = "dataGridViewresdist";
            this.dataGridViewresdist.RowHeadersWidth = 51;
            this.dataGridViewresdist.RowTemplate.Height = 24;
            this.dataGridViewresdist.Size = new System.Drawing.Size(138, 57);
            this.dataGridViewresdist.TabIndex = 4;
            // 
            // dataGridViewdist
            // 
            this.dataGridViewdist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewdist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdist.Location = new System.Drawing.Point(227, 175);
            this.dataGridViewdist.Name = "dataGridViewdist";
            this.dataGridViewdist.RowHeadersWidth = 51;
            this.dataGridViewdist.RowTemplate.Height = 24;
            this.dataGridViewdist.Size = new System.Drawing.Size(197, 86);
            this.dataGridViewdist.TabIndex = 5;
            // 
            // dataGridViewperc
            // 
            this.dataGridViewperc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewperc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewperc.Location = new System.Drawing.Point(17, 175);
            this.dataGridViewperc.Name = "dataGridViewperc";
            this.dataGridViewperc.RowHeadersWidth = 51;
            this.dataGridViewperc.RowTemplate.Height = 24;
            this.dataGridViewperc.Size = new System.Drawing.Size(197, 86);
            this.dataGridViewperc.TabIndex = 6;
            // 
            // btnQualAssess
            // 
            this.btnQualAssess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQualAssess.Location = new System.Drawing.Point(17, 267);
            this.btnQualAssess.Name = "btnQualAssess";
            this.btnQualAssess.Size = new System.Drawing.Size(407, 57);
            this.btnQualAssess.TabIndex = 7;
            this.btnQualAssess.Text = "Quality Assessment";
            this.btnQualAssess.UseVisualStyleBackColor = true;
            this.btnQualAssess.Click += new System.EventHandler(this.btnQualAssess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perceptron";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(222, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "MinDistance";
            // 
            // PredictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQualAssess);
            this.Controls.Add(this.dataGridViewperc);
            this.Controls.Add(this.dataGridViewdist);
            this.Controls.Add(this.dataGridViewresdist);
            this.Controls.Add(this.dataGridViewresperc);
            this.Controls.Add(this.pnlTextBoxes);
            this.Controls.Add(this.predictMindistance);
            this.Controls.Add(this.Predictperc);
            this.Name = "PredictionForm";
            this.Text = "PredictionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresperc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresdist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewperc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Predictperc;
        private System.Windows.Forms.Button predictMindistance;
        private System.Windows.Forms.Panel pnlTextBoxes;
        private System.Windows.Forms.DataGridView dataGridViewresperc;
        private System.Windows.Forms.DataGridView dataGridViewresdist;
        private System.Windows.Forms.DataGridView dataGridViewdist;
        private System.Windows.Forms.DataGridView dataGridViewperc;
        private System.Windows.Forms.Button btnQualAssess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}