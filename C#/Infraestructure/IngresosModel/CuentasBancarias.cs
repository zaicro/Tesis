using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.IngresosModel
{
    [Table("cuentas_bancarias", Schema = "dbo")]
    public class CuentasBancarias
    {
        public CuentasBancarias()
        {
        }

        [Column("id", TypeName = "bigint")]
        [Key]
        [JsonProperty("id")]
        public Int64 Id { get; set; }

        [Column("finalEnt", TypeName = "int")]
        [JsonProperty("finalEnt")]
        public Int32 Finalent { get; set; }

        [Column("guidcuentas_bancarias", TypeName = "uniqueidentifier")]
        [JsonProperty("guidcuentas_bancarias")]
        public Guid GuidcuentasBancarias { get; set; }

        [Column("dsblcuentas_bancarias", TypeName = "bit")]
        [JsonProperty("dsblcuentas_bancarias")]
        public Boolean? DsblcuentasBancarias { get; set; }

        [Column("dplycuentas_bancarias", TypeName = "tinyint")]
        [JsonProperty("dplycuentas_bancarias")]
        public Byte? DplycuentasBancarias { get; set; }

        [Column("cuenta", TypeName = "nvarchar")]
        [JsonProperty("cuenta")]
        public String Cuenta { get; set; }

        [Column("banco_id", TypeName = "bigint")]
        [JsonProperty("banco_id")]
        public Int64? BancoId { get; set; }

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

        public bool ShouldSerializeGuidcuentasBancarias()
        {
            return (!this.NotSerializeGuidcuentasBancarias);
        }

        public bool ShouldSerializeDsblcuentasBancarias()
        {
            return (!this.NotSerializeDsblcuentasBancarias);
        }

        public bool ShouldSerializeDplycuentasBancarias()
        {
            return (!this.NotSerializeDplycuentasBancarias);
        }

        public bool ShouldSerializeCuenta()
        {
            return (!this.NotSerializeCuenta);
        }

        public bool ShouldSerializeBancoId()
        {
            return (!this.NotSerializeBancoId);
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
        public bool NotSerializeGuidcuentasBancarias { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDsblcuentasBancarias { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeDplycuentasBancarias { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeCuenta { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeBancoId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeActivo { get; set; }

        #endregion
    }
}
