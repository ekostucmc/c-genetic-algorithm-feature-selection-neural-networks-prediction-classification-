using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Collections;
using System.IO;
using System.Data;

namespace TreeTestConsoleApplication
{
    class Node
    {
        public string value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(string data)
        {
            this.value = data;
        }
    }

    class Program
    {
        public static int N_Ind = 55;
        public static int N_file = 47;
        public static Random ff = new Random();
        public static int r = 3;                                            // КОЛИЧЕСТВО ВХОДОВ
       
        public static string[] oper = new string[25];                       //МАССИВ ФУНКЦИЙ

        public static int kl;
        
        public static List<double> e1 = new List<double>();
        public static List<double> e11 = new List<double>();
        public static List<double> f1 = new List<double>();
        public static List<double> f11 = new List<double>();

        public static List<double> e2 = new List<double>();
        public static List<double> e22 = new List<double>();
        public static List<double> f2 = new List<double>();
        public static List<double> f22 = new List<double>();

        public static List<double> e3 = new List<double>();
        public static List<double> e33 = new List<double>();
        public static List<double> f3 = new List<double>();
        public static List<double> f33 = new List<double>();

        public static List<double> e4 = new List<double>();
        public static List<double> e44 = new List<double>();
        public static List<double> f4 = new List<double>();
        public static List<double> f44 = new List<double>();

        public static List<double> e5 = new List<double>();
        public static List<double> e55 = new List<double>();
        public static List<double> f5 = new List<double>();
        public static List<double> f55 = new List<double>();

        public static List<double> e6 = new List<double>();
        public static List<double> e66 = new List<double>();
        public static List<double> f6 = new List<double>();
        public static List<double> f66 = new List<double>();

        public static List<double> e7 = new List<double>();
        public static List<double> e77 = new List<double>();
        public static List<double> f7 = new List<double>();
        public static List<double> f77 = new List<double>();

        public static List<double> e8 = new List<double>();
        public static List<double> e88 = new List<double>();
        public static List<double> f8= new List<double>();
        public static List<double> f88 = new List<double>();

        public static List<double> e9 = new List<double>();
        public static List<double> e99 = new List<double>();
        public static List<double> f9 = new List<double>();
        public static List<double> f99 = new List<double>();

        public static List<double> e10 = new List<double>();
        public static List<double> e1010 = new List<double>();
        public static List<double> f10 = new List<double>();
        public static List<double> f1010 = new List<double>();

        public static List<double> x1_mas = new List<double>();
        public static List<double> x2_mas = new List<double>();
        public static List<double> x3_mas = new List<double>();

        public static List<double> W = new List<double>();

        public static List<double> S0 = new List<double>();
        public static List<double> x_etal = new List<double>();

        public static List<double> S = new List<double>();

        public static List<double> wNew = new List<double>();
        public static List<double> w_GA_str = new List<double>();
        public static List<double> e_new1 = new List<double>();
        public static List<double> f1_new1 = new List<double>();

        public static List<double> e_new2 = new List<double>();
        public static List<double> f1_new2 = new List<double>();

        public static List<double> e_new3 = new List<double>();
        public static List<double> f1_new3 = new List<double>();

        public static List<double> S1 = new List<double>();
        public static List<double> S2 = new List<double>();
        public static List<double> S3 = new List<double>();
        public static List<double> S4 = new List<double>();
        /////////////////////// GA //////////////////////////

        public static List<int> t = new List<int>();
        public static List<string> stroky_t = new List<string>();
        public static List<int> it_x = new List<int>();

        public static List<double> m_cod_int = new List<double>();
        public static List<double> m_cod_double = new List<double>();
        public static List<double> m_int_double = new List<double>();

        public static List<string> code_mas = new List<string>();

        public static List<string> n_mas_str = new List<string>();

        public static List<string> str_mas = new List<string>();
        public static List<int> mas_dlinna = new List<int>();

        public static int dlina_max = 0;
        public static int dlina_min = 0;

        public static List<string> rule_rek1 = new List<string>();

        public static string result;
        
        public static List<string> str_xx = new List<string>();
        public static List<string> string_xx = new List<string>();
        public static List<double> double_w = new List<double>();
        
        public static int N = 4;

        public static double S1_res = 0;
        public static double S0_res = 0;

        //////////////////////////////////////////////////
                   
        static void Main(string[] args)
        {
            for (int r = 0; r < 100; r++)
            {
                x1_mas.Add(Convert.ToDouble(ff.Next(14, 95) / 10.0));
                x2_mas.Add(Convert.ToDouble(ff.Next(12, 105) / 10.0));
                x3_mas.Add(Convert.ToDouble(ff.Next(8, 65) / 10.0));
            }

            oper[0] = "F1";
            oper[1] = "F2";
            oper[2] = "F3";
            oper[3] = "F4";
            oper[4] = "F5";
            oper[5] = "F6";
            oper[6] = "F7";
            oper[7] = "F8";
            oper[8] = "F9";

            Calcul_NN_GA();

            Console.ReadKey();
        }

        static void Calcul_NN_GA()
        {
            for (int t = 0; t < x1_mas.Count(); t++)
            {
                x_etal.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
            }

            int N1 = 1; //ff.Next(1, 4);
            int N2 = 1; //ff.Next(1, 4);
            int N3 = 1; //ff.Next(1, 4);
            int N4 = 1; // ff.Next(1, 4);
            int M = 1;  // ff.Next(1, 4);

           if(N1 == 1 || M == 1)
            {
                for (int t = 0; t < 6; t++)
                {
                    W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                    {
                        kl = ff.Next(0, 8);
                        e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                        f1.Add(Act_Fun(oper[kl], e1[p]));

                        kl = ff.Next(0, 8);
                        e2.Add(W[3] * f1[p]);
                        f2.Add(Act_Fun(oper[kl], e2[p]));

                        kl = ff.Next(0, 8);                                                                     // Сумматор 
                        e3.Add(W[4] * f2[p]);
                        f3.Add(Act_Fun(oper[kl], e3[p]));

                        S0.Add(Math.Abs(x_etal[p] - f3[p]) / f3.Count());
                    }
                    for (int op = 0; op < S0.Count(); op++)
                        S0_res += S0[op];

                    // GA //                         

                    encoding(W);
                    cod_double(W);

                    cod_mas_two();
                    recombination1(code_mas);

                    Mutation_1(rule_rek1);                  // исправить 
                    Mutation_2(rule_rek1);                  // исправить 

                    Int_dcod(string_xx);                    // double
                    Double_dcod(str_xx);                         // int

                    concat_int_double(m_cod_double, m_cod_int);

                    W.Clear();
                    for (int k = 0; k < m_int_double.Count(); k++)
                    {
                        W.Add(m_int_double[k]);
                    }
                    
                    for (int p = 0; p < x1_mas.Count(); p++)
                    {
                        e1.Clear();
                        f1.Clear();
                        e2.Clear();
                        f2.Clear();
                        e3.Clear();
                        f3.Clear();
                    }
                    
                    for (int p = 0; p < x1_mas.Count(); p++)
                    {
                        kl = ff.Next(0, 8);
                        e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                        f1.Add(Act_Fun(oper[kl], e1[p]));

                        kl = ff.Next(0, 8);
                        e2.Add(W[3] * f1[p]);
                        f2.Add(Act_Fun(oper[kl], e2[p]));

                        kl = ff.Next(0, 8);
                        e3.Add(W[4] * f2[p]);
                        f3.Add(Act_Fun(oper[kl], e3[p]));

                        S1.Add(Math.Abs(x_etal[p] - f3[p]) / f3.Count());
                    }

                    for (int op = 0; op < S1.Count(); op++)
                        S1_res += S1[op];

                    W.Clear();
                    if (S0_res < S1_res)
                        for (int k = 0; k < m_int_double.Count(); k++)
                            W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                    else
                    {
                        for (int k = 0; k < m_int_double.Count(); k++)
                        {
                            W.Add(m_int_double[k]);
                        }
                    }
                }
           }
                
                if(N1 == 2 || M == 1)
                {
                    
                    for (int t = 0; t < 10; t++)
                    {
                        W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                    }
                    // W = 9 + 1
                    for (int i = 0; i < 3; i++)
                    {
                        for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                            kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                        
                            kl = ff.Next(0, 8);
                            f11.Add(Act_Fun(oper[kl], e11[p]));

                            kl = ff.Next(0, 8);                     // М
                            e2.Add(W[6] * f1[p] + W[7] *f11[p]);
                            f2.Add(Act_Fun(oper[kl], e2[p]));

                            kl = ff.Next(0, 8);                     // сумматор
                            e3.Add(W[8] * f2[p]);
                            f3.Add(Act_Fun(oper[kl], e3[p]));
            
                            S0.Add(Math.Abs(x_etal[p] - f3[p]) / f3.Count());
                        }
                        for (int op = 0; op < S0.Count(); op++)
                            S0_res += S0[op];

                        // GA //                         

                        encoding(W);
                        cod_double(W);

                        cod_mas_two();
                        recombination1(code_mas);

                        Mutation_1(rule_rek1);                  // исправить 
                        Mutation_2(rule_rek1);                  // исправить 

                        Int_dcod(string_xx);                    // double
                        Double_dcod(str_xx);                         // int

                        concat_int_double(m_cod_double, m_cod_int);

                        W.Clear();
                        for (int k = 0; k < m_int_double.Count(); k++)
                        {
                            W.Add(m_int_double[k]);
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Clear();
                            e11.Clear();

                            f1.Clear();
                    
                            f11.Clear();

                            e2.Clear();
                            f2.Clear();

                            e3.Clear();
                            f3.Clear();            
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                            kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                    
                            kl = ff.Next(0, 8);
                            f11.Add(Act_Fun(oper[kl], e11[p]));

                            kl = ff.Next(0, 8);                     // М
                            e2.Add(W[6] * f1[p] + W[7] *f11[p]);
                            f2.Add(Act_Fun(oper[kl], e2[p]));

                            kl = ff.Next(0, 8);                     // сумматор
                            e3.Add(W[8] * f2[p]);
                            f3.Add(Act_Fun(oper[kl], e3[p]));
             
                            S1.Add(Math.Abs(x_etal[p] - f3[p]) / f3.Count());
                        }

                        for (int op = 0; op < S1.Count(); op++)
                            S1_res += S1[op];

                        W.Clear();
                        if (S0_res < S1_res)
                            for (int k = 0; k < m_int_double.Count(); k++)
                                W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                        else
                        {
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }
                        }
                    }
                }
            
