using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.PeachtreeModel
{
    [Table("tb_ordenes_de_venta_test", Schema = "dbo")]
    public class TbOrdenesDeVentaTest
    {
        public TbOrdenesDeVentaTest()
        {
        }

        [Key]
        [Column("ov", TypeName = "varchar")]
        [JsonProperty("ov")]
        public String Ov { get; set; }

        [Column("fecha", TypeName = "date")]
        [JsonProperty("fecha")]
        public DateTime Fecha { get; set; }

        [Column("descripcion", TypeName = "varchar")]
        [JsonProperty("descripcion")]
        public String Descripcion { get; set; }

        [Column("monto", TypeName = "decimal")]
        [JsonProperty("monto")]
        public Decimal Monto { get; set; }

        [Column("cliente_id", TypeName = "bigint")]
        [JsonProperty("cliente_id")]
        public Int64 ClienteId { get; set; }

        [Column("division_id", TypeName = "int")]
        [JsonProperty("division_id")]
        public Int32 DivisionId { get; set; }

        [Column("pais_id", TypeName = "int")]
        [JsonProperty("pais_id")]
        public Int32 PaisId { get; set; }

        #region ShouldSerialize
        public bool ShouldSerializeOv()
        {
            return (!this.NotSerializeOv);
        }

        public bool ShouldSerializeFecha()
        {
            return (!this.NotSerializeFecha);
        }

        public bool ShouldSerializeDescripcion()
        {
            return (!this.NotSerializeDescripcion);
        }

        public bool ShouldSerializeMonto()
        {
            return (!this.NotSerializeMonto);
        }

        public bool ShouldSerializeClienteId()
        {
            return (!this.NotSerializeClienteId);
        }

        public bool ShouldSerializeDivisionId()
        {
            return (!this.NotSerializeDivisionId);
        }

        public bool ShouldSerializePaisId()
        {
            return (!this.NotSerializePaisId);
        }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeOv { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeFecha { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDescripcion { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeMonto { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeClienteId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDivisionId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializePaisId { get; set; }

        #endregion
    }
}
