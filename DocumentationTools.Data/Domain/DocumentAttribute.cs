using System;

namespace DocumentationTools.Data.Domain
{
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public sealed class DocumentAttribute : Attribute
    {
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }


        public DocumentAttribute() { }
        public DocumentAttribute(string description) : this(description, "", "") { }
        public DocumentAttribute(string description, string input, string output)
        {
            Description = description;
            Input = input;
            Output = output;
        }

    }
}
