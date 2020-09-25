namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectShowFilter
    {

        private string nameField;

        private string filterCatagoryField;

        private uint meritField;

        private byte inputsField;

        private byte outputsField;

        private string fileField;

        private string fileVersionField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string FilterCatagory
        {
            get
            {
                return this.filterCatagoryField;
            }
            set
            {
                this.filterCatagoryField = value;
            }
        }

        /// <remarks/>
        public uint Merit
        {
            get
            {
                return this.meritField;
            }
            set
            {
                this.meritField = value;
            }
        }

        /// <remarks/>
        public byte Inputs
        {
            get
            {
                return this.inputsField;
            }
            set
            {
                this.inputsField = value;
            }
        }

        /// <remarks/>
        public byte Outputs
        {
            get
            {
                return this.outputsField;
            }
            set
            {
                this.outputsField = value;
            }
        }

        /// <remarks/>
        public string File
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <remarks/>
        public string FileVersion
        {
            get
            {
                return this.fileVersionField;
            }
            set
            {
                this.fileVersionField = value;
            }
        }
    }



}
