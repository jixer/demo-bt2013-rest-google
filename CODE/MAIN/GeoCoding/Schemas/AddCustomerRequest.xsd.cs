namespace Neudesic.BizTalkRESTDemo.Schema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Neudesic.BizTalkRESTDemo.Schema.AddCustomerRequest",@"AddCustomerRequest")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Neudesic.BizTalkRESTDemo.Schema.PropertySchema.FullAddress), XPath = @"/*[local-name()='AddCustomerRequest' and namespace-uri()='http://Neudesic.BizTalkRESTDemo.Schema.AddCustomerRequest']/*[local-name()='FullAddress' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "FirstName", XPath = @"/*[local-name()='AddCustomerRequest' and namespace-uri()='http://Neudesic.BizTalkRESTDemo.Schema.AddCustomerRequest']/*[local-name()='FirstName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "LastName", XPath = @"/*[local-name()='AddCustomerRequest' and namespace-uri()='http://Neudesic.BizTalkRESTDemo.Schema.AddCustomerRequest']/*[local-name()='LastName' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddCustomerRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Neudesic.BizTalkRESTDemo.Schema.PropertySchema.PropertySchema", typeof(global::Neudesic.BizTalkRESTDemo.Schema.PropertySchema.PropertySchema))]
    public sealed class AddCustomerRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Neudesic.BizTalkRESTDemo.Schema.AddCustomerRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Neudesic.BizTalkRESTDemo.Schema.PropertySchema"" targetNamespace=""http://Neudesic.BizTalkRESTDemo.Schema.AddCustomerRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Neudesic.BizTalkRESTDemo.Schema.PropertySchema"" location=""Neudesic.BizTalkRESTDemo.Schema.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AddCustomerRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""AddCustomerRequest"" />
        <b:properties>
          <b:property name=""ns0:FullAddress"" xpath=""/*[local-name()='AddCustomerRequest' and namespace-uri()='http://Neudesic.BizTalkRESTDemo.Schema.AddCustomerRequest']/*[local-name()='FullAddress' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddCustomerRequest' and namespace-uri()='http://Neudesic.BizTalkRESTDemo.Schema.AddCustomerRequest']/*[local-name()='FirstName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AddCustomerRequest' and namespace-uri()='http://Neudesic.BizTalkRESTDemo.Schema.AddCustomerRequest']/*[local-name()='LastName' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""FullAddress"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AddCustomerRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AddCustomerRequest";
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
