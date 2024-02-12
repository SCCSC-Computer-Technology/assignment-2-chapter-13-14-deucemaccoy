
namespace andrew_foster_cpt_236_lab_1
{
    partial class displayForm
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
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.closeButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(20, 21);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(760, 125);
            this.displayBox.TabIndex = 0;
            this.displayBox.Text = "";
            // 
            // closeButt
            // 
            this.closeButt.Location = new System.Drawing.Point(300, 175);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(135, 40);
            this.closeButt.TabIndex = 1;
            this.closeButt.Text = "Close";
            this.closeButt.UseVisualStyleBackColor = true;
            this.closeButt.Click += new System.EventHandler(this.closeButt_Click);
            // 
            // displayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 252);
            this.Controls.Add(this.closeButt);
            this.Controls.Add(this.displayBox);
            this.Name = "displayForm";
            this.Text = "Search Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Button closeButt;
    }
}