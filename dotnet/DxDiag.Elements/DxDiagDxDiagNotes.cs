namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDxDiagNotes
    {

        private string displayTabField;

        private string[] soundTabField;

        private string inputTabField;

        /// <remarks/>
        public string DisplayTab
        {
            get
            {
                return this.displayTabField;
            }
            set
            {
                this.displayTabField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SoundTab")]
        public string[] SoundTab
        {
            get
            {
                return this.soundTabField;
            }
            set
            {
                this.soundTabField = value;
            }
        }

        /// <remarks/>
        public string InputTab
        {
            get
            {
                return this.inputTabField;
            }
            set
            {
                this.inputTabField = value;
            }
        }
    }



}
