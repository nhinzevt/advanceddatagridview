
namespace Zuby.ADGV
{
    partial class FormCustomFilter
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
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_columnName = new System.Windows.Forms.Label();
            this.comboBox_filterType = new System.Windows.Forms.ComboBox();
            this.label_and = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(60, 214);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(112, 35);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(182, 214);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(112, 35);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_columnName
            // 
            this.label_columnName.AutoSize = true;
            this.label_columnName.Location = new System.Drawing.Point(6, 14);
            this.label_columnName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_columnName.Name = "label_columnName";
            this.label_columnName.Size = new System.Drawing.Size(174, 20);
            this.label_columnName.TabIndex = 2;
            this.label_columnName.Text = "Show rows where value";
            // 
            // comboBox_filterType
            // 
            this.comboBox_filterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filterType.FormattingEnabled = true;
            this.comboBox_filterType.Location = new System.Drawing.Point(10, 38);
            this.comboBox_filterType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_filterType.Name = "comboBox_filterType";
            this.comboBox_filterType.Size = new System.Drawing.Size(282, 28);
            this.comboBox_filterType.TabIndex = 3;
            this.comboBox_filterType.SelectedIndexChanged += new System.EventHandler(this.comboBox_filterType_SelectedIndexChanged);
            // 
            // label_and
            // 
            this.label_and.AutoSize = true;
            this.label_and.Location = new System.Drawing.Point(10, 137);
            this.label_and.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_and.Name = "label_and";
            this.label_and.Size = new System.Drawing.Size(38, 20);
            this.label_and.TabIndex = 6;
            this.label_and.Text = "And";
            this.label_and.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FormCustomFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(308, 260);
            this.Controls.Add(this.label_and);
            this.Controls.Add(this.label_columnName);
            this.Controls.Add(this.comboBox_filterType);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCustomFilter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Filter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCustomFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_columnName;
        private System.Windows.Forms.ComboBox comboBox_filterType;
        private System.Windows.Forms.Label label_and;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}