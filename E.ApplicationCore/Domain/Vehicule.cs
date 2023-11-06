﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Vehicule
    {

        [MaxLength(25)]
        public string Couleur { get; set; }

        public int Kilometrage { get; set; }

        public double PrixJour { get; set; }

        public int VehiculeId { get; set; }



        public List<Reservation> Reservations { get; set; }
    }
}
