using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ToolBuddy.CodeBase2GitLab.CodeBase
{
    /// <remarks>
    /// Auto generated using XML Schema Definition Tool (Xsd.exe)
    /// https://msdn.microsoft.com/en-us/library/x6c1kb0s(v=VS.100).aspx
    /// </remarks>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot("ticket-notes", Namespace = "", IsNullable = false)]
    public class ticketnotes
    {
        /// <remarks/>
        [XmlElement("ticket-note")]
        public Ticketnote[] ticketnote
        {
            get { return field; }
            set { field = value; }
        }
        /// <remarks/>
        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }
        private Ticketnote[] field;
        private string typeField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Ticketnote
    {
        /// <remarks/>
        public Attachments attachments
        {
            get { return attachmentsField; }
            set { attachmentsField = value; }
        }
        /// <remarks/>
        public string content
        {
            get { return contentField; }
            set { contentField = value; }
        }
        /// <remarks/>
        [XmlElement("created-at")]
        public Createdat createdat
        {
            get { return createdatField; }
            set { createdatField = value; }
        }
        /// <remarks/>
        [XmlElement("updated-at")]
        public Updatedat updatedat
        {
            get { return updatedatField; }
            set { updatedatField = value; }
        }
        /// <remarks/>
        public noteID id
        {
            get { return idField; }
            set { idField = value; }
        }
        /// <remarks/>
        [XmlElement("user-id")]
        public Userid userid
        {
            get { return useridField; }
            set { useridField = value; }
        }
        /// <remarks/>
        public string updates
        {
            get { return updatesField; }
            set { updatesField = value; }
        }
        /// <remarks/>
        [XmlElement("company-id")]
        public Companyid companyid
        {
            get { return companyidField; }
            set { companyidField = value; }
        }
        private Attachments attachmentsField;
        private string contentField;
        private Createdat createdatField;
        private Updatedat updatedatField;
        private noteID idField;
        private Userid useridField;
        private string updatesField;
        private Companyid companyidField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Attachments
    {
        /// <remarks/>
        [XmlElement("attachment")]
        public Attachment[] attachment
        {
            get { return attachmentField; }
            set { attachmentField = value; }
        }
        /// <remarks/>
        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }
        private Attachment[] attachmentField;
        private string typeField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Attachment
    {
        /// <remarks/>
        public AttachmentID id
        {
            get { return idField; }
            set { idField = value; }
        }
        /// <remarks/>
        public string identifier
        {
            get { return identifierField; }
            set { identifierField = value; }
        }
        /// <remarks/>
        [XmlElement("file-name")]
        public string filename
        {
            get { return filenameField; }
            set { filenameField = value; }
        }
        /// <remarks/>
        [XmlElement("content-type")]
        public string contenttype
        {
            get { return contenttypeField; }
            set { contenttypeField = value; }
        }
        /// <remarks/>
        [XmlElement("file-size")]
        public AttachmentFilesize filesize
        {
            get { return filesizeField; }
            set { filesizeField = value; }
        }
        /// <remarks/>
        public string url
        {
            get { return urlField; }
            set { urlField = value; }
        }
        private AttachmentID idField;
        private string identifierField;
        private string filenameField;
        private string contenttypeField;
        private AttachmentFilesize filesizeField;
        private string urlField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AttachmentID
    {
        /// <remarks/>
        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }
        /// <remarks/>
        [XmlText]
        public uint Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private uint valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AttachmentFilesize
    {
        /// <remarks/>
        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }
        /// <remarks/>
        [XmlText]
        public uint Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private uint valueField;
    }


    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class noteID
    {
        /// <remarks/>
        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }
        /// <remarks/>
        [XmlText]
        public uint Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private uint valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Userid
    {
        /// <remarks/>
        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }
        /// <remarks/>
        [XmlAttribute]
        public bool nil
        {
            get { return nilField; }
            set { nilField = value; }
        }
        /// <remarks/>
        [XmlIgnore]
        public bool nilSpecified
        {
            get { return nilFieldSpecified; }
            set { nilFieldSpecified = value; }
        }
        /// <remarks/>
        [XmlText]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private bool nilField;
        private bool nilFieldSpecified;
        private string valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Companyid
    {
        /// <remarks/>
        [XmlAttribute]
        public bool nil
        {
            get { return nilField; }
            set { nilField = value; }
        }
        private bool nilField;
    }
}