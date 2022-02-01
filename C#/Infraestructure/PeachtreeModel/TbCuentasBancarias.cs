using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.PeachtreeModel
{
    [Table("tb_cuentas_bancarias", Schema = "dbo")]
    public class TbCuentasBancarias
    {
        public TbCuentasBancarias()
        {
        }

        [Column("id", TypeName = "int")]
        [Key]
        [JsonProperty("id")]
        public Int32 Id { get; set; }

        [Column("division_codigo", TypeName = "varchar")]
        [JsonProperty("division_codigo")]
        public String DivisionCodigo { get; set; }

        [Column("banco_id", TypeName = "int")]
        [ForeignKey("FkCuentasBancariasBanco")]
        [JsonProperty("banco_id")]
        public Int32 BancoId { get; set; }

        [Column("moneda_id", TypeName = "int")]
        [JsonProperty("moneda_id")]
        public Int32 MonedaId { get; set; }

        [Column("cuenta", TypeName = "varchar")]
        [JsonProperty("cuenta")]
        public String Cuenta { get; set; }

        [Column("usuario_crea", TypeName = "varchar")]
        [JsonProperty("usuario_crea")]
        public String UsuarioCrea { get; set; }

        [Column("fecha_crea", TypeName = "datetime")]
        [JsonProperty("fecha_crea")]
        public DateTime FechaCrea { get; set; }

        [Column("usuario_modifica", TypeName = "varchar")]
        [JsonProperty("usuario_modifica")]
        public String UsuarioModifica { get; set; }

        [Column("fecha_modifica", TypeName = "datetime")]
        [JsonProperty("fecha_modifica")]
        public DateTime FechaModifica { get; set; }

        [Column("pais_id", TypeName = "int")]
        [ForeignKey("FkTbCuentasBancariasPais")]
        [JsonProperty("pais_id")]
        public Int32 PaisId { get; set; }

        [JsonIgnore]
        public virtual TbDicBancos FkCuentasBancariasBanco { get; set; }

        [JsonIgnore]
        public virtual TbPaises FkTbCuentasBancariasPais { get; set; }

        #region ShouldSerialize
        public bool ShouldSerializeId()
        {
            return (!this.NotSerializeId);
        }

        public bool ShouldSerializeDivisionCodigo()
        {
            return (!this.NotSerializeDivisionCodigo);
        }

        public bool ShouldSerializeBancoId()
        {
            return (!this.NotSerializeBancoId);
        }

        public bool ShouldSerializeMonedaId()
        {
            return (!this.NotSerializeMonedaId);
        }

        public bool ShouldSerializeCuenta()
        {
            return (!this.NotSerializeCuenta);
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

        public bool ShouldSerializePaisId()
        {
            return (!this.NotSerializePaisId);
        }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDivisionCodigo { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeBancoId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeMonedaId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeCuenta { get; set; }

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
        public bool NotSerializePaisId { get; set; }

        #endregion
    }
}
