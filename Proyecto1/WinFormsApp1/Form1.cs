namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int rowIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (1 < 0)
            {

            }
            int n = dgvEmpleados.Rows.Add();
            //usando el indice agregamos informacion
            dgvEmpleados.Rows[n].Cells[0].Value = txtNombre.Text;
            dgvEmpleados.Rows[n].Cells[1].Value = txtApellido.Text;
            dgvEmpleados.Rows[n].Cells[2].Value = txtEdad.Text;

            //clear inputs
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            index.Text = (rowIndex + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.RemoveAt(rowIndex);
        }
    }
    }

}