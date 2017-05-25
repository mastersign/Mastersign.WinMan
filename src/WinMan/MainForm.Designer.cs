namespace Mastersign.WinMan
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListTopWindows = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.listWindows = new System.Windows.Forms.ListView();
            this.colHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWindowClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScreen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVirtualDesktop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnListTopWindows
            // 
            this.btnListTopWindows.Location = new System.Drawing.Point(12, 12);
            this.btnListTopWindows.Name = "btnListTopWindows";
            this.btnListTopWindows.Size = new System.Drawing.Size(138, 23);
            this.btnListTopWindows.TabIndex = 1;
            this.btnListTopWindows.Text = "Top Windows";
            this.btnListTopWindows.UseVisualStyleBackColor = true;
            this.btnListTopWindows.Click += new System.EventHandler(this.btnListTopWindows_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(12, 41);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(138, 23);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "Maximize";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // listWindows
            // 
            this.listWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listWindows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colHandle,
            this.colWindowClass,
            this.colState,
            this.colPosition,
            this.colScreen,
            this.colVirtualDesktop,
            this.colProcess});
            this.listWindows.Location = new System.Drawing.Point(156, 12);
            this.listWindows.MultiSelect = false;
            this.listWindows.Name = "listWindows";
            this.listWindows.Size = new System.Drawing.Size(1048, 326);
            this.listWindows.TabIndex = 3;
            this.listWindows.UseCompatibleStateImageBehavior = false;
            this.listWindows.View = System.Windows.Forms.View.Details;
            // 
            // colHandle
            // 
            this.colHandle.Text = "HWnd";
            this.colHandle.Width = 80;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 150;
            // 
            // colWindowClass
            // 
            this.colWindowClass.Text = "Window Class";
            this.colWindowClass.Width = 120;
            // 
            // colState
            // 
            this.colState.Text = "State";
            this.colState.Width = 80;
            // 
            // colPosition
            // 
            this.colPosition.Text = "Position";
            this.colPosition.Width = 150;
            // 
            // colScreen
            // 
            this.colScreen.Text = "Screen";
            this.colScreen.Width = 100;
            // 
            // colVirtualDesktop
            // 
            this.colVirtualDesktop.Text = "Virtual Desktop";
            this.colVirtualDesktop.Width = 200;
            // 
            // colProcess
            // 
            this.colProcess.Text = "Process";
            this.colProcess.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 350);
            this.Controls.Add(this.listWindows);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnListTopWindows);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListTopWindows;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.ListView listWindows;
        private System.Windows.Forms.ColumnHeader colHandle;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colWindowClass;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colScreen;
        private System.Windows.Forms.ColumnHeader colVirtualDesktop;
        private System.Windows.Forms.ColumnHeader colProcess;
    }
}

