namespace Words_Game
{
    partial class formInicial
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
            btStart = new Button();
            SuspendLayout();
            // 
            // btStart
            // 
            btStart.BackgroundImage = Properties.Resources.btStart;
            btStart.BackgroundImageLayout = ImageLayout.Zoom;
            btStart.Font = new Font("Showcard Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btStart.Location = new Point(12, 670);
            btStart.Name = "btStart";
            btStart.Size = new Size(186, 192);
            btStart.TabIndex = 0;
            btStart.Text = "INICIAR";
            btStart.TextAlign = ContentAlignment.BottomCenter;
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // formInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logotipo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1105, 884);
            Controls.Add(btStart);
            Name = "formInicial";
            Text = "WORDS GAME";
            Load += formInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btStart;
    }
}
