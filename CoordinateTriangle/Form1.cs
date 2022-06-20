using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BG_Odev3
{
    public partial class frmOdev : Form
    {

        System.Drawing.Graphics Cizim;

        Pen kalem = new Pen(Color.Purple, 2);

        Double[,] XCismiNoktasi = new Double[3, 3] {  {2,3,0},
                                                      {7,3,0},
                                                      {2,6,0},};

        Double[,] Xnew = new Double[3, 3];

        Double[,] Tisometric = new Double[4, 4] { { 0.707, -0.408,0,0},
                                                   {0,0.816,0,0 },
                                                   {-0.707, -0.408,0,0 },
                                                    {0,0,0,0 } };
        Double[,] Ttranslation = new Double[4, 4] { {1,0,0,0 },
                                                  {0,1,0,0 },
                                                   {0,0,1,0 },
                                                      {0,0,0,1 }};
        Double[,] Trotate = new Double[4, 4] { {1,0,0,0 },
                                                  {0,1,0,0 },
                                                   {0,0,1,0 },
                                                      {0,0,0,1 }};

        Double[,] axis2BX = new Double[2, 2] { { -20, 0 }, { 20, 0 } };
        Double[,] axis2BY = new Double[2, 2] { { 0, 20 }, { 0, -20 } };

        int i, j, k;
        public frmOdev()
        {
            InitializeComponent();
        }

        //cisim icin
        private void Draw()
        {
            Cizim = this.CreateGraphics();
            Cizim.DrawLine(kalem, CaCoordinateX(Xnew[0, 0]), CaCoordinateY(Xnew[0, 1]), CaCoordinateX(Xnew[1, 0]), CaCoordinateY(Xnew[1, 1]));
            Cizim.DrawLine(kalem, CaCoordinateX(Xnew[1, 0]), CaCoordinateY(Xnew[1, 1]), CaCoordinateX(Xnew[2, 0]), CaCoordinateY(Xnew[2, 1]));
            Cizim.DrawLine(kalem, CaCoordinateX(Xnew[2, 0]), CaCoordinateY(Xnew[2, 1]), CaCoordinateX(Xnew[0, 0]), CaCoordinateY(Xnew[0, 1]));
        }

        //yansıtılmış cismin cizimi
        private void Draw2()
        {
            Cizim = this.CreateGraphics();
            Cizim.DrawLine(kalem, YansıtX(Xnew[0, 0]), YansıtY(Xnew[0, 1]), YansıtX(Xnew[1, 0]), YansıtY(Xnew[1, 1]));
            Cizim.DrawLine(kalem, YansıtX(Xnew[1, 0]), YansıtY(Xnew[1, 1]), YansıtX(Xnew[2, 0]), YansıtY(Xnew[2, 1]));
            Cizim.DrawLine(kalem, YansıtX(Xnew[2, 0]), YansıtY(Xnew[2, 1]), YansıtX(Xnew[0, 0]), YansıtY(Xnew[0, 1]));
        }

        //cisim icin
        private int CaCoordinateX(Double tempX)
        {
            return Convert.ToInt32(300 + 250 + (50 * tempX));
        }

        private int CaCoordinateY(Double tempY)
        {
            return Convert.ToInt32(100 + 250 + (-50 * tempY));
        }

        //yansıtma icin
        private int YansıtX(Double tempX)
        {
            return Convert.ToInt32(300 + 250 + (50 * tempX));
        }
        private int YansıtY(Double tempY)
        {
            return Convert.ToInt32(100 + 250 + (50 * tempY));
        }




        private void btn2Beksen_Click(object sender, EventArgs e)
        {
            Cizim = this.CreateGraphics();
            Cizim.DrawLine(kalem, CaCoordinateX(axis2BX[0, 0]), CaCoordinateY(axis2BX[0, 1]), CaCoordinateX(axis2BX[1, 0]), CaCoordinateY(axis2BX[1, 1]));
            Cizim.DrawLine(kalem, CaCoordinateX(axis2BY[0, 0]), CaCoordinateY(axis2BY[0, 1]), CaCoordinateX(axis2BY[1, 0]), CaCoordinateY(axis2BY[1, 1]));

            Cizim.Dispose();
        }

        private void btnİzoizDusumu_Click(object sender, EventArgs e)
        {
            Xnew = XCismiNoktasi;
            Draw();
        }

        private void btnOtele_Click(object sender, EventArgs e)
        {


            Xnew = XCismiNoktasi;
            Draw2();


        }

        private void btnDondur_Click(object sender, EventArgs e)
        {
            Double[,] temp = new Double[8, 4];
            Double teta = 30;

            Trotate[1, 2] = Math.Cos(Math.PI * teta / 180.0);
            Trotate[2, 2] = Trotate[1, 1];

            Trotate[1, 2] = Math.Sin(Math.PI * teta / 180.0);
            Trotate[2, 3] = (-1) * Trotate[1, 2];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    temp[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        temp[i, j] += XCismiNoktasi[i, k] * Trotate[k, j];
                    }
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Xnew[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Xnew[i, j] += temp[i, k] * Tisometric[k, j];
                    }
                }
            }
            kalem.Color = Color.Black;
            Draw();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void frmOdev_Load(object sender, EventArgs e)
        {

        }
    }
}
