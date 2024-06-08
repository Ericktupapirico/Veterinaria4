namespace Veterinaria4
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
            components = new System.ComponentModel.Container();
            btnGuardarVeterinario = new Button();
            textNombreVeterinario = new TextBox();
            textContraseñaVeterinario = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarVeterinario
            // 
            btnGuardarVeterinario.Location = new Point(351, 294);
            btnGuardarVeterinario.Name = "btnGuardarVeterinario";
            btnGuardarVeterinario.Size = new Size(94, 29);
            btnGuardarVeterinario.TabIndex = 0;
            btnGuardarVeterinario.Text = "Guardar";
            btnGuardarVeterinario.UseVisualStyleBackColor = true;
            btnGuardarVeterinario.Click += button1_Click;
            // 
            // textNombreVeterinario
            // 
            textNombreVeterinario.Location = new Point(333, 228);
            textNombreVeterinario.Name = "textNombreVeterinario";
            textNombreVeterinario.Size = new Size(125, 27);
            textNombreVeterinario.TabIndex = 1;
            textNombreVeterinario.TextChanged += textNombreVeterinario_TextChanged;
            // 
            // textContraseñaVeterinario
            // 
            textContraseñaVeterinario.Location = new Point(333, 261);
            textContraseñaVeterinario.Name = "textContraseñaVeterinario";
            textContraseñaVeterinario.Size = new Size(125, 27);
            textContraseñaVeterinario.TabIndex = 2;
            textContraseñaVeterinario.TextChanged += textBox2_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(251, 231);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 231);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 268);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(textContraseñaVeterinario);
            Controls.Add(textNombreVeterinario);
            Controls.Add(btnGuardarVeterinario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarVeterinario;
        private TextBox textNombreVeterinario;
        private TextBox textContraseñaVeterinario;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
