using System;
using System.Diagnostics;
using System.Windows.Forms;

public class Menu

{
    public static void Menus()
    {
        Form janela = new Form();
        janela.Text = "DIGITE O SEU NOME:";
        janela.Size = new System.Drawing.Size(350, 200);


         Label lblNome= new Label();
            lblNome.Text = "Nome:";
            lblNome.Top = 0;
            lblNome.Left = 0;
            lblNome.Size = new System.Drawing.Size(100, 25);

        TextBox txtNome = new TextBox();
            txtNome.Top = 0;
            txtNome.Left = 100;
            txtNome.Size = new System.Drawing.Size(100, 25);

        Button btnOla = new Button();
            btnOla.Text = "Olá";
            btnOla.Top = 75;
            btnOla.Left = 100;
            btnOla.Size = new System.Drawing.Size(100, 25);
            btnOla.Click += (sender, e) => {
                 MessageBox.Show("Olá, " + txtNome.Text + "!");
            };


        Button btnFechar = new Button();
            btnFechar.Text = "Fechar";
            btnFechar.Top = 100;
            btnFechar.Left = 100;
            btnFechar.Size = new System.Drawing.Size(100 , 25);
            btnFechar.Click += (sender, e) => {
               janela.Close();
            };

            janela.Controls.Add(lblNome);

            janela.Controls.Add(txtNome);

            janela.Controls.Add(btnOla);

            janela.Controls.Add(btnFechar);

        Application.Run(janela);

    }

}
