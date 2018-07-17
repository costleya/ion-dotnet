using System.Runtime.CompilerServices;

namespace IonDotnet.Internals
{
    internal static class IonConstants
    {
        public const int Eof = -1;

        public const int TidNull = 0;
        public const int TidBoolean = 1;
        public const int TidPosInt = 2;
        public const int TidNegInt = 3;
        public const int TidFloat = 4;
        public const int TidDecimal = 5;
        public const int TidTimestamp = 6;
        public const int TidSymbol = 7;
        public const int TidString = 8;
        public const int TidClob = 9;
        public const int TidBlob = 10; // a
        public const int TidList = 11; // b
        public const int TidSexp = 12; // c
        public const int TidStruct = 13; // d
        public const int TidTypedecl = 14; // e
        public const int TidUnused = 15; // f
        public const int TidDatagram = 16; // not a real type id
        public const int TidNopPad = 99; // not a real type id

        // TODO unify these
        public const int LnIsNull = 0x0f;

        public const int LnIsEmptyContainer = 0x00;
        public const int LnIsOrderedStruct = 0x01;
        public const int LnIsVarLen = 0x0e;

        public const int LnBooleanTrue = 0x01;
        public const int LnBooleanFalse = 0x00;
        public const int LnNumericZero = 0x00;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetTypeCode(int tid) => tid >> 4;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetLowNibble(int tid) => tid & 0xf;

        public const int Bvm10 = unchecked((int) 0xE00100EA);
    }
}
