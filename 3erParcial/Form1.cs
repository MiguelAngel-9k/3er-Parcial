using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3erParcial
{
    public partial class Form1 : Form
    {
        List<city> cities_list;
        bool delete_column = false;

        public Form1()
        {
            InitializeComponent();
            EnlaceCassandra addCities = new EnlaceCassandra();
            cities_list = addCities.Get_Cities_by_id();    
            
            for(int i = 0; cities_list.Count>i;i++)
            {
                elegir_ciudad.Items.Add(cities_list[i].id.ToString());
            }

            dato_especifico.Items.Add("Alcalde");
            dato_especifico.Items.Add("Poblacion");
            dato_especifico.Items.Add("Numero Hospitales");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void agregar_caracteristica_Click(object sender, EventArgs e)
        {
            string buffer = txtCaracteristica.Text;
            caracteristicas.Items.Add(buffer);
        }

        private void caracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregar_registro_Click(object sender, EventArgs e)
        {
            city data = new city();

            if (ciudad.Text == "" && data.capital ==null)
            {
                MessageBox.Show("FALTA No.Ciudad o Centro", "INCORRECTO");
                return;
            }

            data.id = Int32.Parse(ciudad.Text);
            data.capital = capital.Text.ToString();
            if(textBox2.Text!="")
                data.hostpital_quantity = Int32.Parse(textBox2.Text);
            data.mayor = alcalde.Text;
            if (textBox2.Text != "")
                data.population = Int32.Parse(poblacion.Text);

            int index = 0;
            data.characteritics = new List<string>();
            while (index < caracteristicas.Items.Count)
            {
                caracteristicas.SelectedItem = index;
                data.characteritics.Add(caracteristicas.Items[index].ToString());
                index++;
            }
       

            EnlaceCassandra node = new EnlaceCassandra();
            node.insertData(data);
            index = caracteristicas.Items.Count;
            while(index>=0)
            {
                caracteristicas.Items.Remove(index);
                index--;
            }

            cities_list = node.Get_Cities_by_id();

            for (int i = 0; cities_list.Count > i; i++)
            {
                elegir_ciudad.Items.Add(cities_list[i].id.ToString());
            }

            ciudad.Text = "";
            alcalde.Text = "";
            capital.Text = "";
            textBox2.Text = "";
            poblacion.Text = "";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buffer = textBox1.Text;
            new_column_value.Enabled = true;
            new_column.Text = buffer;


            EnlaceCassandra add = new EnlaceCassandra();
            add.insertColumn(buffer);
        }

        private void elegir_ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buffer = elegir_ciudad.SelectedItem.ToString();
            int i = 0;
            while(cities_list.Count>=i)
            {
                if(cities_list[i].id==Int32.Parse(buffer))
                {
                    capital.Text = cities_list[i].capital;
                    ciudad.Text = cities_list[i].id.ToString();
                    alcalde.Text = cities_list[i].mayor;
                    poblacion.Text = cities_list[i].population.ToString();
                    textBox2.Text = cities_list[i].hostpital_quantity.ToString();
                    break;
                }
                i++;
            }

            dato_especifico.Enabled = true;
            
            MessageBox.Show("HORA PUEDE MODIFICAR SU LAS CARACTERISTICAS U OTROS DATOS\nCARACTERISTICAS SE MODIFICAN POR SEPARADO","AVISO");
        }

        private void modificar_caracteristicas_Click(object sender, EventArgs e)
        {
            city modCaracteristcas = new city();
            int index=0;
            modCaracteristcas.characteritics = new List<string>();
            while (index < caracteristicas.Items.Count)
            {
                caracteristicas.SelectedItem = index;
                modCaracteristcas.characteritics.Add(caracteristicas.Items[index].ToString());
                index++;
            }

            modCaracteristcas.id = Int32.Parse(ciudad.Text.ToString());
            modCaracteristcas.capital = capital.Text;

            EnlaceCassandra characteristics = new EnlaceCassandra();
            characteristics.Edit_characteristics(modCaracteristcas);

        }

        private void Eliminar_renglon_Click(object sender, EventArgs e)
        {
            city delete = new city();
            delete.id = Int32.Parse(ciudad.Text.ToString());
            delete.capital = capital.Text;

            EnlaceCassandra row = new EnlaceCassandra();
            row.delte_row(delete);

            cities_list = row.Get_Cities_by_id();

            for (int i = 0; cities_list.Count > i; i++)
            {
                elegir_ciudad.Items.Add(cities_list[i].id.ToString());
            }

            MessageBox.Show("Renglon eliminado\nPuede dar en mostrar informacion", "actualizacion");

        }

        private void dato_especifico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query="";

            if (delete_column == false)
            {
                query = "UPDATE cities_by_id SET ";

                if (dato_especifico.SelectedItem.ToString() == "Alcalde")
                    query += "mayor = '" + alcalde.Text + "'";
                else if (dato_especifico.SelectedItem.ToString() == "Poblacion")
                    query += "population = " + Int32.Parse(poblacion.Text);
                else if (dato_especifico.SelectedItem.ToString() == "Numero Hospitales")
                    query += "hospitals_quantity = " + Int32.Parse(poblacion.Text);



                query += "  WHERE id_city =" + ciudad.Text + " AND capital ='" + capital.Text + "';";
            }else if(delete_column == true)
            {
                query = "DELETE ";
                if (dato_especifico.SelectedItem.ToString() == "Alcalde")
                    query += "mayor ";
                else if (dato_especifico.SelectedItem.ToString() == "Poblacion")
                    query += "population ";
                else if (dato_especifico.SelectedItem.ToString() == "Numero Hospitales")
                    query += "hospitals_quantity " 
                        ;
                query += "FROM cities_by_id WHERE id_city = "+ciudad.Text+" AND capital ='"+capital.Text+"';";


            }
            EnlaceCassandra update = new EnlaceCassandra();
            update.update(query);

            MessageBox.Show("LA INFORMAIO SE ACTUALIZO CON EXITO\nPUEDE DAR EN MOSTRAR DATOS","AVISO");
        }

        private void Dato_CheckedChanged(object sender, EventArgs e)
        {
            if (Dato.Checked)
            {
                delete_column = true;
                return;
            }

            delete_column = false;
            return;
        }

        private void remplazar_Click(object sender, EventArgs e)
        {
            string id = elegir_ciudad.Text;
            city data = new city();

            if (ciudad.Text == "" && data.capital == null)
            {
                MessageBox.Show("FALTA No.Ciudad o Centro", "INCORRECTO");
                return;
            }

            data.id = Int32.Parse(ciudad.Text);
            data.capital = capital.Text.ToString();
            if (textBox2.Text != "")
                data.hostpital_quantity = Int32.Parse(textBox2.Text);
            data.mayor = alcalde.Text;
            if (textBox2.Text != "")
                data.population = Int32.Parse(poblacion.Text);

            int index = 0;
            data.characteritics = new List<string>();
            while (index < caracteristicas.Items.Count)
            {
                caracteristicas.SelectedItem = index;
                data.characteritics.Add(caracteristicas.Items[index].ToString());
                index++;
            }

            EnlaceCassandra node = new EnlaceCassandra();
            node.replace(data,id);

            InitializeComponent();
            EnlaceCassandra addCities = new EnlaceCassandra();
            cities_list = addCities.Get_Cities_by_id();

            for (int i = 0; cities_list.Count > i; i++)
            {
                elegir_ciudad.Items.Add(cities_list[i].id.ToString());
            }

            dato_especifico.Items.Add("Alcalde");
            dato_especifico.Items.Add("Poblacion");
            dato_especifico.Items.Add("Numero Hospitales");

            MessageBox.Show("EL  BATCH SE APLICO, REINICIE LA APLICACION", "BATCH STATUS");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void display_info_Click(object sender, EventArgs e)
        {

            EnlaceCassandra show = new EnlaceCassandra();
            cities_list = show.Get_All();
            int index = 0;
            string row;
            while (index < cities_list.Count)
            {
                row = cities_list[index].id.ToString()+"    ";
                row += cities_list[index].capital + "    ";
                row += cities_list[index].dateTime + "   ";
                row += cities_list[index].mayor + "  ";
                row += cities_list[index].hostpital_quantity.ToString() + "  ";
                row += cities_list[index].population.ToString();

                data.Items.Add(row);

                index++;
            }
        }

        private void data_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
