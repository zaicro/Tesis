using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesisApi.Infraestructure.PeachtreeModel
{
    [Table("tb_dic_bancos", Schema = "parametros")]
    public class TbDicBancos
    {
        public TbDicBancos()
        {
            RefTbCuentasBancarias = new HashSet<TbCuentasBancarias>();
        }

        [Column("banco_id", TypeName = "int")]
        [Key]
        [JsonProperty("banco_id")]
        public Int32 BancoId { get; set; }

        [Column("banco_nombre", TypeName = "varchar")]
        [JsonProperty("banco_nombre")]
        public String BancoNombre { get; set; }

        [Column("banco_estado", TypeName = "bit")]
        [JsonProperty("banco_estado")]
        public Boolean BancoEstado { get; set; }

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

        [JsonIgnore]
        public ICollection<TbCuentasBancarias> RefTbCuentasBancarias { get; set; }

        #region ShouldSerialize
        public bool ShouldSerializeBancoId()
        {
            return (!this.NotSerializeBancoId);
        }

        public bool ShouldSerializeBancoNombre()
        {
            return (!this.NotSerializeBancoNombre);
        }

        public bool ShouldSerializeBancoEstado()
        {
            return (!this.NotSerializeBancoEstado);
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

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeBancoId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeBancoNombre { get; set; }

        [NotMapped]
        [JsonIgnore]
        public bool NotSerializeBancoEstado { get; set; }

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

        #endregion
    }
}
