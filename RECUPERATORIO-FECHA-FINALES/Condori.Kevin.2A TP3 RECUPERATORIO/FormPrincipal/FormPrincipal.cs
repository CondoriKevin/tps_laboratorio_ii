using Entidades;
using Entidades.Enumerados;
using Serializable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FormPrincipal : Form
    {
        Stock stock;
        private int indice;
        List<Tela> listaFiltro;
        Mensaje miMensaje;
        List<Mensaje> listaMensajes;
        /// <summary>
        /// Constructor del FrmPrincipal
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
            stock = new Stock("Lista de telas");
            listaFiltro = new List<Tela>();
            listaMensajes = new List<Mensaje>();
            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Nacional nacional = new Nacional(EMaquina.AMano, "Nacional", "Javier", 1000, ECalidadTela.Excelente);
            Nacional nacionalIgual = new Nacional(EMaquina.AMano, "Nacional", "Javier", 1000, ECalidadTela.Excelente);
            Importada importada = new Importada(EMaquina.Cortadora, "Importada", "Lucas", 333, ECalidadTela.Excelente);
            Nacional nacionalMismosDatosImportada = new Nacional(EMaquina.Cortadora, "Nacional", "Lucas", 333, ECalidadTela.Excelente);
            Importada importadaIgual = new Importada(EMaquina.Cortadora, "Importada", "Lucas", 333, ECalidadTela.Excelente);
            Importada importadaOtro = new Importada(EMaquina.Estampado, "Importada", "Javier", 222, ECalidadTela.Malo);
            stock = stock + nacional;
            stock = stock + nacionalIgual;   //NO SE DEBERIA SUMAR
            stock = stock + nacionalMismosDatosImportada; //con diferente tipo de dato 
            stock = stock + importada;
            stock = stock + importadaIgual; //NO SE DEBERIA SUMAR
            stock = stock + importadaOtro;

            this.cmbMaquina.DataSource = Enum.GetNames(typeof(EMaquina));
            this.cmbTela.DataSource = Enum.GetNames(typeof(ETipoTela));
            this.cmbCalidadTela.DataSource = Enum.GetNames(typeof(ECalidadTela));
            //this.dtgvView.DataSource = stock.ListaDeMateriales;
            AgregarData(stock.ListaDeTelas);
            Limpiar();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CorroborarDatos())
            {
                //Obtengo el indice de la nueva linea creada
                int indice = this.dtgvView.Rows.Add();
                //agrego informacion en el dataGrid
                this.dtgvView.Rows[indice].Cells[0].Value = this.cmbMaquina.Text;
                this.dtgvView.Rows[indice].Cells[1].Value = this.cmbTela.Text;
                this.dtgvView.Rows[indice].Cells[2].Value = this.txtCliente.Text;
                this.dtgvView.Rows[indice].Cells[3].Value = this.txtCantidad.Text;
                this.dtgvView.Rows[indice].Cells[4].Value = this.cmbCalidadTela.Text;
                miMensaje = new Mensaje(this.cmbMaquina.Text,
                                        this.cmbTela.Text,
                                        this.txtCliente.Text,
                                        this.txtCantidad.Text,
                                        this.cmbCalidadTela.Text);
                MensajeCargado.Mensaje = miMensaje;
                listaMensajes = listaMensajes + miMensaje;
                //miMensaje.GuardarTxt();
                //miMensaje.GuardarXml();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Completar datos para continuar",
                                "Rellenar datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Agrega informacion por defecto al DataGrid cuando se inicia el programa
        /// </summary>
        /// <param name="lista"></param>
        private void AgregarData(List<Tela> lista)
        {
            this.dtgvView.DataSource = null;
            foreach (var item in lista)
            {
                indice = this.dtgvView.Rows.Add();
                this.dtgvView.Rows[indice].Cells[0].Value = item.Maquina;
                this.dtgvView.Rows[indice].Cells[1].Value = item.GetType().Name;
                this.dtgvView.Rows[indice].Cells[3].Value = item.Cantidad;
                this.dtgvView.Rows[indice].Cells[4].Value = item.CalidadTela;
                if (item is Nacional)
                {
                    this.dtgvView.Rows[indice].Cells[2].Value = ((Nacional)item).Cliente;
                }
                else if (item is Importada)
                {
                    this.dtgvView.Rows[indice].Cells[2].Value = ((Importada)item).Cliente;
                }
                miMensaje = new Mensaje(item.Maquina.ToString(),
                                        item.GetType().Name,
                                        item.Cliente,
                                        item.Cantidad.ToString(),
                                        item.CalidadTela.ToString());
                MensajeCargado.Mensaje = miMensaje;
                listaMensajes = listaMensajes + miMensaje;
            }
        }

        /// <summary>
        /// Establece los campos del formulario en vacios
        /// </summary>
        private void Limpiar()
        {
            this.cmbMaquina.SelectedIndex = -1;
            this.cmbTela.SelectedIndex = -1;
            this.txtCliente.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.cmbCalidadTela.SelectedIndex = -1;
        }

        /// <summary>
        /// Identifica el indice de Fila seleccionado por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        /// <summary>
        /// Elimina del DataGrid la fila seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (indice != -1)
                {
                    dtgvView.Rows.RemoveAt(indice);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Seleccione la fila para eliminar el trabajo",
                                "Warning!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Corrobora que todos los campos a llenar no esten vacios al momento de proseguir con la accion
        /// </summary>
        /// <returns></returns>
        private bool CorroborarDatos()
        {
            bool retorno = false;
            if (this.cmbMaquina.Text != string.Empty &&
                this.cmbTela.Text != string.Empty &&
                this.txtCliente.Text != string.Empty &&
                this.txtCantidad.Text != string.Empty &&
                this.cmbCalidadTela.Text != string.Empty)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Filtra la lista de elementos del DataGrid segun el proceso del material
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="proceso"></param>
        private void FiltrarDataGrid(DataGridView dataGridView, EMaquina maquina)
        {
            listaFiltro = stock.FiltrarLista(stock.ListaDeTelas, maquina);
            if (listaFiltro.Count > 0)
            {
                AgregarData(listaFiltro);
            }
        }

        /// <summary>
        /// Permite Editar una fila del DataGrid, al seleccionar la fila, esta sera eliminada y los valores retornaran a los campos a completar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (indice != -1)
                {
                    this.cmbMaquina.Text = (string)this.dtgvView.Rows[indice].Cells[0].Value;
                    this.cmbTela.Text = (string)this.dtgvView.Rows[indice].Cells[1].Value;
                    this.txtCliente.Text = (string)this.dtgvView.Rows[indice].Cells[2].Value;
                    this.txtCantidad.Text = (string)this.dtgvView.Rows[indice].Cells[3].Value;
                    this.cmbCalidadTela.Text = (string)this.dtgvView.Rows[indice].Cells[4].Value;
                    btnEliminar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciones el Trabajo para Editar",
                "Warning!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Condiciona que solo se puedan ingresar numeros
        /// </summary>
        /// <param name="pE"></param>
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        /// <summary>
        /// Permite solo ingresar numeros 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        /// <summary>
        /// Se crean los archivos xml y txt de los trabajos cargados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El archivo txt y xml se ha creado corretamente", "Archivos GENERADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Mensaje item in listaMensajes)
            {
                item.GuardarTxt();
                item.GuardarXml();
            }
        }










        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
