namespace Atividade_Pratica_AP1
{
    partial class AP1
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
            btnAP1 = new Button();
            btnAP2 = new Button();
            SuspendLayout();
            // 
            // btnAP1
            // 
            btnAP1.Location = new Point(39, 94);
            btnAP1.Name = "btnAP1";
            btnAP1.Size = new Size(196, 66);
            btnAP1.TabIndex = 0;
            btnAP1.Text = "AP1";
            btnAP1.UseVisualStyleBackColor = true;
            btnAP1.Click += btnAP1_Click;
            // 
            // btnAP2
            // 
            btnAP2.Location = new Point(293, 94);
            btnAP2.Name = "btnAP2";
            btnAP2.Size = new Size(196, 66);
            btnAP2.TabIndex = 1;
            btnAP2.Text = "AP2";
            btnAP2.UseVisualStyleBackColor = true;
            // 
            // AP1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 305);
            Controls.Add(btnAP2);
            Controls.Add(btnAP1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AP1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atividades";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAP1;
        private Button btnAP2;
    }
}
