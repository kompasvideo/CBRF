﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Этот исходный код был создан с помощью xsd, версия=4.6.1590.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:cbr-ru:ed:v2.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:cbr-ru:ed:v2.0", IsNullable=false)]
public partial class ED807 {
    
    private ED807BICDirectoryEntry[] bICDirectoryEntryField;
    
    private string eDNoField;
    
    private string eDDateField;
    
    private string eDAuthorField;
    
    private string creationReasonField;
    
    private string creationDateTimeField;
    
    private string infoTypeCodeField;
    
    private string businessDayField;
    
    private string directoryVersionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BICDirectoryEntry")]
    public ED807BICDirectoryEntry[] BICDirectoryEntry {
        get {
            return this.bICDirectoryEntryField;
        }
        set {
            this.bICDirectoryEntryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EDNo {
        get {
            return this.eDNoField;
        }
        set {
            this.eDNoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EDDate {
        get {
            return this.eDDateField;
        }
        set {
            this.eDDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EDAuthor {
        get {
            return this.eDAuthorField;
        }
        set {
            this.eDAuthorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CreationReason {
        get {
            return this.creationReasonField;
        }
        set {
            this.creationReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CreationDateTime {
        get {
            return this.creationDateTimeField;
        }
        set {
            this.creationDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string InfoTypeCode {
        get {
            return this.infoTypeCodeField;
        }
        set {
            this.infoTypeCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BusinessDay {
        get {
            return this.businessDayField;
        }
        set {
            this.businessDayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DirectoryVersion {
        get {
            return this.directoryVersionField;
        }
        set {
            this.directoryVersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:cbr-ru:ed:v2.0")]
public partial class ED807BICDirectoryEntry {
    
    private ED807BICDirectoryEntryParticipantInfo[] participantInfoField;
    
    private ED807BICDirectoryEntrySWBICS[] sWBICSField;
    
    private ED807BICDirectoryEntryAccounts[] accountsField;
    
    private string bICField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ParticipantInfo")]
    public ED807BICDirectoryEntryParticipantInfo[] ParticipantInfo {
        get {
            return this.participantInfoField;
        }
        set {
            this.participantInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SWBICS")]
    public ED807BICDirectoryEntrySWBICS[] SWBICS {
        get {
            return this.sWBICSField;
        }
        set {
            this.sWBICSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Accounts")]
    public ED807BICDirectoryEntryAccounts[] Accounts {
        get {
            return this.accountsField;
        }
        set {
            this.accountsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BIC {
        get {
            return this.bICField;
        }
        set {
            this.bICField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:cbr-ru:ed:v2.0")]
public partial class ED807BICDirectoryEntryParticipantInfo {
    
    private ED807BICDirectoryEntryParticipantInfoRstrList[] rstrListField;
    
    private string namePField;
    
    private string cntrCdField;
    
    private string rgnField;
    
    private string indField;
    
    private string tnpField;
    
    private string nnpField;
    
    private string adrField;
    
    private string dateInField;
    
    private string ptTypeField;
    
    private string srvcsField;
    
    private string xchTypeField;
    
    private string uIDField;
    
    private string participantStatusField;
    
    private string prntBICField;
    
    private string regNField;
    
    private string englNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RstrList")]
    public ED807BICDirectoryEntryParticipantInfoRstrList[] RstrList {
        get {
            return this.rstrListField;
        }
        set {
            this.rstrListField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NameP {
        get {
            return this.namePField;
        }
        set {
            this.namePField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CntrCd {
        get {
            return this.cntrCdField;
        }
        set {
            this.cntrCdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Rgn {
        get {
            return this.rgnField;
        }
        set {
            this.rgnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Ind {
        get {
            return this.indField;
        }
        set {
            this.indField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Tnp {
        get {
            return this.tnpField;
        }
        set {
            this.tnpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nnp {
        get {
            return this.nnpField;
        }
        set {
            this.nnpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Adr {
        get {
            return this.adrField;
        }
        set {
            this.adrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DateIn {
        get {
            return this.dateInField;
        }
        set {
            this.dateInField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PtType {
        get {
            return this.ptTypeField;
        }
        set {
            this.ptTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Srvcs {
        get {
            return this.srvcsField;
        }
        set {
            this.srvcsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string XchType {
        get {
            return this.xchTypeField;
        }
        set {
            this.xchTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UID {
        get {
            return this.uIDField;
        }
        set {
            this.uIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ParticipantStatus {
        get {
            return this.participantStatusField;
        }
        set {
            this.participantStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PrntBIC {
        get {
            return this.prntBICField;
        }
        set {
            this.prntBICField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RegN {
        get {
            return this.regNField;
        }
        set {
            this.regNField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EnglName {
        get {
            return this.englNameField;
        }
        set {
            this.englNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:cbr-ru:ed:v2.0")]
public partial class ED807BICDirectoryEntryParticipantInfoRstrList {
    
    private string rstrField;
    
    private string rstrDateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Rstr {
        get {
            return this.rstrField;
        }
        set {
            this.rstrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RstrDate {
        get {
            return this.rstrDateField;
        }
        set {
            this.rstrDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:cbr-ru:ed:v2.0")]
public partial class ED807BICDirectoryEntrySWBICS {
    
    private string sWBICField;
    
    private string defaultSWBICField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SWBIC {
        get {
            return this.sWBICField;
        }
        set {
            this.sWBICField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DefaultSWBIC {
        get {
            return this.defaultSWBICField;
        }
        set {
            this.defaultSWBICField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:cbr-ru:ed:v2.0")]
public partial class ED807BICDirectoryEntryAccounts {
    
    private ED807BICDirectoryEntryAccountsAccRstrList[] accRstrListField;
    
    private string accountField;
    
    private string regulationAccountTypeField;
    
    private string ckField;
    
    private string accountCBRBICField;
    
    private string dateInField;
    
    private string accountStatusField;
    
    private string dateOutField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AccRstrList")]
    public ED807BICDirectoryEntryAccountsAccRstrList[] AccRstrList {
        get {
            return this.accRstrListField;
        }
        set {
            this.accRstrListField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Account {
        get {
            return this.accountField;
        }
        set {
            this.accountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RegulationAccountType {
        get {
            return this.regulationAccountTypeField;
        }
        set {
            this.regulationAccountTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CK {
        get {
            return this.ckField;
        }
        set {
            this.ckField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AccountCBRBIC {
        get {
            return this.accountCBRBICField;
        }
        set {
            this.accountCBRBICField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DateIn {
        get {
            return this.dateInField;
        }
        set {
            this.dateInField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AccountStatus {
        get {
            return this.accountStatusField;
        }
        set {
            this.accountStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DateOut {
        get {
            return this.dateOutField;
        }
        set {
            this.dateOutField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:cbr-ru:ed:v2.0")]
public partial class ED807BICDirectoryEntryAccountsAccRstrList {
    
    private string accRstrField;
    
    private string accRstrDateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AccRstr {
        get {
            return this.accRstrField;
        }
        set {
            this.accRstrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AccRstrDate {
        get {
            return this.accRstrDateField;
        }
        set {
            this.accRstrDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:cbr-ru:ed:v2.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:cbr-ru:ed:v2.0", IsNullable=false)]
public partial class NewDataSet {
    
    private ED807[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ED807")]
    public ED807[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}