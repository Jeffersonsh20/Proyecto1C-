using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProectoEquipos.Clase
{
    internal class ClsOrden
    {
        String[,] eq = new String[12, 10];
        String[] name = new String[12];
        int[] J = new int[12];
        int[] Pts = new int[12];
        int[] G = new int[12];
        int[] E = new int[12];
        int[] P = new int[12];
        int[] GF = new int[12];
        int[] GC = new int[12];
        int[] DG = new int[12];
        public String[,] ordenar(String[,] clubs)
        {
            for (int x = 0; x < J.Length; x++)
            {
                name[x] = clubs[x, 1];
                J[x] = Convert.ToInt32(clubs[x, 2]);
                Pts[x] = Convert.ToInt32(clubs[x, 3]);
                G[x] = Convert.ToInt32(clubs[x, 4]);
                E[x] = Convert.ToInt32(clubs[x, 5]);
                P[x] = Convert.ToInt32(clubs[x, 6]);
                GF[x] = Convert.ToInt32(clubs[x, 7]);
                GC[x] = Convert.ToInt32(clubs[x, 8]);
                DG[x] = Convert.ToInt32(clubs[x, 9]);
            }

            int Jor, Puntos, Gan, Emp, Per, GolF, GolC, DifG;
            String nombre;
            for (int i = 0; i < (J.Length - 1); i++)
            {
                for (int j = 0; j < (J.Length - 1); j++)
                {
                    //Ordenar por Puntos
                    if (Pts[j] < Pts[j + 1])
                    {
                        Puntos = Pts[j];
                        nombre = name[j];
                        Jor = J[j];
                        Gan = G[j];
                        Emp = E[j];
                        Per = P[j];
                        GolF = GF[j];
                        GolC = GC[j];
                        DifG = DG[j];
                        Pts[j] = Pts[j + 1];
                        name[j] = name[j + 1];
                        J[j] = J[j + 1];
                        G[j] = G[j + 1];
                        E[j] = E[j + 1];
                        P[j] = P[j + 1];
                        GF[j] = GF[j + 1];
                        GC[j] = GC[j + 1];
                        DG[j] = DG[j + 1];
                        Pts[j + 1] = Puntos;
                        name[j + 1] = nombre;
                        J[j + 1] = Jor;
                        G[j + 1] = Gan;
                        E[j + 1] = Emp;
                        P[j + 1] = Per;
                        GF[j + 1] = GolF;
                        GC[j + 1] = GolC;
                        DG[j + 1] = DifG;

                        //Ordenar Diferencia Goles
                        if (DG[j] < DG[j + 1])
                        {
                            Puntos = Pts[j];
                            nombre = name[j];
                            Jor = J[j];
                            Gan = G[j];
                            Emp = E[j];
                            Per = P[j];
                            GolF = GF[j];
                            GolC = GC[j];
                            DifG = DG[j];
                            Pts[j] = Pts[j + 1];
                            name[j] = name[j + 1];
                            J[j] = J[j + 1];
                            G[j] = G[j + 1];
                            E[j] = E[j + 1];
                            P[j] = P[j + 1];
                            GF[j] = GF[j + 1];
                            GC[j] = GC[j + 1];
                            DG[j] = DG[j + 1];
                            Pts[j + 1] = Puntos;
                            name[j + 1] = nombre;
                            J[j + 1] = Jor;
                            G[j + 1] = Gan;
                            E[j + 1] = Emp;
                            P[j + 1] = Per;
                            GF[j + 1] = GolF;
                            GC[j + 1] = GolC;
                            DG[j + 1] = DifG;


                            //Ordenar Por Goles
                            if (GF[j] < GF[j + 1])
                            {
                                Puntos = Pts[j];
                                nombre = name[j];
                                Jor = J[j];
                                Gan = G[j];
                                Emp = E[j];
                                Per = P[j];
                                GolF = GF[j];
                                GolC = GC[j];
                                DifG = DG[j];
                                Pts[j] = Pts[j + 1];
                                name[j] = name[j + 1];
                                J[j] = J[j + 1];
                                G[j] = G[j + 1];
                                E[j] = E[j + 1];
                                P[j] = P[j + 1];
                                GF[j] = GF[j + 1];
                                GC[j] = GC[j + 1];
                                DG[j] = DG[j + 1];
                                Pts[j + 1] = Puntos;
                                name[j + 1] = nombre;
                                J[j + 1] = Jor;
                                G[j + 1] = Gan;
                                E[j + 1] = Emp;
                                P[j + 1] = Per;
                                GF[j + 1] = GolF;
                                GC[j + 1] = GolC;
                                DG[j + 1] = DifG;


                            }
                        }
                    }
                }
            }
            for (int y = 0; y < clubs.GetLength(0); y++)
            {

                eq[y, 0] = (y + 1) + "";
                eq[y, 1] = name[y];
                eq[y, 2] = J[y] + "";
                eq[y, 3] = Pts[y] + "";
                eq[y, 4] = G[y] + "";
                eq[y, 5] = E[y] + "";
                eq[y, 6] = P[y] + "";
                eq[y, 7] = GF[y] + "";
                eq[y, 8] = GC[y] + "";
                eq[y, 9] = DG[y] + "";
            }

            return eq;

        }
    }

}
