namespace Neudesic.BizTalkRESTDemo.Schema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "firstName", XPath = @"/*[local-name()='AddCustomer' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='firstName' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "lastName", XPath = @"/*[local-name()='AddCustomer' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='lastName' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddCustomer", @"AddCustomerResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Neudesic.BizTalkRESTDemo.Schema.sqlBinding_System_x2eData", typeof(global::Neudesic.BizTalkRESTDemo.Schema.sqlBinding_System_x2eData))]
    public sealed class sqlBinding_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" version=""1.0"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""Neudesic.BizTalkRESTDemo.Schema.sqlBinding_System_x2eData"" namespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
  <annotation>
    <appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Procedure.dbo</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
      </b:references>
    </appinfo>
  </annotation>
  <element name=""AddCustomer"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/AddCustomer</doc:action>
      </documentation>
      <appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddCustomer' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='firstName' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddCustomer' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='lastName' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']"" />
        </b:properties>
      </appinfo>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""0"" maxOccurs=""1"" name=""firstName"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""150"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""lastName"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""150"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""street1"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""255"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""street2"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""255"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""city"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""100"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""state"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""2"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""zip"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""12"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""lat"" nillable=""true"" type=""int"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""long"" nillable=""true"" type=""int"" />
      </sequence>
    </complexType>
  </element>
  <element name=""AddCustomerResponse"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/AddCustomer/response</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""0"" maxOccurs=""1"" name=""AddCustomerResult"" nillable=""true"" type=""ns3:ArrayOfDataSet"" />
        <element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""int"" />
      </sequence>
    </complexType>
  </element>
</schema>";
        
        public sqlBinding_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "AddCustomer";
                _RootElements[1] = "AddCustomerResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"AddCustomer")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "firstName", XPath = @"/*[local-name()='AddCustomer' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='firstName' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "lastName", XPath = @"/*[local-name()='AddCustomer' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']/*[local-name()='lastName' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddCustomer"})]
        public sealed class AddCustomer : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddCustomer() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddCustomer";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"AddCustomerResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddCustomerResponse"})]
        public sealed class AddCustomerResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddCustomerResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddCustomerResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
