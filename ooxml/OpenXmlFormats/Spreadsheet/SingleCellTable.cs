// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
    [Serializable]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot("table",Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public class CT_Table
    {

        private CT_AutoFilter autoFilterField;

        private CT_SortState sortStateField;

        private CT_TableColumns tableColumnsField;

        private CT_TableStyleInfo tableStyleInfoField;

        private CT_ExtensionList extLstField;

        private uint idField;

        private string nameField;

        private string displayNameField;

        private string commentField;

        private string refField;

        private ST_TableType tableTypeField;

        private uint headerRowCountField;

        private bool insertRowField;

        private bool insertRowShiftField;

        private uint totalsRowCountField;

        private bool totalsRowShownField;

        private bool publishedField;

        private uint headerRowDxfIdField;

        private bool headerRowDxfIdFieldSpecified;

        private uint dataDxfIdField;

        private bool dataDxfIdFieldSpecified;

        private uint totalsRowDxfIdField;

        private bool totalsRowDxfIdFieldSpecified;

        private uint headerRowBorderDxfIdField;

        private bool headerRowBorderDxfIdFieldSpecified;

        private uint tableBorderDxfIdField;

        private bool tableBorderDxfIdFieldSpecified;

        private uint totalsRowBorderDxfIdField;

        private bool totalsRowBorderDxfIdFieldSpecified;

        private string headerRowCellStyleField;

        private string dataCellStyleField;

        private string totalsRowCellStyleField;

        private uint connectionIdField;

        private bool connectionIdFieldSpecified;

        public CT_Table()
        {
            this.extLstField = new CT_ExtensionList();
            this.tableStyleInfoField = new CT_TableStyleInfo();
            this.tableColumnsField = new CT_TableColumns();
            this.sortStateField = new CT_SortState();
            this.autoFilterField = new CT_AutoFilter();
            this.tableTypeField = ST_TableType.worksheet;
            this.headerRowCountField = ((uint)(1));
            this.insertRowField = false;
            this.insertRowShiftField = false;
            this.totalsRowCountField = ((uint)(0));
            this.totalsRowShownField = true;
            this.publishedField = false;
        }

        public CT_AutoFilter autoFilter
        {
            get
            {
                return this.autoFilterField;
            }
            set
            {
                this.autoFilterField = value;
            }
        }

        public CT_SortState sortState
        {
            get
            {
                return this.sortStateField;
            }
            set
            {
                this.sortStateField = value;
            }
        }

        public CT_TableColumns tableColumns
        {
            get
            {
                return this.tableColumnsField;
            }
            set
            {
                this.tableColumnsField = value;
            }
        }

        public CT_TableStyleInfo tableStyleInfo
        {
            get
            {
                return this.tableStyleInfoField;
            }
            set
            {
                this.tableStyleInfoField = value;
            }
        }

        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }
        [XmlAttribute]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        [XmlAttribute]
        public string name
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
        [XmlAttribute]
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
        [XmlAttribute]
        public string comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
        [XmlAttribute]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(ST_TableType.worksheet)]
        public ST_TableType tableType
        {
            get
            {
                return this.tableTypeField;
            }
            set
            {
                this.tableTypeField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(typeof(uint), "1")]
        public uint headerRowCount
        {
            get
            {
                return this.headerRowCountField;
            }
            set
            {
                this.headerRowCountField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool insertRow
        {
            get
            {
                return this.insertRowField;
            }
            set
            {
                this.insertRowField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool insertRowShift
        {
            get
            {
                return this.insertRowShiftField;
            }
            set
            {
                this.insertRowShiftField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(typeof(uint), "0")]
        public uint totalsRowCount
        {
            get
            {
                return this.totalsRowCountField;
            }
            set
            {
                this.totalsRowCountField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(true)]
        public bool totalsRowShown
        {
            get
            {
                return this.totalsRowShownField;
            }
            set
            {
                this.totalsRowShownField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool published
        {
            get
            {
                return this.publishedField;
            }
            set
            {
                this.publishedField = value;
            }
        }
        [XmlAttribute]
        public uint headerRowDxfId
        {
            get
            {
                return this.headerRowDxfIdField;
            }
            set
            {
                this.headerRowDxfIdField = value;
            }
        }
        [XmlIgnore]
        public bool headerRowDxfIdSpecified
        {
            get
            {
                return this.headerRowDxfIdFieldSpecified;
            }
            set
            {
                this.headerRowDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint dataDxfId
        {
            get
            {
                return this.dataDxfIdField;
            }
            set
            {
                this.dataDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool dataDxfIdSpecified
        {
            get
            {
                return this.dataDxfIdFieldSpecified;
            }
            set
            {
                this.dataDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint totalsRowDxfId
        {
            get
            {
                return this.totalsRowDxfIdField;
            }
            set
            {
                this.totalsRowDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool totalsRowDxfIdSpecified
        {
            get
            {
                return this.totalsRowDxfIdFieldSpecified;
            }
            set
            {
                this.totalsRowDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint headerRowBorderDxfId
        {
            get
            {
                return this.headerRowBorderDxfIdField;
            }
            set
            {
                this.headerRowBorderDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool headerRowBorderDxfIdSpecified
        {
            get
            {
                return this.headerRowBorderDxfIdFieldSpecified;
            }
            set
            {
                this.headerRowBorderDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint tableBorderDxfId
        {
            get
            {
                return this.tableBorderDxfIdField;
            }
            set
            {
                this.tableBorderDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool tableBorderDxfIdSpecified
        {
            get
            {
                return this.tableBorderDxfIdFieldSpecified;
            }
            set
            {
                this.tableBorderDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint totalsRowBorderDxfId
        {
            get
            {
                return this.totalsRowBorderDxfIdField;
            }
            set
            {
                this.totalsRowBorderDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool totalsRowBorderDxfIdSpecified
        {
            get
            {
                return this.totalsRowBorderDxfIdFieldSpecified;
            }
            set
            {
                this.totalsRowBorderDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public string headerRowCellStyle
        {
            get
            {
                return this.headerRowCellStyleField;
            }
            set
            {
                this.headerRowCellStyleField = value;
            }
        }
        [XmlAttribute]
        public string dataCellStyle
        {
            get
            {
                return this.dataCellStyleField;
            }
            set
            {
                this.dataCellStyleField = value;
            }
        }
        [XmlAttribute]
        public string totalsRowCellStyle
        {
            get
            {
                return this.totalsRowCellStyleField;
            }
            set
            {
                this.totalsRowCellStyleField = value;
            }
        }
        [XmlAttribute]
        public uint connectionId
        {
            get
            {
                return this.connectionIdField;
            }
            set
            {
                this.connectionIdField = value;
            }
        }

        [XmlIgnore]
        public bool connectionIdSpecified
        {
            get
            {
                return this.connectionIdFieldSpecified;
            }
            set
            {
                this.connectionIdFieldSpecified = value;
            }
        }
    }

    public class CT_TableColumns
    {

        private List<CT_TableColumn> tableColumnField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_TableColumns()
        {
            this.tableColumnField = new List<CT_TableColumn>();
        }

        public List<CT_TableColumn> tableColumn
        {
            get
            {
                return this.tableColumnField;
            }
            set
            {
                this.tableColumnField = value;
            }
        }

        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        [XmlIgnore]
        public bool countSpecified
        {
            get
            {
                return this.countFieldSpecified;
            }
            set
            {
                this.countFieldSpecified = value;
            }
        }
    }

    public class CT_TableColumn
    {

        private CT_TableFormula calculatedColumnFormulaField;

        private CT_TableFormula totalsRowFormulaField;

        private CT_XmlColumnPr xmlColumnPrField;

        private CT_ExtensionList extLstField;

        private uint idField;

        private string uniqueNameField;

        private string nameField;

        private ST_TotalsRowFunction totalsRowFunctionField;

        private string totalsRowLabelField;

        private uint queryTableFieldIdField;

        private bool queryTableFieldIdFieldSpecified;

        private uint headerRowDxfIdField;

        private bool headerRowDxfIdFieldSpecified;

        private uint dataDxfIdField;

        private bool dataDxfIdFieldSpecified;

        private uint totalsRowDxfIdField;

        private bool totalsRowDxfIdFieldSpecified;

        private string headerRowCellStyleField;

        private string dataCellStyleField;

        private string totalsRowCellStyleField;

        public CT_TableColumn()
        {
            this.extLstField = new CT_ExtensionList();
            this.xmlColumnPrField = new CT_XmlColumnPr();
            this.totalsRowFormulaField = new CT_TableFormula();
            this.calculatedColumnFormulaField = new CT_TableFormula();
            this.totalsRowFunctionField = ST_TotalsRowFunction.none;
        }

        public CT_TableFormula calculatedColumnFormula
        {
            get
            {
                return this.calculatedColumnFormulaField;
            }
            set
            {
                this.calculatedColumnFormulaField = value;
            }
        }

        public CT_TableFormula totalsRowFormula
        {
            get
            {
                return this.totalsRowFormulaField;
            }
            set
            {
                this.totalsRowFormulaField = value;
            }
        }

        public CT_XmlColumnPr xmlColumnPr
        {
            get
            {
                return this.xmlColumnPrField;
            }
            set
            {
                this.xmlColumnPrField = value;
            }
        }

        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        public string uniqueName
        {
            get
            {
                return this.uniqueNameField;
            }
            set
            {
                this.uniqueNameField = value;
            }
        }

        public string name
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

        [DefaultValue(ST_TotalsRowFunction.none)]
        public ST_TotalsRowFunction totalsRowFunction
        {
            get
            {
                return this.totalsRowFunctionField;
            }
            set
            {
                this.totalsRowFunctionField = value;
            }
        }

        public string totalsRowLabel
        {
            get
            {
                return this.totalsRowLabelField;
            }
            set
            {
                this.totalsRowLabelField = value;
            }
        }

        public uint queryTableFieldId
        {
            get
            {
                return this.queryTableFieldIdField;
            }
            set
            {
                this.queryTableFieldIdField = value;
            }
        }

        [XmlIgnore]
        public bool queryTableFieldIdSpecified
        {
            get
            {
                return this.queryTableFieldIdFieldSpecified;
            }
            set
            {
                this.queryTableFieldIdFieldSpecified = value;
            }
        }

        public uint headerRowDxfId
        {
            get
            {
                return this.headerRowDxfIdField;
            }
            set
            {
                this.headerRowDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool headerRowDxfIdSpecified
        {
            get
            {
                return this.headerRowDxfIdFieldSpecified;
            }
            set
            {
                this.headerRowDxfIdFieldSpecified = value;
            }
        }

        public uint dataDxfId
        {
            get
            {
                return this.dataDxfIdField;
            }
            set
            {
                this.dataDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool dataDxfIdSpecified
        {
            get
            {
                return this.dataDxfIdFieldSpecified;
            }
            set
            {
                this.dataDxfIdFieldSpecified = value;
            }
        }

        public uint totalsRowDxfId
        {
            get
            {
                return this.totalsRowDxfIdField;
            }
            set
            {
                this.totalsRowDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool totalsRowDxfIdSpecified
        {
            get
            {
                return this.totalsRowDxfIdFieldSpecified;
            }
            set
            {
                this.totalsRowDxfIdFieldSpecified = value;
            }
        }

        public string headerRowCellStyle
        {
            get
            {
                return this.headerRowCellStyleField;
            }
            set
            {
                this.headerRowCellStyleField = value;
            }
        }

        public string dataCellStyle
        {
            get
            {
                return this.dataCellStyleField;
            }
            set
            {
                this.dataCellStyleField = value;
            }
        }

        public string totalsRowCellStyle
        {
            get
            {
                return this.totalsRowCellStyleField;
            }
            set
            {
                this.totalsRowCellStyleField = value;
            }
        }
    }

    public class CT_TableFormula
    {

        private bool arrayField;

        private string valueField;

        public CT_TableFormula()
        {
            this.arrayField = false;
        }

        [DefaultValue(false)]
        public bool array
        {
            get
            {
                return this.arrayField;
            }
            set
            {
                this.arrayField = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    public class CT_XmlColumnPr
    {

        private CT_ExtensionList extLstField;

        private uint mapIdField;

        private string xpathField;

        private bool denormalizedField;

        private ST_XmlDataType xmlDataTypeField;

        public CT_XmlColumnPr()
        {
            this.extLstField = new CT_ExtensionList();
            this.denormalizedField = false;
        }

        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        public uint mapId
        {
            get
            {
                return this.mapIdField;
            }
            set
            {
                this.mapIdField = value;
            }
        }

        public string xpath
        {
            get
            {
                return this.xpathField;
            }
            set
            {
                this.xpathField = value;
            }
        }

        [DefaultValue(false)]
        public bool denormalized
        {
            get
            {
                return this.denormalizedField;
            }
            set
            {
                this.denormalizedField = value;
            }
        }

        public ST_XmlDataType xmlDataType
        {
            get
            {
                return this.xmlDataTypeField;
            }
            set
            {
                this.xmlDataTypeField = value;
            }
        }
    }

    public enum ST_XmlDataType
    {

    
        @string,

    
        normalizedString,

    
        token,

    
        @byte,

    
        unsignedByte,

    
        base64Binary,

    
        hexBinary,

    
        integer,

    
        positiveInteger,

    
        negativeInteger,

    
        nonPositiveInteger,

    
        nonNegativeInteger,

    
        @int,

    
        unsignedInt,

    
        @long,

    
        unsignedLong,

    
        @short,

    
        unsignedShort,

    
        @decimal,

    
        @float,

    
        @double,

    
        boolean,

    
        time,

    
        dateTime,

    
        duration,

    
        date,

    
        gMonth,

    
        gYear,

    
        gYearMonth,

    
        gDay,

    
        gMonthDay,

    
        Name,

    
        QName,

    
        NCName,

    
        anyURI,

    
        language,

    
        ID,

    
        IDREF,

    
        IDREFS,

    
        ENTITY,

    
        ENTITIES,

    
        NOTATION,

    
        NMTOKEN,

    
        NMTOKENS,

    
        anyType,
    }

    public enum ST_TotalsRowFunction
    {

    
        none,

    
        sum,

    
        min,

    
        max,

    
        average,

    
        count,

    
        countNums,

    
        stdDev,

    
        var,

    
        custom,
    }

    public class CT_TableStyleInfo
    {

        private string nameField;

        private bool showFirstColumnField;

        private bool showFirstColumnFieldSpecified;

        private bool showLastColumnField;

        private bool showLastColumnFieldSpecified;

        private bool showRowStripesField;

        private bool showRowStripesFieldSpecified;

        private bool showColumnStripesField;

        private bool showColumnStripesFieldSpecified;

        public string name
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

        public bool showFirstColumn
        {
            get
            {
                return this.showFirstColumnField;
            }
            set
            {
                this.showFirstColumnField = value;
            }
        }

        [XmlIgnore]
        public bool showFirstColumnSpecified
        {
            get
            {
                return this.showFirstColumnFieldSpecified;
            }
            set
            {
                this.showFirstColumnFieldSpecified = value;
            }
        }

        public bool showLastColumn
        {
            get
            {
                return this.showLastColumnField;
            }
            set
            {
                this.showLastColumnField = value;
            }
        }

        [XmlIgnore]
        public bool showLastColumnSpecified
        {
            get
            {
                return this.showLastColumnFieldSpecified;
            }
            set
            {
                this.showLastColumnFieldSpecified = value;
            }
        }

        public bool showRowStripes
        {
            get
            {
                return this.showRowStripesField;
            }
            set
            {
                this.showRowStripesField = value;
            }
        }

        [XmlIgnore]
        public bool showRowStripesSpecified
        {
            get
            {
                return this.showRowStripesFieldSpecified;
            }
            set
            {
                this.showRowStripesFieldSpecified = value;
            }
        }

        public bool showColumnStripes
        {
            get
            {
                return this.showColumnStripesField;
            }
            set
            {
                this.showColumnStripesField = value;
            }
        }

        [XmlIgnore]
        public bool showColumnStripesSpecified
        {
            get
            {
                return this.showColumnStripesFieldSpecified;
            }
            set
            {
                this.showColumnStripesFieldSpecified = value;
            }
        }
    }

    public enum ST_TableType
    {

    
        worksheet,

    
        xml,

    
        queryTable,
    }
    [Serializable]
    [System.Diagnostics.DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot("singleXmlCells", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public class CT_SingleXmlCells
    {

        private List<CT_SingleXmlCell> singleXmlCellField;

        public CT_SingleXmlCells()
        {
            this.singleXmlCellField = new List<CT_SingleXmlCell>();
        }

        public List<CT_SingleXmlCell> singleXmlCell
        {
            get
            {
                return this.singleXmlCellField;
            }
            set
            {
                this.singleXmlCellField = value;
            }
        }
    }

    public class CT_SingleXmlCell
    {

        private CT_XmlCellPr xmlCellPrField;

        private CT_ExtensionList extLstField;

        private uint idField;

        private string rField;

        private uint connectionIdField;

        public CT_SingleXmlCell()
        {
            this.extLstField = new CT_ExtensionList();
            this.xmlCellPrField = new CT_XmlCellPr();
        }

        public CT_XmlCellPr xmlCellPr
        {
            get
            {
                return this.xmlCellPrField;
            }
            set
            {
                this.xmlCellPrField = value;
            }
        }

        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        public string r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        public uint connectionId
        {
            get
            {
                return this.connectionIdField;
            }
            set
            {
                this.connectionIdField = value;
            }
        }
    }

    public class CT_XmlCellPr
    {

        private CT_XmlPr xmlPrField;

        private CT_ExtensionList extLstField;

        private uint idField;

        private string uniqueNameField;

        public CT_XmlCellPr()
        {
            this.extLstField = new CT_ExtensionList();
            this.xmlPrField = new CT_XmlPr();
        }

        public CT_XmlPr xmlPr
        {
            get
            {
                return this.xmlPrField;
            }
            set
            {
                this.xmlPrField = value;
            }
        }

        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        public string uniqueName
        {
            get
            {
                return this.uniqueNameField;
            }
            set
            {
                this.uniqueNameField = value;
            }
        }
    }

    public class CT_XmlPr
    {

        private CT_ExtensionList extLstField;

        private uint mapIdField;

        private string xpathField;

        private ST_XmlDataType xmlDataTypeField;

        public CT_XmlPr()
        {
            this.extLstField = new CT_ExtensionList();
        }

        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        public uint mapId
        {
            get
            {
                return this.mapIdField;
            }
            set
            {
                this.mapIdField = value;
            }
        }

        public string xpath
        {
            get
            {
                return this.xpathField;
            }
            set
            {
                this.xpathField = value;
            }
        }

        public ST_XmlDataType xmlDataType
        {
            get
            {
                return this.xmlDataTypeField;
            }
            set
            {
                this.xmlDataTypeField = value;
            }
        }
    }
}
