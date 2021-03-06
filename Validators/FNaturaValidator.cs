using BusinessObjects.Validators;

namespace FatturaElettronicaPA.Validators
{
    /// <summary>
    /// Validates FatturaElettronicaBody.DatiGenerali.DatiGeneraliDocumento.DatiCassaPrevidenziale.Natura
    /// </summary>
    public class FNaturaValidator : DomainValidator
    {

        private const string BrokenDescription = "Valori ammessi [N1], [N2], [..], [N5])";

        /// <summary>
        /// Constructor.
        /// </summary>
        public FNaturaValidator() : this(null, BrokenDescription) { }
        public FNaturaValidator(string propertyName) : this(propertyName, BrokenDescription) { }
        public FNaturaValidator(string propertyName, string description) : base(propertyName, description)
        {
            Domain = new[] { "N1", "N2", "N3", "N4", "N5" };
        }
    }
}
