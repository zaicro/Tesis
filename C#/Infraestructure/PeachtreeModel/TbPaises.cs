using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.PeachtreeModel
{
    [Table("tb_paises", Schema = "parametros")]
    public class TbPaises
    {
        public TbPaises()
        {
        }

        [Column("Iso_numerico", TypeName = "int")]
        [Key]
        [JsonProperty("Iso_numerico")]
        public Int32 IsoNumerico { get; set; }

        [Column("Iso_alfa2", TypeName = "varchar")]
        [JsonProperty("Iso_alfa2")]
        public String IsoAlfa2 { get; set; }

        [Column("Iso_alfa3", TypeName = "varchar")]
        [JsonProperty("Iso_alfa3")]
        public String IsoAlfa3 { get; set; }

        [Column("Iso_nombre", TypeName = "varchar")]
        [JsonProperty("Iso_nombre")]
        public String IsoNombre { get; set; }

        [Column("Integra_id", TypeName = "int")]
        [JsonProperty("Integra_id")]
        public Int32? IntegraId { get; set; }

        [Column("Integra_code", TypeName = "varchar")]
        [JsonProperty("Integra_code")]
        public String IntegraCode { get; set; }

        [Column("RetailCore_id", TypeName = "int")]
        [JsonProperty("RetailCore_id")]
        public Int32? RetailcoreId { get; set; }

        [Column("Intranet_id", TypeName = "int")]
        [JsonProperty("Intranet_id")]
        public Int32? IntranetId { get; set; }

        [Column("Dichter", TypeName = "bit")]
        [JsonProperty("Dichter")]
        public Boolean Dichter { get; set; }

        [Column("Orden", TypeName = "int")]
        [JsonProperty("Orden")]
        public Int32 Orden { get; set; }

        [Column("Activo", TypeName = "bit")]
        [JsonProperty("Activo")]
        public Boolean Activo { get; set; }

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
        public bool ShouldSerializeIsoNumerico()
        {
            return (!this.NotSerializeIsoNumerico);
        }

        public bool ShouldSerializeIsoAlfa2()
        {
            return (!this.NotSerializeIsoAlfa2);
        }

        public bool ShouldSerializeIsoAlfa3()
        {
            return (!this.NotSerializeIsoAlfa3);
        }

        public bool ShouldSerializeIsoNombre()
        {
            return (!this.NotSerializeIsoNombre);
        }

        public bool ShouldSerializeIntegraId()
        {
            return (!this.NotSerializeIntegraId);
        }

        public bool ShouldSerializeIntegraCode()
        {
            return (!this.NotSerializeIntegraCode);
        }

        public bool ShouldSerializeRetailcoreId()
        {
            return (!this.NotSerializeRetailcoreId);
        }

        public bool ShouldSerializeIntranetId()
        {
            return (!this.NotSerializeIntranetId);
        }

        public bool ShouldSerializeDichter()
        {
            return (!this.NotSerializeDichter);
        }

        public bool ShouldSerializeOrden()
        {
            return (!this.NotSerializeOrden);
        }

        public bool ShouldSerializeActivo()
        {
            return (!this.NotSerializeActivo);
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
        public bool NotSerializeIsoNumerico { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIsoAlfa2 { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIsoAlfa3 { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIsoNombre { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIntegraId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIntegraCode { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeRetailcoreId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeIntranetId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDichter { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeOrden { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeActivo { get; set; }

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
