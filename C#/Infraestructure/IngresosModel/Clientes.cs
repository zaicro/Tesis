using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.IngresosModel
{
    [Table("clientes", Schema = "dbo")]
    public class Clientes
    {
        public Clientes()
        {
        }

        [Column("id_clientes", TypeName = "bigint")]
        [Key]
        [JsonProperty("id_clientes")]
        public Int64 IdClientes { get; set; }

        [Column("finalEnt", TypeName = "int")]
        [JsonProperty("finalEnt")]
        public Int32 Finalent { get; set; }

        [Column("guidclientes", TypeName = "uniqueidentifier")]
        [JsonProperty("guidclientes")]
        public Guid Guidclientes { get; set; }

        [Column("dsblclientes", TypeName = "bit")]
        [JsonProperty("dsblclientes")]
        public Boolean? Dsblclientes { get; set; }

        [Column("dplyclientes", TypeName = "tinyint")]
        [JsonProperty("dplyclientes")]
        public Byte? Dplyclientes { get; set; }

        [Column("nombre", TypeName = "nvarchar")]
        [JsonProperty("nombre")]
        public String Nombre { get; set; }

        [Column("factura", TypeName = "nvarchar")]
        [JsonProperty("factura")]
        public String Factura { get; set; }

        [Column("correo", TypeName = "nvarchar")]
        [JsonProperty("correo")]
        public String Correo { get; set; }

        [Column("telefono", TypeName = "nvarchar")]
        [JsonProperty("telefono")]
        public String Telefono { get; set; }

        [Column("activo", TypeName = "bit")]
        [JsonProperty("activo")]
        public Boolean? Activo { get; set; }

        #region ShouldSerialize
        public bool ShouldSerializeIdClientes()
        {
            return (!this.NotSerializeIdClientes);
        }

        public bool ShouldSerializeFinalent()
        {
            return (!this.NotSerializeFinalent);
        }

        public bool ShouldSerializeGuidclientes()
        {
            return (!this.NotSerializeGuidclientes);
        }

        public bool ShouldSerializeDsblclientes()
        {
            return (!this.NotSerializeDsblclientes);
        }

        public bool ShouldSerializeDplyclientes()
        {
            return (!this.NotSerializeDplyclientes);
        }

        public bool ShouldSerializeNombre()
        {
            return (!this.NotSerializeNombre);
        }

        public bool ShouldSerializeFactura()
        {
            return (!this.NotSerializeFactura);
        }

        public bool ShouldSerializeCorreo()
        {
            return (!this.NotSerializeCorreo);
        }

        public bool ShouldSerializeTelefono()
        {
            return (!this.NotSerializeTelefono);
        }

        public bool ShouldSerializeActivo()
        {
            return (!this.NotSerializeActivo);
        }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIdClientes { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeFinalent { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeGuidclientes { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDsblclientes { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDplyclientes { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeNombre { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeFactura { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeCorreo { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeTelefono { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeActivo { get; set; }

        #endregion
    }
}
