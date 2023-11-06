using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Locataire
    {
        [Required(ErrorMessage ="ce champ est obligatoire")]
        public string Adresse { get; set; }


        [DataType(DataType.Date)]
        public DateTime DateAdhesion { get; set; }

        public int Id { get; set; }

        public int PointBonus { get; set; }

        public string Telephone { get; set; }


        //relation 1 -> *


     
        public Agent Agent { get; set; }


        public List<Reservation> Reservations { get; set; }

    }
}
