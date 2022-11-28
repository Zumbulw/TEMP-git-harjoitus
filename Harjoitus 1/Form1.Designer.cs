namespace Harjoitus_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOtsikko = new System.Windows.Forms.Label();
            this.btnVaihdaTeksti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOtsikko
            // 
            this.lblOtsikko.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtsikko.Location = new System.Drawing.Point(12, 26);
            this.lblOtsikko.Name = "lblOtsikko";
            this.lblOtsikko.Size = new System.Drawing.Size(450, 31);
            this.lblOtsikko.TabIndex = 0;
            this.lblOtsikko.Text = "Otsikko";
            this.lblOtsikko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVaihdaTeksti
            // 
            this.btnVaihdaTeksti.Location = new System.Drawing.Point(164, 91);
            this.btnVaihdaTeksti.Name = "btnVaihdaTeksti";
            this.btnVaihdaTeksti.Size = new System.Drawing.Size(144, 29);
            this.btnVaihdaTeksti.TabIndex = 1;
            this.btnVaihdaTeksti.Text = "Vaihda teksti";
            this.btnVaihdaTeksti.UseVisualStyleBackColor = true;
            this.btnVaihdaTeksti.Click += new System.EventHandler(this.vaihdaTeksti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 157);
            this.Controls.Add(this.btnVaihdaTeksti);
            this.Controls.Add(this.lblOtsikko);
            this.Name = "Form1";
            this.Text = "Harjoitus 1 - Aleksander Tsapul";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblOtsikko;
        private Button btnVaihdaTeksti;
    }
}