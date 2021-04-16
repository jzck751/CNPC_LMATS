
namespace CNPC_LMATS
{
    partial class mainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.welcom_button = new System.Windows.Forms.Label();
            this.materialCollection_button = new System.Windows.Forms.Button();
            this.dataTrim_button = new System.Windows.Forms.Button();
            this.qualityTrack_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.qualityTrack_button);
            this.splitContainer1.Panel1.Controls.Add(this.dataTrim_button);
            this.splitContainer1.Panel1.Controls.Add(this.materialCollection_button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.welcom_button);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // welcom_button
            // 
            this.welcom_button.AutoSize = true;
            this.welcom_button.Location = new System.Drawing.Point(200, 200);
            this.welcom_button.Name = "welcom_button";
            this.welcom_button.Size = new System.Drawing.Size(277, 15);
            this.welcom_button.TabIndex = 0;
            this.welcom_button.Text = "欢迎登入中石油录井资料采集与整理系统";
            // 
            // materialCollection_button
            // 
            this.materialCollection_button.Location = new System.Drawing.Point(23, 94);
            this.materialCollection_button.Name = "materialCollection_button";
            this.materialCollection_button.Size = new System.Drawing.Size(150, 50);
            this.materialCollection_button.TabIndex = 0;
            this.materialCollection_button.Text = "数据采集系统";
            this.materialCollection_button.UseVisualStyleBackColor = true;
            // 
            // dataTrim_button
            // 
            this.dataTrim_button.Location = new System.Drawing.Point(23, 182);
            this.dataTrim_button.Name = "dataTrim_button";
            this.dataTrim_button.Size = new System.Drawing.Size(150, 50);
            this.dataTrim_button.TabIndex = 1;
            this.dataTrim_button.Text = "资料整理系统";
            this.dataTrim_button.UseVisualStyleBackColor = true;
            // 
            // qualityTrack_button
            // 
            this.qualityTrack_button.Location = new System.Drawing.Point(23, 273);
            this.qualityTrack_button.Name = "qualityTrack_button";
            this.qualityTrack_button.Size = new System.Drawing.Size(150, 50);
            this.qualityTrack_button.TabIndex = 2;
            this.qualityTrack_button.Text = "质量跟踪系统";
            this.qualityTrack_button.UseVisualStyleBackColor = true;
            this.qualityTrack_button.Click += new System.EventHandler(this.qualityTrack_button_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label welcom_button;
        private System.Windows.Forms.Button qualityTrack_button;
        private System.Windows.Forms.Button dataTrim_button;
        private System.Windows.Forms.Button materialCollection_button;
    }
}