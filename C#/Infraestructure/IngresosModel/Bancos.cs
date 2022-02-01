using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.IngresosModel
{
    [Table("bancos", Schema = "dbo")]
    public class Bancos
    {
        public Bancos()
        {
        }

        [Column("id", TypeName = "bigint")]
        [Key]
        [JsonProperty("id")]
        public Int64 Id { get; set; }

        [Column("finalEnt", TypeName = "int")]
        [JsonProperty("finalEnt")]
        public Int32 Finalent { get; set; }

        [Column("guidbancos", TypeName = "uniqueidentifier")]
        [JsonProperty("guidbancos")]
        public Guid Guidbancos { get; set; }

        [Column("dsblbancos", TypeName = "bit")]
        [JsonProperty("dsblbancos")]
        public Boolean? Dsblbancos { get; set; }

        [Column("dplybancos", TypeName = "tinyint")]
        [JsonProperty("dplybancos")]
        public Byte? Dplybancos { get; set; }

        [Column("banco", TypeName = "nvarchar")]
        [JsonProperty("banco")]
        public String Banco { get; set; }

        [Column("activo", TypeName = "bit")]
        [JsonProperty("activo")]
        public Boolean? Activo { get; set; }

        #region ShouldSerialize
        public bool ShouldSerializeId()
        {
            return (!this.NotSerializeId);
        }

        public bool ShouldSerializeFinalent()
        {
            return (!this.NotSerializeFinalent);
        }

        public bool ShouldSerializeGuidbancos()
        {
            return (!this.NotSerializeGuidbancos);
        }

        public bool ShouldSerializeDsblbancos()
        {
            return (!this.NotSerializeDsblbancos);
        }

        public bool ShouldSerializeDplybancos()
        {
            return (!this.NotSerializeDplybancos);
        }

        public bool ShouldSerializeBanco()
        {
            return (!this.NotSerializeBanco);
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
        public bool NotSerializeFinalent { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeGuidbancos { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDsblbancos { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDplybancos { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeBanco { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeActivo { get; set; }

        #endregion
    }
}
