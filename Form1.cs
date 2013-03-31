using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int X, Y, X1, Y1, DX, DY;
        string strfotoFondo;
        private Button button;
        private TextBox txt;
        private List<Propiedades> propiedades = new List<Propiedades>();
        private int luzCont = 0;
        private int rgbCont = 0;
        private int persianaCont = 0;
        private int termostatoCont = 0;
        public string[] imagenes = {"luzOn.png", "luzOff.png", "rgbOn.png","rgbOff.png", "persianaOn.png","persianaOff.png","termostatoOn.png","termostatoOff.png"};

        public Form1()
        {
            InitializeComponent();

            imgFondo.AllowDrop = true;
            imgFondo.DragDrop += imagen_DragDrop;
            imgFondo.DragEnter += imagen_DragEnter;

            crearLuz.Image = Image.FromFile("luzOn.png");
            btnLuzOn.Click += btnImagen_Click;
            btnLuzOff.Click += btnImagen_Click;

            crearRgb.Image = Image.FromFile("rgbOn.png");
            btnRgbOn.Click += btnImagen_Click;
            btnRgbOff.Click += btnImagen_Click;

            crearPersiana.Image = Image.FromFile("persianaOn.png");
            btnPersianaOn.Click += btnImagen_Click;
            btnPersianaOff.Click += btnImagen_Click;

            crearTermostato.Image = Image.FromFile("termostatoOn.png");
            btnTermostatoOn.Click += btnImagen_Click;
            btnTermostatoOff.Click += btnImagen_Click;

            
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            button.DoDragDrop(button, DragDropEffects.Move);
        }

        private void imagen_DragEnter(object sender, DragEventArgs e)
        {
            PictureBox imagen = (PictureBox)sender;
            e.Effect = DragDropEffects.Move;
            X = PointToClient(Cursor.Position).X;
            Y = PointToClient(Cursor.Position).Y;

            DX = X - (imagen.Location.X + button.Location.X) - 20;
            DY = Y - (imagen.Location.Y + button.Location.Y) - 20;
        }

        private void imagen_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox imagen = (PictureBox)sender;
            X1 = PointToClient(Cursor.Position).X;
            Y1 = PointToClient(Cursor.Position).Y;

            X = X1 - X + button.Location.X + DX;
            Y = Y1 - Y + button.Location.Y + DY;

            if (X > imagen.Size.Width - 40)
                X = imagen.Size.Width - 40;

            if (Y > imagen.Size.Height - 40)
                Y = imagen.Size.Height - 40;

            if (X < 0)
                X = 0;

            if (Y < 0)
                Y = 0;

            button.Location = new Point(X, Y);

            Propiedades btnPropiedades = propiedades.Find(p => p.getCodigo() == button.Name.ToString());
            btnPropiedades.setLocationX(button.Location.X);
            btnPropiedades.setLocationY(button.Location.Y);
            txtLocationX.Text = btnPropiedades.getLocationX().ToString();
            txtLocationY.Text = btnPropiedades.getLocationY().ToString();
        }

        private void button_GotFocus(object sender, EventArgs e)
        {
            button = (Button)sender;

            Propiedades btnPropiedades = propiedades.Find(p => p.getCodigo() == button.Name.ToString());
            txtTipo.Text = btnPropiedades.getTipo();
            txtNombre.Text = btnPropiedades.getCodigo();
            txtLocationX.Text = btnPropiedades.getLocationX().ToString();
            txtLocationY.Text = btnPropiedades.getLocationY().ToString();
        }

        private void crearLuz_Click(object sender, EventArgs e)
        {
            Button botonLuz = new Button();
            botonLuz.AllowDrop = true;
            botonLuz.Tag = "Luz_ONOFF";
            botonLuz.Name = botonLuz.Tag.ToString() + " " + luzCont;
            botonLuz.Location = new Point(350, 190);
            botonLuz.Image = Image.FromFile("luzOn.png");
            botonLuz.Size = new Size(40, 40);
            botonLuz.UseVisualStyleBackColor = true;
            botonLuz.Visible = true;
            imgFondo.Controls.Add(botonLuz);
            botonLuz.MouseDown += button_MouseDown;
            botonLuz.GotFocus += button_GotFocus;
            botonLuz.KeyPress += button_KeyPress;

            Propiedades luzPropiedades = new Propiedades(botonLuz.Name.ToString());
            luzPropiedades.setTipo(botonLuz.Tag.ToString());
            luzPropiedades.setLocationX(botonLuz.Location.X);
            luzPropiedades.setLocationY(botonLuz.Location.Y);
            propiedades.Add(luzPropiedades);

            botonLuz.Focus();

            luzCont++;
        }

        private void crearRgb_Click(object sender, EventArgs e)
        {
            Button botonRgb = new Button();
            botonRgb.AllowDrop = true;
            botonRgb.Tag = "Luz_RGB";
            botonRgb.Name = botonRgb.Tag.ToString() + rgbCont;
            botonRgb.Location = new Point(350, 190);
            botonRgb.Image = Image.FromFile("rgbOn.png");
            botonRgb.Size = new Size(40, 40);
            botonRgb.UseVisualStyleBackColor = true;
            botonRgb.Visible = true;
            imgFondo.Controls.Add(botonRgb);
            botonRgb.MouseDown += button_MouseDown;
            botonRgb.GotFocus += button_GotFocus;
            botonRgb.KeyPress += button_KeyPress;

            Propiedades rgbPropiedades = new Propiedades(botonRgb.Name.ToString());
            rgbPropiedades.setTipo(botonRgb.Tag.ToString());
            rgbPropiedades.setLocationX(botonRgb.Location.X);
            rgbPropiedades.setLocationY(botonRgb.Location.Y);
            propiedades.Add(rgbPropiedades);

            botonRgb.Focus();

            rgbCont++;
        }

        private void crearPersiana_Click(object sender, EventArgs e)
        {
            Button botonPersiana = new Button();
            botonPersiana.AllowDrop = true;
            botonPersiana.Tag = "Persiana";
            botonPersiana.Name = botonPersiana.Tag.ToString() + persianaCont;
            botonPersiana.Location = new Point(350, 190);
            botonPersiana.Image = Image.FromFile("persianaOn.png");
            botonPersiana.Size = new Size(40, 40);
            botonPersiana.UseVisualStyleBackColor = true;
            botonPersiana.Visible = true;
            imgFondo.Controls.Add(botonPersiana);
            botonPersiana.MouseDown += button_MouseDown;
            botonPersiana.GotFocus += button_GotFocus;
            botonPersiana.KeyPress += button_KeyPress;

            Propiedades persianaPropiedades = new Propiedades(botonPersiana.Name.ToString());
            persianaPropiedades.setTipo(botonPersiana.Tag.ToString());
            persianaPropiedades.setLocationX(botonPersiana.Location.X);
            persianaPropiedades.setLocationY(botonPersiana.Location.Y);
            propiedades.Add(persianaPropiedades);

            botonPersiana.Focus();

            persianaCont++;
        }

        private void crearTermostato_Click(object sender, EventArgs e)
        {
            Button botonTermostato = new Button();
            botonTermostato.AllowDrop = true;
            botonTermostato.Tag = "Termostato";
            botonTermostato.Name = botonTermostato.Tag.ToString() + termostatoCont;
            botonTermostato.Location = new Point(350, 190);
            botonTermostato.Image = Image.FromFile("termostatoOn.png");
            botonTermostato.Size = new Size(40, 40);
            botonTermostato.UseVisualStyleBackColor = true;
            botonTermostato.Visible = true;
            imgFondo.Controls.Add(botonTermostato);
            botonTermostato.MouseDown += button_MouseDown;
            botonTermostato.GotFocus += button_GotFocus;
            botonTermostato.KeyPress += button_KeyPress;

            Propiedades termostatoPropiedades = new Propiedades(botonTermostato.Name.ToString());
            termostatoPropiedades.setTipo(botonTermostato.Tag.ToString());
            termostatoPropiedades.setLocationX(botonTermostato.Location.X);
            termostatoPropiedades.setLocationY(botonTermostato.Location.Y);
            propiedades.Add(termostatoPropiedades);

            botonTermostato.Focus();

            termostatoCont++;
        }

        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                propiedades.RemoveAll(x => x.getCodigo() == button.Name.ToString());

                imgFondo.Controls.Remove(button);
                button.Dispose();

                txtTipo.Text = "";
                txtNombre.Text = "";
                txtLocationX.Text = "";
                txtLocationY.Text = "";
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();

            open1.InitialDirectory = "";
            open1.Filter = "ImagenFiles(*.BMP,*.JPG,*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|Allfiles(*.*)|*.*";
            open1.FilterIndex = 1;
            open1.ShowDialog();
            string strfoto = open1.SafeFileName;

            if (strfoto != "")
            {
                
                txt.Text = strfoto;
                imagenes[(int)txt.Tag] = txt.Text;
            }
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();

            open1.InitialDirectory = "";
            open1.Filter = "ImagenFiles(*.BMP,*.JPG,*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|Allfiles(*.*)|*.*";
            open1.FilterIndex = 1;
            open1.ShowDialog();
            strfotoFondo = open1.SafeFileName;

            if (strfotoFondo != "")
            {
                

                imgFondo.SizeMode = PictureBoxSizeMode.StretchImage;
                imgFondo.Image = Image.FromFile(strfotoFondo);

                crearLuz.Enabled = true;
                btnLuzOn.Enabled = true;
                btnLuzOff.Enabled = true;

                crearRgb.Enabled = true;
                btnRgbOn.Enabled = true;
                btnRgbOff.Enabled = true;

                crearPersiana.Enabled = true;
                btnPersianaOn.Enabled = true;
                btnPersianaOff.Enabled = true;

                crearTermostato.Enabled = true;
                btnTermostatoOn.Enabled = true;
                btnTermostatoOff.Enabled = true;
            }
        }

        private void btnImagenOn_MouseEnter(object sender, EventArgs e)
        {
            txt = txtLuzOn;
           // imagenes[0] = txtLuzOn.Text;
            //imagenes[0] = txt.Text;
            txt.Tag = 0;
        }

        private void btnImagenOff_MouseEnter(object sender, EventArgs e)
        {
            txt = txtLuzOff;
            //imagenes[1] = txtLuzOff.Text;
            //imagenes[1] = txt.Text;
            txt.Tag = 1;
        }

        private void btnRgbOn_MouseEnter(object sender, EventArgs e)
        {
            txt = txtRgbOn;
            //imagenes[2] = txtRgbOn.Text;
            //imagenes[2] = txt.Text;
            txt.Tag = 2;
        }

        private void btnRgbOff_MouseEnter(object sender, EventArgs e)
        {
            txt = txtRgbOff;
            //imagenes[3] = txtRgbOff.Text;
            //imagenes[3] = txt.Text;
            txt.Tag = 3;
        }

        private void btnPersianaOn_MouseEnter(object sender, EventArgs e)
        {
            txt = txtPersianaOn;
            //imagenes[4] = txtPersianaOn.Text;
            //imagenes[4] = txt.Text;
            txt.Tag = 4;
        }

        private void btnPersianaOff_MouseEnter(object sender, EventArgs e)
        {
            txt = txtPersianaOff;
            //imagenes[5] = txtPersianaOff.Text;
            //imagenes[5] = txt.Text;
            txt.Tag =5;
        }

        private void btnTermostatoOn_MouseEnter(object sender, EventArgs e)
        {
            txt = txtTermostatoOn;
            //imagenes[6] = txtTermostatoOn.Text;
           // imagenes[6] = txt.Text;
            txt.Tag = 6;
        }

        private void btnTermostatoOff_MouseEnter(object sender, EventArgs e)
        {
            txt = txtTermostatoOff;
            //imagenes[7] = txtTermostatoOff.Text;
            //imagenes[7] = txt.Text;
            txt.Tag = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Class2(propiedades, strfotoFondo, imagenes);
        }
    }
}
