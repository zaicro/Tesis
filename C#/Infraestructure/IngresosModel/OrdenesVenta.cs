using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.IngresosModel
{
    [Table("ordenes_venta", Schema = "dbo")]
    public class OrdenesVenta
    {
        public OrdenesVenta()
        {
        }

        [Column("id", TypeName = "bigint")]
        [Key]
        [JsonProperty("id")]
        public Int64 Id { get; set; }

        [Column("finalEnt", TypeName = "int")]
        [JsonProperty("finalEnt")]
        public Int32 Finalent { get; set; }

        [Column("baCreatedTime", TypeName = "bigint")]
        [JsonProperty("baCreatedTime")]
        public Int64 Bacreatedtime { get; set; }

        [Column("baGuid", TypeName = "uniqueidentifier")]
        [JsonProperty("baGuid")]
        public Guid Baguid { get; set; }

        [Column("orden_venta", TypeName = "nvarchar")]
        [JsonProperty("orden_venta")]
        public String OrdenVenta { get; set; }

        [Column("fecha_creacion", TypeName = "datetime")]
        [JsonProperty("fecha_creacion")]
        public DateTime? FechaCreacion { get; set; }

        [Column("descripcion", TypeName = "nvarchar")]
        [JsonProperty("descripcion")]
        public String Descripcion { get; set; }

        [Column("pais_id", TypeName = "bigint")]
        [JsonProperty("pais_id")]
        public Int64? PaisId { get; set; }

        [Column("division_id", TypeName = "bigint")]
        [JsonProperty("division_id")]
        public Int64? DivisionId { get; set; }

        [Column("cliente_id", TypeName = "bigint")]
        [JsonProperty("cliente_id")]
        public Int64? ClienteId { get; set; }

        [Column("cerrada", TypeName = "bit")]
        [JsonProperty("cerrada")]
        public Boolean? Cerrada { get; set; }

        [Column("monto", TypeName = "money")]
        [JsonProperty("monto")]
        public Decimal? Monto { get; set; }

        #region ShouldSerialize
        public bool ShouldSerializeId()
        {
            return (!this.NotSerializeId);
        }

        public bool ShouldSerializeFinalent()
        {
            return (!this.NotSerializeFinalent);
        }

        public bool ShouldSerializeBacreatedtime()
        {
            return (!this.NotSerializeBacreatedtime);
        }

        public bool ShouldSerializeBaguid()
        {
            return (!this.NotSerializeBaguid);
        }

        public bool ShouldSerializeOrdenVenta()
        {
            return (!this.NotSerializeOrdenVenta);
        }

        public bool ShouldSerializeFechaCreacion()
        {
            return (!this.NotSerializeFechaCreacion);
        }

        public bool ShouldSerializeDescripcion()
        {
            return (!this.NotSerializeDescripcion);
        }

        public bool ShouldSerializePaisId()
        {
            return (!this.NotSerializePaisId);
        }

        public bool ShouldSerializeDivisionId()
        {
            return (!this.NotSerializeDivisionId);
        }

        public bool ShouldSerializeClienteId()
        {
            return (!this.NotSerializeClienteId);
        }

        public bool ShouldSerializeCerrada()
        {
            return (!this.NotSerializeCerrada);
        }

        public bool ShouldSerializeMonto()
        {
            return (!this.NotSerializeMonto);
        }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeFinalent { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeBacreatedtime { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeBaguid { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeOrdenVenta { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeFechaCreacion { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDescripcion { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializePaisId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDivisionId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeClienteId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeCerrada { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeMonto { get; set; }

        #endregion
    }
}
