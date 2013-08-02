namespace Neudesic.BizTalkRESTDemo.Schema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"GeocodeResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GeocodeResponse"})]
    public sealed class GeocodeResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""GeocodeResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""status"" type=""xs:string"" />
        <xs:element name=""result"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""type"" type=""xs:string"" />
              <xs:element name=""formatted_address"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""address_component"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""long_name"" type=""xs:string"" />
                    <xs:element name=""short_name"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""type"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""geometry"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""location"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""lat"" type=""xs:float"" />
                          <xs:element name=""lng"" type=""xs:float"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""location_type"" type=""xs:string"" />
                    <xs:element name=""viewport"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""southwest"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""lat"" type=""xs:float"" />
                                <xs:element name=""lng"" type=""xs:float"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""northeast"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""lat"" type=""xs:float"" />
                                <xs:element name=""lng"" type=""xs:float"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GeocodeResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "GeocodeResponse";
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
