namespace Classifier
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.sFD = new System.Windows.Forms.SaveFileDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.lblweights = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1st = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2nd = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewWeights = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblIntraClassDistance = new System.Windows.Forms.Label();
            this.lblInter1ClassDistance = new System.Windows.Forms.Label();
            this.lblInter2ClassDistance = new System.Windows.Forms.Label();
            this.numericUpDownLearninrate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIters = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainMenu.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1st)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2nd)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLearninrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1420, 30);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.dataGridView);
            this.panel.Location = new System.Drawing.Point(12, 77);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(709, 280);
            this.panel.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(709, 280);
            this.dataGridView.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnStart.Location = new System.Drawing.Point(12, 490);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(277, 63);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Characteristics";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(1155, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "CLose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Enabled = false;
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnTrain.Location = new System.Drawing.Point(306, 490);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(277, 63);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // lblweights
            // 
            this.lblweights.AutoSize = true;
            this.lblweights.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblweights.Location = new System.Drawing.Point(585, 362);
            this.lblweights.Name = "lblweights";
            this.lblweights.Size = new System.Drawing.Size(277, 29);
            this.lblweights.TabIndex = 17;
            this.lblweights.Text = "Weights of Perceptron: ";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridView1st);
            this.panel2.Location = new System.Drawing.Point(746, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 195);
            this.panel2.TabIndex = 22;
            // 
            // dataGridView1st
            // 
            this.dataGridView1st.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1st.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1st.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1st.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1st.Name = "dataGridView1st";
            this.dataGridView1st.RowHeadersWidth = 51;
            this.dataGridView1st.RowTemplate.Height = 24;
            this.dataGridView1st.Size = new System.Drawing.Size(304, 195);
            this.dataGridView1st.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(741, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Characteristics of 1st Class";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dataGridView2nd);
            this.panel3.Location = new System.Drawing.Point(1067, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 195);
            this.panel3.TabIndex = 23;
            // 
            // dataGridView2nd
            // 
            this.dataGridView2nd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2nd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2nd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2nd.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2nd.Name = "dataGridView2nd";
            this.dataGridView2nd.RowHeadersWidth = 51;
            this.dataGridView2nd.RowTemplate.Height = 24;
            this.dataGridView2nd.Size = new System.Drawing.Size(304, 195);
            this.dataGridView2nd.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(1062, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Characteristics of 2nd Class";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.dataGridViewWeights);
            this.panel5.Location = new System.Drawing.Point(585, 394);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(465, 68);
            this.panel5.TabIndex = 25;
            // 
            // dataGridViewWeights
            // 
            this.dataGridViewWeights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWeights.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWeights.Name = "dataGridViewWeights";
            this.dataGridViewWeights.RowHeadersWidth = 51;
            this.dataGridViewWeights.RowTemplate.Height = 24;
            this.dataGridViewWeights.Size = new System.Drawing.Size(465, 68);
            this.dataGridViewWeights.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(12, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 29);
            this.label11.TabIndex = 27;
            this.label11.Text = "Your DataSet:";
            // 
            // btnPredict
            // 
            this.btnPredict.Enabled = false;
            this.btnPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPredict.Location = new System.Drawing.Point(746, 487);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(277, 63);
            this.btnPredict.TabIndex = 28;
            this.btnPredict.Text = "Go to predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // lblIntraClassDistance
            // 
            this.lblIntraClassDistance.AutoSize = true;
            this.lblIntraClassDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblIntraClassDistance.Location = new System.Drawing.Point(741, 328);
            this.lblIntraClassDistance.Name = "lblIntraClassDistance";
            this.lblIntraClassDistance.Size = new System.Drawing.Size(236, 29);
            this.lblIntraClassDistance.TabIndex = 29;
            this.lblIntraClassDistance.Text = "Intra Class Distance: ";
            // 
            // lblInter1ClassDistance
            // 
            this.lblInter1ClassDistance.AutoSize = true;
            this.lblInter1ClassDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInter1ClassDistance.Location = new System.Drawing.Point(741, 77);
            this.lblInter1ClassDistance.Name = "lblInter1ClassDistance";
            this.lblInter1ClassDistance.Size = new System.Drawing.Size(228, 25);
            this.lblInter1ClassDistance.TabIndex = 30;
            this.lblInter1ClassDistance.Text = "Inter 1st Class Distance: ";
            // 
            // lblInter2ClassDistance
            // 
            this.lblInter2ClassDistance.AutoSize = true;
            this.lblInter2ClassDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInter2ClassDistance.Location = new System.Drawing.Point(1062, 77);
            this.lblInter2ClassDistance.Name = "lblInter2ClassDistance";
            this.lblInter2ClassDistance.Size = new System.Drawing.Size(235, 25);
            this.lblInter2ClassDistance.TabIndex = 31;
            this.lblInter2ClassDistance.Text = "Inter 2nd Class Distance: ";
            // 
            // numericUpDownLearninrate
            // 
            this.numericUpDownLearninrate.DecimalPlaces = 2;
            this.numericUpDownLearninrate.Enabled = false;
            this.numericUpDownLearninrate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownLearninrate.Location = new System.Drawing.Point(485, 394);
            this.numericUpDownLearninrate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLearninrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownLearninrate.Name = "numericUpDownLearninrate";
            this.numericUpDownLearninrate.Size = new System.Drawing.Size(94, 22);
            this.numericUpDownLearninrate.TabIndex = 32;
            this.numericUpDownLearninrate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDownIters
            // 
            this.numericUpDownIters.Enabled = false;
            this.numericUpDownIters.Location = new System.Drawing.Point(485, 440);
            this.numericUpDownIters.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIters.Name = "numericUpDownIters";
            this.numericUpDownIters.Size = new System.Drawing.Size(94, 22);
            this.numericUpDownIters.TabIndex = 33;
            this.numericUpDownIters.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(202, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Learning Rate: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(202, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Iteration\'s Count: ";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Classifier.MyObjects);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownIters);
            this.Controls.Add(this.numericUpDownLearninrate);
            this.Controls.Add(this.lblInter2ClassDistance);
            this.Controls.Add(this.lblInter1ClassDistance);
            this.Controls.Add(this.lblIntraClassDistance);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblweights);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1st)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2nd)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLearninrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.SaveFileDialog sFD;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Label lblweights;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1st;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2nd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewWeights;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblIntraClassDistance;
        private System.Windows.Forms.Label lblInter1ClassDistance;
        private System.Windows.Forms.Label lblInter2ClassDistance;
        private System.Windows.Forms.NumericUpDown numericUpDownLearninrate;
        private System.Windows.Forms.NumericUpDown numericUpDownIters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}