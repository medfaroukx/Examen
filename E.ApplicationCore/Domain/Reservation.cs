using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }


        [Range(1,30)]
        public int DureeJours { get; set; }


     

        public Vehicule Vehicule { get; set; }//  relation * -> 1

   
        public Locataire Locataire { get; set; } //  relation * -> 1
        public object LocataireFK { get; set; }
        public object VehiculeFK { get; set; }
    }
}
