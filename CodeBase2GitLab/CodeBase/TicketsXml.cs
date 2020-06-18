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
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class tickets
    {
        /// <remarks/>
        [XmlElement("ticket")]
        public Ticket[] ticket
        {
            get { return ticketField; }
            set { ticketField = value; }
        }
        /// <remarks/>
        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }
        private Ticket[] ticketField;
        private string typeField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Ticket
    {
        /// <remarks/>
        [XmlElement("ticket-id")]
        public Ticketid ticketid
        {
            get { return ticketidField; }
            set { ticketidField = value; }
        }
        /// <remarks/>
        public string summary
        {
            get { return summaryField; }
            set { summaryField = value; }
        }
        /// <remarks/>
        [XmlElement("ticket-type")]
        public string tickettype
        {
            get { return tickettypeField; }
            set { tickettypeField = value; }
        }
        /// <remarks/>
        [XmlElement("reporter-id")]
        public Reporterid reporterid
        {
            get { return reporteridField; }
            set { reporteridField = value; }
        }
        /// <remarks/>
        [XmlElement("assignee-id")]
        public Assigneeid assigneeid
        {
            get { return assigneeidField; }
            set { assigneeidField = value; }
        }
        /// <remarks/>
        public Assignee assignee
        {
            get { return assigneeField; }
            set { assigneeField = value; }
        }
        /// <remarks/>
        public Reporter reporter
        {
            get { return reporterField; }
            set { reporterField = value; }
        }
        /// <remarks/>
        [XmlElement("category-id")]
        public Categoryid categoryid
        {
            get { return categoryidField; }
            set { categoryidField = value; }
        }
        /// <remarks/>
        public Category category
        {
            get { return categoryField; }
            set { categoryField = value; }
        }
        /// <remarks/>
        [XmlElement("priority-id")]
        public Priorityid priorityid
        {
            get { return priorityidField; }
            set { priorityidField = value; }
        }
        /// <remarks/>
        public Priority priority
        {
            get { return priorityField; }
            set { priorityField = value; }
        }
        /// <remarks/>
        [XmlElement("status-id")]
        public Statusid statusid
        {
            get { return statusidField; }
            set { statusidField = value; }
        }
        /// <remarks/>
        public Status status
        {
            get { return statusField; }
            set { statusField = value; }
        }
        /// <remarks/>
        [XmlElement("type-id")]
        public Typeid typeid
        {
            get { return typeidField; }
            set { typeidField = value; }
        }
        /// <remarks/>
        public Type type
        {
            get { return typeField; }
            set { typeField = value; }
        }
        /// <remarks/>
        [XmlElement("milestone-id")]
        public Milestoneid milestoneid
        {
            get { return milestoneidField; }
            set { milestoneidField = value; }
        }
        /// <remarks/>
        public Milestone milestone
        {
            get { return milestoneField; }
            set { milestoneField = value; }
        }
        /// <remarks/>
        [XmlElement("start-on")]
        public Starton starton
        {
            get { return startonField; }
            set { startonField = value; }
        }
        /// <remarks/>
        public Deadline deadline
        {
            get { return deadlineField; }
            set { deadlineField = value; }
        }
        /// <remarks/>
        public object tags
        {
            get { return tagsField; }
            set { tagsField = value; }
        }
        /// <remarks/>
        [XmlElement("updated-at")]
        public Updatedat updatedat
        {
            get { return updatedatField; }
            set { updatedatField = value; }
        }
        /// <remarks/>
        [XmlElement("created-at")]
        public Createdat createdat
        {
            get { return createdatField; }
            set { createdatField = value; }
        }
        /// <remarks/>
        [XmlElement("estimated-time")]
        public Estimatedtime estimatedtime
        {
            get { return estimatedtimeField; }
            set { estimatedtimeField = value; }
        }
        /// <remarks/>
        [XmlElement("project-id")]
        public Projectid projectid
        {
            get { return projectidField; }
            set { projectidField = value; }
        }
        /// <remarks/>
        [XmlElement("total-time-spent")]
        public Totaltimespent totaltimespent
        {
            get { return totaltimespentField; }
            set { totaltimespentField = value; }
        }
        public ticketnotes ticketnotes
        {
            get { return ticketnotesField; }
            set { ticketnotesField = value; }
        }
        private Ticketid ticketidField;
        private string summaryField;
        private string tickettypeField;
        private Reporterid reporteridField;
        private Assigneeid assigneeidField;
        private Assignee assigneeField;
        private Reporter reporterField;
        private Categoryid categoryidField;
        private Category categoryField;
        private Priorityid priorityidField;
        private Priority priorityField;
        private Statusid statusidField;
        private Status statusField;
        private Typeid typeidField;
        private Type typeField;
        private Milestoneid milestoneidField;
        private Milestone milestoneField;
        private Starton startonField;
        private Deadline deadlineField;
        private object tagsField;
        private Updatedat updatedatField;
        private Createdat createdatField;
        private Estimatedtime estimatedtimeField;
        private Projectid projectidField;
        private Totaltimespent totaltimespentField;
        private ticketnotes ticketnotesField;

    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Ticketid
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
        public ushort Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private ushort valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Reporterid
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
    public class Assigneeid
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Assignee
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Reporter
    {
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
        private bool nilField;
        private bool nilFieldSpecified;
        private string valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Categoryid
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
    public class Category
    {
        /// <remarks/>
        public CategoryID id
        {
            get { return idField; }
            set { idField = value; }
        }
        /// <remarks/>
        public string name
        {
            get { return nameField; }
            set { nameField = value; }
        }
        private CategoryID idField;
        private string nameField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class CategoryID
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
    public class Priorityid
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
    public class Priority
    {
        /// <remarks/>
        public PriorityID id
        {
            get { return idField; }
            set { idField = value; }
        }
        /// <remarks/>
        public string name
        {
            get { return nameField; }
            set { nameField = value; }
        }
        /// <remarks/>
        public string colour
        {
            get { return colourField; }
            set { colourField = value; }
        }
        /// <remarks/>
        public PriorityDefault @default
        {
            get { return defaultField; }
            set { defaultField = value; }
        }
        /// <remarks/>
        public PriorityPosition position
        {
            get { return positionField; }
            set { positionField = value; }
        }
        private PriorityID idField;
        private string nameField;
        private string colourField;
        private PriorityDefault defaultField;
        private PriorityPosition positionField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PriorityID
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
    public class PriorityDefault
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
        public bool Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private bool valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PriorityPosition
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
        public byte Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private byte valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Statusid
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
    public class Status
    {
        /// <remarks/>
        public StatusID id
        {
            get { return idField; }
            set { idField = value; }
        }
        /// <remarks/>
        public string name
        {
            get { return nameField; }
            set { nameField = value; }
        }
        /// <remarks/>
        public string colour
        {
            get { return colourField; }
            set { colourField = value; }
        }
        /// <remarks/>
        public StatusOrder order
        {
            get { return orderField; }
            set { orderField = value; }
        }
        /// <remarks/>
        [XmlElement("treat-as-closed")]
        public StatusTreatasclosed treatasclosed
        {
            get { return treatasclosedField; }
            set { treatasclosedField = value; }
        }
        private StatusID idField;
        private string nameField;
        private string colourField;
        private StatusOrder orderField;
        private StatusTreatasclosed treatasclosedField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class StatusID
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
    public class StatusOrder
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
        public byte Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private byte valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class StatusTreatasclosed
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
        public bool Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private bool valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Typeid
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
    public class Type
    {
        /// <remarks/>
        public TypeID id
        {
            get { return idField; }
            set { idField = value; }
        }
        /// <remarks/>
        public string name
        {
            get { return nameField; }
            set { nameField = value; }
        }
        /// <remarks/>
        public string icon
        {
            get { return iconField; }
            set { iconField = value; }
        }
        private TypeID idField;
        private string nameField;
        private string iconField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class TypeID
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
    public class Milestoneid
    {
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
        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }
        /// <remarks/>
        [XmlText]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private bool nilField;
        private bool nilFieldSpecified;
        private string typeField;
        private string valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Milestone
    {
        /// <remarks/>
        public MilestoneID id
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
        public string name
        {
            get { return nameField; }
            set { nameField = value; }
        }
        /// <remarks/>
        [XmlElement("start-at")]
        public MilestoneStartat startat
        {
            get { return startatField; }
            set { startatField = value; }
        }
        /// <remarks/>
        public MilestoneDeadline deadline
        {
            get { return deadlineField; }
            set { deadlineField = value; }
        }
        /// <remarks/>
        [XmlElement("parent-id")]
        public MilestoneParentid parentid
        {
            get { return parentidField; }
            set { parentidField = value; }
        }
        /// <remarks/>
        public string description
        {
            get { return descriptionField; }
            set { descriptionField = value; }
        }
        /// <remarks/>
        [XmlElement("responsible-user-id")]
        public MilestoneResponsibleuserid responsibleuserid
        {
            get { return responsibleuseridField; }
            set { responsibleuseridField = value; }
        }
        /// <remarks/>
        [XmlElement("estimated-time")]
        public MilestoneEstimatedtime estimatedtime
        {
            get { return estimatedtimeField; }
            set { estimatedtimeField = value; }
        }
        /// <remarks/>
        public string status
        {
            get { return statusField; }
            set { statusField = value; }
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
        private MilestoneID idField;
        private string identifierField;
        private string nameField;
        private MilestoneStartat startatField;
        private MilestoneDeadline deadlineField;
        private MilestoneParentid parentidField;
        private string descriptionField;
        private MilestoneResponsibleuserid responsibleuseridField;
        private MilestoneEstimatedtime estimatedtimeField;
        private string statusField;
        private bool nilField;
        private bool nilFieldSpecified;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class MilestoneID
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
    public class MilestoneStartat
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class MilestoneDeadline
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class MilestoneParentid
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class MilestoneResponsibleuserid
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class MilestoneEstimatedtime
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
        public byte Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private byte valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Starton
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Deadline
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Updatedat
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
        public DateTime Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private DateTime valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Createdat
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
        public DateTime Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private DateTime valueField;
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Estimatedtime
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

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Projectid
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
    public class Totaltimespent
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
        public byte Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
        private string typeField;
        private byte valueField;
    }
}