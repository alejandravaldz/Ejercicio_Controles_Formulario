namespace otro_ejempo_Contoles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bnt_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            lst_Series.Items.Add(txt_Series.Text);
            lbl_Indice.ForeColor = Color.DarkGray;
            string nuevoElemento = txt_Series.Text;
            txt_Series.Text = "";


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Series.SelectedIndex != -1)
            {
                lst_Series.Items.RemoveAt(lst_Series.SelectedIndex);

            }
        }

        private void lst_Series_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Indice.Text = lst_Series.SelectedIndex.ToString();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            lst_Series.Items.Clear();
            lbl_Indice.Text = "";
        }

        private void txt_Series_TextChanged(object sender, EventArgs e)
        {

        }
    }


}