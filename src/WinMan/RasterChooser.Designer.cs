namespace Mastersign.WinMan.Gui
{
    partial class RasterChooser
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblX;
            System.Windows.Forms.Label lblY;
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.chkEven12Y = new System.Windows.Forms.CheckBox();
            this.chkEven12X = new System.Windows.Forms.CheckBox();
            this.chkEven10Y = new System.Windows.Forms.CheckBox();
            this.chkEven10X = new System.Windows.Forms.CheckBox();
            this.chkEven8Y = new System.Windows.Forms.CheckBox();
            this.chkEven8X = new System.Windows.Forms.CheckBox();
            this.chkEven7Y = new System.Windows.Forms.CheckBox();
            this.chkEven7X = new System.Windows.Forms.CheckBox();
            this.chkEven6Y = new System.Windows.Forms.CheckBox();
            this.chkEven6X = new System.Windows.Forms.CheckBox();
            this.chkEven5Y = new System.Windows.Forms.CheckBox();
            this.chkEven5X = new System.Windows.Forms.CheckBox();
            this.chkEven4Y = new System.Windows.Forms.CheckBox();
            this.chkEven4X = new System.Windows.Forms.CheckBox();
            this.chkGoldenY = new System.Windows.Forms.CheckBox();
            this.chkGoldenX = new System.Windows.Forms.CheckBox();
            lblX = new System.Windows.Forms.Label();
            lblY = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Dock = System.Windows.Forms.DockStyle.Fill;
            lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblX.Location = new System.Drawing.Point(6, 6);
            lblX.Margin = new System.Windows.Forms.Padding(3);
            lblX.Name = "lblX";
            lblX.Size = new System.Drawing.Size(66, 13);
            lblX.TabIndex = 1;
            lblX.Text = "H";
            lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Dock = System.Windows.Forms.DockStyle.Fill;
            lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblY.Location = new System.Drawing.Point(78, 6);
            lblY.Margin = new System.Windows.Forms.Padding(3);
            lblY.Name = "lblY";
            lblY.Size = new System.Drawing.Size(67, 13);
            lblY.TabIndex = 2;
            lblY.Text = "V";
            lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.chkEven12Y, 1, 8);
            this.tableLayout.Controls.Add(this.chkEven12X, 0, 8);
            this.tableLayout.Controls.Add(this.chkEven10Y, 1, 7);
            this.tableLayout.Controls.Add(this.chkEven10X, 0, 7);
            this.tableLayout.Controls.Add(this.chkEven8Y, 1, 6);
            this.tableLayout.Controls.Add(this.chkEven8X, 0, 6);
            this.tableLayout.Controls.Add(this.chkEven7Y, 1, 5);
            this.tableLayout.Controls.Add(this.chkEven7X, 0, 5);
            this.tableLayout.Controls.Add(this.chkEven6Y, 1, 4);
            this.tableLayout.Controls.Add(this.chkEven6X, 0, 4);
            this.tableLayout.Controls.Add(this.chkEven5Y, 1, 3);
            this.tableLayout.Controls.Add(this.chkEven5X, 0, 3);
            this.tableLayout.Controls.Add(this.chkEven4Y, 1, 2);
            this.tableLayout.Controls.Add(this.chkEven4X, 0, 2);
            this.tableLayout.Controls.Add(this.chkGoldenY, 1, 1);
            this.tableLayout.Controls.Add(lblY, 1, 0);
            this.tableLayout.Controls.Add(this.chkGoldenX, 0, 1);
            this.tableLayout.Controls.Add(lblX, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayoutPanel1";
            this.tableLayout.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayout.RowCount = 10;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(151, 312);
            this.tableLayout.TabIndex = 0;
            // 
            // chkEven12Y
            // 
            this.chkEven12Y.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven12Y.AutoSize = true;
            this.chkEven12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven12Y.Location = new System.Drawing.Point(75, 183);
            this.chkEven12Y.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven12Y.Name = "chkEven12Y";
            this.chkEven12Y.Size = new System.Drawing.Size(73, 23);
            this.chkEven12Y.TabIndex = 17;
            this.chkEven12Y.Tag = "Even12";
            this.chkEven12Y.Text = "12";
            this.chkEven12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven12Y.UseVisualStyleBackColor = true;
            this.chkEven12Y.CheckedChanged += new System.EventHandler(this.CheckBoxYHandler);
            // 
            // chkEven12X
            // 
            this.chkEven12X.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven12X.AutoSize = true;
            this.chkEven12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven12X.Location = new System.Drawing.Point(3, 183);
            this.chkEven12X.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven12X.Name = "chkEven12X";
            this.chkEven12X.Size = new System.Drawing.Size(72, 23);
            this.chkEven12X.TabIndex = 16;
            this.chkEven12X.Tag = "Even12";
            this.chkEven12X.Text = "12";
            this.chkEven12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven12X.UseVisualStyleBackColor = true;
            this.chkEven12X.CheckedChanged += new System.EventHandler(this.CheckBoxXHandler);
            // 
            // chkEven10Y
            // 
            this.chkEven10Y.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven10Y.AutoSize = true;
            this.chkEven10Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven10Y.Location = new System.Drawing.Point(75, 160);
            this.chkEven10Y.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven10Y.Name = "chkEven10Y";
            this.chkEven10Y.Size = new System.Drawing.Size(73, 23);
            this.chkEven10Y.TabIndex = 15;
            this.chkEven10Y.Tag = "Even10";
            this.chkEven10Y.Text = "10";
            this.chkEven10Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven10Y.UseVisualStyleBackColor = true;
            this.chkEven10Y.CheckedChanged += new System.EventHandler(this.CheckBoxYHandler);
            // 
            // chkEven10X
            // 
            this.chkEven10X.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven10X.AutoSize = true;
            this.chkEven10X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven10X.Location = new System.Drawing.Point(3, 160);
            this.chkEven10X.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven10X.Name = "chkEven10X";
            this.chkEven10X.Size = new System.Drawing.Size(72, 23);
            this.chkEven10X.TabIndex = 14;
            this.chkEven10X.Tag = "Even10";
            this.chkEven10X.Text = "10";
            this.chkEven10X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven10X.UseVisualStyleBackColor = true;
            this.chkEven10X.CheckedChanged += new System.EventHandler(this.CheckBoxXHandler);
            // 
            // chkEven8Y
            // 
            this.chkEven8Y.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven8Y.AutoSize = true;
            this.chkEven8Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven8Y.Location = new System.Drawing.Point(75, 137);
            this.chkEven8Y.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven8Y.Name = "chkEven8Y";
            this.chkEven8Y.Size = new System.Drawing.Size(73, 23);
            this.chkEven8Y.TabIndex = 13;
            this.chkEven8Y.Tag = "Even8";
            this.chkEven8Y.Text = "8";
            this.chkEven8Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven8Y.UseVisualStyleBackColor = true;
            this.chkEven8Y.CheckedChanged += new System.EventHandler(this.CheckBoxYHandler);
            // 
            // chkEven8X
            // 
            this.chkEven8X.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven8X.AutoSize = true;
            this.chkEven8X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven8X.Location = new System.Drawing.Point(3, 137);
            this.chkEven8X.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven8X.Name = "chkEven8X";
            this.chkEven8X.Size = new System.Drawing.Size(72, 23);
            this.chkEven8X.TabIndex = 12;
            this.chkEven8X.Tag = "Even8";
            this.chkEven8X.Text = "8";
            this.chkEven8X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven8X.UseVisualStyleBackColor = true;
            this.chkEven8X.CheckedChanged += new System.EventHandler(this.CheckBoxXHandler);
            // 
            // chkEven7Y
            // 
            this.chkEven7Y.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven7Y.AutoSize = true;
            this.chkEven7Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven7Y.Location = new System.Drawing.Point(75, 114);
            this.chkEven7Y.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven7Y.Name = "chkEven7Y";
            this.chkEven7Y.Size = new System.Drawing.Size(73, 23);
            this.chkEven7Y.TabIndex = 11;
            this.chkEven7Y.Tag = "Even7";
            this.chkEven7Y.Text = "7";
            this.chkEven7Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven7Y.UseVisualStyleBackColor = true;
            this.chkEven7Y.CheckedChanged += new System.EventHandler(this.CheckBoxYHandler);
            // 
            // chkEven7X
            // 
            this.chkEven7X.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven7X.AutoSize = true;
            this.chkEven7X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven7X.Location = new System.Drawing.Point(3, 114);
            this.chkEven7X.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven7X.Name = "chkEven7X";
            this.chkEven7X.Size = new System.Drawing.Size(72, 23);
            this.chkEven7X.TabIndex = 10;
            this.chkEven7X.Tag = "Even7";
            this.chkEven7X.Text = "7";
            this.chkEven7X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven7X.UseVisualStyleBackColor = true;
            this.chkEven7X.CheckedChanged += new System.EventHandler(this.CheckBoxXHandler);
            // 
            // chkEven6Y
            // 
            this.chkEven6Y.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven6Y.AutoSize = true;
            this.chkEven6Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven6Y.Location = new System.Drawing.Point(75, 91);
            this.chkEven6Y.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven6Y.Name = "chkEven6Y";
            this.chkEven6Y.Size = new System.Drawing.Size(73, 23);
            this.chkEven6Y.TabIndex = 9;
            this.chkEven6Y.Tag = "Even6";
            this.chkEven6Y.Text = "6";
            this.chkEven6Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven6Y.UseVisualStyleBackColor = true;
            this.chkEven6Y.CheckedChanged += new System.EventHandler(this.CheckBoxYHandler);
            // 
            // chkEven6X
            // 
            this.chkEven6X.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven6X.AutoSize = true;
            this.chkEven6X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven6X.Location = new System.Drawing.Point(3, 91);
            this.chkEven6X.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven6X.Name = "chkEven6X";
            this.chkEven6X.Size = new System.Drawing.Size(72, 23);
            this.chkEven6X.TabIndex = 8;
            this.chkEven6X.Tag = "Even6";
            this.chkEven6X.Text = "6";
            this.chkEven6X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven6X.UseVisualStyleBackColor = true;
            this.chkEven6X.CheckedChanged += new System.EventHandler(this.CheckBoxXHandler);
            // 
            // chkEven5Y
            // 
            this.chkEven5Y.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven5Y.AutoSize = true;
            this.chkEven5Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven5Y.Location = new System.Drawing.Point(75, 68);
            this.chkEven5Y.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven5Y.Name = "chkEven5Y";
            this.chkEven5Y.Size = new System.Drawing.Size(73, 23);
            this.chkEven5Y.TabIndex = 7;
            this.chkEven5Y.Tag = "Even5";
            this.chkEven5Y.Text = "5";
            this.chkEven5Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven5Y.UseVisualStyleBackColor = true;
            this.chkEven5Y.CheckedChanged += new System.EventHandler(this.CheckBoxYHandler);
            // 
            // chkEven5X
            // 
            this.chkEven5X.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven5X.AutoSize = true;
            this.chkEven5X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven5X.Location = new System.Drawing.Point(3, 68);
            this.chkEven5X.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven5X.Name = "chkEven5X";
            this.chkEven5X.Size = new System.Drawing.Size(72, 23);
            this.chkEven5X.TabIndex = 6;
            this.chkEven5X.Tag = "Even5";
            this.chkEven5X.Text = "5";
            this.chkEven5X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven5X.UseVisualStyleBackColor = true;
            this.chkEven5X.CheckedChanged += new System.EventHandler(this.CheckBoxXHandler);
            // 
            // chkEven4Y
            // 
            this.chkEven4Y.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven4Y.AutoSize = true;
            this.chkEven4Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven4Y.Location = new System.Drawing.Point(75, 45);
            this.chkEven4Y.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven4Y.Name = "chkEven4Y";
            this.chkEven4Y.Size = new System.Drawing.Size(73, 23);
            this.chkEven4Y.TabIndex = 5;
            this.chkEven4Y.Tag = "Even4";
            this.chkEven4Y.Text = "4";
            this.chkEven4Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven4Y.UseVisualStyleBackColor = true;
            this.chkEven4Y.CheckedChanged += new System.EventHandler(this.CheckBoxYHandler);
            // 
            // chkEven4X
            // 
            this.chkEven4X.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEven4X.AutoSize = true;
            this.chkEven4X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEven4X.Location = new System.Drawing.Point(3, 45);
            this.chkEven4X.Margin = new System.Windows.Forms.Padding(0);
            this.chkEven4X.Name = "chkEven4X";
            this.chkEven4X.Size = new System.Drawing.Size(72, 23);
            this.chkEven4X.TabIndex = 4;
            this.chkEven4X.Tag = "Even4";
            this.chkEven4X.Text = "4";
            this.chkEven4X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEven4X.UseVisualStyleBackColor = true;
            this.chkEven4X.CheckedChanged += new System.EventHandler(this.CheckBoxXHandler);
            // 
            // chkGoldenY
            // 
            this.chkGoldenY.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGoldenY.AutoSize = true;
            this.chkGoldenY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkGoldenY.Location = new System.Drawing.Point(75, 22);
            this.chkGoldenY.Margin = new System.Windows.Forms.Padding(0);
            this.chkGoldenY.Name = "chkGoldenY";
            this.chkGoldenY.Size = new System.Drawing.Size(73, 23);
            this.chkGoldenY.TabIndex = 3;
            this.chkGoldenY.Tag = "Golden";
            this.chkGoldenY.Text = "GR";
            this.chkGoldenY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGoldenY.UseVisualStyleBackColor = true;
            this.chkGoldenY.CheckedChanged += new System.EventHandler(this.CheckBoxYHandler);
            // 
            // chkGoldenX
            // 
            this.chkGoldenX.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGoldenX.AutoSize = true;
            this.chkGoldenX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkGoldenX.Location = new System.Drawing.Point(3, 22);
            this.chkGoldenX.Margin = new System.Windows.Forms.Padding(0);
            this.chkGoldenX.Name = "chkGoldenX";
            this.chkGoldenX.Size = new System.Drawing.Size(72, 23);
            this.chkGoldenX.TabIndex = 0;
            this.chkGoldenX.Tag = "Golden";
            this.chkGoldenX.Text = "GR";
            this.chkGoldenX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGoldenX.UseVisualStyleBackColor = true;
            this.chkGoldenX.CheckedChanged += new System.EventHandler(this.CheckBoxXHandler);
            // 
            // RasterChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout);
            this.Name = "RasterChooser";
            this.Size = new System.Drawing.Size(151, 312);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.CheckBox chkGoldenX;
        private System.Windows.Forms.CheckBox chkEven12Y;
        private System.Windows.Forms.CheckBox chkEven12X;
        private System.Windows.Forms.CheckBox chkEven10Y;
        private System.Windows.Forms.CheckBox chkEven10X;
        private System.Windows.Forms.CheckBox chkEven8Y;
        private System.Windows.Forms.CheckBox chkEven8X;
        private System.Windows.Forms.CheckBox chkEven7Y;
        private System.Windows.Forms.CheckBox chkEven7X;
        private System.Windows.Forms.CheckBox chkEven6Y;
        private System.Windows.Forms.CheckBox chkEven6X;
        private System.Windows.Forms.CheckBox chkEven5Y;
        private System.Windows.Forms.CheckBox chkEven5X;
        private System.Windows.Forms.CheckBox chkEven4Y;
        private System.Windows.Forms.CheckBox chkEven4X;
        private System.Windows.Forms.CheckBox chkGoldenY;
    }
}
