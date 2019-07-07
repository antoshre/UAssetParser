using System.ComponentModel;
using System.Runtime.Serialization;
using UAssetParser.Formats;
/*
 * TODO: Work out if this class needs to be customized.  I just copied Int32Property and changed the name...
 */
namespace UAssetParser.Objects.Visitors.Unreal
{
    [DataContract, Description("UInt32Property"), Category("Unreal")]
    public class UInt32Property : FPropertyTag
    {
        [DataMember]
        public int Value { get; set; }

        [DataMember]
        public FPropertyGuid Guid { get; set; }

        public override object GetValue()
        {
            return Value;
        }
    }
}
