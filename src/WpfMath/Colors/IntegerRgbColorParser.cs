using System.Globalization;

namespace WpfMath.Colors
{
    internal class IntegerRgbColorParser : RgbColorParserBase<byte>
    {
        protected override (bool, byte) TryParseComponent(string component)
        {
            var success = byte.TryParse(component, NumberStyles.None, CultureInfo.InvariantCulture, out var val);
            return (success, val);
        }

        protected override byte GetByteValue(byte val) => val;
    }
}
