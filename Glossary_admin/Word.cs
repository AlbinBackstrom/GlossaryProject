namespace Glossary_Admin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Word")]
    public partial class Word
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Word1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Word2 { get; set; }

        public int TestId { get; set; }

        public virtual Test Test { get; set; }
    }
}
