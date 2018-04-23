namespace MasterDetailProject {
    partial class Form1 {
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
            this.customGridControlClass1 = new MasterDetailProject.CustomGridControlClass();
            this.customGridView1 = new MasterDetailProject.CustomGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControlClass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customGridControlClass1
            // 
            this.customGridControlClass1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGridControlClass1.Location = new System.Drawing.Point(0, 0);
            this.customGridControlClass1.MainView = this.customGridView1;
            this.customGridControlClass1.Name = "customGridControlClass1";
            this.customGridControlClass1.Size = new System.Drawing.Size(313, 354);
            this.customGridControlClass1.TabIndex = 0;
            this.customGridControlClass1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView1});
            // 
            // customGridView1
            // 
            this.customGridView1.GridControl = this.customGridControlClass1;
            this.customGridView1.Name = "customGridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 354);
            this.Controls.Add(this.customGridControlClass1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customGridControlClass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGridControlClass customGridControlClass1;
        private CustomGridView customGridView1;


    }
}

