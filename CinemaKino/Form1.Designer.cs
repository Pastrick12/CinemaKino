namespace CinemaKino
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
            button1 = new Button();
            button2 = new Button();
            btnJson = new Button();
            btnXml = new Button();
            btnMigrar = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(233, 142);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(79, 20);
            button1.TabIndex = 0;
            button1.Text = "Tab";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(233, 177);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 1;
            button2.Text = "busqueda";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnJson
            // 
            btnJson.Location = new Point(236, 50);
            btnJson.Name = "btnJson";
            btnJson.Size = new Size(75, 23);
            btnJson.TabIndex = 2;
            btnJson.Text = "Json";
            btnJson.UseVisualStyleBackColor = true;
            btnJson.Click += btnJson_Click;
            // 
            // btnXml
            // 
            btnXml.Location = new Point(233, 204);
            btnXml.Name = "btnXml";
            btnXml.Size = new Size(75, 23);
            btnXml.TabIndex = 3;
            btnXml.Text = "XML";
            btnXml.UseVisualStyleBackColor = true;
            btnXml.Click += btnXml_Click;
            // 
            // btnMigrar
            // 
            btnMigrar.Location = new Point(236, 12);
            btnMigrar.Name = "btnMigrar";
            btnMigrar.Size = new Size(75, 23);
            btnMigrar.TabIndex = 4;
            btnMigrar.Text = "Migrar";
            btnMigrar.UseVisualStyleBackColor = true;
            btnMigrar.Click += btnMigrar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(233, 96);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Csv";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button3);
            Controls.Add(btnMigrar);
            Controls.Add(btnXml);
            Controls.Add(btnJson);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnJson;
        private Button btnXml;
        private Button btnMigrar;
        private Button button3;
    }
}
