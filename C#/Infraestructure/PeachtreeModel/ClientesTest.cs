using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.PeachtreeModel
{
    [Table("clientes_test", Schema = "dbo")]
    public class ClientesTest
    {
        public ClientesTest()
        {
        }

        [Column("id", TypeName = "bigint")]
        [Key]
        [JsonProperty("id")]
        public Int64 Id { get; set; }

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
        public bool ShouldSerializeId()
        {
            return (!this.NotSerializeId);
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
        public bool NotSerializeId { get; set; }

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
