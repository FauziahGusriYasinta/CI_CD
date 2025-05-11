namespace Uas.View
{
    partial class TransaksiForm
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
            this.listTransaksi = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listTransaksi
            // 
            this.listTransaksi.HideSelection = false;
            this.listTransaksi.Location = new System.Drawing.Point(12, 60);
            this.listTransaksi.Name = "listTransaksi";
            this.listTransaksi.Size = new System.Drawing.Size(1191, 518);
            this.listTransaksi.TabIndex = 18;
            this.listTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // TransaksiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 590);
            this.Controls.Add(this.listTransaksi);
            this.Name = "TransaksiForm";
            this.Text = "TransaksiFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listTransaksi;
    }
}