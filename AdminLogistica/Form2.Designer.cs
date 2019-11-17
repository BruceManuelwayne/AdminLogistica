namespace AdminLogistica
{
    partial class FormLote
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
            this.buttonSelecionarCarpeta = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonUploadLote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelecionarCarpeta
            // 
            this.buttonSelecionarCarpeta.Location = new System.Drawing.Point(27, 29);
            this.buttonSelecionarCarpeta.Name = "buttonSelecionarCarpeta";
            this.buttonSelecionarCarpeta.Size = new System.Drawing.Size(156, 86);
            this.buttonSelecionarCarpeta.TabIndex = 0;
            this.buttonSelecionarCarpeta.Text = "Mostrar Lotes en Carpeta";
            this.buttonSelecionarCarpeta.UseVisualStyleBackColor = true;
            this.buttonSelecionarCarpeta.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(387, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(395, 404);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // buttonUploadLote
            // 
            this.buttonUploadLote.Location = new System.Drawing.Point(27, 153);
            this.buttonUploadLote.Name = "buttonUploadLote";
            this.buttonUploadLote.Size = new System.Drawing.Size(156, 86);
            this.buttonUploadLote.TabIndex = 2;
            this.buttonUploadLote.Text = "Ingresar Arvicho Lote";
            this.buttonUploadLote.UseVisualStyleBackColor = true;
            // 
            // FormLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUploadLote);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSelecionarCarpeta);
            this.Name = "FormLote";
            this.Text = "FormLote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelecionarCarpeta;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonUploadLote;
    }
}