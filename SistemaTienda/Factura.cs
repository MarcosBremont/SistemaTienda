using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTienda
{
    public class Factura
    {
        private int codigo;
        private string nombre_pro = "";
        private float precio_pro;
        private string nombrecompleto = "";
        private string facturado = "";
        private int cantidad;
        private float total_calculo;
        private DateTime fechaFactura;



        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre_pro { get => nombre_pro; set => nombre_pro = value; }
        public float Precio_pro { get => precio_pro; set => precio_pro = value; }
        public string Nombrecompleto { get => nombrecompleto; set => nombrecompleto = value; }
        public string Facturado { get => facturado; set => facturado = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Total_calculo { get => total_calculo; set => total_calculo = value; }
        public DateTime FechaFactura { get => fechaFactura; set => fechaFactura = value; }
    }
}