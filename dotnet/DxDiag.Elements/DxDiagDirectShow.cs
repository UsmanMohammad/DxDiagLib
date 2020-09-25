namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectShow
    {

        private string preferredDShowFiltersField;

        private DxDiagDirectShowFilter[] filterField;

        /// <remarks/>
        public string PreferredDShowFilters
        {
            get
            {
                return this.preferredDShowFiltersField;
            }
            set
            {
                this.preferredDShowFiltersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Filter")]
        public DxDiagDirectShowFilter[] Filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }
    }



}
