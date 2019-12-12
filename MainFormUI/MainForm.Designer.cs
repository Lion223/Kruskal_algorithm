namespace MainFormUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.minTb = new System.Windows.Forms.RichTextBox();
            this.maxTb = new System.Windows.Forms.RichTextBox();
            this.readfileBtn = new MetroFramework.Controls.MetroButton();
            this.fileTb = new System.Windows.Forms.RichTextBox();
            this.fullkruscalBtn = new MetroFramework.Controls.MetroButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fileLbl = new MetroFramework.Controls.MetroLabel();
            this.graphViewer = new Microsoft.Glee.GraphViewerGdi.GViewer();
            this.graphrbMp = new MetroFramework.Controls.MetroPanel();
            this.graph_maxRb = new MetroFramework.Controls.MetroRadioButton();
            this.graph_minRb = new MetroFramework.Controls.MetroRadioButton();
            this.graphRb = new MetroFramework.Controls.MetroRadioButton();
            this.graphrbMp.SuspendLayout();
            this.SuspendLayout();
            // 
            // minTb
            // 
            this.minTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minTb.Location = new System.Drawing.Point(23, 77);
            this.minTb.Name = "minTb";
            this.minTb.Size = new System.Drawing.Size(242, 189);
            this.minTb.TabIndex = 0;
            this.minTb.Text = "";
            // 
            // maxTb
            // 
            this.maxTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTb.Location = new System.Drawing.Point(271, 77);
            this.maxTb.Name = "maxTb";
            this.maxTb.Size = new System.Drawing.Size(242, 189);
            this.maxTb.TabIndex = 1;
            this.maxTb.Text = "";
            // 
            // readfileBtn
            // 
            this.readfileBtn.Location = new System.Drawing.Point(222, 22);
            this.readfileBtn.Name = "readfileBtn";
            this.readfileBtn.Size = new System.Drawing.Size(171, 34);
            this.readfileBtn.TabIndex = 2;
            this.readfileBtn.Text = "Read data from a text file";
            this.readfileBtn.UseSelectable = true;
            this.readfileBtn.Click += new System.EventHandler(this.readfileBtn_Click);
            // 
            // fileTb
            // 
            this.fileTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileTb.Location = new System.Drawing.Point(519, 77);
            this.fileTb.Name = "fileTb";
            this.fileTb.ReadOnly = true;
            this.fileTb.Size = new System.Drawing.Size(115, 189);
            this.fileTb.TabIndex = 3;
            this.fileTb.Text = "";
            // 
            // fullkruscalBtn
            // 
            this.fullkruscalBtn.Location = new System.Drawing.Point(399, 22);
            this.fullkruscalBtn.Name = "fullkruscalBtn";
            this.fullkruscalBtn.Size = new System.Drawing.Size(122, 34);
            this.fullkruscalBtn.TabIndex = 4;
            this.fullkruscalBtn.Text = "Execute";
            this.fullkruscalBtn.UseSelectable = true;
            this.fullkruscalBtn.Click += new System.EventHandler(this.fullkruscalBtn_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // fileLbl
            // 
            this.fileLbl.Location = new System.Drawing.Point(519, 247);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(116, 19);
            this.fileLbl.TabIndex = 6;
            this.fileLbl.Text = "No file opened";
            this.fileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graphViewer
            // 
            this.graphViewer.AsyncLayout = false;
            this.graphViewer.AutoScroll = true;
            this.graphViewer.BackwardEnabled = false;
            this.graphViewer.ForwardEnabled = false;
            this.graphViewer.Graph = null;
            this.graphViewer.Location = new System.Drawing.Point(23, 272);
            this.graphViewer.MouseHitDistance = 0.05D;
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.NavigationVisible = true;
            this.graphViewer.PanButtonPressed = false;
            this.graphViewer.SaveButtonVisible = true;
            this.graphViewer.Size = new System.Drawing.Size(612, 318);
            this.graphViewer.TabIndex = 7;
            this.graphViewer.ZoomF = 1D;
            this.graphViewer.ZoomFraction = 0.5D;
            this.graphViewer.ZoomWindowThreshold = 0.05D;
            // 
            // graphrbMp
            // 
            this.graphrbMp.Controls.Add(this.graph_maxRb);
            this.graphrbMp.Controls.Add(this.graph_minRb);
            this.graphrbMp.Controls.Add(this.graphRb);
            this.graphrbMp.Enabled = false;
            this.graphrbMp.HorizontalScrollbarBarColor = true;
            this.graphrbMp.HorizontalScrollbarHighlightOnWheel = false;
            this.graphrbMp.HorizontalScrollbarSize = 10;
            this.graphrbMp.Location = new System.Drawing.Point(23, 596);
            this.graphrbMp.Name = "graphrbMp";
            this.graphrbMp.Size = new System.Drawing.Size(611, 35);
            this.graphrbMp.TabIndex = 8;
            this.graphrbMp.VerticalScrollbarBarColor = true;
            this.graphrbMp.VerticalScrollbarHighlightOnWheel = false;
            this.graphrbMp.VerticalScrollbarSize = 10;
            // 
            // graph_maxRb
            // 
            this.graph_maxRb.AutoSize = true;
            this.graph_maxRb.Location = new System.Drawing.Point(152, 8);
            this.graph_maxRb.Name = "graph_maxRb";
            this.graph_maxRb.Size = new System.Drawing.Size(52, 15);
            this.graph_maxRb.TabIndex = 4;
            this.graph_maxRb.Text = "MaST";
            this.graph_maxRb.UseSelectable = true;
            this.graph_maxRb.CheckedChanged += new System.EventHandler(this.graph_maxRb_CheckedChanged);
            // 
            // graph_minRb
            // 
            this.graph_minRb.AutoSize = true;
            this.graph_minRb.Location = new System.Drawing.Point(81, 8);
            this.graph_minRb.Name = "graph_minRb";
            this.graph_minRb.Size = new System.Drawing.Size(49, 15);
            this.graph_minRb.TabIndex = 3;
            this.graph_minRb.Text = "MiST";
            this.graph_minRb.UseSelectable = true;
            this.graph_minRb.CheckedChanged += new System.EventHandler(this.graph_minRb_CheckedChanged);
            // 
            // graphRb
            // 
            this.graphRb.AutoSize = true;
            this.graphRb.Checked = true;
            this.graphRb.Location = new System.Drawing.Point(12, 8);
            this.graphRb.Name = "graphRb";
            this.graphRb.Size = new System.Drawing.Size(55, 15);
            this.graphRb.TabIndex = 2;
            this.graphRb.TabStop = true;
            this.graphRb.Text = "Graph";
            this.graphRb.UseSelectable = true;
            this.graphRb.CheckedChanged += new System.EventHandler(this.graphRb_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 642);
            this.Controls.Add(this.graphrbMp);
            this.Controls.Add(this.graphViewer);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.fullkruscalBtn);
            this.Controls.Add(this.fileTb);
            this.Controls.Add(this.readfileBtn);
            this.Controls.Add(this.maxTb);
            this.Controls.Add(this.minTb);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Kruskal Algorithm";
            this.graphrbMp.ResumeLayout(false);
            this.graphrbMp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox maxTb;
        private MetroFramework.Controls.MetroButton readfileBtn;
        public System.Windows.Forms.RichTextBox minTb;
        public System.Windows.Forms.RichTextBox fileTb;
        private MetroFramework.Controls.MetroButton fullkruscalBtn;
        private System.Windows.Forms.OpenFileDialog ofd;
        private MetroFramework.Controls.MetroLabel fileLbl;
        private Microsoft.Glee.GraphViewerGdi.GViewer graphViewer;
        private MetroFramework.Controls.MetroPanel graphrbMp;
        private MetroFramework.Controls.MetroRadioButton graph_maxRb;
        private MetroFramework.Controls.MetroRadioButton graph_minRb;
        private MetroFramework.Controls.MetroRadioButton graphRb;
    }
}

