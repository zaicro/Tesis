using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.IngresosModel
{
    [Table("paises", Schema = "dbo")]
    public class Paises
    {
        public Paises()
        {
        }

        [Column("iso_numerico", TypeName = "bigint")]
        [Key]
        [JsonProperty("iso_numerico")]
        public Int64 IsoNumerico { get; set; }

        [Column("finalEnt", TypeName = "int")]
        [JsonProperty("finalEnt")]
        public Int32 Finalent { get; set; }

        [Column("guidpaises", TypeName = "uniqueidentifier")]
        [JsonProperty("guidpaises")]
        public Guid Guidpaises { get; set; }

        [Column("dsblpaises", TypeName = "bit")]
        [JsonProperty("dsblpaises")]
        public Boolean? Dsblpaises { get; set; }

        [Column("dplypaises", TypeName = "tinyint")]
        [JsonProperty("dplypaises")]
        public Byte? Dplypaises { get; set; }

        [Column("iso_nombre", TypeName = "nvarchar")]
        [JsonProperty("iso_nombre")]
        public String IsoNombre { get; set; }

        [Column("iso_alfa3", TypeName = "nvarchar")]
        [JsonProperty("iso_alfa3")]
        public String IsoAlfa3 { get; set; }

        [Column("iso_alfa2", TypeName = "nvarchar")]
        [JsonProperty("iso_alfa2")]
        public String IsoAlfa2 { get; set; }

        [Column("es_dichter", TypeName = "bit")]
        [JsonProperty("es_dichter")]
        public Boolean? EsDichter { get; set; }

        #region ShouldSerialize
        public bool ShouldSerializeIsoNumerico()
        {
            return (!this.NotSerializeIsoNumerico);
        }

        public bool ShouldSerializeFinalent()
        {
            return (!this.NotSerializeFinalent);
        }

        public bool ShouldSerializeGuidpaises()
        {
            return (!this.NotSerializeGuidpaises);
        }

        public bool ShouldSerializeDsblpaises()
        {
            return (!this.NotSerializeDsblpaises);
        }

        public bool ShouldSerializeDplypaises()
        {
            return (!this.NotSerializeDplypaises);
        }

        public bool ShouldSerializeIsoNombre()
        {
            return (!this.NotSerializeIsoNombre);
        }

        public bool ShouldSerializeIsoAlfa3()
        {
            return (!this.NotSerializeIsoAlfa3);
        }

        public bool ShouldSerializeIsoAlfa2()
        {
            return (!this.NotSerializeIsoAlfa2);
        }

        public bool ShouldSerializeEsDichter()
        {
            return (!this.NotSerializeEsDichter);
        }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIsoNumerico { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeFinalent { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeGuidpaises { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDsblpaises { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDplypaises { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIsoNombre { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIsoAlfa3 { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIsoAlfa2 { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeEsDichter { get; set; }

        #endregion
    }
}
