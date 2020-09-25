namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagLogicalDisk
    {

        private string driveLetterField;

        private ulong freeSpaceField;

        private ulong maxSpaceField;

        private string fileSystemField;

        private string modelField;

        private string pNPDeviceIDField;

        private byte hardDriveIndexField;

        private object driversField;

        /// <remarks/>
        public string DriveLetter
        {
            get
            {
                return this.driveLetterField;
            }
            set
            {
                this.driveLetterField = value;
            }
        }

        /// <remarks/>
        public ulong FreeSpace
        {
            get
            {
                return this.freeSpaceField;
            }
            set
            {
                this.freeSpaceField = value;
            }
        }

        /// <remarks/>
        public ulong MaxSpace
        {
            get
            {
                return this.maxSpaceField;
            }
            set
            {
                this.maxSpaceField = value;
            }
        }

        /// <remarks/>
        public string FileSystem
        {
            get
            {
                return this.fileSystemField;
            }
            set
            {
                this.fileSystemField = value;
            }
        }

        /// <remarks/>
        public string Model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        public string PNPDeviceID
        {
            get
            {
                return this.pNPDeviceIDField;
            }
            set
            {
                this.pNPDeviceIDField = value;
            }
        }

        /// <remarks/>
        public byte HardDriveIndex
        {
            get
            {
                return this.hardDriveIndexField;
            }
            set
            {
                this.hardDriveIndexField = value;
            }
        }

        /// <remarks/>
        public object Drivers
        {
            get
            {
                return this.driversField;
            }
            set
            {
                this.driversField = value;
            }
        }
    }



}
