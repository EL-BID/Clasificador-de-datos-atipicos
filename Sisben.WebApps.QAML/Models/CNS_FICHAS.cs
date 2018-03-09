//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sisben.WebApps.QAML.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CNS_FICHAS
    {
        public int Num_paquete { get; set; }
        public byte Est_ficha_bd { get; set; }
        public System.DateTime Fec_paquete { get; set; }
        public string Cod_dpto { get; set; }
        public string Cod_mpio { get; set; }
        public int Num_ficha { get; set; }
        public string Ide_ficha_origen { get; set; }
        public short Ide_edificacion { get; set; }
        public string Ver_estructura { get; set; }
        public byte Ori_encuesta { get; set; }
        public string Cod_clase { get; set; }
        public string Cod_centro_poblado { get; set; }
        public string Cod_area_coordinacion { get; set; }
        public string Cod_area_operativa { get; set; }
        public string Cod_uni_cobertura { get; set; }
        public string Cod_comuna { get; set; }
        public string Cod_corregimiento { get; set; }
        public string Cod_vereda { get; set; }
        public string Cod_barrio { get; set; }
        public string Cod_enumerador { get; set; }
        public byte Tot_viviendas { get; set; }
        public byte Tot_hogares { get; set; }
        public byte Ord_vivienda { get; set; }
        public byte Ind_direccion { get; set; }
        public string Dir_vivienda { get; set; }
        public byte Uso_vivienda { get; set; }
        public string Ide_foto { get; set; }
        public Nullable<System.DateTime> Fec_ini_encuesta { get; set; }
        public Nullable<System.DateTime> Fec_fin_encuesta { get; set; }
        public Nullable<decimal> Coord_x_manual_rec { get; set; }
        public Nullable<decimal> Coord_y_manual_rec { get; set; }
        public Nullable<decimal> Coord_x_auto_rec { get; set; }
        public Nullable<decimal> Coord_y_auto_rec { get; set; }
        public Nullable<int> GPS_Alt_auto_rec { get; set; }
        public Nullable<System.DateTime> Fec_captura_GPS_rec { get; set; }
        public Nullable<int> GPS_Distancia_rec { get; set; }
        public Nullable<decimal> Coord_x_manual_enc { get; set; }
        public Nullable<decimal> Coord_y_manual_enc { get; set; }
        public Nullable<decimal> Coord_x_auto_enc { get; set; }
        public Nullable<decimal> Coord_y_auto_enc { get; set; }
        public Nullable<int> GPS_Alt_auto_enc { get; set; }
        public string Fec_captura_gps_enc { get; set; }
        public Nullable<int> GPS_Distancia_enc { get; set; }
        public byte Est_nov_cartografia { get; set; }
        public string Cod_digitador { get; set; }
        public string Cod_equipo_encuesta { get; set; }
        public System.DateTime Fec_digitacion { get; set; }
        public byte Ind_formato { get; set; }
        public byte Num_hogares_recuento { get; set; }
        public byte Est_ficha { get; set; }
        public byte Num_visita { get; set; }
        public string Cod_chip { get; set; }
        public string Dir_chip { get; set; }
        public int Num_solicitud { get; set; }
        public string Cod_UC_total { get; set; }
        public Nullable<System.DateTime> ML_Procesado { get; set; }
        public Nullable<bool> ML_Irregular { get; set; }
    }
}
