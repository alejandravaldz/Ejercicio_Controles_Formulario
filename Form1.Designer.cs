namespace otro_ejempo_Contoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bnt_Salir = new Button();
            btn_Agregar = new Button();
            lst_Series = new ListBox();
            txt_Series = new TextBox();
            label1 = new Label();
            lbl_Indice = new Label();
            btn_Limpiar = new Button();
            btn_Eliminar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // bnt_Salir
            // 
            bnt_Salir.BackColor = Color.BurlyWood;
            bnt_Salir.ForeColor = SystemColors.ActiveCaptionText;
            bnt_Salir.Location = new Point(661, 436);
            bnt_Salir.Name = "bnt_Salir";
            bnt_Salir.Size = new Size(105, 45);
            bnt_Salir.TabIndex = 0;
            bnt_Salir.Text = "Salir";
            bnt_Salir.UseVisualStyleBackColor = false;
            bnt_Salir.Click += bnt_Salir_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.BurlyWood;
            btn_Agregar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Agregar.Location = new Point(296, 440);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(105, 44);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // lst_Series
            // 
            lst_Series.BackColor = Color.White;
            lst_Series.ForeColor = SystemColors.InactiveCaptionText;
            lst_Series.FormattingEnabled = true;
            lst_Series.ItemHeight = 20;
            lst_Series.Location = new Point(267, 174);
            lst_Series.Name = "lst_Series";
            lst_Series.Size = new Size(344, 204);
            lst_Series.TabIndex = 2;
            lst_Series.SelectedIndexChanged += lst_Series_SelectedIndexChanged;
            // 
            // txt_Series
            // 
            txt_Series.BackColor = Color.White;
            txt_Series.ForeColor = SystemColors.InactiveCaptionText;
            txt_Series.Location = new Point(648, 174);
            txt_Series.Name = "txt_Series";
            txt_Series.Size = new Size(184, 27);
            txt_Series.TabIndex = 3;
            txt_Series.TextChanged += txt_Series_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(139, 250);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 4;
            label1.Text = "Series";
            // 
            // lbl_Indice
            // 
            lbl_Indice.AutoSize = true;
            lbl_Indice.BackColor = Color.White;
            lbl_Indice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Indice.ForeColor = SystemColors.InactiveCaptionText;
            lbl_Indice.Location = new Point(671, 241);
            lbl_Indice.Name = "lbl_Indice";
            lbl_Indice.Size = new Size(63, 25);
            lbl_Indice.TabIndex = 5;
            lbl_Indice.Text = "label2";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.BurlyWood;
            btn_Limpiar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Limpiar.Location = new Point(413, 440);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(100, 44);
            btn_Limpiar.TabIndex = 6;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.BurlyWood;
            btn_Eliminar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Eliminar.Location = new Point(534, 436);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(105, 48);
            btn_Eliminar.TabIndex = 7;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MintCream;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(246, 29);
            label2.Name = "label2";
            label2.Size = new Size(471, 39);
            label2.TabIndex = 8;
            label2.Text = "Escriba su lista de series favoritas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 508);
            Controls.Add(label2);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Limpiar);
            Controls.Add(lbl_Indice);
            Controls.Add(label1);
            Controls.Add(txt_Series);
            Controls.Add(lst_Series);
            Controls.Add(btn_Agregar);
            Controls.Add(bnt_Salir);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bnt_Salir;
        private Button btn_Agregar;
        private ListBox lst_Series;
        private TextBox txt_Series;
        private Label label1;
        private Label lbl_Indice;
        private Button btn_Limpiar;
        private Button btn_Eliminar;
        private Label label2;
    }
}