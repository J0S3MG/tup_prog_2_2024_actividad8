using Ejercicio1.Models;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        string path = Application.StartupPath + "\\Banco.dat";//El StartupPath me lleva a la carpeta de la app. Y creo en esa carpeta un archivo binario.
        Banco bna;//Creo la clase contenedora.
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnVerCuentas_Click(object sender, EventArgs e)
        {

            tbxVer.Text = "Numero de Cuenta  | Nombre        | Saldo" + "\r\n";
            for (int i = 0; i < bna.CantCuent; i++)
            {
                Cuenta cue = bna[i];
                tbxVer.Text += cue.ToString();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog venti = new OpenFileDialog();//Creo la ventana Modal que me va a permitir seleccionar el archivo y abrirlo.
            venti.Title = "Importación de cuentas";//establecemos el titulo del cuadro de dialogo del archivo
            venti.Filter = "fichero csv|*.csv";// determinamos los archivos a mostrar
            if (venti.ShowDialog() == DialogResult.OK)//Abro la ventana modal.
            {
                string ruta = venti.FileName;//Trae la ruta del archivo.
                FileStream flow = null;//Hago una variable que almacena el flujo de datos.
                StreamReader lee = null;//Hago una variable que almacena flujo de lectura.
                try
                {
                    flow = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);//Creo el flujo de datos.
                    lee = new StreamReader(flow);//Creo el flujo de lectura.

                    string linea = lee.ReadLine();//Leo la primera linea."DNI; nombre; número de cuenta; saldo"
                    string[] datosep;//Creo un vector que va a recibir los datos separados."DNI; nombre; número de cuenta; saldo"
                    Cuenta recibe;//Recibe la cuenta creada para poder settear el saldo.

                    while (lee.EndOfStream)
                    {
                        linea = lee.ReadLine();//Lee la siguiente linea.
                        datosep = linea.Split(';');//separa las lineas en un vector.
                                                   //Pos 2 Nuro. Cuenta lo convierto//Pos 0 DNI lo convierto//Pos 1 Nombre
                        recibe = bna.AgregarCuenta(Convert.ToInt32(datosep[2]), Convert.ToInt32(datosep[0]), datosep[1]);
                        recibe.Saldo = Convert.ToDouble(datosep[3]);//Pos 3 el saldo.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    lee.Close();
                    flow.Close();
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog venti = new SaveFileDialog();//Creo la ventana Modal que me va a permitir seleccionar una ubicacion y guardar el archivo.
            venti.Title = "Exportacion de cuentas";//establecemos el titulo del cuadro de dialogo del archivo
            venti.Filter = "fichero csv|*.csv";//determinamos los archivos a mostrar
            if (venti.ShowDialog() == DialogResult.OK)//Abro la ventana modal.
            {
                string ruta = venti.FileName;//Trae la ruta del archivo.
                FileStream flow = null;//Hago una variable que almacena el flujo de datos.
                StreamWriter quino = null;//Hago una variable que almacena flujo de escritura.
                try
                {
                    flow = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);//Creo el flujo de datos.
                    quino = new StreamWriter(flow);//Creo el flujo de escritura.

                    quino.WriteLine("DNI; nombre; número de cuenta; saldo");//Cargo la primera linea
                    for (int i = 0; i < bna.CantCuent; i++)
                    {
                        Cuenta cue = bna[i];
                        quino.WriteLine($"{cue.Titular.DNI};{cue.Titular.Nombre};{cue.Numero};{cue.Saldo}");//Cargo cada dato de la linea 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    quino.Close();
                    flow.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists(path))//Chequeo que la ruta exista.
            {
                FileStream flujoBin = new FileStream(path,FileMode.Open, FileAccess.Read);//Abro el archivo para leerlo.
                BinaryFormatter bin = new BinaryFormatter();//Creo el adaptador que me permite traducir el archivo.
                bna = bin.Deserialize(flujoBin) as Banco;//Deserializo el archivo y lo casteo como un banco.
                flujoBin.Close();
            }
       
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(path))//Chequeo que la ruta exista.
            {
                File.Delete(path);//Si existe la borro.
            }
            FileStream flujoBin = new FileStream(path, FileMode.Create, FileAccess.Write);//Sino creo el flujo para escribiro.
            BinaryFormatter bin = new BinaryFormatter();//Creo el adaptador que me permite traducir el archivo.
            bin.Serialize(flujoBin, bna);//Le paso el objeto contenedor y el flujo donde se va a guardar en binario.
            flujoBin.Close();
        }
    }
}
