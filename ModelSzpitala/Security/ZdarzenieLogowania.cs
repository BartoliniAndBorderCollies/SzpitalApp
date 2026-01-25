using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelSzpitala.Security
{
    public class ZdarzenieLogowania
    {
        private DateTime _dataLogowania;
        private string _nazwaUsera;
        private bool _sukces;

        public DateTime DataLogowania
        {
            get
            {
                return _dataLogowania;
            }
        }

        public string NazwaUsera
        {
            get
            {
                return _nazwaUsera;
            }
        }

        public bool Sukces
        {
            get
            {
                return _sukces;
            }
        }

        [JsonConstructor]
        public ZdarzenieLogowania(DateTime dataLogowania, string nazwaUsera, bool sukces)
        {
            _dataLogowania = dataLogowania;
            _nazwaUsera = nazwaUsera;
            _sukces = sukces;
        }
    }
}
