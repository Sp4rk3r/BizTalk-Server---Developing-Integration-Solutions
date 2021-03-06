namespace Mod6 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Mod6.Customer",@"Customer")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Mod6.PropertySchema.Category), XPath = @"/*[local-name()='Customer' and namespace-uri()='http://Mod6.Customer']/*[local-name()='Category' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Customer"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Mod6.PropertySchema.PropertySchema", typeof(global::Mod6.PropertySchema.PropertySchema))]
    public sealed class Customers : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Mod6.Customer"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Mod6.PropertySchema"" targetNamespace=""http://Mod6.Customer"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo root_reference=""Customer"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Mod6.PropertySchema"" location=""Mod6.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Customer"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Category"" xpath=""/*[local-name()='Customer' and namespace-uri()='http://Mod6.Customer']/*[local-name()='Category' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""MiddleName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""ContactNo"" type=""xs:string"" />
        <xs:element name=""Category"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Customers() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Customer";
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
