
namespace Lab3
{
    partial class NoteForm
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
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnSaveAs = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(187, 368);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "Öppna";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnSaveAs
            // 
            this.BtnSaveAs.Location = new System.Drawing.Point(345, 368);
            this.BtnSaveAs.Name = "BtnSaveAs";
            this.BtnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveAs.TabIndex = 1;
            this.BtnSaveAs.Text = "Spara som..";
            this.BtnSaveAs.UseVisualStyleBackColor = true;
            this.BtnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 70);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(408, 292);
            this.TextBox.TabIndex = 2;
            this.TextBox.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the text which you would like to save below";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(268, 368);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 398);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.BtnSaveAs);
            this.Controls.Add(this.BtnOpen);
            this.Name = "NoteForm";
            this.Text = "namnlös.txt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnSaveAs;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
    }
}

