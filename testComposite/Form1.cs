using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testComposite.Clases;

namespace testComposite
{
    public partial class Form1 : Form
    {
        List<Componente> carrito = new List<Componente>();
        Producto pc;
       

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Item item1 = new Item("Micro 1", 10000);
            Item item2 = new Item("Micro 2", 15000);
            Item item3 = new Item("Mother 1", 8000);
            Item item4 = new Item("Mother 2", 12000);
            Item item5 = new Item("Memoria 8GB", 7000);
            Item item6 = new Item("Memoria 16GB", 11000);
            Item item7 = new Item("Placa de Video 8GB", 67000);
            Item item8 = new Item("Placa de Video 12GB", 97000);
            listBox1.Items.Add(item1);
            listBox1.Items.Add(item2);
            listBox1.Items.Add(item3);
            listBox1.Items.Add(item4);
            listBox1.Items.Add(item5);
            listBox1.Items.Add(item6);
            listBox1.Items.Add(item7);
            listBox1.Items.Add(item8);
            listBox1.DisplayMember = "Nombre";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carrito.Add(listBox1.SelectedItem as Item);
            ActualizarCarrito();

        }

        public void ActualizarCarrito()
        {
            listBox3.DataSource = null;
            listBox3.DataSource = carrito;
            listBox3.DisplayMember = "Nombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pc.AgregarHijo(listBox1.SelectedItem as Item);
            ActualizarPC();
        }
        public void ActualizarPC()
        {
            listBox2.DataSource = null;
            listBox2.DataSource = pc.Mostrar();
            listBox2.DisplayMember = "Nombre";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pc.QuitarHijo(listBox2.SelectedItem as Item);
            ActualizarPC();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            carrito.Add(pc);
            ActualizarCarrito();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float total = 0;
            foreach (Componente item in carrito)
            {
                total += item.CalcularTotal();
            }
            textBox1.Text = "$" + total.ToString(); ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pc = new Producto(textBox2.Text);
            ActualizarPC();
        }
    }
}
