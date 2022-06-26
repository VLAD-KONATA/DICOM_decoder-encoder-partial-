
namespace DicomTest
{
    partial class FrmImage
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsWindowLabel = new System.Windows.Forms.ToolStripLabel();
            this.tsWindow = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsLevel = new System.Windows.Forms.ToolStripTextBox();
            this.tsCombobox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsWindowLabel,
            this.tsWindow,
            this.toolStripLabel1,
            this.tsLevel,
            this.tsCombobox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsWindowLabel
            // 
            this.tsWindowLabel.Name = "tsWindowLabel";
            this.tsWindowLabel.Size = new System.Drawing.Size(54, 25);
            this.tsWindowLabel.Text = "窗宽：";
            // 
            // tsWindow
            // 
            this.tsWindow.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tsWindow.Name = "tsWindow";
            this.tsWindow.Size = new System.Drawing.Size(100, 28);
            this.tsWindow.Text = "2000";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 25);
            this.toolStripLabel1.Text = "窗位：";
            // 
            // tsLevel
            // 
            this.tsLevel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tsLevel.Name = "tsLevel";
            this.tsLevel.Size = new System.Drawing.Size(100, 28);
            this.tsLevel.Text = "0";
            // 
            // tsCombobox
            // 
            this.tsCombobox.Items.AddRange(new object[] {
            "脑窗",
            "骨窗",
            "纵隔窗",
            "肺窗",
            "肝窗",
            "腹窗",
            "脊柱窗",
            "宽肺窗"});
            this.tsCombobox.Name = "tsCombobox";
            this.tsCombobox.Size = new System.Drawing.Size(121, 28);
            this.tsCombobox.TextChanged += new System.EventHandler(this.tsCombobox_TextChanged);
            // 
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImage";
            this.Text = "FrmImage";
            this.Load += new System.EventHandler(this.FrmImage_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmImage_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsWindowLabel;
        private System.Windows.Forms.ToolStripTextBox tsWindow;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsLevel;
        private System.Windows.Forms.ToolStripComboBox tsCombobox;
    }
}