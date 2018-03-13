namespace Glossary_Admin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Result")]
    public partial class Result
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int CorrectWords { get; set; }

        public int NumberOfQuestions { get; set; }

        public int TestId { get; set; }

        public virtual Test Test { get; set; }
    }
}
