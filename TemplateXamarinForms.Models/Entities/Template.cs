using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateXamarinForms.Models.Entities
{
    public class Template : BaseModel
    {
        public string Name { get; set; }

        [OneToOne(foreignKey: "TestModelId", CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead)]
        public SecondTemplate TestModel { get; set; }

        [ForeignKey(typeof(SecondTemplate))]
        public int TestModelId { get; set; }
    }
}
