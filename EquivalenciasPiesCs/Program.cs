﻿using System;
/* 1.7. Crear un proyecto llamado “EquivalenciasPies”. 
 * Se debe ingresar una distancia medidas en pies y 
 * calcular su equivalente en pulgadas, yarda, cms y metros. 
Utilizar únicamente las equivalencias conocidas: 
1 pie = 12 pulgadas, 1 yarda = 3 pies, 
1 pulgada = 2.54 cm, 1 metro = 100 cm. */
namespace EquivalenciasPiesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte piePulgadas = 12;
            byte yardaPies = 3;
            decimal pulgadaCms = 2.54M;
            byte metroCms = 100;
            uint pies;
            decimal pulgadas, cms;

            Console.Write("Ingrese medida en pies: ");
            pies = Convert.ToUInt32(Console.ReadLine());

            pulgadas = pies * piePulgadas;
            cms = pulgadas * pulgadaCms;

            Console.WriteLine("Equivale a {0} pulgadas", pulgadas);
            Console.WriteLine("Equivale a {0} yardas", pies / yardaPies);
            Console.WriteLine("Equivale a {0} centimetros", cms);
            Console.WriteLine("Equivale a {0} metros", cms / metroCms);
        }
    }
}