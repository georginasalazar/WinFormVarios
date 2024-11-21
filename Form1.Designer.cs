namespace WinFormsVariosForms
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
            buttonForm1 = new Button();
            buttonForm2 = new Button();
            labelTituloPrincipal = new Label();
            printDialog1 = new PrintDialog();
            textBoxDato = new TextBox();
            SuspendLayout();
            // 
            // buttonForm1
            // 
            buttonForm1.AutoSize = true;
            buttonForm1.Location = new Point(178, 202);
            buttonForm1.Name = "buttonForm1";
            buttonForm1.Size = new Size(176, 70);
            buttonForm1.TabIndex = 0;
            buttonForm1.Text = "formulario1";
            buttonForm1.UseVisualStyleBackColor = true;
            buttonForm1.Click += buttonForm1_Click;
            // 
            // buttonForm2
            // 
            buttonForm2.AccessibleRole = AccessibleRole.MenuBar;
            buttonForm2.AutoSize = true;
            buttonForm2.Location = new Point(385, 202);
            buttonForm2.Name = "buttonForm2";
            buttonForm2.Size = new Size(176, 70);
            buttonForm2.TabIndex = 1;
            buttonForm2.Text = "formulario2";
            buttonForm2.UseVisualStyleBackColor = true;
            // 
            // labelTituloPrincipal
            // 
            labelTituloPrincipal.AutoSize = true;
            labelTituloPrincipal.BackColor = Color.Transparent;
            labelTituloPrincipal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTituloPrincipal.Location = new Point(271, 107);
            labelTituloPrincipal.Name = "labelTituloPrincipal";
            labelTituloPrincipal.Size = new Size(201, 38);
            labelTituloPrincipal.TabIndex = 2;
            labelTituloPrincipal.Text = "Titulo Principal";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // textBoxDato
            // 
            textBoxDato.Location = new Point(274, 308);
            textBoxDato.Name = "textBoxDato";
            textBoxDato.PlaceholderText = "nombre";
            textBoxDato.Size = new Size(201, 27);
            textBoxDato.TabIndex = 3;
            textBoxDato.Text = " ";
            textBoxDato.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDato);
            Controls.Add(labelTituloPrincipal);
            Controls.Add(buttonForm2);
            Controls.Add(buttonForm1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonForm1;
        private Button buttonForm2;
        private Label labelTituloPrincipal;
        private PrintDialog printDialog1;
        private TextBox textBoxDato;
    }
}
