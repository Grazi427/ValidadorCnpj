namespace ValidadorCnpj
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
            mtbCnpj = new MaskedTextBox();
            btnValidaCnpj = new Button();
            SuspendLayout();
            // 
            // mtbCnpj
            // 
            mtbCnpj.Location = new Point(324, 116);
            mtbCnpj.Mask = "00.000.000/0000-00";
            mtbCnpj.Name = "mtbCnpj";
            mtbCnpj.Size = new Size(121, 23);
            mtbCnpj.TabIndex = 0;
            mtbCnpj.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // btnValidaCnpj
            // 
            btnValidaCnpj.Location = new Point(358, 168);
            btnValidaCnpj.Name = "btnValidaCnpj";
            btnValidaCnpj.Size = new Size(75, 23);
            btnValidaCnpj.TabIndex = 1;
            btnValidaCnpj.Text = "validar";
            btnValidaCnpj.UseVisualStyleBackColor = true;
            btnValidaCnpj.Click += btnValidaCnpj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidaCnpj);
            Controls.Add(mtbCnpj);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbCnpj;
        private Button btnValidaCnpj;
    }
}
