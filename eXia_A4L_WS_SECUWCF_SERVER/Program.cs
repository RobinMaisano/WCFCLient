﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using eXia_A4L_WS_SECUWCF_MIDDLEWARE;

namespace eXia_A4L_WS_SECUWCF_SERVER
{
    class Program
    {
        private static ServiceHost host;

        static void Main(string[] args)
        {
            Program.headup();
            Program.ini_serv();
            Console.Read();
        }
        static void headup()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************************");
            Console.WriteLine("**                                    **");
            Console.WriteLine("**     Server WCF eXia A4 WS2 1.0     **");
            Console.WriteLine("**                                    **");
            Console.WriteLine("****************************************\n\n");
        }
        static void ini_serv()
        {
            int i;

            Program.host = new ServiceHost(typeof(
               SVC));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Initialisation du serveur...veuillez patienter");

            try
            {
                host.Open();
                Console.WriteLine("<--Serveur ouvert-->\n");

                for (i = 0; i < host.Description.Endpoints.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Description du service {0}", i);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Adresse : " + host.Description.Endpoints[i].Address);
                    Console.WriteLine("Binding : " + host.Description.Endpoints[i].Binding);
                    Console.WriteLine("Contract Type : " + host.Description.Endpoints[i].Contract.ContractType);
                    Console.WriteLine("Contract Name : " + host.Description.Endpoints[i].Contract.Name);
                    Console.WriteLine("Uri : " + host.Description.Endpoints[i].ListenUri.Host);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("<--Fin de l'initialisation-->");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + host.State.ToString());
            }


        }
    }
}
