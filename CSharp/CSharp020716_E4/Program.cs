using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp020716_E4
{
    class Jagged
    {
        static void Main(string[] args)
        {
            int[][] network_nodes = new int[3][];
            network_nodes[0] = new int[3];
            network_nodes[1] = new int[5];
            network_nodes[2] = new int[2];

            int i, j;


            for (i = 0; i < network_nodes.Length; i++)
                for (j = 0; j < network_nodes[i].Length; j++)
                    network_nodes[i][j] = i * j + 70;

            Console.Write("Total Numbers of network nodes: " + network_nodes.Length+"\n");

            for (i = 0; i < network_nodes.Length; i++)
            {
                for (j = 0; j < network_nodes[i].Length; j++)
                {
                    Console.Write("CPU usage at node " + i + " CPU " + j + ":");
                    Console.Write(network_nodes[i][j] + "% \n");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
