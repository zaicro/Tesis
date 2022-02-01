using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesisApi.Infraestructure.IngresosModel
{
    [Table("divisiones", Schema = "dbo")]
    public class Divisiones
    {
        public Divisiones()
        {
        }

        [Column("id_divisiones", TypeName = "bigint")]
        [Key]
        [JsonProperty("id_divisiones")]
        public Int64 IdDivisiones { get; set; }

        [Column("finalEnt", TypeName = "int")]
        [JsonProperty("finalEnt")]
        public Int32 Finalent { get; set; }

        [Column("guiddivisiones", TypeName = "uniqueidentifier")]
        [JsonProperty("guiddivisiones")]
        public Guid Guiddivisiones { get; set; }

        [Column("dsbldivisiones", TypeName = "bit")]
        [JsonProperty("dsbldivisiones")]
        public Boolean? Dsbldivisiones { get; set; }

        [Column("dplydivisiones", TypeName = "tinyint")]
        [JsonProperty("dplydivisiones")]
        public Byte? Dplydivisiones { get; set; }

        [Column("nombre", TypeName = "nvarchar")]
        [JsonProperty("nombre")]
        public String Nombre { get; set; }

        [Column("descripcion", TypeName = "nvarchar")]
        [JsonProperty("descripcion")]
        public String Descripcion { get; set; }

        [Column("activo", TypeName = "bit")]
        [JsonProperty("activo")]
        public Boolean? Activo { get; set; }

        #region ShouldSerialize
        public bool ShouldSerializeIdDivisiones()
        {
            return (!this.NotSerializeIdDivisiones);
        }

        public bool ShouldSerializeFinalent()
        {
            return (!this.NotSerializeFinalent);
        }

        public bool ShouldSerializeGuiddivisiones()
        {
            return (!this.NotSerializeGuiddivisiones);
        }

        public bool ShouldSerializeDsbldivisiones()
        {
            return (!this.NotSerializeDsbldivisiones);
        }

        public bool ShouldSerializeDplydivisiones()
        {
            return (!this.NotSerializeDplydivisiones);
        }

        public bool ShouldSerializeNombre()
        {
            return (!this.NotSerializeNombre);
        }

        public bool ShouldSerializeDescripcion()
        {
            return (!this.NotSerializeDescripcion);
        }

        public bool ShouldSerializeActivo()
        {
            return (!this.NotSerializeActivo);
        }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIdDivisiones { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeFinalent { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeGuiddivisiones { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDsbldivisiones { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDplydivisiones { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeNombre { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDescripcion { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeActivo { get; set; }

        #endregion
    }
}
