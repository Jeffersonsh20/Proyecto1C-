using Newtonsoft.Json;
using ProectoEquipos.Clase;

namespace ProectoEquipos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            String archivo = File.ReadAllText(path);
            clubes = JsonConvert.DeserializeObject<String[,]>(archivo);
            InitializeComponent();
        }
        String[,] clubes;
        String[,] ordenar;
        private int pos = 0;
        private int name = 1;
        private int j = 2;
        private int pts = 3;
        private int g = 4;
        private int e = 5;
        private int p = 6;
        private int gf = 7;
        private int gc = 8;
        private int dfg = 9;

        String path = "C:\\Users\\Wclinares\\source\\repos\\ProectoEquipos\\Clase\\equipos.json";

        public void cargadatos(String[,] clubs)
        {

            for (int i = 0; i < clubs.GetLength(0); i++)
            {
                tbEquipos.Rows.Add(clubs[i, pos], clubs[i, name], clubs[i, j], clubs[i, pts],
                clubs[i, g], clubs[i, e], clubs[i, p], clubs[i, gf],
                clubs[i, gc], clubs[i, dfg]);
            }
        }

        private void btnequipos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clubes.GetLength(0); i++)
            {
                comboEquipo1.Items.Add(clubes[i, name]);
                comboEquipo2.Items.Add(clubes[i, name]);
            }
            cargadatos(clubes);

        }

        private void tbnActualizar_Click(object sender, EventArgs e)
        {
            String club1 = "";
            String club2 = "";
            int resultadoClub1 = 0;
            int resultadoClub2 = 0;

            club1 = Convert.ToString(comboEquipo1.SelectedItem);
            club2 = Convert.ToString(comboEquipo2.SelectedItem);
            resultadoClub1 = Convert.ToInt32(textResultado1.Text);
            resultadoClub2 = Convert.ToInt32(textResultado2.Text);


            if (resultadoClub1 > resultadoClub2)
            {
                for (int i = 0; i < clubes.GetLength(0); i++)
                {
                    if (club1.Equals(clubes[i, name]))
                    {
                        clubes[i, j] = (Convert.ToInt32(clubes[i, j]) + 1) + "";
                        clubes[i, pts] = (Convert.ToInt32(clubes[i, pts]) + 3) + "";
                        clubes[i, g] = (Convert.ToInt32(clubes[i, g]) + 1) + "";
                        clubes[i, gf] = (Convert.ToInt32(clubes[i, gf]) + resultadoClub1) + "";
                        clubes[i, gc] = (Convert.ToInt32(clubes[i, gc]) + resultadoClub2) + "";
                        clubes[i, dfg] = (Convert.ToInt32(clubes[i, gf]) - Convert.ToInt32(clubes[i, gc])) + "";
                    }
                    else if (club2.Equals(clubes[i, name]))
                    {
                        clubes[i, j] = (Convert.ToInt32(clubes[i, j]) + 1) + "";
                        clubes[i, p] = (Convert.ToInt32(clubes[i, p]) + 1) + "";
                        clubes[i, gf] = (Convert.ToInt32(clubes[i, gf]) + resultadoClub2) + "";
                        clubes[i, gc] = (Convert.ToInt32(clubes[i, gc]) + resultadoClub1) + "";
                        clubes[i, dfg] = (Convert.ToInt32(clubes[i, gf]) - Convert.ToInt32(clubes[i, gc])) + "";
                    }
                }
            }

            else if (resultadoClub1 < resultadoClub2)
            {
                for (int i = 0; i < clubes.GetLength(0); i++)
                {
                    if (club2.Equals(clubes[i, name]))
                    {
                        clubes[i, j] = (Convert.ToInt32(clubes[i, j]) + 1) + "";
                        clubes[i, pts] = (Convert.ToInt32(clubes[i, pts]) + 3) + "";
                        clubes[i, g] = (Convert.ToInt32(clubes[i, g]) + 1) + "";
                        clubes[i, gf] = (Convert.ToInt32(clubes[i, gf]) + resultadoClub2) + "";
                        clubes[i, gc] = (Convert.ToInt32(clubes[i, gc]) + resultadoClub1) + "";
                        clubes[i, dfg] = (Convert.ToInt32(clubes[i, gf]) - Convert.ToInt32(clubes[i, gc])) + "";
                    }
                    else if (club1.Equals(clubes[i, name]))
                    {
                        clubes[i, j] = (Convert.ToInt32(clubes[i, j]) + 1) + "";
                        clubes[i, p] = (Convert.ToInt32(clubes[i, p]) + 1) + "";
                        clubes[i, gf] = (Convert.ToInt32(clubes[i, gf]) + resultadoClub1) + "";
                        clubes[i, gc] = (Convert.ToInt32(clubes[i, gc]) + resultadoClub2) + "";
                        clubes[i, dfg] = (Convert.ToInt32(clubes[i, gf]) - Convert.ToInt32(clubes[i, gc])) + "";
                    }
                }
            }

            else
            {
                for (int i = 0; i < clubes.GetLength(0); i++)
                {
                    if (club1.Equals(clubes[i, name]))
                    {
                        clubes[i, j] = (Convert.ToInt32(clubes[i, j]) + 1) + "";
                        clubes[i, pts] = (Convert.ToInt32(clubes[i, pts]) + 1) + "";
                        clubes[i, this.e] = (Convert.ToInt32(clubes[i, this.e]) + 1) + "";
                        clubes[i, gf] = (Convert.ToInt32(clubes[i, gf]) + resultadoClub1) + "";
                        clubes[i, gc] = (Convert.ToInt32(clubes[i, gc]) + resultadoClub2) + "";
                        clubes[i, dfg] = (Convert.ToInt32(clubes[i, gf]) - Convert.ToInt32(clubes[i, gc])) + "";
                    }
                    else if (club2.Equals(clubes[i, name]))
                    {
                        clubes[i, j] = (Convert.ToInt32(clubes[i, j]) + 1) + "";
                        clubes[i, pts] = (Convert.ToInt32(clubes[i, pts]) + 1) + "";
                        clubes[i, this.e] = (Convert.ToInt32(clubes[i, this.e]) + 1) + "";
                        clubes[i, gf] = (Convert.ToInt32(clubes[i, gf]) + resultadoClub2) + "";
                        clubes[i, gc] = (Convert.ToInt32(clubes[i, gc]) + resultadoClub1) + "";
                        clubes[i, dfg] = (Convert.ToInt32(clubes[i, gf]) - Convert.ToInt32(clubes[i, gc])) + "";
                    }
                }

            }

            ClsOrden ordenae = new ClsOrden();
            ordenar = ordenae.ordenar(clubes);
            cargadatos(ordenar);

        }
    }
    
}