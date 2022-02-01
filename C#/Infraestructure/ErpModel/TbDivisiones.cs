using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.ErpModel
{
    [Table("tb_divisiones", Schema = "parametros")]
    public class TbDivisiones
    {
        public TbDivisiones()
        {
        }

        [Column("Id", TypeName = "int")]
        [Key]
        [JsonProperty("Id")]
        public Int32 Id { get; set; }

        [Column("Nombre", TypeName = "varchar")]
        [JsonProperty("Nombre")]
        public String Nombre { get; set; }

        [Column("Orden", TypeName = "int")]
        [JsonProperty("Orden")]
        public Int32 Orden { get; set; }

        [Column("Activo", TypeName = "bit")]
        [JsonProperty("Activo")]
        public Boolean Activo { get; set; }

        [Column("Descripcion", TypeName = "varchar")]
        [JsonProperty("Descripcion")]
        public String Descripcion { get; set; }

        [Column("Usuario_crea", TypeName = "varchar")]
        [JsonProperty("Usuario_crea")]
        public String UsuarioCrea { get; set; }

        [Column("Fecha_crea", TypeName = "datetime")]
        [JsonProperty("Fecha_crea")]
        public DateTime FechaCrea { get; set; }

        [Column("Usuario_modifica", TypeName = "varchar")]
        [JsonProperty("Usuario_modifica")]
        public String UsuarioModifica { get; set; }

        [Column("Fecha_modifica", TypeName = "datetime")]
        [JsonProperty("Fecha_modifica")]
        public DateTime FechaModifica { get; set; }

        [Column("Observaciones", TypeName = "varchar")]
        [JsonProperty("Observaciones")]
        public String Observaciones { get; set; }

        #region ShouldSerialize
        public bool ShouldSerializeId()
        {
            return (!this.NotSerializeId);
        }

        public bool ShouldSerializeNombre()
        {
            return (!this.NotSerializeNombre);
        }

        public bool ShouldSerializeOrden()
        {
            return (!this.NotSerializeOrden);
        }

        public bool ShouldSerializeActivo()
        {
            return (!this.NotSerializeActivo);
        }

        public bool ShouldSerializeDescripcion()
        {
            return (!this.NotSerializeDescripcion);
        }

        public bool ShouldSerializeUsuarioCrea()
        {
            return (!this.NotSerializeUsuarioCrea);
        }

        public bool ShouldSerializeFechaCrea()
        {
            return (!this.NotSerializeFechaCrea);
        }

        public bool ShouldSerializeUsuarioModifica()
        {
            return (!this.NotSerializeUsuarioModifica);
        }

        public bool ShouldSerializeFechaModifica()
        {
            return (!this.NotSerializeFechaModifica);
        }

        public bool ShouldSerializeObservaciones()
        {
            return (!this.NotSerializeObservaciones);
        }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeNombre { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeOrden { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeActivo { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDescripcion { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeUsuarioCrea { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeFechaCrea { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeUsuarioModifica { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeFechaModifica { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeObservaciones { get; set; }

        #endregion
    }
}
