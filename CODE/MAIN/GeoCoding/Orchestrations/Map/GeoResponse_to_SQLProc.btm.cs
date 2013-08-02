namespace Neudesic.BizTalkRESTDemo.Orchestration.Map {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Neudesic.BizTalkRESTDemo.Schema.GeocodeResponse", typeof(global::Neudesic.BizTalkRESTDemo.Schema.GeocodeResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Neudesic.BizTalkRESTDemo.Schema.sqlBinding_dbo+AddCustomer", typeof(global::Neudesic.BizTalkRESTDemo.Schema.sqlBinding_dbo.AddCustomer))]
    public sealed class GeoResponse_to_SQLProc : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/GeocodeResponse"" />
  </xsl:template>
  <xsl:template match=""/GeocodeResponse"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot; &quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:MathInt(string(result/geometry/location/lat/text()))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:MathInt(string(result/geometry/location/lng/text()))"" />
    <ns0:AddCustomer>
      <ns0:firstName>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </ns0:firstName>
      <ns0:lastName>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </ns0:lastName>
      <street1 xmlns=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"">
<xsl:value-of select=""//address_component[type[text()='street_number']]/long_name/text()"" />
<xsl:text> </xsl:text>
<xsl:value-of select=""//address_component[type[text()='route']]/long_name/text()"" />
</street1>
      <ns0:street2>
        <xsl:value-of select=""$var:v1"" />
      </ns0:street2>
      <city xmlns=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"">
<xsl:value-of select=""//address_component[type[text()='administrative_area_level_2']]/long_name/text()"" />
</city>
      <state xmlns=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"">
<xsl:value-of select=""//address_component[type[text()='administrative_area_level_1']]/short_name/text()"" />
</state>
      <zip xmlns=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"">
<xsl:value-of select=""//address_component[type[text()='postal_code']]/long_name/text()"" />
</zip>
      <ns0:lat>
        <xsl:value-of select=""$var:v2"" />
      </ns0:lat>
      <ns0:long>
        <xsl:value-of select=""$var:v3"" />
      </ns0:long>
    </ns0:AddCustomer>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string MathInt(string val)
{
	string retval = """";
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		try
		{
			int i = Convert.ToInt32(d, System.Globalization.CultureInfo.InvariantCulture);
			if (i > d)
			{
				i = i-1;
			}
			retval = i.ToString(System.Globalization.CultureInfo.InvariantCulture);
		}
		catch (Exception)
		{
		}
	}
	return retval;
}


public string StringConcat(string param0)
{
   return param0;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Neudesic.BizTalkRESTDemo.Schema.GeocodeResponse";
        
        private const global::Neudesic.BizTalkRESTDemo.Schema.GeocodeResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Neudesic.BizTalkRESTDemo.Schema.sqlBinding_dbo+AddCustomer";
        
        private const global::Neudesic.BizTalkRESTDemo.Schema.sqlBinding_dbo.AddCustomer _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Neudesic.BizTalkRESTDemo.Schema.GeocodeResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Neudesic.BizTalkRESTDemo.Schema.sqlBinding_dbo+AddCustomer";
                return _TrgSchemas;
            }
        }
    }
}