                if(N1 == 2 || M == 2)
                {
                    for (int t = 0; t < 10; t++)
                    {
                        W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                            kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                        
                            kl = ff.Next(0, 8);
                            f11.Add(Act_Fun(oper[kl], e11[p]));

                            kl = ff.Next(0, 8);
                            e2.Add(W[6] * f1[p]);
                            e22.Add(W[7] * f11[p]);

                            kl = ff.Next(0, 8);
                            f2.Add(Act_Fun(oper[kl], e2[p]));                                            
                            f22.Add(Act_Fun(oper[kl], e22[p]));

                            kl = ff.Next(0, 8);                                                          
                            e3.Add(W[8] * f2[p] + W[9]*f22[p]);
                            f3.Add(Act_Fun(oper[kl], e3[p]));

                            S0.Add(Math.Abs(x_etal[p] - f3[p]) / f3.Count());
                        }
                        for (int op = 0; op < S0.Count(); op++)
                            S0_res += S0[op];

                        // GA //                         

                        encoding(W);
                        cod_double(W);

                        cod_mas_two();
                        recombination1(code_mas);

                        Mutation_1(rule_rek1);                  // исправить 
                        Mutation_2(rule_rek1);                  // исправить 

                        Int_dcod(string_xx);                    // double
                        Double_dcod(str_xx);                         // int

                        concat_int_double(m_cod_double, m_cod_int);

                        W.Clear();
                        for (int k = 0; k < m_int_double.Count(); k++)
                        {
                            W.Add(m_int_double[k]);
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Clear();
                            e11.Clear();

                            f1.Clear();

                            f11.Clear();

                            e2.Clear();
                            e22.Clear();

                            f2.Clear();                                            // M
                            f22.Clear();

                            e3.Clear();
                            f3.Clear();
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                            kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                            
                            kl = ff.Next(0, 8);
                            f11.Add(Act_Fun(oper[kl], e11[p]));

                            kl = ff.Next(0, 8);
                            e2.Add(W[6] * f1[p]);
                            e22.Add(W[7] * f11[p]);

                            kl = ff.Next(0, 8);
                            f2.Add(Act_Fun(oper[kl], e2[p]));                                            // M
                            f22.Add(Act_Fun(oper[kl], e22[p]));

                            kl = ff.Next(0, 8);                                                          // сумматор
                            e3.Add(W[8] * f2[p] + W[9]*f22[p]);
                            f3.Add(Act_Fun(oper[kl], e3[p]));

                            S1.Add(Math.Abs(x_etal[p] - f3[p]) / f3.Count());
                        }

                        for (int op = 0; op < S1.Count(); op++)
                            S1_res += S1[op];

                        W.Clear();
                        if (S0_res < S1_res)
                            for (int k = 0; k < m_int_double.Count(); k++)
                                W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                        else
                        {
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }
                        }
                    }
                }
            
                if (N1 == 3 || M == 2)
                {
                    for (int t = 0; t < 18; t++)
                    {
                        W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                            e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                            kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                            kl = ff.Next(0, 8);
                            f2.Add(Act_Fun(oper[kl], e2[p]));
                            kl = ff.Next(0, 8);
                            f3.Add(Act_Fun(oper[kl], e3[p]));

                            e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                            e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);

                            kl = ff.Next(0, 8);
                            f4.Add(Act_Fun(oper[kl], e4[p]));
                            kl = ff.Next(0, 8);
                            f5.Add(Act_Fun(oper[kl], e5[p]));

                            kl = ff.Next(0, 8);
                            e6.Add(W[15] * f4[p] + W[16] * f5[p]);                                                  // Сумматор 
                            f6.Add(Act_Fun(oper[kl], e6[p]));

                            S0.Add(Math.Abs(x_etal[p] - f6[p]) / f6.Count());
                        }
                        for (int op = 0; op < S0.Count(); op++)
                            S0_res += S0[op];

                        // GA //                         

                        encoding(W);
                        cod_double(W);

                        cod_mas_two();
                        recombination1(code_mas);

                        Mutation_1(rule_rek1);                  // исправить 
                        Mutation_2(rule_rek1);                  // исправить 

                        Int_dcod(string_xx);                    // double
                        Double_dcod(str_xx);                         // int

                        concat_int_double(m_cod_double, m_cod_int);

                        W.Clear();
                        for (int k = 0; k < m_int_double.Count(); k++)
                        {
                            W.Add(m_int_double[k]);
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Clear();
                            e2.Clear();
                            e3.Clear();

                            f1.Clear();
                            f2.Clear();
                            f3.Clear();

                            e4.Clear();
                            e5.Clear();

                            f4.Clear();
                            f5.Clear();

                            e6.Clear();                                                  // Сумматор 
                            f6.Clear();
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                            e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                            kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                            
                            kl = ff.Next(0, 8);
                            f2.Add(Act_Fun(oper[kl], e2[p]));
                            
                            kl = ff.Next(0, 8);
                            f3.Add(Act_Fun(oper[kl], e3[p]));

                            e4.Add(W[9] * f1[p] + W[10]*f2[p] + W[11]*f3[p]);
                            e5.Add(W[12] * f1[p] + W[13]*f2[p] + W[14]*f3[p]);

                            kl = ff.Next(0, 8);
                            f4.Add(Act_Fun(oper[kl], e4[p]));
                            
                            kl = ff.Next(0, 8);
                            f5.Add(Act_Fun(oper[kl], e5[p]));

                            kl = ff.Next(0, 8);
                            e6.Add(W[15] * f4[p] + W[16]*f5[p]);                                                  // Сумматор 
                            f6.Add(Act_Fun(oper[kl], e6[p]));

                            S1.Add(Math.Abs(x_etal[p] - f6[p]) / f6.Count());
                        }

                        for (int op = 0; op < S1.Count(); op++)
                            S1_res += S1[op];

                        W.Clear();
                        if (S0_res < S1_res)
                            for (int k = 0; k < m_int_double.Count(); k++)
                                W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                        else
                        {
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }
                        }
                    }
                }
            
                if (N1 == 3 || M == 3)
                {
                    
                    for (int t = 0; t < 22; t++)
                    {
                        W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                            e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                            kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                            
                            kl = ff.Next(0, 8);
                            f2.Add(Act_Fun(oper[kl], e2[p]));
                            
                            kl = ff.Next(0, 8);
                            f3.Add(Act_Fun(oper[kl], e3[p]));

                            e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                            e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);
                            e6.Add(W[15] * f1[p] + W[16] * f2[p] + W[17] * f3[p]);

                            kl = ff.Next(0, 8);
                            f4.Add(Act_Fun(oper[kl], e4[p]));
                            
                            kl = ff.Next(0, 8);
                            f5.Add(Act_Fun(oper[kl], e5[p]));
                            
                            kl = ff.Next(0, 8);
                            f6.Add(Act_Fun(oper[kl], e6[p]));

                            kl = ff.Next(0, 8);
                            e7.Add(W[18] * f4[p] + W[19] * f5[p] + W[20] * f6[p]);                                                  // Сумматор 
                            f7.Add(Act_Fun(oper[kl], e7[p]));

                            S0.Add(Math.Abs(x_etal[p] - f7[p]) / f7.Count());
                        }
                        for (int op = 0; op < S0.Count(); op++)
                            S0_res += S0[op];

                        // GA //                         

                        encoding(W);
                        cod_double(W);

                        cod_mas_two();
                        recombination1(code_mas);

                        Mutation_1(rule_rek1);                  // исправить 
                        Mutation_2(rule_rek1);                  // исправить 

                        Int_dcod(string_xx);                    // double
                        Double_dcod(str_xx);                         // int

                        concat_int_double(m_cod_double, m_cod_int);

                        W.Clear();
                        for (int k = 0; k < m_int_double.Count(); k++)
                        {
                            W.Add(m_int_double[k]);
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Clear();
                            e2.Clear();
                            e3.Clear();

                            f1.Clear();
                            f2.Clear();

                            f3.Clear();

                            e4.Clear();
                            e5.Clear();
                            e6.Clear();

                            f4.Clear();
                            f5.Clear();
                            f6.Clear();
                            e7.Clear();                                                  // Сумматор 
                            f7.Clear();
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                            e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                            kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                            
                            kl = ff.Next(0, 8);
                            f2.Add(Act_Fun(oper[kl], e2[p]));
                            
                            kl = ff.Next(0, 8);
                            f3.Add(Act_Fun(oper[kl], e3[p]));
                        
                            e4.Add(W[9] * f1[p] + W[10]*f2[p] + W[11]*f3[p]);
                            e5.Add(W[12] * f1[p] + W[13]*f2[p] + W[14]*f3[p]);
                            e6.Add(W[15] * f1[p] + W[16]*f2[p] + W[17]*f3[p]);

                            kl = ff.Next(0, 8);
                            f4.Add(Act_Fun(oper[kl], e4[p]));
                            
                            kl = ff.Next(0, 8);
                            f5.Add(Act_Fun(oper[kl], e5[p]));
                            
                            kl = ff.Next(0, 8);
                            f6.Add(Act_Fun(oper[kl], e6[p]));

                            kl = ff.Next(0, 8);
                            e7.Add(W[18] * f4[p] + W[19]*f5[p] + W[20]*f6[p]);                                                  // Сумматор 
                            f7.Add(Act_Fun(oper[kl], e7[p]));

                            S1.Add(Math.Abs(x_etal[p] - f7[p]) / f7.Count());
                        }

                        for (int op = 0; op < S1.Count(); op++)
                            S1_res += S1[op];

                        W.Clear();
                        if (S0_res < S1_res)
                            for (int k = 0; k < m_int_double.Count(); k++)
                                W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                        else
                        {
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }
                        }
                    }
                }
            
                if (N1 == 4 || M == 1)
                {
                 
                    for (int t = 0; t < 18; t++)
                    {
                        W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                            e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);
                            e4.Add(W[9] * x1_mas[p] + W[10] * x2_mas[p] + W[11] * x3_mas[p]);

                        kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                        kl = ff.Next(0, 8);
                            f2.Add(Act_Fun(oper[kl], e2[p]));
                        kl = ff.Next(0, 8);
                            f3.Add(Act_Fun(oper[kl], e3[p]));
                        kl = ff.Next(0, 8);
                            f4.Add(Act_Fun(oper[kl], e4[p]));

                            kl = ff.Next(0, 8);
                            e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p] + W[15] * f4[p]);
                            f5.Add(Act_Fun(oper[kl], e5[p]));

                            kl = ff.Next(0, 8);
                            e6.Add(W[16] * f5[p]);                                                  // Сумматор 
                            f6.Add(Act_Fun(oper[kl], e6[p]));

                            S0.Add(Math.Abs(x_etal[p] - f6[p]) / f6.Count());
                        }
                        for (int op = 0; op < S0.Count(); op++)
                            S0_res += S0[op];

                        // GA //                         

                        encoding(W);
                        cod_double(W);

                        cod_mas_two();
                        recombination1(code_mas);

                        Mutation_1(rule_rek1);                  // исправить 
                        Mutation_2(rule_rek1);                  // исправить 

                        Int_dcod(string_xx);                    // double
                        Double_dcod(str_xx);                         // int

                        concat_int_double(m_cod_double, m_cod_int);

                        W.Clear();
                        for (int k = 0; k < m_int_double.Count(); k++)
                        {
                            W.Add(m_int_double[k]);
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Clear();
                            e2.Clear();
                            e3.Clear();
                            e4.Clear();

                            f1.Clear();
                            f2.Clear();
                            f3.Clear();
                            f4.Clear();

                            e5.Clear();
                            f5.Clear();

                            e6.Clear();                                                  // Сумматор 
                            f6.Clear();
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                            e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                            e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);
                            e4.Add(W[9] * x1_mas[p] + W[10] * x2_mas[p] + W[11] * x3_mas[p]);

                            kl = ff.Next(0, 8);
                            f1.Add(Act_Fun(oper[kl], e1[p]));
                            
                            kl = ff.Next(0, 8);
                            f2.Add(Act_Fun(oper[kl], e2[p]));
                
                            kl = ff.Next(0, 8);
                            f3.Add(Act_Fun(oper[kl], e3[p]));
                            
                            kl = ff.Next(0, 8);
                            f4.Add(Act_Fun(oper[kl], e4[p]));

                            kl = ff.Next(0, 8);
                            e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p] + W[15] * f4[p]);
                            f5.Add(Act_Fun(oper[kl], e5[p]));

                            kl = ff.Next(0, 8);
                            e6.Add(W[16] * f5[p]);                                                  // Сумматор 
                            f6.Add(Act_Fun(oper[kl], e6[p]));


                            S1.Add(Math.Abs(x_etal[p] - f6[p]) / f6.Count());
                        }

                        for (int op = 0; op < S1.Count(); op++)
                            S1_res += S1[op];

                        W.Clear();
                        if (S0_res < S1_res)
                            for (int k = 0; k < m_int_double.Count(); k++)
                                W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                        else
                        {
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }
                        }
                    }
            
                }
       
               // int N2 = 1;
               if(N1 == 1 || N2 == 1 || M == 1)
                    {
                        for (int t = 0; t < 6; t++)
                        {
                            W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                            {
                                kl = ff.Next(0, 8);
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]); // N1
                                f1.Add(Act_Fun(oper[kl], e1[p]));

                                kl = ff.Next(0, 8);                                                             // N1 
                                e2.Add(W[3] * f1[p]);
                                f2.Add(Act_Fun(oper[kl], e2[p]));

                                kl = ff.Next(0, 8);                                                             // N2 
                                e3.Add(W[4] * f1[p]);
                                f3.Add(Act_Fun(oper[kl], e3[p]));

                                kl = ff.Next(0, 8);                                                             // M                                                                   
                                e4.Add(W[5] * f3[p]);
                                f4.Add(Act_Fun(oper[kl], e4[p]));

                                S0.Add(Math.Abs(x_etal[p] - f4[p]) / f4.Count());
                            }
                            for (int op = 0; op < S0.Count(); op++)
                                S0_res += S0[op];

                            // GA //                         

                            encoding(W);
                            cod_double(W);

                            cod_mas_two();
                            recombination1(code_mas);

                            Mutation_1(rule_rek1);                  // исправить 
                            Mutation_2(rule_rek1);                  // исправить 

                            Int_dcod(string_xx);                    // double
                            Double_dcod(str_xx);                         // int

                            concat_int_double(m_cod_double, m_cod_int);

                            W.Clear();
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Clear(); // N1
                                f1.Clear();

                                e2.Clear();
                                f2.Clear();

                                e3.Clear();
                                f3.Clear();

                                e4.Clear();
                                f4.Clear();
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                kl = ff.Next(0, 8);
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]); // N1
                                f1.Add(Act_Fun(oper[kl], e1[p]));

                                kl = ff.Next(0, 8);                                                             // N1 
                                e2.Add(W[3] * f1[p]);
                                f2.Add(Act_Fun(oper[kl], e2[p]));

                                kl = ff.Next(0, 8);                                                             // N2 
                                e3.Add(W[4] * f2[p]);
                                f3.Add(Act_Fun(oper[kl], e3[p]));

                                kl = ff.Next(0, 8);                                                             // M                                                                   
                                e4.Add(W[5] * f3[p]);
                                f4.Add(Act_Fun(oper[kl], e4[p]));

                                S1.Add(Math.Abs(x_etal[p] - f4[p]) / f4.Count());
                            }

                            for (int op = 0; op < S1.Count(); op++)
                                S1_res += S1[op];

                            W.Clear();
                            if (S0_res < S1_res)
                                for (int k = 0; k < m_int_double.Count(); k++)
                                    W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                            else
                            {
                                for (int k = 0; k < m_int_double.Count(); k++)
                                {
                                    W.Add(m_int_double[k]);
                                }
                            }
                        }
                    }

                 if (N1 == 2 || N2 == 1 || M == 1)
                    {
                    
                        for (int t = 0; t < 10; t++)
                        {
                            W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                        }
                   
                        for (int i = 0; i < 3; i++)
                        {
                            for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                            {
                                kl = ff.Next(0, 8);
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                                f11.Add(Act_Fun(oper[kl], e11[p]));

                                kl = ff.Next(0, 8);                     // N1
                                e2.Add(W[6] * f1[p] + W[7] *f11[p]);
                                f2.Add(Act_Fun(oper[kl], e2[p]));

                                kl = ff.Next(0, 8);                     // N2
                                e3.Add(W[8] * f2[p]);
                                f3.Add(Act_Fun(oper[kl], e3[p]));

                                kl = ff.Next(0, 8);                     // сумматор
                                e4.Add(W[9] * f3[p]);
                                f4.Add(Act_Fun(oper[kl], e4[p]));

                                S0.Add(Math.Abs(x_etal[p] - f4[p]) / f4.Count());
                            }
                            for (int op = 0; op < S0.Count(); op++)
                                S0_res += S0[op];

                            // GA //                         

                            encoding(W);
                            cod_double(W);

                            cod_mas_two();
                            recombination1(code_mas);

                            Mutation_1(rule_rek1);                  // исправить 
                            Mutation_2(rule_rek1);                  // исправить 

                            Int_dcod(string_xx);                    // double
                            Double_dcod(str_xx);                         // int

                            concat_int_double(m_cod_double, m_cod_int);

                            W.Clear();
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Clear();
                                e11.Clear();

                                f1.Clear();
                                f11.Clear();

                                e2.Clear();
                                f2.Clear();

                                e3.Clear();
                                f3.Clear();

                                e4.Clear();
                                f4.Clear();
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                kl = ff.Next(0, 8);
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                                f11.Add(Act_Fun(oper[kl], e11[p]));

                                kl = ff.Next(0, 8);                     // N1
                                e2.Add(W[6] * f1[p] + W[7] * f11[p]);
                                f2.Add(Act_Fun(oper[kl], e2[p]));

                                kl = ff.Next(0, 8);                     // N2
                                e3.Add(W[8] * f2[p]);
                                f3.Add(Act_Fun(oper[kl], e3[p]));

                                kl = ff.Next(0, 8);                     // сумматор
                                e4.Add(W[9] * f3[p]);
                                f4.Add(Act_Fun(oper[kl], e4[p]));

                                S1.Add(Math.Abs(x_etal[p] - f4[p]) / f4.Count());
                            }

                            for (int op = 0; op < S1.Count(); op++)
                                S1_res += S1[op];

                            W.Clear();
                            if (S0_res < S1_res)
                                for (int k = 0; k < m_int_double.Count(); k++)
                                    W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                            else
                            {
                                for (int k = 0; k < m_int_double.Count(); k++)
                                {
                                    W.Add(m_int_double[k]);
                                }
                            }
                        }
                    }

                 if (N1 == 2 || N2 == 1 || M == 2)
                    {
                        for (int t = 0; t < 12; t++)
                        {
                            W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                            {
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                                
                                kl = ff.Next(0, 8);
                                f11.Add(Act_Fun(oper[kl], e11[p]));

                                kl = ff.Next(0, 8);
                                e2.Add(W[6] * f1[p]);
                                e22.Add(W[7] * f11[p]);     // N1

                                kl = ff.Next(0, 8);
                                f2.Add(Act_Fun(oper[kl], e2[p]));    // M
                                f22.Add(Act_Fun(oper[kl], e22[p]));

                                kl = ff.Next(0, 8);
                                e3.Add(W[8] * f2[p] + W[9] * f22[p]);    // M
                                f33.Add(Act_Fun(oper[kl], e3[p]));


                                kl = ff.Next(0, 8);                  // сумматор
                                e4.Add(W[10] * (f33[p]));
                                f4.Add(Act_Fun(oper[kl], e4[p]));

                                S0.Add(Math.Abs(x_etal[p] - f4[p]) / f4.Count());
                            }
                            for (int op = 0; op < S0.Count(); op++)
                                S0_res += S0[op];

                            // GA //                         

                            encoding(W);
                            cod_double(W);

                            cod_mas_two();
                            recombination1(code_mas);

                            Mutation_1(rule_rek1);                  // исправить 
                            Mutation_2(rule_rek1);                  // исправить 

                            Int_dcod(string_xx);                    // double
                            Double_dcod(str_xx);                         // int

                            concat_int_double(m_cod_double, m_cod_int);

                            W.Clear();
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Clear();
                                e11.Clear();

                                f1.Clear();

                                f11.Clear();

                                e2.Clear();
                                e22.Clear();     // N1

                                f2.Clear();    // M
                                f22.Clear();

                                e3.Clear();    // M
                                f33.Clear();

                                e4.Clear();
                                f4.Clear();
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                                
                                kl = ff.Next(0, 8);
                                f11.Add(Act_Fun(oper[kl], e11[p]));

                                kl = ff.Next(0, 8);
                                e2.Add(W[6] * f1[p]);
                                e22.Add(W[7] * f11[p]);     // N1

                                kl = ff.Next(0, 8);
                                f2.Add(Act_Fun(oper[kl], e2[p]));    // M
                                f22.Add(Act_Fun(oper[kl], e22[p]));

                                kl = ff.Next(0, 8);
                                e3.Add(W[8] * f2[p] + W[9] * f22[p]);    // M
                                f33.Add(Act_Fun(oper[kl], e3[p]));


                                kl = ff.Next(0, 8);                  // сумматор
                                e4.Add(W[10] * (f33[p]));
                                f4.Add(Act_Fun(oper[kl], e4[p]));

                                S1.Add(Math.Abs(x_etal[p] - f4[p]) / f4.Count());
                            }

                            for (int op = 0; op < S1.Count(); op++)
                                S1_res += S1[op];

                            W.Clear();
                            if (S0_res < S1_res)
                                for (int k = 0; k < m_int_double.Count(); k++)
                                    W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                            else
                            {
                                for (int k = 0; k < m_int_double.Count(); k++)
                                {
                                    W.Add(m_int_double[k]);
                                }
                            }
                        }
                    }

                 if (N1 == 3 || N2 == 1 || M == 2)
                    {
                        for (int t = 0; t < 18; t++)
                        {
                            W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                            {
                          
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                                kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                                
                                kl = ff.Next(0, 8);
                                f2.Add(Act_Fun(oper[kl], e2[p]));
                                
                                kl = ff.Next(0, 8);
                                f3.Add(Act_Fun(oper[kl], e3[p]));

                                kl = ff.Next(0, 8);
                                e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);

                                kl = ff.Next(0, 8);
                                f4.Add(Act_Fun(oper[kl], e4[p]));
                                
                                kl = ff.Next(0, 8);
                                f5.Add(Act_Fun(oper[kl], e5[p]));

                                kl = ff.Next(0, 8);
                                e6.Add(W[15] * f4[p] + W[16] * f5[p]);
                                f6.Add(Act_Fun(oper[kl], e6[p]));

                                kl = ff.Next(0, 8);
                                e7.Add(W[17] * f6[p]);                                                  // Сумматор 
                                f7.Add(Act_Fun(oper[kl], e7[p]));

                                S0.Add(Math.Abs(x_etal[p] - f7[p]) / f7.Count());
                            }
                            for (int op = 0; op < S0.Count(); op++)
                                S0_res += S0[op];

                            // GA //                         

                            encoding(W);
                            cod_double(W);

                            cod_mas_two();
                            recombination1(code_mas);

                            Mutation_1(rule_rek1);                  // исправить 
                            Mutation_2(rule_rek1);                  // исправить 

                            Int_dcod(string_xx);                    // double
                            Double_dcod(str_xx);                         // int

                            concat_int_double(m_cod_double, m_cod_int);

                            W.Clear();
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Clear();
                                e2.Clear();
                                e3.Clear();

                                f1.Clear();

                                f2.Clear();

                                f3.Clear();
                                e4.Clear();
                                e5.Clear();

                                f4.Clear();
                                f5.Clear();
                                e6.Clear();
                                f6.Clear();
                                e7.Clear();                                                  // Сумматор 
                                f7.Clear();
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                                kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                                
                                kl = ff.Next(0, 8);
                                f2.Add(Act_Fun(oper[kl], e2[p]));
                                
                                kl = ff.Next(0, 8);
                                f3.Add(Act_Fun(oper[kl], e3[p]));

                                kl = ff.Next(0, 8);
                                e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);

                                kl = ff.Next(0, 8);
                                f4.Add(Act_Fun(oper[kl], e4[p]));
                                f5.Add(Act_Fun(oper[kl], e5[p]));

                                kl = ff.Next(0, 8);
                                e6.Add(W[15] * f4[p] + W[16] * f5[p]);
                                f6.Add(Act_Fun(oper[kl], e6[p]));

                                kl = ff.Next(0, 8);
                                e7.Add(W[17] * f6[p]);                                                  // Сумматор 
                                f7.Add(Act_Fun(oper[kl], e7[p]));

                                S1.Add(Math.Abs(x_etal[p] - f7[p]) / f7.Count());
                            }

                            for (int op = 0; op < S1.Count(); op++)
                                S1_res += S1[op];

                            W.Clear();
                            if (S0_res < S1_res)
                                for (int k = 0; k < m_int_double.Count(); k++)
                                    W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                            else
                            {
                                for (int k = 0; k < m_int_double.Count(); k++)
                                {
                                    W.Add(m_int_double[k]);
                                }
                            }
                        }
                    }
            
                 if (N1 == 3 || N2 == 1 || M == 3)
                    {                    
                        for (int t = 0; t < 22; t++)
                        {
                            W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                            {             
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                                kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                                
                                kl = ff.Next(0,8);
                                f2.Add(Act_Fun(oper[kl], e2[p]));
                                
                                kl = ff.Next(0, 8);
                                f3.Add(Act_Fun(oper[kl], e3[p]));

                                e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);
                                e6.Add(W[15] * f1[p] + W[16] * f2[p] + W[17] * f3[p]);

                                kl = ff.Next(0, 8);
                                f4.Add(Act_Fun(oper[kl], e4[p]));
                                
                                kl = ff.Next(0, 8);
                                f5.Add(Act_Fun(oper[kl], e5[p]));
                                
                                kl = ff.Next(0, 8);
                                f6.Add(Act_Fun(oper[kl], e6[p]));

                                kl = ff.Next(0, 8);
                                e7.Add(W[18] * f4[p] + W[19] * f5[p] + W[20] * f6[p]);
                                f7.Add(Act_Fun(oper[kl], e7[p]));

                                kl = ff.Next(0, 8);
                                e8.Add(W[21] * f7[p]);                                                  // Сумматор 
                                f8.Add(Act_Fun(oper[kl], e8[p]));

                                S0.Add(Math.Abs(x_etal[p] - f8[p]) / f8.Count());
                            }
                            for (int op = 0; op < S0.Count(); op++)
                                S0_res += S0[op];

                            // GA //                         

                            encoding(W);
                            cod_double(W);

                            cod_mas_two();
                            recombination1(code_mas);

                            Mutation_1(rule_rek1);                  // исправить 
                            Mutation_2(rule_rek1);                  // исправить 

                            Int_dcod(string_xx);                    // double
                            Double_dcod(str_xx);                         // int

                            concat_int_double(m_cod_double, m_cod_int);

                            W.Clear();
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Clear();
                                e2.Clear();
                                e3.Clear();

                                f1.Clear();

                                f2.Clear();

                                f3.Clear();

                                e4.Clear();
                                e5.Clear();
                                e6.Clear();

                                f4.Clear();
                                f5.Clear();
                                f6.Clear();
                                e7.Clear();
                                f7.Clear();
                                e8.Clear();                                                  // Сумматор 
                                f8.Clear();
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                                kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                                
                                kl = ff.Next(0, 8);
                                f2.Add(Act_Fun(oper[kl], e2[p]));
                                
                                kl = ff.Next(0, 8);
                                f3.Add(Act_Fun(oper[kl], e3[p]));

                                e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);
                                e6.Add(W[15] * f1[p] + W[16] * f2[p] + W[17] * f3[p]);

                                kl = ff.Next(0, 8);
                                f4.Add(Act_Fun(oper[kl], e4[p]));
                                
                                kl = ff.Next(0, 8);
                                f5.Add(Act_Fun(oper[kl], e5[p]));
                                
                                kl = ff.Next(0, 8);
                                f6.Add(Act_Fun(oper[kl], e6[p]));

                                kl = ff.Next(0, 8);
                                e7.Add(W[18] * f4[p] + W[19] * f5[p] + W[20] * f6[p]);
                                f7.Add(Act_Fun(oper[kl], e7[p]));

                                kl = ff.Next(0, 8);
                                e8.Add(W[21] * f7[p]);                                                  // Сумматор 
                                f8.Add(Act_Fun(oper[kl], e8[p]));

                                S1.Add(Math.Abs(x_etal[p] - f8[p]) / f8.Count());
                            }

                            for (int op = 0; op < S1.Count(); op++)
                                S1_res += S1[op];

                            W.Clear();
                            if (S0_res < S1_res)
                                for (int k = 0; k < m_int_double.Count(); k++)
                                    W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                            else
                            {
                                for (int k = 0; k < m_int_double.Count(); k++)
                                {
                                    W.Add(m_int_double[k]);
                                }
                            }
                        }
                    }
            
                 if (N1 == 4 || N2 == 1 || M == 1)
                    {
                        for (int t = 0; t < 18; t++)
                        {
                            W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                            {
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);
                                e4.Add(W[9] * x1_mas[p] + W[10] * x2_mas[p] + W[11] * x3_mas[p]);

                 kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                 kl = ff.Next(0, 8);
                                f2.Add(Act_Fun(oper[kl], e2[p]));
                 kl = ff.Next(0, 8);
                                f3.Add(Act_Fun(oper[kl], e3[p]));
                 kl = ff.Next(0, 8);
                                f4.Add(Act_Fun(oper[kl], e4[p]));

                                kl = ff.Next(0, 8);
                                e5.Add(W[12] * f1[p] + W[13]*f2[p] + W[14]*f3[p] + W[15]*f4[p]);
                                f5.Add(Act_Fun(oper[kl], e5[p]));

                                kl = ff.Next(0, 8);
                                e6.Add(W[16] * f5[p]);
                                f6.Add(Act_Fun(oper[kl], e6[p]));
                            
                                kl = ff.Next(0, 8);
                                e7.Add(W[17] * f6[p]);                                                  // Сумматор 
                                f7.Add(Act_Fun(oper[kl], e7[p]));

                                S0.Add(Math.Abs(x_etal[p] - f7[p]) / f7.Count());
                            }
                            for (int op = 0; op < S0.Count(); op++)
                                S0_res += S0[op];

                            // GA //                         

                            encoding(W);
                            cod_double(W);

                            cod_mas_two();
                            recombination1(code_mas);

                            Mutation_1(rule_rek1);                  // исправить 
                            Mutation_2(rule_rek1);                  // исправить 

                            Int_dcod(string_xx);                    // double
                            Double_dcod(str_xx);                         // int

                            concat_int_double(m_cod_double, m_cod_int);

                            W.Clear();
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Clear();
                                e2.Clear();
                                e3.Clear();
                                e4.Clear();

                                f1.Clear();
                                f2.Clear();
                                f3.Clear();
                                f4.Clear();
                                e5.Clear();
                                f5.Clear();
                                e6.Clear();
                                f6.Clear();
                                e7.Clear();                                                  // Сумматор 
                                f7.Clear();
                            }

                            for (int p = 0; p < x1_mas.Count(); p++)
                            {
                                e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);
                                e4.Add(W[9] * x1_mas[p] + W[10] * x2_mas[p] + W[11] * x3_mas[p]);

                 kl = ff.Next(0, 8);
                                f1.Add(Act_Fun(oper[kl], e1[p]));
                 kl = ff.Next(0, 8);
                                f2.Add(Act_Fun(oper[kl], e2[p]));
                 kl = ff.Next(0, 8);
                                f3.Add(Act_Fun(oper[kl], e3[p]));
                 kl = ff.Next(0, 8);
                                f4.Add(Act_Fun(oper[kl], e4[p]));

                                kl = ff.Next(0, 8);
                                e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p] + W[15] * f4[p]);
                                f5.Add(Act_Fun(oper[kl], e5[p]));

                                    kl = ff.Next(0, 8);
                                e6.Add(W[16] * f5[p]);
                                f6.Add(Act_Fun(oper[kl], e6[p]));

                                kl = ff.Next(0, 8);
                                e7.Add(W[17] * f6[p]);                                                  // Сумматор 
                                f7.Add(Act_Fun(oper[kl], e7[p]));

                                S1.Add(Math.Abs(x_etal[p] - f7[p]) / f7.Count());
                            }

                            for (int op = 0; op < S1.Count(); op++)
                                S1_res += S1[op];

                            W.Clear();
                            if (S0_res < S1_res)
                                for (int k = 0; k < m_int_double.Count(); k++)
                                    W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                            else
                            {
                                for (int k = 0; k < m_int_double.Count(); k++)
                                {
                                    W.Add(m_int_double[k]);
                                }
                            }
                        }
                    }
            
                // int N3 = 1;
             //   int N2 = 1; 
                if (N1 == 1 || N2 == 1 || N3 == 1 || M == 1)
                 {
                     for (int t = 0; t < 8; t++)
                     {
                         W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                     }

                     for (int i = 0; i < 3; i++)
                     {
                         for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                         {
                             kl = ff.Next(0, 8);
                             e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]); // N1
                             f1.Add(Act_Fun(oper[kl], e1[p]));

                             kl = ff.Next(0, 8);                                                             // N1 
                             e2.Add(W[3] * f1[p]);
                             f2.Add(Act_Fun(oper[kl], e2[p]));

                             kl = ff.Next(0, 8);                                                             // N2 
                             e3.Add(W[4] * f2[p]);
                             f3.Add(Act_Fun(oper[kl], e3[p]));

                             kl = ff.Next(0, 8);                                                             // N2 
                             e4.Add(W[5] * f3[p]);
                             f4.Add(Act_Fun(oper[kl], e4[p]));

                             kl = ff.Next(0, 8);                                                             // M                                                                   
                             e5.Add(W[6] * f4[p]);
                             f5.Add(Act_Fun(oper[kl], e5[p]));

                             S0.Add(Math.Abs(x_etal[p] - f5[p]) / f5.Count());
                         }
                         for (int op = 0; op < S0.Count(); op++)
                             S0_res += S0[op];

                         // GA //                         

                         encoding(W);
                         cod_double(W);

                         cod_mas_two();
                         recombination1(code_mas);

                         Mutation_1(rule_rek1);                  // исправить 
                         Mutation_2(rule_rek1);                  // исправить 

                         Int_dcod(string_xx);                    // double
                         Double_dcod(str_xx);                         // int

                         concat_int_double(m_cod_double, m_cod_int);

                         W.Clear();
                         for (int k = 0; k < m_int_double.Count(); k++)
                         {
                             W.Add(m_int_double[k]);
                         }

                         for (int p = 0; p < x1_mas.Count(); p++)
                         {
                             e1.Clear(); // N1
                             f1.Clear();

                             e2.Clear();
                             f2.Clear();
                             e3.Clear();
                             f3.Clear();
                             e4.Clear();
                             f4.Clear();
                             e5.Clear();
                             f5.Clear();
                         }

                         for (int p = 0; p < x1_mas.Count(); p++)
                         {
                             kl = ff.Next(0, 8);
                             e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]); // N1
                             f1.Add(Act_Fun(oper[kl], e1[p]));

                             kl = ff.Next(0, 8);                                                             // N1 
                             e2.Add(W[3] * f1[p]);
                             f2.Add(Act_Fun(oper[kl], e2[p]));

                             kl = ff.Next(0, 8);                                                             // N2 
                             e3.Add(W[4] * f2[p]);
                             f3.Add(Act_Fun(oper[kl], e3[p]));

                             kl = ff.Next(0, 8);                                                             // N2 
                             e4.Add(W[5] * f3[p]);
                             f4.Add(Act_Fun(oper[kl], e4[p]));

                             kl = ff.Next(0, 8);                                                             // M                                                                   
                             e5.Add(W[6] * f4[p]);
                             f5.Add(Act_Fun(oper[kl], e5[p]));

                             S1.Add(Math.Abs(x_etal[p] - f5[p]) / f5.Count());
                         }

                         for (int op = 0; op < S1.Count(); op++)
                             S1_res += S1[op];

                         W.Clear();
                         if (S0_res < S1_res)
                             for (int k = 0; k < m_int_double.Count(); k++)
                                 W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                         else
                         {
                             for (int k = 0; k < m_int_double.Count(); k++)
                             {
                                 W.Add(m_int_double[k]);
                             }
                         }
                     }
                 }
                
                            if (N1 == 2 || N2 == 1 || N3 == 1 || M == 1)
                             {

                                 for (int t = 0; t < 12; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }
                
                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                    
                                            kl = ff.Next(0, 8);
                                         f11.Add(Act_Fun(oper[kl], e11[p]));

                                         kl = ff.Next(0, 8);                     // N1
                                         e2.Add(W[6] * f1[p] + W[7] * f11[p]);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));

                                         kl = ff.Next(0, 8);                     // N2
                                         e3.Add(W[8] * f2[p]);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));


                                         kl = ff.Next(0, 8);                     // N2
                                         e4.Add(W[9] * f3[p]);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);                     // сумматор
                                         e5.Add(W[10] * f4[p]);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f5[p]) / f5.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Clear();
                                         e11.Clear();

                                         f1.Clear();

                                         f11.Clear();

                                         e2.Clear();
                                         f2.Clear();

                                         e3.Clear();
                                         f3.Clear();

                                         e4.Clear();
                                         f4.Clear();
                                         e5.Clear();
                                         f5.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                
                                         kl = ff.Next(0, 8);
                                         f11.Add(Act_Fun(oper[kl], e11[p]));

                                         kl = ff.Next(0, 8);                     // N1
                                         e2.Add(W[6] * f1[p] + W[7] * f11[p]);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));

                                         kl = ff.Next(0, 8);                     // N2
                                         e3.Add(W[8] * f2[p]);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));


                                         kl = ff.Next(0, 8);                     // N2
                                         e4.Add(W[9] * f3[p]);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);                     // сумматор
                                         e5.Add(W[10] * f4[p]);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f5[p]) / f5.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }
                            
                            if (N1 == 2 || N2 == 1 || N3 == 1 || M == 2)
                             {
                                 for (int t = 0; t < 12; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }

                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         
                                         kl = ff.Next(0, 8);
                                         f11.Add(Act_Fun(oper[kl], e11[p]));

                                         kl = ff.Next(0, 8);
                                         e2.Add(W[6] * f1[p]);
                                         e22.Add(W[7] * f11[p]);                                        // N1

                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));                              // M
                                         f22.Add(Act_Fun(oper[kl], e22[p]));

                                         kl = ff.Next(0, 8);
                                         e3.Add(W[8] * f2[p] + W[9] * f22[p]);                              // M
                                         f33.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);
                                         e4.Add(W[10] * f33[p]);                          // M
                                         f44.Add(Act_Fun(oper[kl], e4[p]));


                                         kl = ff.Next(0, 8);                  // сумматор
                                         e5.Add(W[11] * (f44[p]));
                                         f55.Add(Act_Fun(oper[kl], e5[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f55[p]) / f55.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Clear();
                                         e11.Clear();

                                         f1.Clear();
                                         f11.Clear();
                                         e2.Clear();
                                         e22.Clear();                                        // N1

                                         f2.Clear();                              // M
                                         f22.Clear();
                                         e3.Clear();                              // M
                                         f33.Clear();
                                         e4.Clear();                          // M
                                         f44.Clear();
                                         e5.Clear();
                                         f55.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                            kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         
                                         kl = ff.Next(0, 8);
                                         f11.Add(Act_Fun(oper[kl], e11[p]));

                                         kl = ff.Next(0, 8);
                                         e2.Add(W[6] * f1[p]);
                                         e22.Add(W[7] * f11[p]);                                        // N1

                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));                              // M
                                         f22.Add(Act_Fun(oper[kl], e22[p]));

                                         kl = ff.Next(0, 8);
                                         e3.Add(W[8]*f2[p] + W[9]*f22[p]);                              // M
                                         f33.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);
                                         e4.Add(W[10] * f33[p]);                          // M
                                         f44.Add(Act_Fun(oper[kl], e4[p]));


                                         kl = ff.Next(0, 8);                  // сумматор
                                         e5.Add(W[11] * (f44[p]));
                                         f55.Add(Act_Fun(oper[kl], e5[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f55[p]) / f55.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }
                            
                            if (N1 == 3 || N2 == 1 || N3 == 1 || M == 2)
                             {
                                 for (int t = 0; t < 20; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }

                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                 kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                 kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                 kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);
                                         e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);

                 kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                 kl = ff.Next(0, 8);
                                         e6.Add(W[15] * f4[p] + W[16] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                 kl = ff.Next(0, 8);
                                         e7.Add(W[17] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[18] * f7[p]);                                                  // Сумматор 
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f8[p]) / f8.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Clear();
                                         e2.Clear();
                                         e3.Clear();

                                         f1.Clear();
                                         f2.Clear();
                                         f3.Clear();

                                         e4.Clear();
                                         e5.Clear();
                                         f4.Clear();
                                         f5.Clear();
                                         e6.Clear();
                                         f6.Clear();
                                         e7.Clear();
                                         f7.Clear();
                                         e8.Clear();                                                  // Сумматор 
                                         f8.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     { 
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                 kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                 kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                 kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);
                                         e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);

                 kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                 kl = ff.Next(0, 8);
                                         e6.Add(W[15] * f4[p] + W[16] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                 kl = ff.Next(0, 8);
                                         e7.Add(W[17] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[18] * f7[p]);                                                  // Сумматор 
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f8[p]) / f8.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }
        
                            if (N1 == 3 || N2 == 1 || N3 == 1 || M == 3)
                             {
                                 for (int t = 0; t < 24; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }

                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                 kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                 kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                 kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);
                                         e6.Add(W[15] * f1[p] + W[16] * f2[p] + W[17] * f3[p]);

                 kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));
                 kl = ff.Next(0, 8);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));
                 kl = ff.Next(0, 8);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                 kl = ff.Next(0, 8);
                                         e7.Add(W[18] * f4[p] + W[19] * f5[p] + W[20] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                 kl = ff.Next(0, 8);
                                         e8.Add(W[21] * f7[p]);
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         kl = ff.Next(0, 8);
                                         e9.Add(W[22] * f8[p]);                                                  // Сумматор 
                                         f9.Add(Act_Fun(oper[kl], e9[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f9[p]) / f9.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Clear();
                                         e2.Clear();
                                         e3.Clear();

                                         f1.Clear();
                                         f2.Clear();
                                         f3.Clear();

                                         e4.Clear();
                                         e5.Clear();
                                         e6.Clear();

                                         f4.Clear();
                                         f5.Clear();
                                         f6.Clear();

                                         e7.Clear();
                                         f7.Clear();
                                         e8.Clear();
                                         f8.Clear();

                                         e9.Clear();                                                  // Сумматор 
                                         f9.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                                    kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                    kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                                    kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);
                                         e6.Add(W[15] * f1[p] + W[16] * f2[p] + W[17] * f3[p]);
                                        
                                            kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));
                                        
                                            kl = ff.Next(0, 8);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));
                                     
                                         kl = ff.Next(0, 8);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         kl = ff.Next(0, 8);
                                         e7.Add(W[18] * f4[p] + W[19] * f5[p] + W[20] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[21] * f7[p]);
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         kl = ff.Next(0, 8);
                                         e9.Add(W[22] * f8[p]);                                                  // Сумматор 
                                         f9.Add(Act_Fun(oper[kl], e9[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f9[p]) / f9.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }
                
                            if (N1 == 4 || N2 == 1 || N3 == 1 || M == 1)
                             {
                                 for (int t = 0; t < 20; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }

                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);
                                         e4.Add(W[9] * x1_mas[p] + W[10] * x2_mas[p] + W[11] * x3_mas[p]);
                                
                                    kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                    kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                                    kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));
                                    kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p] + W[15] * f4[p]);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                                         e6.Add(W[16] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         e7.Add(W[17] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[18] * f7[p]);                                                  // Сумматор 
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f8[p]) / f8.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                          e1.Clear();
                                         e2.Clear();
                                         e3.Clear();
                                         e4.Clear();
                                
                                         f1.Clear();
                                         f2.Clear();
                                    
                                         f3.Clear();
                                    
                                         f4.Clear();
                                        e5.Clear();
                                         f5.Clear();

                                         e6.Clear();
                                         f6.Clear();

                                         e7.Clear();
                                         f7.Clear();
                                         e8.Clear();                                                  // Сумматор 
                                         f8.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);
                                         e4.Add(W[9] * x1_mas[p] + W[10] * x2_mas[p] + W[11] * x3_mas[p]);

                                            kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                            kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                                            kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));
                                            kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p] + W[15] * f4[p]);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));
           
                  kl = ff.Next(0, 8);
                                         e6.Add(W[16] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                  kl = ff.Next(0, 8);
                                         e7.Add(W[17] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[18] * f7[p]);                                                  // Сумматор 
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f8[p]) / f8.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }
                        
         //     int N3 = 1;
         //     int N2 = 1;
         //       int N4 = 1;
                if (N1 == 1 || N2 == 1 || N3 == 1 || N4 == 1 || M == 1)
                {
                    for (int t = 0; t < 8; t++)
                    {
                        W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                        {
                            kl = ff.Next(0, 8);
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]); // N1
                            f1.Add(Act_Fun(oper[kl], e1[p]));

                            kl = ff.Next(0, 8);                                                             // N1 
                            e2.Add(W[3] * f1[p]);
                            f2.Add(Act_Fun(oper[kl], e2[p]));

                            kl = ff.Next(0, 8);                                                             // N2 
                            e3.Add(W[4] * f2[p]);
                            f3.Add(Act_Fun(oper[kl], e3[p]));

                            kl = ff.Next(0, 8);                                                             // N2 
                            e4.Add(W[5] * f3[p]);
                            f4.Add(Act_Fun(oper[kl], e4[p]));

                            kl = ff.Next(0, 8);                                                             // N2 
                            e5.Add(W[6] * f4[p]);
                            f5.Add(Act_Fun(oper[kl], e5[p]));

                            kl = ff.Next(0, 8);                                                             // M                                                                   
                            e6.Add(W[7] * f5[p]);
                            f6.Add(Act_Fun(oper[kl], e6[p]));

                            S0.Add(Math.Abs(x_etal[p] - f6[p]) / f6.Count());
                        }
                        for (int op = 0; op < S0.Count(); op++)
                            S0_res += S0[op];

                        // GA //                         

                        encoding(W);
                        cod_double(W);

                        cod_mas_two();
                        recombination1(code_mas);

                        Mutation_1(rule_rek1);                  // исправить 
                        Mutation_2(rule_rek1);                  // исправить 

                        Int_dcod(string_xx);                    // double
                        Double_dcod(str_xx);                         // int

                        concat_int_double(m_cod_double, m_cod_int);

                        W.Clear();
                        for (int k = 0; k < m_int_double.Count(); k++)
                        {
                            W.Add(m_int_double[k]);
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            e1.Clear(); // N1
                            f1.Clear();

                            e2.Clear();
                            f2.Clear();
                            e3.Clear();
                            f3.Clear();

                            e4.Clear();
                            f4.Clear();
                            e5.Clear();
                            f5.Clear();
                            e6.Clear();
                            f6.Clear();
                        }

                        for (int p = 0; p < x1_mas.Count(); p++)
                        {
                            kl = ff.Next(0, 8);
                            e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]); // N1
                            f1.Add(Act_Fun(oper[kl], e1[p]));

                            kl = ff.Next(0, 8);                                                             // N1 
                            e2.Add(W[3] * f1[p]);
                            f2.Add(Act_Fun(oper[kl], e2[p]));

                            kl = ff.Next(0, 8);                                                             // N2 
                            e3.Add(W[4] * f2[p]);
                            f3.Add(Act_Fun(oper[kl], e3[p]));

                            kl = ff.Next(0, 8);                                                             // N2 
                            e4.Add(W[5] * f3[p]);
                            f4.Add(Act_Fun(oper[kl], e4[p]));

                            kl = ff.Next(0, 8);                                                             // N2 
                            e5.Add(W[6] * f4[p]);
                            f5.Add(Act_Fun(oper[kl], e5[p]));

                            kl = ff.Next(0, 8);                                                             // M                                                                   
                            e6.Add(W[7] * f5[p]);
                            f6.Add(Act_Fun(oper[kl], e6[p]));

                            S1.Add(Math.Abs(x_etal[p] - f6[p]) / f6.Count());
                        }

                        for (int op = 0; op < S1.Count(); op++)
                            S1_res += S1[op];

                        W.Clear();
                        if (S0_res < S1_res)
                            for (int k = 0; k < m_int_double.Count(); k++)
                                W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                        else
                        {
                            for (int k = 0; k < m_int_double.Count(); k++)
                            {
                                W.Add(m_int_double[k]);
                            }
                        }
                    }
                }
            
                            if (N1 == 2 || N2 == 1 || N3 == 1 || N4 == 1 || M == 1)
                             {

                                 for (int t = 0; t < 12; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }
                
                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f11.Add(Act_Fun(oper[kl], e11[p]));

                                         kl = ff.Next(0, 8);                     // N1
                                         e2.Add(W[6] * f1[p] + W[7] * f11[p]);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));

                                         kl = ff.Next(0, 8);                     // N2
                                         e3.Add(W[8] * f2[p]);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);                     // N2
                                         e4.Add(W[9] * f3[p]);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);                     // N2
                                         e5.Add(W[10] * f4[p]);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                                         kl = ff.Next(0, 8);                     // сумматор
                                         e6.Add(W[11] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f6[p]) / f6.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Clear();
                                         e11.Clear();

                                         f1.Clear();
                                         f11.Clear();
                                            e2.Clear();
                                         f2.Clear();

                                         e3.Clear();
                                         f3.Clear();

                                         e4.Clear();
                                         f4.Clear();
                                                e5.Clear();
                                         f5.Clear();
                                         e6.Clear();
                                         f6.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f11.Add(Act_Fun(oper[kl], e11[p]));

                                         kl = ff.Next(0, 8);                     // N1
                                         e2.Add(W[6] * f1[p] + W[7] * f11[p]);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));

                                         kl = ff.Next(0, 8);                     // N2
                                         e3.Add(W[8] * f2[p]);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);                     // N2
                                         e4.Add(W[9] * f3[p]);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);                     // N2
                                         e5.Add(W[10] * f4[p]);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                                         kl = ff.Next(0, 8);                     // сумматор
                                         e6.Add(W[11] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f6[p]) / f6.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }
                        
                            if (N1 == 2 || N2 == 1 || N3 == 1 || N4 == 1 || M == 2)
                             {
                                 for (int t = 0; t < 14; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }

                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f11.Add(Act_Fun(oper[kl], e11[p]));

                                         kl = ff.Next(0, 8);
                                         e2.Add(W[6] * f1[p]);
                                         e22.Add(W[7] * f11[p]);                                        // N1

                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));                              // M
                                         f22.Add(Act_Fun(oper[kl], e22[p]));

                                         kl = ff.Next(0, 8);
                                         e3.Add(W[8] * f2[p] + W[9] * f22[p]);                              // M
                                         f33.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);
                                         e4.Add(W[10] * f33[p]);                          // M
                                         f44.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);
                                         e5.Add(W[11] * f44[p]);                          // M
                                         f55.Add(Act_Fun(oper[kl], e5[p]));

                                         kl = ff.Next(0, 8);                  // сумматор
                                         e6.Add(W[12] * (f55[p]));
                                         f66.Add(Act_Fun(oper[kl], e6[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f66[p]) / f66.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                          e1.Clear();
                                         e11.Clear();
                                            f1.Clear();
                                         
                                         f11.Clear();
                                            e2.Clear();
                                         e22.Clear();                                        // N1

                                         f2.Clear();                              // M
                                         f22.Clear();

                                         e3.Clear();                              // M
                                         f33.Clear();
                                            e4.Clear();                          // M
                                         f44.Clear();

                                         e5.Clear();                          // M
                                         f55.Clear();

                                         e6.Clear();
                                         f66.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e11.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f11.Add(Act_Fun(oper[kl], e11[p]));

                                         kl = ff.Next(0, 8);
                                         e2.Add(W[6] * f1[p]);
                                         e22.Add(W[7] * f11[p]);                                        // N1

                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));                              // M
                                         f22.Add(Act_Fun(oper[kl], e22[p]));

                                         kl = ff.Next(0, 8);
                                         e3.Add(W[8] * f2[p] + W[9] * f22[p]);                              // M
                                         f33.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);
                                         e4.Add(W[10] * f33[p]);                          // M
                                         f44.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);
                                         e5.Add(W[11] * f44[p]);                          // M
                                         f55.Add(Act_Fun(oper[kl], e5[p]));

                                         kl = ff.Next(0, 8);                  // сумматор
                                         e6.Add(W[12] * (f55[p]));
                                         f66.Add(Act_Fun(oper[kl], e6[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f66[p]) / f66.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }
                        
                            if (N1 == 3 || N2 == 1 || N3 == 1 || N4 == 1 || M == 2)
                             {
                                 for (int t = 0; t < 20; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }

                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                                         kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);
                                         e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);

                                         kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                                         kl = ff.Next(0, 8);
                                         e6.Add(W[15] * f4[p] + W[16] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         kl = ff.Next(0, 8);
                                         e7.Add(W[17] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[18] * f7[p]);
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         kl = ff.Next(0, 8);
                                         e9.Add(W[19] * f8[p]);                                                  // Сумматор 
                                         f9.Add(Act_Fun(oper[kl], e9[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f9[p]) / f9.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Clear();
                                         e2.Clear();
                                         e3.Clear();

                                         f1.Clear();
                                         f2.Clear();
                                         f3.Clear();

                                         e4.Clear();
                                         e5.Clear();

                                         f4.Clear();
                                         f5.Clear();

                                         e6.Clear();
                                         f6.Clear();

                                         e7.Clear();
                                         f7.Clear();
                                        e8.Clear();
                                         f8.Clear();

                                         e9.Clear();                                                  // Сумматор 
                                         f9.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                                         kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         kl = ff.Next(0, 8);
                                         e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);

                                         kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                                         kl = ff.Next(0, 8);
                                         e6.Add(W[15] * f4[p] + W[16] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         kl = ff.Next(0, 8);
                                         e7.Add(W[17] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[18] * f7[p]);
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         kl = ff.Next(0, 8);
                                         e9.Add(W[19] * f8[p]);                                                  // Сумматор 
                                         f9.Add(Act_Fun(oper[kl], e9[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f9[p]) / f9.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }
        
                           if (N1 == 3 || N2 == 1 || N3 == 1 || N4 == 1 || M == 3)
                             {
                                 for (int t = 0; t < 24; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }

                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                                         kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);
                                         e6.Add(W[15] * f1[p] + W[16] * f2[p] + W[17] * f3[p]);

                                         kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));
                                         kl = ff.Next(0, 8);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));
                                         kl = ff.Next(0, 8);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         kl = ff.Next(0, 8);
                                         e7.Add(W[18] * f4[p] + W[19] * f5[p] + W[20] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[21] * f7[p]);
                                         f8.Add(Act_Fun(oper[kl], e8[p]));


                                         kl = ff.Next(0, 8);
                                         e9.Add(W[22] * f8[p]);
                                         f9.Add(Act_Fun(oper[kl], e9[p]));

                                         kl = ff.Next(0, 8);
                                         e10.Add(W[23] * f9[p]);                                                  // Сумматор 
                                         f10.Add(Act_Fun(oper[kl], e10[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f10[p]) / f10.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Clear();
                                         e2.Clear();
                                         e3.Clear();

                                         f1.Clear();
                                         f2.Clear();
                                         f3.Clear();

                                         e4.Clear();
                                         e5.Clear();
                                         e6.Clear();

                                         f4.Clear();
                                         f5.Clear();
                                         f6.Clear();

                                         e7.Clear();
                                         f7.Clear();
                                         e8.Clear();
                                         f8.Clear();
                                         e9.Clear();
                                         f9.Clear();

                                         e10.Clear();                                                  // Сумматор 
                                         f10.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                                         kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));

                                         e4.Add(W[9] * f1[p] + W[10] * f2[p] + W[11] * f3[p]);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p]);
                                         e6.Add(W[15] * f1[p] + W[16] * f2[p] + W[17] * f3[p]);

                                         kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));
                                         kl = ff.Next(0, 8);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));
                                         kl = ff.Next(0, 8);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         kl = ff.Next(0, 8);
                                         e7.Add(W[18] * f4[p] + W[19] * f5[p] + W[20] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[21] * f7[p]);
                                         f8.Add(Act_Fun(oper[kl], e8[p]));


                                         kl = ff.Next(0, 8);
                                         e9.Add(W[22] * f8[p]);
                                         f9.Add(Act_Fun(oper[kl], e9[p]));

                                         kl = ff.Next(0, 8);
                                         e10.Add(W[23] * f9[p]);                                                  // Сумматор 
                                         f10.Add(Act_Fun(oper[kl], e10[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f10[p]) / f10.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }
            
                            if (N1 == 4 || N2 == 1 || N3 == 1 || N4 == 1 || M == 1)
                             {
                                 for (int t = 0; t < 20; t++)
                                 {
                                     W.Add(Convert.ToDouble(ff.Next(1, 58) / 10.0));
                                 }

                                 for (int i = 0; i < 3; i++)
                                 {
                                     for (int p = 0; p < x1_mas.Count(); p++)                                                        // СДЕЛАТЬ У КАЖДОГО ВАРИАНТА СТРУКТУРЫ НЕЙРОНКИ
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);
                                         e4.Add(W[9] * x1_mas[p] + W[10] * x2_mas[p] + W[11] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                                         kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));
                                         kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p] + W[15] * f4[p]);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                                         kl = ff.Next(0, 8);
                                         e6.Add(W[16] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         kl = ff.Next(0, 8);
                                         e7.Add(W[17] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[18] * f7[p]);
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         kl = ff.Next(0, 8);
                                         e9.Add(W[19] * f8[p]);                                                  // Сумматор 
                                         f9.Add(Act_Fun(oper[kl], e9[p]));

                                         S0.Add(Math.Abs(x_etal[p] - f9[p]) / f9.Count());
                                     }
                                     for (int op = 0; op < S0.Count(); op++)
                                         S0_res += S0[op];

                                     // GA //                         

                                     encoding(W);
                                     cod_double(W);

                                     cod_mas_two();
                                     recombination1(code_mas);

                                     Mutation_1(rule_rek1);                  // исправить 
                                     Mutation_2(rule_rek1);                  // исправить 

                                     Int_dcod(string_xx);                    // double
                                     Double_dcod(str_xx);                         // int

                                     concat_int_double(m_cod_double, m_cod_int);

                                     W.Clear();
                                     for (int k = 0; k < m_int_double.Count(); k++)
                                     {
                                         W.Add(m_int_double[k]);
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                        e1.Clear();
                                         e2.Clear();
                                         e3.Clear();
                                         e4.Clear();

                                         
                                         f1.Clear();
                                         f2.Clear();
                                         f3.Clear();
                                  
                                         f4.Clear();
                                         e5.Clear();
                                         f5.Clear();
                                         e6.Clear();
                                         f6.Clear();

                                         e7.Clear();
                                         f7.Clear();

                                         e8.Clear();
                                         f8.Clear();

                                         e9.Clear();                                                  // Сумматор 
                                         f9.Clear();
                                     }

                                     for (int p = 0; p < x1_mas.Count(); p++)
                                     {
                                         e1.Add(W[0] * x1_mas[p] + W[1] * x2_mas[p] + W[2] * x3_mas[p]);
                                         e2.Add(W[3] * x1_mas[p] + W[4] * x2_mas[p] + W[5] * x3_mas[p]);
                                         e3.Add(W[6] * x1_mas[p] + W[7] * x2_mas[p] + W[8] * x3_mas[p]);
                                         e4.Add(W[9] * x1_mas[p] + W[10] * x2_mas[p] + W[11] * x3_mas[p]);

                                         kl = ff.Next(0, 8);
                                         f1.Add(Act_Fun(oper[kl], e1[p]));
                                         kl = ff.Next(0, 8);
                                         f2.Add(Act_Fun(oper[kl], e2[p]));
                                         kl = ff.Next(0, 8);
                                         f3.Add(Act_Fun(oper[kl], e3[p]));
                                         kl = ff.Next(0, 8);
                                         f4.Add(Act_Fun(oper[kl], e4[p]));

                                         kl = ff.Next(0, 8);
                                         e5.Add(W[12] * f1[p] + W[13] * f2[p] + W[14] * f3[p] + W[15] * f4[p]);
                                         f5.Add(Act_Fun(oper[kl], e5[p]));

                                         kl = ff.Next(0, 8);
                                         e6.Add(W[16] * f5[p]);
                                         f6.Add(Act_Fun(oper[kl], e6[p]));

                                         kl = ff.Next(0, 8);
                                         e7.Add(W[17] * f6[p]);
                                         f7.Add(Act_Fun(oper[kl], e7[p]));

                                         kl = ff.Next(0, 8);
                                         e8.Add(W[18] * f7[p]);
                                         f8.Add(Act_Fun(oper[kl], e8[p]));

                                         kl = ff.Next(0, 8);
                                         e9.Add(W[19] * f8[p]);                                                  // Сумматор 
                                         f9.Add(Act_Fun(oper[kl], e9[p]));

                                         S1.Add(Math.Abs(x_etal[p] - f9[p]) / f9.Count());
                                     }

                                     for (int op = 0; op < S1.Count(); op++)
                                         S1_res += S1[op];

                                     W.Clear();
                                     if (S0_res < S1_res)
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                             W.Add(Convert.ToDouble(ff.Next(5, 75) / 10.0));
                                     else
                                     {
                                         for (int k = 0; k < m_int_double.Count(); k++)
                                         {
                                             W.Add(m_int_double[k]);
                                         }
                                     }
                                 }
                             }

                Console.WriteLine("Отклонение ******************************************* Отклонение ");
            for (int p = 0; p < S0.Count(); p++)
            {   
                Console.WriteLine("Vor: " + " " + S0[p] + "|" + "  Weiter: " + " " + S1[p]);
            }
           }
            
        static double Act_Fun(string oper, double e)
        {
            double f = 0;
            if (oper == "F1")
            {
                f = 1 / (1 + Math.Exp(-1 * e));
            }

            if (oper == "F2")
            {
                if (e <= 0)
                {
                    f = 0;
                }
                else
                {
                    f = e;
                }
            }
            if (oper == "F3")
            {
                f = Math.Exp(-1 * e * e);
            }
            if (oper == "F4")
            {
                if (e <= 0)
                { f = 0; }
                else
                {
                    if (e > 0 && e < 1)
                    {
                        f = e;
                    }
                    else
                    {
                        if (e >= 1)
                        { f = 1; }
                    }
                }
            }

            if (oper == "F5")
            {
                if (e <= -1)
                {
                    f = -1;
                }
                else
                {
                    if (e < 1 && e > -1)
                    {
                        f = e;
                    }
                    else
                    {
                        if (e >= 1)
                        { f = 1; }
                    }
                }
            }

            if (oper == "F6")
            {
                f = (Math.Exp(e) - Math.Exp(-1 * e)) / (Math.Exp(e) + Math.Exp(-1 * e));
            }

            if (oper == "F7")
            {
                if (e <= 1)
                {
                    f = 1 - Math.Abs(e);
                }
                else
                {
                    if (Math.Abs(e) > 1)
                        f = 0;
                }
            }

            return f;
        }
        //
        static List<string> encoding(List<double> x)
        {
            result = "";
            for (int q = 0; q < x.Count(); q++)
            {
                it_x.Add((int)x[q]);
                double_w.Add(x[q] - it_x[q]);
            }
            for (int e = 0; e < x.Count(); e++)
            {
                while (true)
                {
                    result = it_x[e] % 2 + result;
                    if (it_x[e] / 2 == 0)
                        break;
                    else
                        it_x[e] /= 2;
                }
                string t = result;
                string_xx.Add(result);
                result = "";
            }
            return string_xx;                                                           // ---------------------!!!string_xx!!! целые числа 
        }
        static List<string> cod_mas_two()
        {
            for (int t = 0; t < str_xx.Count(); t++)
                code_mas.Add(string_xx[t] + str_xx[t]);

            int Max_dlinna = 0;
            List<int> dlinna = new List<int>();

            for (int i = 0; i < code_mas.Count(); i++)
            {
                dlinna.Add(code_mas[i].Length);
            }

            Max_dlinna = dlinna.Max();

            for (int i = 0; i < code_mas.Count(); i++)
            {
                if (code_mas[i].Length < Max_dlinna)
                {
                    if (Max_dlinna % 2 == 0)
                    {
                        while (code_mas[i].Length != Max_dlinna)
                        {
                            code_mas[i] = code_mas[i] + "0";
                        }
                    }
                    else
                    {
                        while (code_mas[i].Length != Max_dlinna)
                        {
                            code_mas[i] = code_mas[i] + "0" + "0";
                        }
                    }
                }
                else
                    code_mas[i] = code_mas[i];
            }
            return code_mas;
        }

        static List<string> cod_double(List<double> x)
        {
            string res_double = "";
            double xx = 0;
            int co = 0;
            for (int w = 0; w < x.Count(); w++)
            {
                for (co = 0; co <= 2; co++)
                {
                    xx = double_w[w] * 2;
                    if (xx == 1)
                    {
                        res_double = Convert.ToString((int)xx) + res_double;
                        break;
                    }
                    else if (xx < 1)
                    {
                        res_double = Convert.ToString((int)xx) + res_double;
                        double_w[w] = xx;
                    }
                    else if (xx > 1)
                    {
                        res_double = Convert.ToString((int)xx) + res_double;
                        double_w[w] = xx - 1;
                    }
                    else if (xx == 1)
                        break;
                }
                str_xx.Add(res_double);
                res_double = "";
            }
            return str_xx;                                          // - это массив для Хранения Кодированных значений(бинарных) 
        }

        /* static List<string> Common_mas()
         {
             str_mas.Clear();
             Console.WriteLine("------******************----------");           
             for (int i = 0; i < str_xx.Count(); i++)
             {   
                 str_mas.Add(str_xx[i] + string_xx[i]);
                 Console.WriteLine(str_mas[i]);
             }
             n_mas_str.Clear();
             for (int p = 0; p < str_mas.Count(); p++)
             {
                 int count_bin = str_xx[p].Length; 

                 int n = str_mas[p].Length;                
                
                     if (n >= count_bin)
                         n_mas_str.Add(str_mas[p]);
                     else
                         n_mas_str.Add(str_mas[p] + "0");
             }
             Console.WriteLine("----------------------------------------------");            
             for(int t = 0; t < n_mas_str.Count(); t++)
             Console.WriteLine("{0}", n_mas_str[t]);            
             return n_mas_str;
         }
        */
        static void Int_dcod(List<string> x)
        {
            double ert = 0;
            double rt_chisli = 0;
            Console.WriteLine("+++-------------------------**********************------------------------+++");
            for (int i = 0; i < x.Count(); i++)
            {
                string tr = x[i];
                for (int t = 0; t < tr.Count(); t++)
                {
                    char c = tr[t];
                    if (c == '1')
                        ert = 1 * Math.Pow(2, tr.Count() - t - 1);                                     // в обратную сторону прочитать массив //
                    else
                        ert = 0 * Math.Pow(2, tr.Count() - t - 1);
                    rt_chisli += ert;
                }
                m_cod_int.Add(rt_chisli);
                rt_chisli = 0;
                Console.WriteLine("result_chorocho =" + m_cod_int[i]);
            }
        }

        static void Double_dcod(List<string> x)
        {
            double ert = 0;
            double rt_chisli_double = 0;

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i < x.Count(); i++)
            {
                string tr = x[i];
                for (int t = 0; t < tr.Count(); t++)
                {
                    char c = tr[t];
                    if (c == '1')
                        ert = 1 * Math.Pow(2, (-t) - 1);       // в обратную сторону прочитать массив //
                    else
                        ert = 0 * Math.Pow(2, (-t) - 1);
                    rt_chisli_double += ert;
                }
                m_cod_double.Add(rt_chisli_double);
                rt_chisli_double = 0;

                Console.WriteLine("result_chorocho_Double = " + m_cod_double[i]);
            }
        }

        static List<double> concat_int_double(List<double> x, List<double> y)
        {
            Console.WriteLine("*Next generation*");

            for (int i = 0; i < m_cod_double.Count(); i++)
            {
                m_int_double.Add(m_cod_double[i] + m_cod_int[i]);
                Console.WriteLine("CHislo = " + m_int_double[i]);
            }
            return m_int_double;
        }

        static List<string> Mutation_1(List<string> y)
        {
            Console.WriteLine("Mutate1");

            List<string> rule_mut1 = new List<string>();

            for (int i = 0; i < y.Count(); i++)
            {
                int count_bin = y[i].Length;

                int position = ff.Next(0, count_bin);

                char c = y[i][0];

                if (c == '1')
                    y[i] = '0' + y[i].Substring(1, count_bin - 1);
                else
                    y[i] = '1' + y[i].Substring(1, count_bin - 1);

                rule_mut1.Add(y[i]);
            }
            Console.WriteLine("Mutate1");
            return rule_mut1;
        }

        static List<string> Mutation_2(List<string> y)
        {
            Console.WriteLine("Mutate2");

            List<string> rule_mut2 = new List<string>();

            for (int i = 0; i < y.Count(); i++)
            {
                int count_bin = y[i].Length;

                for (int r = 0; r < 3; r++)
                {
                    int position = ff.Next(0, count_bin);
                    char c = y[i][position];
                    if (c == '1')
                        y[i] = '0' + y[i].Substring(1, count_bin - 1);
                    else
                        y[i] = '1' + y[i].Substring(1, count_bin - 1);
                }
                rule_mut2.Add(y[i]);
            }

            return rule_mut2;
        }

        static List<string> recombination1(List<string> y)
        {
            Console.WriteLine("Recombination1");

            rule_rek1.Clear();

            for (int i = 0; i < y.Count(); i++)
            {
                int count_bin = y[i].Length;

                if (count_bin % 2 == 0)
                {
                    rule_rek1.Add(y[i].Substring(0, count_bin / 2) + y[i + 1].Substring(count_bin / 2, count_bin / 2));
                    rule_rek1.Add(y[i + 1].Substring(0, count_bin / 2) + y[i].Substring(count_bin / 2, count_bin / 2));
                }
                i++;
            }

            Console.WriteLine("Recombination1");
            return rule_rek1;
        }
    }
}
