namespace S2GroupProject.Forms
{
    partial class Experiment
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
            this.EmployeeFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // EmployeeFlowPanel
            // 
            this.EmployeeFlowPanel.Location = new System.Drawing.Point(3, 5);
            this.EmployeeFlowPanel.Name = "EmployeeFlowPanel";
            this.EmployeeFlowPanel.Size = new System.Drawing.Size(1165, 720);
            this.EmployeeFlowPanel.TabIndex = 0;
            // 
            // Experiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 728);
            this.Controls.Add(this.EmployeeFlowPanel);
            this.Name = "Experiment";
            this.Text = "Experiment";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel EmployeeFlowPanel;
    }
}